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
	/// Specific bencher for Entity Framework, doing no change tracking fetch
	/// </summary>
	public class EntityFrameworkCoreNoChangeTrackingBencher : BencherBase<EFCore20.Bencher.EntityClasses.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkCoreNoChangeTrackingBencher"/> class.
		/// </summary>
		public EntityFrameworkCoreNoChangeTrackingBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
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
				return ctx.SalesOrderHeaders.AsNoTracking().Single(e => e.SalesOrderId == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EFCore20.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
		{
			using(var ctx = new AWDataContext(this.ConnectionStringToUse))
			{
				return ctx.SalesOrderHeaders.AsNoTracking().ToList();
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
