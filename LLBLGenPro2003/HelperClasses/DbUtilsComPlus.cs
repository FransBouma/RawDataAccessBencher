///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//
// Do not try to run this code on another version of the database than the database
// which was used to generate this code. This means that when you used f.e. SqlServer 2000
// to generate this code, it is likely that you will not be able to use that code on
// SqlServer 7 due to SQL syntax mismatches. Most code is generic code which will work
// with any database, but some code relies on a specific database type/vendor/version used. 
// This code is located in the DaoClasses which target a specific specified database. Also all
// classes target a specific specified Dynamic Query Engine (DQE) in the using/imports
// directives. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2003.1
// Code is generated on: woensdag 4 september 2019 12:09:46
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.EnterpriseServices;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.HelperClasses
{
	/// <summary>
	/// General utility class for COM+ transactions. 
	/// </summary>
	[Transaction(TransactionOption.Required)]
	public class DbUtilsComPlus : ServicedComponent
	{
		#region Constants
		private const string connectionKeyString = "Main.ConnectionString";
		#endregion

		#region Class Member Declarations
		private static int _commandTimeOut = 30;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public DbUtilsComPlus()
		{
		}


		/// <summary>
		/// Creates a new SqlConnection
		/// </summary>
		/// <param name="connectionString">Conectionstring To use</param>
		/// <returns>A ready to use, closed, sqlconnection object</returns>
		public SqlConnection CreateConnection(string connectionString)
		{
			return new SqlConnection(connectionString);
		}

		/// <summary>
		/// Creates a new closed SqlConnection object based on the connection string read from the *.config file of the appdomain.
		/// The connection string is stored in a key with the name defined in the constant connectionKeyString, mentioned above.
		/// </summary>
		/// <returns>A ready to use, closed, sqlconnection object</returns>
		public SqlConnection CreateConnection()
		{
			// read the connection string from the *.config file.
			AppSettingsReader configReader = new AppSettingsReader();
			string connectionString = configReader.GetValue(connectionKeyString, typeof(string)).ToString();

			return CreateConnection(connectionString);
		}
		
		
		#region Class Property Declarations
		/// <summary>
		/// Gets / sets the command time out (in seconds). This is a global setting, so every Command object created after you've set this
		/// property to a value will have that value as CommandTimeOut. Default is 30 seconds which is the ADO.NET default.
		/// </summary>
		public static int CommandTimeOut
		{
			get
			{
				return _commandTimeOut;
			}
			set
			{
				_commandTimeOut = value;
				SD.LLBLGen.Pro.DQE.SqlServer2003.DynamicQueryEngine.CommandTimeOut = _commandTimeOut;
			}
		}
		#endregion
	}
}
