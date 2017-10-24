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
		/// Performs the individual bench mark. This is a benchmark which fetches all SalesOrderHeader elements with the keys specified, individually.
		/// </summary>
		/// <param name="keys">The keys for all elements to fetch.</param>
		/// <param name="discardResults">if set to <c>true</c> the results are returned but are not collected.</param>
		/// <returns>
		/// A filled in benchmark result object, with the total time taken to fetch all elements of the keys specified. EnumerationTime is not set. Number of
		/// </returns>
		BenchResult PerformIndividualBenchMark(List<int> keys, bool discardResults);
		/// <summary>
		/// Performs the set benchmark. This is a benchmark which fetches the full set of sales order headers, enumerates it and returns the times it took
		/// to perform these actions as well as the number of rows read.
		/// </summary>
		/// <returns>A filled in benchmark result object</returns>
		BenchResult PerformSetBenchmark();
		/// <summary>
		/// Performs the set benchmark. This is a benchmark which fetches the full set of sales order headers, enumerates it and returns the times it took
		/// to perform these actions as well as the number of rows read.
		/// </summary>
		/// <param name="discardResults">if set to <c>true</c> the results are returned but are not collected.</param>
		/// <returns>
		/// A filled in benchmark result object
		/// </returns>
		BenchResult PerformSetBenchmark(bool discardResults);
		/// <summary>
		/// Performs the eager load benchmark. This is a benchmark which will fetch a 2-edge graph of 1000 sales order headers, all related customer entities and all related 
		/// sales order detail entities. 
		/// </summary>
		/// <returns>
		/// A filled in benchmark result object
		/// </returns>
		BenchResult PerformEagerLoadBenchmark();
		/// <summary>
		/// Performs the eager load benchmark. This is a benchmark which will fetch a 2-edge graph of 1000 sales order headers, all related customer entities and all related 
		/// sales order detail entities. 
		/// </summary>
		/// <param name="discardResults">if set to <c>true</c> the results are returned but are not collected.</param>
		/// <returns>
		/// A filled in benchmark result object
		/// </returns>
		BenchResult PerformEagerLoadBenchmark(bool discardResults);
		/// <summary>
		/// Performs the eager load benchmark, asynchronously. This is a benchmark which will fetch a 2-edge graph of 1000 sales order headers, all related customer entities and all related 
		/// sales order detail entities. It will use a Task.Run to perform the async code. 
		/// </summary>
		/// <param name="discardResults">if set to <c>true</c> the results are returned but are not collected.</param>
		/// <returns>
		/// A filled in benchmark result object
		/// </returns>
		BenchResult PerformAsyncEagerLoadBenchmark(bool discardResults);
		/// <summary>
		/// Resets the result containers of this bencher.
		/// </summary>
		void ResetResults();
		/// <summary>
		/// Calculates the averages from the results obtained through the benchmark methods. Requires at least 3 runs of the benchmark methods to produce
		/// valid results. Results are obtainable through the properties <see cref="IndividualFetchMean"/>, <see cref="SetFetchMean"/> and
		/// <see cref="EnumerationMean"/>.
		/// </summary>
		void CalculateStatistics();
		
		/// <summary>
		/// Gets the individual fetch average, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double IndividualFetchMean { get;}
		/// <summary>
		/// Gets the set fetch average, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double SetFetchMean { get; }
		/// <summary>
		/// Gets the enumeration average, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double EnumerationMean { get; }
		/// <summary>
		/// Gets the individual fetch standard deviation, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double IndividualFetchSD { get; }
		/// <summary>
		/// Gets the set fetch standard deviation, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double SetFetchSD { get;  }
		/// <summary>
		/// Gets the enumeration standard deviation, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double EnumerationSD { get; }
		/// <summary>
		/// Gets the eager load fetch mean, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double EagerLoadFetchMean { get; }
		/// <summary>
		/// Gets the eager load fetch standard deviation, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double EagerLoadFetchSD { get; }
		/// <summary>
		/// Gets the async eager load fetch mean, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double AsyncEagerLoadFetchMean { get; }
		/// <summary>
		/// Gets the async eager load fetch standard deviation, calculated by <see cref="CalculateStatistics"/>
		/// </summary>
		double AsyncEagerLoadFetchSD { get; }
		/// <summary>
		/// Gets a value indicating whether the fetch uses some form of caching (resultset caching, element caching)
		/// </summary>
		bool UsesCaching { get; }
		/// <summary>
		/// Gets a value indicating whether the fetch results in change tracked elements or not. 
		/// </summary>
		bool UsesChangeTracking { get; }
		/// <summary>
		/// Gets a value indicating whether this bencher supports eager loading. If true, this bencher will participate in eager loading benchmarks
		/// </summary>
		bool SupportsEagerLoading { get; }
		/// <summary>
		/// Gets a value indicating whether this bencher supports asynchronous tasks. If true, this bencher will participate in asynchronous benchmarks.
		/// </summary>
		bool SupportsAsync { get; }
		/// <summary>
		/// The total amount of bytes allocated when doing an individual fetch benchmark run
		/// </summary>
		long MemoryIndividualBenchmarks { get; set; }
		/// <summary>
		/// The total amount of bytes allocated when doing a set fetch benchmark run
		/// </summary>
		long MemorySetBenchmarks { get; set; }
		/// <summary>
		/// The total amount of bytes allocated when doing an eager load fetch benchmark run
		/// </summary>
		long MemoryEagerLoadBenchmarks { get; set; }
		/// <summary>
		/// The total amount of bytes allocated when doing an async eager load fetch benchmark run
		/// </summary>
		long MemoryAsyncEagerLoadBenchmarks { get; set; }
	}
}
