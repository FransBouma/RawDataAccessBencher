﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.TypedViewClasses;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.Linq;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing no-change tracking fetch, using a Typed View poco with a linq query.
	/// </summary>
	public class LLBLGenProNoChangeTrackingLinqPocoBencher : FetchOnlyBencherBase<SohLinqPocoRow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNoChangeTrackingLinqPocoBencher"/> class.
		/// </summary>
		public LLBLGenProNoChangeTrackingLinqPocoBencher(string connectionString)
			: base(r => r.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
			RuntimeConfiguration.AddConnectionString("AdventureWorks.ConnectionString.SQL Server (SqlClient)", connectionString);
			RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c=>c.AddDbProviderFactory(typeof(Microsoft.Data.SqlClient.SqlClientFactory)));
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SohLinqPocoRow FetchIndividual(int key)
		{
			using(var adapter = new DataAccessAdapter())
			{
				var metaData = new LinqMetaData(adapter);
				return metaData.SohLinqPoco.FirstOrDefault(s => s.SalesOrderId == key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SohLinqPocoRow> FetchSet()
		{
			using(var adapter = new DataAccessAdapter())
			{
				var metaData = new LinqMetaData(adapter);
				return metaData.SohLinqPoco.ToList();
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), Poco typed view with Linq", typeof(DataAccessAdapterBase));
		}
	}
}
