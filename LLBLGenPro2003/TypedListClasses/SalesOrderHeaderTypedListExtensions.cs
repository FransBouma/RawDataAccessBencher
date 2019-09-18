using System.Collections.Generic;

namespace LLBL2003.AdventureWorks2008.TypedListClasses
{
	public partial class SalesOrderHeaderTypedList : IEnumerable<SalesOrderHeaderRow>
	{
		IEnumerator<SalesOrderHeaderRow> IEnumerable<SalesOrderHeaderRow>.GetEnumerator()
		{
			foreach(var r in this.Rows)
			{
				yield return (SalesOrderHeaderRow)r;
			}
		}
	}
}