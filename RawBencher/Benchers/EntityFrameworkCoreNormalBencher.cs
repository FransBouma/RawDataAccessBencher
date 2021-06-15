using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Bencher;
using EFCore.Bencher.EntityClasses;
using Microsoft.EntityFrameworkCore;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Entity Framework Core, doing normal fetch
	/// </summary>
	public class EntityFrameworkCoreNormalBencher : BencherBase<EFCore.Bencher.EntityClasses.SalesOrderHeader, EFCore.Bencher.EntityClasses.CreditCard>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkCoreNormalBencher"/> class.
		/// </summary>
		public EntityFrameworkCoreNormalBencher()
			: base(e => e.SalesOrderId, l=>l.CreditCardId, usesChangeTracking: true, usesCaching: false, supportsEagerLoading:true, supportsAsync:true, supportsInserts:true)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override EFCore.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeaders.Single(e => e.SalesOrderId == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
		{
			using (var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeaders.ToList();
			}
		}



		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader> FetchGraph()
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return (from soh in ctx.SalesOrderHeaders.AsQueryable()      // Added AsQueryable() to help compiler choose extension method 
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh)
							.Include(x => x.SalesOrderDetails)
							.Include(x => x.Customer)
#if NET5_0_OR_GREATER
                            .AsSplitQuery()  // EF Core 5 recommends AsSplitQuery() when having more than 1 Include to avoid cartesian product in select 
#endif
							.ToList();
			}
		}


		/// <summary>
		/// Async variant of FetchGraph(). Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override async Task<IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader>> FetchGraphAsync()
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return await (from soh in ctx.SalesOrderHeaders.AsQueryable()  // Added AsQueryable() to help compiler choose extension method 
							  where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
							  select soh)
					.Include(x=>x.SalesOrderDetails)
					.Include(x=>x.Customer)
#if NET5_0_OR_GREATER
                    .AsSplitQuery()   // EF Core 5 recommends AsSplitQuery() when having more than 1 Include to avoid cartesian product in select 
#endif
					.ToListAsync();
			}
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(EFCore.Bencher.EntityClasses.SalesOrderHeader parent, BenchResult resultContainer)
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
			resultContainer.IncNumberOfRowsForType(typeof(EFCore.Bencher.EntityClasses.SalesOrderDetail), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId <= 0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(EFCore.Bencher.EntityClasses.Customer), 1);
		}


		public override IEnumerable<CreditCard> CreateSetForInserts(int amountToInsert)
		{
			var toReturn = new List<CreditCard>();
			for(int i = 0; i < amountToInsert; i++)
			{
				toReturn.Add(new CreditCard()
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


		protected override IEnumerable<CreditCard> FetchInserted(int amountInserted)
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
                // Added AsQueryable() to help compiler choose extension method 
				return ctx.CreditCards.AsQueryable().Where(c => c.CreditCardId > 19237).ToList();
			}
		}


		protected override void DeleteInserted(IEnumerable<CreditCard> toDelete)
		{
			//using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			//{
			//	ctx.CreditCards.RemoveRange(toDelete);
			//	ctx.SaveChanges();
			//}

			// the above code is terribly slow, so we'll issue a direct SQL statement using SqlClient here, it otherwise takes multiple seconds for EF to delete the 1000 entities.
			using(var con = new System.Data.SqlClient.SqlConnection(this.ConnectionStringToUse))
			{
				var cmd = con.CreateCommand();
				cmd.CommandText = "DELETE FROM Sales.CreditCard WHERE CreditCardId > 19237";
				con.Open();
				cmd.ExecuteNonQuery();
				con.Close();
			}
		}


		public override void InsertSet(IEnumerable<CreditCard> toInsert, int batchSize)
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse, batchSize))
			{
				ctx.CreditCards.AddRange(toInsert);
				ctx.SaveChanges();
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Entity Framework Core v{0} (v{1})", typeof(Microsoft.EntityFrameworkCore.DbContext));
		}


		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion

	}
}
