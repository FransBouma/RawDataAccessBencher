#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
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
			: base(e => e.SalesOrderId, usesChangeTracking: true, usesCaching: false)
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