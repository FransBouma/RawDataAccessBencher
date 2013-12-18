using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher
{
	/// <summary>
	/// Contains the results of a single benchmark method run.
	/// </summary>
	public class BenchResult
	{
		public long FetchTimeInMilliseconds { get; set; }
		public long EnumerationTimeInMilliseconds { get; set; }
		public int NumberOfRowsFetched { get; set; }
	}
}
