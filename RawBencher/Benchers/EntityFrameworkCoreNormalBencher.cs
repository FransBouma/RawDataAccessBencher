using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore20.Bencher;
using Microsoft.EntityFrameworkCore;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Entity Framework Core, doing normal fetch
	/// </summary>
	public class EntityFrameworkCoreNormalBencher : BencherBase<EFCore20.Bencher.EntityClasses.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkCoreNormalBencher"/> class.
		/// </summary>
		public EntityFrameworkCoreNormalBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: true, usesCaching: false, supportsEagerLoading:true, supportsAsync:true)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override EFCore20.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
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
		public override IEnumerable<EFCore20.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
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
		public override IEnumerable<EFCore20.Bencher.EntityClasses.SalesOrderHeader> FetchGraph()
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return (from soh in ctx.SalesOrderHeaders
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh)
							.Include(x => x.SalesOrderDetails)
							.Include(x => x.Customer)
							.ToList();
			}
		}


		/// <summary>
		/// Async variant of FetchGraph(). Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override async Task<IEnumerable<EFCore20.Bencher.EntityClasses.SalesOrderHeader>> FetchGraphAsync()
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return await (from soh in ctx.SalesOrderHeaders
							  where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
							  select soh)
					.Include(x=>x.SalesOrderDetails)
					.Include(x=>x.Customer)
					.ToListAsync();
			}
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(EFCore20.Bencher.EntityClasses.SalesOrderHeader parent, BenchResult resultContainer)
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
			resultContainer.IncNumberOfRowsForType(typeof(EFCore20.Bencher.EntityClasses.SalesOrderDetail), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId <= 0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(EFCore20.Bencher.EntityClasses.Customer), 1);
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
