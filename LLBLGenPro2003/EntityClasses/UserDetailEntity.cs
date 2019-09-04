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
	/// Entity class which represents the entity 'UserDetail' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class UserDetailEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private NonPresentTimeHeaderCollection	_nonPresentTimeHeader;
		private bool	_alwaysFetchNonPresentTimeHeader, _alreadyFetchedNonPresentTimeHeader;
		private NonPresentTimeHeaderCollection	_nonPresentTimeHeader_;
		private bool	_alwaysFetchNonPresentTimeHeader_, _alreadyFetchedNonPresentTimeHeader_;



		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ID changes value. Databinding related.
		/// </summary>
		public event EventHandler IDChanged;

		/// <summary>
		/// Event which is thrown when UserName changes value. Databinding related.
		/// </summary>
		public event EventHandler UserNameChanged;

		/// <summary>
		/// Event which is thrown when SignaturePicPath changes value. Databinding related.
		/// </summary>
		public event EventHandler SignaturePicPathChanged;

		/// <summary>
		/// Event which is thrown when FullName changes value. Databinding related.
		/// </summary>
		public event EventHandler FullNameChanged;

		/// <summary>
		/// Event which is thrown when EmployeeNr changes value. Databinding related.
		/// </summary>
		public event EventHandler EmployeeNrChanged;

		/// <summary>
		/// Event which is thrown when Department changes value. Databinding related.
		/// </summary>
		public event EventHandler DepartmentChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public UserDetailEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new UserDetailEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
		public UserDetailEntity(System.Int32 iD)
		{
			InitClassFetch(iD, new UserDetailValidator(), new PropertyDescriptorFactory(), new UserDetailEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
		/// <param name="validator">The custom validator object for this UserDetailEntity</param>
		public UserDetailEntity(System.Int32 iD, UserDetailValidator validator)
		{
			InitClassFetch(iD, validator, new PropertyDescriptorFactory(), new UserDetailEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
		/// <param name="validator">The custom validator object for this UserDetailEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public UserDetailEntity(System.Int32 iD, UserDetailValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(iD, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public UserDetailEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private UserDetailEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_nonPresentTimeHeader = (NonPresentTimeHeaderCollection)info.GetValue("_nonPresentTimeHeader", typeof(NonPresentTimeHeaderCollection));
			_alwaysFetchNonPresentTimeHeader = info.GetBoolean("_alwaysFetchNonPresentTimeHeader");
			_alreadyFetchedNonPresentTimeHeader = info.GetBoolean("_alreadyFetchedNonPresentTimeHeader");

			_nonPresentTimeHeader_ = (NonPresentTimeHeaderCollection)info.GetValue("_nonPresentTimeHeader_", typeof(NonPresentTimeHeaderCollection));
			_alwaysFetchNonPresentTimeHeader_ = info.GetBoolean("_alwaysFetchNonPresentTimeHeader_");
			_alreadyFetchedNonPresentTimeHeader_ = info.GetBoolean("_alreadyFetchedNonPresentTimeHeader_");



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
			_alreadyFetchedNonPresentTimeHeader = (_nonPresentTimeHeader.Count > 0);
			_alreadyFetchedNonPresentTimeHeader_ = (_nonPresentTimeHeader_.Count > 0);



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
			info.AddValue("_nonPresentTimeHeader", _nonPresentTimeHeader);
			info.AddValue("_alwaysFetchNonPresentTimeHeader", _alwaysFetchNonPresentTimeHeader);
			info.AddValue("_alreadyFetchedNonPresentTimeHeader", _alreadyFetchedNonPresentTimeHeader);
			info.AddValue("_nonPresentTimeHeader_", _nonPresentTimeHeader_);
			info.AddValue("_alwaysFetchNonPresentTimeHeader_", _alwaysFetchNonPresentTimeHeader_);
			info.AddValue("_alreadyFetchedNonPresentTimeHeader_", _alreadyFetchedNonPresentTimeHeader_);



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

				case "NonPresentTimeHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_nonPresentTimeHeader.Add(relatedEntity);
					break;
				case "NonPresentTimeHeader_":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_nonPresentTimeHeader_.Add(relatedEntity);
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

				case "NonPresentTimeHeader":
					// Remove it from the collection.
					_nonPresentTimeHeader.Remove(relatedEntity);
					break;
				case "NonPresentTimeHeader_":
					// Remove it from the collection.
					_nonPresentTimeHeader_.Remove(relatedEntity);
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

			toReturn.Add(_nonPresentTimeHeader);
			toReturn.Add(_nonPresentTimeHeader_);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("UserDetailEntity");
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
		/// Method which will try to fetch the contents for this entity using a unique constraint. 
		/// </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="userName">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCUserName(System.String userName)
		{
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			base.Fields = dao.FetchUserDetailUsingUCUserName(base.Transaction, userName);
			
			bool fetchResult = false;
			if(base.Fields.State==EntityState.Fetched)
			{
				base.IsNew = false;
				fetchResult = true;
			}

			return fetchResult;
		}
	
		/// <summary>
		/// Method which will try to fetch the contents for this entity using a unique constraint. 
		/// </summary>
		/// <remarks>All contents of the entity is lost.</remarks>
		/// <param name="employeeNr">Value for a field in the UniqueConstraint, which is used to retrieve the contents.</param>
		/// <returns>true if succeeded and the contents is read, false otherwise</returns>
		public bool FetchUsingUCEmployeeNr(System.String employeeNr)
		{
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			base.Fields = dao.FetchUserDetailUsingUCEmployeeNr(base.Transaction, employeeNr);
			
			bool fetchResult = false;
			if(base.Fields.State==EntityState.Fetched)
			{
				base.IsNew = false;
				fetchResult = true;
			}

			return fetchResult;
		}
	
	
		/// <summary>
		/// Fetches the contents of this entity from the persistent storage using the primary key.
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
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
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			bool wasSuccesful = dao.DeleteUserDetail(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(UserDetailFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeHeaderEntity'</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader || forceFetch || _alwaysFetchNonPresentTimeHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader);
					}
				}
				_nonPresentTimeHeader.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader.GetMultiManyToOne(this, null);
				_nonPresentTimeHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader = true;
			}
			return _nonPresentTimeHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeHeaderEntity'</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader || forceFetch || _alwaysFetchNonPresentTimeHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader);
					}
				}
				_nonPresentTimeHeader.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader.GetMultiManyToOne(this, null, filter);
				_nonPresentTimeHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader = true;
			}
			return _nonPresentTimeHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader || forceFetch || _alwaysFetchNonPresentTimeHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader);
					}
				}
				_nonPresentTimeHeader.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTimeHeader.GetMultiManyToOne(this, null);
				_nonPresentTimeHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader = true;
			}
			return _nonPresentTimeHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader || forceFetch || _alwaysFetchNonPresentTimeHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader);
					}
				}
				_nonPresentTimeHeader.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTimeHeader.GetMultiManyToOne(this, null, filter);
				_nonPresentTimeHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader = true;
			}
			return _nonPresentTimeHeader;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'NonPresentTimeHeader'. These settings will be taken into account
		/// when the property NonPresentTimeHeader is requested or GetMultiNonPresentTimeHeader is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersNonPresentTimeHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_nonPresentTimeHeader.SortClauses=sortClauses;
			_nonPresentTimeHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeHeaderEntity'</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader_ || forceFetch || _alwaysFetchNonPresentTimeHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader_);
					}
				}
				_nonPresentTimeHeader_.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader_.GetMultiManyToOne(null, this);
				_nonPresentTimeHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader_ = true;
			}
			return _nonPresentTimeHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'NonPresentTimeHeaderEntity'</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader_(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader_ || forceFetch || _alwaysFetchNonPresentTimeHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader_);
					}
				}
				_nonPresentTimeHeader_.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader_.GetMultiManyToOne(null, this, filter);
				_nonPresentTimeHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader_ = true;
			}
			return _nonPresentTimeHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader_ || forceFetch || _alwaysFetchNonPresentTimeHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader_);
					}
				}
				_nonPresentTimeHeader_.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader_.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTimeHeader_.GetMultiManyToOne(null, this);
				_nonPresentTimeHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader_ = true;
			}
			return _nonPresentTimeHeader_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual NonPresentTimeHeaderCollection GetMultiNonPresentTimeHeader_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedNonPresentTimeHeader_ || forceFetch || _alwaysFetchNonPresentTimeHeader_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_nonPresentTimeHeader_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_nonPresentTimeHeader_);
					}
				}
				_nonPresentTimeHeader_.SuppressClearInGetMulti=!forceFetch;
				_nonPresentTimeHeader_.EntityFactoryToUse = entityFactoryToUse;
				_nonPresentTimeHeader_.GetMultiManyToOne(null, this, filter);
				_nonPresentTimeHeader_.SuppressClearInGetMulti=false;
				_alreadyFetchedNonPresentTimeHeader_ = true;
			}
			return _nonPresentTimeHeader_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'NonPresentTimeHeader_'. These settings will be taken into account
		/// when the property NonPresentTimeHeader_ is requested or GetMultiNonPresentTimeHeader_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersNonPresentTimeHeader_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_nonPresentTimeHeader_.SortClauses=sortClauses;
			_nonPresentTimeHeader_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
		/// Event thrower for the UserNameChanged event, which is thrown when UserName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUserNameChanged()
		{
			if(UserNameChanged!=null)
			{
				UserNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SignaturePicPathChanged event, which is thrown when SignaturePicPath changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSignaturePicPathChanged()
		{
			if(SignaturePicPathChanged!=null)
			{
				SignaturePicPathChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FullNameChanged event, which is thrown when FullName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFullNameChanged()
		{
			if(FullNameChanged!=null)
			{
				FullNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EmployeeNrChanged event, which is thrown when EmployeeNr changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEmployeeNrChanged()
		{
			if(EmployeeNrChanged!=null)
			{
				EmployeeNrChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DepartmentChanged event, which is thrown when Department changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDepartmentChanged()
		{
			if(DepartmentChanged!=null)
			{
				DepartmentChanged(this, new EventArgs());
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
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			return dao.AddUserDetail(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			return dao.UpdateUserDetail(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();
			return dao.UpdateUserDetail(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.UserDetailEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new UserDetailValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this UserDetailEntity</param>
		private void InitClassFetch(System.Int32 iD, UserDetailValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.UserDetailEntity);
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
			_nonPresentTimeHeader = new NonPresentTimeHeaderCollection(propertyDescriptorFactoryToUse, new NonPresentTimeHeaderEntityFactory());
			_nonPresentTimeHeader.SetContainingEntityInfo(this, "UserDetail");
			_alwaysFetchNonPresentTimeHeader = false;
			_alreadyFetchedNonPresentTimeHeader = false;
			_nonPresentTimeHeader_ = new NonPresentTimeHeaderCollection(propertyDescriptorFactoryToUse, new NonPresentTimeHeaderEntityFactory());
			_nonPresentTimeHeader_.SetContainingEntityInfo(this, "UserDetail_");
			_alwaysFetchNonPresentTimeHeader_ = false;
			_alreadyFetchedNonPresentTimeHeader_ = false;



		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="iD">PK value for UserDetail which data should be fetched into this UserDetail object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 iD)
		{
			UserDetailDAO dao = DAOFactory.CreateUserDetailDAO();

			// Load EntityFields of UserDetail
			dao.FetchUserDetail(base.Fields, base.Transaction, iD);

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
		public static UserDetailRelations Relations
		{
			get	{ return new UserDetailRelations(); }
		}

	
		/// <summary>
		/// The ID property of the Entity UserDetail
		/// </summary>
		public virtual System.Int32 ID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.ID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.ID, value))
				{
					OnIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The UserName property of the Entity UserDetail
		/// </summary>
		public virtual System.String UserName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.UserName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UserName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.UserName, value))
				{
					OnUserNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The SignaturePicPath property of the Entity UserDetail
		/// </summary>
		public virtual System.String SignaturePicPath
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.SignaturePicPath);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SignaturePicPath because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.SignaturePicPath, value))
				{
					OnSignaturePicPathChanged();
				}
			}
		}
	
		/// <summary>
		/// The FullName property of the Entity UserDetail
		/// </summary>
		public virtual System.String FullName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.FullName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FullName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.FullName, value))
				{
					OnFullNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The EmployeeNr property of the Entity UserDetail
		/// </summary>
		public virtual System.String EmployeeNr
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.EmployeeNr);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EmployeeNr because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.EmployeeNr, value))
				{
					OnEmployeeNrChanged();
				}
			}
		}
	
		/// <summary>
		/// The Department property of the Entity UserDetail
		/// </summary>
		public virtual System.String Department
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UserDetailFieldIndex.Department);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Department because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UserDetailFieldIndex.Department, value))
				{
					OnDepartmentChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNonPresentTimeHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual NonPresentTimeHeaderCollection NonPresentTimeHeader
		{
			get
			{
				return GetMultiNonPresentTimeHeader(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for NonPresentTimeHeader. When set to true, NonPresentTimeHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time NonPresentTimeHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiNonPresentTimeHeader(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchNonPresentTimeHeader
		{
			get
			{
				return _alwaysFetchNonPresentTimeHeader;
			}
			set
			{
				_alwaysFetchNonPresentTimeHeader = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'NonPresentTimeHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiNonPresentTimeHeader_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual NonPresentTimeHeaderCollection NonPresentTimeHeader_
		{
			get
			{
				return GetMultiNonPresentTimeHeader_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for NonPresentTimeHeader_. When set to true, NonPresentTimeHeader_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time NonPresentTimeHeader_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiNonPresentTimeHeader_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchNonPresentTimeHeader_
		{
			get
			{
				return _alwaysFetchNonPresentTimeHeader_;
			}
			set
			{
				_alwaysFetchNonPresentTimeHeader_ = value;
			}	
		}
	
	
	
	
		#endregion
	}
}
