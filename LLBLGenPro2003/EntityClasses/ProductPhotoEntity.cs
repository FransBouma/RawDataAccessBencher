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
	/// Entity class which represents the entity 'ProductPhoto' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ProductPhotoEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private ProductProductPhotoCollection	_productProductPhoto;
		private bool	_alwaysFetchProductProductPhoto, _alreadyFetchedProductProductPhoto;
		private ProductCollection _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ProductPhotoID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductPhotoIDChanged;

		/// <summary>
		/// Event which is thrown when ThumbNailPhoto changes value. Databinding related.
		/// </summary>
		public event EventHandler ThumbNailPhotoChanged;

		/// <summary>
		/// Event which is thrown when ThumbnailPhotoFileName changes value. Databinding related.
		/// </summary>
		public event EventHandler ThumbnailPhotoFileNameChanged;

		/// <summary>
		/// Event which is thrown when LargePhoto changes value. Databinding related.
		/// </summary>
		public event EventHandler LargePhotoChanged;

		/// <summary>
		/// Event which is thrown when LargePhotoFileName changes value. Databinding related.
		/// </summary>
		public event EventHandler LargePhotoFileNameChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ProductPhotoEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ProductPhotoEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		public ProductPhotoEntity(System.Int32 productPhotoID)
		{
			InitClassFetch(productPhotoID, new ProductPhotoValidator(), new PropertyDescriptorFactory(), new ProductPhotoEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="validator">The custom validator object for this ProductPhotoEntity</param>
		public ProductPhotoEntity(System.Int32 productPhotoID, ProductPhotoValidator validator)
		{
			InitClassFetch(productPhotoID, validator, new PropertyDescriptorFactory(), new ProductPhotoEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="validator">The custom validator object for this ProductPhotoEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductPhotoEntity(System.Int32 productPhotoID, ProductPhotoValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productPhotoID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductPhotoEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductPhotoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_productProductPhoto = (ProductProductPhotoCollection)info.GetValue("_productProductPhoto", typeof(ProductProductPhotoCollection));
			_alwaysFetchProductProductPhoto = info.GetBoolean("_alwaysFetchProductProductPhoto");
			_alreadyFetchedProductProductPhoto = info.GetBoolean("_alreadyFetchedProductProductPhoto");

			_product = (ProductCollection)info.GetValue("_product", typeof(ProductCollection));
			_alwaysFetchProduct = info.GetBoolean("_alwaysFetchProduct");
			_alreadyFetchedProduct = info.GetBoolean("_alreadyFetchedProduct");


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
			_alreadyFetchedProductProductPhoto = (_productProductPhoto.Count > 0);
			_alreadyFetchedProduct = (_product.Count > 0);


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
			info.AddValue("_productProductPhoto", _productProductPhoto);
			info.AddValue("_alwaysFetchProductProductPhoto", _alwaysFetchProductProductPhoto);
			info.AddValue("_alreadyFetchedProductProductPhoto", _alreadyFetchedProductProductPhoto);
			info.AddValue("_product", _product);
			info.AddValue("_alwaysFetchProduct", _alwaysFetchProduct);
			info.AddValue("_alreadyFetchedProduct", _alreadyFetchedProduct);


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

				case "ProductProductPhoto":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productProductPhoto.Add(relatedEntity);
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

				case "ProductProductPhoto":
					// Remove it from the collection.
					_productProductPhoto.Remove(relatedEntity);
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

			toReturn.Add(_productProductPhoto);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("ProductPhotoEntity");
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
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productPhotoID)
		{
			return Fetch(productPhotoID);
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
			return Fetch(this.ProductPhotoID);
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
			ProductPhotoDAO dao = DAOFactory.CreateProductPhotoDAO();
			bool wasSuccesful = dao.DeleteProductPhoto(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ProductPhotoFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public virtual ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				_productProductPhoto.GetMultiManyToOne(null, this);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductProductPhotoEntity'</returns>
		public virtual ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				_productProductPhoto.GetMultiManyToOne(null, this, filter);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				_productProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				_productProductPhoto.GetMultiManyToOne(null, this);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductProductPhotoCollection GetMultiProductProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductProductPhoto || forceFetch || _alwaysFetchProductProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productProductPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productProductPhoto);
					}
				}
				_productProductPhoto.SuppressClearInGetMulti=!forceFetch;
				_productProductPhoto.EntityFactoryToUse = entityFactoryToUse;
				_productProductPhoto.GetMultiManyToOne(null, this, filter);
				_productProductPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductProductPhoto = true;
			}
			return _productProductPhoto;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductProductPhoto'. These settings will be taken into account
		/// when the property ProductProductPhoto is requested or GetMultiProductProductPhoto is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productProductPhoto.SortClauses=sortClauses;
			_productProductPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_product.GetMultiManyToManyUsingProductPhoto(this);
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
				_product.GetMultiManyToManyUsingProductPhoto(this);
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

	
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ProductPhotoIDChanged event, which is thrown when ProductPhotoID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductPhotoIDChanged()
		{
			if(ProductPhotoIDChanged!=null)
			{
				ProductPhotoIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ThumbNailPhotoChanged event, which is thrown when ThumbNailPhoto changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnThumbNailPhotoChanged()
		{
			if(ThumbNailPhotoChanged!=null)
			{
				ThumbNailPhotoChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ThumbnailPhotoFileNameChanged event, which is thrown when ThumbnailPhotoFileName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnThumbnailPhotoFileNameChanged()
		{
			if(ThumbnailPhotoFileNameChanged!=null)
			{
				ThumbnailPhotoFileNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the LargePhotoChanged event, which is thrown when LargePhoto changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnLargePhotoChanged()
		{
			if(LargePhotoChanged!=null)
			{
				LargePhotoChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the LargePhotoFileNameChanged event, which is thrown when LargePhotoFileName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnLargePhotoFileNameChanged()
		{
			if(LargePhotoFileNameChanged!=null)
			{
				LargePhotoFileNameChanged(this, new EventArgs());
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
			ProductPhotoDAO dao = DAOFactory.CreateProductPhotoDAO();
			return dao.AddProductPhoto(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductPhotoDAO dao = DAOFactory.CreateProductPhotoDAO();
			return dao.UpdateProductPhoto(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductPhotoDAO dao = DAOFactory.CreateProductPhotoDAO();
			return dao.UpdateProductPhoto(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductPhotoEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ProductPhotoValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductPhotoEntity</param>
		private void InitClassFetch(System.Int32 productPhotoID, ProductPhotoValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductPhotoEntity);
			bool wasSuccesful = Fetch(productPhotoID);
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
			_productProductPhoto = new ProductProductPhotoCollection(propertyDescriptorFactoryToUse, new ProductProductPhotoEntityFactory());
			_productProductPhoto.SetContainingEntityInfo(this, "ProductPhoto");
			_alwaysFetchProductProductPhoto = false;
			_alreadyFetchedProductProductPhoto = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="productPhotoID">PK value for ProductPhoto which data should be fetched into this ProductPhoto object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productPhotoID)
		{
			ProductPhotoDAO dao = DAOFactory.CreateProductPhotoDAO();

			// Load EntityFields of ProductPhoto
			dao.FetchProductPhoto(base.Fields, base.Transaction, productPhotoID);

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
		public static ProductPhotoRelations Relations
		{
			get	{ return new ProductPhotoRelations(); }
		}

	
		/// <summary>
		/// The ProductPhotoID property of the Entity ProductPhoto
		/// </summary>
		public virtual System.Int32 ProductPhotoID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.ProductPhotoID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductPhotoID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.ProductPhotoID, value))
				{
					OnProductPhotoIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ThumbNailPhoto property of the Entity ProductPhoto
		/// </summary>
		public virtual System.Byte[] ThumbNailPhoto
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.ThumbNailPhoto);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ThumbNailPhoto because it is set to NULL.");
				}
				return (System.Byte[])valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.ThumbNailPhoto, value))
				{
					OnThumbNailPhotoChanged();
				}
			}
		}
	
		/// <summary>
		/// The ThumbnailPhotoFileName property of the Entity ProductPhoto
		/// </summary>
		public virtual System.String ThumbnailPhotoFileName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ThumbnailPhotoFileName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.ThumbnailPhotoFileName, value))
				{
					OnThumbnailPhotoFileNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The LargePhoto property of the Entity ProductPhoto
		/// </summary>
		public virtual System.Byte[] LargePhoto
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.LargePhoto);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for LargePhoto because it is set to NULL.");
				}
				return (System.Byte[])valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.LargePhoto, value))
				{
					OnLargePhotoChanged();
				}
			}
		}
	
		/// <summary>
		/// The LargePhotoFileName property of the Entity ProductPhoto
		/// </summary>
		public virtual System.String LargePhotoFileName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.LargePhotoFileName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for LargePhotoFileName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.LargePhotoFileName, value))
				{
					OnLargePhotoFileNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ProductPhoto
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductPhotoFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductPhotoFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductProductPhotoEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductProductPhotoCollection ProductProductPhoto
		{
			get
			{
				return GetMultiProductProductPhoto(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductProductPhoto. When set to true, ProductProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductProductPhoto(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductProductPhoto
		{
			get
			{
				return _alwaysFetchProductProductPhoto;
			}
			set
			{
				_alwaysFetchProductProductPhoto = value;
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
	
	
	
		#endregion
	}
}
