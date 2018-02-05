using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v54.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v54.EntityClasses;
using AdventureWorks.Dal.Adapter.v54.FactoryClasses;
using AdventureWorks.Dal.Adapter.v54.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing a resultset caching backed fetch
	/// </summary>
	public class LLBLGenProResultsetCachingBencher : BencherBase<SalesOrderHeaderEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProResultsetCachingBencher"/> class.
		/// </summary>
		public LLBLGenProResultsetCachingBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: true, usesCaching: true)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeaderEntity FetchIndividual(int key)
		{
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader
							.Where(SalesOrderHeaderFields.SalesOrderId == key)
							.CacheResultset(10);

			using(var adapter = new DataAccessAdapter())
			{
				return adapter.FetchFirst(q);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeaderEntity> FetchSet()
		{
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader
						.CacheResultset(10);

			var headers = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchQuery(q, headers);
			}
			return headers;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1})", typeof(DataAccessAdapterBase));
		}
	}
}
