using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using LLBL2003.AdventureWorks2008.EntityClasses;

namespace LLBL2003.AdventureWorks2008.CollectionClasses
{
	public partial class SalesOrderHeaderCollection : IEnumerable<SalesOrderHeaderEntity>
	{
		public IEnumerator<SalesOrderHeaderEntity> GetEnumerator()
		{
			foreach(var e in base.InnerList.Cast<SalesOrderHeaderEntity>())
			{
				yield return e;
			}
		}
	}
}