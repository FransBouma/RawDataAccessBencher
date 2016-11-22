using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Threading;
using AdventureWorks.Dal.Adapter.v51.DatabaseSpecific;
using BenchmarkDotNet.Attributes;
using Dapper;
using RawBencher.Benchers;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace RawBencher.BenchmarkDotNet
{
	/// <summary>
	/// Controller used for BenchmarkDotNet
	/// </summary>
	public class BenchmarkDotNetController
	{
		private const int LoopAmount = 25;
		private const int IndividualKeysAmount = 100;
		private const bool PerformSetBenchmarks = true;			// flag to signal whether the set fetch benchmarks have to be run.
		private const bool PerformIndividualBenchMarks = true;  // flag to signal whether the single element fetch benchmarks have to be run.
		private const bool PerformEagerLoadBenchmarks = true;	// flag to signal whether the eager load fetch benchmarks have to be run. Not every bencher will perform this benchmnark.

		private static string SqlSelectCommandText = @"SELECT [SalesOrderID],[RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[SalesOrderNumber],[PurchaseOrderNumber],[AccountNumber],[CustomerID],[SalesPersonID],[TerritoryID],[BillToAddressID],[ShipToAddressID],[ShipMethodID],[CreditCardID],[CreditCardApprovalCode],[CurrencyRateID],[SubTotal],[TaxAmt],[Freight],[TotalDue],[Comment],[rowguid],[ModifiedDate]	FROM [Sales].[SalesOrderHeader]";
		private static List<IBencher> RegisteredBenchers = new List<IBencher>();
		private static List<int> KeysForIndividualFetches = new List<int>();

		public static string ConnectionString;


		public BenchmarkDotNetController()
		{
			Console.WriteLine("SETUP");
			CacheController.RegisterCache(ConnectionString, new ResultsetCache());
			FetchKeysForIndividualFetches();
			WarmupDB();
		}


		[Benchmark(Baseline = true)]
		public IEnumerable FetchSet_HandCodedBencher()
		{
			var bencher = new HandCodedBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };
			return bencher.FetchSet();
		}


		[Benchmark()]
		public IEnumerable FetchSet_HandCodedBencherUsingBoxing()
		{
			var bencher = new HandCodedBencherUsingBoxing() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };
			return bencher.FetchSet();
		}
		


		//	RegisteredBenchers.Add(new HandCodedBencherUsingBoxing() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new RawDbDataReaderBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new DapperBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new EntityFramework7NoChangeTrackingBencher() { ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new LinqToSqlNoChangeTrackingBencher());
		//	RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingQuerySpecPocoBencher());
		//	RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingLinqPocoBencher());
		//	RegisteredBenchers.Add(new LLBLGenProNoChangeTrackingBencher());
		//	RegisteredBenchers.Add(new EntityFrameworkNoChangeTrackingBencher());
		//	RegisteredBenchers.Add(new PetaPocoBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new PetaPocoFastBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new LINQ2DBNormalBencher(ConnectionString));
		//	RegisteredBenchers.Add(new LINQ2DBCompiledBencher(ConnectionString));

		//	RegisteredBenchers.Add(new LLBLGenProNormalBencher());
		//	RegisteredBenchers.Add(new LinqToSqlNormalBencher());
		//	RegisteredBenchers.Add(new EntityFrameworkNormalBencher());
		//	RegisteredBenchers.Add(new EntityFramework7NormalBencher() { ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new OakDynamicDbDtoBencher());
		//	RegisteredBenchers.Add(new OakDynamicDbNormalBencher());
		//	RegisteredBenchers.Add(new LLBLGenProResultsetCachingBencher());
		//	RegisteredBenchers.Add(new NHibernateNormalBencher());
		//	RegisteredBenchers.Add(new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });
		//	RegisteredBenchers.Add(new MassiveBencher());
		//	RegisteredBenchers.Add(new OrmLiteBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString });


		private static void FetchKeysForIndividualFetches()
		{
			using (var conn = new SqlConnection(ConnectionString))
			{
				KeysForIndividualFetches = conn.Query<int>("select top {=count} SalesOrderId from AdventureWorks.Sales.SalesOrderHeader order by SalesOrderNumber",
															new { count = IndividualKeysAmount }).AsList();
			}
			if (KeysForIndividualFetches.Count != IndividualKeysAmount)
			{
				throw new InvalidOperationException("Can't fetch the keys for the individual benchmarks");
			}
		}


		private static void WarmupDB()
		{
			var dbWarmer = new DataTableBencher() { CommandText = SqlSelectCommandText, ConnectionStringToUse = ConnectionString };
			var set = dbWarmer.FetchSet();
			var setAsList = set.ToList();
			var value = dbWarmer.FetchIndividual(KeysForIndividualFetches[0]);
		}
	}
}