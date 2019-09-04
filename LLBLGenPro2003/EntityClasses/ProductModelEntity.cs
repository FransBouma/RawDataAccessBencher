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
	/// Entity class which represents the entity 'ProductModel' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ProductModelEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private ProductCollection	_product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;
		private ProductModelIllustrationCollection	_productModelIllustration;
		private bool	_alwaysFetchProductModelIllustration, _alreadyFetchedProductModelIllustration;
		private ProductModelProductDescriptionCultureCollection	_productModelProductDescriptionCulture;
		private bool	_alwaysFetchProductModelProductDescriptionCulture, _alreadyFetchedProductModelProductDescriptionCulture;
		private ProductSubcategoryCollection _productSubcategory;
		private bool	_alwaysFetchProductSubcategory, _alreadyFetchedProductSubcategory;
		private UnitMeasureCollection _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure;
		private UnitMeasureCollection _unitMeasure_;
		private bool	_alwaysFetchUnitMeasure_, _alreadyFetchedUnitMeasure_;
		private IllustrationCollection _illustration;
		private bool	_alwaysFetchIllustration, _alreadyFetchedIllustration;
		private CultureCollection _culture;
		private bool	_alwaysFetchCulture, _alreadyFetchedCulture;
		private ProductDescriptionCollection _productDescription;
		private bool	_alwaysFetchProductDescription, _alreadyFetchedProductDescription;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ProductModelID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductModelIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when CatalogDescription changes value. Databinding related.
		/// </summary>
		public event EventHandler CatalogDescriptionChanged;

		/// <summary>
		/// Event which is thrown when Instructions changes value. Databinding related.
		/// </summary>
		public event EventHandler InstructionsChanged;

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
		public ProductModelEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ProductModelEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		public ProductModelEntity(System.Int32 productModelID)
		{
			InitClassFetch(productModelID, new ProductModelValidator(), new PropertyDescriptorFactory(), new ProductModelEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		public ProductModelEntity(System.Int32 productModelID, ProductModelValidator validator)
		{
			InitClassFetch(productModelID, validator, new PropertyDescriptorFactory(), new ProductModelEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="validator">The custom validator object for this ProductModelEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductModelEntity(System.Int32 productModelID, ProductModelValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productModelID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductModelEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductModelEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");

			_productModelIllustration = (ProductModelIllustrationCollection)info.GetValue("_productModelIllustration", typeof(ProductModelIllustrationCollection));
			_alwaysFetchProductModelIllustration = info.GetBoolean("_alwaysFetchProductModelIllustration");
			_alreadyFetchedProductModelIllustration = info.GetBoolean("_alreadyFetchedProductModelIllustration");

			_productModelProductDescriptionCulture = (ProductModelProductDescriptionCultureCollection)info.GetValue("_productModelProductDescriptionCulture", typeof(ProductModelProductDescriptionCultureCollection));
			_alwaysFetchProductModelProductDescriptionCulture = info.GetBoolean("_alwaysFetchProductModelProductDescriptionCulture");
			_alreadyFetchedProductModelProductDescriptionCulture = info.GetBoolean("_alreadyFetchedProductModelProductDescriptionCulture");

			_productSubcategory = (ProductSubcategoryCollection)info.GetValue("_productSubcategory", typeof(ProductSubcategoryCollection));
			_alwaysFetchProductSubcategory = info.GetBoolean("_alwaysFetchProductSubcategory");
			_alreadyFetchedProductSubcategory = info.GetBoolean("_alreadyFetchedProductSubcategory");

			_unitMeasure = (UnitMeasureCollection)info.GetValue("_unitMeasure", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");

			_unitMeasure_ = (UnitMeasureCollection)info.GetValue("_unitMeasure_", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure_ = info.GetBoolean("_alwaysFetchUnitMeasure_");
			_alreadyFetchedUnitMeasure_ = info.GetBoolean("_alreadyFetchedUnitMeasure_");

			_illustration = (IllustrationCollection)info.GetValue("_illustration", typeof(IllustrationCollection));
			_alwaysFetchIllustration = info.GetBoolean("_alwaysFetchIllustration");
			_alreadyFetchedIllustration = info.GetBoolean("_alreadyFetchedIllustration");

			_culture = (CultureCollection)info.GetValue("_culture", typeof(CultureCollection));
			_alwaysFetchCulture = info.GetBoolean("_alwaysFetchCulture");
			_alreadyFetchedCulture = info.GetBoolean("_alreadyFetchedCulture");

			_productDescription = (ProductDescriptionCollection)info.GetValue("_productDescription", typeof(ProductDescriptionCollection));
			_alwaysFetchProductDescription = info.GetBoolean("_alwaysFetchProductDescription");
			_alreadyFetchedProductDescription = info.GetBoolean("_alreadyFetchedProductDescription");


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
			_alreadyFetchedProductModelIllustration = (_productModelIllustration.Count > 0);
			_alreadyFetchedProductModelProductDescriptionCulture = (_productModelProductDescriptionCulture.Count > 0);
			_alreadyFetchedProductSubcategory = (_productSubcategory.Count > 0);
			_alreadyFetchedUnitMeasure = (_unitMeasure.Count > 0);
			_alreadyFetchedUnitMeasure_ = (_unitMeasure_.Count > 0);
			_alreadyFetchedIllustration = (_illustration.Count > 0);
			_alreadyFetchedCulture = (_culture.Count > 0);
			_alreadyFetchedProductDescription = (_productDescription.Count > 0);


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
			info.AddValue("_productModelIllustration", _productModelIllustration);
			info.AddValue("_alwaysFetchProductModelIllustration", _alwaysFetchProductModelIllustration);
			info.AddValue("_alreadyFetchedProductModelIllustration", _alreadyFetchedProductModelIllustration);
			info.AddValue("_productModelProductDescriptionCulture", _productModelProductDescriptionCulture);
			info.AddValue("_alwaysFetchProductModelProductDescriptionCulture", _alwaysFetchProductModelProductDescriptionCulture);
			info.AddValue("_alreadyFetchedProductModelProductDescriptionCulture", _alreadyFetchedProductModelProductDescriptionCulture);
			info.AddValue("_productSubcategory", _productSubcategory);
			info.AddValue("_alwaysFetchProductSubcategory", _alwaysFetchProductSubcategory);
			info.AddValue("_alreadyFetchedProductSubcategory", _alreadyFetchedProductSubcategory);
			info.AddValue("_unitMeasure", _unitMeasure);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
			info.AddValue("_unitMeasure_", _unitMeasure_);
			info.AddValue("_alwaysFetchUnitMeasure_", _alwaysFetchUnitMeasure_);
			info.AddValue("_alreadyFetchedUnitMeasure_", _alreadyFetchedUnitMeasure_);
			info.AddValue("_illustration", _illustration);
			info.AddValue("_alwaysFetchIllustration", _alwaysFetchIllustration);
			info.AddValue("_alreadyFetchedIllustration", _alreadyFetchedIllustration);
			info.AddValue("_culture", _culture);
			info.AddValue("_alwaysFetchCulture", _alwaysFetchCulture);
			info.AddValue("_alreadyFetchedCulture", _alreadyFetchedCulture);
			info.AddValue("_productDescription", _productDescription);
			info.AddValue("_alwaysFetchProductDescription", _alwaysFetchProductDescription);
			info.AddValue("_alreadyFetchedProductDescription", _alreadyFetchedProductDescription);


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

				case "Product":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_product.Add(relatedEntity);
					break;
				case "ProductModelIllustration":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productModelIllustration.Add(relatedEntity);
					break;
				case "ProductModelProductDescriptionCulture":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productModelProductDescriptionCulture.Add(relatedEntity);
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

				case "Product":
					// Remove it from the collection.
					_product.Remove(relatedEntity);
					break;
				case "ProductModelIllustration":
					// Remove it from the collection.
					_productModelIllustration.Remove(relatedEntity);
					break;
				case "ProductModelProductDescriptionCulture":
					// Remove it from the collection.
					_productModelProductDescriptionCulture.Remove(relatedEntity);
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

			toReturn.Add(_product);
			toReturn.Add(_productModelIllustration);
			toReturn.Add(_productModelProductDescriptionCulture);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("ProductModelEntity");
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
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID)
		{
			return Fetch(productModelID);
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
			return Fetch(this.ProductModelID);
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
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();
			bool wasSuccesful = dao.DeleteProductModel(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ProductModelFieldIndex fieldIndex)
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
				_product.GetMultiManyToOne(this, null, null, null);
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
				_product.GetMultiManyToOne(this, null, null, null, filter);
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
				_product.GetMultiManyToOne(this, null, null, null);
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
				_product.GetMultiManyToOne(this, null, null, null, filter);
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
		/// Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public virtual ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				_productModelIllustration.GetMultiManyToOne(null, this);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelIllustrationEntity'</returns>
		public virtual ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				_productModelIllustration.GetMultiManyToOne(null, this, filter);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				_productModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				_productModelIllustration.GetMultiManyToOne(null, this);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelIllustrationCollection GetMultiProductModelIllustration(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelIllustration || forceFetch || _alwaysFetchProductModelIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelIllustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelIllustration);
					}
				}
				_productModelIllustration.SuppressClearInGetMulti=!forceFetch;
				_productModelIllustration.EntityFactoryToUse = entityFactoryToUse;
				_productModelIllustration.GetMultiManyToOne(null, this, filter);
				_productModelIllustration.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelIllustration = true;
			}
			return _productModelIllustration;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductModelIllustration'. These settings will be taken into account
		/// when the property ProductModelIllustration is requested or GetMultiProductModelIllustration is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelIllustration.SortClauses=sortClauses;
			_productModelIllustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public virtual ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				_productModelProductDescriptionCulture.GetMultiManyToOne(null, null, this);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductModelProductDescriptionCultureEntity'</returns>
		public virtual ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				_productModelProductDescriptionCulture.GetMultiManyToOne(null, null, this, filter);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				_productModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				_productModelProductDescriptionCulture.GetMultiManyToOne(null, null, this);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductModelProductDescriptionCultureCollection GetMultiProductModelProductDescriptionCulture(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductModelProductDescriptionCulture || forceFetch || _alwaysFetchProductModelProductDescriptionCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productModelProductDescriptionCulture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productModelProductDescriptionCulture);
					}
				}
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=!forceFetch;
				_productModelProductDescriptionCulture.EntityFactoryToUse = entityFactoryToUse;
				_productModelProductDescriptionCulture.GetMultiManyToOne(null, null, this, filter);
				_productModelProductDescriptionCulture.SuppressClearInGetMulti=false;
				_alreadyFetchedProductModelProductDescriptionCulture = true;
			}
			return _productModelProductDescriptionCulture;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductModelProductDescriptionCulture'. These settings will be taken into account
		/// when the property ProductModelProductDescriptionCulture is requested or GetMultiProductModelProductDescriptionCulture is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductModelProductDescriptionCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productModelProductDescriptionCulture.SortClauses=sortClauses;
			_productModelProductDescriptionCulture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productSubcategory.GetMultiManyToManyUsingProductModel(this);
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
				_productSubcategory.GetMultiManyToManyUsingProductModel(this);
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
				_unitMeasure.GetMultiManyToManyUsingProductModel(this);
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
				_unitMeasure.GetMultiManyToManyUsingProductModel(this);
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
				_unitMeasure_.GetMultiManyToManyUsingProductModel_(this);
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
				_unitMeasure_.GetMultiManyToManyUsingProductModel_(this);
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
		/// Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'IllustrationEntity'</returns>
		public virtual IllustrationCollection GetMultiIllustration(bool forceFetch)
		{
 			if( ( !_alreadyFetchedIllustration || forceFetch || _alwaysFetchIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_illustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_illustration);
					}
				}
				_illustration.SuppressClearInGetMulti=!forceFetch;
				_illustration.GetMultiManyToManyUsingProductModel(this);
				_illustration.SuppressClearInGetMulti=false;
				_alreadyFetchedIllustration = true;
			}
			return _illustration;
		}


		/// <summary>
		/// Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual IllustrationCollection GetMultiIllustration(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedIllustration || forceFetch || _alwaysFetchIllustration) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_illustration.ParticipatesInTransaction)
					{
						base.Transaction.Add(_illustration);
					}
				}
				_illustration.SuppressClearInGetMulti=!forceFetch;
				_illustration.EntityFactoryToUse = entityFactoryToUse;
				_illustration.GetMultiManyToManyUsingProductModel(this);
				_illustration.SuppressClearInGetMulti=false;
				_alreadyFetchedIllustration = true;
			}
			return _illustration;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Illustration'. These settings will be taken into account
		/// when the property Illustration is requested or GetMultiIllustration is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersIllustration(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_illustration.SortClauses=sortClauses;
			_illustration.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'CultureEntity'</returns>
		public virtual CultureCollection GetMultiCulture(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCulture || forceFetch || _alwaysFetchCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_culture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_culture);
					}
				}
				_culture.SuppressClearInGetMulti=!forceFetch;
				_culture.GetMultiManyToManyUsingProductModel(this);
				_culture.SuppressClearInGetMulti=false;
				_alreadyFetchedCulture = true;
			}
			return _culture;
		}


		/// <summary>
		/// Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual CultureCollection GetMultiCulture(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedCulture || forceFetch || _alwaysFetchCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_culture.ParticipatesInTransaction)
					{
						base.Transaction.Add(_culture);
					}
				}
				_culture.SuppressClearInGetMulti=!forceFetch;
				_culture.EntityFactoryToUse = entityFactoryToUse;
				_culture.GetMultiManyToManyUsingProductModel(this);
				_culture.SuppressClearInGetMulti=false;
				_alreadyFetchedCulture = true;
			}
			return _culture;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Culture'. These settings will be taken into account
		/// when the property Culture is requested or GetMultiCulture is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersCulture(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_culture.SortClauses=sortClauses;
			_culture.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDescriptionEntity'</returns>
		public virtual ProductDescriptionCollection GetMultiProductDescription(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductDescription || forceFetch || _alwaysFetchProductDescription) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDescription.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDescription);
					}
				}
				_productDescription.SuppressClearInGetMulti=!forceFetch;
				_productDescription.GetMultiManyToManyUsingProductModel(this);
				_productDescription.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDescription = true;
			}
			return _productDescription;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductDescriptionCollection GetMultiProductDescription(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductDescription || forceFetch || _alwaysFetchProductDescription) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDescription.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDescription);
					}
				}
				_productDescription.SuppressClearInGetMulti=!forceFetch;
				_productDescription.EntityFactoryToUse = entityFactoryToUse;
				_productDescription.GetMultiManyToManyUsingProductModel(this);
				_productDescription.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDescription = true;
			}
			return _productDescription;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductDescription'. These settings will be taken into account
		/// when the property ProductDescription is requested or GetMultiProductDescription is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDescription(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDescription.SortClauses=sortClauses;
			_productDescription.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ProductModelIDChanged event, which is thrown when ProductModelID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductModelIDChanged()
		{
			if(ProductModelIDChanged!=null)
			{
				ProductModelIDChanged(this, new EventArgs());
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
		/// Event thrower for the CatalogDescriptionChanged event, which is thrown when CatalogDescription changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCatalogDescriptionChanged()
		{
			if(CatalogDescriptionChanged!=null)
			{
				CatalogDescriptionChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the InstructionsChanged event, which is thrown when Instructions changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnInstructionsChanged()
		{
			if(InstructionsChanged!=null)
			{
				InstructionsChanged(this, new EventArgs());
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
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();
			return dao.AddProductModel(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();
			return dao.UpdateProductModel(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();
			return dao.UpdateProductModel(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductModelEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ProductModelValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductModelEntity</param>
		private void InitClassFetch(System.Int32 productModelID, ProductModelValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductModelEntity);
			bool wasSuccesful = Fetch(productModelID);
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
			_product.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;
			_productModelIllustration = new ProductModelIllustrationCollection(propertyDescriptorFactoryToUse, new ProductModelIllustrationEntityFactory());
			_productModelIllustration.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProductModelIllustration = false;
			_alreadyFetchedProductModelIllustration = false;
			_productModelProductDescriptionCulture = new ProductModelProductDescriptionCultureCollection(propertyDescriptorFactoryToUse, new ProductModelProductDescriptionCultureEntityFactory());
			_productModelProductDescriptionCulture.SetContainingEntityInfo(this, "ProductModel");
			_alwaysFetchProductModelProductDescriptionCulture = false;
			_alreadyFetchedProductModelProductDescriptionCulture = false;
			_productSubcategory = new ProductSubcategoryCollection(propertyDescriptorFactoryToUse, new ProductSubcategoryEntityFactory());
			_alwaysFetchProductSubcategory = false;
			_alreadyFetchedProductSubcategory = false;
			_unitMeasure = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
			_unitMeasure_ = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure_ = false;
			_alreadyFetchedUnitMeasure_ = false;
			_illustration = new IllustrationCollection(propertyDescriptorFactoryToUse, new IllustrationEntityFactory());
			_alwaysFetchIllustration = false;
			_alreadyFetchedIllustration = false;
			_culture = new CultureCollection(propertyDescriptorFactoryToUse, new CultureEntityFactory());
			_alwaysFetchCulture = false;
			_alreadyFetchedCulture = false;
			_productDescription = new ProductDescriptionCollection(propertyDescriptorFactoryToUse, new ProductDescriptionEntityFactory());
			_alwaysFetchProductDescription = false;
			_alreadyFetchedProductDescription = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="productModelID">PK value for ProductModel which data should be fetched into this ProductModel object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productModelID)
		{
			ProductModelDAO dao = DAOFactory.CreateProductModelDAO();

			// Load EntityFields of ProductModel
			dao.FetchProductModel(base.Fields, base.Transaction, productModelID);

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
		public static ProductModelRelations Relations
		{
			get	{ return new ProductModelRelations(); }
		}

	
		/// <summary>
		/// The ProductModelID property of the Entity ProductModel
		/// </summary>
		public virtual System.Int32 ProductModelID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.ProductModelID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductModelID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.ProductModelID, value))
				{
					OnProductModelIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity ProductModel
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The CatalogDescription property of the Entity ProductModel
		/// </summary>
		public virtual System.String CatalogDescription
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.CatalogDescription);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CatalogDescription because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.CatalogDescription, value))
				{
					OnCatalogDescriptionChanged();
				}
			}
		}
	
		/// <summary>
		/// The Instructions property of the Entity ProductModel
		/// </summary>
		public virtual System.String Instructions
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.Instructions);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Instructions because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.Instructions, value))
				{
					OnInstructionsChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity ProductModel
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ProductModel
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelFieldIndex.ModifiedDate, value))
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
		/// Retrieves all related entities of type 'ProductModelIllustrationEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductModelIllustrationCollection ProductModelIllustration
		{
			get
			{
				return GetMultiProductModelIllustration(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductModelIllustration. When set to true, ProductModelIllustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelIllustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelIllustration(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelIllustration
		{
			get
			{
				return _alwaysFetchProductModelIllustration;
			}
			set
			{
				_alwaysFetchProductModelIllustration = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductModelProductDescriptionCultureEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductModelProductDescriptionCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductModelProductDescriptionCultureCollection ProductModelProductDescriptionCulture
		{
			get
			{
				return GetMultiProductModelProductDescriptionCulture(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductModelProductDescriptionCulture. When set to true, ProductModelProductDescriptionCulture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModelProductDescriptionCulture is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductModelProductDescriptionCulture(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductModelProductDescriptionCulture
		{
			get
			{
				return _alwaysFetchProductModelProductDescriptionCulture;
			}
			set
			{
				_alwaysFetchProductModelProductDescriptionCulture = value;
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
		/// Retrieves all related entities of type 'IllustrationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiIllustration()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual IllustrationCollection Illustration
		{
			get
			{
				return GetMultiIllustration(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Illustration. When set to true, Illustration is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Illustration is accessed. You can always execute
		/// a forced fetch by calling GetMultiIllustration(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchIllustration
		{
			get
			{
				return _alwaysFetchIllustration;
			}
			set
			{
				_alwaysFetchIllustration = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'CultureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual CultureCollection Culture
		{
			get
			{
				return GetMultiCulture(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Culture. When set to true, Culture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Culture is accessed. You can always execute
		/// a forced fetch by calling GetMultiCulture(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchCulture
		{
			get
			{
				return _alwaysFetchCulture;
			}
			set
			{
				_alwaysFetchCulture = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductDescriptionEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDescription()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductDescriptionCollection ProductDescription
		{
			get
			{
				return GetMultiProductDescription(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductDescription. When set to true, ProductDescription is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDescription is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDescription(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDescription
		{
			get
			{
				return _alwaysFetchProductDescription;
			}
			set
			{
				_alwaysFetchProductDescription = value;
			}	
		}
	
	
	
		#endregion
	}
}
