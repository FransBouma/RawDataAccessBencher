using System.Collections.Generic;
using System.Linq;
using EFCore.Bencher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Entity Framework, doing no change tracking fetch
	/// </summary>
	public class EntityFrameworkCoreNoChangeTrackingBencher : FetchOnlyBencherBase<EFCore.Bencher.EntityClasses.SalesOrderHeader>
	{
		private readonly PooledDbContextFactory<AWDataContext> pooledDbContextFactory;

		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkCoreNoChangeTrackingBencher"/> class.
		/// </summary>
		public EntityFrameworkCoreNoChangeTrackingBencher(string connectionString)
			: base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
		{
			var options = new DbContextOptionsBuilder<AWDataContext>()
				.UseSqlServer(connectionString)
				.Options;

			pooledDbContextFactory = new PooledDbContextFactory<AWDataContext>(options);
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override EFCore.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
		{
			using (var ctx = pooledDbContextFactory.CreateDbContext())
			{
				return ctx.SalesOrderHeaders.AsNoTracking().Single(e => e.SalesOrderId == key);
			}
		}

		
		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EFCore.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
		{
			using (var ctx = pooledDbContextFactory.CreateDbContext())
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
	}
}
