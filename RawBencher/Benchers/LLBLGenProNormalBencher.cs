﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.EntityClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.HelperClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing normal fetch
	/// </summary>
	public class LLBLGenProNormalBencher : BencherBase<SalesOrderHeaderEntity, CreditCardEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNormalBencher"/> class.
		/// </summary>
		public LLBLGenProNormalBencher(string connectionString) 
					: base(e=>e.SalesOrderId, l=>l.CreditCardId, usesChangeTracking:true, usesCaching: false, supportsEagerLoading:true, supportsAsync:true, supportsInserts:true)
		{
			EntityBase2.MarkSavedEntitiesAsFetched = true;
			RuntimeConfiguration.AddConnectionString("AdventureWorks.ConnectionString.SQL Server (SqlClient)", connectionString);
			RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c=>c.AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory)));
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeaderEntity FetchIndividual(int key)
		{
			var toFetch = new SalesOrderHeaderEntity();
			toFetch.SalesOrderId = key;
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntity(toFetch);
			}
			return toFetch;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeaderEntity> FetchSet()
		{
			var headers = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(headers, null);
			}
			return headers;
		}


		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<SalesOrderHeaderEntity> FetchGraph()
		{
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader
								.Where((SalesOrderHeaderFields.SalesOrderId > 50000).And(SalesOrderHeaderFields.SalesOrderId <= 51000))
								.WithPath(SalesOrderHeaderEntity.PrefetchPathSalesOrderDetails, SalesOrderHeaderEntity.PrefetchPathCustomer);
			var toReturn = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchQuery(q, toReturn);
			}
			return toReturn;
		}


		/// <summary>
		/// Async variant of FetchGraph(). Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override async Task<IEnumerable<SalesOrderHeaderEntity>> FetchGraphAsync()
		{
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader
								.Where((SalesOrderHeaderFields.SalesOrderId > 50000).And(SalesOrderHeaderFields.SalesOrderId <= 51000))
								.WithPath(SalesOrderHeaderEntity.PrefetchPathSalesOrderDetails, SalesOrderHeaderEntity.PrefetchPathCustomer);
			var toReturn = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				await adapter.FetchQueryAsync(q, toReturn);
			}
			return toReturn;
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(SalesOrderHeaderEntity parent, BenchResult resultContainer)
		{
			int amount = 0;
			foreach(var sod in parent.SalesOrderDetails)
			{
				if(sod.SalesOrderId > 0)
				{
					amount++;
				}
				else
				{
					return;
				}
			}
			resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetailEntity), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId<=0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(CustomerEntity), 1);
		}


		public override IEnumerable<CreditCardEntity> CreateSetForInserts(int amountToInsert)
		{
			var toReturn = new EntityCollection<CreditCardEntity>();
			for(int i = 0; i < amountToInsert; i++)
			{
				toReturn.Add(new CreditCardEntity()
							 {
								 CardNumber = Guid.NewGuid().ToString("N").Substring(0, 24), // we need a unique string, as there's a unique index on this field. This is semi unique... 
								 CardType = "Vista",
								 ExpMonth = 11,
								 ExpYear=2018,
								 ModifiedDate = DateTime.Now
							 });
			}
			return toReturn;
		}


		public override void InsertSet(IEnumerable<CreditCardEntity> toInsert, int batchSize)
		{
			using(var adapter = new DataAccessAdapter())
			{
				adapter.BatchSize = batchSize;
				adapter.SaveEntityCollection(toInsert as EntityCollection<CreditCardEntity>, false, false);
			}
		}


		protected override IEnumerable<CreditCardEntity> FetchInserted(int amountInserted)
		{
			var toReturn = new EntityCollection<CreditCardEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(toReturn, new RelationPredicateBucket(CreditCardFields.CreditCardId.GreaterThan(19237)));
			}
			return toReturn;
		}


		protected override void DeleteInserted(IEnumerable<CreditCardEntity> toDelete)
		{
			using(var adapter = new DataAccessAdapter())
			{
				adapter.DeleteEntitiesDirectly(typeof(CreditCardEntity), new RelationPredicateBucket(CreditCardFields.CreditCardId.GreaterThan(19237)));
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1})", typeof(DataAccessAdapterBase));
		}
	}
}

