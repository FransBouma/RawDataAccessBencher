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
	/// Entity class which represents the entity 'SpecialOffer' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class SpecialOfferEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private SpecialOfferProductCollection	_specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct;
		private ProductCollection _product;
		private bool	_alwaysFetchProduct, _alreadyFetchedProduct;


		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when SpecialOfferID changes value. Databinding related.
		/// </summary>
		public event EventHandler SpecialOfferIDChanged;

		/// <summary>
		/// Event which is thrown when Description changes value. Databinding related.
		/// </summary>
		public event EventHandler DescriptionChanged;

		/// <summary>
		/// Event which is thrown when DiscountPct changes value. Databinding related.
		/// </summary>
		public event EventHandler DiscountPctChanged;

		/// <summary>
		/// Event which is thrown when Type changes value. Databinding related.
		/// </summary>
		public event EventHandler TypeChanged;

		/// <summary>
		/// Event which is thrown when Category changes value. Databinding related.
		/// </summary>
		public event EventHandler CategoryChanged;

		/// <summary>
		/// Event which is thrown when StartDate changes value. Databinding related.
		/// </summary>
		public event EventHandler StartDateChanged;

		/// <summary>
		/// Event which is thrown when EndDate changes value. Databinding related.
		/// </summary>
		public event EventHandler EndDateChanged;

		/// <summary>
		/// Event which is thrown when MinQty changes value. Databinding related.
		/// </summary>
		public event EventHandler MinQtyChanged;

		/// <summary>
		/// Event which is thrown when MaxQty changes value. Databinding related.
		/// </summary>
		public event EventHandler MaxQtyChanged;

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
		public SpecialOfferEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new SpecialOfferEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		public SpecialOfferEntity(System.Int32 specialOfferID)
		{
			InitClassFetch(specialOfferID, new SpecialOfferValidator(), new PropertyDescriptorFactory(), new SpecialOfferEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferEntity</param>
		public SpecialOfferEntity(System.Int32 specialOfferID, SpecialOfferValidator validator)
		{
			InitClassFetch(specialOfferID, validator, new PropertyDescriptorFactory(), new SpecialOfferEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="validator">The custom validator object for this SpecialOfferEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SpecialOfferEntity(System.Int32 specialOfferID, SpecialOfferValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(specialOfferID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public SpecialOfferEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private SpecialOfferEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_specialOfferProduct = (SpecialOfferProductCollection)info.GetValue("_specialOfferProduct", typeof(SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");

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
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct.Count > 0);
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
			info.AddValue("_specialOfferProduct", _specialOfferProduct);
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);
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

				case "SpecialOfferProduct":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_specialOfferProduct.Add(relatedEntity);
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

				case "SpecialOfferProduct":
					// Remove it from the collection.
					_specialOfferProduct.Remove(relatedEntity);
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

			toReturn.Add(_specialOfferProduct);
		
			return toReturn;
		}


		/// <summary>
		/// Create an xml representation of this entity class
		/// </summary>
		/// <returns></returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override System.Xml.XmlNode ToXml()
		{
			return base.ToXml("SpecialOfferEntity");
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
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 specialOfferID)
		{
			return Fetch(specialOfferID);
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
			return Fetch(this.SpecialOfferID);
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
			SpecialOfferDAO dao = DAOFactory.CreateSpecialOfferDAO();
			bool wasSuccesful = dao.DeleteSpecialOffer(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(SpecialOfferFieldIndex fieldIndex)
		{
			return base.Fields[(int)fieldIndex].IsNull;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.GetMultiManyToOne(null, this);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferProductEntity'</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.GetMultiManyToOne(null, this, filter);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				_specialOfferProduct.GetMultiManyToOne(null, this);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SpecialOfferProductCollection GetMultiSpecialOfferProduct(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedSpecialOfferProduct || forceFetch || _alwaysFetchSpecialOfferProduct) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOfferProduct.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOfferProduct);
					}
				}
				_specialOfferProduct.SuppressClearInGetMulti=!forceFetch;
				_specialOfferProduct.EntityFactoryToUse = entityFactoryToUse;
				_specialOfferProduct.GetMultiManyToOne(null, this, filter);
				_specialOfferProduct.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOfferProduct = true;
			}
			return _specialOfferProduct;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SpecialOfferProduct'. These settings will be taken into account
		/// when the property SpecialOfferProduct is requested or GetMultiSpecialOfferProduct is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOfferProduct(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOfferProduct.SortClauses=sortClauses;
			_specialOfferProduct.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_product.GetMultiManyToManyUsingSpecialOffer(this);
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
				_product.GetMultiManyToManyUsingSpecialOffer(this);
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
		/// Event thrower for the SpecialOfferIDChanged event, which is thrown when SpecialOfferID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSpecialOfferIDChanged()
		{
			if(SpecialOfferIDChanged!=null)
			{
				SpecialOfferIDChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DescriptionChanged event, which is thrown when Description changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDescriptionChanged()
		{
			if(DescriptionChanged!=null)
			{
				DescriptionChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DiscountPctChanged event, which is thrown when DiscountPct changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDiscountPctChanged()
		{
			if(DiscountPctChanged!=null)
			{
				DiscountPctChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the TypeChanged event, which is thrown when Type changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnTypeChanged()
		{
			if(TypeChanged!=null)
			{
				TypeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the CategoryChanged event, which is thrown when Category changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnCategoryChanged()
		{
			if(CategoryChanged!=null)
			{
				CategoryChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StartDateChanged event, which is thrown when StartDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStartDateChanged()
		{
			if(StartDateChanged!=null)
			{
				StartDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the EndDateChanged event, which is thrown when EndDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnEndDateChanged()
		{
			if(EndDateChanged!=null)
			{
				EndDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the MinQtyChanged event, which is thrown when MinQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnMinQtyChanged()
		{
			if(MinQtyChanged!=null)
			{
				MinQtyChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the MaxQtyChanged event, which is thrown when MaxQty changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnMaxQtyChanged()
		{
			if(MaxQtyChanged!=null)
			{
				MaxQtyChanged(this, new EventArgs());
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
			SpecialOfferDAO dao = DAOFactory.CreateSpecialOfferDAO();
			return dao.AddSpecialOffer(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			SpecialOfferDAO dao = DAOFactory.CreateSpecialOfferDAO();
			return dao.UpdateSpecialOffer(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			SpecialOfferDAO dao = DAOFactory.CreateSpecialOfferDAO();
			return dao.UpdateSpecialOffer(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SpecialOfferEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new SpecialOfferValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this SpecialOfferEntity</param>
		private void InitClassFetch(System.Int32 specialOfferID, SpecialOfferValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.SpecialOfferEntity);
			bool wasSuccesful = Fetch(specialOfferID);
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
			_specialOfferProduct = new SpecialOfferProductCollection(propertyDescriptorFactoryToUse, new SpecialOfferProductEntityFactory());
			_specialOfferProduct.SetContainingEntityInfo(this, "SpecialOffer");
			_alwaysFetchSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferProduct = false;
			_product = new ProductCollection(propertyDescriptorFactoryToUse, new ProductEntityFactory());
			_alwaysFetchProduct = false;
			_alreadyFetchedProduct = false;


		}




	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="specialOfferID">PK value for SpecialOffer which data should be fetched into this SpecialOffer object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 specialOfferID)
		{
			SpecialOfferDAO dao = DAOFactory.CreateSpecialOfferDAO();

			// Load EntityFields of SpecialOffer
			dao.FetchSpecialOffer(base.Fields, base.Transaction, specialOfferID);

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
		public static SpecialOfferRelations Relations
		{
			get	{ return new SpecialOfferRelations(); }
		}

	
		/// <summary>
		/// The SpecialOfferID property of the Entity SpecialOffer
		/// </summary>
		public virtual System.Int32 SpecialOfferID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.SpecialOfferID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SpecialOfferID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.SpecialOfferID, value))
				{
					OnSpecialOfferIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Description property of the Entity SpecialOffer
		/// </summary>
		public virtual System.String Description
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.Description);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Description because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.Description, value))
				{
					OnDescriptionChanged();
				}
			}
		}
	
		/// <summary>
		/// The DiscountPct property of the Entity SpecialOffer
		/// </summary>
		public virtual System.Decimal DiscountPct
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.DiscountPct);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DiscountPct because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.DiscountPct, value))
				{
					OnDiscountPctChanged();
				}
			}
		}
	
		/// <summary>
		/// The Type property of the Entity SpecialOffer
		/// </summary>
		public virtual System.String Type
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.Type);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Type because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.Type, value))
				{
					OnTypeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Category property of the Entity SpecialOffer
		/// </summary>
		public virtual System.String Category
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.Category);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Category because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.Category, value))
				{
					OnCategoryChanged();
				}
			}
		}
	
		/// <summary>
		/// The StartDate property of the Entity SpecialOffer
		/// </summary>
		public virtual System.DateTime StartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.StartDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StartDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.StartDate, value))
				{
					OnStartDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The EndDate property of the Entity SpecialOffer
		/// </summary>
		public virtual System.DateTime EndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.EndDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for EndDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.EndDate, value))
				{
					OnEndDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The MinQty property of the Entity SpecialOffer
		/// </summary>
		public virtual System.Int32 MinQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.MinQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for MinQty because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.MinQty, value))
				{
					OnMinQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The MaxQty property of the Entity SpecialOffer
		/// </summary>
		public virtual System.Int32 MaxQty
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.MaxQty);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for MaxQty because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.MaxQty, value))
				{
					OnMaxQtyChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity SpecialOffer
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity SpecialOffer
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)SpecialOfferFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)SpecialOfferFieldIndex.ModifiedDate, value))
				{
					OnModifiedDateChanged();
				}
			}
		}
	
	
		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferProductEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOfferProduct()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SpecialOfferProductCollection SpecialOfferProduct
		{
			get
			{
				return GetMultiSpecialOfferProduct(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SpecialOfferProduct. When set to true, SpecialOfferProduct is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOfferProduct is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOfferProduct(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOfferProduct
		{
			get
			{
				return _alwaysFetchSpecialOfferProduct;
			}
			set
			{
				_alwaysFetchSpecialOfferProduct = value;
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
