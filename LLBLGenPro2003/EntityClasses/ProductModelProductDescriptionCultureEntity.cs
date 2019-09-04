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
	/// Entity class which represents the entity 'ProductModelProductDescriptionCulture' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ProductModelProductDescriptionCultureEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations


		private CultureEntity _culture;
		private bool	_alwaysFetchCulture, _alreadyFetchedCulture;
		private ProductDescriptionEntity _productDescription;
		private bool	_alwaysFetchProductDescription, _alreadyFetchedProductDescription;
		private ProductModelEntity _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ProductModelID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductModelIDChanged;

		/// <summary>
		/// Event which is thrown when ProductDescriptionID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductDescriptionIDChanged;

		/// <summary>
		/// Event which is thrown when CultureID changes value. Databinding related.
		/// </summary>
		public event EventHandler CultureIDChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public ProductModelProductDescriptionCultureEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ProductModelProductDescriptionCultureEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		public ProductModelProductDescriptionCultureEntity(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, new ProductModelProductDescriptionCultureValidator(), new PropertyDescriptorFactory(), new ProductModelProductDescriptionCultureEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		public ProductModelProductDescriptionCultureEntity(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, ProductModelProductDescriptionCultureValidator validator)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, validator, new PropertyDescriptorFactory(), new ProductModelProductDescriptionCultureEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="validator">The custom validator object for this ProductModelProductDescriptionCultureEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductModelProductDescriptionCultureEntity(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, ProductModelProductDescriptionCultureValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productModelID, productDescriptionID, cultureID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductModelProductDescriptionCultureEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductModelProductDescriptionCultureEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{


			_culture = (CultureEntity)info.GetValue("_culture", typeof(CultureEntity));
			if(_culture!=null)
			{
				// rewire event handler.
				_culture.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchCulture = info.GetBoolean("_alwaysFetchCulture");
			_alreadyFetchedCulture = info.GetBoolean("_alreadyFetchedCulture");
			_productDescription = (ProductDescriptionEntity)info.GetValue("_productDescription", typeof(ProductDescriptionEntity));
			if(_productDescription!=null)
			{
				// rewire event handler.
				_productDescription.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProductDescription = info.GetBoolean("_alwaysFetchProductDescription");
			_alreadyFetchedProductDescription = info.GetBoolean("_alreadyFetchedProductDescription");
			_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
			if(_productModel!=null)
			{
				// rewire event handler.
				_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");

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


			_alreadyFetchedCulture = (_culture != null);
			_alreadyFetchedProductDescription = (_productDescription != null);
			_alreadyFetchedProductModel = (_productModel != null);

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


			info.AddValue("_culture", _culture);
			info.AddValue("_alwaysFetchCulture", _alwaysFetchCulture);
			info.AddValue("_alreadyFetchedCulture", _alreadyFetchedCulture);
			info.AddValue("_productDescription", _productDescription);
			info.AddValue("_alwaysFetchProductDescription", _alwaysFetchProductDescription);
			info.AddValue("_alreadyFetchedProductDescription", _alreadyFetchedProductDescription);
			info.AddValue("_productModel", _productModel);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);

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
				case "Culture":
					SetupSyncCulture(relatedEntity);
					break;
				case "ProductDescription":
					SetupSyncProductDescription(relatedEntity);
					break;
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
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
				case "Culture":
					DesetupSyncCulture(false);
					break;
				case "ProductDescription":
					DesetupSyncProductDescription(false);
					break;
				case "ProductModel":
					DesetupSyncProductModel(false);
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
			if(_culture!=null)
			{
				toReturn.Add(_culture);
			}
			if(_productDescription!=null)
			{
				toReturn.Add(_productDescription);
			}
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
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
			return base.ToXml("ProductModelProductDescriptionCultureEntity");
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
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID)
		{
			return Fetch(productModelID, productDescriptionID, cultureID);
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
			return Fetch(this.ProductModelID, this.ProductDescriptionID, this.CultureID);
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
			ProductModelProductDescriptionCultureDAO dao = DAOFactory.CreateProductModelProductDescriptionCultureDAO();
			bool wasSuccesful = dao.DeleteProductModelProductDescriptionCulture(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ProductModelProductDescriptionCultureFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
	
	
		/// <summary>
		/// Retrieves the related entity of type 'CultureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'CultureEntity' which is related to this entity.</returns>
		public virtual CultureEntity GetSingleCulture()
		{
			return GetSingleCulture(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'CultureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'CultureEntity' which is related to this entity.</returns>
		public virtual CultureEntity GetSingleCulture(bool forceFetch)
		{
 			if( ( !_alreadyFetchedCulture || forceFetch || _alwaysFetchCulture) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				CultureEntity newEntity = new CultureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.CultureID);
				this.Culture = newEntity;

				_alreadyFetchedCulture = true;
			}
			return _culture;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductDescriptionEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductDescriptionEntity' which is related to this entity.</returns>
		public virtual ProductDescriptionEntity GetSingleProductDescription()
		{
			return GetSingleProductDescription(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductDescriptionEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductDescriptionEntity' which is related to this entity.</returns>
		public virtual ProductDescriptionEntity GetSingleProductDescription(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductDescription || forceFetch || _alwaysFetchProductDescription) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductDescriptionEntity newEntity = new ProductDescriptionEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductDescriptionID);
				this.ProductDescription = newEntity;

				_alreadyFetchedProductDescription = true;
			}
			return _productDescription;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public virtual ProductModelEntity GetSingleProductModel()
		{
			return GetSingleProductModel(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductModelEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductModelEntity' which is related to this entity.</returns>
		public virtual ProductModelEntity GetSingleProductModel(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductModel || forceFetch || _alwaysFetchProductModel) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductModelEntity newEntity = new ProductModelEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductModelID);
				this.ProductModel = newEntity;

				_alreadyFetchedProductModel = true;
			}
			return _productModel;
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
		/// Event thrower for the ProductDescriptionIDChanged event, which is thrown when ProductDescriptionID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductDescriptionIDChanged()
		{
			if(ProductDescriptionIDChanged!=null)
			{
				ProductDescriptionIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CultureIDChanged event, which is thrown when CultureID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCultureIDChanged()
		{
			if(CultureIDChanged!=null)
			{
				CultureIDChanged(this, new EventArgs());
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
			ProductModelProductDescriptionCultureDAO dao = DAOFactory.CreateProductModelProductDescriptionCultureDAO();
			return dao.AddProductModelProductDescriptionCulture(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductModelProductDescriptionCultureDAO dao = DAOFactory.CreateProductModelProductDescriptionCultureDAO();
			return dao.UpdateProductModelProductDescriptionCulture(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductModelProductDescriptionCultureDAO dao = DAOFactory.CreateProductModelProductDescriptionCultureDAO();
			return dao.UpdateProductModelProductDescriptionCulture(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductModelProductDescriptionCultureEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ProductModelProductDescriptionCultureValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductModelProductDescriptionCultureEntity</param>
		private void InitClassFetch(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID, ProductModelProductDescriptionCultureValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductModelProductDescriptionCultureEntity);
			bool wasSuccesful = Fetch(productModelID, productDescriptionID, cultureID);
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


			_culture = null;
			_alwaysFetchCulture = false;
			_alreadyFetchedCulture = false;
			_productDescription = null;
			_alwaysFetchProductDescription = false;
			_alreadyFetchedProductDescription = false;
			_productModel = null;
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;

		}


		/// <summary>
		/// Removes the sync logic for member _culture
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncCulture(bool signalRelatedEntity)
		{
			if(_culture != null)
			{
				// disconnect the entity from this entity
				_culture.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_culture.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
				}
				base.UnsetEntitySyncInformation("Culture", _culture, ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID);
				_culture = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _culture
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncCulture(IEntity relatedEntity)
		{
			DesetupSyncCulture(true);
			
			if(relatedEntity!=null)
			{
				_culture = (CultureEntity)relatedEntity;
				_culture.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("Culture", _culture, ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID);
				if(!_culture.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductModelProductDescriptionCultureEntity.Relations.CultureEntityUsingCultureID, _culture);
				}
			}

			_alreadyFetchedCulture = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _productDescription
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductDescription(bool signalRelatedEntity)
		{
			if(_productDescription != null)
			{
				// disconnect the entity from this entity
				_productDescription.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_productDescription.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
				}
				base.UnsetEntitySyncInformation("ProductDescription", _productDescription, ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID);
				_productDescription = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _productDescription
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductDescription(IEntity relatedEntity)
		{
			DesetupSyncProductDescription(true);
			
			if(relatedEntity!=null)
			{
				_productDescription = (ProductDescriptionEntity)relatedEntity;
				_productDescription.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ProductDescription", _productDescription, ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID);
				if(!_productDescription.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductModelProductDescriptionCultureEntity.Relations.ProductDescriptionEntityUsingProductDescriptionID, _productDescription);
				}
			}

			_alreadyFetchedProductDescription = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _productModel
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductModel(bool signalRelatedEntity)
		{
			if(_productModel != null)
			{
				// disconnect the entity from this entity
				_productModel.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_productModel.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
				}
				base.UnsetEntitySyncInformation("ProductModel", _productModel, ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID);
				_productModel = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _productModel
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductModel(IEntity relatedEntity)
		{
			DesetupSyncProductModel(true);
			
			if(relatedEntity!=null)
			{
				_productModel = (ProductModelEntity)relatedEntity;
				_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ProductModel", _productModel, ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID);
				if(!_productModel.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductModelProductDescriptionCultureEntity.Relations.ProductModelEntityUsingProductModelID, _productModel);
				}
			}

			_alreadyFetchedProductModel = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="productModelID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="productDescriptionID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <param name="cultureID">PK value for ProductModelProductDescriptionCulture which data should be fetched into this ProductModelProductDescriptionCulture object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productModelID, System.Int32 productDescriptionID, System.String cultureID)
		{
			ProductModelProductDescriptionCultureDAO dao = DAOFactory.CreateProductModelProductDescriptionCultureDAO();

			// Load EntityFields of ProductModelProductDescriptionCulture
			dao.FetchProductModelProductDescriptionCulture(base.Fields, base.Transaction, productModelID, productDescriptionID, cultureID);

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
		public static ProductModelProductDescriptionCultureRelations Relations
		{
			get	{ return new ProductModelProductDescriptionCultureRelations(); }
		}

	
		/// <summary>
		/// The ProductModelID property of the Entity ProductModelProductDescriptionCulture
		/// </summary>
		public virtual System.Int32 ProductModelID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductModelID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductModelID, value))
				{
					OnProductModelIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductDescriptionID property of the Entity ProductModelProductDescriptionCulture
		/// </summary>
		public virtual System.Int32 ProductDescriptionID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductDescriptionID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID, value))
				{
					OnProductDescriptionIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The CultureID property of the Entity ProductModelProductDescriptionCulture
		/// </summary>
		public virtual System.String CultureID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for CultureID because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.CultureID, value))
				{
					OnCultureIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity ProductModelProductDescriptionCulture
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductModelProductDescriptionCultureFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
	
	
		/// <summary>
		/// Gets / sets related entity of type 'CultureEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleCulture()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual CultureEntity Culture
		{
			get
			{
				return GetSingleCulture(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncCulture(value);
				}
				else
				{
					if(value==null)
					{
						if(_culture != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_culture.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Culture. When set to true, Culture is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Culture is accessed. You can always execute
		/// a forced fetch by calling GetSingleCulture(true).
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
		/// Gets / sets related entity of type 'ProductDescriptionEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductDescription()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductDescriptionEntity ProductDescription
		{
			get
			{
				return GetSingleProductDescription(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductDescription(value);
				}
				else
				{
					if(value==null)
					{
						if(_productDescription != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_productDescription.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductDescription. When set to true, ProductDescription is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDescription is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductDescription(true).
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
	
		/// <summary>
		/// Gets / sets related entity of type 'ProductModelEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductModel()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductModelEntity ProductModel
		{
			get
			{
				return GetSingleProductModel(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductModel(value);
				}
				else
				{
					if(value==null)
					{
						if(_productModel != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_productModel.UnsetRelatedEntity(this, "ProductModelProductDescriptionCulture");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "ProductModelProductDescriptionCulture");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductModel. When set to true, ProductModel is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductModel is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductModel(true).
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
	
	
		#endregion
	}
}
