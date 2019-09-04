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
	/// Entity class which represents the entity 'ContactCreditCard' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ContactCreditCardEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private ContactEntity _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact;
		private CreditCardEntity _creditCard;
		private bool	_alwaysFetchCreditCard, _alreadyFetchedCreditCard;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ContactID changes value. Databinding related.
		/// </summary>
		public event EventHandler ContactIDChanged;

		/// <summary>
		/// Event which is thrown when CreditCardID changes value. Databinding related.
		/// </summary>
		public event EventHandler CreditCardIDChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ContactCreditCardEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ContactCreditCardEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		public ContactCreditCardEntity(System.Int32 contactID, System.Int32 creditCardID)
		{
			InitClassFetch(contactID, creditCardID, new ContactCreditCardValidator(), new PropertyDescriptorFactory(), new ContactCreditCardEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="validator">The custom validator object for this ContactCreditCardEntity</param>
		public ContactCreditCardEntity(System.Int32 contactID, System.Int32 creditCardID, ContactCreditCardValidator validator)
		{
			InitClassFetch(contactID, creditCardID, validator, new PropertyDescriptorFactory(), new ContactCreditCardEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="validator">The custom validator object for this ContactCreditCardEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactCreditCardEntity(System.Int32 contactID, System.Int32 creditCardID, ContactCreditCardValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(contactID, creditCardID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ContactCreditCardEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ContactCreditCardEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_contact = (ContactEntity)info.GetValue("_contact", typeof(ContactEntity));
			if(_contact!=null)
			{
				// rewire event handler.
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");
			_creditCard = (CreditCardEntity)info.GetValue("_creditCard", typeof(CreditCardEntity));
			if(_creditCard!=null)
			{
				// rewire event handler.
				_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCreditCard = info.GetBoolean("_alwaysFetchCreditCard");
			_alreadyFetchedCreditCard = info.GetBoolean("_alreadyFetchedCreditCard");

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


			_alreadyFetchedContact = (_contact != null);
			_alreadyFetchedCreditCard = (_creditCard != null);

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


			info.AddValue("_contact", _contact);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_creditCard", _creditCard);
			info.AddValue("_alwaysFetchCreditCard", _alwaysFetchCreditCard);
			info.AddValue("_alreadyFetchedCreditCard", _alreadyFetchedCreditCard);

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
				case "Contact":
					SetupSyncContact(relatedEntity);
					break;
				case "CreditCard":
					SetupSyncCreditCard(relatedEntity);
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
				case "Contact":
					DesetupSyncContact(false);
					break;
				case "CreditCard":
					DesetupSyncCreditCard(false);
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
			if(_contact!=null)
			{
				toReturn.Add(_contact);
			}
			if(_creditCard!=null)
			{
				toReturn.Add(_creditCard);
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


		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("ContactCreditCardEntity");
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
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 contactID, System.Int32 creditCardID)
		{
			return Fetch(contactID, creditCardID);
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
			return Fetch(this.ContactID, this.CreditCardID);
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
			ContactCreditCardDAO dao = DAOFactory.CreateContactCreditCardDAO();
			bool wasSuccesful = dao.DeleteContactCreditCard(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ContactCreditCardFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact()
		{
			return GetSingleContact(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ContactEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ContactEntity' which is related to this entity.</returns>
		public virtual ContactEntity GetSingleContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ContactEntity newEntity = new ContactEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ContactID);
				this.Contact = newEntity;

				_alreadyFetchedContact = true;
			}
			return _contact;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public virtual CreditCardEntity GetSingleCreditCard()
		{
			return GetSingleCreditCard(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CreditCardEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CreditCardEntity' which is related to this entity.</returns>
		public virtual CreditCardEntity GetSingleCreditCard(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCreditCard || forceFetch || _alwaysFetchCreditCard) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CreditCardEntity newEntity = new CreditCardEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.CreditCardID);
				this.CreditCard = newEntity;

				_alreadyFetchedCreditCard = true;
			}
			return _creditCard;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ContactIDChanged event, which is thrown when ContactID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnContactIDChanged()
		{
			if(ContactIDChanged!=null)
			{
				ContactIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CreditCardIDChanged event, which is thrown when CreditCardID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCreditCardIDChanged()
		{
			if(CreditCardIDChanged!=null)
			{
				CreditCardIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ModifiedDateChanged event, which is thrown when ModifiedDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnModifiedDateChanged()
		{
			if(ModifiedDateChanged!=null)
			{
				ModifiedDateChanged(this, new EventArgs());
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
			ContactCreditCardDAO dao = DAOFactory.CreateContactCreditCardDAO();
			return dao.AddContactCreditCard(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ContactCreditCardDAO dao = DAOFactory.CreateContactCreditCardDAO();
			return dao.UpdateContactCreditCard(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ContactCreditCardDAO dao = DAOFactory.CreateContactCreditCardDAO();
			return dao.UpdateContactCreditCard(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactCreditCardEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ContactCreditCardValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ContactCreditCardEntity</param>
		private void InitClassFetch(System.Int32 contactID, System.Int32 creditCardID, ContactCreditCardValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ContactCreditCardEntity);
			bool wasSuccesful = Fetch(contactID, creditCardID);
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


			_contact = null;
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_creditCard = null;
			_alwaysFetchCreditCard = false;
			_alreadyFetchedCreditCard = false;

		}


		/// <summary>
		/// Removes the sync logic for member _contact
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncContact(bool signalRelatedEntity)
		{
			if(_contact != null)
			{
				// disconnect the entity from this entity
				_contact.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_contact.UnsetRelatedEntity(this, "ContactCreditCard");
				}
				base.UnsetEntitySyncInformation("Contact", _contact, ContactCreditCardEntity.Relations.ContactEntityUsingContactID);
				_contact = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _contact
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncContact(IEntity relatedEntity)
		{
			DesetupSyncContact(true);
			
			if(relatedEntity!=null)
			{
				_contact = (ContactEntity)relatedEntity;
				_contact.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Contact", _contact, ContactCreditCardEntity.Relations.ContactEntityUsingContactID);
				if(!_contact.IsNew)
				{
					// sync now
					base.SyncFKFields(ContactCreditCardEntity.Relations.ContactEntityUsingContactID, _contact);
				}
			}

			_alreadyFetchedContact = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _creditCard
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCreditCard(bool signalRelatedEntity)
		{
			if(_creditCard != null)
			{
				// disconnect the entity from this entity
				_creditCard.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_creditCard.UnsetRelatedEntity(this, "ContactCreditCard");
				}
				base.UnsetEntitySyncInformation("CreditCard", _creditCard, ContactCreditCardEntity.Relations.CreditCardEntityUsingCreditCardID);
				_creditCard = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _creditCard
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCreditCard(IEntity relatedEntity)
		{
			DesetupSyncCreditCard(true);
			
			if(relatedEntity!=null)
			{
				_creditCard = (CreditCardEntity)relatedEntity;
				_creditCard.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("CreditCard", _creditCard, ContactCreditCardEntity.Relations.CreditCardEntityUsingCreditCardID);
				if(!_creditCard.IsNew)
				{
					// sync now
					base.SyncFKFields(ContactCreditCardEntity.Relations.CreditCardEntityUsingCreditCardID, _creditCard);
				}
			}

			_alreadyFetchedCreditCard = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="contactID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <param name="creditCardID">PK value for ContactCreditCard which data should be fetched into this ContactCreditCard object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 contactID, System.Int32 creditCardID)
		{
			ContactCreditCardDAO dao = DAOFactory.CreateContactCreditCardDAO();

			// Load EntityFields of ContactCreditCard
			dao.FetchContactCreditCard(base.Fields, base.Transaction, contactID, creditCardID);

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
		public static ContactCreditCardRelations Relations
		{
			get	{ return new ContactCreditCardRelations(); }
		}

	
		/// <summary>
		/// The ContactID property of the Entity ContactCreditCard
		/// </summary>
		public virtual System.Int32 ContactID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactCreditCardFieldIndex.ContactID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ContactID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactCreditCardFieldIndex.ContactID, value))
				{
					OnContactIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CreditCardID property of the Entity ContactCreditCard
		/// </summary>
		public virtual System.Int32 CreditCardID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactCreditCardFieldIndex.CreditCardID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CreditCardID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactCreditCardFieldIndex.CreditCardID, value))
				{
					OnCreditCardIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ContactCreditCard
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ContactCreditCardFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ContactCreditCardFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'ContactEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ContactEntity Contact
		{
			get
			{
				return GetSingleContact(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncContact(value);
				}
				else
				{
					if(value==null)
					{
						if(_contact != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_contact.UnsetRelatedEntity(this, "ContactCreditCard");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ContactCreditCard");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetSingleContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContact
		{
			get
			{
				return _alwaysFetchContact;
			}
			set
			{
				_alwaysFetchContact = value;
			}	
		}
	
		/// <summary>
		/// Gets / sets related entity of type 'CreditCardEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCreditCard()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CreditCardEntity CreditCard
		{
			get
			{
				return GetSingleCreditCard(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCreditCard(value);
				}
				else
				{
					if(value==null)
					{
						if(_creditCard != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_creditCard.UnsetRelatedEntity(this, "ContactCreditCard");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ContactCreditCard");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for CreditCard. When set to true, CreditCard is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time CreditCard is accessed. You can always execute
		/// a forced fetch by calling GetSingleCreditCard(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCreditCard
		{
			get
			{
				return _alwaysFetchCreditCard;
			}
			set
			{
				_alwaysFetchCreditCard = value;
			}	
		}
	
	
		#endregion
	}
}
