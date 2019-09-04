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
using System.ComponentModel;
using System.Collections;
using System.Runtime.Serialization;
using System.Data;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.FactoryClasses;
using LLBL2003.AdventureWorks2008.CollectionClasses;
using LLBL2003.AdventureWorks2008.DaoClasses;
using LLBL2003.AdventureWorks2008.RelationClasses;
using LLBL2003.AdventureWorks2008.ValidatorClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.EntityClasses
{
	/// <summary>
	/// Entity class which represents the entity 'NonPresentTimeHeader' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class NonPresentTimeHeaderEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private NonPresentTimeCollection	_nonPresentTime;
		private bool	_alwaysFetchNonPresentTime, _alreadyFetchedNonPresentTime;
		private ReasonCollection _reason;
		private bool	_alwaysFetchReason, _alreadyFetchedReason;
		private UserDetailEntity _userDetail;
		private bool	_alwaysFetchUserDetail, _alreadyFetchedUserDetail;
		private UserDetailEntity _userDetail_;
		private bool	_alwaysFetchUserDetail_, _alreadyFetchedUserDetail_;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ID changes value. Databinding related.
		/// </summary>
		public event EventHandler IDChanged;

		/// <summary>
		/// Event which is thrown when UserID changes value. Databinding related.
		/// </summary>
		public event EventHandler UserIDChanged;

		/// <summary>
		/// Event which is thrown when ApprovedFromID changes value. Databinding related.
		/// </summary>
		public event EventHandler ApprovedFromIDChanged;

		/// <summary>
		/// Event which is thrown when EnteredDate changes value. Databinding related.
		/// </summary>
		public event EventHandler EnteredDateChanged;

		/// <summary>
		/// Event which is thrown when ApprovedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ApprovedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public NonPresentTimeHeaderEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new NonPresentTimeHeaderEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		public NonPresentTimeHeaderEntity(System.Int32 iD)
		{
			InitClassFetch(iD, new NonPresentTimeHeaderValidator(), new PropertyDescriptorFactory(), new NonPresentTimeHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		/// <param name="validator">The custom validator object for this NonPresentTimeHeaderEntity</param>
		public NonPresentTimeHeaderEntity(System.Int32 iD, NonPresentTimeHeaderValidator validator)
		{
			InitClassFetch(iD, validator, new PropertyDescriptorFactory(), new NonPresentTimeHeaderEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		/// <param name="validator">The custom validator object for this NonPresentTimeHeaderEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public NonPresentTimeHeaderEntity(System.Int32 iD, NonPresentTimeHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(iD, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public NonPresentTimeHeaderEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private NonPresentTimeHeaderEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_nonPresentTime = (NonPresentTimeCollection)info.GetValue("_nonPresentTime", typeof(NonPresentTimeCollection));
			_alwaysFetchNonPresentTime = info.GetBoolean("_alwaysFetchNonPresentTime");
			_alreadyFetchedNonPresentTime = info.GetBoolean("_alreadyFetchedNonPresentTime");

			_reason = (ReasonCollection)info.GetValue("_reason", typeof(ReasonCollection));
			_alwaysFetchReason = info.GetBoolean("_alwaysFetchReason");
			_alreadyFetchedReason = info.GetBoolean("_alreadyFetchedReason");
			_userDetail = (UserDetailEntity)info.GetValue("_userDetail", typeof(UserDetailEntity));
			if(_userDetail!=null)
			{
				// rewire event handler.
				_userDetail.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchUserDetail = info.GetBoolean("_alwaysFetchUserDetail");
			_alreadyFetchedUserDetail = info.GetBoolean("_alreadyFetchedUserDetail");
			_userDetail_ = (UserDetailEntity)info.GetValue("_userDetail_", typeof(UserDetailEntity));
			if(_userDetail_!=null)
			{
				// rewire event handler.
				_userDetail_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchUserDetail_ = info.GetBoolean("_alwaysFetchUserDetail_");
			_alreadyFetchedUserDetail_ = info.GetBoolean("_alreadyFetchedUserDetail_");

		}
		
		
		/// <summary>
		/// Will perform post-ReadXml actions as well as the normal ReadXml() actions, performed by the base class.
		/// </summary>
		/// <param name="node">XmlNode with Xml data which should be read into this entity and its members. Node's root element is the root element
		/// of the entity's Xml data</param>
		public override void ReadXml(System.Xml.XmlNode node)
		{
			base.ReadXml (node);

			// walk the contained data objects to see if they're fetched. If so, set the flags to true.
			_alreadyFetchedNonPresentTime = (_nonPresentTime.Count > 0);
			_alreadyFetchedReason = (_reason.Count > 0);
			_alreadyFetchedUserDetail = (_userDetail != null);
			_alreadyFetchedUserDetail_ = (_userDetail_ != null);

		}

		
		/// <summary>
		/// Saves the Entity class to the persistent storage. It updates or inserts the entity, which depends if the entity was originally read from the 
		/// database. If the entity is new, an insert is done and the updateRestriction is ignored. If the entity is not new, the updateRestriction
		/// predicate is used to create an additional where clause (it will be added with AND) for the update query. This predicate can be used for
		/// concurrency checks, like checks on timestamp column values.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query. Will be ignored when the entity is
		/// <param name="recurse">When true, it will save all dirty objects referenced (directly or indirectly) by this entity also.</param>
		/// <returns>true if Save succeeded, false otherwise</returns>
		/// <remarks>Do not call this routine directly, use the overloaded version in a derived class as this version doesn't construct a
		/// local transaction during recursive save, this is done in the overloaded version in a derived class.</remarks>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public override bool Save(IPredicate updateRestriction, bool recurse)
		{
			bool transactionStartedInThisScope = false;
			Transaction transactionManager = null;

			if(recurse)
			{
				if(!base.ParticipatesInTransaction)
				{
					// Start local transaction
					transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveRecursively");
					// Add ourselves
					transactionManager.Add(this);
					transactionStartedInThisScope=true;
				}
			}
			try
			{
				// perform the save action(s)
				bool result = base.Save(updateRestriction, recurse);

				// only commit a transaction which is started here.
				if(transactionStartedInThisScope)
				{
					transactionManager.Commit();
				}

				return result;
			}
			catch
			{
				// exception caught. roll back a transaction started here.
				if(transactionStartedInThisScope)
				{
					transactionManager.Rollback();
				}
				// bubble exception 
				throw;
			}
			finally
			{
				if(transactionStartedInThisScope)
				{
					transactionManager.Dispose();
				}
			}
		}


		/// <summary>
		/// ISerializable member. Does custom serialization so event handlers do not get serialized.
		/// Serializes members of this entity class and uses the base class' implementation to serialize
		/// the rest.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_nonPresentTime", _nonPresentTime);
			info.AddValue("_alwaysFetchNonPresentTime", _alwaysFetchNonPresentTime);
			info.AddValue("_alreadyFetchedNonPresentTime", _alreadyFetchedNonPresentTime);
			info.AddValue("_reason", _reason);
			info.AddValue("_alwaysFetchReason", _alwaysFetchReason);
			info.AddValue("_alreadyFetchedReason", _alreadyFetchedReason);
			info.AddValue("_userDetail", _userDetail);
			info.AddValue("_alwaysFetchUserDetail", _alwaysFetchUserDetail);
			info.AddValue("_alreadyFetchedUserDetail", _alreadyFetchedUserDetail);
			info.AddValue("_userDetail_", _userDetail_);
			info.AddValue("_alwaysFetchUserDetail_", _alwaysFetchUserDetail_);
			info.AddValue("_alreadyFetchedUserDetail_", _alreadyFetchedUserDetail_);

			base.GetObjectData(info, context);
		}


		/// <summary>
		/// Sets the internal parameter related to the fieldname passed to the instance relatedEntity. 
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public override void SetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "UserDetail":
					SetupSyncUserDetail(relatedEntity);
					break;
				case "UserDetail_":
					SetupSyncUserDetail_(relatedEntity);
					break;
				case "NonPresentTime":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_nonPresentTime.Add(relatedEntity);
					break;

				default:
					// do nothing
					break;
			}
		}
		
		
		/// <summary>
		/// Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() 
		/// </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		public override void UnsetRelatedEntity(IEntity relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				case "UserDetail":
					DesetupSyncUserDetail(false);
					break;
				case "UserDetail_":
					DesetupSyncUserDetail_(false);
					break;
				case "NonPresentTime":
					// Remove it from the collection.
					_nonPresentTime.Remove(relatedEntity);
					break;

				default:
					// do nothing
					break;
			}
		}


		/// <summary>
		/// Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These
		/// entities will have to be persisted after this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependingRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();


			return toReturn;
		}
		
		
		/// <summary>
		/// Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.
		/// </summary>
		/// <returns>Collection with 0 or more IEntity objects, referenced by this entity</returns>
		public override ArrayList GetDependentRelatedEntities()
		{
			ArrayList toReturn = new ArrayList();

			// each related entity which is dirty, is added to the collection, and will be saved first.
			if(_userDetail!=null)
			{
				toReturn.Add(_userDetail);
			}
			if(_userDetail_!=null)
			{
				toReturn.Add(_userDetail_);
			}

			return toReturn;
		}
		
		
		/// <summary>
		/// Gets an ArrayList of all entity collections stored as member variables in this entity. The contents of the ArrayList is
		/// used by the DataAccessAdapter to perform recursive saves. Only 1:n related collections are returned.
		/// </summary>
		/// <returns>Collection with 0 or more IEntityCollection objects, referenced by this entity</returns>
		public override ArrayList GetMemberEntityCollections()
		{
			ArrayList toReturn = new ArrayList();

			toReturn.Add(_nonPresentTime);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("NonPresentTimeHeaderEntity");
		}


		/// <summary>
		/// Returns a unique hashcode for this entity which is unique for this type. It is based on the primary key values
		/// of this entity. If no primary key values are available, the hashcode of the object is returned.
		/// </summary>
		/// <returns>unique hashcode based on the values of the primary key values of this entity</returns>
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

	
	
		/// <summary>
		/// Fetches the contents of this entity from the persistent storage using the primary key.
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 iD)
		{
			return Fetch(iD);
		}


		/// <summary>
		/// Refetches the Entity from the persistent storage. Refetch is used to re-load an Entity which is marked "Out-of-sync", due to a save action. 
		/// Refetching an empty Entity has no effect. 
		/// </summary>
		/// <returns>true if Refetch succeeded, false otherwise</returns>
		/// <exception cref="System.ApplicationException">When an exception is caught during the save process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public override bool Refetch()
		{
			return Fetch(this.ID);
		}


		/// <summary>
		/// Deletes the Entity from the persistent storage. This method succeeds also when the Entity is not present.
		/// </summary>
		/// <param name="deleteRestriction">Predicate expression, meant for concurrency checks in a delete query. Overrules the predicate returned
		/// by a set ConcurrencyPredicateFactory object.</param>
		/// <returns>true if Delete succeeded, false otherwise</returns>
		/// <exception cref="ORMQueryExecutionException">When an exception is caught during the delete process. The caught exception is set as the
		/// inner exception. Encapsulation of database-related exceptions is necessary since these exceptions do not have a common exception framework
		/// implemented.</exception>
		public override bool Delete(IPredicate deleteRestriction)
		{
			NonPresentTimeHeaderDAO dao = DAOFactory.CreateNonPresentTimeHeaderDAO();
			bool wasSuccesful = dao.DeleteNonPresentTimeHeader(base.Fields, base.Transaction, deleteRestriction);
			if(wasSuccesful)
			{
				base.Delete(deleteRestriction);
			}
			return wasSuccesful;
		}
	

		/// <summary>
		/// Returns true if the original value for the field with the fieldIndex passed in, read from the persistent storage was NULL, false otherwise.
		/// Should not be used for testing if the current value is NULL, because the current value can't be set to NULL.
		/// If the current value for the field with the index fieldIndex is set to <i>null</i>, you can simply test
		/// against <i>null</i> to see if the <i>current value</i> of the field is null. 
		/// </summary>
		/// <param name="fieldIndex">Index of the field to test if that field was NULL in the persistent storage</param>
		/// <returns>true if the field with the passed in index was NULL in the persistent storage, false otherwise</returns>
		public bool TestOriginalFieldValueForNull(NonPresentTimeHeaderFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeEntity'</returns>
		public virtual NonPresentTimeCollection GetMultiNonPresentTime(bool forceFetch)
		{
 			if( ( !_alreadyFetchedNonPresentTime || forceFetch || _alwaysFetchNonPresentTime) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTime.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTime);
					}
				}
				_nonPresentTime.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTime.GetMultiManyToOne(null, this);
				_nonPresentTime.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTime = true;
			}
			return _nonPresentTime;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeEntity'</returns>
		public virtual NonPresentTimeCollection GetMultiNonPresentTime(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTime || forceFetch || _alwaysFetchNonPresentTime) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTime.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTime);
					}
				}
				_nonPresentTime.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTime.GetMultiManyToOne(null, this, filter);
				_nonPresentTime.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTime = true;
			}
			return _nonPresentTime;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeCollection GetMultiNonPresentTime(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedNonPresentTime || forceFetch || _alwaysFetchNonPresentTime) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTime.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTime);
					}
				}
				_nonPresentTime.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTime.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTime.GetMultiManyToOne(null, this);
				_nonPresentTime.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTime = true;
			}
			return _nonPresentTime;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeCollection GetMultiNonPresentTime(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTime || forceFetch || _alwaysFetchNonPresentTime) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTime.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTime);
					}
				}
				_nonPresentTime.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTime.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTime.GetMultiManyToOne(null, this, filter);
				_nonPresentTime.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTime = true;
			}
			return _nonPresentTime;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'NonPresentTime'. These settings will be taken into account
		/// when the property NonPresentTime is requested or GetMultiNonPresentTime is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersNonPresentTime(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_nonPresentTime.SortClauses=sortClauses;
			_nonPresentTime.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ReasonEntity'</returns>
		public virtual ReasonCollection GetMultiReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedReason || forceFetch || _alwaysFetchReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_reason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_reason);
					}
				}
				_reason.SuppressClearInGetMulti=!forceFetch;
				_reason.GetMultiManyToManyUsingNonPresentTimeHeader(this);
				_reason.SuppressClearInGetMulti=false;
				_alreadyFetchedReason = true;
			}
			return _reason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ReasonCollection GetMultiReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedReason || forceFetch || _alwaysFetchReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_reason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_reason);
					}
				}
				_reason.SuppressClearInGetMulti=!forceFetch;
				_reason.EntityFactoryToUse = entityFactoryToUse;
				_reason.GetMultiManyToManyUsingNonPresentTimeHeader(this);
				_reason.SuppressClearInGetMulti=false;
				_alreadyFetchedReason = true;
			}
			return _reason;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Reason'. These settings will be taken into account
		/// when the property Reason is requested or GetMultiReason is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_reason.SortClauses=sortClauses;
			_reason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'UserDetailEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'UserDetailEntity' which is related to this entity.</returns>
		public virtual UserDetailEntity GetSingleUserDetail()
		{
			return GetSingleUserDetail(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'UserDetailEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'UserDetailEntity' which is related to this entity.</returns>
		public virtual UserDetailEntity GetSingleUserDetail(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUserDetail || forceFetch || _alwaysFetchUserDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				UserDetailEntity newEntity = new UserDetailEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.UserID);
				this.UserDetail = newEntity;

				_alreadyFetchedUserDetail = true;
			}
			return _userDetail;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'UserDetailEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'UserDetailEntity' which is related to this entity.</returns>
		public virtual UserDetailEntity GetSingleUserDetail_()
		{
			return GetSingleUserDetail_(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'UserDetailEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'UserDetailEntity' which is related to this entity.</returns>
		public virtual UserDetailEntity GetSingleUserDetail_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUserDetail_ || forceFetch || _alwaysFetchUserDetail_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				UserDetailEntity newEntity = new UserDetailEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ApprovedFromID);
				this.UserDetail_ = newEntity;

				_alreadyFetchedUserDetail_ = true;
			}
			return _userDetail_;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the IDChanged event, which is thrown when ID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnIDChanged()
		{
			if(IDChanged!=null)
			{
				IDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the UserIDChanged event, which is thrown when UserID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUserIDChanged()
		{
			if(UserIDChanged!=null)
			{
				UserIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ApprovedFromIDChanged event, which is thrown when ApprovedFromID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnApprovedFromIDChanged()
		{
			if(ApprovedFromIDChanged!=null)
			{
				ApprovedFromIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EnteredDateChanged event, which is thrown when EnteredDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEnteredDateChanged()
		{
			if(EnteredDateChanged!=null)
			{
				EnteredDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ApprovedDateChanged event, which is thrown when ApprovedDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnApprovedDateChanged()
		{
			if(ApprovedDateChanged!=null)
			{
				ApprovedDateChanged(this, new EventArgs());
			}
		}
	
		#endregion


		/// <summary>
		/// Event handler which is called by a related entity after that entity is persisted.
		/// </summary>
		/// <param name="sender">IEntity instance</param>
		/// <param name="e"></param>
		protected virtual void OnEntityAfterSave(object sender, EventArgs e)
		{
			IEntity persistedEntity = (IEntity)sender;

			ArrayList entitySyncInfos = new ArrayList(((Hashtable)base.GetEntitySyncInformation(persistedEntity)).Values);
			for (int i = 0; i < entitySyncInfos.Count; i++)
			{
				EntitySyncInfoSS currentSyncInfo = (EntitySyncInfoSS)entitySyncInfos[i];
				base.SyncFKFields(currentSyncInfo.Relation, currentSyncInfo.DataSupplyingEntity);
			}
		}


		/// <summary>
		/// Performs the insert action of a new Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool InsertEntity()
		{
			NonPresentTimeHeaderDAO dao = DAOFactory.CreateNonPresentTimeHeaderDAO();
			return dao.AddNonPresentTimeHeader(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			NonPresentTimeHeaderDAO dao = DAOFactory.CreateNonPresentTimeHeaderDAO();
			return dao.UpdateNonPresentTimeHeader(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			NonPresentTimeHeaderDAO dao = DAOFactory.CreateNonPresentTimeHeaderDAO();
			return dao.UpdateNonPresentTimeHeader(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.NonPresentTimeHeaderEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new NonPresentTimeHeaderValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this NonPresentTimeHeaderEntity</param>
		private void InitClassFetch(System.Int32 iD, NonPresentTimeHeaderValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.NonPresentTimeHeaderEntity);
			bool wasSuccesful = Fetch(iD);
			base.IsNew = !wasSuccesful;
			base.Validator = validator;
			base.EntityFactoryToUse = entityFactoryToUse;
		}
	

		/// <summary>
		/// Initializes the class members
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassMembers(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			_nonPresentTime = new NonPresentTimeCollection(propertyDescriptorFactoryToUse, new NonPresentTimeEntityFactory());
			_nonPresentTime.SetContainingEntityInfo(this, "NonPresentTimeHeader");
			_alwaysFetchNonPresentTime = false;
			_alreadyFetchedNonPresentTime = false;
			_reason = new ReasonCollection(propertyDescriptorFactoryToUse, new ReasonEntityFactory());
			_alwaysFetchReason = false;
			_alreadyFetchedReason = false;
			_userDetail = null;
			_alwaysFetchUserDetail = false;
			_alreadyFetchedUserDetail = false;
			_userDetail_ = null;
			_alwaysFetchUserDetail_ = false;
			_alreadyFetchedUserDetail_ = false;

		}


		/// <summary>
		/// Removes the sync logic for member _userDetail
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncUserDetail(bool signalRelatedEntity)
		{
			if(_userDetail != null)
			{
				// disconnect the entity from this entity
				_userDetail.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_userDetail.UnsetRelatedEntity(this, "NonPresentTimeHeader");
				}
				base.UnsetEntitySyncInformation("UserDetail", _userDetail, NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingUserID);
				_userDetail = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _userDetail
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserDetail(IEntity relatedEntity)
		{
			DesetupSyncUserDetail(true);
			
			if(relatedEntity!=null)
			{
				_userDetail = (UserDetailEntity)relatedEntity;
				_userDetail.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("UserDetail", _userDetail, NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingUserID);
				if(!_userDetail.IsNew)
				{
					// sync now
					base.SyncFKFields(NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingUserID, _userDetail);
				}
			}

			_alreadyFetchedUserDetail = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _userDetail_
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncUserDetail_(bool signalRelatedEntity)
		{
			if(_userDetail_ != null)
			{
				// disconnect the entity from this entity
				_userDetail_.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_userDetail_.UnsetRelatedEntity(this, "NonPresentTimeHeader_");
				}
				base.UnsetEntitySyncInformation("UserDetail_", _userDetail_, NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingApprovedFromID);
				_userDetail_ = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _userDetail_
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUserDetail_(IEntity relatedEntity)
		{
			DesetupSyncUserDetail_(true);
			
			if(relatedEntity!=null)
			{
				_userDetail_ = (UserDetailEntity)relatedEntity;
				_userDetail_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("UserDetail_", _userDetail_, NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingApprovedFromID);
				if(!_userDetail_.IsNew)
				{
					// sync now
					base.SyncFKFields(NonPresentTimeHeaderEntity.Relations.UserDetailEntityUsingApprovedFromID, _userDetail_);
				}
			}

			_alreadyFetchedUserDetail_ = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="iD">PK value for NonPresentTimeHeader which data should be fetched into this NonPresentTimeHeader object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 iD)
		{
			NonPresentTimeHeaderDAO dao = DAOFactory.CreateNonPresentTimeHeaderDAO();

			// Load EntityFields of NonPresentTimeHeader
			dao.FetchNonPresentTimeHeader(base.Fields, base.Transaction, iD);

			bool fetchResult = false;
			if(base.Fields.State == EntityState.Fetched)
			{
				base.IsNew = false;
				fetchResult = true;
			}

			return fetchResult;
		}
	
	
		#region Class Property Declarations
		/// <summary>
		/// The relations object holding all relations of this entity with other entity classes.
		/// </summary>
		public static NonPresentTimeHeaderRelations Relations
		{
			get	{ return new NonPresentTimeHeaderRelations(); }
		}

	
		/// <summary>
		/// The ID property of the Entity NonPresentTimeHeader
		/// </summary>
		public virtual System.Int32 ID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeHeaderFieldIndex.ID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeHeaderFieldIndex.ID, value))
				{
					OnIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The UserID property of the Entity NonPresentTimeHeader
		/// </summary>
		public virtual System.Int32 UserID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeHeaderFieldIndex.UserID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UserID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeHeaderFieldIndex.UserID, value))
				{
					OnUserIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ApprovedFromID property of the Entity NonPresentTimeHeader
		/// </summary>
		public virtual System.Int32 ApprovedFromID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeHeaderFieldIndex.ApprovedFromID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ApprovedFromID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeHeaderFieldIndex.ApprovedFromID, value))
				{
					OnApprovedFromIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The EnteredDate property of the Entity NonPresentTimeHeader
		/// </summary>
		public virtual System.DateTime EnteredDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeHeaderFieldIndex.EnteredDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EnteredDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeHeaderFieldIndex.EnteredDate, value))
				{
					OnEnteredDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The ApprovedDate property of the Entity NonPresentTimeHeader
		/// </summary>
		public virtual System.DateTime ApprovedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)NonPresentTimeHeaderFieldIndex.ApprovedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ApprovedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)NonPresentTimeHeaderFieldIndex.ApprovedDate, value))
				{
					OnApprovedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNonPresentTime()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual NonPresentTimeCollection NonPresentTime
		{
			get
			{
				return GetMultiNonPresentTime(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for NonPresentTime. When set to true, NonPresentTime is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time NonPresentTime is accessed. You can always execute
		/// a forced fetch by calling GetMultiNonPresentTime(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchNonPresentTime
		{
			get
			{
				return _alwaysFetchNonPresentTime;
			}
			set
			{
				_alwaysFetchNonPresentTime = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ReasonCollection Reason
		{
			get
			{
				return GetMultiReason(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Reason. When set to true, Reason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Reason is accessed. You can always execute
		/// a forced fetch by calling GetMultiReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchReason
		{
			get
			{
				return _alwaysFetchReason;
			}
			set
			{
				_alwaysFetchReason = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'UserDetailEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUserDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserDetailEntity UserDetail
		{
			get
			{
				return GetSingleUserDetail(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUserDetail(value);
				}
				else
				{
					if(value==null)
					{
						if(_userDetail != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_userDetail.UnsetRelatedEntity(this, "NonPresentTimeHeader");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "NonPresentTimeHeader");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UserDetail. When set to true, UserDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserDetail is accessed. You can always execute
		/// a forced fetch by calling GetSingleUserDetail(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUserDetail
		{
			get
			{
				return _alwaysFetchUserDetail;
			}
			set
			{
				_alwaysFetchUserDetail = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'UserDetailEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUserDetail_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UserDetailEntity UserDetail_
		{
			get
			{
				return GetSingleUserDetail_(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUserDetail_(value);
				}
				else
				{
					if(value==null)
					{
						if(_userDetail_ != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_userDetail_.UnsetRelatedEntity(this, "NonPresentTimeHeader_");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "NonPresentTimeHeader_");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UserDetail_. When set to true, UserDetail_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UserDetail_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleUserDetail_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUserDetail_
		{
			get
			{
				return _alwaysFetchUserDetail_;
			}
			set
			{
				_alwaysFetchUserDetail_ = value;
			}	
		}
	
	
		#endregion
	}
}
