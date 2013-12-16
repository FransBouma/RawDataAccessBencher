using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v41.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using SD.LLBLGen.Pro.ORMSupportClasses;
using RawBencher.Benchers;
using System.Threading;

namespace RawBencher
{
	class Program
	{
		private const int LoopAmount = 10;
		private const int IndividualKeysAmount = 100;
		private const bool PerformSetBenchmarks = true;			// flag to signal whether the set fetch benchmarks have to be run.
		private const bool PerformIndividualBenchMarks = false; // flag to signal whether the single element fetch benchmarks have to be run.

		private static Dictionary<string, List<long>> _rawResultsPerORM = new Dictionary<string, List<long>>();
		private static string ConnectionString = @"data source=WIN2008SQL2012\SQLEXPRESS;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096";
        private static string SqlSelectCommandText = @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber],[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID],[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate]  FROM [Sales].[SalesOrderHeader]";
		private static List<IBencher> RegisteredBenchers = new List<IBencher>();
		private static List<int> KeysForIndividualFetches = new List<int>();

		static void Main(string[] args)
		{
			InitConnectionString();

            CacheController.RegisterCache(ConnectionString, new ResultsetCache());

			RegisteredBenchers.Add(new HandCodedBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new RawDbDataReaderBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new EntityFrameworkNoChangeTrackingBencher());
			RegisteredBenchers.Add(new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new DapperBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
			RegisteredBenchers.Add(new EntityFrameworkNormalBencher());
			RegisteredBenchers.Add(new LinqToSqlNoChangeTrackingBencher());
			RegisteredBenchers.Add(new LinqToSqlNormalBencher());
			RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingBencher());
			RegisteredBenchers.Add(new LLBLGenProNormalBencher());
			RegisteredBenchers.Add(new LLBLGenProResultsetCachingBencher());
			RegisteredBenchers.Add(new NHibernateNormalBencher());
			RegisteredBenchers.Add(new OakDynamicDbNormalBencher());
			RegisteredBenchers.Add(new OrmLiteBencher() { ConnectionStringToUse = ConnectionString} );

			WarmupDB();
			FetchKeysForIndividualFetches();

			//ProfileBenchers(RegisteredBenchers.FirstOrDefault(b=>b.GetType()==typeof(EntityFrameworkNoChangeTrackingBencher)));

			RunRegisteredBenchers();

#warning REFACTOR
			Console.WriteLine("\nAveraged total results per framework");
			Console.WriteLine("------------------------------------------");
			CalculateFinalResultAverages();
            Console.WriteLine("\nComplete. Press enter to exit.");
            Console.ReadLine();
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
				Console.WriteLine("Running set benchmark for bencher '{0}' before profiling to warm up constructs", b.CreateFrameworkName());
				b.PerformSetBenchmark();
			}

			Console.WriteLine("Attach profiler and press ENTER to continue");
			Console.ReadLine();
			foreach(var b in benchersToProfile)
			{
				Console.WriteLine("Running set benchmark for profile for bencher: {0}. Change tracking: {1}", b.CreateFrameworkName(), b.UsesChangeTracking);
				b.PerformSetBenchmark();
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
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader
						.Select(()=>SalesOrderHeaderFields.SalesOrderId.ToValue<int>())
						.Limit(IndividualKeysAmount);
			KeysForIndividualFetches = new DataAccessAdapter().FetchQuery(q);
			if(KeysForIndividualFetches.Count < IndividualKeysAmount)
			{
				throw new InvalidOperationException("Can't fetch the keys for the individual benchmarks");
			}
		}


		private static void RunRegisteredBenchers()
		{
			Console.WriteLine("\nStarting benchmarks.");
			Console.WriteLine("====================================================================");
			Console.WriteLine("Do set benchmarks: {0}.\nDo single element benchmarks: {1}", PerformSetBenchmarks, PerformIndividualBenchMarks);
			_rawResultsPerORM.Clear();

			foreach(var bencher in RegisteredBenchers)
			{
				DisplayBencherInfo(bencher);
				RunBencher(bencher);
			}
		}


		private static void RunBencher(IBencher bencher)
		{
			if(PerformSetBenchmarks)
			{
				// set benches
				Console.WriteLine("Set fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					var result = bencher.PerformSetBenchmark();
					ReportSetResult(bencher, result);

					// avoid having the GC collect in the middle of a run.
					GC.Collect();
					Thread.Sleep(1000);
				}
			}
			if(PerformIndividualBenchMarks)
			{
				// individual benches
				Console.WriteLine("Single element fetches");
				Console.WriteLine("-------------------------");
				for(int i = 0; i < LoopAmount; i++)
				{
					var result = bencher.PerformIndividualBenchMark(KeysForIndividualFetches);
					ReportIndividualResult(bencher, result);

					// avoid having the GC collect in the middle of a run.
					GC.Collect();
					Thread.Sleep(1000);
				}
			}
		}


		private static void WarmupDB()
		{
			var dbWarmer = new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };

			Console.WriteLine("\nWarming up DB, DB client code and CLR");
			Console.WriteLine("====================================================================");
			DisplayBencherInfo(dbWarmer);
			for(int i = 0; i < LoopAmount; i++)
			{
				var result = dbWarmer.PerformSetBenchmark();
				ReportSetResult(dbWarmer, result);
			}
		}


		private static void DisplayBencherInfo(IBencher bencher)
		{
			Console.WriteLine("\n{0}. Change tracking: {1}. Caching: {2}.", bencher.CreateFrameworkName(), bencher.UsesChangeTracking, bencher.UsesCaching);
			Console.WriteLine("--------------------------------------------------------------------------------------------");
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


		private static void ReportResult(string frameworkName, long elapsedTimeInMs, int amountFetched)
		{
#warning REFACTOR
			Console.WriteLine("Fetched {0} objects using: '{1}'. Took: {2}ms", amountFetched, frameworkName, elapsedTimeInMs);
			List<long> container;
			if(!_rawResultsPerORM.TryGetValue(frameworkName, out container))
			{
				container = new List<long>();
				_rawResultsPerORM.Add(frameworkName, container);
			}
			container.Add(elapsedTimeInMs);
		}


		private static void CalculateFinalResultAverages()
		{
			foreach(var kvp in _rawResultsPerORM)
			{
				var results = kvp.Value;
				if(results.Count<=2)
				{
					Console.WriteLine("Not enough results: '{0}'", kvp.Key);
					continue;
				}

				// ignore slowest and fastest result, then calculate the average.
				results.Sort();
				long total = 0;
				for(int i = 1; i < results.Count - 1; i++)
				{
					total += results[i];

				}
				// safe, 2 or less results are not accepted as we have to skip fastest and slowest.
				var average = (double)total/(double)(results.Count-2);
				Console.WriteLine("Average results of '{0}' is: {1}ms", kvp.Key, average);
			}
		}
	}
}
