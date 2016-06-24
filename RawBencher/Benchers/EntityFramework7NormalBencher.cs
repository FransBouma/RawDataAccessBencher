using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF7.Bencher.Model;
using Microsoft.EntityFrameworkCore;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Entity Framework, doing normal fetch
	/// </summary>
	public class EntityFramework7NormalBencher : BencherBase<EF7.Bencher.Model.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkNormalBencher"/> class.
		/// </summary>
		public EntityFramework7NormalBencher()
			: base(e => e.SalesOrderID, usesChangeTracking: true, usesCaching: false, supportsEagerLoading:true, supportsAsync:true)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override EF7.Bencher.Model.SalesOrderHeader FetchIndividual(int key)
		{
			using(var ctx = new AdventureWorksContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeader.Single(e => e.SalesOrderID == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EF7.Bencher.Model.SalesOrderHeader> FetchSet()
		{
			using (var ctx = new AdventureWorksContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeader.ToList();
			}
		}



		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<EF7.Bencher.Model.SalesOrderHeader> FetchGraph()
		{
			using(var ctx = new AdventureWorksContext(this.ConnectionStringToUse))
			{
				return (from soh in ctx.SalesOrderHeader
						where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
						select soh)
							.Include(x => x.SalesOrderDetail)
							.Include(x => x.Customer)
							.ToList();
			}
		}


		/// <summary>
		/// Async variant of FetchGraph(). Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override async Task<IEnumerable<EF7.Bencher.Model.SalesOrderHeader>> FetchGraphAsync()
		{
			using(var ctx = new AdventureWorksContext(this.ConnectionStringToUse))
			{
				return await (from soh in ctx.SalesOrderHeader
							  where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
							  select soh)
					.Include(x=>x.SalesOrderDetail)
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
		public override void VerifyGraphElementChildren(EF7.Bencher.Model.SalesOrderHeader parent, BenchResult resultContainer)
		{
			int amount = 0;
			foreach(var sod in parent.SalesOrderDetail)
			{
				if(sod.SalesOrderID > 0)
				{
					amount++;
				}
				else
				{
					return;
				}
			}
			resultContainer.IncNumberOfRowsForType(typeof(EF7.Bencher.Model.SalesOrderDetail), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerID <= 0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(EF7.Bencher.Model.Customer), 1);
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Entity Framework v{0} (v{1})", typeof(Microsoft.EntityFrameworkCore.DbContext));
		}


		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion

	}
}
