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

using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.HelperClasses
{
	/// <summary>
	/// Specific implementation of the Transaction class. The constructor will take care of the creation of the physical transaction and the
	/// opening of the connection. The transaction object is ready to use as soon as the constructor succeeds.
	/// </summary>
	public class Transaction : TransactionBase
	{
		/// <summary>
		/// CTor. Will read the connection string from an external source. Opens connection, class
		/// </summary>
		/// <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		/// <param name="name">The name of the transaction to use.</param>
		public Transaction(IsolationLevel transactionIsolationLevel, string name):base(transactionIsolationLevel, name)
		{
			// empty
		}

		
		/// <summary>
		/// CTor. 
		/// </summary>
		/// <param name="transactionIsolationLevel">IsolationLevel to use in the transaction</param>
		/// <param name="name">The name of the transaction to use.</param>
		/// <param name="connectionString">Connection string to use in this transaction</param>
		public Transaction(IsolationLevel transactionIsolationLevel, string name, string connectionString):base(transactionIsolationLevel, name, connectionString)
		{
			// empty
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance. 
		/// Reads connectionstring from .config file.
		/// </summary>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection()
		{
			return DbUtils.CreateConnection();
		}


		/// <summary>
		/// Creates a new IDbConnection instance which will be used by all elements using this ITransaction instance
		/// </summary>
		/// <param name="connectionString">Connection string to use</param>
		/// <returns>new IDbConnection instance</returns>
		protected override System.Data.IDbConnection CreateConnection(string connectionString)
		{
			return DbUtils.CreateConnection(connectionString);
		}


		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// </summary>
		/// <returns>a physical transaction object, like an instance of SqlTransaction.</returns>
		protected override System.Data.IDbTransaction CreatePhysicalTransaction()
		{
			return DbUtils.CreateTransaction(base.ConnectionToUse, base.TransactionIsolationLevel, this.Name);
		}
	}
}
