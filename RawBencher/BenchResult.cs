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
		public BenchResult()
		{
			this.NumberOfRowsFetchedPerType = new Dictionary<Type, int>();
		}


		public void IncNumberOfRowsForType(Type t, int amount)
		{
			int currentValue = 0;
			if(!this.NumberOfRowsFetchedPerType.TryGetValue(t, out currentValue))
			{
				currentValue = 0;
			}
			currentValue += amount;
			this.NumberOfRowsFetchedPerType[t] = currentValue;
		}

		#region Properties
		public double FetchTimeInMilliseconds { get; set; }
		public double EnumerationTimeInMilliseconds { get; set; }

		/// <summary>
		/// Gets the number of rows fetched in total. This is the aggregate of all values in NumberOfRowsFetchedPerType
		/// </summary>
		public int TotalNumberOfRowsFetched
		{
			get { return this.NumberOfRowsFetchedPerType.Sum(kvp=>kvp.Value); }
		}
		/// <summary>
		/// Gets or sets the the number of rows fetched per type in an eager load graph
		/// </summary>
		public Dictionary<Type, int> NumberOfRowsFetchedPerType { get; private set; }
		#endregion
	}
}
