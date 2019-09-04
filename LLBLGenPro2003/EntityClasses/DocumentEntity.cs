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
	/// Entity class which represents the entity 'Document' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class DocumentEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private ProductDocumentCollection	_productDocument;
		private bool	_alwaysFetchProductDocument, _alreadyFetchedProductDocument;
		private ProductCollection _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when DocumentID changes value. Databinding related.
		/// </summary>
		public event EventHandler DocumentIDChanged;

		/// <summary>
		/// Event which is thrown when Title changes value. Databinding related.
		/// </summary>
		public event EventHandler TitleChanged;

		/// <summary>
		/// Event which is thrown when FileName changes value. Databinding related.
		/// </summary>
		public event EventHandler FileNameChanged;

		/// <summary>
		/// Event which is thrown when FileExtension changes value. Databinding related.
		/// </summary>
		public event EventHandler FileExtensionChanged;

		/// <summary>
		/// Event which is thrown when Revision changes value. Databinding related.
		/// </summary>
		public event EventHandler RevisionChanged;

		/// <summary>
		/// Event which is thrown when ChangeNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler ChangeNumberChanged;

		/// <summary>
		/// Event which is thrown when Status changes value. Databinding related.
		/// </summary>
		public event EventHandler StatusChanged;

		/// <summary>
		/// Event which is thrown when DocumentSummary changes value. Databinding related.
		/// </summary>
		public event EventHandler DocumentSummaryChanged;

		/// <summary>
		/// Event which is thrown when Document changes value. Databinding related.
		/// </summary>
		public event EventHandler DocumentChanged;

		/// <summary>
		/// Event which is thrown when ModifiedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler ModifiedDateChanged;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public DocumentEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new DocumentEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		public DocumentEntity(System.Int32 documentID)
		{
			InitClassFetch(documentID, new DocumentValidator(), new PropertyDescriptorFactory(), new DocumentEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="validator">The custom validator object for this DocumentEntity</param>
		public DocumentEntity(System.Int32 documentID, DocumentValidator validator)
		{
			InitClassFetch(documentID, validator, new PropertyDescriptorFactory(), new DocumentEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="validator">The custom validator object for this DocumentEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public DocumentEntity(System.Int32 documentID, DocumentValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(documentID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public DocumentEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private DocumentEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_productDocument = (ProductDocumentCollection)info.GetValue("_productDocument", typeof(ProductDocumentCollection));
			_alwaysFetchProductDocument = info.GetBoolean("_alwaysFetchProductDocument");
			_alreadyFetchedProductDocument = info.GetBoolean("_alreadyFetchedProductDocument");

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
			_alreadyFetchedProductDocument = (_productDocument.Count > 0);
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
			info.AddValue("_productDocument", _productDocument);
			info.AddValue("_alwaysFetchProductDocument", _alwaysFetchProductDocument);
			info.AddValue("_alreadyFetchedProductDocument", _alreadyFetchedProductDocument);
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

				case "ProductDocument":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productDocument.Add(relatedEntity);
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

				case "ProductDocument":
					// Remove it from the collection.
					_productDocument.Remove(relatedEntity);
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

			toReturn.Add(_productDocument);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("DocumentEntity");
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
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 documentID)
		{
			return Fetch(documentID);
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
			return Fetch(this.DocumentID);
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
			DocumentDAO dao = DAOFactory.CreateDocumentDAO();
			bool wasSuccesful = dao.DeleteDocument(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(DocumentFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public virtual ProductDocumentCollection GetMultiProductDocument(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				_productDocument.GetMultiManyToOne(this, null);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductDocumentEntity'</returns>
		public virtual ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				_productDocument.GetMultiManyToOne(this, null, filter);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				_productDocument.EntityFactoryToUse = entityFactoryToUse;
				_productDocument.GetMultiManyToOne(this, null);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductDocumentCollection GetMultiProductDocument(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductDocument || forceFetch || _alwaysFetchProductDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productDocument.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productDocument);
					}
				}
				_productDocument.SuppressClearInGetMulti=!forceFetch;
				_productDocument.EntityFactoryToUse = entityFactoryToUse;
				_productDocument.GetMultiManyToOne(this, null, filter);
				_productDocument.SuppressClearInGetMulti=false;
				_alreadyFetchedProductDocument = true;
			}
			return _productDocument;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductDocument'. These settings will be taken into account
		/// when the property ProductDocument is requested or GetMultiProductDocument is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productDocument.SortClauses=sortClauses;
			_productDocument.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_product.GetMultiManyToManyUsingDocument(this);
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
				_product.GetMultiManyToManyUsingDocument(this);
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
		/// Event thrower for the DocumentIDChanged event, which is thrown when DocumentID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDocumentIDChanged()
		{
			if(DocumentIDChanged!=null)
			{
				DocumentIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TitleChanged event, which is thrown when Title changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTitleChanged()
		{
			if(TitleChanged!=null)
			{
				TitleChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FileNameChanged event, which is thrown when FileName changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFileNameChanged()
		{
			if(FileNameChanged!=null)
			{
				FileNameChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FileExtensionChanged event, which is thrown when FileExtension changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFileExtensionChanged()
		{
			if(FileExtensionChanged!=null)
			{
				FileExtensionChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the RevisionChanged event, which is thrown when Revision changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnRevisionChanged()
		{
			if(RevisionChanged!=null)
			{
				RevisionChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ChangeNumberChanged event, which is thrown when ChangeNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnChangeNumberChanged()
		{
			if(ChangeNumberChanged!=null)
			{
				ChangeNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StatusChanged event, which is thrown when Status changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStatusChanged()
		{
			if(StatusChanged!=null)
			{
				StatusChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DocumentSummaryChanged event, which is thrown when DocumentSummary changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDocumentSummaryChanged()
		{
			if(DocumentSummaryChanged!=null)
			{
				DocumentSummaryChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DocumentChanged event, which is thrown when Document changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDocumentChanged()
		{
			if(DocumentChanged!=null)
			{
				DocumentChanged(this, new EventArgs());
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
			DocumentDAO dao = DAOFactory.CreateDocumentDAO();
			return dao.AddDocument(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			DocumentDAO dao = DAOFactory.CreateDocumentDAO();
			return dao.UpdateDocument(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			DocumentDAO dao = DAOFactory.CreateDocumentDAO();
			return dao.UpdateDocument(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.DocumentEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new DocumentValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this DocumentEntity</param>
		private void InitClassFetch(System.Int32 documentID, DocumentValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.DocumentEntity);
			bool wasSuccesful = Fetch(documentID);
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
			_productDocument = new ProductDocumentCollection(propertyDescriptorFactoryToUse, new ProductDocumentEntityFactory());
			_productDocument.SetContainingEntityInfo(this, "Document");
			_alwaysFetchProductDocument = false;
			_alreadyFetchedProductDocument = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="documentID">PK value for Document which data should be fetched into this Document object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 documentID)
		{
			DocumentDAO dao = DAOFactory.CreateDocumentDAO();

			// Load EntityFields of Document
			dao.FetchDocument(base.Fields, base.Transaction, documentID);

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
		public static DocumentRelations Relations
		{
			get	{ return new DocumentRelations(); }
		}

	
		/// <summary>
		/// The DocumentID property of the Entity Document
		/// </summary>
		public virtual System.Int32 DocumentID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.DocumentID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DocumentID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.DocumentID, value))
				{
					OnDocumentIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Title property of the Entity Document
		/// </summary>
		public virtual System.String Title
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.Title);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Title because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.Title, value))
				{
					OnTitleChanged();
				}
			}
		}
	
		/// <summary>
		/// The FileName property of the Entity Document
		/// </summary>
		public virtual System.String FileName
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.FileName);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FileName because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.FileName, value))
				{
					OnFileNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The FileExtension property of the Entity Document
		/// </summary>
		public virtual System.String FileExtension
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.FileExtension);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FileExtension because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.FileExtension, value))
				{
					OnFileExtensionChanged();
				}
			}
		}
	
		/// <summary>
		/// The Revision property of the Entity Document
		/// </summary>
		public virtual System.String Revision
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.Revision);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Revision because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.Revision, value))
				{
					OnRevisionChanged();
				}
			}
		}
	
		/// <summary>
		/// The ChangeNumber property of the Entity Document
		/// </summary>
		public virtual System.Int32 ChangeNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.ChangeNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ChangeNumber because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.ChangeNumber, value))
				{
					OnChangeNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The Status property of the Entity Document
		/// </summary>
		public virtual System.Byte Status
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.Status);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Status because it is set to NULL.");
				}
				return (System.Byte)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.Status, value))
				{
					OnStatusChanged();
				}
			}
		}
	
		/// <summary>
		/// The DocumentSummary property of the Entity Document
		/// </summary>
		public virtual System.String DocumentSummary
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.DocumentSummary);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DocumentSummary because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.DocumentSummary, value))
				{
					OnDocumentSummaryChanged();
				}
			}
		}
	
		/// <summary>
		/// The Document property of the Entity Document
		/// </summary>
		public virtual System.Byte[] Document
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.Document);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Document because it is set to NULL.");
				}
				return (System.Byte[])valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.Document, value))
				{
					OnDocumentChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Document
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)DocumentFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)DocumentFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductDocumentEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductDocumentCollection ProductDocument
		{
			get
			{
				return GetMultiProductDocument(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductDocument. When set to true, ProductDocument is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductDocument is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductDocument(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductDocument
		{
			get
			{
				return _alwaysFetchProductDocument;
			}
			set
			{
				_alwaysFetchProductDocument = value;
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
