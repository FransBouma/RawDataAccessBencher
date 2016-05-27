using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.v50.DatabaseSpecific;
using BenchmarkDotNet.Running;
using RawBencher.BenchmarkDotNet;

namespace RawBencher
{
	public class Program
	{
		private static string ConnectionString = ConfigurationManager.ConnectionStrings["AdventureWorks.ConnectionString.SQL Server (SqlClient)"].ConnectionString;

		public static void Main(string[] args)
		{
			try
			{
				// old runner
				//OriginalController.Run(args);

				DoBenchmarkDotNet();
			}
			catch(Exception ex)
			{
				BencherUtils.DisplayException(ex);
			}
		}


		private static void DoBenchmarkDotNet()
		{
			// We have to do it this way as BenchmarkDotNet doesn't support app.config files. 
			InitConnectionString();
			BenchmarkDotNetController.ConnectionString = Program.ConnectionString;
			var summary = BenchmarkRunner.Run<BenchmarkDotNetController>();
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
	}
}
