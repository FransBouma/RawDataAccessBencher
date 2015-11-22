#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF7.Bencher.Model;

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
			: base(e => e.SalesOrderID, usesChangeTracking: true, usesCaching: false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override EF7.Bencher.Model.SalesOrderHeader FetchIndividual(int key)
		{
			using(var ctx = new AdventureWorksContext())
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
            using (var ctx = new AdventureWorksContext())
            {
                return ctx.SalesOrderHeader.ToList();
            }
        }


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Entity Framework v{0} (v{1})", typeof(Microsoft.Data.Entity.DbContext));
		}
	}
}
#endif