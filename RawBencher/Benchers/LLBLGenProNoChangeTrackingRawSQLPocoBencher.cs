using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v52.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v52.TypedViewClasses;
using AdventureWorks.Dal.Adapter.v52.HelperClasses;
using AdventureWorks.Dal.Adapter.v52.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing no-change tracking fetch, using a Typed View poco with a Raw SQL query.
	/// </summary>
	public class LLBLGenProNoChangeTrackingRawSQLPocoBencher : BencherBase<SohQuerySpecPocoRow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNoChangeTrackingRawSQLPocoBencher"/> class.
		/// </summary>
		public LLBLGenProNoChangeTrackingRawSQLPocoBencher()
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
			var statement = this.CommandText + " WHERE SalesOrderID=@id";
			using(var adapter = new DataAccessAdapter())
			{
				return adapter.FetchQuery<SohQuerySpecPocoRow>(statement, new { id=key}).FirstOrDefault();
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
				return adapter.FetchQuery<SohQuerySpecPocoRow>(this.CommandText);
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), Poco with Raw SQL", typeof(DataAccessAdapterBase));
		}


		public string CommandText { get; set; }
	}
}
