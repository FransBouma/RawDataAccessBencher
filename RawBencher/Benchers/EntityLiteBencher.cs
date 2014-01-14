using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inercya.EntityLite;

namespace RawBencher.Benchers
{
    class EntityLiteBencher: BencherBase<EntityLite.Model.SalesOrderHeader>
	{
		/// <summary>
        /// Initializes a new instance of the <see cref="EntityLiteBencher" /> class.
		/// </summary>
        public EntityLiteBencher()
			: base(e => e.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
		}
		
		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
        public override EntityLite.Model.SalesOrderHeader FetchIndividual(int key)
		{
			using (var ds = new EntityLite.Model.AdventureWorksDataService())
            {
                return ds.SalesOrderHeaderRepository
                    .Query(Projection.BaseTable)
                    .Where(EntityLite.Model.SalesOrderHeaderFields.SalesOrderId, key)
                    .FirstOrDefault();
                    
            }
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<EntityLite.Model.SalesOrderHeader> FetchSet()
		{
            using (var ds = new EntityLite.Model.AdventureWorksDataService())
            {
                return ds.SalesOrderHeaderRepository
                    .Query(Projection.BaseTable)
                    .ToList();
            }
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return "EntityLite 1.0.10-Beta";
		}
	}
}
