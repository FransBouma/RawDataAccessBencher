using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.FactoryClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;
using LLBL2003.AdventureWorks2008.TypedListClasses;
using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro 2003, doing no-change tracking fetch
	/// </summary>bg
	public class LLBLGenPro2003NoChangeTrackingBencher : FetchOnlyBencherBase<SalesOrderHeaderRow>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNoChangeTrackingBencher"/> class.
		/// </summary>
		public LLBLGenPro2003NoChangeTrackingBencher(string connectionString)
			: base(r => r.SalesOrderID, usesChangeTracking:false, usesCaching:false)
		{
			DbUtils.ConnectionStringToUse = connectionString;
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeaderRow FetchIndividual(int key)
		{
			var sohTL = new SalesOrderHeaderTypedList();
			sohTL.Fill(0, null, true, new PredicateExpression(new FieldCompareValuePredicate(EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderID), ComparisonOperator.Equal, key)));
			return sohTL.Rows[0] as SalesOrderHeaderRow;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeaderRow> FetchSet()
		{
			var sohTL = new SalesOrderHeaderTypedList();
			sohTL.Fill();
			return sohTL;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), DataTable based TypedList", typeof(DataAccessAdapterBase));
		}
	}
}
