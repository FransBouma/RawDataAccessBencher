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
// Code is generated on: woensdag 4 september 2019 12:09:45
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;
using System.Data;

using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;
using SD.LLBLGen.Pro.DQE.SqlServer2003;

namespace LLBL2003.AdventureWorks2008.DaoClasses
{
	/// <summary>
	/// Generic DAO class for usage with Typed list classes.
	/// </summary>
	public class TypedListDAO : DaoBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public TypedListDAO()
		{
		}


		/// <summary>
		/// Retrieves rows in the datatable provided which match the specified filter, containing the fields specified. 
		/// It will always create a new connection to the database.
		/// </summary>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the resultset to return.</param>
		/// <param name="tableToFill">The datatable to fill with the rows retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows or not</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiAsDataTable(IEntityFields fieldsToReturn, DataTable tableToFill, long maxNumberOfItemsToReturn, 
				ISortExpression sortClauses, IPredicate selectFilter, IRelationCollection relations, bool allowDuplicates, IGroupByCollection groupByClause, ITransaction transactionToUse)
		{
			IRetrievalQuery selectQuery = DynamicQueryEngine.CreateSelectDQ(fieldsToReturn, DbUtils.DetermineConnectionToUse(transactionToUse), 
				selectFilter, maxNumberOfItemsToReturn, sortClauses, relations, allowDuplicates, groupByClause);
			return base.ExecuteMultiRowDataTableRetrievalQuery(selectQuery, DbUtils.CreateDataAdapter(), tableToFill);
		}


		/// <summary>
		/// Retrieves rows in the datatable provided which match the specified filter, containing the fields specified. 
		/// It will always create a new connection to the database. This overload doesn't accept relations, therefor all fields in the fieldsToReturn
		/// have to be in the same table/view.
		/// </summary>
		/// <param name="fieldsToReturn">IEntityFields implementation which forms the definition of the resultset to return.</param>
		/// <param name="tableToFill">The datatable to fill with the rows retrieved</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiAsDataTable(IEntityFields fieldsToReturn, DataTable tableToFill, long maxNumberOfItemsToReturn, 
			ISortExpression sortClauses, IPredicate selectFilter, IGroupByCollection groupByClause, ITransaction transactionToUse)
		{
			IRetrievalQuery selectQuery = DynamicQueryEngine.CreateSelectDQ(fieldsToReturn, DbUtils.DetermineConnectionToUse(transactionToUse), 
				selectFilter, maxNumberOfItemsToReturn, sortClauses, groupByClause);
			return base.ExecuteMultiRowDataTableRetrievalQuery(selectQuery, DbUtils.CreateDataAdapter(), tableToFill);
		}

	}
}
