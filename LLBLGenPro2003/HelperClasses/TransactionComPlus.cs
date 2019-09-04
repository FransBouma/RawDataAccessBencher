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
using System.EnterpriseServices;

using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.HelperClasses
{
	/// <summary>
	/// Specific implementation of the TransactionComPlus class. The constructor will take care of the creation of the physical transaction and the
	/// opening of the connection. It will require a COM+ transaction.
	/// </summary>
	[Transaction(TransactionOption.Required)]
	public class TransactionComPlus : TransactionComPlusBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public TransactionComPlus()
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionString">Connection string to use in this transaction</param>
		public TransactionComPlus(string connectionString):base(connectionString)
		{
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		/// Reads connectionstring from .config file. The COM+ transaction will flow to the used method.
		/// </summary>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection()
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection();
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		/// The COM+ transaction will flow to the used method.
		/// </summary>
		/// <param name="connectionString">Connection string to use</param>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection(string connectionString)
		{
			DbUtilsComPlus dbUtilsToUse = new DbUtilsComPlus();
			return dbUtilsToUse.CreateConnection(connectionString);
		}


		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// This method is void in combination of a COM+ transaction. It will always return null.
		/// </summary>
		/// <returns>null</returns>
		protected override System.Data.IDbTransaction CreatePhysicalTransaction()
		{
			return null;
		}

	}
}
