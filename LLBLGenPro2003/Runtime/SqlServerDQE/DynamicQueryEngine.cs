//////////////////////////////////////////////////////////////////////
// Part of the Dynamic Query Engine (DQE) for SqlServer, used in the generated code. 
// LLBLGen Pro specific. Do not modify. 
// LLBLGen Pro is (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
//////////////////////////////////////////////////////////////////////
// The sourcecode for this DQE is released as BSD2 licensed open source, so licensees and others can
// modify, update, extend or use it to write other DQE's. Do NOT, under any circumstance, change the
// INTERFACE of the DQE. Each DQE has to implement the same methods to make it work with LLBLGen Pro's
// generated code. Because the methods are static, no interface definition is possible however.
//////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2003 Solutions Design. All rights reserved.
// 
// This DQE is released under the following license: (BSD2)
// -------------------------------------------
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met: 
//
// 1) Redistributions of source code must retain the above copyright notice, this list of 
//    conditions and the following disclaimer. 
// 2) Redistributions in binary form must reproduce the above copyright notice, this list of 
//    conditions and the following disclaimer in the documentation and/or other materials 
//    provided with the distribution. 
// 
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
//
// The views and conclusions contained in the software and documentation are those of the authors 
// and should not be interpreted as representing official policies, either expressed or implied, 
// of Solutions Design. 
//
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
//		- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace SD.LLBLGen.Pro.DQE.SqlServer2003
{
	/// <summary>
	/// DynamicQueryEngine for SqlServer.
	/// </summary>
	public class DynamicQueryEngine
	{
		#region Class Constants
		/// <summary>
		/// Length of buffer in which Insert queries are generated
		/// </summary>
		public static int InsertQueryBufferLength=128;
		/// <summary>
		/// Length of buffer in which Delete queries are generated
		/// </summary>
		public static int DeleteQueryBufferLength=128;
		/// <summary>
		/// Length of buffer in which Update queries are generated
		/// </summary>
		public static int UpdateQueryBufferLength=128;
		/// <summary>
		/// Length of buffer in which Select queries are generated
		/// </summary>
		public static int SelectQueryBufferLength=128;
		/// <summary>
		/// Length of buffer in which Join constructs for select queries are generated
		/// </summary>
		public static int SelectJoinQueryBufferLength=256;
		/// <summary>
		/// Length of buffer in which resultset definitions for select queries are generated
		/// </summary>
		public static int SelectResultSetBufferLength=128;
		#endregion

		#region Class Member Declarations
		private static int _commandTimeOut=30;
		#endregion

		/// <summary>
		/// Private CTor. No instances allowed.
		/// </summary>
		private DynamicQueryEngine()
		{
		}


		#region Dynamic Insert Query construction methods.
		/// <summary>
		/// Creates a new Insert Query object which is ready to use. 
		/// </summary>
		/// <param name="fields">EntityFields object to use to build the insert query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <returns>IActionQuery Instance which is ready to be used.</returns>
		/// <remarks>Self servicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When fields is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityField instances.</exception>
		public static IActionQuery CreateInsertDQ(IEntityFields fields, IDbConnection connectionToUse)
		{
			// call generic construction code.
			return CreateInsertDQ(fields.GetAsEntityFieldCoreArray(), fields.GetAsPersistenceInfoArray(), connectionToUse);
		}


		/// <summary>
		/// Creates a new Insert Query object which is ready to use. 
		/// </summary>
		/// <param name="fields">Array of EntityFieldCore objects to use to build the insert query</param>
		/// <param name="fieldsPersistenceInfo">Array of IFieldPersistenceInfo objects to use to build the insert query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <returns>IActionQuery Instance which is ready to be used.</returns>
		/// <remarks>Generic version.</remarks>
		/// <exception cref="System.ArgumentNullException">When fields is null or fieldsPersistenceInfo is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityFieldCore instances or fieldsPersistenceInfo is empty.</exception>
		public static IActionQuery CreateInsertDQ(IEntityFieldCore[] fields, IFieldPersistenceInfo[] fieldsPersistenceInfo, IDbConnection connectionToUse)
		{
			if(fields==null)
			{
				throw new ArgumentNullException("fields", "fields can't be null.");
			}
			if(fieldsPersistenceInfo==null)
			{
				throw new ArgumentNullException("fieldsPersistenceInfo", "fieldsPersistenceInfo can't be null.");
			}
			if((fields.Length<=0)||(fieldsPersistenceInfo.Length<=0))
			{
				throw new ArgumentException("No fields to insert or not enough persistence info objects passed", "fields");
			}

			IDbCommand command = CreateCommand();
			IActionQuery insertQuery = new ActionQuery(connectionToUse, command);
			IDbSpecificCreator creator = new SqlServerSpecificCreator();

			StringBuilder queryText = new StringBuilder(InsertQueryBufferLength);
			StringBuilder parametersText = new StringBuilder(InsertQueryBufferLength);
			StringBuilder outputRetrievalQueryText = new StringBuilder(InsertQueryBufferLength);

			// walk all EntityField instances in fields. We only support single table inserts, pick the table of the first field.
			queryText.AppendFormat("INSERT INTO {0} (", creator.CreateObjectName(fieldsPersistenceInfo[0]));

			SqlParameter newParameter=null;
			for(int i=0, amountFieldsAdded=0;i<fields.Length;i++)
			{
				IEntityFieldCore field = fields[i];
				IFieldPersistenceInfo persistenceInfo = fieldsPersistenceInfo[i];

				if(persistenceInfo.IsIdentity)
				{
					// Create output parameter.
					newParameter = (SqlParameter)creator.CreateParameter(field, persistenceInfo, ParameterDirection.Output);
					command.Parameters.Add(newParameter);

					insertQuery.AddParameterFieldRelation(new ParameterFieldRelation(field, newParameter));

					// create output retrieval query.
					outputRetrievalQueryText.AppendFormat(";SELECT {0}={1}", newParameter.ParameterName, persistenceInfo.IdentityValueSequenceName);
					// done.
					continue;
				}

				if(!field.IsChanged)
				{
					// doesn't have a value set or is readonly. Assume a default is set in the database or NULL is acceptable., skip field.
					continue;
				}

				// normal field which will be updated.
				if(amountFieldsAdded>0)
				{
					queryText.Append(",");
				}
				queryText.AppendFormat("{0}", creator.CreateFieldNameSimple(persistenceInfo, field.Name));

				// add parameter
				newParameter = (SqlParameter)creator.CreateParameter(field, persistenceInfo, ParameterDirection.Input);
				command.Parameters.Add(newParameter);
				if(amountFieldsAdded>0)
				{
					parametersText.Append(",");
				}
				parametersText.Append(newParameter.ParameterName);
				amountFieldsAdded++;
			}

			// append the rest of the query elements.
			queryText.AppendFormat(") VALUES ({0}){1}", parametersText.ToString(), outputRetrievalQueryText.ToString());

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;

			// query is done. 
			return insertQuery;
		}
		#endregion


		#region Dynamic Delete Query construction methods.
		/// <summary>
		/// Creates a new Delete Query object which is ready to use.
		/// </summary>
		/// <param name="persistenceInfo">IFieldPersistenceInfo of field which is used to determine which table to target</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="deleteFilter">A complete IPredicate implementing object which contains the filter for the rows to delete</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <remarks>Generic version</remarks>
		/// <exception cref="System.ArgumentNullException">When persistenceInfo is null</exception>
		public static IActionQuery CreateDeleteDQ(IFieldPersistenceInfo persistenceInfo, IDbConnection connectionToUse, IPredicate deleteFilter)
		{
			if(persistenceInfo==null)
			{
				throw new ArgumentNullException("persistenceInfo", "persistenceInfo can't be null.");
			}

			IDbCommand command = CreateCommand();
			IActionQuery deleteQuery = new ActionQuery(connectionToUse, command);
			IDbSpecificCreator creator = new SqlServerSpecificCreator();
			StringBuilder queryText = new StringBuilder(DeleteQueryBufferLength);

			queryText.AppendFormat("DELETE FROM {0}", creator.CreateObjectName(persistenceInfo));

			if(deleteFilter!=null)
			{
				int uniqueMarker=0;
				deleteFilter.DatabaseSpecificCreator = creator;
				queryText.AppendFormat(" WHERE {0}", deleteFilter.ToQueryText(ref uniqueMarker));

				for(int i=0;i<deleteFilter.Parameters.Count;i++)
				{
					command.Parameters.Add (deleteFilter.Parameters[i]);
				}
			}

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;

			// query is done. 
			return deleteQuery;
		}


		/// <summary>
		/// Creates a new Delete Query object which is ready to use.
		/// </summary>
		/// <param name="persistenceInfo">IFieldPersistenceInfo of field which is used to determine which table to target</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="deleteFilter">A complete IPredicate implementing object which contains the filter for the rows to delete</param>
		/// <param name="relationsToWalk">list of EntityRelation objects, which will be used to formulate a second FROM clause with INNER JOINs.</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <remarks>Generic version</remarks>
		/// <exception cref="System.ArgumentNullException">When persistenceInfo is null or when deleteFilter is null or when relationsToWalk is null</exception>
		public static IActionQuery CreateDeleteDQ(IFieldPersistenceInfo persistenceInfo, IDbConnection connectionToUse, IPredicate deleteFilter, IRelationCollection relationsToWalk)
		{
			if(persistenceInfo==null)
			{
				throw new ArgumentNullException("persistenceInfo", "persistenceInfo can't be null.");
			}

			if(deleteFilter==null)
			{
				throw new ArgumentNullException("deleteFilter", "deleteFilter can't be null.");
			}

			if(relationsToWalk==null)
			{
				throw new ArgumentNullException("relationsToWalk", "relationsToWalk can't be null.");
			}

			if(((RelationCollection)relationsToWalk).Count<=0)
			{
				// no relations specified, do a normal query
				return CreateDeleteDQ(persistenceInfo, connectionToUse, deleteFilter);
			}

			IDbCommand command = CreateCommand();
			IActionQuery deleteQuery = new ActionQuery(connectionToUse, command);
			IDbSpecificCreator creator = new SqlServerSpecificCreator();
			StringBuilder queryText = new StringBuilder(DeleteQueryBufferLength);

			int uniqueMarker=0;
			relationsToWalk.DatabaseSpecificCreator = creator;
			deleteFilter.DatabaseSpecificCreator = creator;
			queryText.AppendFormat("DELETE FROM {0} FROM {1} WHERE {2}", creator.CreateObjectName(persistenceInfo), relationsToWalk.ToQueryText(ref uniqueMarker), deleteFilter.ToQueryText(ref uniqueMarker));

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;
			for(int i=0;i<deleteFilter.Parameters.Count;i++)
			{
				command.Parameters.Add(deleteFilter.Parameters[i]);
			}

			for(int i=0;i<((RelationCollection)relationsToWalk).CustomFilterParameters.Count;i++)
			{
				command.Parameters.Add(((RelationCollection)relationsToWalk).CustomFilterParameters[i]);
			}

			// query is done. 
			return deleteQuery;
		}
		#endregion


		#region Dynamic Update Query construction methods.
		/// <summary>
		/// Creates a new Update Query object which is ready to use. Only 'changed' EntityFields are included in the update query.
		/// Primary Key fields are never updated. 
		/// </summary>
		/// <param name="fields">EntityFields object to use to build the update query.</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="updateFilter">A complete IPredicate implementing object which contains the filter for the rows to update</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <remarks>Selfservicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When fields is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityField instances.</exception>
		public static IActionQuery CreateUpdateDQ(IEntityFields fields, IDbConnection connectionToUse, IPredicate updateFilter)
		{
			// call generic construction code
			return CreateUpdateDQ(fields.GetAsEntityFieldCoreArray(), fields.GetAsPersistenceInfoArray(), connectionToUse, updateFilter);
		}


		/// <summary>
		/// Creates a new Update Query object which is ready to use. Only 'changed' EntityFieldCore are included in the update query. 
		/// Primary Key fields are never updated. 
		/// </summary>
		/// <param name="fields">EntityFields object to use to build the update query.</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="updateFilter">A complete IPredicate implementing object which contains the filter for the rows to update</param>
		/// <param name="relationsToWalk">list of EntityRelation objects, which will be used to formulate a FROM clause with INNER JOINs.</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <remarks>Selfservicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When fields is null or when updateFilter is null or when relationsToWalk is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityField instances.</exception>
		public static IActionQuery CreateUpdateDQ(IEntityFields fields, IDbConnection connectionToUse, IPredicate updateFilter, IRelationCollection relationsToWalk)
		{
			// call generic construction code
			return CreateUpdateDQ(fields.GetAsEntityFieldCoreArray(), fields.GetAsPersistenceInfoArray(), connectionToUse, updateFilter, relationsToWalk);
		}


		/// <summary>
		/// Creates a new Update Query object which is ready to use. Only 'changed' EntityFieldCore fields are included in the update query. 
		/// Primary Key fields are never updated. 
		/// </summary>
		/// <param name="fields">EntityFieldCore array to use to build the update query.</param>
		/// <param name="fieldsPersistenceInfo">Array of IFieldPersistenceInfo objects to use to build the update query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="updateFilter">A complete IPredicate implementing object which contains the filter for the rows to update</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <exception cref="System.ArgumentNullException">When fields is null or fieldsPersistenceInfo is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityFieldCore instances or fieldsPersistenceInfo is empty.</exception>
		public static IActionQuery CreateUpdateDQ(IEntityFieldCore[] fields, IFieldPersistenceInfo[] fieldsPersistenceInfo, 
							IDbConnection connectionToUse, IPredicate updateFilter)
		{
			if(fields==null)
			{
				throw new ArgumentNullException("fields", "fields can't be null.");
			}
			if(fieldsPersistenceInfo==null)
			{
				throw new ArgumentNullException("fieldsPersistenceInfo", "fieldsPersistenceInfo can't be null.");
			}
			if((fields.Length<=0)||(fieldsPersistenceInfo.Length<=0))
			{
				throw new ArgumentException("No fields to update or not enough persistence info objects passed", "fields");
			}

			ArrayList fieldsToUpdate = new ArrayList();
			ArrayList persistenceInfoFieldsToUpdate = new ArrayList();
			ConstructFieldsToUpdateList(fields, fieldsPersistenceInfo, ref fieldsToUpdate, ref persistenceInfoFieldsToUpdate);

			IDbCommand command = CreateCommand();
			IActionQuery updateQuery = new ActionQuery(connectionToUse, command);

			if(fieldsToUpdate.Count <=0)
			{
				// no fields to update. return empty query
				command.CommandText="";
				return updateQuery;
			}

			IDbSpecificCreator creator = new SqlServerSpecificCreator();
			StringBuilder queryText = new StringBuilder(UpdateQueryBufferLength);

			// walk all EntityField instances in fields. We only support single table updates, pick the table of the first field.
			queryText.AppendFormat("UPDATE {0} SET ", creator.CreateObjectName(fieldsPersistenceInfo[0]));

			SqlParameter newParameter=null;
			for(int i=0;i<fieldsToUpdate.Count;i++)
			{
				IEntityFieldCore field = (IEntityFieldCore)fieldsToUpdate[i];
				IFieldPersistenceInfo persistenceInfo = (IFieldPersistenceInfo)persistenceInfoFieldsToUpdate[i];

				// normal field which will be updated.
				newParameter = (SqlParameter)creator.CreateParameter(field, persistenceInfo, ParameterDirection.Input);
				command.Parameters.Add(newParameter);
				if(i>0)
				{
					queryText.Append(",");
				}
				queryText.AppendFormat("{0}={1}", creator.CreateFieldNameSimple(persistenceInfo, field.Name) , newParameter.ParameterName);
			}

			if(updateFilter!=null)
			{
				int uniqueMarker=0;
				updateFilter.DatabaseSpecificCreator = creator;
				queryText.AppendFormat(" WHERE {0}", updateFilter.ToQueryText(ref uniqueMarker));

				for(int i=0;i<updateFilter.Parameters.Count;i++)
				{
					command.Parameters.Add(updateFilter.Parameters[i]);
				}
			}

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;

			// query is done. 
			return updateQuery;
		}


		/// <summary>
		/// Creates a new Update Query object which is ready to use. Only 'changed' EntityFieldCore are included in the update query.
		/// Primary Key fields are never updated. 
		/// </summary>
		/// <param name="fields">Array of EntityFieldCore objects to use to build the insert query</param>
		/// <param name="fieldsPersistenceInfo">Array of IFieldPersistenceInfo objects to use to build the update query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="updateFilter">A complete IPredicate implementing object which contains the filter for the rows to update</param>
		/// <param name="relationsToWalk">list of EntityRelation objects, which will be used to formulate a FROM clause with INNER JOINs.</param>
		/// <returns>IActionQuery instance which is ready to be used.</returns>
		/// <exception cref="System.ArgumentNullException">When fields is null or when updateFilter is null or 
		/// when relationsToWalk is null or when fieldsPersistence is null</exception>
		/// <exception cref="System.ArgumentException">When fields contains no EntityFieldCore instances or fieldsPersistenceInfo is empty.</exception>
		public static IActionQuery CreateUpdateDQ(IEntityFieldCore[] fields, IFieldPersistenceInfo[] fieldsPersistenceInfo, 
						IDbConnection connectionToUse, IPredicate updateFilter, IRelationCollection relationsToWalk)
		{
			if(fields==null)
			{
				throw new ArgumentNullException("fields", "fields can't be null.");
			}
			if(fieldsPersistenceInfo==null)
			{
				throw new ArgumentNullException("fieldsPersistenceInfo", "fieldsPersistenceInfo can't be null.");
			}
			if((fields.Length<=0)||(fieldsPersistenceInfo.Length<=0))
			{
				throw new ArgumentException("No fields to update or not enough persistence info objects passed", "fields");
			}
			if(updateFilter==null)
			{
				throw new ArgumentNullException("updateFilter", "updateFilter can't be null.");
			}
			if(relationsToWalk==null)
			{
				throw new ArgumentNullException("relationsToWalk", "relationsToWalk can't be null.");
			}

			if(((RelationCollection)relationsToWalk).Count<=0)
			{
				// no relations set do normal query
				return CreateUpdateDQ(fields, fieldsPersistenceInfo, connectionToUse, updateFilter);
			}

			ArrayList fieldsToUpdate = new ArrayList();
			ArrayList persistenceInfoFieldsToUpdate = new ArrayList();
			ConstructFieldsToUpdateList(fields, fieldsPersistenceInfo, ref fieldsToUpdate, ref persistenceInfoFieldsToUpdate);

			IDbCommand command = CreateCommand();
			IActionQuery updateQuery = new ActionQuery(connectionToUse, command);

			if(fieldsToUpdate.Count <=0)
			{
				// no fields to update. return empty query
				command.CommandText="";
				return updateQuery;
			}

			IDbSpecificCreator creator = new SqlServerSpecificCreator();
			StringBuilder queryText = new StringBuilder(UpdateQueryBufferLength);
			updateFilter.DatabaseSpecificCreator = creator;

			// walk all EntityField instances in fields. We only support single table updates, pick the table of the first field.
			queryText.AppendFormat("UPDATE {0} SET ", creator.CreateObjectName(fieldsPersistenceInfo[0]));

			SqlParameter newParameter=null;
			for(int i=0;i<fieldsToUpdate.Count;i++)
			{
				IEntityFieldCore field = (IEntityFieldCore)fieldsToUpdate[i];
				IFieldPersistenceInfo persistenceInfo = (IFieldPersistenceInfo)persistenceInfoFieldsToUpdate[i];

				// normal field which will be updated.
				newParameter = (SqlParameter)creator.CreateParameter(field, persistenceInfo, ParameterDirection.Input);
				command.Parameters.Add(newParameter);
				if(i>0)
				{
					queryText.Append(",");
				}
				queryText.AppendFormat("{0}={1}", creator.CreateFieldNameSimple(persistenceInfo, field.Name), newParameter.ParameterName);
			}

			int uniqueMarker=0;
			relationsToWalk.DatabaseSpecificCreator=creator;
			queryText.AppendFormat(" FROM {0}", relationsToWalk.ToQueryText(ref uniqueMarker));
			queryText.AppendFormat(" WHERE {0}", updateFilter.ToQueryText(ref uniqueMarker));

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;
			for(int i=0;i<updateFilter.Parameters.Count;i++)
			{
				command.Parameters.Add(updateFilter.Parameters[i]);
			}

			for(int i=0;i<((RelationCollection)relationsToWalk).CustomFilterParameters.Count;i++)
			{
				command.Parameters.Add(((RelationCollection)relationsToWalk).CustomFilterParameters[i]);
			}

			// query is done. 
			return updateQuery;
		}
		#endregion


		#region Dynamic Select Query construction methods.
		/// <summary>
		/// Creates a new Select Query which is ready to use. If selectFilter is set to null, all rows are selected.
		/// </summary>
		/// <param name="selectList">list of fields to select</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="selectFilter">A complete IPredicate implementing object which contains the filter for the rows to select. When set to null, no 
		/// filtering is done, and all rows are returned.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <returns>IRetrievalQuery instance which is ready to be used.</returns>
		/// <remarks>SelfServicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When selectList is null</exception>
		/// <exception cref="System.ArgumentException">When selectList contains no EntityField instances.</exception>
		/// <exception cref="System.ArgumentException">When selectList contains one or more EntityField instances which are not present in a filled groupByClause.</exception>
		public static IRetrievalQuery CreateSelectDQ(IEntityFields selectList, IDbConnection connectionToUse, IPredicate selectFilter, 
			long maxNumberOfItemsToReturn, ISortExpression sortClauses, IGroupByCollection groupByClause)
		{
			// simply do a normal select with duplicates allowed
			return CreateSelectDQ(selectList.GetAsEntityFieldCoreArray(), selectList.GetAsPersistenceInfoArray(), connectionToUse, 
					selectFilter, maxNumberOfItemsToReturn, sortClauses, groupByClause, true);
		}


		/// <summary>
		/// Creates a new Select Query which is ready to use. If selectFilter is set to null, all rows are selected.
		/// </summary>
		/// <param name="selectList">list of fields to select</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="selectFilter">A complete IPredicate implementing object which contains the filter for the rows to select. When set to null, no 
		/// filtering is done, and all rows are returned.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <param name="allowDuplicates">Flag which forces the inclusion of DISTINCT if set to true. If the resultset contains fields of type ntext, text or image, no duplicate filtering
		/// is done.</param>
		/// <returns>IRetrievalQuery instance which is ready to be used.</returns>
		/// <remarks>Selfservicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When selectList is null</exception>
		/// <exception cref="System.ArgumentException">When selectList contains no EntityField instances.</exception>
		/// <exception cref="System.ArgumentException">When selectList contains one or more EntityField instances which are not present in a filled groupByClause.</exception>
		public static IRetrievalQuery CreateSelectDQ(IEntityFields selectList, IDbConnection connectionToUse, IPredicate selectFilter, 
			long maxNumberOfItemsToReturn, ISortExpression sortClauses, IGroupByCollection groupByClause, bool allowDuplicates)
		{
			// call the generic construction code
			return CreateSelectDQ(selectList.GetAsEntityFieldCoreArray(), selectList.GetAsPersistenceInfoArray(), connectionToUse, selectFilter,
						maxNumberOfItemsToReturn, sortClauses, groupByClause, allowDuplicates);
		}


		/// <summary>
		/// Creates a new Select Query which is ready to use, based on the specified select list and the specified set of relations.
		/// If selectFilter is set to null, all rows are selected.
		/// </summary>
		/// <param name="selectList">list of fields to select</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="selectFilter">A complete IPredicate implementing object which contains the filter for the rows to select. When set to null, no 
		/// filtering is done, and all rows are returned.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relationsToWalk">list of EntityRelation objects, which will be used to formulate a FROM clause with INNER JOINs.</param>
		/// <param name="allowDuplicates">Flag which forces the inclusion of DISTINCT if set to true. If the resultset contains fields of type ntext, text or image, no duplicate filtering
		/// is done.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <returns>IRetrievalQuery instance which is ready to be used.</returns>
		/// <remarks>Selfservicing specific</remarks>
		/// <exception cref="System.ArgumentNullException">When selectList is null or when relationsToWalk is null.</exception>
		/// <exception cref="System.ArgumentException">When selectList contains no EntityField instances.</exception>
		/// <exception cref="System.ArgumentException">When selectList contains one or more EntityField instances which are not present in a filled groupByClause.</exception>
		public static IRetrievalQuery CreateSelectDQ(IEntityFields selectList, IDbConnection connectionToUse, IPredicate selectFilter, 
			long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relationsToWalk, bool allowDuplicates, IGroupByCollection groupByClause)
		{
			// call generic construction code
			return CreateSelectDQ(selectList.GetAsEntityFieldCoreArray(), selectList.GetAsPersistenceInfoArray(), connectionToUse, selectFilter, maxNumberOfItemsToReturn,
						sortClauses, relationsToWalk, allowDuplicates, groupByClause);
		}


		/// <summary>
		/// Creates a new Select Query which is ready to use. If selectFilter is set to null, all rows are selected.
		/// </summary>
		/// <param name="selectList">list of IEntityFieldCore objects to select</param>
		/// <param name="fieldsPersistenceInfo">Array of IFieldPersistenceInfo objects to use to build the select query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="selectFilter">A complete IPredicate implementing object which contains the filter for the rows to select. When set to null, no 
		/// filtering is done, and all rows are returned.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <param name="allowDuplicates">Flag which forces the inclusion of DISTINCT if set to true. If the resultset contains fields of type ntext, text or image, no duplicate filtering
		/// is done.</param>
		/// <returns>IRetrievalQuery instance which is ready to be used.</returns>
		/// <remarks>Generic version</remarks>
		/// <exception cref="System.ArgumentNullException">When selectList is null or fieldsPersistenceInfo is null</exception>
		/// <exception cref="System.ArgumentException">When selectList contains no EntityFieldCore instances or fieldsPersistenceInfo is empty.</exception>
		public static IRetrievalQuery CreateSelectDQ(IEntityFieldCore[] selectList, IFieldPersistenceInfo[] fieldsPersistenceInfo, 
					IDbConnection connectionToUse, IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, 
					IGroupByCollection groupByClause, bool allowDuplicates)
		{
			if(selectList==null)
			{
				throw new ArgumentNullException("selectList", "selectList can't be null.");
			}
			if(fieldsPersistenceInfo==null)
			{
				throw new ArgumentNullException("fieldsPersistenceInfo", "fieldsPersistenceInfo can't be null.");
			}
			if((selectList.Length<=0)||(fieldsPersistenceInfo.Length<=0))
			{
				throw new ArgumentException("No selectList specified in selectList.", "selectList");
			}

			IDbCommand command = CreateCommand();
			IRetrievalQuery selectQuery = new RetrievalQuery(connectionToUse, command);
			IDbSpecificCreator creator = new SqlServerSpecificCreator();

			StringBuilder queryText = new StringBuilder(SelectQueryBufferLength);
			StringBuilder resultsetText = new StringBuilder(SelectResultSetBufferLength);

			// first create the resultset text. During the loop, check if there are fields of type ntext, text or image. if so, we will
			// have to create another query if duplicates are not allowed.
			bool distinctViolatingTypesFound=false;
			for(int i=0;i<selectList.Length;i++)
			{
				if(i>0)
				{
					resultsetText.Append(",");
				}
				resultsetText.AppendFormat("{0}", creator.CreateFieldName(fieldsPersistenceInfo[i], selectList[i].Alias, true));

				if(!allowDuplicates)
				{
					distinctViolatingTypesFound |= (((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.NText)||
						((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.Text)||
						((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.Image));
				}
			}

			queryText.Append("SELECT ");

			if(!allowDuplicates)
			{
				// we now have to determine if there are fields in the resultset which violate the DISTINCT keyword. If so, we skip distinct.
				if(!distinctViolatingTypesFound)
				{
					queryText.Append(" DISTINCT");
				}
			}

			if(maxNumberOfItemsToReturn > 0)
			{
				queryText.AppendFormat(" TOP {0}", maxNumberOfItemsToReturn);
			}

			queryText.AppendFormat(" {0} FROM {1}", resultsetText.ToString(), creator.CreateObjectName(fieldsPersistenceInfo[0]));

			if(selectFilter!=null)
			{
				// append where clause
				selectFilter.DatabaseSpecificCreator = creator;
				int uniqueMarker=0;
				queryText.AppendFormat(" WHERE {0}", selectFilter.ToQueryText(ref uniqueMarker));

				for(int i=0;i<selectFilter.Parameters.Count;i++)
				{
					command.Parameters.Add(selectFilter.Parameters[i]);
				}
			}

			if(sortClauses!=null)
			{
				if(sortClauses.Count>0)
				{
					AppendOrderByClause(queryText, sortClauses, creator);
				}
			}

			if(groupByClause!=null)
			{
				// append GROUP BY clause
				AppendGroupByClause(queryText, groupByClause, creator);
			}

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;

			// query is done. 
			return selectQuery;
		}


		/// <summary>
		/// Creates a new Select Query which is ready to use, based on the specified select list and the specified set of relations.
		/// If selectFilter is set to null, all rows are selected.
		/// </summary>
		/// <param name="selectList">list of IEntityFieldCore objects to select</param>
		/// <param name="fieldsPersistenceInfo">Array of IFieldPersistenceInfo objects to use to build the select query</param>
		/// <param name="connectionToUse">The connection to use for the query</param>
		/// <param name="selectFilter">A complete IPredicate implementing object which contains the filter for the rows to select. When set to null, no 
		/// filtering is done, and all rows are returned.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query. 
		/// If the used Dynamic Query Engine supports it, 'TOP' is used to limit the amount of rows to return. 
		/// When set to 0, no limitations are specified.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relationsToWalk">list of EntityRelation objects, which will be used to formulate a FROM clause with INNER JOINs.</param>
		/// <param name="allowDuplicates">Flag which forces the inclusion of DISTINCT if set to true. If the resultset contains fields of type ntext, text or image, no duplicate filtering
		/// is done.</param>
		/// <param name="groupByClause">The list of fields to group by on. When not specified or an empty collection is specified, no group by clause
		/// is added to the query. A check is performed for each field in the selectList. If a field in the selectList is not present in the groupByClause
		/// collection, an exception is thrown.</param>
		/// <returns>IRetrievalQuery instance which is ready to be used.</returns>
		/// <remarks>Generic version</remarks>
		/// <exception cref="System.ArgumentNullException">When selectList is null or fieldsPersistenceInfo is null or relationsToWalk is null</exception>
		/// <exception cref="System.ArgumentException">When selectList contains no EntityFieldCore instances or fieldsPersistenceInfo is empty.</exception>
		public static IRetrievalQuery CreateSelectDQ(IEntityFieldCore[] selectList, IFieldPersistenceInfo[] fieldsPersistenceInfo, 
					IDbConnection connectionToUse, IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, 
					IRelationCollection relationsToWalk, bool allowDuplicates, IGroupByCollection groupByClause)
		{
			if(selectList==null)
			{
				throw new ArgumentNullException("selectList", "selectList can't be null.");
			}
			if(fieldsPersistenceInfo==null)
			{
				throw new ArgumentNullException("fieldsPersistenceInfo", "fieldsPersistenceInfo can't be null.");
			}
			if((selectList.Length<=0)||(fieldsPersistenceInfo.Length<=0))
			{
				throw new ArgumentException("No selectList specified in selectList.", "selectList");
			}
			if(relationsToWalk==null)
			{
				throw new ArgumentNullException("relationsToWalk", "relationsToWalk can't be null.");
			}
			if(((RelationCollection)relationsToWalk).Count<=0)
			{
				// no relations specified, do a normal query
				return CreateSelectDQ(selectList, fieldsPersistenceInfo, connectionToUse, selectFilter, maxNumberOfItemsToReturn, sortClauses, groupByClause, allowDuplicates);
			}

			IDbCommand command = CreateCommand();
			IRetrievalQuery selectQuery = new RetrievalQuery(connectionToUse, command);
			IDbSpecificCreator creator = new SqlServerSpecificCreator();

			StringBuilder queryText = new StringBuilder(SelectJoinQueryBufferLength);
			StringBuilder resultsetText = new StringBuilder(SelectResultSetBufferLength);

			// first create the resultset text. During the loop, check if there are fields of type ntext, text or image. if so, we will
			// have to create another query if duplicates are not allowed.
			bool distinctViolatingTypesFound=false;
			for(int i=0;i<selectList.Length;i++)
			{
				if(i>0)
				{
					resultsetText.Append(",");
				}
				resultsetText.AppendFormat("{0}", creator.CreateFieldName(fieldsPersistenceInfo[i], selectList[i].Alias, true));

				if(!allowDuplicates)
				{
					distinctViolatingTypesFound |= (((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.NText)||
						((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.Text)||
						((SqlDbType)fieldsPersistenceInfo[i].SourceColumnDbType == SqlDbType.Image));
				}
			}

			queryText.Append("SELECT");

			if(!allowDuplicates)
			{
				// we now have to determine if there are fields in the resultset which violate the DISTINCT keyword. If so, we skip distinct.
				if(!distinctViolatingTypesFound)
				{
					queryText.Append(" DISTINCT");
				}
			}

			if(maxNumberOfItemsToReturn > 0)
			{
				queryText.AppendFormat(" TOP {0}", maxNumberOfItemsToReturn);
			}

			queryText.AppendFormat(" {0} FROM", resultsetText.ToString());

			// build join list.
			int uniqueMarker=0;
			relationsToWalk.DatabaseSpecificCreator = creator;
			queryText.Append(relationsToWalk.ToQueryText(ref uniqueMarker));

			for(int i=0;i<((RelationCollection)relationsToWalk).CustomFilterParameters.Count;i++)
			{
				command.Parameters.Add(((RelationCollection)relationsToWalk).CustomFilterParameters[i]);
			}

			// build where clause
			if(selectFilter!=null)
			{
				// append where clause
				selectFilter.DatabaseSpecificCreator = creator;
				queryText.AppendFormat(" WHERE {0}", selectFilter.ToQueryText(ref uniqueMarker));

				for(int i=0;i<selectFilter.Parameters.Count;i++)
				{
					command.Parameters.Add(selectFilter.Parameters[i]);
				}
			}

			if(sortClauses!=null)
			{
				if(sortClauses.Count>0)
				{
					AppendOrderByClause(queryText, sortClauses, creator);
				}
			}

			if(groupByClause!=null)
			{
				// append GROUP BY clause
				AppendGroupByClause(queryText, groupByClause, creator);
			}

			command.CommandText = queryText.ToString();
			command.CommandType = CommandType.Text;

			// query is done. 
			return selectQuery;
		}
		#endregion


		/// <summary>
		/// Appends a GROUP BY clause to the query specified.
		/// </summary>
		/// <param name="queryText">query text currently being build</param>
		/// <param name="groupByClause">group by collection</param>
		/// <param name="creator">Creator for sqlserver specific sql</param>
		private static void AppendGroupByClause(StringBuilder queryText, IGroupByCollection groupByClause, IDbSpecificCreator creator)
		{
			queryText.Append(" GROUP BY ");
			for(int i=0;i<groupByClause.Count;i++)
			{
				if(i>0)
				{
					queryText.Append(",");
				}
				queryText.AppendFormat("{0}", creator.CreateFieldName(groupByClause[i], groupByClause[i].Name));
			}
		}


		/// <summary>
		/// Appends an ORDER BY clause to the query specified.
		/// </summary>
		/// <param name="queryText">query text currently being build</param>
		/// <param name="sortClauses">sort clauses collection</param>
		/// <param name="creator">Creator for sqlserver specific sql</param>
		private static void AppendOrderByClause(StringBuilder queryText, ISortExpression sortClauses, IDbSpecificCreator creator)
		{
			// append ORDER BY plus the sort clauses
			queryText.Append(" ORDER BY ");
			for(int i=0;i<sortClauses.Count;i++)
			{
				ISortClause sortClauseToUse = sortClauses[i];
				if(i>0)
				{
					queryText.Append(",");
				}
				queryText.AppendFormat("{0} {1}", creator.CreateFieldName(sortClauseToUse.PersistenceInfo, sortClauseToUse.FieldToSortCore.Name), creator.ConvertSortOperator(sortClauseToUse.SortOperatorToUse));
			}
		}


		/// <summary>
		/// Constructs the list of fields to update plus its corresponding fieldpersistenceinfo list.
		/// </summary>
		/// <param name="fields"></param>
		/// <param name="fieldsPersistenceInfo"></param>
		/// <param name="fieldsToUpdate">will be altered</param>
		/// <param name="persistenceInfoFieldsToUpdate">will be altered</param>
		private static void ConstructFieldsToUpdateList(IEntityFieldCore[] fields, IFieldPersistenceInfo[] fieldsPersistenceInfo, ref ArrayList fieldsToUpdate, ref ArrayList persistenceInfoFieldsToUpdate)
		{
			for(int i=0;i<fields.Length;i++)
			{
				if((fields[i].IsChanged)&&(!fields[i].IsPrimaryKey)&&(!fieldsPersistenceInfo[i].IsIdentity))
				{
					// field can be updated
					fieldsToUpdate.Add(fields[i]);
					persistenceInfoFieldsToUpdate.Add(fieldsPersistenceInfo[i]);
				}
			}
		}


		/// <summary>
		/// Creates a new IDbCommand object and initializes it
		/// </summary>
		/// <returns>ready to use IDbCommand object</returns>
		private static IDbCommand CreateCommand()
		{
			IDbCommand toReturn = new SqlCommand();
			toReturn.CommandTimeout = _commandTimeOut;

			return toReturn;
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets the command time out (in seconds). This is a global setting, so every Command object created after you've set this
		/// property to a value will have that value as CommandTimeOut. Default is 30 seconds which is the ADO.NET default.
		/// Do not set this property by hand, use the selfservicing dbUtils class to do that for you.
		/// Adapter's DataAccessAdapter class has its own, per call, command timeout setting, which is recommended over this setting, which is global
		/// for all calls.
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
			}
		}
		#endregion
	}
}
