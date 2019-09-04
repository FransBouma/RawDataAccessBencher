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
	/// Entity class which represents the entity 'Vendor' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class VendorEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private PurchaseOrderHeaderCollection	_purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;
		private VendorAddressCollection	_vendorAddress;
		private bool	_alwaysFetchVendorAddress, _alreadyFetchedVendorAddress;
		private VendorContactCollection	_vendorContact;
		private bool	_alwaysFetchVendorContact, _alreadyFetchedVendorContact;
		private ProductCollection _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private UnitMeasureCollection _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure;
		private EmployeeCollection _employee;
		private bool	_alwaysFetchEmployee, _alreadyFetchedEmployee;
		private ShipMethodCollection _shipMethod;
		private bool	_alwaysFetchShipMethod, _alreadyFetchedShipMethod;
		private AddressCollection _address;
		private bool	_alwaysFetchAddress, _alreadyFetchedAddress;
		private AddressTypeCollection _addressType;
		private bool	_alwaysFetchAddressType, _alreadyFetchedAddressType;
		private ContactCollection _contact;
		private bool	_alwaysFetchContact, _alreadyFetchedContact;
		private ContactTypeCollection _contactType;
		private bool	_alwaysFetchContactType, _alreadyFetchedContactType;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when VendorID changes value. Databinding related.
		/// </summary>
		public event EventHandler VendorIDChanged;

		/// <summary>
		/// Event which is thrown when AccountNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler AccountNumberChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when CreditRating changes value. Databinding related.
		/// </summary>
		public event EventHandler CreditRatingChanged;

		/// <summary>
		/// Event which is thrown when PreferredVendorStatus changes value. Databinding related.
		/// </summary>
		public event EventHandler PreferredVendorStatusChanged;

		/// <summary>
		/// Event which is thrown when ActiveFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler ActiveFlagChanged;

		/// <summary>
		/// Event which is thrown when PurchasingWebServiceURL changes value. Databinding related.
		/// </summary>
		public event EventHandler PurchasingWebServiceURLChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public VendorEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new VendorEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		public VendorEntity(System.Int32 vendorID)
		{
			InitClassFetch(vendorID, new VendorValidator(), new PropertyDescriptorFactory(), new VendorEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		public VendorEntity(System.Int32 vendorID, VendorValidator validator)
		{
			InitClassFetch(vendorID, validator, new PropertyDescriptorFactory(), new VendorEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="validator">The custom validator object for this VendorEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public VendorEntity(System.Int32 vendorID, VendorValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(vendorID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public VendorEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private VendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_productVendor = (ProductVendorCollection)info.GetValue("_productVendor", typeof(ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");

			_purchaseOrderHeader = (PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");

			_vendorAddress = (VendorAddressCollection)info.GetValue("_vendorAddress", typeof(VendorAddressCollection));
			_alwaysFetchVendorAddress = info.GetBoolean("_alwaysFetchVendorAddress");
			_alreadyFetchedVendorAddress = info.GetBoolean("_alreadyFetchedVendorAddress");

			_vendorContact = (VendorContactCollection)info.GetValue("_vendorContact", typeof(VendorContactCollection));
			_alwaysFetchVendorContact = info.GetBoolean("_alwaysFetchVendorContact");
			_alreadyFetchedVendorContact = info.GetBoolean("_alreadyFetchedVendorContact");

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_unitMeasure = (UnitMeasureCollection)info.GetValue("_unitMeasure", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");

			_employee = (EmployeeCollection)info.GetValue("_employee", typeof(EmployeeCollection));
			_alwaysFetchEmployee = info.GetBoolean("_alwaysFetchEmployee");
			_alreadyFetchedEmployee = info.GetBoolean("_alreadyFetchedEmployee");

			_shipMethod = (ShipMethodCollection)info.GetValue("_shipMethod", typeof(ShipMethodCollection));
			_alwaysFetchShipMethod = info.GetBoolean("_alwaysFetchShipMethod");
			_alreadyFetchedShipMethod = info.GetBoolean("_alreadyFetchedShipMethod");

			_address = (AddressCollection)info.GetValue("_address", typeof(AddressCollection));
			_alwaysFetchAddress = info.GetBoolean("_alwaysFetchAddress");
			_alreadyFetchedAddress = info.GetBoolean("_alreadyFetchedAddress");

			_addressType = (AddressTypeCollection)info.GetValue("_addressType", typeof(AddressTypeCollection));
			_alwaysFetchAddressType = info.GetBoolean("_alwaysFetchAddressType");
			_alreadyFetchedAddressType = info.GetBoolean("_alreadyFetchedAddressType");

			_contact = (ContactCollection)info.GetValue("_contact", typeof(ContactCollection));
			_alwaysFetchContact = info.GetBoolean("_alwaysFetchContact");
			_alreadyFetchedContact = info.GetBoolean("_alreadyFetchedContact");

			_contactType = (ContactTypeCollection)info.GetValue("_contactType", typeof(ContactTypeCollection));
			_alwaysFetchContactType = info.GetBoolean("_alwaysFetchContactType");
			_alreadyFetchedContactType = info.GetBoolean("_alreadyFetchedContactType");


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
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader.Count > 0);
			_alreadyFetchedVendorAddress = (_vendorAddress.Count > 0);
			_alreadyFetchedVendorContact = (_vendorContact.Count > 0);
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedUnitMeasure = (_unitMeasure.Count > 0);
			_alreadyFetchedEmployee = (_employee.Count > 0);
			_alreadyFetchedShipMethod = (_shipMethod.Count > 0);
			_alreadyFetchedAddress = (_address.Count > 0);
			_alreadyFetchedAddressType = (_addressType.Count > 0);
			_alreadyFetchedContact = (_contact.Count > 0);
			_alreadyFetchedContactType = (_contactType.Count > 0);


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
			info.AddValue("_productVendor", _productVendor);
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_purchaseOrderHeader", _purchaseOrderHeader);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);
			info.AddValue("_vendorAddress", _vendorAddress);
			info.AddValue("_alwaysFetchVendorAddress", _alwaysFetchVendorAddress);
			info.AddValue("_alreadyFetchedVendorAddress", _alreadyFetchedVendorAddress);
			info.AddValue("_vendorContact", _vendorContact);
			info.AddValue("_alwaysFetchVendorContact", _alwaysFetchVendorContact);
			info.AddValue("_alreadyFetchedVendorContact", _alreadyFetchedVendorContact);
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_unitMeasure", _unitMeasure);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
			info.AddValue("_employee", _employee);
			info.AddValue("_alwaysFetchEmployee", _alwaysFetchEmployee);
			info.AddValue("_alreadyFetchedEmployee", _alreadyFetchedEmployee);
			info.AddValue("_shipMethod", _shipMethod);
			info.AddValue("_alwaysFetchShipMethod", _alwaysFetchShipMethod);
			info.AddValue("_alreadyFetchedShipMethod", _alreadyFetchedShipMethod);
			info.AddValue("_address", _address);
			info.AddValue("_alwaysFetchAddress", _alwaysFetchAddress);
			info.AddValue("_alreadyFetchedAddress", _alreadyFetchedAddress);
			info.AddValue("_addressType", _addressType);
			info.AddValue("_alwaysFetchAddressType", _alwaysFetchAddressType);
			info.AddValue("_alreadyFetchedAddressType", _alreadyFetchedAddressType);
			info.AddValue("_contact", _contact);
			info.AddValue("_alwaysFetchContact", _alwaysFetchContact);
			info.AddValue("_alreadyFetchedContact", _alreadyFetchedContact);
			info.AddValue("_contactType", _contactType);
			info.AddValue("_alwaysFetchContactType", _alwaysFetchContactType);
			info.AddValue("_alreadyFetchedContactType", _alreadyFetchedContactType);


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

				case "ProductVendor":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productVendor.Add(relatedEntity);
					break;
				case "PurchaseOrderHeader":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_purchaseOrderHeader.Add(relatedEntity);
					break;
				case "VendorAddress":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorAddress.Add(relatedEntity);
					break;
				case "VendorContact":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_vendorContact.Add(relatedEntity);
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

				case "ProductVendor":
					// Remove it from the collection.
					_productVendor.Remove(relatedEntity);
					break;
				case "PurchaseOrderHeader":
					// Remove it from the collection.
					_purchaseOrderHeader.Remove(relatedEntity);
					break;
				case "VendorAddress":
					// Remove it from the collection.
					_vendorAddress.Remove(relatedEntity);
					break;
				case "VendorContact":
					// Remove it from the collection.
					_vendorContact.Remove(relatedEntity);
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

			toReturn.Add(_productVendor);
			toReturn.Add(_purchaseOrderHeader);
			toReturn.Add(_vendorAddress);
			toReturn.Add(_vendorContact);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("VendorEntity");
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
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 vendorID)
		{
			return Fetch(vendorID);
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
			return Fetch(this.VendorID);
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
			VendorDAO dao = DAOFactory.CreateVendorDAO();
			bool wasSuccesful = dao.DeleteVendor(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(VendorFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public virtual ProductVendorCollection GetMultiProductVendor(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				_productVendor.GetMultiManyToOne(null, null, this);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductVendorEntity'</returns>
		public virtual ProductVendorCollection GetMultiProductVendor(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				_productVendor.GetMultiManyToOne(null, null, this, filter);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				_productVendor.EntityFactoryToUse = entityFactoryToUse;
				_productVendor.GetMultiManyToOne(null, null, this);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductVendorCollection GetMultiProductVendor(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductVendor || forceFetch || _alwaysFetchProductVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productVendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productVendor);
					}
				}
				_productVendor.SuppressClearInGetMulti=!forceFetch;
				_productVendor.EntityFactoryToUse = entityFactoryToUse;
				_productVendor.GetMultiManyToOne(null, null, this, filter);
				_productVendor.SuppressClearInGetMulti=false;
				_alreadyFetchedProductVendor = true;
			}
			return _productVendor;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductVendor'. These settings will be taken into account
		/// when the property ProductVendor is requested or GetMultiProductVendor is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productVendor.SortClauses=sortClauses;
			_productVendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.GetMultiManyToOne(null, null, this);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderHeaderEntity'</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.GetMultiManyToOne(null, null, this, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeader.GetMultiManyToOne(null, null, this);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderHeaderCollection GetMultiPurchaseOrderHeader(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderHeader || forceFetch || _alwaysFetchPurchaseOrderHeader) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderHeader.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderHeader);
					}
				}
				_purchaseOrderHeader.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderHeader.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderHeader.GetMultiManyToOne(null, null, this, filter);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'PurchaseOrderHeader'. These settings will be taken into account
		/// when the property PurchaseOrderHeader is requested or GetMultiPurchaseOrderHeader is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderHeader(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderHeader.SortClauses=sortClauses;
			_purchaseOrderHeader.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.GetMultiManyToOne(null, null, this);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorAddressEntity'</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.GetMultiManyToOne(null, null, this, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddress.GetMultiManyToOne(null, null, this);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorAddressCollection GetMultiVendorAddress(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorAddress || forceFetch || _alwaysFetchVendorAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorAddress.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorAddress);
					}
				}
				_vendorAddress.SuppressClearInGetMulti=!forceFetch;
				_vendorAddress.EntityFactoryToUse = entityFactoryToUse;
				_vendorAddress.GetMultiManyToOne(null, null, this, filter);
				_vendorAddress.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorAddress = true;
			}
			return _vendorAddress;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'VendorAddress'. These settings will be taken into account
		/// when the property VendorAddress is requested or GetMultiVendorAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorAddress.SortClauses=sortClauses;
			_vendorAddress.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.GetMultiManyToOne(null, null, this);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'VendorContactEntity'</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.GetMultiManyToOne(null, null, this, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				_vendorContact.GetMultiManyToOne(null, null, this);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorContactCollection GetMultiVendorContact(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedVendorContact || forceFetch || _alwaysFetchVendorContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendorContact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendorContact);
					}
				}
				_vendorContact.SuppressClearInGetMulti=!forceFetch;
				_vendorContact.EntityFactoryToUse = entityFactoryToUse;
				_vendorContact.GetMultiManyToOne(null, null, this, filter);
				_vendorContact.SuppressClearInGetMulti=false;
				_alreadyFetchedVendorContact = true;
			}
			return _vendorContact;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'VendorContact'. These settings will be taken into account
		/// when the property VendorContact is requested or GetMultiVendorContact is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendorContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendorContact.SortClauses=sortClauses;
			_vendorContact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				_product.GetMultiManyToManyUsingVendor(this);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct || forceFetch || _alwaysFetchProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product);
					}
				}
				_product.SuppressClearInGetMulti=!forceFetch;
				_product.EntityFactoryToUse = entityFactoryToUse;
				_product.GetMultiManyToManyUsingVendor(this);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product'. These settings will be taken into account
		/// when the property Product is requested or GetMultiProduct is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product.SortClauses=sortClauses;
			_product.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure);
					}
				}
				_unitMeasure.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure.GetMultiManyToManyUsingVendor(this);
				_unitMeasure.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure = true;
			}
			return _unitMeasure;
		}


		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure);
					}
				}
				_unitMeasure.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure.EntityFactoryToUse = entityFactoryToUse;
				_unitMeasure.GetMultiManyToManyUsingVendor(this);
				_unitMeasure.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure = true;
			}
			return _unitMeasure;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'UnitMeasure'. These settings will be taken into account
		/// when the property UnitMeasure is requested or GetMultiUnitMeasure is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasure(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasure.SortClauses=sortClauses;
			_unitMeasure.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'EmployeeEntity'</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.GetMultiManyToManyUsingVendor(this);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual EmployeeCollection GetMultiEmployee(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedEmployee || forceFetch || _alwaysFetchEmployee) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_employee.ParticipatesInTransaction)
					{
						base.Transaction.Add(_employee);
					}
				}
				_employee.SuppressClearInGetMulti=!forceFetch;
				_employee.EntityFactoryToUse = entityFactoryToUse;
				_employee.GetMultiManyToManyUsingVendor(this);
				_employee.SuppressClearInGetMulti=false;
				_alreadyFetchedEmployee = true;
			}
			return _employee;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Employee'. These settings will be taken into account
		/// when the property Employee is requested or GetMultiEmployee is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersEmployee(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_employee.SortClauses=sortClauses;
			_employee.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShipMethodEntity'</returns>
		public virtual ShipMethodCollection GetMultiShipMethod(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod);
					}
				}
				_shipMethod.SuppressClearInGetMulti=!forceFetch;
				_shipMethod.GetMultiManyToManyUsingVendor(this);
				_shipMethod.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod = true;
			}
			return _shipMethod;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShipMethodCollection GetMultiShipMethod(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShipMethod || forceFetch || _alwaysFetchShipMethod) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shipMethod.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shipMethod);
					}
				}
				_shipMethod.SuppressClearInGetMulti=!forceFetch;
				_shipMethod.EntityFactoryToUse = entityFactoryToUse;
				_shipMethod.GetMultiManyToManyUsingVendor(this);
				_shipMethod.SuppressClearInGetMulti=false;
				_alreadyFetchedShipMethod = true;
			}
			return _shipMethod;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ShipMethod'. These settings will be taken into account
		/// when the property ShipMethod is requested or GetMultiShipMethod is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShipMethod(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shipMethod.SortClauses=sortClauses;
			_shipMethod.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressEntity'</returns>
		public virtual AddressCollection GetMultiAddress(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address);
					}
				}
				_address.SuppressClearInGetMulti=!forceFetch;
				_address.GetMultiManyToManyUsingVendor(this);
				_address.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress = true;
			}
			return _address;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressCollection GetMultiAddress(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddress || forceFetch || _alwaysFetchAddress) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_address.ParticipatesInTransaction)
					{
						base.Transaction.Add(_address);
					}
				}
				_address.SuppressClearInGetMulti=!forceFetch;
				_address.EntityFactoryToUse = entityFactoryToUse;
				_address.GetMultiManyToManyUsingVendor(this);
				_address.SuppressClearInGetMulti=false;
				_alreadyFetchedAddress = true;
			}
			return _address;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Address'. These settings will be taken into account
		/// when the property Address is requested or GetMultiAddress is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddress(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_address.SortClauses=sortClauses;
			_address.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'AddressTypeEntity'</returns>
		public virtual AddressTypeCollection GetMultiAddressType(bool forceFetch)
		{
 			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType);
					}
				}
				_addressType.SuppressClearInGetMulti=!forceFetch;
				_addressType.GetMultiManyToManyUsingVendor(this);
				_addressType.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType = true;
			}
			return _addressType;
		}


		/// <summary>
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual AddressTypeCollection GetMultiAddressType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedAddressType || forceFetch || _alwaysFetchAddressType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_addressType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_addressType);
					}
				}
				_addressType.SuppressClearInGetMulti=!forceFetch;
				_addressType.EntityFactoryToUse = entityFactoryToUse;
				_addressType.GetMultiManyToManyUsingVendor(this);
				_addressType.SuppressClearInGetMulti=false;
				_alreadyFetchedAddressType = true;
			}
			return _addressType;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'AddressType'. These settings will be taken into account
		/// when the property AddressType is requested or GetMultiAddressType is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersAddressType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_addressType.SortClauses=sortClauses;
			_addressType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactEntity'</returns>
		public virtual ContactCollection GetMultiContact(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact);
					}
				}
				_contact.SuppressClearInGetMulti=!forceFetch;
				_contact.GetMultiManyToManyUsingVendor(this);
				_contact.SuppressClearInGetMulti=false;
				_alreadyFetchedContact = true;
			}
			return _contact;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactCollection GetMultiContact(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContact || forceFetch || _alwaysFetchContact) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contact.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contact);
					}
				}
				_contact.SuppressClearInGetMulti=!forceFetch;
				_contact.EntityFactoryToUse = entityFactoryToUse;
				_contact.GetMultiManyToManyUsingVendor(this);
				_contact.SuppressClearInGetMulti=false;
				_alreadyFetchedContact = true;
			}
			return _contact;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Contact'. These settings will be taken into account
		/// when the property Contact is requested or GetMultiContact is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContact(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contact.SortClauses=sortClauses;
			_contact.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ContactTypeEntity'</returns>
		public virtual ContactTypeCollection GetMultiContactType(bool forceFetch)
		{
 			if( ( !_alreadyFetchedContactType || forceFetch || _alwaysFetchContactType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType);
					}
				}
				_contactType.SuppressClearInGetMulti=!forceFetch;
				_contactType.GetMultiManyToManyUsingVendor(this);
				_contactType.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType = true;
			}
			return _contactType;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ContactTypeCollection GetMultiContactType(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedContactType || forceFetch || _alwaysFetchContactType) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_contactType.ParticipatesInTransaction)
					{
						base.Transaction.Add(_contactType);
					}
				}
				_contactType.SuppressClearInGetMulti=!forceFetch;
				_contactType.EntityFactoryToUse = entityFactoryToUse;
				_contactType.GetMultiManyToManyUsingVendor(this);
				_contactType.SuppressClearInGetMulti=false;
				_alreadyFetchedContactType = true;
			}
			return _contactType;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ContactType'. These settings will be taken into account
		/// when the property ContactType is requested or GetMultiContactType is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersContactType(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_contactType.SortClauses=sortClauses;
			_contactType.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the VendorIDChanged event, which is thrown when VendorID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnVendorIDChanged()
		{
			if(VendorIDChanged!=null)
			{
				VendorIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the AccountNumberChanged event, which is thrown when AccountNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnAccountNumberChanged()
		{
			if(AccountNumberChanged!=null)
			{
				AccountNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the NameChanged event, which is thrown when Name changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnNameChanged()
		{
			if(NameChanged!=null)
			{
				NameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CreditRatingChanged event, which is thrown when CreditRating changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCreditRatingChanged()
		{
			if(CreditRatingChanged!=null)
			{
				CreditRatingChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PreferredVendorStatusChanged event, which is thrown when PreferredVendorStatus changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPreferredVendorStatusChanged()
		{
			if(PreferredVendorStatusChanged!=null)
			{
				PreferredVendorStatusChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ActiveFlagChanged event, which is thrown when ActiveFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnActiveFlagChanged()
		{
			if(ActiveFlagChanged!=null)
			{
				ActiveFlagChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the PurchasingWebServiceURLChanged event, which is thrown when PurchasingWebServiceURL changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnPurchasingWebServiceURLChanged()
		{
			if(PurchasingWebServiceURLChanged!=null)
			{
				PurchasingWebServiceURLChanged(this, new EventArgs());
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
			VendorDAO dao = DAOFactory.CreateVendorDAO();
			return dao.AddVendor(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			VendorDAO dao = DAOFactory.CreateVendorDAO();
			return dao.UpdateVendor(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			VendorDAO dao = DAOFactory.CreateVendorDAO();
			return dao.UpdateVendor(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.VendorEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new VendorValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this VendorEntity</param>
		private void InitClassFetch(System.Int32 vendorID, VendorValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.VendorEntity);
			bool wasSuccesful = Fetch(vendorID);
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
			_productVendor = new ProductVendorCollection(propertyDescriptorFactoryToUse, new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_purchaseOrderHeader = new PurchaseOrderHeaderCollection(propertyDescriptorFactoryToUse, new PurchaseOrderHeaderEntityFactory());
			_purchaseOrderHeader.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;
			_vendorAddress = new VendorAddressCollection(propertyDescriptorFactoryToUse, new VendorAddressEntityFactory());
			_vendorAddress.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchVendorAddress = false;
			_alreadyFetchedVendorAddress = false;
			_vendorContact = new VendorContactCollection(propertyDescriptorFactoryToUse, new VendorContactEntityFactory());
			_vendorContact.SetContainingEntityInfo(this, "Vendor");
			_alwaysFetchVendorContact = false;
			_alreadyFetchedVendorContact = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_unitMeasure = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
			_employee = new EmployeeCollection(propertyDescriptorFactoryToUse, new EmployeeEntityFactory());
			_alwaysFetchEmployee = false;
			_alreadyFetchedEmployee = false;
			_shipMethod = new ShipMethodCollection(propertyDescriptorFactoryToUse, new ShipMethodEntityFactory());
			_alwaysFetchShipMethod = false;
			_alreadyFetchedShipMethod = false;
			_address = new AddressCollection(propertyDescriptorFactoryToUse, new AddressEntityFactory());
			_alwaysFetchAddress = false;
			_alreadyFetchedAddress = false;
			_addressType = new AddressTypeCollection(propertyDescriptorFactoryToUse, new AddressTypeEntityFactory());
			_alwaysFetchAddressType = false;
			_alreadyFetchedAddressType = false;
			_contact = new ContactCollection(propertyDescriptorFactoryToUse, new ContactEntityFactory());
			_alwaysFetchContact = false;
			_alreadyFetchedContact = false;
			_contactType = new ContactTypeCollection(propertyDescriptorFactoryToUse, new ContactTypeEntityFactory());
			_alwaysFetchContactType = false;
			_alreadyFetchedContactType = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="vendorID">PK value for Vendor which data should be fetched into this Vendor object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 vendorID)
		{
			VendorDAO dao = DAOFactory.CreateVendorDAO();

			// Load EntityFields of Vendor
			dao.FetchVendor(base.Fields, base.Transaction, vendorID);

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
		public static VendorRelations Relations
		{
			get	{ return new VendorRelations(); }
		}

	
		/// <summary>
		/// The VendorID property of the Entity Vendor
		/// </summary>
		public virtual System.Int32 VendorID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.VendorID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for VendorID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.VendorID, value))
				{
					OnVendorIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The AccountNumber property of the Entity Vendor
		/// </summary>
		public virtual System.String AccountNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.AccountNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for AccountNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.AccountNumber, value))
				{
					OnAccountNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity Vendor
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The CreditRating property of the Entity Vendor
		/// </summary>
		public virtual System.Byte CreditRating
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.CreditRating);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CreditRating because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.CreditRating, value))
				{
					OnCreditRatingChanged();
				}
			}
		}
	
		/// <summary>
		/// The PreferredVendorStatus property of the Entity Vendor
		/// </summary>
		public virtual System.Boolean PreferredVendorStatus
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.PreferredVendorStatus);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PreferredVendorStatus because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.PreferredVendorStatus, value))
				{
					OnPreferredVendorStatusChanged();
				}
			}
		}
	
		/// <summary>
		/// The ActiveFlag property of the Entity Vendor
		/// </summary>
		public virtual System.Boolean ActiveFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.ActiveFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ActiveFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.ActiveFlag, value))
				{
					OnActiveFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The PurchasingWebServiceURL property of the Entity Vendor
		/// </summary>
		public virtual System.String PurchasingWebServiceURL
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.PurchasingWebServiceURL);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for PurchasingWebServiceURL because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.PurchasingWebServiceURL, value))
				{
					OnPurchasingWebServiceURLChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Vendor
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)VendorFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)VendorFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductVendorEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductVendorCollection ProductVendor
		{
			get
			{
				return GetMultiProductVendor(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductVendor. When set to true, ProductVendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductVendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductVendor(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductVendor
		{
			get
			{
				return _alwaysFetchProductVendor;
			}
			set
			{
				_alwaysFetchProductVendor = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderHeader()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual PurchaseOrderHeaderCollection PurchaseOrderHeader
		{
			get
			{
				return GetMultiPurchaseOrderHeader(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for PurchaseOrderHeader. When set to true, PurchaseOrderHeader is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderHeader is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderHeader(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderHeader
		{
			get
			{
				return _alwaysFetchPurchaseOrderHeader;
			}
			set
			{
				_alwaysFetchPurchaseOrderHeader = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorAddressEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorAddressCollection VendorAddress
		{
			get
			{
				return GetMultiVendorAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for VendorAddress. When set to true, VendorAddress is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorAddress is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorAddress
		{
			get
			{
				return _alwaysFetchVendorAddress;
			}
			set
			{
				_alwaysFetchVendorAddress = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorContactEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendorContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorContactCollection VendorContact
		{
			get
			{
				return GetMultiVendorContact(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for VendorContact. When set to true, VendorContact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time VendorContact is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendorContact(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendorContact
		{
			get
			{
				return _alwaysFetchVendorContact;
			}
			set
			{
				_alwaysFetchVendorContact = value;
			}	
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product
		{
			get
			{
				return GetMultiProduct(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product. When set to true, Product is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct
		{
			get
			{
				return _alwaysFetchProduct;
			}
			set
			{
				_alwaysFetchProduct = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual UnitMeasureCollection UnitMeasure
		{
			get
			{
				return GetMultiUnitMeasure(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasure(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure
		{
			get
			{
				return _alwaysFetchUnitMeasure;
			}
			set
			{
				_alwaysFetchUnitMeasure = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'EmployeeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiEmployee()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual EmployeeCollection Employee
		{
			get
			{
				return GetMultiEmployee(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Employee. When set to true, Employee is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Employee is accessed. You can always execute
		/// a forced fetch by calling GetMultiEmployee(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchEmployee
		{
			get
			{
				return _alwaysFetchEmployee;
			}
			set
			{
				_alwaysFetchEmployee = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ShipMethodEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShipMethod()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ShipMethodCollection ShipMethod
		{
			get
			{
				return GetMultiShipMethod(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ShipMethod. When set to true, ShipMethod is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShipMethod is accessed. You can always execute
		/// a forced fetch by calling GetMultiShipMethod(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchShipMethod
		{
			get
			{
				return _alwaysFetchShipMethod;
			}
			set
			{
				_alwaysFetchShipMethod = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'AddressEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddress()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressCollection Address
		{
			get
			{
				return GetMultiAddress(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Address. When set to true, Address is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Address is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddress(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddress
		{
			get
			{
				return _alwaysFetchAddress;
			}
			set
			{
				_alwaysFetchAddress = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'AddressTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiAddressType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual AddressTypeCollection AddressType
		{
			get
			{
				return GetMultiAddressType(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for AddressType. When set to true, AddressType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time AddressType is accessed. You can always execute
		/// a forced fetch by calling GetMultiAddressType(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchAddressType
		{
			get
			{
				return _alwaysFetchAddressType;
			}
			set
			{
				_alwaysFetchAddressType = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ContactEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContact()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactCollection Contact
		{
			get
			{
				return GetMultiContact(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Contact. When set to true, Contact is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Contact is accessed. You can always execute
		/// a forced fetch by calling GetMultiContact(true).
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
		/// Retrieves all related entities of type 'ContactTypeEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiContactType()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ContactTypeCollection ContactType
		{
			get
			{
				return GetMultiContactType(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ContactType. When set to true, ContactType is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ContactType is accessed. You can always execute
		/// a forced fetch by calling GetMultiContactType(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchContactType
		{
			get
			{
				return _alwaysFetchContactType;
			}
			set
			{
				_alwaysFetchContactType = value;
			}	
		}
	
	
	
		#endregion
	}
}
