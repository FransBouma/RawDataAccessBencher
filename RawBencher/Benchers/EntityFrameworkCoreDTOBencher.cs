﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Bencher;
using EFCore.Dtos.DtoClasses;
using EFCore.Dtos.DtoClasses.SalesOrderHeaderDtoTypes;
using EFCore.Dtos.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Entity Framework Core, doing a DTO Graph fetch
	/// </summary>
	public class EntityFrameworkCoreDTOBencher : FetchOnlyBencherBase<SalesOrderHeaderDto>
	{
		private readonly PooledDbContextFactory<AWDataContext> pooledDbContextFactory;

		/// <summary>
		/// Initializes a new instance of the <see cref="EntityFrameworkCoreDTOBencher"/> class.
		/// </summary>
		public EntityFrameworkCoreDTOBencher(string connectionString)
			: base(e => e.SalesOrderId, usesChangeTracking:false, usesCaching:false, supportsAsync:true, supportsEagerLoading:true, supportsIndividualFetch:false, supportsSetFetch:false)
		{
			var options = new DbContextOptionsBuilder<AWDataContext>()
				.UseSqlServer(connectionString)
				.EnableThreadSafetyChecks(false)
				.Options;

			pooledDbContextFactory = new PooledDbContextFactory<AWDataContext>(options);
		}

		
		/// <summary>
		/// Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override IEnumerable<SalesOrderHeaderDto> FetchGraph()
		{
			using (var ctx = pooledDbContextFactory.CreateDbContext())
			{
				return (from soh in ctx.SalesOrderHeaders.AsQueryable() // Added AsQueryable() to help compiler choose extension method 
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh).ProjectToSalesOrderHeaderDto().ToList();
			}
		}


		/// <summary>
		/// Async variant of FetchGraph(). Fetches the complete graph using eager loading and returns this as an IEnumerable.
		/// </summary>
		/// <returns>the graph fetched</returns>
		public override async Task<IEnumerable<SalesOrderHeaderDto>> FetchGraphAsync()
		{
			using (var ctx = pooledDbContextFactory.CreateDbContext())
			{
				return await (from soh in ctx.SalesOrderHeaders.AsQueryable() // Added AsQueryable() to help compiler choose extension method 
							  where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
							  select soh).ProjectToSalesOrderHeaderDto().ToListAsync();
			}
		}


		/// <summary>
		/// Verifies the graph element's children. The parent should contain 2 sets of related elements: SalesOrderDetail and Customer. Both have to be counted and
		/// the count has to stored in the resultContainer, under the particular type. Implementers have to check whether the related elements are actually materialized objects.
		/// </summary>
		/// <param name="parent">The parent.</param>
		/// <param name="resultContainer">The result container.</param>
		public override void VerifyGraphElementChildren(SalesOrderHeaderDto parent, BenchResult resultContainer)
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
			resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetailDto), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId <= 0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(CustomerDto), 1);
		}

		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("Entity Framework Core v{0} (v{1}) Poco DTO Graph", typeof(Microsoft.EntityFrameworkCore.DbContext));
		}
	}
}
