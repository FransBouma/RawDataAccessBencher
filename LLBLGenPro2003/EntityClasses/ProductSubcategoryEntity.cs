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
	/// Entity class which represents the entity 'ProductSubcategory' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ProductSubcategoryEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private ProductModelCollection _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel;
		private UnitMeasureCollection _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure;
		private UnitMeasureCollection _unitMeasure_;
		private bool	_alwaysFetchUnitMeasure_, _alreadyFetchedUnitMeasure_;
		private ProductCategoryEntity _productCategory;
		private bool	_alwaysFetchProductCategory, _alreadyFetchedProductCategory;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ProductSubcategoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductSubcategoryIDChanged;

		/// <summary>
		/// Event which is thrown when ProductCategoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductCategoryIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when Rowguid changes value. Databinding related.
		/// </summary>
		public event EventHandler RowguidChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ProductSubcategoryEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ProductSubcategoryEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID)
		{
			InitClassFetch(productSubcategoryID, new ProductSubcategoryValidator(), new PropertyDescriptorFactory(), new ProductSubcategoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The custom validator object for this ProductSubcategoryEntity</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID, ProductSubcategoryValidator validator)
		{
			InitClassFetch(productSubcategoryID, validator, new PropertyDescriptorFactory(), new ProductSubcategoryEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="validator">The custom validator object for this ProductSubcategoryEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductSubcategoryEntity(System.Int32 productSubcategoryID, ProductSubcategoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productSubcategoryID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductSubcategoryEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductSubcategoryEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_productModel = (ProductModelCollection)info.GetValue("_productModel", typeof(ProductModelCollection));
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");

			_unitMeasure = (UnitMeasureCollection)info.GetValue("_unitMeasure", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");

			_unitMeasure_ = (UnitMeasureCollection)info.GetValue("_unitMeasure_", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure_ = info.GetBoolean("_alwaysFetchUnitMeasure_");
			_alreadyFetchedUnitMeasure_ = info.GetBoolean("_alreadyFetchedUnitMeasure_");
			_productCategory = (ProductCategoryEntity)info.GetValue("_productCategory", typeof(ProductCategoryEntity));
			if(_productCategory!=null)
			{
				// rewire event handler.
				_productCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProductCategory = info.GetBoolean("_alwaysFetchProductCategory");
			_alreadyFetchedProductCategory = info.GetBoolean("_alreadyFetchedProductCategory");

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
			_alreadyFetchedProduct = (_product.Count > 0);
			_alreadyFetchedProductModel = (_productModel.Count > 0);
			_alreadyFetchedUnitMeasure = (_unitMeasure.Count > 0);
			_alreadyFetchedUnitMeasure_ = (_unitMeasure_.Count > 0);
			_alreadyFetchedProductCategory = (_productCategory != null);

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
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);
			info.AddValue("_productModel", _productModel);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);
			info.AddValue("_unitMeasure", _unitMeasure);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
			info.AddValue("_unitMeasure_", _unitMeasure_);
			info.AddValue("_alwaysFetchUnitMeasure_", _alwaysFetchUnitMeasure_);
			info.AddValue("_alreadyFetchedUnitMeasure_", _alreadyFetchedUnitMeasure_);
			info.AddValue("_productCategory", _productCategory);
			info.AddValue("_alwaysFetchProductCategory", _alwaysFetchProductCategory);
			info.AddValue("_alreadyFetchedProductCategory", _alreadyFetchedProductCategory);

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
				case "ProductCategory":
					SetupSyncProductCategory(relatedEntity);
					break;
				case "Product":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_product.Add(relatedEntity);
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
				case "ProductCategory":
					DesetupSyncProductCategory(false);
					break;
				case "Product":
					// Remove it from the collection.
					_product.Remove(relatedEntity);
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
			if(_productCategory!=null)
			{
				toReturn.Add(_productCategory);
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

			toReturn.Add(_product);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("ProductSubcategoryEntity");
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
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productSubcategoryID)
		{
			return Fetch(productSubcategoryID);
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
			return Fetch(this.ProductSubcategoryID);
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
			ProductSubcategoryDAO dao = DAOFactory.CreateProductSubcategoryDAO();
			bool wasSuccesful = dao.DeleteProductSubcategory(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ProductSubcategoryFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
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
				_product.GetMultiManyToOne(null, this, null, null);
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
				_product.GetMultiManyToOne(null, this, null, null, filter);
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
				_product.GetMultiManyToOne(null, this, null, null);
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
				_product.GetMultiManyToOne(null, this, null, null, filter);
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
				_productModel.GetMultiManyToManyUsingProductSubcategory(this);
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
				_productModel.GetMultiManyToManyUsingProductSubcategory(this);
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
				_unitMeasure.GetMultiManyToManyUsingProductSubcategory(this);
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
				_unitMeasure.GetMultiManyToManyUsingProductSubcategory(this);
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
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure_ || forceFetch || _alwaysFetchUnitMeasure_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure_);
					}
				}
				_unitMeasure_.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure_.GetMultiManyToManyUsingProductSubcategory_(this);
				_unitMeasure_.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure_ = true;
			}
			return _unitMeasure_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasure_ || forceFetch || _alwaysFetchUnitMeasure_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure_);
					}
				}
				_unitMeasure_.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure_.EntityFactoryToUse = entityFactoryToUse;
				_unitMeasure_.GetMultiManyToManyUsingProductSubcategory_(this);
				_unitMeasure_.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure_ = true;
			}
			return _unitMeasure_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'UnitMeasure_'. These settings will be taken into account
		/// when the property UnitMeasure_ is requested or GetMultiUnitMeasure_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasure_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasure_.SortClauses=sortClauses;
			_unitMeasure_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductCategoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductCategoryEntity' which is related to this entity.</returns>
		public virtual ProductCategoryEntity GetSingleProductCategory()
		{
			return GetSingleProductCategory(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductCategoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductCategoryEntity' which is related to this entity.</returns>
		public virtual ProductCategoryEntity GetSingleProductCategory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductCategory || forceFetch || _alwaysFetchProductCategory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductCategoryEntity newEntity = new ProductCategoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductCategoryID);
				this.ProductCategory = newEntity;

				_alreadyFetchedProductCategory = true;
			}
			return _productCategory;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ProductSubcategoryIDChanged event, which is thrown when ProductSubcategoryID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductSubcategoryIDChanged()
		{
			if(ProductSubcategoryIDChanged!=null)
			{
				ProductSubcategoryIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ProductCategoryIDChanged event, which is thrown when ProductCategoryID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductCategoryIDChanged()
		{
			if(ProductCategoryIDChanged!=null)
			{
				ProductCategoryIDChanged(this, new EventArgs());
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
		/// Event thrower for the RowguidChanged event, which is thrown when Rowguid changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnRowguidChanged()
		{
			if(RowguidChanged!=null)
			{
				RowguidChanged(this, new EventArgs());
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
			ProductSubcategoryDAO dao = DAOFactory.CreateProductSubcategoryDAO();
			return dao.AddProductSubcategory(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductSubcategoryDAO dao = DAOFactory.CreateProductSubcategoryDAO();
			return dao.UpdateProductSubcategory(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductSubcategoryDAO dao = DAOFactory.CreateProductSubcategoryDAO();
			return dao.UpdateProductSubcategory(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductSubcategoryEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ProductSubcategoryValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductSubcategoryEntity</param>
		private void InitClassFetch(System.Int32 productSubcategoryID, ProductSubcategoryValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductSubcategoryEntity);
			bool wasSuccesful = Fetch(productSubcategoryID);
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
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_product.SetContainingEntityInfo(this, "ProductSubcategory");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_productModel = new ProductModelCollection(propertyDescriptorFactoryToUse, new ProductModelEntityFactory());
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;
			_unitMeasure = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
			_unitMeasure_ = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure_ = false;
			_alreadyFetchedUnitMeasure_ = false;
			_productCategory = null;
			_alwaysFetchProductCategory = false;
			_alreadyFetchedProductCategory = false;

		}


		/// <summary>
		/// Removes the sync logic for member _productCategory
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductCategory(bool signalRelatedEntity)
		{
			if(_productCategory != null)
			{
				// disconnect the entity from this entity
				_productCategory.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_productCategory.UnsetRelatedEntity(this, "ProductSubcategory");
				}
				base.UnsetEntitySyncInformation("ProductCategory", _productCategory, ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID);
				_productCategory = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _productCategory
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductCategory(IEntity relatedEntity)
		{
			DesetupSyncProductCategory(true);
			
			if(relatedEntity!=null)
			{
				_productCategory = (ProductCategoryEntity)relatedEntity;
				_productCategory.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ProductCategory", _productCategory, ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID);
				if(!_productCategory.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductSubcategoryEntity.Relations.ProductCategoryEntityUsingProductCategoryID, _productCategory);
				}
			}

			_alreadyFetchedProductCategory = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="productSubcategoryID">PK value for ProductSubcategory which data should be fetched into this ProductSubcategory object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productSubcategoryID)
		{
			ProductSubcategoryDAO dao = DAOFactory.CreateProductSubcategoryDAO();

			// Load EntityFields of ProductSubcategory
			dao.FetchProductSubcategory(base.Fields, base.Transaction, productSubcategoryID);

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
		public static ProductSubcategoryRelations Relations
		{
			get	{ return new ProductSubcategoryRelations(); }
		}

	
		/// <summary>
		/// The ProductSubcategoryID property of the Entity ProductSubcategory
		/// </summary>
		public virtual System.Int32 ProductSubcategoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductSubcategoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductSubcategoryFieldIndex.ProductSubcategoryID, value))
				{
					OnProductSubcategoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductCategoryID property of the Entity ProductSubcategory
		/// </summary>
		public virtual System.Int32 ProductCategoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSubcategoryFieldIndex.ProductCategoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductCategoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductSubcategoryFieldIndex.ProductCategoryID, value))
				{
					OnProductCategoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity ProductSubcategory
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSubcategoryFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductSubcategoryFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity ProductSubcategory
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSubcategoryFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductSubcategoryFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ProductSubcategory
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductSubcategoryFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductSubcategoryFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
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
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasure_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual UnitMeasureCollection UnitMeasure_
		{
			get
			{
				return GetMultiUnitMeasure_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure_. When set to true, UnitMeasure_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasure_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure_
		{
			get
			{
				return _alwaysFetchUnitMeasure_;
			}
			set
			{
				_alwaysFetchUnitMeasure_ = value;
			}	
		}
	
	
		/// <summary>
		/// Gets / sets related entity of type 'ProductCategoryEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductCategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductCategoryEntity ProductCategory
		{
			get
			{
				return GetSingleProductCategory(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductCategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_productCategory != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_productCategory.UnsetRelatedEntity(this, "ProductSubcategory");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ProductSubcategory");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductCategory. When set to true, ProductCategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCategory is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductCategory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCategory
		{
			get
			{
				return _alwaysFetchProductCategory;
			}
			set
			{
				_alwaysFetchProductCategory = value;
			}	
		}
	
	
		#endregion
	}
}
