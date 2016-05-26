using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v50.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v50.EntityClasses;
using AdventureWorks.Dal.Adapter.v50.FactoryClasses;
using AdventureWorks.Dal.Adapter.v50.HelperClasses;
using LinqToDB;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing normal fetch
	/// </summary>
	public class LLBLGenProNormalBencher : BencherBase<SalesOrderHeaderEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNormalBencher"/> class.
		/// </summary>
		public LLBLGenProNormalBencher() : base(e=>e.SalesOrderId, usesChangeTracking:true, usesCaching: false, supportsEagerLoading:true)
		{
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

