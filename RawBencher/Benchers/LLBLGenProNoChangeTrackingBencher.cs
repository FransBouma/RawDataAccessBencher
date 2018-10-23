using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.TypedViewClasses;
using AdventureWorks.Dal.Adapter.HelperClasses;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing no-change tracking fetch
	/// </summary>bg
	public class LLBLGenProNoChangeTrackingBencher : FetchOnlyBencherBase<SohRow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNoChangeTrackingBencher"/> class.
		/// </summary>
		public LLBLGenProNoChangeTrackingBencher(string connectionString)
			: base(r => r.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
			RuntimeConfiguration.AddConnectionString("AdventureWorks.ConnectionString.SQL Server (SqlClient)", connectionString);
			RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c=>c.AddDbProviderFactory(typeof(System.Data.SqlClient.SqlClientFactory)));
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SohRow FetchIndividual(int key)
		{
			var toFetch = new SohTypedView();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchTypedView(toFetch, new RelationPredicateBucket(SohFields.SalesOrderId==key), true);
			}
			return toFetch.First();
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SohRow> FetchSet()
		{
			var headers = new SohTypedView();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchTypedView(headers, true);
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
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), DataTable based TypedView", typeof(DataAccessAdapterBase));
		}
	}
}
