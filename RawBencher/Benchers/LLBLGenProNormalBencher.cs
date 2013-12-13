using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v41.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing normal fetch
	/// </summary>
	public class LLBLGenProNormalBencher : BencherBase<SalesOrderHeaderEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNormalBencher"/> class.
		/// </summary>
		public LLBLGenProNormalBencher() : base(e=>e.SalesOrderId, usesChangeTracking:true, usesCaching: false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeaderEntity FetchIndividual(int key)
		{
			var toFetch = new SalesOrderHeaderEntity();
			toFetch.SalesOrderId = key;
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntity(toFetch);
			}
			return toFetch;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeaderEntity> FetchSet()
		{
			var headers = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(headers, null);
			}
			return headers;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		public override string CreateFrameworkName()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1})", typeof(DataAccessAdapterBase));
		}
	}
}
