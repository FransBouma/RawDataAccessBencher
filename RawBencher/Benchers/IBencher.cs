using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Interface used with a bencher implementation
	/// </summary>
	public interface IBencher
	{
		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		string CreateFrameworkName();
		/// <summary>
		/// Performs the individual bench mark. This is a benchmark which fetches all SalesOrderHeader elements with the keys specified, individually.
		/// </summary>
		/// <param name="keys">The keys for all elements to fetch.</param>
		/// <returns>
		/// A filled in benchmark result object, with the total time taken to fetch all elements of the keys specified. EnumerationTime is not set. Number of
		/// </returns>
		BenchResult PerformIndividualBenchMark(List<int> keys);
		/// <summary>
		/// Performs the set benchmark. This is a benchmark which fetches the full set of sales order headers, enumerates it and returns the times it took
		/// to perform these actions as well as the number of rows read.
		/// </summary>
		/// <returns>A filled in benchmark result object</returns>
		BenchResult PerformSetBenchmark();
		/// <summary>
		/// Resets the result containers of this bencher.
		/// </summary>
		void ResetResults();
		/// <summary>
		/// Calculates the averages from the results obtained through the benchmark methods. Requires at least 3 runs of the benchmark methods to produce
		/// valid results. Results are obtainable through the properties <see cref="IndividualFetchAverage"/>, <see cref="SetFetchAverage"/> and
		/// <see cref="EnumerationAverage"/>.
		/// </summary>
		void CalculateAverages();
		
		/// <summary>
		/// Gets the individual fetch average, calculated by <see cref="CalculateAverages"/>
		/// </summary>
		double IndividualFetchAverage { get;}
		/// <summary>
		/// Gets the set fetch average, calculated by <see cref="CalculateAverages"/>
		/// </summary>
		double SetFetchAverage { get; }
		/// <summary>
		/// Gets the enumeration average, calculated by <see cref="CalculateAverages"/>
		/// </summary>
		double EnumerationAverage { get; }
		/// <summary>
		/// Gets a value indicating whether the fetch uses some form of caching (resultset caching, element caching)
		/// </summary>
		bool UsesCaching { get; }
		/// <summary>
		/// Gets a value indicating whether the fetch results in change tracked elements or not. 
		/// </summary>
		bool UsesChangeTracking { get; }
	}
}
