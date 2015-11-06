#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v42.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v42.TypedViewClasses;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing no-change tracking fetch, using a Typed View poco with a queryspec query.
	/// </summary>
	public class LLBLGenProNoChangeTrackingQuerySpecPocoBencher : BencherBase<SohQuerySpecPocoRow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNoChangeTrackingQuerySpecPocoBencher"/> class.
		/// </summary>
		public LLBLGenProNoChangeTrackingQuerySpecPocoBencher()
			: base(r => r.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SohQuerySpecPocoRow FetchIndividual(int key)
		{
			var qf = new QueryFactory();
			var q = qf.SohQuerySpecPoco
							.Where(SohQuerySpecPocoFields.SalesOrderId == key)
							.Limit(1);
			using(var adapter = new DataAccessAdapter())
			{
				return adapter.FetchFirst(q);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SohQuerySpecPocoRow> FetchSet()
		{
			using(var adapter = new DataAccessAdapter())
			{
				return adapter.FetchQuery(new QueryFactory().SohQuerySpecPoco);
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), Poco typed view with QuerySpec", typeof(DataAccessAdapterBase));
		}
	}
}
#endif