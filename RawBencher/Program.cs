using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RawBencher.Benchers;
using System.Threading;
using Dapper;
#if !DNXCORE50
using System.Configuration;
#endif
#if !(DNXCORE50 || DNX451)
using AdventureWorks.Dal.Adapter.v42.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v42.EntityClasses;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using SD.LLBLGen.Pro.ORMSupportClasses;
#endif

namespace RawBencher
{
	/// <summary>
	/// The actual bencher management code. Pass '/a' on the command line as argument to make the program exit automatically. If no argument
	/// is specified it will wait for ENTER after reporting the results. 
	/// </summary>
	public class Program
	{
		private const int LoopAmount = 25;
		private const int IndividualKeysAmount = 100;
		private const bool PerformSetBenchmarks = true;			// flag to signal whether the set fetch benchmarks have to be run.
		private const bool PerformIndividualBenchMarks = true;  // flag to signal whether the single element fetch benchmarks have to be run.
		private const bool ApplyAntiFloodForVMUsage = false;    // set to true if your target DB server is hosted on a VM, otherwise set it to false. Used in individual fetch bench.

#if DNXCORE50
		// have spoken to the corefx folks; currently no API for this in core-clr, but is a work-item
		public const string ConnectionString = "data source=nerd.sd.local;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096";
#else
		private static string ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks.ConnectionString.SQL Server (SqlClient)"].ConnectionString;
#endif
		private static string SqlSelectCommandText = @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber],[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID],[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate]	FROM [Sales].[SalesOrderHeader]";
		private static List<IBencher> RegisteredBenchers = new List<IBencher>();
		private static List<int> KeysForIndividualFetches = new List<int>();

		static void Main(string[] args)
		{
			bool autoExit = false;
			if(args.Length > 0)
			{
				autoExit = args[0] == "/a";
			}

			InitConnectionString();

#if !(DNXCORE50 || DNX451)
			CacheController.RegisterCache(ConnectionString, new ResultsetCache());
#endif

			RegisteredBenchers.Add(new HandCodedBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new HandCodedBencherUsingBoxing() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new RawDbDataReaderBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new DapperBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });

#if !DNXCORE50
			RegisteredBenchers.Add(new MassiveBencher());
			RegisteredBenchers.Add(new OrmLiteBencher() { ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
#endif

#if !(DNXCORE50 || DNX451)
			RegisteredBenchers.Add(new EntityFrameworkNoChangeTrackingBencher());
			RegisteredBenchers.Add(new EntityFrameworkNormalBencher());
			RegisteredBenchers.Add(new LinqToSqlNoChangeTrackingBencher());
			RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingLinqPocoBencher());
			RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingQuerySpecPocoBencher());
			RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingBencher());
			RegisteredBenchers.Add(new LLBLGenProResultsetCachingBencher());
			RegisteredBenchers.Add(new LLBLGenProNormalBencher());
			RegisteredBenchers.Add(new LinqToSqlNormalBencher());
			RegisteredBenchers.Add(new OakDynamicDbDtoBencher());
			RegisteredBenchers.Add(new OakDynamicDbNormalBencher());
			RegisteredBenchers.Add(new NHibernateNormalBencher());
			RegisteredBenchers.Add(new PetaPocoBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new PetaPocoFastBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
#endif








			DisplayHeader();
	
			WarmupDB();
			FetchKeysForIndividualFetches();

			// Uncomment the line below if you want to profile a bencher. Specify the bencher instance and follow the guides on the screen.
			//ProfileBenchers(RegisteredBenchers.FirstOrDefault(b => b.GetType() == typeof(MassiveBencher)));

			RunRegisteredBenchers();
			ReportResultStatistics(autoExit);
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

			
			Console.WriteLine( "+-------------------------------------------------------------------------------------------");
			Console.WriteLine( "| Raw Data Access / ORM Benchmarks.");
			Console.WriteLine(@"| Code available at              : https://github.com/FransBouma/RawDataAccessBencher");
			Console.WriteLine( "| Benchmarks run on              : {0}", DateTime.Now.ToString("F"));
			Console.WriteLine( "| Registered benchmarks          :");
			foreach(var bencher in RegisteredBenchers)
			{
				DisplayBencherInfo(bencher, "| \t", suffixWithDashLine:false);
			}
			Console.WriteLine( "| Run set benchmarks             : {0}", PerformSetBenchmarks);
			Console.WriteLine( "| Run individual fetch benchmarks: {0}", PerformIndividualBenchMarks);
			Console.WriteLine( "| Number of set fetches          : {0}", LoopAmount);
			Console.WriteLine( "| Number of individual keys      : {0}", IndividualKeysAmount);
			Console.WriteLine( "| Release build                  : {0}", releaseBuild);
#if !DNXCORE50 // there is a plan to add a new API equivalent to this; not released yet
			Console.WriteLine( "| Client OS                      : {0} ({1}bit)", Environment.OSVersion, Environment.Is64BitOperatingSystem ? "64" : "32" );
			Console.WriteLine( "| Bencher runs as 64bit          : {0}", Environment.Is64BitProcess);
			Console.WriteLine( "| CLR version                    : {0}", Environment.Version);
#else
			Console.WriteLine( "| ADO.NET version                    : {0}", Program.GetVersion(typeof(SqlConnection))); // kinda hacky
#endif
			Console.WriteLine( "| Number of CPUs                 : {0}", Environment.ProcessorCount);
			Console.WriteLine( "| Server used                    : {0}", conBuilder.DataSource);
			Console.WriteLine( "| Catalog used                   : {0}", conBuilder.InitialCatalog);
			Console.WriteLine( "| SQL Server version used        : {0}", sqlServerVersion);
			Console.WriteLine( "+-------------------------------------------------------------------------------------------\n");
		}

		public static Version GetVersion(Type type)
		{
			return GetAssembly(type).GetName().Version;
		}
		public static Assembly GetAssembly(Type type)
		{
#if DNXCORE50
			return type.GetTypeInfo().Assembly;
#else
			return type.Assembly;
#endif
		}


		/// <summary>
		/// Displays a pre-amble so the user can attach the .net profiler, then runs the benchers specified and then displays a text to stop profiling. 
		/// </summary>
		/// <param name="benchersToProfile">The benchers to profile.</param>
		private static void ProfileBenchers(params IBencher[] benchersToProfile)
		{
			// run the benchers before profiling. 
			foreach (var b in benchersToProfile)
			{
				if(b == null)
				{
					Console.WriteLine("The bencher you are trying to profile hasn't been registered. Can't continue.");
					return;
				}
				Console.WriteLine("Running set benchmark for bencher '{0}' before profiling to warm up constructs", b.CreateFrameworkName());
				b.PerformSetBenchmark();
			}

			Console.WriteLine("Attach profiler and press ENTER to continue");
			Console.ReadLine();
			foreach (var b in benchersToProfile)
			{
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
			}
			Console.WriteLine("Done. Grab snapshot and stop profiler. Press ENTER to continue.");
			Console.ReadLine();
		}


		private static void InitConnectionString()
		{
#if !(DNXCORE50 || DNX451) // DNX451 here is just because DataAccessAdapter not dragged over yet
			// Use the connection string from app.config instead of the static variable if the connection string exists
			var connectionStringFromConfig = ConfigurationManager.ConnectionStrings[DataAccessAdapter.ConnectionStringKeyName];
			if (connectionStringFromConfig != null)
			{
				ConnectionString = string.IsNullOrEmpty(connectionStringFromConfig.ConnectionString) ? ConnectionString : connectionStringFromConfig.ConnectionString;
			}
#endif
		}


		private static void FetchKeysForIndividualFetches()
		{
			using (var conn = new SqlConnection(ConnectionString))
			{
				KeysForIndividualFetches = conn.Query<int>(
					"select top {=count} SalesOrderId from AdventureWorks.Sales.SalesOrderHeader order by SalesOrderNumber",
					new { count = IndividualKeysAmount }).AsList();
			}
			if (KeysForIndividualFetches.Count != IndividualKeysAmount)
			{
				throw new InvalidOperationException("Can't fetch the keys for the individual benchmarks");
			}
		}


		private static void RunRegisteredBenchers()
		{
			Console.WriteLine("\nStarting benchmarks.");
			Console.WriteLine("====================================================================");

			foreach (var bencher in RegisteredBenchers)
			{
				DisplayBencherInfo(bencher);
				try
				{
					RunBencher(bencher);
				}
				catch(Exception ex)
				{
					DisplayException(ex);
				}
			}
		}


		private static void RunBencher(IBencher bencher)
		{
			bencher.ResetResults();
			Console.WriteLine("First one warm-up run to initialize constructs. Results will not be collected.");
			var result = bencher.PerformSetBenchmark(discardResults: true);
			ReportSetResult(bencher, result);
			Console.WriteLine("Starting bench runs...");
			if(PerformSetBenchmarks)
			{
				// set benches
				Console.WriteLine("Set fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformSetBenchmark();
					ReportSetResult(bencher, result);

					// avoid having the GC collect in the middle of a run.
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
				}
			}
			if (PerformIndividualBenchMarks)
			{
				// individual benches
				Console.WriteLine("Single element fetches");
				Console.WriteLine("-------------------------");
				for (int i = 0; i < LoopAmount; i++)
				{
					result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches);
					ReportIndividualResult(bencher, result);

					// avoid having the GC collect in the middle of a run.
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();

					if(ApplyAntiFloodForVMUsage)
					{
						// sleep is to avoid hammering the network layer on the target server. If the target server is a VM, it might stall once or twice
						// during benching, which is not what we want at it can skew the results a lot. In a very short time, a lot of queries are executed
						// on the target server (LoopAmount * IndividualKeysAmount), which will hurt performance on VMs with very fast frameworks in some
						// cases in some runs (so more than 2 runs are slow). 
#pragma warning disable CS0162
#if DNXCORE50
						throw new NotImplementedException(nameof(ApplyAntiFloodForVMUsage));
#else
						Thread.Sleep(400);
#endif
#pragma warning restore CS0162
					}
				}
			}
		}


		private static void WarmupDB()
		{
			IBencher dbWarmer;
#if DNXCORE50
			dbWarmer = new HandCodedBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };
#else
			dbWarmer = new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };
#endif

			Console.WriteLine("\nWarming up DB, DB client code and CLR");
			Console.WriteLine("====================================================================");
			DisplayBencherInfo(dbWarmer);
			for (int i = 0; i < LoopAmount; i++)
			{
				var result = dbWarmer.PerformSetBenchmark();
				ReportSetResult(dbWarmer, result);
			}
		}


		private static void DisplayBencherInfo(IBencher bencher)
		{
			DisplayBencherInfo(bencher, "\n", suffixWithDashLine: true);
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


		private static void ReportSetResult(IBencher bencher, BenchResult result)
		{
			Console.WriteLine("Number of elements fetched: {0}.\tFetch took: {1}ms.\tEnumerating result took: {2}ms",
								result.NumberOfRowsFetched, result.FetchTimeInMilliseconds, result.EnumerationTimeInMilliseconds);
		}


		private static void ReportIndividualResult(IBencher bencher, BenchResult result)
		{
			Console.WriteLine("Number of elements fetched individually: {0}.\tTotal time: {1}ms.\tTime per element: {2}ms",
								KeysForIndividualFetches.Count, result.FetchTimeInMilliseconds,
								(double)result.FetchTimeInMilliseconds / (double)KeysForIndividualFetches.Count);
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

			Console.WriteLine("Non-change tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
			Console.WriteLine("------------------------------------------------------------------------------");
			foreach(var bencher in RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.SetFetchMean))
			{
				Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean, 
									bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
			}

			Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), no caching", LoopAmount);
			Console.WriteLine("------------------------------------------------------------------------------");
			foreach(var bencher in RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.SetFetchMean))
			{
				Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean,
									bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
			}

			if(PerformIndividualBenchMarks)
			{
				Console.WriteLine("\nNon-change tracking individual fetches ({0} elements, {1} runs), no caching", IndividualKeysAmount, LoopAmount);
				Console.WriteLine("------------------------------------------------------------------------------");
				foreach(var bencher in RegisteredBenchers.Where(b => !b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.IndividualFetchMean))
				{
					Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount, 
															bencher.IndividualFetchSD / IndividualKeysAmount);
				}

				Console.WriteLine("\nChange tracking individual fetches ({0} elements, {1} runs), no caching", IndividualKeysAmount, LoopAmount);
				Console.WriteLine("------------------------------------------------------------------------------");
				foreach(var bencher in RegisteredBenchers.Where(b => b.UsesChangeTracking && !b.UsesCaching).OrderBy(b => b.IndividualFetchMean))
				{
					Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount,
															bencher.IndividualFetchSD / IndividualKeysAmount);
				}
			}

			Console.WriteLine("\nChange tracking fetches, set fetches ({0} runs), caching", LoopAmount);
			Console.WriteLine("------------------------------------------------------------------------------");
			foreach(var bencher in RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching).OrderBy(b => b.SetFetchMean))
			{
				Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms)\tEnum: {3:N2}ms ({4:N2}ms)", bencher.CreateFrameworkName(), bencher.SetFetchMean,
									bencher.SetFetchSD, bencher.EnumerationMean, bencher.EnumerationSD);
			}

			if(PerformIndividualBenchMarks)
			{
				Console.WriteLine("\nChange tracking individual fetches ({0} elements, {1} runs), caching", IndividualKeysAmount, LoopAmount);
				Console.WriteLine("------------------------------------------------------------------------------");
				foreach(var bencher in RegisteredBenchers.Where(b => b.UsesChangeTracking && b.UsesCaching).OrderBy(b => b.IndividualFetchMean))
				{
					Console.WriteLine("{0,-" + longestNameLength + "} : {1:N2}ms ({2:N2}ms) per individual fetch", bencher.CreateFrameworkName(), bencher.IndividualFetchMean / IndividualKeysAmount,
															bencher.IndividualFetchSD / IndividualKeysAmount);
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


		private static void DisplayException(Exception toDisplay)
		{
			if(toDisplay == null)
			{
				return;
			}

			Console.WriteLine("Exception caught of type: {0}", toDisplay.GetType().FullName);
			Console.WriteLine("Message: {0}", toDisplay.Message);
			Console.WriteLine("Stack trace:\n{0}", toDisplay.StackTrace);
			Console.WriteLine("Inner exception:");
			DisplayException(toDisplay.InnerException);
		}
	}
}
