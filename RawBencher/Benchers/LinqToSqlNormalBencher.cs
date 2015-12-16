#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L2S.Bencher;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Linq To Sql, doing normal fetch
	/// </summary>
	public class LinqToSqlNormalBencher : BencherBase<L2S.Bencher.EntityClasses.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LinqToSqlNormalBencher"/> class.
		/// </summary>
		public LinqToSqlNormalBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: true, usesCaching: false, supportsEagerLoading:true)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override L2S.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
		{
			using(var ctx = new L2SBencherDataContext())
			{
				return ctx.SalesOrderHeaders.FirstOrDefault(e => e.SalesOrderId == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<L2S.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
		{
			using(var ctx = new L2SBencherDataContext())
			{
				return ctx.SalesOrderHeaders.ToList();
			}
		}
		

		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<L2S.Bencher.EntityClasses.SalesOrderHeader> FetchGraph()
		{
			using(var ctx = new L2SBencherDataContext())
			{
				var loadOptions = new DataLoadOptions();
				loadOptions.LoadWith<L2S.Bencher.EntityClasses.SalesOrderHeader>(soh=>soh.SalesOrderDetails);
				loadOptions.LoadWith<L2S.Bencher.EntityClasses.SalesOrderHeader>(soh=>soh.Customer);
				ctx.LoadOptions = loadOptions;
				return (from soh in ctx.SalesOrderHeaders
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh).ToList();
			}
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(L2S.Bencher.EntityClasses.SalesOrderHeader parent, BenchResult resultContainer)
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
			resultContainer.IncNumberOfRowsForType(typeof(L2S.Bencher.EntityClasses.SalesOrderDetail), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId <= 0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(L2S.Bencher.EntityClasses.Customer), 1);
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Linq to Sql v{0} (v{1})", typeof(System.Data.Linq.DataContext));
		}
	}
}
#endif