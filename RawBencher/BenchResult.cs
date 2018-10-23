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
			this.NumberOfRowsAffectedPerType = new Dictionary<Type, int>();
		}


		public void IncNumberOfRowsForType(Type t, int amount)
		{
			int currentValue = 0;
			if(!this.NumberOfRowsAffectedPerType.TryGetValue(t, out currentValue))
			{
				currentValue = 0;
			}
			currentValue += amount;
			this.NumberOfRowsAffectedPerType[t] = currentValue;
		}

		#region Properties
		public double ActionTimeInMilliseconds { get; set; }
		public double EnumerationTimeInMilliseconds { get; set; }
		public long NumberOfBytesAllocated { get; set; }

		/// <summary>
		/// Gets the number of rows affected by the action, e.g. a fetch, in total. This is the aggregate of all values in NumberOfRowsAffectedPerType
		/// </summary>
		public int TotalNumberOfRowsAffected
		{
			get { return this.NumberOfRowsAffectedPerType.Sum(kvp=>kvp.Value); }
		}
		/// <summary>
		/// Gets or sets the the number of rows affected by the action per type in an eager load graph
		/// </summary>
		public Dictionary<Type, int> NumberOfRowsAffectedPerType { get; private set; }
		#endregion
	}
}
