using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;
using Dapper;
using RawBencher.Benchers;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RawBencher
{
	/// <summary>
	/// The actual bencher management code. Pass '/a' on the command line as argument to make the program exit automatically. If no argument
	/// is specified it will wait for ENTER after reporting the results. 
	/// </summary>
	public class BenchController
	{
		private const int LoopAmount = 20;
		private const int IndividualKeysAmount = 1000;
		private const int InsertSetSize = 1000;			// insert this amount of elements during insert benchmarks.
		private const int InsertBatchSizeDefault = 60;
		private const int ProfileLoopAmount = 1;
		private const bool PerformSetInsertBenchmarks = true; // flag to signal whether the set insert benchmarks have to run. Not every bencher will perform this benchmark.
		private const bool PerformSetBenchmarks = false; // flag to signal whether the set fetch benchmarks have to be run.
		private const bool PerformIndividualBenchMarks = false; // flag to signal whether the single element fetch benchmarks have to be run.
		private const bool PerformEagerLoadBenchmarks = false; // flag to signal whether the eager load fetch benchmarks have to be run. Not every bencher will perform this benchmnark.
		private const bool PerformAsyncBenchmarks = false; // flag to signal whether the async fetch benchmarks have to be run. Not every bencher will perform this benchmark.
		private const bool ApplyAntiFloodForVMUsage = false; // set to true if your target DB server is hosted on a VM, otherwise set it to false. Used in individual fetch bench.

		private static string ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks.ConnectionString.SQL Server (SqlClient)"].ConnectionString;
		private static string SqlSelectCommandText = @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber],[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID],[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate] FROM [Sales].[SalesOrderHeader]";
		private static List<IBencher> RegisteredBenchers = new List<IBencher>();
		private static List<int> KeysForIndividualFetches = new List<int>();


		public static void Run(string[] args)
		{
			bool autoExit = false;
			if(args.Length > 0)
			{
				autoExit = args[0] == "/a";
			}
			BenchController.InitConnectionString();

			CacheController.RegisterCache(ConnectionString, new ResultsetCache());
			//RegisteredBenchers.Add(new HandCodedBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new NHibernateNormalBencher());
			// RegisteredBenchers.Add(new HandCodedBencherUsingBoxing() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new RawDbDataReaderBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			//RegisteredBenchers.Add(new EntityFrameworkCoreNoChangeTrackingBencher() {ConnectionStringToUse = ConnectionString});
			RegisteredBenchers.Add(new EntityFrameworkCoreNormalBencher() {ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new NPocoBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new LINQ2DBCompiledBencher(ConnectionString));
			// RegisteredBenchers.Add(new LINQ2DBNormalBencher(ConnectionString));
			//RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingRawSQLPocoBencher() {CommandText = SqlSelectCommandText});
			//RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingQuerySpecPocoBencher());
			//RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingLinqPocoBencher());
			//RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingBencher());
			//RegisteredBenchers.Add(new LLBLGenProResultsetCachingBencher());
			RegisteredBenchers.Add(new LLBLGenProNormalBencher());
			// RegisteredBenchers.Add(new DapperBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
   //          RegisteredBenchers.Add(new ChainBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
   //          RegisteredBenchers.Add(new ChainCompiledBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
   //          RegisteredBenchers.Add(new LinqToSqlNoChangeTrackingBencher());
			// RegisteredBenchers.Add(new LinqToSqlNormalBencher());
			// RegisteredBenchers.Add(new EntityFrameworkNoChangeTrackingBencher());
			// RegisteredBenchers.Add(new EntityFrameworkNormalBencher());
			// RegisteredBenchers.Add(new PetaPocoBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new PetaPocoFastBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new OrmLiteBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new DataTableBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString});
			// RegisteredBenchers.Add(new MassiveBencher());

			BenchController.DisplayHeader();
			BenchController.WarmupDB();
			BenchController.FetchKeysForIndividualFetches();

			// Uncomment the line below if you want to profile a bencher. Specify the bencher instance and follow the guides on the screen.
			//ProfileBenchers(RegisteredBenchers.FirstOrDefault(b => b.GetType() == typeof(LLBLGenProNormalBencher)));
			BenchController.RunRegisteredBenchers();
			BenchController.ReportResultStatistics(autoExit);
		}


		private static void DisplayHeader()
		{
			bool releaseBuild = true;
#if DEBUG
			releaseBuild = false;
#endif
			var conBuilder = new SqlConnectionStringBuilder(ConnectionString);
			string sqlServerVersion = "Unknown";
			using(var conForHeader = new SqlConnection(ConnectionString))
			{
				conForHeader.Open();
				sqlServerVersion = conForHeader.ServerVersion;
				conForHeader.Close();
			}

			Console.WriteLine("+-------------------------------------------------------------------------------------------");
			Console.WriteLine("| Raw Data Access / ORM Benchmarks.");
			Console.WriteLine(@"| Code available at              : https://github.com/FransBouma/RawDataAccessBencher");
			Console.WriteLine("| Benchmarks run on              : {0}", DateTime.Now.ToString("F"));
			Console.WriteLine("| Registered benchmarks          :");
			foreach(var bencher in RegisteredBenchers)
			{
				BenchController.DisplayBencherInfo(bencher, "| \t", suffixWithDashLine: false);
			}
			Console.WriteLine("| Run set benchmarks             : {0}", PerformSetBenchmarks);
			Console.WriteLine("| Run individual fetch benchmarks: {0}", PerformIndividualBenchMarks);
			Console.WriteLine("| Number of set fetches          : {0}", LoopAmount);
			Console.WriteLine("| Number of individual keys      : {0}", IndividualKeysAmount);
			Console.WriteLine("| Release build                  : {0}", releaseBuild);
			Console.WriteLine("| Client OS                      : {0} ({1}bit)", Environment.OSVersion, Environment.Is64BitOperatingSystem ? "64" : "32");
			Console.WriteLine("| Bencher runs as 64bit          : {0}", Environment.Is64BitProcess);
			Console.WriteLine("| CLR version                    : {0}", Environment.Version);
			Console.WriteLine("| Number of CPUs                 : {0}", Environment.ProcessorCount);
			Console.WriteLine("| Server used                    : {0}", conBuilder.DataSource);
			Console.WriteLine("| Catalog used                   : {0}", conBuilder.InitialCatalog);
			Console.WriteLine("| SQL Server version used        : {0}", sqlServerVersion);
			Console.WriteLine("+-------------------------------------------------------------------------------------------\n");
		}


		/// <summary>
		/// Displays a pre-amble so the user can attach the .net profiler, then runs the benchers specified and then displays a text to stop profiling. 
		/// </summary>
		/// <param name="benchersToProfile">The benchers to profile.</param>
		private static void ProfileBenchers(params IBencher[] benchersToProfile)
		{
			// run the benchers before profiling. 
			foreach(var b in benchersToProfile)
			{
				if(b == null)
				{
					Console.WriteLine("The bencher you are trying to profile hasn't been registered. Can't continue.");
					return;
				}
				Console.WriteLine("Running set benchmark for bencher '{0}' before profiling to warm up constructs", b.CreateFrameworkName());
				b.PerformSetBenchmark();
				b.PerformIndividualBenchMark(KeysForIndividualFetches);
				if(b.SupportsEagerLoading)
				{
					b.PerformEagerLoadBenchmark();
					if(b.SupportsAsync)
					{
						b.PerformAsyncEagerLoadBenchmark(discardResults:true);
					}
				}

				if(b.SupportsInserts)
				{
					b.PerformInsertSetBenchmark(InsertSetSize, InsertBatchSizeDefault, discardResults: true);
				}
			}

			Console.WriteLine("Attach profiler and press ENTER to continue");
			Console.ReadLine();
			for(int i = 0; i < ProfileLoopAmount; i++)
			{
				foreach(var b in benchersToProfile)
				{
					if(PerformSetInsertBenchmarks)
					{
						Console.WriteLine("Running set insert benchmark for profile for bencher: {0}.", b.CreateFrameworkName());
						b.PerformInsertSetBenchmark(InsertSetSize, InsertBatchSizeDefault);
					}
					if(PerformSetBenchmarks)
					{
						Console.WriteLine("Running set benchmark for profile for bencher: {0}. Change tracking: {1}", b.CreateFrameworkName(), b.UsesChangeTracking);
						b.PerformSetBenchmark();
					}
					if(PerformIndividualBenchMarks)
					{
						Console.WriteLine("Running individual fetch benchmark for profile for bencher: {0}. Change tracking: {1}", b.CreateFrameworkName(), b.UsesChangeTracking);
						b.PerformIndividualBenchMark(KeysForIndividualFetches);
					}
					if(PerformEagerLoadBenchmarks && b.SupportsEagerLoading)
					{
						Console.WriteLine("Running eager load fetch benchmark for profile for bencher: {0}. Change tracking: {1}", b.CreateFrameworkName(), b.UsesChangeTracking);
						b.PerformEagerLoadBenchmark();
					}
					if(PerformAsyncBenchmarks && b.SupportsEagerLoading && b.SupportsAsync)
					{
						Console.WriteLine("Running async eager load fetch benchmark for profile for bencher: {0}. Change tracking: {1}", b.CreateFrameworkName(), b.UsesChangeTracking);
						b.PerformAsyncEagerLoadBenchmark(discardResults: false);
					}
				}
			}
			Console.WriteLine("Done. Grab snapshot and stop profiler. Press ENTER to continue.");
			Console.ReadLine();
		}


		private static void InitConnectionString()
		{
			// Use the connection string from app.config instead of the static variable if the connection string exists
			var connectionStringFromConfig = ConfigurationManager.ConnectionStrings[DataAccessAdapter.ConnectionStringKeyName];
			if(connectionStringFromConfig != null)
			{
				ConnectionString = string.IsNullOrEmpty(connectionStringFromConfig.ConnectionString) ? ConnectionString : connectionStringFromConfig.ConnectionString;
			}
		}


		private static void FetchKeysForIndividualFetches()
		{
			using(var conn = new SqlConnection(ConnectionString))
			{
				KeysForIndividualFetches = conn.Query<int>("select top {=count} SalesOrderId from AdventureWorks.Sales.SalesOrderHeader order by SalesOrderNumber",
														   new {count = IndividualKeysAmount}).AsList();
			}
			if(KeysForIndividualFetches.Count != IndividualKeysAmount)
			{
				throw new InvalidOperationException("Can't fetch the keys for the individual benchmarks");
			}
		}


		private static void RunRegisteredBenchers()
		{
			Console.WriteLine("\nStarting benchmarks.");
			Console.WriteLine("====================================================================");

			foreach(var bencher in RegisteredBenchers)
			{
				BenchController.DisplayBencherInfo(bencher);
				try
				{
					BenchController.RunBencher(bencher);
				}
				catch(Exception ex)
				{
					BencherUtils.DisplayException(ex);
				}
			}
			
			Console.WriteLine("\nPerforming memory measurement runs.");
			Console.WriteLine("====================================================================");
			AppDomain.MonitoringIsEnabled = true;
			foreach(var bencher in RegisteredBenchers)
			{
				BenchController.DisplayBencherInfo(bencher);
				try
				{
					BenchController.RunMemoryAnalysisForBencher(bencher);
				}
				catch(Exception ex)
				{
					BencherUtils.DisplayException(ex);
				}
			}
		}
		

		private static void RunMemoryAnalysisForBencher(IBencher bencher)
		{
			Console.WriteLine("\nStarting bench runs...");
			BenchResult result;
			if(PerformSetBenchmarks)
			{
				// set benches
				Console.WriteLine("Set fetches");
				Console.WriteLine("-------------------------");
				result = bencher.PerformSetBenchmark(discardResults:true);
				BenchController.ReportMemoryUsageSetResult(result);
				bencher.MemorySetBenchmarks = result.NumberOfBytesAllocated;
				// avoid having the GC collect in the middle of a run.
				BenchController.ForceGCCollect();
			}
			if(PerformIndividualBenchMarks)
			{
				// individual benches
				Console.WriteLine("\nSingle element fetches");
				Console.WriteLine("-------------------------");
				result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches, discardResults:true);
				BenchController.ReportMemoryUsageIndividualResult(result);
				bencher.MemoryIndividualBenchmarks = result.NumberOfBytesAllocated;

				// avoid having the GC collect in the middle of a run.
				BenchController.ForceGCCollect();

				if(ApplyAntiFloodForVMUsage)
				{
					// sleep is to avoid hammering the network layer on the target server. If the target server is a VM, it might stall once or twice
					// during benching, which is not what we want at it can skew the results a lot. In a very short time, a lot of queries are executed
					// on the target server (LoopAmount * IndividualKeysAmount), which will hurt performance on VMs with very fast frameworks in some
					// cases in some runs (so more than 2 runs are slow). 
#pragma warning disable CS0162
					Thread.Sleep(400);
#pragma warning restore CS0162
				}
			}
			if(PerformEagerLoadBenchmarks && bencher.SupportsEagerLoading)
			{
				// eager load benches
				Console.WriteLine("\nEager Load fetches");
				Console.WriteLine("-------------------------");
				result = bencher.PerformEagerLoadBenchmark(discardResults:true);
				BenchController.ReportMemoryUsageEagerLoadResult(result);
				bencher.MemoryEagerLoadBenchmarks = result.NumberOfBytesAllocated;
				
				// avoid having the GC collect in the middle of a run.
				BenchController.ForceGCCollect();
			}
			if(PerformAsyncBenchmarks && bencher.SupportsEagerLoading && bencher.SupportsAsync)
			{
				// eager load benches
				Console.WriteLine("\nAsync eager Load fetches");
				Console.WriteLine("-------------------------");
				result = bencher.PerformAsyncEagerLoadBenchmark(discardResults: true);
				BenchController.ReportMemoryUsageEagerLoadResult(result);
				bencher.MemoryAsyncEagerLoadBenchmarks = result.NumberOfBytesAllocated;

				// avoid having the GC collect in the middle of a run.
				BenchController.ForceGCCollect();
			}

			if(PerformSetInsertBenchmarks && bencher.SupportsInserts)
			{
				// set inserts
				Console.WriteLine("Set inserts");
				Console.WriteLine("-------------------------");
				result = bencher.PerformInsertSetBenchmark(InsertSetSize, InsertBatchSizeDefault, discardResults:true);
				BenchController.ReportMemoryUsageInsertSetResult(result);
				bencher.MemorySetInsertBenchmarks = result.NumberOfBytesAllocated;
				// avoid having the GC collect in the middle of a run.
				BenchController.ForceGCCollect();
			}
		}


		private static void RunBencher(IBencher bencher)
		{
			bencher.ResetResults();
			Console.WriteLine("First one warm-up run of each bench type to initialize constructs. Results will not be collected.");
			var result = bencher.PerformSetBenchmark(discardResults: true);
			BenchController.ReportSetResult(result);
			if(bencher.SupportsEagerLoading)
			{
				result = bencher.PerformEagerLoadBenchmark(discardResults: true);
				BenchController.ReportEagerLoadResult(result);
				if(PerformAsyncBenchmarks && bencher.SupportsAsync)
				{
					result = bencher.PerformAsyncEagerLoadBenchmark(discardResults: true);
					BenchController.ReportEagerLoadResult(result);
				}
			}
			if(PerformIndividualBenchMarks)
			{
				result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches, discardResults: true);
				BenchController.ReportIndividualResult(result);
			}

			if(bencher.SupportsInserts && PerformSetInsertBenchmarks)
			{
				result = bencher.PerformInsertSetBenchmark(InsertSetSize, InsertBatchSizeDefault, discardResults: true);
				BenchController.ReportInsertSetResult(result);
			}
			Console.WriteLine("\nStarting bench runs...");
			if(PerformSetBenchmarks)
			{
				// set benches
				Console.WriteLine("Set fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformSetBenchmark();
					BenchController.ReportSetResult(result);

					// avoid having the GC collect in the middle of a run.
					BenchController.ForceGCCollect();
				}
			}
			if(PerformIndividualBenchMarks)
			{
				// individual benches
				Console.WriteLine("\nSingle element fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches);
					BenchController.ReportIndividualResult(result);

					// avoid having the GC collect in the middle of a run.
					BenchController.ForceGCCollect();

					if(ApplyAntiFloodForVMUsage)
					{
						// sleep is to avoid hammering the network layer on the target server. If the target server is a VM, it might stall once or twice
						// during benching, which is not what we want at it can skew the results a lot. In a very short time, a lot of queries are executed
						// on the target server (LoopAmount * IndividualKeysAmount), which will hurt performance on VMs with very fast frameworks in some
						// cases in some runs (so more than 2 runs are slow). 
#pragma warning disable CS0162
						Thread.Sleep(400);
#pragma warning restore CS0162
					}
				}
			}
			if(PerformEagerLoadBenchmarks && bencher.SupportsEagerLoading)
			{
				// eager load benches
				Console.WriteLine("\nEager Load fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformEagerLoadBenchmark();
					BenchController.ReportEagerLoadResult(result);

					// avoid having the GC collect in the middle of a run.
					BenchController.ForceGCCollect();
				}
			}
			if(PerformAsyncBenchmarks && bencher.SupportsEagerLoading && bencher.SupportsAsync)
			{
				// eager load benches
				Console.WriteLine("\nAsync eager Load fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformAsyncEagerLoadBenchmark(discardResults: false);
					BenchController.ReportEagerLoadResult(result);

					// avoid having the GC collect in the middle of a run.
					BenchController.ForceGCCollect();
				}
			}
			if(bencher.SupportsInserts && PerformSetInsertBenchmarks)
			{
				// set insert benches
				Console.WriteLine("Set Inserts");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformInsertSetBenchmark(InsertSetSize, InsertBatchSizeDefault);
					BenchController.ReportInsertSetResult(result);

					// avoid having the GC collect in the middle of a run.
					BenchController.ForceGCCollect();
				}
			}
		}


		private static void WarmupDB()
		{
			IBencher dbWarmer = new DataTableBencher() {CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString};
			Console.WriteLine("\nWarming up DB, DB client code and CLR");
			Console.WriteLine("====================================================================");
			BenchController.DisplayBencherInfo(dbWarmer);
			for(int i = 0; i < LoopAmount; i++)
			{
				var result = dbWarmer.PerformSetBenchmark();
				BenchController.ReportSetResult(result);
			}
		}


		private static void DisplayBencherInfo(IBencher bencher)
		{
			BenchController.DisplayBencherInfo(bencher, "\n", suffixWithDashLine: true);
		}


		private static void DisplayBencherInfo(IBencher bencher, string linePrefix, bool suffixWithDashLine)
		{
			Console.Write(linePrefix);
			Console.WriteLine("{0}. Change tracking: {1}. Caching: {2}.", bencher.CreateFrameworkName(), bencher.UsesChangeTracking, bencher.UsesCaching);
			if(suffixWithDashLine)
			{
				Console.WriteLine("--------------------------------------------------------------------------------------------");
			}
		}


		private static void ReportSetResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched: {1}.\tFetch took: {2:N2}ms.\tEnumerating result took: {3:N2}ms.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  result.ActionTimeInMilliseconds, result.EnumerationTimeInMilliseconds);
		}


		private static void ReportIndividualResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched individually: {1}.\tTotal time: {2:N2}ms.\tTime per element: {3:N2}ms", DateTime.Now, KeysForIndividualFetches.Count, 
							  result.ActionTimeInMilliseconds, result.ActionTimeInMilliseconds / KeysForIndividualFetches.Count);
		}


		private static void ReportEagerLoadResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched: {1} ({2}).\tFetch took: {3:N2}ms.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  string.Join(" + ", result.NumberOfRowsAffectedPerType.Select(kvp => kvp.Value).ToArray()), result.ActionTimeInMilliseconds);
		}

		
		private static void ReportMemoryUsageSetResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched: {1}.\tFetch took: {2:N2}ms.\tAllocated bytes: {3}.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  result.ActionTimeInMilliseconds, result.NumberOfBytesAllocated);
		}


		private static void ReportMemoryUsageIndividualResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched individually: {1}.\tTotal time: {2:N2}ms.\tAllocated bytes per element: {3}.", DateTime.Now, KeysForIndividualFetches.Count, 
							  result.ActionTimeInMilliseconds, result.NumberOfBytesAllocated);
		}


		private static void ReportMemoryUsageEagerLoadResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements fetched: {1} ({2}).\tFetch took: {3:N2}ms. Allocated bytes: {3}.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  string.Join(" + ", result.NumberOfRowsAffectedPerType.Select(kvp => kvp.Value).ToArray()), result.NumberOfBytesAllocated);
		}


		private static void ReportInsertSetResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements inserted as set: {1}.\tSet insert took: {2:N2}ms.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  result.ActionTimeInMilliseconds);
		}

		private static void ReportMemoryUsageInsertSetResult(BenchResult result)
		{
			Console.WriteLine("[{0:HH:mm:ss}] # of elements inserted as set: {1}.\tSet insert took: {2:N2}ms.\tAllocated bytes: {3}.", DateTime.Now, result.TotalNumberOfRowsAffected, 
							  result.ActionTimeInMilliseconds, result.NumberOfBytesAllocated);
		}
		

		/// <summary>
		/// Reports the resulting statistics (mean/standard deviation) to standard out
		/// </summary>
		/// <param name="autoExit">if set to <c>true</c> the method won't wait for ENTER to exit but will exit immediately.</param>
		private static void ReportResultStatistics(bool autoExit)
		{
			Console.WriteLine("\nResults per framework. Values are given as: 'mean (standard deviation)'");
			Console.WriteLine("==============================================================================");
			int longestNameLength = 0;
			foreach(var bencher in RegisteredBenchers)
			{
				string name = bencher.CreateFrameworkName();
				if(name.Length > longestNameLength)
				{
					longestNameLength = name.Length;
				}
				bencher.CalculateStatistics();
			}
			if(PerformSetBenchmarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.SetFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("Non-change tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean,
										  bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
					}
					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemorySetBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemorySetBenchmarks / 1024, 
										  bencher.MemorySetBenchmarks);
					}
				}
				benchersToList = RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.SetFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean,
										  bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
					}
					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemorySetBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemorySetBenchmarks / 1024, 
										  bencher.MemorySetBenchmarks);
					}
				}
			}
			if(PerformIndividualBenchMarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.IndividualFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nNon-change tracking individual fetches ({0} elements, {1} runs), no caching", IndividualKeysAmount, LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount,
										  bencher.IndividualFetchSD / IndividualKeysAmount);
					}
					
					Console.WriteLine("\nMemory usage, per individual element");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryIndividualBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryIndividualBenchmarks / 1024, 
										  bencher.MemoryIndividualBenchmarks);
					}
				}
				benchersToList = RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.IndividualFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nChange tracking individual fetches ({0} elements, {1} runs), no caching", IndividualKeysAmount, LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount,
										  bencher.IndividualFetchSD / IndividualKeysAmount);
					}
										
					Console.WriteLine("\nMemory usage, per individual element");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryIndividualBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryIndividualBenchmarks / 1024, 
										  bencher.MemoryIndividualBenchmarks);
					}
				}
			}
			if(PerformEagerLoadBenchmarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => b.SupportsEagerLoading && !b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.EagerLoadFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("Non-change tracking fetches, eager load fetches, 3-node split graph, 1000 root elements ({0} runs), no caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)", bencher.CreateFrameworkName(), bencher.EagerLoadFetchMean, bencher.EagerLoadFetchSD);
					}
									
					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryEagerLoadBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryEagerLoadBenchmarks / 1024, 
										  bencher.MemoryEagerLoadBenchmarks);
					}
				}
				benchersToList = RegisteredBenchers.Where(b => b.SupportsEagerLoading && b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.EagerLoadFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nChange tracking fetches, eager load fetches, 3-node split graph, 1000 root elements ({0} runs), no caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)", bencher.CreateFrameworkName(), bencher.EagerLoadFetchMean, bencher.EagerLoadFetchSD);
					}
									
					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryEagerLoadBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryEagerLoadBenchmarks / 1024, 
										  bencher.MemoryEagerLoadBenchmarks);
					}
				}
				benchersToList = RegisteredBenchers.Where(b => b.SupportsEagerLoading && b.SupportsAsync && b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.EagerLoadFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nAsync change tracking fetches, eager load fetches, 3-node split graph, 1000 root elements ({0} runs), no caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)", bencher.CreateFrameworkName(), bencher.AsyncEagerLoadFetchMean, bencher.AsyncEagerLoadFetchSD);
					}
														
					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryAsyncEagerLoadBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryAsyncEagerLoadBenchmarks / 1024, 
										  bencher.MemoryAsyncEagerLoadBenchmarks);
					}
				}
			}
			if(PerformSetBenchmarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching).OrderBy(b => b.SetFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), caching", LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean,
										  bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
					}

					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemorySetBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemorySetBenchmarks / 1024, 
										  bencher.MemorySetBenchmarks);
					}
				}
			}
			if(PerformIndividualBenchMarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching).OrderBy(b => b.IndividualFetchMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nChange tracking individual fetches ({0} elements, {1} runs), caching", IndividualKeysAmount, LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount,
										  bencher.IndividualFetchSD / IndividualKeysAmount);
					}
					
					Console.WriteLine("\nMemory usage, per individual element");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemoryIndividualBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemoryIndividualBenchmarks / 1024, 
										  bencher.MemoryIndividualBenchmarks);
					}
				}
			}
			if(PerformSetInsertBenchmarks)
			{
				var benchersToList = RegisteredBenchers.Where(b => b.SupportsInserts).OrderBy(b => b.SetInsertMean).ToList();
				if(benchersToList.Count > 0)
				{
					Console.WriteLine("\nSet inserts of {0} elements in one go ({1} runs)", InsertSetSize, LoopAmount);
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList)
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)", bencher.CreateFrameworkName(), bencher.SetInsertMean,
										  bencher.SetInsertSD);
					}

					Console.WriteLine("\nMemory usage, per iteration");
					Console.WriteLine("------------------------------------------------------------------------------");
					foreach(var bencher in benchersToList.OrderBy(b=>b.MemorySetInsertBenchmarks))
					{
						Console.WriteLine("{0,-" + longestNameLength + "} : {1:0,0} KB ({2:0,0} bytes)", bencher.CreateFrameworkName(), bencher.MemorySetInsertBenchmarks / 1024, 
										  bencher.MemorySetInsertBenchmarks);
					}
				}
			}
			Console.Write("\nComplete.");
			if(autoExit)
			{
				return;
			}
			Console.WriteLine(" Press enter to exit.");
			Console.ReadLine();
		}


		private static void ForceGCCollect()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			GC.Collect();
		}
	}
}