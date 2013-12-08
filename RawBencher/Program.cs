using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v41.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.v41.EntityClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using EF6.Bencher;
using L2S.Bencher;
using NH.Bencher;
using NHibernate;
using NHibernate.Linq;
using Dapper;
using SD.LLBLGen.Pro.QuerySpec;
using SD.LLBLGen.Pro.QuerySpec.Adapter;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Reflection;

namespace RawBencher
{
	class Program
	{
		private static Dictionary<string, List<long>> _rawResultsPerORM = new Dictionary<string, List<long>>();
		private static string ConnectionString = @"data source=zeusVM\SQLSERVER2005;initial catalog=AdventureWorks;integrated security=SSPI;persist security info=False;packet size=4096";

		static void Main(string[] args)
		{
			CacheController.RegisterCache(ConnectionString, new ResultsetCache());
			int loopAmount = 10;

			Console.WriteLine("\nWarming up DB, DB client code and CLR");
			Console.WriteLine("------------------------------------------");
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderHandCoded();
			}

			Console.WriteLine("\nStarting benchmarks");
			Console.WriteLine("------------------------------------------");
			_rawResultsPerORM.Clear();
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderEF();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderEFNoTracking();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderL2S();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderEntities();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderEntitiesWithCaching();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderDapper();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderNH();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderHandCoded();
			}
			for(int i = 0; i < loopAmount; i++)
			{
				FetchSalesOrderHeaderDataTable();
			}

			Console.WriteLine("\nIndividual entity fetch benches");
			Console.WriteLine("------------------------------------------");
			FetchSalesOrderHeaderEntitiesIndividually();
			FetchSalesOrderHeaderEFIndividually();

			Console.WriteLine("\nAveraged total results per framework");
			Console.WriteLine("------------------------------------------");
			CalculateFinalResultAverages();
		}


		private static void FetchSalesOrderHeaderDataTable()
		{
			var frameworkName = "DbDataAdapter into DataTable";
			var sw = new Stopwatch();
			sw.Start();
			var headers = new DataTable();
			using(var con = new SqlConnection(ConnectionString))
			{
				var cmd = con.CreateCommand();
				cmd.CommandText = "select * from Sales.SalesOrderHeader";
				var adapter = new SqlDataAdapter(cmd);
				adapter.Fill(headers);
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Rows.Count);

			for(int i = 0; i < headers.Rows.Count;i++ )
			{
				if(Convert.ToInt32(headers.Rows[i]["SalesOrderID"]) <= 0)
				{
					Console.WriteLine("Data table: Data is empty");
					break;
				}
			}
		}


		private static void FetchSalesOrderHeaderHandCoded()
		{
			var frameworkName = "DbDataReader, handcoded";

			var sw = new Stopwatch();
			sw.Start();
			var headers = new List<SalesOrderHeader>();
			using(var con = new SqlConnection(ConnectionString))
			{
				var cmd = con.CreateCommand();
				cmd.CommandText = "select * from Sales.SalesOrderHeader";
				con.Open();
				var reader = cmd.ExecuteReader();
				while(reader.Read())
				{
					object fieldValue = null;
					var soh = new SalesOrderHeader();
					soh.SalesOrderId = (int)reader.GetValue(0);
					soh.RevisionNumber = (byte)reader.GetValue(1);
					soh.OrderDate = (DateTime)reader.GetValue(2);
					soh.DueDate = (DateTime)reader.GetValue(3);
					fieldValue = reader.GetValue(4);
					soh.ShipDate = (DateTime)(fieldValue == DBNull.Value ? null : fieldValue);
					soh.Status = (byte)reader.GetValue(5);
					soh.OnlineOrderFlag = (bool)reader.GetValue(6);
					soh.SalesOrderNumber = (string)reader.GetValue(7);
					fieldValue = reader.GetValue(8);
					soh.PurchaseOrderNumber = (string)(fieldValue == DBNull.Value ? null : fieldValue);
					fieldValue = reader.GetValue(9);
					soh.AccountNumber = (string)(fieldValue == DBNull.Value ? null : fieldValue);
					soh.CustomerID = (int)reader.GetValue(10);
					soh.ContactID = (int)reader.GetValue(11);
					fieldValue = reader.GetValue(12);
					soh.SalesPersonID = (int?)(fieldValue == DBNull.Value ? null : fieldValue);
					fieldValue = reader.GetValue(13);
					soh.TerritoryID = (int?)(fieldValue == DBNull.Value ? null : fieldValue);
					soh.BillToAddressID = (int)reader.GetValue(14);
					soh.ShipToAddressID = (int)reader.GetValue(15);
					soh.ShipMethodID = (int)reader.GetValue(16);
					fieldValue = reader.GetValue(17);
					soh.CreditCardID = (int?)(fieldValue == DBNull.Value ? null : fieldValue);
					fieldValue = reader.GetValue(18);
					soh.CreditCardApprovalCode = (string)(fieldValue == DBNull.Value ? null : fieldValue);
					fieldValue = reader.GetValue(19);
					soh.CurrencyRateID = (int?)(fieldValue == DBNull.Value?null : fieldValue);
					soh.SubTotal = (decimal)reader.GetValue(20);
					soh.TaxAmt = (decimal)reader.GetValue(21);
					soh.Freight = (decimal)reader.GetValue(22);
					soh.TotalDue = (decimal)reader.GetValue(23);
					fieldValue = reader.GetValue(24);
					soh.Comment = (string)(fieldValue==DBNull.Value ? null : fieldValue);
					soh.Rowguid = (Guid)reader.GetValue(25);
					soh.ModifiedDate = (DateTime)reader.GetValue(26);
					headers.Add(soh);
				}
				reader.Close();
				con.Close();
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("Hand written: Data is empty");
					break;
				}
			}
		}


		private static void FetchSalesOrderHeaderDapper()
		{
			var frameworkName = "Dapper";

			var sw = new Stopwatch();
			sw.Start();
			var headers = new List<SalesOrderHeader>();
			using(var con = new SqlConnection(ConnectionString))
			{
				con.Open();
				headers = con.Query<SalesOrderHeader>("select * from Sales.SalesOrderHeader").ToList();
				con.Close();
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);

			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("Dapper: Data is empty");
					break;
				}
			}
		}


		private static void FetchSalesOrderHeaderEntitiesWithCaching()
		{
			var frameworkName = CreateFrameworkName("LLBLGen Pro v{0} (v{1}), with resultset caching", typeof(DataAccessAdapterBase));
			var sw = new Stopwatch();
			sw.Start();
			var qf = new QueryFactory();
			var q = qf.SalesOrderHeader.CacheResultset(5);
			var headers = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchQuery(q, headers);
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("LLBL41 with cache: Data is empty");
					break;
				}
			}
		}


		private static void FetchSalesOrderHeaderEntitiesIndividually()
		{
			Console.WriteLine("Fetching entities individually, LLBLGen Pro v4.1");
			var headers = FetchSalesOrderHeaderEntities();
			int count = 0;
			var sw = new Stopwatch();
			sw.Start();
			foreach(var fetched in headers)
			{
				var toFetch = new SalesOrderHeaderEntity(fetched.SalesOrderId);
				using(var adapter = new DataAccessAdapter())
				{
					adapter.FetchEntity(toFetch);
					if(toFetch.Fields.State != SD.LLBLGen.Pro.ORMSupportClasses.EntityState.Fetched)
					{
						Console.WriteLine("Not fetched. Aborting");
						return;
					}
					count++;
				}
				if(count > 1000)
				{
					break;
				}
			}
			sw.Stop();
			double average = (double)sw.ElapsedMilliseconds / (double)count;
			Console.WriteLine("Fetching {0} entities individually through CTor/PK fetch took {1}ms, or {2}ms/entity", count, sw.ElapsedMilliseconds, average);
		}
		

		private static EntityCollection<SalesOrderHeaderEntity> FetchSalesOrderHeaderEntities()
		{
			var frameworkName = CreateFrameworkName("LLBLGen Pro v{0} (v{1})", typeof(DataAccessAdapterBase));
			var sw = new Stopwatch();
			sw.Start();
			var headers = new EntityCollection<SalesOrderHeaderEntity>();
			using(var adapter = new DataAccessAdapter())
			{
				adapter.FetchEntityCollection(headers, null);
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("LLBL41: Data is empty");
					break;
				}
			}
			return headers;
		}


		private static List<EF6.Bencher.EntityClasses.SalesOrderHeader>  FetchSalesOrderHeaderEF()
		{
			var frameworkName = CreateFrameworkName("Entity Framework v{0} (v{1})", typeof(System.Data.Entity.DbContext));
			var sw = new Stopwatch();
			sw.Start();
			List<EF6.Bencher.EntityClasses.SalesOrderHeader> headers = null;
			using(var ctx = new AWDataContext())
			{
				headers = ctx.SalesOrderHeaders.ToList();
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("EF: Data is empty");
					break;
				}
			}
			return headers;
		}


		private static List<EF6.Bencher.EntityClasses.SalesOrderHeader> FetchSalesOrderHeaderEFNoTracking()
		{
			var frameworkName = CreateFrameworkName("Entity Framework v{0} (v{1}), using AsNoTracking()", typeof(System.Data.Entity.DbContext));
			var sw = new Stopwatch();
			sw.Start();
			List<EF6.Bencher.EntityClasses.SalesOrderHeader> headers = null;
			using(var ctx = new AWDataContext())
			{
				headers = ctx.SalesOrderHeaders.AsNoTracking().ToList();
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("EF: Data is empty");
					break;
				}
			}
			return headers;
		}


		private static void FetchSalesOrderHeaderEFIndividually()
		{
			Console.WriteLine("Fetching entities individually, EF6.0.1");
			var headers = FetchSalesOrderHeaderEF();
			int count = 0;
			var sw = new Stopwatch();
			sw.Start();
			foreach(var fetched in headers)
			{
				using(var ctx = new AWDataContext())
				{
					var toFetch = ctx.SalesOrderHeaders.Single(soh => soh.SalesOrderId == fetched.SalesOrderId);
					count++;
				}
				if(count > 1000)
				{
					break;
				}
			}
			sw.Stop();
			double average = (double)sw.ElapsedMilliseconds / (double)count;
			Console.WriteLine("Fetching {0} entities individually through CTor/PK fetch took {1}ms, or {2}ms/entity", count, sw.ElapsedMilliseconds, average);
		}


		private static void FetchSalesOrderHeaderL2S()
		{
			var frameworkName = CreateFrameworkName("Linq to Sql v{0} (v{1})", typeof(System.Data.Linq.DataContext));
			var sw = new Stopwatch();
			sw.Start();
			List<L2S.Bencher.EntityClasses.SalesOrderHeader> headers = null;
			var ctx = new L2SBencherDataContext();
			headers = ctx.SalesOrderHeaders.ToList();
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);

			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("L2S: Data is empty");
					break;
				}
			}
		}


		private static void FetchSalesOrderHeaderNH()
		{
			var frameworkName = CreateFrameworkName("NHibernate v{0} (v{1})", typeof(ISession));
			var sw = new Stopwatch();
			sw.Start();
			List<NH.Bencher.EntityClasses.SalesOrderHeader> headers = null;
			using(var session = SessionManager.OpenSession())
			{
				headers = session.Query<NH.Bencher.EntityClasses.SalesOrderHeader>().ToList();
			}
			sw.Stop();
			ReportResult(frameworkName, sw.ElapsedMilliseconds, headers.Count);
			foreach(var e in headers)
			{
				if(e.SalesOrderId <= 0)
				{
					Console.WriteLine("NH: Data is empty");
					break;
				}
			}
		}


		private static void GetVersionStrings(Assembly a, out string fileVersion, out string assemblyVersion)
		{
			fileVersion = string.Empty;
			assemblyVersion = string.Empty;
			if(a != null)
			{
				assemblyVersion = a.GetName().Version.ToString();
				fileVersion = FileVersionInfo.GetVersionInfo(a.Location).FileVersion;
			}
		}


		private static void ReportResult(string frameworkName, long elapsedTimeInMs, int amountFetched)
		{
			Console.WriteLine("Fetched {0} objects using: '{1}'. Took: {2}ms", amountFetched, frameworkName, elapsedTimeInMs);
			List<long> container;
			if(!_rawResultsPerORM.TryGetValue(frameworkName, out container))
			{
				container = new List<long>();
				_rawResultsPerORM.Add(frameworkName, container);
			}
			container.Add(elapsedTimeInMs);
		}


		private static string CreateFrameworkName(string formatString, Type t)
		{
			string assemblyVersion;
			string fileVersion;
			GetVersionStrings(t.Assembly, out fileVersion, out assemblyVersion);
			return string.Format(formatString, assemblyVersion, fileVersion);
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
