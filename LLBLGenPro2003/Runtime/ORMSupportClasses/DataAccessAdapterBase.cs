/////////////////////////////////////////////////////////////
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Data.Common;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Base class for DAA classes which are generated.
	/// </summary>
	public abstract class DataAccessAdapterBase : IDataAccessAdapter, IDisposable
	{
		#region Private Enums
		/// <summary>
		/// Enum which is used to signal the element removal routine what to do while removing hte elements.
		/// This is a performance issue, now the loop has to be run just once
		/// </summary>
		private enum ActionToPerformDuringRemove:int
		{
			/// <summary>
			/// No action
			/// </summary>
			None, 
			/// <summary>
			/// Call ITransactionalElement.TransactionCommit()
			/// </summary>
			SendCommit,
			/// <summary>
			/// Call ITransactionalElement.TransactionRollback()
			/// </summary>
			SendRollback
		}
		#endregion
		
		#region Class Member Declarations
		private ITypeDefaultValue	_typeDefaultValueSupplier;
		private IsolationLevel		_transactionIsolationLevel;
		private string				_transactionName, _connectionString;
		private IDbConnection		_activeConnection;
		private IDbTransaction		_physicalTransaction;
		private ArrayList			_transactionParticipants, _entitiesInTransaction, _participantsInProgress;
		private bool				_isTransactionInProgress, _isDisposed, _keepConnectionOpen;
		private int					_commandTimeOut, _recursionCounter;
		#endregion

		#region Private Constants
		private const int defaultTimeOut = 30;
		#endregion
		
		/// <summary>
		/// CTor
		/// </summary>
		public DataAccessAdapterBase()
		{
			_typeDefaultValueSupplier = null;
			_transactionIsolationLevel = IsolationLevel.ReadCommitted;

			_transactionName = String.Empty;
			_transactionParticipants = new ArrayList();
			_entitiesInTransaction = new ArrayList();
			_participantsInProgress = new ArrayList();

			_activeConnection = null;
			_connectionString = String.Empty;
			_physicalTransaction = null;
			_isDisposed=false;
			_isTransactionInProgress=false;
			_keepConnectionOpen=false;
			_commandTimeOut = defaultTimeOut;
			_recursionCounter = 0;
		}

		
		/// <summary>
		/// Executes the passed in action query and, if not null, runs it inside the passed in transaction.
		/// </summary>
		/// <param name="queryToExecute">ActionQuery to execute.</param>
		/// <returns>execution result, which is the amount of rows affected (if applicable)</returns>
		public virtual int ExecuteActionQuery(IActionQuery queryToExecute)
		{
			WireTransaction(queryToExecute);
			queryToExecute.Command.CommandTimeout = _commandTimeOut;
			OpenConnection();
			int toReturn = queryToExecute.Execute();
			if(!(_keepConnectionOpen||_isTransactionInProgress))
			{
				CloseConnection();
			}
			return toReturn;
		}


		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 row.
		/// It sets the connection object of the command object of query object passed in to the connection object of this class.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="fieldsToFill">The IEntityFields2 object to store the fetched data in</param>
		/// <param name="fieldsPersistenceInfo">The IFieldPersistenceInfo objects for the fieldsToFill fields</param>
		public virtual void ExecuteSingleRowRetrievalQuery(IRetrievalQuery queryToExecute, IEntityFields2 fieldsToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo)
		{
			queryToExecute.Connection=_activeConnection;
			WireTransaction(queryToExecute);
			IDataReader dataSource = null;
			queryToExecute.Command.CommandTimeout = _commandTimeOut;

			try
			{
				OpenConnection();

				dataSource = queryToExecute.Execute(CommandBehavior.SingleRow);
				FetchOneRow(dataSource, fieldsToFill, fieldsPersistenceInfo);
			}
			// all exceptions are fatal.
			finally
			{
				if(dataSource!=null)
				{
					if(!dataSource.IsClosed)
					{
						dataSource.Close();
					}
					dataSource.Dispose();
				}
				if(!(_keepConnectionOpen||_isTransactionInProgress))
				{
					CloseConnection();
				}
			}
		}


		/// <summary>
		/// Executes the passed in retrieval query and, if not null, runs it inside the passed in transaction. Used to read 1 or more rows.
		/// It sets the connection object of the command object of query object passed in to the connection object of this class.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="entityFactory">the factory object which can produce the entities this method has to fill.</param>
		/// <param name="collectionToFill">Collection to fill with the retrieved rows.</param>
		/// <param name="fieldsPersistenceInfo">The persistence information for the fields of the entity created by entityFactory</param>
		/// <param name="allowDuplicates">Flag to signal if duplicates in the datastream should be loaded into the collection (true) or not (false)</param>
		/// <param name="validatorToUse">Validator object to use when creating a new entity. Can be null.</param>
		public virtual void ExecuteMultiRowRetrievalQuery(IRetrievalQuery queryToExecute, IEntityFactory2 entityFactory, 
				IEntityCollection2 collectionToFill, IFieldPersistenceInfo[] fieldsPersistenceInfo, bool allowDuplicates, IValidator validatorToUse)
		{
			queryToExecute.Connection=_activeConnection;
			WireTransaction(queryToExecute);
			queryToExecute.Command.CommandTimeout = _commandTimeOut;

			// construct hashtable for filtering out duplicates. Each hashtable entry is at first a section of
			// empty cells. When a hashcode is found in the set of hashes, add an entry, if not existend to this
			// hashtable. When the hashcode already is added to this hashtable, the entity of the new hashcode is
			// compared to all the entities with the same hashcode in the list related to the hashcode in this table.
			// when an equal object is found, it's a real duplicate, otherwise the entity is added to the list and the
			// collection.
			Hashtable objectHashtable = new Hashtable();
			Hashtable objectHashes = new Hashtable();
			EntityCollectionBase2 collection = (EntityCollectionBase2)collectionToFill;		// pre-cast collection.

			IDataReader dataSource = null;
			bool isReadOnlySave = collection.IsReadOnly;
			bool doNotPerformAddIfPresentSave = collection.DoNotPerformAddIfPresent;
			collection.IsReadOnly=false;
			collection.DoNotPerformAddIfPresent=false;

			// first add the existing objects to the hashtables, if they're not new
			for (int i = 0; i < collection.Count; i++)
			{
				IEntity2 currentEntity = collection[i];
				if(currentEntity.IsNew)
				{
					continue;
				}
				CheckForDuplicate(currentEntity, ref objectHashtable, ref objectHashes);
			}

			try
			{
				OpenConnection();

				dataSource = queryToExecute.Execute(CommandBehavior.Default);
				if(dataSource==null)
				{
					// nothing to read from
					return;
				}

				if(dataSource.IsClosed)
				{
					// can't read
					return;
				}

				int[] fieldIndexToOrdinal = new int[fieldsPersistenceInfo.Length];
				for (int i = 0; i < fieldIndexToOrdinal.Length; i++)
				{
					fieldIndexToOrdinal[i]=-1;
				}

				// for each row fetched, create a new entity and fill it with the row
				while(dataSource.Read())
				{
					IEntityFields2 newFields = entityFactory.CreateFields();
					ReadRowIntoFields(dataSource, newFields, fieldsPersistenceInfo, ref fieldIndexToOrdinal);

					IEntity2 entityToAdd = entityFactory.Create(newFields);
					if(validatorToUse!=null)
					{
						entityToAdd.Validator = validatorToUse;
					}

					// set state.
					entityToAdd.Fields.State = EntityState.Fetched;
					// it should be set to false, because the entity is read from the database
					entityToAdd.IsNew=false;

					if(allowDuplicates)
					{
						// add it to the collection.
						collection.Add(entityToAdd);
					}
					else
					{
						// test if we already have read this entity in the resultset or if it's already present in the collection. If not, read it.
						if(CheckForDuplicate(entityToAdd, ref objectHashtable, ref objectHashes))
						{
							// add it to the collection.
							collection.Add(entityToAdd);
						}
					}
				}
			}
				// all exceptions are fatal.
			finally
			{
				if(dataSource!=null)
				{
					if(!dataSource.IsClosed)
					{
						dataSource.Close();
					}
					dataSource.Dispose();
				}
				if(!(_keepConnectionOpen||_isTransactionInProgress))
				{
					CloseConnection();
				}

				collection.IsReadOnly=isReadOnlySave;
				collection.DoNotPerformAddIfPresent=doNotPerformAddIfPresentSave;
			}
		}


		/// <summary>
		/// Executes the passed in retrieval query and returns the results as a datatable using the passed in data-adapter. 
		/// It sets the connection object of the command object of query object passed in to the connection object of this class.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param>
		/// <returns>DataTable with the rows requested</returns>
		public virtual DataTable ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse)
		{
			DataTable toReturn = new DataTable();
			queryToExecute.Command.CommandTimeout=_commandTimeOut;
			OpenConnection();
			// wire up connection, command with adapter
			queryToExecute.Connection=_activeConnection;
			WireTransaction(queryToExecute);
			((IDbDataAdapter)dataAdapterToUse).SelectCommand = queryToExecute.Command;
			dataAdapterToUse.Fill(toReturn);

			if(!(_keepConnectionOpen||_isTransactionInProgress))
			{
				CloseConnection();
			}
			return toReturn;
		}


		/// <summary>
		/// Executes the passed in retrieval query and returns the results in thedatatable specified using the passed in data-adapter. 
		/// It sets the connection object of the command object of query object passed in to the connection object of this class.
		/// </summary>
		/// <param name="queryToExecute">Retrieval query to execute</param>
		/// <param name="dataAdapterToUse">The dataadapter to use to fill the datatable.</param>
		/// <param name="tableToFill">DataTable to fill</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public virtual bool ExecuteMultiRowDataTableRetrievalQuery(IRetrievalQuery queryToExecute, DbDataAdapter dataAdapterToUse, DataTable tableToFill)
		{
			queryToExecute.Command.CommandTimeout=_commandTimeOut;
			OpenConnection();
			// wire up connection, command with adapter
			queryToExecute.Connection=_activeConnection;
			WireTransaction(queryToExecute);
			((IDbDataAdapter)dataAdapterToUse).SelectCommand = queryToExecute.Command;
			dataAdapterToUse.Fill(tableToFill);
			if(!(_keepConnectionOpen||_isTransactionInProgress))
			{
				CloseConnection();
			}
			return true;
		}


		/// <summary>
		/// Wires an active transaction to the command object of the passed in query. If no transaction is in progress, nothing is wired.
		/// </summary>
		/// <param name="queryToWire">Query to wire up with the passed in transaction</param>
		public virtual void WireTransaction(IQuery queryToWire)
		{
			if(!_isTransactionInProgress)
			{
				// nothing to wire
				return;
			}

			queryToWire.Command.Transaction = _physicalTransaction;
		}


		/// <summary>
		/// Starts a new transaction. All database activity after this call will be ran in this transaction and all objects will participate
		/// in this transaction until its committed or rolled back. 
		/// If there is a transaction in progress, an exception is thrown.
		/// Will create and open a new connection if a transaction is not open and/or available.
		/// </summary>
		/// <param name="isolationLevelToUse">The isolation level to use for this transaction</param>
		/// <param name="name">The name for this transaction</param>
		/// <exception cref="InvalidOperationException">If a transaction is already in progress.</exception>
		public virtual void StartTransaction(IsolationLevel isolationLevelToUse, string name)
		{
			if(_isTransactionInProgress)
			{
				throw new InvalidOperationException(String.Format("A transaction with the name '{0}' is already in progress. Commit or rollback that transaction first.", _transactionName));
			}
			_transactionName = name;
			_transactionIsolationLevel = isolationLevelToUse;

			_entitiesInTransaction.Clear();
			_participantsInProgress.Clear();

			// open connection if needed
			OpenConnection();

			_physicalTransaction = CreateNewPhysicalTransaction();
			if(_physicalTransaction!=null)
			{
				_isTransactionInProgress=true;
			}
		}


		/// <summary>
		/// Commits the transaction in action. It will end all database activity, since commiting a transaction is finalizing it. After
		/// calling Commit or Rollback, the ITransaction implementing class will reset itself. Will close the connection.
		/// </summary>
		/// <remarks>Will close the active connection unless KeepConnectionOpen has been set to true</remarks>
		public virtual void Commit()
		{
			if(_physicalTransaction==null)
			{
				// no transaction going on, however this situation should not happen.
				return;
			}

			if(!_isTransactionInProgress)
			{
				// no transaction going on
				return;
			}

			// commit the transaction
			_physicalTransaction.Commit();
			_isTransactionInProgress = false;
			_entitiesInTransaction.Clear();

			if(!_keepConnectionOpen)
			{
				_activeConnection.Close();
				_keepConnectionOpen=false;
			}

			// Commit and Remove all objects participating in this transaction from this transaction.
			RemoveElementsFromTransaction(ActionToPerformDuringRemove.SendCommit);

			// reset the transactional membervariables.
			Reset();
		}


		/// <summary>
		/// Rolls back the transaction in action. It will end all database activity, since commiting a transaction is finalizing it. After
		/// calling Commit or Rollback, the ITransaction implementing class will reset itself. 
		/// </summary>
		/// <remarks>Will close the active connection unless KeepConnectionOpen has been set to true</remarks>
		public virtual void Rollback()
		{
			if(_physicalTransaction==null)
			{
				// no transaction going on, however this situation should not happen.
				return;
			}

			if(!_isTransactionInProgress)
			{
				// no transaction going on
				return;
			}

			// rollback the transaction
			_physicalTransaction.Rollback();
			_isTransactionInProgress = false;
			_entitiesInTransaction.Clear();

			if(!_keepConnectionOpen)
			{
				_activeConnection.Close();
				_keepConnectionOpen=false;
			}

			// Remove all objects participating in this transaction from this transaction.
			RemoveElementsFromTransaction(ActionToPerformDuringRemove.SendRollback);

			// reset this object.
			Reset();
		}


		/// <summary>
		/// Opens the active connection object. If the connection is already open, nothing is done.
		/// If no connection object is present, a new one is created
		/// </summary>
		public virtual void OpenConnection()
		{
			if(_activeConnection==null)
			{
				_activeConnection = CreateNewPhysicalConnection(_connectionString);
			}
			if(_activeConnection.State!=ConnectionState.Open)
			{
				_activeConnection.Open();
			}
		}


		/// <summary>
		/// Closes the active connection. If no connection is available or the connection is closed, nothing is done.
		/// If there is a transaction in progress, it's rolled back.
		/// </summary>
		public virtual void CloseConnection()
		{
			// check if there is a transaction going on
			if(_isTransactionInProgress)
			{
				Rollback();
			}

			if(_activeConnection!=null)
			{
				if(_activeConnection.State!=ConnectionState.Closed)
				{
					_activeConnection.Close();
					_keepConnectionOpen=false;
				}
			}
		}


		/// <summary>
		/// Saves the passed in entity to the persistent storage. Will <i>not</i> refetch the entity after this save.
		/// The entity will stay out-of-sync. If the entity is new, it will be inserted, if the entity is existent, the changed
		/// entity fields will be changed in the database. Will do a recursive save.
		/// Will pass the concurrency predicate returned by GetConcurrencyPredicate(ConcurrencyPredicateType.Save) as update restriction.
		/// </summary>
		/// <param name="entityToSave">The entity to save</param>
		/// <returns>true if the save was succesful, false otherwise.</returns>
		/// <remarks>Will use a current transaction if a transaction is in progress</remarks>
		public bool SaveEntity(IEntity2 entityToSave)
		{
			return SaveEntity(entityToSave, false, entityToSave.GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
		}


		/// <summary>
		/// Saves the passed in entity to the persistent storage. If the entity is new, it will be inserted, if the entity is existent, the changed
		/// entity fields will be changed in the database. Will do a recursive save.
		/// Will pass the concurrency predicate returned by GetConcurrencyPredicate(ConcurrencyPredicateType.Save) as update restriction.
		/// </summary>
		/// <param name="entityToSave">The entity to save</param>
		/// <param name="refetchAfterSave">When true, it will refetch the entity from the persistent storage so it will be up-to-date
		/// after the save action.</param>
		/// <returns>true if the save was succesful, false otherwise.</returns>
		/// <remarks>Will use a current transaction if a transaction is in progress</remarks>
		public bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave)
		{
			return SaveEntity(entityToSave, refetchAfterSave, entityToSave.GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
		}


		/// <summary>
		/// Saves the passed in entity to the persistent storage. If the entity is new, it will be inserted, if the entity is existent, the changed
		/// entity fields will be changed in the database. Will do a recursive save.
		/// </summary>
		/// <param name="entityToSave">The entity to save</param>
		/// <param name="refetchAfterSave">When true, it will refetch the entity from the persistent storage so it will be up-to-date
		/// after the save action.</param>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new.</param>
		/// <returns>true if the save was succesful, false otherwise.</returns>
		/// <remarks>Will use a current transaction if a transaction is in progress</remarks>
		public virtual bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave, IPredicateExpression updateRestriction)
		{
			return SaveEntity(entityToSave, refetchAfterSave, updateRestriction, true);
		}


		/// <summary>
		/// Saves the passed in entity to the persistent storage. If the entity is new, it will be inserted, if the entity is existent, the changed
		/// entity fields will be changed in the database.
		/// </summary>
		/// <param name="entityToSave">The entity to save</param>
		/// <param name="refetchAfterSave">When true, it will refetch the entity from the persistent storage so it will be up-to-date
		/// after the save action.</param>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is new.</param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by entityToSave also.</param>
		/// <returns>true if the save was succesful, false otherwise.</returns>
		/// <remarks>Will use a current transaction if a transaction is in progress</remarks>
		public virtual bool SaveEntity(IEntity2 entityToSave, bool refetchAfterSave, IPredicateExpression updateRestriction, bool recurse)
		{
			// do not proceed if the entity to save is already in progress. 
			if(_participantsInProgress.Contains(entityToSave.ObjectID))
			{
				// already in progress, return
				return true;
			}

			// first validate the entity. It should throw an exception if the validation fails.
			entityToSave.Validate();

			bool saveKeepConnectionOpen = _keepConnectionOpen;
			bool transactionStartedInThisScope = false;

			IEntityCollection2 containedDependingEntities = null;
			IEntityCollection2 containedDependentEntities = null;
			ArrayList containedMemberCollections = null;

			bool saveSucceeded = true;
			try
			{
				if(recurse)
				{
					// flag another save in the recursion has started.
					SaveInRecursionStarted();

					containedDependingEntities = entityToSave.GetDependingRelatedEntities();
					containedDependentEntities = entityToSave.GetDependentRelatedEntities();
					containedMemberCollections = entityToSave.GetMemberEntityCollections();

					// check one of the entities in the dependent collection is an entity 'in progress'. If so,
					// we leave this routine now, so the save path from that entity will save this entity eventually.
					bool dependentAlreadyInProgress = DetermineIfDependentInProgress(containedDependentEntities);
					if(dependentAlreadyInProgress)
					{
						// done for now, skip this entity, as it can't be saved, because a dependent entity is still in progress.
						// return true so no error bells will go off.
						return true;
					}

					RemoveEntitiesAlreadyInTransaction(containedDependentEntities);

					if(!_isTransactionInProgress)
					{
						// start a transaction if the entity to save contains dirty objects which have to be persisted first.
						if((containedDependentEntities.Count>0)||(containedMemberCollections.Count>0)||(containedDependingEntities.Count>0))
						{
							// contains collections or dirty objects. start transaction
							StartTransaction(IsolationLevel.ReadCommitted, "RecursiveSave");
							transactionStartedInThisScope=true;
						}
					}

					_entitiesInTransaction.Add(entityToSave.ObjectID);
					// Add ourselves to the object list in progress. This will signal other entities which are saved during 
					// a recursive save and which will run into this same entity through a loop in the model that they have to
					// stop saving themselves as this entity will take care of that.
					_participantsInProgress.Add(entityToSave.ObjectID);

					// via recursion, save all dependent dirty entities FIRST.
					for (int i = 0; i < containedDependentEntities.Count; i++)
					{
						// recurse.
						SaveEntity(containedDependentEntities[i], refetchAfterSave, containedDependentEntities[i].GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
					}
				}

				// recursed saves of dirty referenced entities is done. Now save the entity that is the root of the object graph.
				// after that, the contained collections are saved (if any)

				// check whether save has to take place
				if(entityToSave.Fields.IsDirty)
				{
					if(_isTransactionInProgress)
					{
						// Set transaction to any value. This is done to roll back internal values if the transaction fails.
						((ITransactionalElement)entityToSave).Transaction = null;
					}
					else
					{
						OpenConnection();
						_keepConnectionOpen = refetchAfterSave;
					}

					// retrieve persistence information
					IFieldPersistenceInfo[] persistenceInfoObjects = GetFieldPersistenceInfos(entityToSave);

					// construct query
					IActionQuery saveQuery = null;
					if(entityToSave.IsNew)
					{
						saveQuery = CreateInsertDQ(entityToSave, persistenceInfoObjects);
					}
					else
					{
						IPredicateExpression filter = CreatePrimaryKeyFilter(entityToSave.Fields.PrimaryKeyFields);
						if(updateRestriction!=null)
						{
							// add predicate filter
							InsertPersistenceInfoObjects(updateRestriction);
							filter.AddWithAnd(updateRestriction);
						}
						saveQuery = CreateUpdateDQ(entityToSave, persistenceInfoObjects, filter);
					}

					// flag we're going to save an entity
					OnSaveEntity(saveQuery, entityToSave);
					
					// execute the query
					saveSucceeded = (ExecuteActionQuery(saveQuery) > 0);

					// flag save action was completed
					OnSaveEntityComplete(saveQuery, entityToSave);

					if(saveSucceeded)
					{
						if(entityToSave.IsNew)
						{
							// reflect sequence values in pk fields
							saveQuery.ReflectOutputValuesInRelatedFields();
						}
						// set state and other housekeeping info
						entityToSave.Fields.State=EntityState.OutOfSync;
						entityToSave.Fields.AcceptChanges();
						entityToSave.IsNew=false;

						// if refetch has to be done, refetch the entity. Use the fetch routine for that.
						if(refetchAfterSave)
						{
							// refetch the entity, alter flag.
							saveSucceeded &= FetchEntity(entityToSave);
						}
					}
					
					// done, flag entity as persisted if save was succesful
					if(saveSucceeded)
					{
						entityToSave.FlagAsSaved();
					}
					else
					{
						if(recurse)
						{
							// throw concurrency exception, failed.
							throw new ORMConcurrencyException("During a recursive save action an entity's save action failed. The entity which failed is enclosed.", entityToSave);
						}
					}
				}

				if(recurse)
				{
					// remove ourselves from the entities in progress, as we've saved ourselves if that was required
					_participantsInProgress.Remove(entityToSave.ObjectID);

					RemoveEntitiesAlreadyInTransaction(containedDependingEntities);

					// save all depending entities
					for (int i = 0; i < containedDependingEntities.Count; i++)
					{
						// recurse.
						SaveEntity(containedDependingEntities[i], refetchAfterSave, containedDependingEntities[i].GetConcurrencyPredicate(ConcurrencyPredicateType.Save), true);
					}

					// now save all contained entity collections.
					for (int i = 0; i < containedMemberCollections.Count; i++)
					{
						SaveEntityCollection((IEntityCollection2)containedMemberCollections[i], refetchAfterSave, true);
					}

					// done. Commit transaction if it was started in this scope
					if(transactionStartedInThisScope)
					{
						Commit();
						transactionStartedInThisScope=false;
					}
				}
			}
			catch
			{
				// if a transaction was started inside this scope, roll it back.
				if(transactionStartedInThisScope)
				{
					Rollback();
					transactionStartedInThisScope=false;
				}
				saveSucceeded = false;
				// bubble the exception upwards
				throw;
			}
			finally
			{
				_keepConnectionOpen = saveKeepConnectionOpen;
				// clean up a dangling automaticly opened connection if needed.
				if(!(_keepConnectionOpen || _isTransactionInProgress))
				{
					CloseConnection();
				}

				if(recurse)
				{
					SaveInRecursionEnded();
				}
			}
			return saveSucceeded;
		}


		/// <summary>
		/// Fetches an entity from the persistent storage into the passed in Entity2 object using a primary key filter. The primary key fields of
		/// the entity passed in have to have the primary key values. (Example: CustomerID has to have a value, when you want to fetch a CustomerEntity
		/// from the persistent storage into the passed in object)
		/// </summary>
		/// <param name="entityToFetch">The entity object in which the fetched entity data will be stored. The primary key fields have to have a value.</param>
		/// <remarks>Will use a current transaction if a transaction is in progress, so MVCC or other concurrency scheme used by the database can be
		/// utilized</remarks>
		/// <returns>true if the Fetch was succesful, false otherwise</returns>
		public virtual bool FetchEntity(IEntity2 entityToFetch)
		{
			if(entityToFetch==null)
			{
				return false;
			}

			IPredicateExpression filter = CreatePrimaryKeyFilter(entityToFetch.Fields.PrimaryKeyFields);
			bool fetchResult = FetchEntityUsingFilter(entityToFetch.Fields, entityToFetch.LLBLGenProEntityName, filter);
			entityToFetch.IsNew &= !fetchResult;
			return fetchResult;
		}
		
		
		/// <summary>
		/// Fetches an entity from the persistent storage into the object specified using the filter specified. 
		/// Use the entity's uniqueconstraint filter construction methods to construct the required uniqueConstraintFilter for the 
		/// unique constraint you want to use.
		/// </summary>
		/// <param name="entityToFetch">The entity object in which the fetched entity data will be stored.</param>
		/// <param name="uniqueConstraintFilter">The filter which should filter on fields with a unique constraint.</param>
		/// <returns>true if the Fetch was succesful, false otherwise</returns>
		public virtual bool FetchEntityUsingUniqueConstraint(IEntity2 entityToFetch, IPredicateExpression uniqueConstraintFilter)
		{
			if((entityToFetch==null)||(uniqueConstraintFilter==null))
			{
				return false;
			}

			InsertPersistenceInfoObjects(uniqueConstraintFilter);
			bool fetchResult = FetchEntityUsingFilter(entityToFetch.Fields, entityToFetch.LLBLGenProEntityName, uniqueConstraintFilter);
			entityToFetch.IsNew &= !fetchResult;
			return fetchResult;
		}
		
		
		/// <summary>
		/// Fetches a new entity using the filter/relation combination filter passed in via <i>filterBucket</i> and the new entity is created using the
		/// passed in entity factory. Use this method when fetching a related entity using a current entity (for example, fetch the related Customer entity
		/// of an existing Order entity)
		/// </summary>
		/// <param name="entityFactoryToUse">The factory which will be used to create a new entity object which will be fetched</param>
		/// <param name="filterBucket">the completely filled in IRelationPredicateBucket object which will be used as a filter for the fetch. The fetch
		/// will only load the first entity loaded, even if the filter results into more entities being fetched</param>
		/// <returns>The new entity fetched.</returns>
		public virtual IEntity2 FetchNewEntity(IEntityFactory2 entityFactoryToUse, IRelationPredicateBucket filterBucket)
		{
			if((entityFactoryToUse==null)||(filterBucket==null))
			{
				return null;
			}

			InsertPersistenceInfoObjects(filterBucket.PredicateExpression);
			IEntityFields2 newFields = entityFactoryToUse.CreateFields();
			bool fetchResult = false;
			if(((RelationCollection)filterBucket.Relations).Count > 0)
			{
				InsertPersistenceInfoObjects(filterBucket.Relations);
				fetchResult = FetchEntityUsingFilter(newFields, newFields[0].ContainingObjectName, filterBucket.PredicateExpression, filterBucket.Relations);
			}
			else
			{
				// no relations specified.
				fetchResult = FetchEntityUsingFilter(newFields, newFields[0].ContainingObjectName, filterBucket.PredicateExpression);
			}
			IEntity2 newEntity = entityFactoryToUse.Create(newFields);
			newEntity.IsNew &= !fetchResult;
			return newEntity;
		}
		
		
		/// <summary>
		/// Deletes the specified entity from the persistent storage. The entity is not usable after this call, the state is set to
		/// OutOfSync.
		/// Will use the current transaction if a transaction is in progress.
		/// If the passed in entity has a concurrency predicate factory object, the returned predicate expression is used to restrict the delete process.		
		/// </summary>
		/// <param name="entityToDelete">The entity instance to delete from the persistent storage</param>
		/// <returns>true if the delete was succesful, otherwise false.</returns>
		public virtual bool DeleteEntity(IEntity2 entityToDelete)
		{
			IPredicateExpression deleteRestriction = entityToDelete.GetConcurrencyPredicate(ConcurrencyPredicateType.Delete);
			if(deleteRestriction!=null)
			{
				return DeleteEntity(entityToDelete, deleteRestriction);
			}

			if(entityToDelete.Fields.PrimaryKeyFields.Count<=0)
			{
				// no primary key, can't delete
				return false;
			}

			if(_isTransactionInProgress)
			{
				// Set transaction to any value. This is done to roll back internal values if the transaction fails.
				((ITransactionalElement)entityToDelete).Transaction = null;
			}

			IPredicateExpression deleteFilter = CreatePrimaryKeyFilter(entityToDelete.Fields.PrimaryKeyFields);
			IFieldPersistenceInfo persistenceInfo = GetFieldPersistenceInfo(entityToDelete.Fields[0]);
			IActionQuery deleteQuery = CreateDeleteDQ(persistenceInfo, deleteFilter);

			// flag we're about to execute a delete action
			OnDeleteEntity(deleteQuery, entityToDelete);

			bool deleteSucceeded = (ExecuteActionQuery(deleteQuery) > 0);

			// flag we're done executing the delete action
			OnDeleteEntityComplete(deleteQuery, entityToDelete);

			if(deleteSucceeded)
			{
				entityToDelete.Fields.State = EntityState.Deleted;
			}
			return deleteSucceeded;
		}


		/// <summary>
		/// Deletes the specified entity from the persistent storage. The entity is not usable after this call, the state is set to
		/// OutOfSync.
		/// Will use the current transaction if a transaction is in progress.
		/// </summary>
		/// <param name="entityToDelete">The entity instance to delete from the persistent storage</param>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query</param>
		/// <returns>true if the delete was succesful, otherwise false.</returns>
		public virtual bool DeleteEntity(IEntity2 entityToDelete, IPredicateExpression deleteRestriction)
		{
			if(entityToDelete.Fields.PrimaryKeyFields.Count<=0)
			{
				// no primary key, can't delete
				return false;
			}

			if(deleteRestriction==null)
			{
				// do normal delete.
				return DeleteEntity(entityToDelete);
			}

			if(_isTransactionInProgress)
			{
				// Set transaction to any value. This is done to roll back internal values if the transaction fails.
				((ITransactionalElement)entityToDelete).Transaction = null;
			}

			IPredicateExpression deleteFilter = CreatePrimaryKeyFilter(entityToDelete.Fields.PrimaryKeyFields);
			InsertPersistenceInfoObjects(deleteRestriction);
			deleteFilter.AddWithAnd(deleteRestriction);
			IFieldPersistenceInfo persistenceInfo = GetFieldPersistenceInfo(entityToDelete.Fields[0]);
			IActionQuery deleteQuery = CreateDeleteDQ(persistenceInfo, deleteFilter);

			// flag we're about to execute a delete action
			OnDeleteEntity(deleteQuery, entityToDelete);

			bool deleteSucceeded = (ExecuteActionQuery(deleteQuery) > 0);
			
			// flag we're done executing the delete action
			OnDeleteEntityComplete(deleteQuery, entityToDelete);

			if(deleteSucceeded)
			{
				entityToDelete.Fields.State = EntityState.Deleted;
			}
			return deleteSucceeded;
		}


		/// <summary>
		/// Fetches one or more entities which match the filter information in the filterBucket into the EntityCollection passed.
		/// The entity collection object has to contain an entity factory object which will be the factory for the entity instances
		/// to be fetched.
		/// This overload returns all found entities and doesn't apply sorting
		/// </summary>
		/// <param name="collectionToFill">EntityCollection object containing an entity factory which has to be filled</param>
		/// <param name="filterBucket">filter information for retrieving the entities. If null, all entities are returned of the type created by
		/// the factory in the passed in EntityCollection instance.</param>
		public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket)
		{
			FetchEntityCollection(collectionToFill, filterBucket, 0, null);
		}

		
		/// <summary>
		/// Fetches one or more entities which match the filter information in the filterBucket into the EntityCollection passed.
		/// The entity collection object has to contain an entity factory object which will be the factory for the entity instances
		/// to be fetched.
		/// This overload returns all found entities and doesn't apply sorting
		/// </summary>
		/// <param name="collectionToFill">EntityCollection object containing an entity factory which has to be filled</param>
		/// <param name="filterBucket">filter information for retrieving the entities. If null, all entities are returned of the type created by
		/// the factory in the passed in EntityCollection instance.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of entities to return. If 0, all entities matching the filter are returned</param>
		public void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn)
		{
			FetchEntityCollection(collectionToFill, filterBucket, maxNumberOfItemsToReturn, null);
		}


		/// <summary>
		/// Fetches one or more entities which match the filter information in the filterBucket into the EntityCollection passed.
		/// The entity collection object has to contain an entity factory object which will be the factory for the entity instances
		/// to be fetched.
		/// This overload returns all found entities and doesn't apply sorting
		/// </summary>
		/// <param name="collectionToFill">EntityCollection object containing an entity factory which has to be filled</param>
		/// <param name="filterBucket">filter information for retrieving the entities. If null, all entities are returned of the type created by
		/// the factory in the passed in EntityCollection instance.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of entities to return. If 0, all entities matching the filter are returned</param>
		/// <param name="sortClauses">SortClause expression which is applied to the query executed, sorting the fetch result.</param>
		/// <exception cref="ArgumentException">If the passed in collectionToFill doesn't contain an entity factory.</exception>
		public virtual void FetchEntityCollection(IEntityCollection2 collectionToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(collectionToFill.EntityFactoryToUse==null)
			{
				// no factory set. 
				throw new ArgumentException("No entity factory specified in the passed in IEntityCollection2 object. Cannot continue", "collectionToFill");
			}

			bool relationsPresent = false;
			IPredicateExpression expressionToPass = null;
			InterpretFilterBucket(filterBucket, ref relationsPresent, ref expressionToPass);
			InsertPersistenceInfoObjects(sortClauses);

			IEntity2 newEntity = collectionToFill.EntityFactoryToUse.Create();
			IRetrievalQuery selectQuery = null;
			IFieldPersistenceInfo[] persistenceInfo = GetFieldPersistenceInfos(newEntity.LLBLGenProEntityName);
			if(relationsPresent)
			{
				selectQuery=CreateSelectDQ(newEntity.Fields, 
					persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, filterBucket.Relations, true, null);
			}
			else
			{
				selectQuery=CreateSelectDQ(newEntity.Fields, 
					persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, null, true);
			}

			// flag we're about to execute an entitycollection fetch
			OnFetchEntityCollection(selectQuery, collectionToFill);

			ExecuteMultiRowRetrievalQuery(selectQuery, collectionToFill.EntityFactoryToUse, collectionToFill, persistenceInfo, false, null);

			// flag we're done executing an entitycollection fetch
			OnFetchEntityCollectionComplete(selectQuery, collectionToFill);
		}


		/// <summary>
		/// Saves all dirty objects inside the collection passed to the persistent storage. It will do this inside a transaction if a transaction
		/// is not yet available. Will not refetch saved entities and will not recursively save the entities.
		/// </summary>
		/// <param name="collectionToSave">EntityCollection with one or more dirty entities which have to be persisted</param>
		/// <returns>the amount of persisted entities</returns>
		public int SaveEntityCollection(IEntityCollection2 collectionToSave)
		{
			return SaveEntityCollection(collectionToSave, false, false);
		}

		
		/// <summary>
		/// Saves all dirty objects inside the collection passed to the persistent storage. It will do this inside a transaction if a transaction
		/// is not yet available.
		/// </summary>
		/// <param name="collectionToSave">EntityCollection with one or more dirty entities which have to be persisted</param>
		/// <param name="refetchSavedEntitiesAfterSave">Refetches a saved entity from the database, so the entity will not be 'out of sync'</param>
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by the entities inside collectionToSave also.</param>
		/// <returns>the amount of persisted entities</returns>
		public virtual int SaveEntityCollection(IEntityCollection2 collectionToSave, bool refetchSavedEntitiesAfterSave, bool recurse)
		{
			bool localTransactionUsed = false;
			int amountSaved=0;

			try
			{
				if(!_isTransactionInProgress)
				{
					// start own transaction
					StartTransaction(IsolationLevel.ReadCommitted, "SaveEntityCollection");
					localTransactionUsed=true;
				}

				// flag we're starting a saveentitycollection 
				OnSaveEntityCollection(collectionToSave);

				for (int i = 0; i < collectionToSave.Count; i++)
				{
					if(collectionToSave[i].Fields.IsDirty || recurse)
					{
						IEntity2 entityToSave = collectionToSave[i];

						if(recurse)
						{
							if(_entitiesInTransaction.Contains(entityToSave.ObjectID))
							{
								// already in process.
								continue;
							}
						}

						// save it.
						bool saveSucceeded = SaveEntity(entityToSave, refetchSavedEntitiesAfterSave, entityToSave.GetConcurrencyPredicate(ConcurrencyPredicateType.Save), recurse);
						if(saveSucceeded)
						{
							amountSaved++;
						}
					}
				}
				// done
				if(localTransactionUsed)
				{
					// commit local transaction
					Commit();
				}
			}
			catch
			{
				if(localTransactionUsed)
				{
					// abort
					Rollback();
				}
				// throw the exception further
				throw;
			}
			finally
			{
				// clean up a dangling automaticly opened connection if needed.
				if(!(_keepConnectionOpen || _isTransactionInProgress))
				{
					CloseConnection();
				}

				// flag we're done with saveentitycollection 
				OnSaveEntityCollectionComplete(collectionToSave);
			}

			return amountSaved;	
		}


		/// <summary>
		/// Deletes all dirty objects inside the collection passed from the persistent storage. It will do this inside a transaction if a transaction
		/// is not yet available. Entities which are physically deleted from the persistent storage are marked with the state 'Deleted' but are not
		/// removed from the collection.
		/// </summary>
		/// <param name="collectionToDelete">EntityCollection with one or more dirty entities which have to be persisted</param>
		/// <returns>the amount of physically deleted entities</returns>
		public virtual int DeleteEntityCollection(IEntityCollection2 collectionToDelete)
		{
			if(collectionToDelete.Count<=0)
			{
				// no entities, nothing to do.
				return 0;
			}

			bool localTransactionUsed = false;
			int amountDeleted=0;
			if(!_isTransactionInProgress)
			{
				// start own transaction
				StartTransaction(IsolationLevel.ReadCommitted, "DeleteEntityCollection");
				localTransactionUsed=true;
			}

			try
			{
				// flag we're about to start a deleteentitycollection action
				OnDeleteEntityCollection(collectionToDelete);

				for (int i = 0; i < collectionToDelete.Count; i++)
				{
					IEntity2 entityToDelete = collectionToDelete[i];
					bool deleteSucceeded = DeleteEntity(entityToDelete, entityToDelete.GetConcurrencyPredicate(ConcurrencyPredicateType.Delete));
					if(deleteSucceeded)
					{
						amountDeleted++;
					}
				}
				// done
				if(localTransactionUsed)
				{
					// commit local transaction
					Commit();
				}
			}
			catch
			{
				if(localTransactionUsed)
				{
					// abort
					Rollback();
				}
				// throw the exception further
				throw;
			}
			finally
			{
				// clean up a dangling automaticly opened connection if needed.
				if(!(_keepConnectionOpen || _isTransactionInProgress))
				{
					CloseConnection();
				}

				// flag we're done executing deleteentitycollection action
				OnDeleteEntityCollectionComplete(collectionToDelete);
			}

			return amountDeleted;	
		}
		
		
		/// <summary>
		/// Deletes all entities of the name passed in as <i>entityName</i> (e.g. "CustomerEntity") from the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>.
		/// </summary>
		/// <param name="entityName">The name of the entity to retrieve persistence information. For example "CustomerEntity". This name can be
		/// retrieved from an existing entity's LLBLGenProEntityName property.</param>
		/// <param name="filterBucket">filter information to filter out the entities to delete</param>
		/// <returns>the amount of physically deleted entities</returns>
		public virtual int DeleteEntitiesDirectly(string entityName, IRelationPredicateBucket filterBucket)
		{
			// complete the filter
			bool relationsPresent = false;
			IPredicateExpression expressionToPass = null;
			InterpretFilterBucket(filterBucket, ref relationsPresent, ref expressionToPass);
			IActionQuery deleteQuery = null;
			IFieldPersistenceInfo[] persistenceInfos = GetFieldPersistenceInfos(entityName);

			if(relationsPresent)
			{
				deleteQuery=CreateDeleteDQ(persistenceInfos[0], expressionToPass, filterBucket.Relations);
			}
			else
			{
				deleteQuery=CreateDeleteDQ(persistenceInfos[0], expressionToPass);
			}

			// flag we're about to execute a delete entities directly query
			OnDeleteEntitiesDirectly(deleteQuery);

			int result = ExecuteActionQuery(deleteQuery);

			// flag we're done deleting
			OnDeleteEntitiesDirectlyComplete(deleteQuery);

			return result;
		}
		
		
		/// <summary>
		/// Updates all entities of the same type of the entity <i>entityWithNewValues</i> directly in the persistent storage if they match the filter
		/// supplied in <i>filterBucket</i>. Only the fields changed in entityWithNewValues are updated for these fields. 
		/// </summary>
		/// <param name="entityWithNewValues">Entity object which contains the new values for the entities of the same type and which match the filter
		/// in filterBucket. Only fields which are changed are updated.</param>
		/// <param name="filterBucket">filter information to filter out the entities to update.</param>
		/// <returns>the amount of physically updated entities</returns>
		public virtual int UpdateEntitiesDirectly(IEntity2 entityWithNewValues, IRelationPredicateBucket filterBucket)
		{
			// complete the filter
			bool relationsPresent = false;
			IPredicateExpression expressionToPass = null;
			InterpretFilterBucket(filterBucket, ref relationsPresent, ref expressionToPass);
			IActionQuery updateQuery = null;
			IFieldPersistenceInfo[] persistenceInfos = GetFieldPersistenceInfos(entityWithNewValues.LLBLGenProEntityName);
			if(relationsPresent)
			{
				updateQuery=CreateUpdateDQ(entityWithNewValues,	persistenceInfos, expressionToPass, filterBucket.Relations);
			}
			else
			{
				updateQuery=CreateUpdateDQ(entityWithNewValues, persistenceInfos, expressionToPass);
			}

			// flag we're about to execute an UpdateEntities directly query
			OnUpdateEntitiesDirectly(updateQuery);

			int result = ExecuteActionQuery(updateQuery);

			// flag we're done 
			OnUpdateEntitiesDirectlyComplete(updateQuery);

			return result;
		}


		/// <summary>
		/// Fetches the fields passed in fieldCollectionToFetch from the persistent storage using the relations and filter information stored in
		/// filterBucket into the DataTable object passed in. Use this routine to fill a typed list object. Doesn't apply any sorting, doesn't limit
		/// the resultset on the amount of rows to return, does allow duplicates.
		/// For TypedView filling, use the method FetchTypedView()
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields to fetch into the datatable. The fields
		/// inside this object are used to construct the selection resultset.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket)
		{
			FetchTypedList(fieldCollectionToFetch, dataTableToFill, filterBucket, 0, null, true);
		}


		/// <summary>
		/// Fetches the fields passed in fieldCollectionToFetch from the persistent storage using the relations and filter information stored in
		/// filterBucket into the DataTable object passed in. Use this routine to fill a typed list object. Doesn't apply any sorting, doesn't limit
		/// the resultset on the amount of rows to return.
		/// For TypedView filling, use the method FetchTypedView()
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields to fetch into the datatable. The fields
		/// inside this object are used to construct the selection resultset.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, bool allowDuplicates)
		{
			FetchTypedList(fieldCollectionToFetch, dataTableToFill, filterBucket, 0, null, allowDuplicates);
		}


		/// <summary>
		/// Fetches the fields passed in fieldCollectionToFetch from the persistent storage using the relations and filter information stored in
		/// filterBucket into the DataTable object passed in. Use this routine to fill a typed list object. Doesn't apply any sorting.
		/// For TypedView filling, use the method FetchTypedView()
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields to fetch into the datatable. The fields
		/// inside this object are used to construct the selection resultset.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. If 0, all rows matching the filter are returned</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, bool allowDuplicates)
		{
			FetchTypedList(fieldCollectionToFetch, dataTableToFill, filterBucket, maxNumberOfItemsToReturn, null, allowDuplicates);
		}


		/// <summary>
		/// Fetches the fields passed in fieldCollectionToFetch from the persistent storage using the relations and filter information stored in
		/// filterBucket into the DataTable object passed in. Use this routine to fill a typed list object. 
		/// For TypedView filling, use the method FetchTypedView()
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields to fetch into the datatable. The fields
		/// inside this object are used to construct the selection resultset. Use the typed list's method GetFieldsInfo() to retrieve
		/// this IEntityField2 information</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. If 0, all rows matching the filter are returned</param>
		/// <param name="sortClauses">SortClause expression which is applied to the query executed, sorting the fetch result.</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public virtual void FetchTypedList(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			IFieldPersistenceInfo[] persistenceInfo = new FieldPersistenceInfo[fieldCollectionToFetch.Count];

			// get the persistence info objects for the fields in the collection
			for (int i = 0; i < fieldCollectionToFetch.Count; i++)
			{
				persistenceInfo[i] = GetFieldPersistenceInfo(fieldCollectionToFetch[i]);
			}

			bool relationsPresent = false;
			IPredicateExpression expressionToPass = null;
			InterpretFilterBucket(filterBucket, ref relationsPresent, ref expressionToPass);
			InsertPersistenceInfoObjects(sortClauses);
			IRetrievalQuery selectQuery = null;

			// construct query
			if(relationsPresent)
			{
				selectQuery=CreateSelectDQ(fieldCollectionToFetch, persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, filterBucket.Relations, allowDuplicates, null);
			}
			else
			{
				selectQuery=CreateSelectDQ(fieldCollectionToFetch, persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, null, allowDuplicates);
			}

			// flag we're about to execute a fetch of a typed list
			OnFetchTypedList(selectQuery, fieldCollectionToFetch, dataTableToFill);

			ExecuteMultiRowDataTableRetrievalQuery(selectQuery, CreateNewPhysicalDataAdapter(), dataTableToFill);

			// flag we're done fetching
			OnFetchTypedListComplete(selectQuery, fieldCollectionToFetch, dataTableToFill);
		}


		/// <summary>
		/// Fetches the Typed View fields passed in fieldCollectionToFetch from the persistent storage using the filter information stored in
		/// filterBucket into the DataTable object passed in. Doesn't apply any sorting, doesn't limit the amount of rows returned by the query, doesn't
		/// apply any filtering, allows duplicate rows.
		/// Use this routine to fill a TypedView object.
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields of the typed view to fetch into the datatable.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
		{
			FetchTypedView(fieldCollectionToFetch, dataTableToFill, null, 0, null, true);
		}


		/// <summary>
		/// Fetches the Typed View fields passed in fieldCollectionToFetch from the persistent storage using the filter information stored in
		/// filterBucket into the DataTable object passed in. Doesn't apply any sorting, doesn't limit the amount of rows returned by the query, doesn't
		/// apply any filtering.
		/// Use this routine to fill a TypedView object.
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields of the typed view to fetch into the datatable.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, bool allowDuplicates)
		{
			FetchTypedView(fieldCollectionToFetch, dataTableToFill, null, 0, null, allowDuplicates);
		}


		/// <summary>
		/// Fetches the Typed View fields passed in fieldCollectionToFetch from the persistent storage using the filter information stored in
		/// filterBucket into the DataTable object passed in. Doesn't apply any sorting, doesn't limit the amount of rows returned by the query.
		/// Use this routine to fill a TypedView object.
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields of the typed view to fetch into the datatable.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, bool allowDuplicates)
		{
			FetchTypedView(fieldCollectionToFetch, dataTableToFill, filterBucket, 0, null, allowDuplicates);
		}


		/// <summary>
		/// Fetches the Typed View fields passed in fieldCollectionToFetch from the persistent storage using the filter information stored in
		/// filterBucket into the DataTable object passed in. Doesn't apply any sorting
		/// Use this routine to fill a TypedView object.
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields of the typed view to fetch into the datatable.</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data. 
		/// Use the TypedList's method GetRelationInfo() to retrieve this bucket.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. If 0, all rows matching the filter are returned</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		public void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, bool allowDuplicates)
		{
			FetchTypedView(fieldCollectionToFetch, dataTableToFill, filterBucket, maxNumberOfItemsToReturn, null, allowDuplicates);
		}


		/// <summary>
		/// Fetches the Typed View fields passed in fieldCollectionToFetch from the persistent storage using the filter information stored in
		/// filterBucket into the DataTable object passed in. Use this routine to fill a TypedView object.
		/// </summary>
		/// <param name="fieldCollectionToFetch">IEntityField2 collection which contains the fields of the typed view to fetch into the datatable.
		/// Use the Typed View's method GetFieldsInfo() to get this IEntityField2 field collection</param>
		/// <param name="dataTableToFill">The datatable object to fill with the data for the fields in fieldCollectionToFetch</param>
		/// <param name="filterBucket">filter information (relations and predicate expressions) for retrieving the data.</param>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. If 0, all rows matching the filter are returned</param>
		/// <param name="sortClauses">SortClause expression which is applied to the query executed, sorting the fetch result.</param>
		/// <param name="allowDuplicates">When true, it will not filter out duplicate rows, otherwise it will DISTINCT duplicate rows.</param>
		/// <remarks>To fill a DataTable with entity rows, use this method as well, by passing the Fields collection of an entity of the same type
		/// as the one you want to fetch as fieldCollectionToFetch.</remarks>
		public virtual void FetchTypedView(IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill, IRelationPredicateBucket filterBucket, int maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			IFieldPersistenceInfo[] persistenceInfo = GetFieldPersistenceInfos(fieldCollectionToFetch[0].ContainingObjectName);

			bool relationsPresent = false;
			IPredicateExpression expressionToPass = null;
			InterpretFilterBucket(filterBucket, ref relationsPresent, ref expressionToPass);
			InsertPersistenceInfoObjects(sortClauses);

			IRetrievalQuery selectQuery = null;

			// construct query
			if(relationsPresent)
			{
				selectQuery=CreateSelectDQ(fieldCollectionToFetch, persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, filterBucket.Relations, allowDuplicates, null);
			}
			else
			{
				selectQuery=CreateSelectDQ(fieldCollectionToFetch, persistenceInfo, expressionToPass, maxNumberOfItemsToReturn, sortClauses, null, allowDuplicates);
			}

			// flag we're about to execute a fetch of a typed view
			OnFetchTypedView(selectQuery, fieldCollectionToFetch, dataTableToFill);

			ExecuteMultiRowDataTableRetrievalQuery(selectQuery, CreateNewPhysicalDataAdapter(), dataTableToFill);

			// flag we're done fetching
			OnFetchTypedViewComplete(selectQuery, fieldCollectionToFetch, dataTableToFill);
		}


		/// <summary>
		/// Called right before the actual Save action is executed.
		/// </summary>
		/// <param name="saveQuery">the ActionQuery object which will be executed</param>
		/// <param name="entityToSave">the entity which will be saved by saveQuery</param>
		public virtual void OnSaveEntity(IActionQuery saveQuery, IEntity2 entityToSave)
		{
		}

		/// <summary>
		/// Called right after the actual Save action was executed.
		/// </summary>
		/// <param name="saveQuery">the ActionQuery object which will be executed</param>
		/// <param name="entityToSave">the entity which is saved by saveQuery</param>
		public virtual void OnSaveEntityComplete(IActionQuery saveQuery, IEntity2 entityToSave)
		{
		}

		/// <summary>
		/// Called at the start of the SaveEntityCollection() method
		/// </summary>
		/// <param name="entityCollectionToSave">the entity collection to save</param>
		public virtual void OnSaveEntityCollection(IEntityCollection2 entityCollectionToSave)
		{
		}

		/// <summary>
		/// Called at the end of the SaveEntityCollection() method
		/// </summary>
		/// <param name="entityCollectionToSave">the entity collection which was saved</param>
		public virtual void OnSaveEntityCollectionComplete(IEntityCollection2 entityCollectionToSave)
		{
		}

		/// <summary>
		/// Called right before the actual delete action is executed
		/// </summary>
		/// <param name="deleteQuery">the ActionQuery object which will be executed</param>
		/// <param name="entityToDelete">the entity which will be deleted by deleteQuery</param>
		public virtual void OnDeleteEntity(IActionQuery deleteQuery, IEntity2 entityToDelete)
		{
		}

		/// <summary>
		/// Called right before the actual delete action is executed
		/// </summary>
		/// <param name="deleteQuery">the ActionQuery object which will be executed</param>
		/// <param name="entityToDelete">the entity which was deleted by deleteQuery</param>
		public virtual void OnDeleteEntityComplete(IActionQuery deleteQuery, IEntity2 entityToDelete)
		{
		}

		/// <summary>
		/// Called at the start of the DeleteEntityCollection method
		/// </summary>
		/// <param name="entityCollectionToDelete">the entity collection to delete</param>
		public virtual void OnDeleteEntityCollection(IEntityCollection2 entityCollectionToDelete)
		{
		}

		/// <summary>
		/// Called at the end of the DeleteEntityCollection method
		/// </summary>
		/// <param name="entityCollectionToDelete">the entity collection which was delete</param>
		public virtual void OnDeleteEntityCollectionComplete(IEntityCollection2 entityCollectionToDelete)
		{
		}

		/// <summary>
		/// Called right before the actual delete query is executed
		/// </summary>
		/// <param name="deleteQuery">The ActionQuery to execute</param>
		public virtual void OnDeleteEntitiesDirectly(IActionQuery deleteQuery)
		{
		}

		/// <summary>
		/// Called right before the actual delete query is executed
		/// </summary>
		/// <param name="deleteQuery">The ActionQuery to execute</param>
		public virtual void OnDeleteEntitiesDirectlyComplete(IActionQuery deleteQuery)
		{
		}

		/// <summary>
		/// Called right before the actual fetch is executed.
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery which will be executed</param>
		/// <param name="fieldsToFetch">the IEntityFields2 object which will be filled by selectQuery</param>
		public virtual void OnFetchEntity(IRetrievalQuery selectQuery, IEntityFields2 fieldsToFetch)
		{
		}

		/// <summary>
		/// Called right after the actual fetch is executed.
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery which was executed</param>
		/// <param name="fieldsToFetch">the IEntityFields2 object which was filled by selectQuery</param>
		public virtual void OnFetchEntityComplete(IRetrievalQuery selectQuery, IEntityFields2 fieldsToFetch)
		{
		}

		/// <summary>
		/// Called right before the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery which will be executed</param>
		/// <param name="entityCollectionToFetch">the entity collection to fill</param>
		public virtual void OnFetchEntityCollection(IRetrievalQuery selectQuery, IEntityCollection2 entityCollectionToFetch)
		{
		}

		/// <summary>
		/// Called right after the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery which was executed</param>
		/// <param name="entityCollectionToFetch">the entity collection which was filled</param>
		public virtual void OnFetchEntityCollectionComplete(IRetrievalQuery selectQuery, IEntityCollection2 entityCollectionToFetch)
		{
		}


		/// <summary>
		/// Called right before the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery object to execute</param>
		/// <param name="fieldCollectionToFetch">the fieldslist used to construct the query</param>
		/// <param name="dataTableToFill">the datatable object to fill</param>
		public virtual void OnFetchTypedList(IRetrievalQuery selectQuery, IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
		{
		}

		/// <summary>
		/// Called right after the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery object which was executed</param>
		/// <param name="fieldCollectionToFetch">the fieldslist used to construct the query</param>
		/// <param name="dataTableToFill">the datatable object which was filled</param>
		public virtual void OnFetchTypedListComplete(IRetrievalQuery selectQuery, IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
		{
		}

		/// <summary>
		/// Called right before the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery object to execute</param>
		/// <param name="fieldCollectionToFetch">the fieldslist used to construct the query</param>
		/// <param name="dataTableToFill">the datatable object to fill</param>
		public virtual void OnFetchTypedView(IRetrievalQuery selectQuery, IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
		{
		}

		/// <summary>
		/// Called right after the actual fetch is executed
		/// </summary>
		/// <param name="selectQuery">the RetrievalQuery object which was executed</param>
		/// <param name="fieldCollectionToFetch">the fieldslist used to construct the query</param>
		/// <param name="dataTableToFill">the datatable object which was filled</param>
		public virtual void OnFetchTypedViewComplete(IRetrievalQuery selectQuery, IEntityFields2 fieldCollectionToFetch, DataTable dataTableToFill)
		{
		}

		/// <summary>
		/// Called right before the actual update query is executed
		/// </summary>
		/// <param name="updateQuery">The ActionQuery to execute</param>
		public virtual void OnUpdateEntitiesDirectly(IActionQuery updateQuery)
		{
		}

		/// <summary>
		/// Called right after the actual update query is executed
		/// </summary>
		/// <param name="updateQuery">The ActionQuery to execute</param>
		public virtual void OnUpdateEntitiesDirectlyComplete(IActionQuery updateQuery)
		{
		}

		/// <summary>
		/// Adds the passed in object as a participant of this transaction. 
		/// </summary>
		/// <param name="participant">The ITransactionalElement implementing object which actions have to be included in this transaction</param>
		protected void AddTransactionParticipant(ITransactionalElement participant)
		{
			if(!participant.ParticipatesInTransaction)
			{
				_transactionParticipants.Add(participant);
				// pass null, not used in Adapter.
				participant.Transaction = null;
			}
		}


		/// <summary>
		/// Removes the passed in object from the transaction.
		/// </summary>
		/// <param name="participant">The ITransactionalElement implementing object which should be removed from this transaction</param>
		protected void RemoveTransactionParticipant(ITransactionalElement participant)
		{
			if(_transactionParticipants.Contains(participant))
			{
				_transactionParticipants.Remove(participant);
				// pass null, not used in Adapter.
				participant.Transaction = null;
			}
		}


		/// <summary>
		/// Checks if an entity's ObjectID stored in the collection passed in is already in progress in the active transaction. If so, it
		/// will return true, otherwise false.
		/// </summary>
		/// <param name="dependentEntitiesToCheck">entities to check</param>
		/// <returns>true if an entity in the passed in collection is also in _participantsInProgress</returns>
		protected bool DetermineIfDependentInProgress(IEntityCollection2 dependentEntitiesToCheck)
		{
			bool dependentInProgress = false;
			for (int i = 0; i < dependentEntitiesToCheck.Count; i++)
			{
				dependentInProgress |= _participantsInProgress.Contains(dependentEntitiesToCheck[i].ObjectID);
				if(dependentInProgress)
				{
					// found one, that's enough
					break;
				}
			}

			return dependentInProgress;
		}


		/// <summary>
		/// Removes entities already in the transaction from the passed in list. This verify is done by comparing GUID
		/// values with the _entitiesInTransaction member collection. 
		/// </summary>
		/// <param name="containedDirtyEntities">List of dirty entities which are possible targets to save. All entities
		/// already participating in this transaction are removed from this list, because this can cause circles in the recursion</param>
		protected void RemoveEntitiesAlreadyInTransaction(IEntityCollection2 containedDirtyEntities)
		{
			ArrayList entitiesToRemove = new ArrayList();

			for (int i = 0; i < containedDirtyEntities.Count; i++)
			{
				if(_entitiesInTransaction.Contains(containedDirtyEntities[i].ObjectID))
				{
					// already in transaction
					entitiesToRemove.Add(containedDirtyEntities[i]);
				}
			}

			for (int i = 0; i < entitiesToRemove.Count; i++)
			{
				containedDirtyEntities.Remove((IEntity2)entitiesToRemove[i]);
			}
		}


		/// <summary>
		/// Creates a new connection object using the current connection string value
		/// </summary>
		/// <remarks>Will close and dispose an active connection.</remarks>
		protected void CreateConnection()
		{
			if(_activeConnection!=null)
			{
				if(_activeConnection.State==ConnectionState.Open)
				{
					CloseConnection();
					_activeConnection.Dispose();
				}
			}

			_activeConnection = CreateNewPhysicalConnection(_connectionString);
		}


		/// <summary>
		/// Returns the active connection object. If no connection object is present, a new one will be created.
		/// </summary>
		/// <returns>The active connection object</returns>
		protected IDbConnection GetActiveConnection()
		{
			if(_activeConnection==null)
			{
				_activeConnection = CreateNewPhysicalConnection(_connectionString);
			}

			return _activeConnection;
		}


		/// <summary>
		/// Creates a new physical connection object.
		/// </summary>
		/// <param name="connectionString">Connectionstring to use for the new connection object</param>
		/// <returns>IDbConnection implementing connection object.</returns>
		protected abstract IDbConnection CreateNewPhysicalConnection(string connectionString);
		/// <summary>
		/// Creates a new physical transaction object over the created connection. The connection is assumed to be open.
		/// </summary>
		/// <returns>a physical transaction object, like an instance of SqlTransaction.</returns>
		protected abstract IDbTransaction CreateNewPhysicalTransaction();
		/// <summary>
		/// Creates a new .NET DataAdapter for the database system this DataAccessAdapter object is targeting. 
		/// </summary>
		/// <returns>New .NET DataAdapter object</returns>
		protected abstract DbDataAdapter CreateNewPhysicalDataAdapter();
		/// <summary>
		/// Retrieves the persistence info for the field passed in. 
		/// </summary>
		/// <param name="field">Field which fieldpersistence info has to be retrieved</param>
		/// <returns>the requested persistence information</returns>
		protected abstract IFieldPersistenceInfo GetFieldPersistenceInfo(IEntityField2 field);
		/// <summary>
		/// Retrieves the persistence info objects for the fields of the entity passed in.
		/// </summary>
		/// <param name="entity">Entity object which fields the persistence information should be retrieved for</param>
		/// <returns>the requested persistence information</returns>
		protected abstract IFieldPersistenceInfo[] GetFieldPersistenceInfos(IEntity2 entity);
		/// <summary>
		/// Retrieves the persistence info objects for the fields of the entity passed in.
		/// </summary>
		/// <param name="entityName">Entity name for entity type which fields the persistence information should be retrieved for</param>
		/// <returns>the requested persistence information</returns>
		protected abstract IFieldPersistenceInfo[] GetFieldPersistenceInfos(string entityName);
		/// <summary>
		/// Inserts in each predicate expression element the persistence info object for the field used. If there is already a fieldpersistenceinfo 
		/// element for a given field, it is skipped. 
		/// </summary>
		/// <param name="expression">IPredicateExpression object which has predicate elements whose persistence info objects have to be
		/// set to a value.</param>
		protected abstract void InsertPersistenceInfoObjects(IPredicateExpression expression);
		/// <summary>
		/// Inserts in each entityrelation object the persistence info objects for the fields referenced.
		/// </summary>
		/// <param name="relations">IRelationCollection object which has entityrelation objects whose fields' persistence info objects have to be
		/// set to a value.</param>
		protected abstract void InsertPersistenceInfoObjects(IRelationCollection relations);
		/// <summary>
		/// Inserts in each SortClause object the persistence info object for the field referenced.
		/// </summary>
		/// <param name="sortClauses">ISortExpression object which has SortClause objects whose fields persistence info object has to be
		/// set to a value.</param>
		protected abstract void InsertPersistenceInfoObjects(ISortExpression sortClauses);
		/// <summary>
		/// Creates a new insert DQ for the entity passed in.
		/// </summary>
		/// <param name="entityToSave">the entity to create the Insert query for</param>
		/// <param name="persistenceInfoObjects">persistence objects for the entity</param>
		/// <returns>a fully usable IActionQuery object</returns>
		protected abstract IActionQuery CreateInsertDQ(IEntity2 entityToSave, IFieldPersistenceInfo[] persistenceInfoObjects);
		/// <summary>
		/// Creates a new Update DQ for the entity passed in.
		/// </summary>
		/// <param name="entityToSave">the entity to create the Update query for</param>
		/// <param name="persistenceInfoObjects">persistence objects for the entity</param>
		/// <param name="filter">The filter to use in the update query</param>
		/// <returns>a fully usable IActionQuery object</returns>
		protected abstract IActionQuery CreateUpdateDQ(IEntity2 entityToSave, IFieldPersistenceInfo[] persistenceInfoObjects, IPredicateExpression filter);
		/// <summary>
		/// Creates a new Update DQ for the entity passed in.
		/// </summary>
		/// <param name="entityWithNewValues">the entity to with new values to use for the SET clauses</param>
		/// <param name="persistenceInfoObjects">persistence objects for the fields in entityWithNewValues</param>
		/// <param name="filter">The filter to use in the update query</param>
		/// <param name="relationsToWalk">Relations to walk to fulfill the filter</param>
		/// <returns>a fully usable IActionQuery object</returns>
		protected abstract IActionQuery CreateUpdateDQ(IEntity2 entityWithNewValues, IFieldPersistenceInfo[] persistenceInfoObjects, 
			IPredicateExpression filter, IRelationCollection relationsToWalk);
		/// <summary>
		/// Creates a new Select DQ for the fields passed in using the parameters specified.
		/// </summary>
		/// <param name="fieldsToFetch">fields to fetch using the select</param>
		/// <param name="persistenceInfoObjects">persistence info objects for the fields</param>
		/// <param name="filter">filter to use for the where clause</param>
		/// <param name="maxNumberOfItemsToReturn">max. amount of rows to return</param>
		/// <param name="sortClauses">sort clause specifications to use</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <param name="allowDuplicates">flag to specify if duplicates should be returned</param>
		/// <returns>ready to use query to use.</returns>
		protected abstract IRetrievalQuery CreateSelectDQ(IEntityFields2 fieldsToFetch, IFieldPersistenceInfo[] persistenceInfoObjects, 
			IPredicateExpression filter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IGroupByCollection groupByClause, bool allowDuplicates);
		/// <summary>
		/// Creates a new Select DQ for the fields passed in using the parameters specified.
		/// </summary>
		/// <param name="fieldsToFetch">fields to fetch using the select</param>
		/// <param name="persistenceInfoObjects">persistence info objects for the fields</param>
		/// <param name="filter">filter to use for the where clause</param>
		/// <param name="maxNumberOfItemsToReturn">max. amount of rows to return</param>
		/// <param name="sortClauses">sort clause specifications to use</param>
		/// <param name="relationsToWalk">relations to walk to build the FROM clause</param>
		/// <param name="allowDuplicates">flag to specify if duplicates should be returned</param>
		/// <param name="groupByClause">group by clause to embed in the query</param>
		/// <returns>ready to use query to use.</returns>
		protected abstract IRetrievalQuery CreateSelectDQ(IEntityFields2 fieldsToFetch, IFieldPersistenceInfo[] persistenceInfoObjects, 
			IPredicateExpression filter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relationsToWalk, 
			bool allowDuplicates, IGroupByCollection groupByClause);
		/// <summary>
		/// Creates a new delete DQ for the entity passed in.
		/// </summary>
		/// <param name="persistenceInfoObject">persistence objects for the entity's first field.</param>
		/// <param name="filter">The filter to use in the delete query</param>
		/// <returns>a fully usable IActionQuery object</returns>
		protected abstract IActionQuery CreateDeleteDQ(IFieldPersistenceInfo persistenceInfoObject, IPredicateExpression filter);
		/// <summary>
		/// Creates a new delete DQ for the entity passed in.
		/// </summary>
		/// <param name="persistenceInfoObject">persistence objects for the entity's first field.</param>
		/// <param name="filter">The filter to use in the delete query</param>
		/// <param name="relationsToWalk">Relations to use walk to fulfill the filter</param>
		/// <returns>a fully usable IActionQuery object</returns>
		protected abstract IActionQuery CreateDeleteDQ(IFieldPersistenceInfo persistenceInfoObject, IPredicateExpression filter, 
			IRelationCollection relationsToWalk);


		/// <summary>
		/// Checks if the passed in entity is present in the hashtables passed in. If so
		/// </summary>
		/// <param name="entityToAdd">Entity which has to be tested if there was already a duplicate in the hashtables.</param>
		/// <param name="objectHashtable">See remarks</param>
		/// <param name="objectHashes">See remarks</param>
		/// <returns>true if there is no duplicate for hte passed in entity seen yet. False otherwise</returns>
		/// <remarks>construct hashtable for filtering out duplicates. Each hashtable entry is at first a section of
		/// empty cells. When a hashcode is found in the set of hashes, add an entry, if not existend to this
		/// hashtable. When the hashcode already is added to this hashtable, the entity of the new hashcode is
		/// compared to all the entities with the same hashcode in the list related to the hashcode in this table.
		/// when an equal object is found, it's a real duplicate, otherwise the entity is added to the list and the
		/// collection.</remarks>
		private bool CheckForDuplicate(IEntity2 entityToAdd, ref Hashtable objectHashtable, ref Hashtable objectHashes)
		{
			int entityHash = entityToAdd.GetHashCode();
			bool noDuplicateSeen=false;
			if(!objectHashes.ContainsKey(entityHash))
			{
				// no, so add it to the collection and its hash to the hashlist.
				objectHashes.Add(entityHash, null);
				// add new hash bucket to hashtable
				ArrayList newBucket = new ArrayList();
				newBucket.Add(entityToAdd);
				objectHashtable.Add(entityHash, newBucket);
				// flag that no duplicate has been seen.
				noDuplicateSeen=true;
			}
			else
			{
				// hashcode exists. Bucket is there.
				// Check if the entity is equal to any of the entities in the list related to this hashcode.
				ArrayList bucket = (ArrayList)objectHashtable[entityHash];
				bool equalFound=false;
				for (int i = 0; i < bucket.Count; i++)
				{
					EntityBase2 currentEntity=(EntityBase2)bucket[i];
					equalFound = currentEntity.Equals(entityToAdd);
					if(equalFound)
					{
						// duplicate
						break;
					}
				}

				if(!equalFound)
				{
					// not found, no duplicate
					noDuplicateSeen=true;
					bucket.Add(entityToAdd);
				}
			}

			return noDuplicateSeen;
		}


		/// <summary>
		/// Increases the recursion counter with 1. If the counter reaches 0, the objectID's in the _entitiesInTransaction collection are removed.
		/// </summary>
		private void SaveInRecursionStarted()
		{
			_recursionCounter++;
		}


		/// <summary>
		/// Decreases the recursion counter with 1. If the counter reaches 0, the objectID's in the _entitiesInTransaction collection are removed.
		/// </summary>
		private void SaveInRecursionEnded()
		{
			_recursionCounter--;

			if(_recursionCounter==0)
			{
				_entitiesInTransaction.Clear();
			}
		}


		/// <summary>
		/// Creates a new predicate expression which filters on the primary key fields and the set values for the
		/// given primary key fields. If no primary key fields are specified, null is returned.
		/// </summary>
		/// <param name="primaryKeyFields">IEntity2 instance for which the primary key filter has to be constructed</param>
		/// <returns>filled in predicate expression or null if no primary key fields are specified.</returns>
		private IPredicateExpression CreatePrimaryKeyFilter(ArrayList primaryKeyFields)
		{
			if(primaryKeyFields.Count<=0)
			{
				return null;
			}

			IPredicateExpression pkFilter = new PredicateExpression();

			for (int i = 0; i < primaryKeyFields.Count; i++)
			{
				IEntityField2 currentField = (IEntityField2)primaryKeyFields[i];
				IFieldPersistenceInfo persistenceInfo = GetFieldPersistenceInfo(currentField);
				pkFilter.AddWithAnd(new FieldCompareValuePredicate(currentField, persistenceInfo, ComparisonOperator.Equal));
			}

			return pkFilter;
		}


		/// <summary>
		/// Interprets the passed in filterbucket and returns information determined after interpreting the data inside the IRelationPredicateBucket object.
		/// The Relations and predicate expression are initialized with field persistence info objects
		/// </summary>
		/// <param name="filterBucket">The IRelationPredicateBucket object with the filter information to interepret</param>
		/// <param name="relationsPresent">Ref parameter which will be true if there are relation objects specified inside filterBucket</param>
		/// <param name="expressionToPass">Ref parameter which will be the predicate expression to pass to query construction code</param>
		private void InterpretFilterBucket(IRelationPredicateBucket filterBucket, ref bool relationsPresent, ref IPredicateExpression expressionToPass)
		{
			relationsPresent = false;
			expressionToPass = null;
			if(filterBucket!=null)
			{
				if(((RelationCollection)filterBucket.Relations).Count > 0)
				{
					InsertPersistenceInfoObjects(filterBucket.Relations);
					relationsPresent=true;
				}
				if(filterBucket.PredicateExpression!=null)
				{
					if(filterBucket.PredicateExpression.Count>0)
					{
						expressionToPass = filterBucket.PredicateExpression;
						InsertPersistenceInfoObjects(expressionToPass);
					}
				}
			}
		}


		/// <summary>
		/// Fetches an entity from the persistent storage using the filter specified.
		/// </summary>
		/// <param name="fieldsToFetch">The EntityFields2 object to store the entity data in</param>
		/// <param name="entityName">The name of the entity which data should be fetched, used for persistence info retrieval.</param>
		/// <param name="filter">The filter to use to retrieve one entity. If the filter matches more than 1 entity, the first entity read will be used.</param>
		/// <returns>true if fetch succeeded, false otherwise</returns>
		private bool FetchEntityUsingFilter(IEntityFields2 fieldsToFetch, string entityName, IPredicateExpression filter)
		{
			bool fetchSucceeded = false;

			fieldsToFetch.State = EntityState.OutOfSync;
			IFieldPersistenceInfo[] persistenceInfos = GetFieldPersistenceInfos(entityName); 
			IRetrievalQuery selectQuery = CreateSelectDQ(fieldsToFetch,	persistenceInfos, filter, 0, null, null, true);
			// Flag we're about to start a fetch entity action
			OnFetchEntity(selectQuery, fieldsToFetch);

			ExecuteSingleRowRetrievalQuery(selectQuery, fieldsToFetch, persistenceInfos);

			// Flag we're done with the fetch entity action
			OnFetchEntityComplete(selectQuery, fieldsToFetch);

			fetchSucceeded = (fieldsToFetch.State==EntityState.Fetched);
			return fetchSucceeded;
		}


		/// <summary>
		/// Fetches an entity from the persistent storage using the filter specified.
		/// </summary>
		/// <param name="fieldsToFetch">The EntityFields2 object to store the entity data in</param>
		/// <param name="entityName">The name of the entity which data should be fetched, used for persistence info retrieval.</param>
		/// <param name="filter">The filter to use to retrieve one entity. If the filter matches more than 1 entity, the first entity read will be used.</param>
		/// <param name="relations">the relation collection to use for the filtering</param>
		/// <returns>true if fetch succeeded, false otherwise</returns>
		private bool FetchEntityUsingFilter(IEntityFields2 fieldsToFetch, string entityName, IPredicateExpression filter, IRelationCollection relations)
		{
			bool fetchSucceeded = false;

			fieldsToFetch.State = EntityState.OutOfSync;
			IFieldPersistenceInfo[] persistenceInfos = GetFieldPersistenceInfos(entityName); 
			IRetrievalQuery selectQuery = CreateSelectDQ(fieldsToFetch,	persistenceInfos, filter, 0, null, relations, true, null);
			
			// Flag we're about to start a fetch entity action
			OnFetchEntity(selectQuery, fieldsToFetch);
			
			ExecuteSingleRowRetrievalQuery(selectQuery, fieldsToFetch, persistenceInfos);
			
			// Flag we're done with the fetch entity action
			OnFetchEntityComplete(selectQuery, fieldsToFetch);

			fetchSucceeded = (fieldsToFetch.State==EntityState.Fetched);
			return fetchSucceeded;
		}


		/// <summary>
		/// Removes all participating elements from this transaction and sends them a commit or rollback signal, based on the passed in boolean Commit.
		/// This action will make the participating objects to take care of their own connections again.
		/// </summary>
		/// <param name="action">Action to perform on each removed element.</param>
		private void RemoveElementsFromTransaction(ActionToPerformDuringRemove action)
		{
			for(int i=0;i<_transactionParticipants.Count;i++)
			{
				ITransactionalElement participant = (ITransactionalElement)_transactionParticipants[i];
				switch(action)
				{
					case ActionToPerformDuringRemove.None:
						// do nothing
						break;
					case ActionToPerformDuringRemove.SendCommit:
						participant.TransactionCommit();
						break;
					case ActionToPerformDuringRemove.SendRollback:
						participant.TransactionRollback();
						break;
				}
				participant.Transaction = null;
			}
		}


		/// <summary>
		/// Resets the transaction object. All participants will be notified.
		/// </summary>
		private void Reset()
		{
			// test if there is a transaction going on.
			if(_isTransactionInProgress)
			{
				Rollback();
			}

			RemoveElementsFromTransaction(ActionToPerformDuringRemove.None);

			_transactionParticipants.Clear();
			_participantsInProgress.Clear();
		
			if(_physicalTransaction!=null)
			{
				_physicalTransaction.Dispose();
			}
			_physicalTransaction = null;
			_isTransactionInProgress = false;
			_keepConnectionOpen=false;
		}


		/// <summary>
		/// Fetches one row from the open data-reader and places that row into the passed in object rowDestination. rowDestination
		/// should match the format of the rows read by DataSource. Will only read the current row.
		/// </summary>
		/// <param name="dataSource">The open datareader used to fetch the data</param>
		/// <param name="rowDestination">The IEntityFields2 implementing object where the data should be stored.</param>
		/// <param name="fieldsPersistenceInfo">The IFieldPersistenceInfo objects for the rowDestination fields</param>
		private void FetchOneRow(IDataReader dataSource, IEntityFields2 rowDestination, IFieldPersistenceInfo[] fieldsPersistenceInfo)
		{
			if(dataSource==null)
			{
				// nothing to read from
				return;
			}

			if(dataSource.IsClosed)
			{
				// can't read
				return;
			}

			// read 1 row. First advance to first byte
			if(dataSource.Read())
			{
				// sets current value directly, bypassing NewValue. If the resultset doesn't contain the requested column, the underlying persistent
				// storage has been changed compared to the generated code and the code should be re-generated. A column mismatch will result in an exception.
				int[] fieldIndexToOrdinal = new int[rowDestination.Count];
				for (int i = 0; i < fieldIndexToOrdinal.Length; i++)
				{
					fieldIndexToOrdinal[i]=-1;
				}
				ReadRowIntoFields(dataSource, rowDestination, fieldsPersistenceInfo, ref fieldIndexToOrdinal);

				// set state to fetched
				rowDestination.State = EntityState.Fetched;
			}
		}


		/// <summary>
		/// Fetches one row from the open data-reader and places that row into the passed in object rowDestination. rowDestination
		/// should match the format of the rows read by DataSource. Will only read the current row. The datareader is assumed to be initialized, which means, the 
		/// datareader is actually holding a row. (i.e. 'Read()' is called)
		/// </summary>
		/// <param name="dataSource">The open datareader used to fetch the data</param>
		/// <param name="rowDestination">The IEntityFields2 implementing object where the data should be stored.</param>
		/// <param name="fieldsPersistenceInfo">The IFieldPersistenceInfo objects for the rowDestination fields</param>
		/// <param name="fieldIndexToOrdinal">Array with ordinal positions per field index. Use the field index to index into this array to retrieve its ordinal.
		/// Is constructed at runtime, the first time this method is called. Speeds up multi-row retrieval queries.</param>
		private void ReadRowIntoFields(IDataReader dataSource, IEntityFields2 rowDestination, IFieldPersistenceInfo[] fieldsPersistenceInfo, ref int[] fieldIndexToOrdinal)
		{
			// sets current value directly, bypassing NewValue. If the resultset doesn't contain the requested column, the underlying persistent
			// storage has been changed compared to the generated code and the code should be re-generated. A column mismatch will result in an exception.
			int columnOrdinal = 0;
			for(int i=0;i<rowDestination.Count;i++)
			{
				if(fieldIndexToOrdinal[i]==-1)
				{
					// not initialized yet, set ordinal
					// prepare for aliases. 
					try
					{
						if(fieldsPersistenceInfo[i].SourceColumnName!=rowDestination[i].Name)
						{
							// field is aliased in query, use field name
							columnOrdinal = dataSource.GetOrdinal(rowDestination[i].Name);
						}
						else
						{
							// use sourcecolumn
							columnOrdinal = dataSource.GetOrdinal(fieldsPersistenceInfo[i].SourceColumnName);
						}
					}
					catch
					{
						// name not found. 
						columnOrdinal=i;
					}
					fieldIndexToOrdinal[i] = columnOrdinal;
				}
				else
				{
					columnOrdinal = fieldIndexToOrdinal[i];
				}
				object valueInField = dataSource[columnOrdinal];
				bool isColumnValueDBNull = (valueInField==System.DBNull.Value); 
				rowDestination[i].IsNull = isColumnValueDBNull;
				if(isColumnValueDBNull)
				{
					// Store default value for null for type
					rowDestination[i].ForcedCurrentValueWrite(_typeDefaultValueSupplier.DefaultValue(rowDestination[i].DataType));
				}
				else
				{
					// simply store the value
					rowDestination[i].ForcedCurrentValueWrite(valueInField);
				}
			}
			// accept the new values;
			rowDestination.AcceptChanges();
		}


		/// <summary>
		/// Checks if there is an open connection.
		/// </summary>
		/// <returns></returns>
		private bool CheckIfConnectionIsOpen()
		{
			bool connectionIsOpen=false;
			if(_activeConnection!=null)
			{
				connectionIsOpen=(_activeConnection.State!=ConnectionState.Closed);
			}
			return connectionIsOpen;
		}


		#region IDisposable
		/// <summary>
		/// Implements the IDispose' method Dispose.
		/// </summary>
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		/// <summary>
		/// Implements the Dispose functionality. If a transaction is in progress, it will rollback that transaction.
		/// </summary>
		/// <param name="isDisposing">Flag which signals this routine if a dispose action should take place (true) or not (false)</param>
		protected virtual void Dispose(bool isDisposing)
		{
			// Check to see if Dispose has already been called.
			if(!_isDisposed)
			{
				if(isDisposing)
				{
					// Dispose managed resources.
					if(_physicalTransaction != null)
					{
						if(_isTransactionInProgress)
						{
							Rollback();
						}
						else
						{
							_physicalTransaction.Dispose();
							_physicalTransaction = null;
						}
					}
					if(_activeConnection != null)
					{
						// closing the connection will abort (rollback) any pending transactions
						if(_activeConnection.State == ConnectionState.Open)
						{
							_activeConnection.Close();
						}
						_activeConnection.Dispose();
						_activeConnection = null;
					}
				}
			}
			_isDisposed = true;
		}
		#endregion


		#region Class Property Declarations
		/// <summary>
		/// Class which will supply the default value for a specified .NET type. Necessary for rowfetchers when a NULL field is found.
		/// </summary>
		public virtual ITypeDefaultValue TypeDefaultValueSupplier
		{
			get { return _typeDefaultValueSupplier; }
			set { _typeDefaultValueSupplier = value; }
		}


		/// <summary>
		/// Gets IsTransactionInProgress. True when there is a transaction in progress.
		/// </summary>
		public bool IsTransactionInProgress
		{
			get
			{
				return _isTransactionInProgress;
			}
		}


		/// <summary>
		/// Gets / sets the isolation level a transaction should use. 
		/// Setting this during a transaction in progress has no effect on the current running transaction.
		/// </summary>
		public virtual IsolationLevel TransactionIsolationLevel
		{
			get
			{
				return _transactionIsolationLevel;
			}
			set
			{
				_transactionIsolationLevel = value;
			}
		}


		/// <summary>
		/// Gets the name of the transaction. Setting this during a transaction in progress has no effect on the current running transaction.
		/// </summary>
		public virtual string TransactionName
		{
			get
			{
				return _transactionName;
			}
			set
			{
				_transactionName = value;
			}
		}


		/// <summary>
		/// Gets / sets the connection string to use for the connection with the database.
		/// </summary>
		public virtual string ConnectionString
		{
			get
			{
				return _connectionString;
			}
			set
			{
				_connectionString = value;
			}
		}


		/// <summary>
		/// Gets / sets KeepConnectionOpen, a flag used to keep open connections after a database action has finished.
		/// </summary>
		public bool KeepConnectionOpen
		{
			get
			{
				return _keepConnectionOpen;
			}
			set
			{
				_keepConnectionOpen = value;
			}
		}


		/// <summary>
		/// The physical transaction object used over the current ActiveConnection.
		/// </summary>
		protected IDbTransaction PhysicalTransaction
		{
			get
			{
				return _physicalTransaction;
			}
		}

		/// <summary>
		/// Gets / sets the timeout value to use with the command object(s) created by the adapter.
		/// Default is 30 seconds
		/// Set this prior to calling a method which executes database logic.
		/// </summary>
		public int CommandTimeOut 
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