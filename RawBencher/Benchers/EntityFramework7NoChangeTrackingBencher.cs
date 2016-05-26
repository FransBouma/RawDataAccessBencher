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
	/// Specific bencher for Entity Framework, doing no change tracking fetch
	/// </summary>
	public class EntityFramework7NoChangeTrackingBencher : BencherBase<EF7.Bencher.Model.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkNoChangeTrackingBencher"/> class.
		/// </summary>
		public EntityFramework7NoChangeTrackingBencher()
			: base(e => e.SalesOrderID, usesChangeTracking: false, usesCaching: false)
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
				return ctx.SalesOrderHeader.AsNoTracking().Single(e => e.SalesOrderID == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EF7.Bencher.Model.SalesOrderHeader> FetchSet()
		{
			using(var ctx = new AdventureWorksContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeader.AsNoTracking().ToList();
			}
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
