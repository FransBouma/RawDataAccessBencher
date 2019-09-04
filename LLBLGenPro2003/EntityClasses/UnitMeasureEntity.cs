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
	/// Entity class which represents the entity 'UnitMeasure' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class UnitMeasureEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private BillOfMaterialsCollection	_billOfMaterials;
		private bool	_alwaysFetchBillOfMaterials, _alreadyFetchedBillOfMaterials;
		private ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private ProductCollection	_product_;
		private bool	_alwaysFetchProduct_, _alreadyFetchedProduct_;
		private ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private ProductCollection _product__;
		private bool	_alwaysFetchProduct__, _alreadyFetchedProduct__;
		private ProductCollection _product___;
		private bool	_alwaysFetchProduct___, _alreadyFetchedProduct___;
		private ProductModelCollection _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel;
		private ProductModelCollection _productModel_;
		private bool	_alwaysFetchProductModel_, _alreadyFetchedProductModel_;
		private ProductSubcategoryCollection _productSubcategory;
		private bool	_alwaysFetchProductSubcategory, _alreadyFetchedProductSubcategory;
		private ProductSubcategoryCollection _productSubcategory_;
		private bool	_alwaysFetchProductSubcategory_, _alreadyFetchedProductSubcategory_;
		private ProductCollection _product____;
		private bool	_alwaysFetchProduct____, _alreadyFetchedProduct____;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when UnitMeasureCode changes value. Databinding related.
		/// </summary>
		public event EventHandler UnitMeasureCodeChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public UnitMeasureEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new UnitMeasureEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		public UnitMeasureEntity(System.String unitMeasureCode)
		{
			InitClassFetch(unitMeasureCode, new UnitMeasureValidator(), new PropertyDescriptorFactory(), new UnitMeasureEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		public UnitMeasureEntity(System.String unitMeasureCode, UnitMeasureValidator validator)
		{
			InitClassFetch(unitMeasureCode, validator, new PropertyDescriptorFactory(), new UnitMeasureEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="validator">The custom validator object for this UnitMeasureEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public UnitMeasureEntity(System.String unitMeasureCode, UnitMeasureValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(unitMeasureCode, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public UnitMeasureEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private UnitMeasureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_billOfMaterials = (BillOfMaterialsCollection)info.GetValue("_billOfMaterials", typeof(BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials = info.GetBoolean("_alwaysFetchBillOfMaterials");
			_alreadyFetchedBillOfMaterials = info.GetBoolean("_alreadyFetchedBillOfMaterials");

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_product_ = (ProductCollection)info.GetValue("_product_", typeof(ProductCollection));
			_alwaysFetchProduct_ = info.GetBoolean("_alwaysFetchProduct_");
			_alreadyFetchedProduct_ = info.GetBoolean("_alreadyFetchedProduct_");

			_productVendor = (ProductVendorCollection)info.GetValue("_productVendor", typeof(ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");

			_product__ = (ProductCollection)info.GetValue("_product__", typeof(ProductCollection));
			_alwaysFetchProduct__ = info.GetBoolean("_alwaysFetchProduct__");
			_alreadyFetchedProduct__ = info.GetBoolean("_alreadyFetchedProduct__");

			_product___ = (ProductCollection)info.GetValue("_product___", typeof(ProductCollection));
			_alwaysFetchProduct___ = info.GetBoolean("_alwaysFetchProduct___");
			_alreadyFetchedProduct___ = info.GetBoolean("_alreadyFetchedProduct___");

			_productModel = (ProductModelCollection)info.GetValue("_productModel", typeof(ProductModelCollection));
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");

			_productModel_ = (ProductModelCollection)info.GetValue("_productModel_", typeof(ProductModelCollection));
			_alwaysFetchProductModel_ = info.GetBoolean("_alwaysFetchProductModel_");
			_alreadyFetchedProductModel_ = info.GetBoolean("_alreadyFetchedProductModel_");

			_productSubcategory = (ProductSubcategoryCollection)info.GetValue("_productSubcategory", typeof(ProductSubcategoryCollection));
			_alwaysFetchProductSubcategory = info.GetBoolean("_alwaysFetchProductSubcategory");
			_alreadyFetchedProductSubcategory = info.GetBoolean("_alreadyFetchedProductSubcategory");

			_productSubcategory_ = (ProductSubcategoryCollection)info.GetValue("_productSubcategory_", typeof(ProductSubcategoryCollection));
			_alwaysFetchProductSubcategory_ = info.GetBoolean("_alwaysFetchProductSubcategory_");
			_alreadyFetchedProductSubcategory_ = info.GetBoolean("_alreadyFetchedProductSubcategory_");

			_product____ = (ProductCollection)info.GetValue("_product____", typeof(ProductCollection));
			_alwaysFetchProduct____ = info.GetBoolean("_alwaysFetchProduct____");
			_alreadyFetchedProduct____ = info.GetBoolean("_alreadyFetchedProduct____");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");


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
			_alreadyFetchedBillOfMaterials = (_billOfMaterials.Count > 0);
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedProduct_ = (_product_.Count > 0);
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedProduct__ = (_product__.Count > 0);
			_alreadyFetchedProduct___ = (_product___.Count > 0);
			_alreadyFetchedProductModel = (_productModel.Count > 0);
			_alreadyFetchedProductModel_ = (_productModel_.Count > 0);
			_alreadyFetchedProductSubcategory = (_productSubcategory.Count > 0);
			_alreadyFetchedProductSubcategory_ = (_productSubcategory_.Count > 0);
			_alreadyFetchedProduct____ = (_product____.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);


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
			info.AddValue("_billOfMaterials", _billOfMaterials);
			info.AddValue("_alwaysFetchBillOfMaterials", _alwaysFetchBillOfMaterials);
			info.AddValue("_alreadyFetchedBillOfMaterials", _alreadyFetchedBillOfMaterials);
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_product_", _product_);
			info.AddValue("_alwaysFetchProduct_", _alwaysFetchProduct_);
			info.AddValue("_alreadyFetchedProduct_", _alreadyFetchedProduct_);
			info.AddValue("_productVendor", _productVendor);
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_product__", _product__);
			info.AddValue("_alwaysFetchProduct__", _alwaysFetchProduct__);
			info.AddValue("_alreadyFetchedProduct__", _alreadyFetchedProduct__);
			info.AddValue("_product___", _product___);
			info.AddValue("_alwaysFetchProduct___", _alwaysFetchProduct___);
			info.AddValue("_alreadyFetchedProduct___", _alreadyFetchedProduct___);
			info.AddValue("_productModel", _productModel);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);
			info.AddValue("_productModel_", _productModel_);
			info.AddValue("_alwaysFetchProductModel_", _alwaysFetchProductModel_);
			info.AddValue("_alreadyFetchedProductModel_", _alreadyFetchedProductModel_);
			info.AddValue("_productSubcategory", _productSubcategory);
			info.AddValue("_alwaysFetchProductSubcategory", _alwaysFetchProductSubcategory);
			info.AddValue("_alreadyFetchedProductSubcategory", _alreadyFetchedProductSubcategory);
			info.AddValue("_productSubcategory_", _productSubcategory_);
			info.AddValue("_alwaysFetchProductSubcategory_", _alwaysFetchProductSubcategory_);
			info.AddValue("_alreadyFetchedProductSubcategory_", _alreadyFetchedProductSubcategory_);
			info.AddValue("_product____", _product____);
			info.AddValue("_alwaysFetchProduct____", _alwaysFetchProduct____);
			info.AddValue("_alreadyFetchedProduct____", _alreadyFetchedProduct____);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);


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

				case "BillOfMaterials":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_billOfMaterials.Add(relatedEntity);
					break;
				case "Product":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_product.Add(relatedEntity);
					break;
				case "Product_":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_product_.Add(relatedEntity);
					break;
				case "ProductVendor":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productVendor.Add(relatedEntity);
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

				case "BillOfMaterials":
					// Remove it from the collection.
					_billOfMaterials.Remove(relatedEntity);
					break;
				case "Product":
					// Remove it from the collection.
					_product.Remove(relatedEntity);
					break;
				case "Product_":
					// Remove it from the collection.
					_product_.Remove(relatedEntity);
					break;
				case "ProductVendor":
					// Remove it from the collection.
					_productVendor.Remove(relatedEntity);
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

			toReturn.Add(_billOfMaterials);
			toReturn.Add(_product);
			toReturn.Add(_product_);
			toReturn.Add(_productVendor);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("UnitMeasureEntity");
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
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.String unitMeasureCode)
		{
			return Fetch(unitMeasureCode);
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
			return Fetch(this.UnitMeasureCode);
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			bool wasSuccesful = dao.DeleteUnitMeasure(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(UnitMeasureFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials);
					}
				}
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials.GetMultiManyToOne(null, null, this);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials);
					}
				}
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials.GetMultiManyToOne(null, null, this, filter);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials);
					}
				}
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				_billOfMaterials.GetMultiManyToOne(null, null, this);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials || forceFetch || _alwaysFetchBillOfMaterials) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials);
					}
				}
				_billOfMaterials.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials.EntityFactoryToUse = entityFactoryToUse;
				_billOfMaterials.GetMultiManyToOne(null, null, this, filter);
				_billOfMaterials.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials = true;
			}
			return _billOfMaterials;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'BillOfMaterials'. These settings will be taken into account
		/// when the property BillOfMaterials is requested or GetMultiBillOfMaterials is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfMaterials(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfMaterials.SortClauses=sortClauses;
			_billOfMaterials.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
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
				_product.GetMultiManyToOne(null, null, this, null);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch, IPredicateExpression filter)
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
				_product.GetMultiManyToOne(null, null, this, null, filter);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
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
				_product.GetMultiManyToOne(null, null, this, null);
				_product.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct = true;
			}
			return _product;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
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
				_product.GetMultiManyToOne(null, null, this, null, filter);
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
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product_);
					}
				}
				_product_.SuppressClearInGetMulti=!forceFetch;
				_product_.GetMultiManyToOne(null, null, null, this);
				_product_.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct_(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product_);
					}
				}
				_product_.SuppressClearInGetMulti=!forceFetch;
				_product_.GetMultiManyToOne(null, null, null, this, filter);
				_product_.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product_);
					}
				}
				_product_.SuppressClearInGetMulti=!forceFetch;
				_product_.EntityFactoryToUse = entityFactoryToUse;
				_product_.GetMultiManyToOne(null, null, null, this);
				_product_.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProduct_ || forceFetch || _alwaysFetchProduct_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product_);
					}
				}
				_product_.SuppressClearInGetMulti=!forceFetch;
				_product_.EntityFactoryToUse = entityFactoryToUse;
				_product_.GetMultiManyToOne(null, null, null, this, filter);
				_product_.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct_ = true;
			}
			return _product_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product_'. These settings will be taken into account
		/// when the property Product_ is requested or GetMultiProduct_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product_.SortClauses=sortClauses;
			_product_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productVendor.GetMultiManyToOne(null, this, null);
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
				_productVendor.GetMultiManyToOne(null, this, null, filter);
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
				_productVendor.GetMultiManyToOne(null, this, null);
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
				_productVendor.GetMultiManyToOne(null, this, null, filter);
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
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct__ || forceFetch || _alwaysFetchProduct__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product__);
					}
				}
				_product__.SuppressClearInGetMulti=!forceFetch;
				_product__.GetMultiManyToManyUsingUnitMeasure__(this);
				_product__.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct__ = true;
			}
			return _product__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct__ || forceFetch || _alwaysFetchProduct__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product__);
					}
				}
				_product__.SuppressClearInGetMulti=!forceFetch;
				_product__.EntityFactoryToUse = entityFactoryToUse;
				_product__.GetMultiManyToManyUsingUnitMeasure__(this);
				_product__.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct__ = true;
			}
			return _product__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product__'. These settings will be taken into account
		/// when the property Product__ is requested or GetMultiProduct__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product__.SortClauses=sortClauses;
			_product__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct___(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct___ || forceFetch || _alwaysFetchProduct___) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product___);
					}
				}
				_product___.SuppressClearInGetMulti=!forceFetch;
				_product___.GetMultiManyToManyUsingUnitMeasure___(this);
				_product___.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct___ = true;
			}
			return _product___;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct___ || forceFetch || _alwaysFetchProduct___) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product___);
					}
				}
				_product___.SuppressClearInGetMulti=!forceFetch;
				_product___.EntityFactoryToUse = entityFactoryToUse;
				_product___.GetMultiManyToManyUsingUnitMeasure___(this);
				_product___.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct___ = true;
			}
			return _product___;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product___'. These settings will be taken into account
		/// when the property Product___ is requested or GetMultiProduct___ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product___.SortClauses=sortClauses;
			_product___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public virtual ProductModelCollection GetMultiProductModel(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModel.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModel);
					}
				}
				_productModel.SuppressClearInGetMulti=!forceFetch;
				_productModel.GetMultiManyToManyUsingUnitMeasure(this);
				_productModel.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModel = true;
			}
			return _productModel;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelCollection GetMultiProductModel(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModel.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModel);
					}
				}
				_productModel.SuppressClearInGetMulti=!forceFetch;
				_productModel.EntityFactoryToUse = entityFactoryToUse;
				_productModel.GetMultiManyToManyUsingUnitMeasure(this);
				_productModel.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModel = true;
			}
			return _productModel;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductModel'. These settings will be taken into account
		/// when the property ProductModel is requested or GetMultiProductModel is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModel(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModel.SortClauses=sortClauses;
			_productModel.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelEntity'</returns>
		public virtual ProductModelCollection GetMultiProductModel_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductModel_ || forceFetch || _alwaysFetchProductModel_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModel_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModel_);
					}
				}
				_productModel_.SuppressClearInGetMulti=!forceFetch;
				_productModel_.GetMultiManyToManyUsingUnitMeasure_(this);
				_productModel_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModel_ = true;
			}
			return _productModel_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelCollection GetMultiProductModel_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModel_ || forceFetch || _alwaysFetchProductModel_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModel_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModel_);
					}
				}
				_productModel_.SuppressClearInGetMulti=!forceFetch;
				_productModel_.EntityFactoryToUse = entityFactoryToUse;
				_productModel_.GetMultiManyToManyUsingUnitMeasure_(this);
				_productModel_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModel_ = true;
			}
			return _productModel_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductModel_'. These settings will be taken into account
		/// when the property ProductModel_ is requested or GetMultiProductModel_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModel_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModel_.SortClauses=sortClauses;
			_productModel_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSubcategoryEntity'</returns>
		public virtual ProductSubcategoryCollection GetMultiProductSubcategory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductSubcategory || forceFetch || _alwaysFetchProductSubcategory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategory);
					}
				}
				_productSubcategory.SuppressClearInGetMulti=!forceFetch;
				_productSubcategory.GetMultiManyToManyUsingUnitMeasure(this);
				_productSubcategory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategory = true;
			}
			return _productSubcategory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSubcategoryCollection GetMultiProductSubcategory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductSubcategory || forceFetch || _alwaysFetchProductSubcategory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategory);
					}
				}
				_productSubcategory.SuppressClearInGetMulti=!forceFetch;
				_productSubcategory.EntityFactoryToUse = entityFactoryToUse;
				_productSubcategory.GetMultiManyToManyUsingUnitMeasure(this);
				_productSubcategory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategory = true;
			}
			return _productSubcategory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductSubcategory'. These settings will be taken into account
		/// when the property ProductSubcategory is requested or GetMultiProductSubcategory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductSubcategory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productSubcategory.SortClauses=sortClauses;
			_productSubcategory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductSubcategoryEntity'</returns>
		public virtual ProductSubcategoryCollection GetMultiProductSubcategory_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductSubcategory_ || forceFetch || _alwaysFetchProductSubcategory_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategory_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategory_);
					}
				}
				_productSubcategory_.SuppressClearInGetMulti=!forceFetch;
				_productSubcategory_.GetMultiManyToManyUsingUnitMeasure_(this);
				_productSubcategory_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategory_ = true;
			}
			return _productSubcategory_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductSubcategoryCollection GetMultiProductSubcategory_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductSubcategory_ || forceFetch || _alwaysFetchProductSubcategory_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productSubcategory_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productSubcategory_);
					}
				}
				_productSubcategory_.SuppressClearInGetMulti=!forceFetch;
				_productSubcategory_.EntityFactoryToUse = entityFactoryToUse;
				_productSubcategory_.GetMultiManyToManyUsingUnitMeasure_(this);
				_productSubcategory_.SuppressClearInGetMulti=false;
				_alreadyFetchedProductSubcategory_ = true;
			}
			return _productSubcategory_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductSubcategory_'. These settings will be taken into account
		/// when the property ProductSubcategory_ is requested or GetMultiProductSubcategory_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductSubcategory_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productSubcategory_.SortClauses=sortClauses;
			_productSubcategory_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductEntity'</returns>
		public virtual ProductCollection GetMultiProduct____(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProduct____ || forceFetch || _alwaysFetchProduct____) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product____);
					}
				}
				_product____.SuppressClearInGetMulti=!forceFetch;
				_product____.GetMultiManyToManyUsingUnitMeasure____(this);
				_product____.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct____ = true;
			}
			return _product____;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCollection GetMultiProduct____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProduct____ || forceFetch || _alwaysFetchProduct____) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_product____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_product____);
					}
				}
				_product____.SuppressClearInGetMulti=!forceFetch;
				_product____.EntityFactoryToUse = entityFactoryToUse;
				_product____.GetMultiManyToManyUsingUnitMeasure____(this);
				_product____.SuppressClearInGetMulti=false;
				_alreadyFetchedProduct____ = true;
			}
			return _product____;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Product____'. These settings will be taken into account
		/// when the property Product____ is requested or GetMultiProduct____ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProduct____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_product____.SortClauses=sortClauses;
			_product____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'VendorEntity'</returns>
		public virtual VendorCollection GetMultiVendor(bool forceFetch)
		{
 			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendor);
					}
				}
				_vendor.SuppressClearInGetMulti=!forceFetch;
				_vendor.GetMultiManyToManyUsingUnitMeasure(this);
				_vendor.SuppressClearInGetMulti=false;
				_alreadyFetchedVendor = true;
			}
			return _vendor;
		}


		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual VendorCollection GetMultiVendor(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedVendor || forceFetch || _alwaysFetchVendor) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_vendor.ParticipatesInTransaction)
					{
						base.Transaction.Add(_vendor);
					}
				}
				_vendor.SuppressClearInGetMulti=!forceFetch;
				_vendor.EntityFactoryToUse = entityFactoryToUse;
				_vendor.GetMultiManyToManyUsingUnitMeasure(this);
				_vendor.SuppressClearInGetMulti=false;
				_alreadyFetchedVendor = true;
			}
			return _vendor;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Vendor'. These settings will be taken into account
		/// when the property Vendor is requested or GetMultiVendor is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersVendor(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_vendor.SortClauses=sortClauses;
			_vendor.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the UnitMeasureCodeChanged event, which is thrown when UnitMeasureCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnUnitMeasureCodeChanged()
		{
			if(UnitMeasureCodeChanged!=null)
			{
				UnitMeasureCodeChanged(this, new EventArgs());
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
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.AddUnitMeasure(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.UpdateUnitMeasure(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();
			return dao.UpdateUnitMeasure(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.UnitMeasureEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new UnitMeasureValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this UnitMeasureEntity</param>
		private void InitClassFetch(System.String unitMeasureCode, UnitMeasureValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.UnitMeasureEntity);
			bool wasSuccesful = Fetch(unitMeasureCode);
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
			_billOfMaterials = new BillOfMaterialsCollection(propertyDescriptorFactoryToUse, new BillOfMaterialsEntityFactory());
			_billOfMaterials.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchBillOfMaterials = false;
			_alreadyFetchedBillOfMaterials = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_product.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_product_ = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_product_.SetContainingEntityInfo(this, "UnitMeasure_");
			_alwaysFetchProduct_ = false;
			_alreadyFetchedProduct_ = false;
			_productVendor = new ProductVendorCollection(propertyDescriptorFactoryToUse, new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "UnitMeasure");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_product__ = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct__ = false;
			_alreadyFetchedProduct__ = false;
			_product___ = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct___ = false;
			_alreadyFetchedProduct___ = false;
			_productModel = new ProductModelCollection(propertyDescriptorFactoryToUse, new ProductModelEntityFactory());
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;
			_productModel_ = new ProductModelCollection(propertyDescriptorFactoryToUse, new ProductModelEntityFactory());
			_alwaysFetchProductModel_ = false;
			_alreadyFetchedProductModel_ = false;
			_productSubcategory = new ProductSubcategoryCollection(propertyDescriptorFactoryToUse, new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategory = false;
			_alreadyFetchedProductSubcategory = false;
			_productSubcategory_ = new ProductSubcategoryCollection(propertyDescriptorFactoryToUse, new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategory_ = false;
			_alreadyFetchedProductSubcategory_ = false;
			_product____ = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct____ = false;
			_alreadyFetchedProduct____ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="unitMeasureCode">PK value for UnitMeasure which data should be fetched into this UnitMeasure object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.String unitMeasureCode)
		{
			UnitMeasureDAO dao = DAOFactory.CreateUnitMeasureDAO();

			// Load EntityFields of UnitMeasure
			dao.FetchUnitMeasure(base.Fields, base.Transaction, unitMeasureCode);

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
		public static UnitMeasureRelations Relations
		{
			get	{ return new UnitMeasureRelations(); }
		}

	
		/// <summary>
		/// The UnitMeasureCode property of the Entity UnitMeasure
		/// </summary>
		public virtual System.String UnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UnitMeasureFieldIndex.UnitMeasureCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for UnitMeasureCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UnitMeasureFieldIndex.UnitMeasureCode, value))
				{
					OnUnitMeasureCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity UnitMeasure
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UnitMeasureFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UnitMeasureFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity UnitMeasure
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)UnitMeasureFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)UnitMeasureFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfMaterials()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual BillOfMaterialsCollection BillOfMaterials
		{
			get
			{
				return GetMultiBillOfMaterials(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for BillOfMaterials. When set to true, BillOfMaterials is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfMaterials is accessed. You can always execute
		/// a forced fetch by calling GetMultiBillOfMaterials(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfMaterials
		{
			get
			{
				return _alwaysFetchBillOfMaterials;
			}
			set
			{
				_alwaysFetchBillOfMaterials = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
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
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product_
		{
			get
			{
				return GetMultiProduct_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product_. When set to true, Product_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct_
		{
			get
			{
				return _alwaysFetchProduct_;
			}
			set
			{
				_alwaysFetchProduct_ = value;
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
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product__
		{
			get
			{
				return GetMultiProduct__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product__. When set to true, Product__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct__
		{
			get
			{
				return _alwaysFetchProduct__;
			}
			set
			{
				_alwaysFetchProduct__ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product___
		{
			get
			{
				return GetMultiProduct___(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product___. When set to true, Product___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct___(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct___
		{
			get
			{
				return _alwaysFetchProduct___;
			}
			set
			{
				_alwaysFetchProduct___ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModel()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductModelCollection ProductModel
		{
			get
			{
				return GetMultiProductModel(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductModel. When set to true, ProductModel is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModel(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModel
		{
			get
			{
				return _alwaysFetchProductModel;
			}
			set
			{
				_alwaysFetchProductModel = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModel_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductModelCollection ProductModel_
		{
			get
			{
				return GetMultiProductModel_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductModel_. When set to true, ProductModel_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModel_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModel_
		{
			get
			{
				return _alwaysFetchProductModel_;
			}
			set
			{
				_alwaysFetchProductModel_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductSubcategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductSubcategoryCollection ProductSubcategory
		{
			get
			{
				return GetMultiProductSubcategory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductSubcategory. When set to true, ProductSubcategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductSubcategory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSubcategory
		{
			get
			{
				return _alwaysFetchProductSubcategory;
			}
			set
			{
				_alwaysFetchProductSubcategory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductSubcategoryEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductSubcategory_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductSubcategoryCollection ProductSubcategory_
		{
			get
			{
				return GetMultiProductSubcategory_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductSubcategory_. When set to true, ProductSubcategory_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategory_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductSubcategory_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductSubcategory_
		{
			get
			{
				return _alwaysFetchProductSubcategory_;
			}
			set
			{
				_alwaysFetchProductSubcategory_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProduct____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCollection Product____
		{
			get
			{
				return GetMultiProduct____(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Product____. When set to true, Product____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Product____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiProduct____(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProduct____
		{
			get
			{
				return _alwaysFetchProduct____;
			}
			set
			{
				_alwaysFetchProduct____ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'VendorEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiVendor()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual VendorCollection Vendor
		{
			get
			{
				return GetMultiVendor(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Vendor. When set to true, Vendor is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Vendor is accessed. You can always execute
		/// a forced fetch by calling GetMultiVendor(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchVendor
		{
			get
			{
				return _alwaysFetchVendor;
			}
			set
			{
				_alwaysFetchVendor = value;
			}	
		}
	
	
	
		#endregion
	}
}
