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
using System.Data;
using System.Collections;
using System.ComponentModel;
using System.Xml;
using System.Runtime.Serialization;

using LLBL2003.AdventureWorks2008.EntityClasses;
using LLBL2003.AdventureWorks2008.FactoryClasses;
using LLBL2003.AdventureWorks2008.DaoClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;
using LLBL2003.AdventureWorks2008.ValidatorClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.CollectionClasses
{
	/// <summary>
	/// Collection class for storing and retrieving collections of ProductEntity objects. 
	/// </summary>
	[Serializable]
	public class ProductCollection : EntityCollectionBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ProductCollection():base(new PropertyDescriptorFactory(), typeof(ProductCollection), new ProductEntityFactory())
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductCollection(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
			:base(propertyDescriptorFactoryToUse, typeof(ProductCollection), entityFactoryToUse)
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		///  <param name="validatorToUse">The validator object to use when creating entity objects during a GetMulti() call.</param>
		public ProductCollection(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse, ProductValidator validatorToUse)
			:base(propertyDescriptorFactoryToUse, typeof(ProductCollection), entityFactoryToUse, validatorToUse)
		{
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductCollection(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}


		/// <summary>
		/// Converts the Entities inside this entitycollection into an Entity node with inner nodes for each field, which is stored in a generic collection node.
		/// </summary>
		/// <returns>XmlNode containing the EntityFields in xml format</returns>
		[Obsolete("ToXml is obsolete. use WriteXml instead.", false)]
		public override XmlNode ToXml()
		{
			return base.ToXml("ProductCollection");
		}

	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which have data in common
		/// with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(ProductModelEntity productModelInstance, ProductSubcategoryEntity productSubcategoryInstance, UnitMeasureEntity unitMeasureInstance, UnitMeasureEntity unitMeasure_Instance)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, base.MaxNumberOfItemsToReturn, base.SortClauses, null);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which have data in common
		/// with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(ProductModelEntity productModelInstance, ProductSubcategoryEntity productSubcategoryInstance, UnitMeasureEntity unitMeasureInstance, UnitMeasureEntity unitMeasure_Instance, IPredicateExpression filter)
		{
			return GetMultiManyToOne(productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance, base.MaxNumberOfItemsToReturn, base.SortClauses, filter);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which have data in common
		/// with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter. All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="filter">Extra filter to limit the resultset. Predicate expression can be null, in which case it will be ignored.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMultiManyToOne(ProductModelEntity productModelInstance, ProductSubcategoryEntity productSubcategoryInstance, UnitMeasureEntity unitMeasureInstance, UnitMeasureEntity unitMeasure_Instance, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IPredicateExpression filter)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, filter, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance);
		}


		/// <summary>
		/// Deletes from the persistent storage all Product entities which have data in common
		/// with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter.
		/// </summary>
		/// <remarks>Runs directly on the persistent storage. It will not delete entity objects from the current collection.</remarks>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMultiManyToOne( ProductModelEntity productModelInstance,  ProductSubcategoryEntity productSubcategoryInstance,  UnitMeasureEntity unitMeasureInstance,  UnitMeasureEntity unitMeasure_Instance)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.DeleteMulti(base.Transaction, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance);
		}


		/// <summary>
		/// Updates in the persistent storage all Product entities which have data in common with the specified related Entities.
		/// If one is omitted, that entity is not used as a filter.
		/// Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in the passed in entity entityWithNewValues. The new values of these fields are read from entityWithNewValues. 
		/// </summary>
		/// <param name="entityWithNewValues">ProductEntity instance which holds the new values for the matching entities to update. Only
		/// changed fields are taken into account</param>
		/// <param name="productModelInstance">ProductModelEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="productSubcategoryInstance">ProductSubcategoryEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasureInstance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <param name="unitMeasure_Instance">UnitMeasureEntity instance to use as a filter for the ProductEntity objects to return</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMultiManyToOne(ProductEntity entityWithNewValues, ProductModelEntity productModelInstance, ProductSubcategoryEntity productSubcategoryInstance, UnitMeasureEntity unitMeasureInstance, UnitMeasureEntity unitMeasure_Instance)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateMulti(entityWithNewValues.Fields, base.Transaction, productModelInstance, productSubcategoryInstance, unitMeasureInstance, unitMeasure_Instance);
		}
	
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure__(UnitMeasureEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasure__(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure__(UnitMeasureEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasure__(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, unitMeasureInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure___(UnitMeasureEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasure___(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure___(UnitMeasureEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasure___(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, unitMeasureInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocument(DocumentEntity documentInstance)
		{
			return GetMultiManyToManyUsingDocument(documentInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in DocumentEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="documentInstance">DocumentEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingDocument(DocumentEntity documentInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingDocument(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, documentInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocation(LocationEntity locationInstance)
		{
			return GetMultiManyToManyUsingLocation(locationInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in LocationEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="locationInstance">LocationEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingLocation(LocationEntity locationInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingLocation(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, locationInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhoto(ProductPhotoEntity productPhotoInstance)
		{
			return GetMultiManyToManyUsingProductPhoto(productPhotoInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in ProductPhotoEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="productPhotoInstance">ProductPhotoEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingProductPhoto(ProductPhotoEntity productPhotoInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingProductPhoto(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, productPhotoInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReason(ScrapReasonEntity scrapReasonInstance)
		{
			return GetMultiManyToManyUsingScrapReason(scrapReasonInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in ScrapReasonEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="scrapReasonInstance">ScrapReasonEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingScrapReason(ScrapReasonEntity scrapReasonInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingScrapReason(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, scrapReasonInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure____(UnitMeasureEntity unitMeasureInstance)
		{
			return GetMultiManyToManyUsingUnitMeasure____(unitMeasureInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in UnitMeasureEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="unitMeasureInstance">UnitMeasureEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingUnitMeasure____(UnitMeasureEntity unitMeasureInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingUnitMeasure____(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, unitMeasureInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendor(VendorEntity vendorInstance)
		{
			return GetMultiManyToManyUsingVendor(vendorInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in VendorEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="vendorInstance">VendorEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingVendor(VendorEntity vendorInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingVendor(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, vendorInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeader(PurchaseOrderHeaderEntity purchaseOrderHeaderInstance)
		{
			return GetMultiManyToManyUsingPurchaseOrderHeader(purchaseOrderHeaderInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in PurchaseOrderHeaderEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="purchaseOrderHeaderInstance">PurchaseOrderHeaderEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingPurchaseOrderHeader(PurchaseOrderHeaderEntity purchaseOrderHeaderInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingPurchaseOrderHeader(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, purchaseOrderHeaderInstance);
		}
	
		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// Relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffer(SpecialOfferEntity specialOfferInstance)
		{
			return GetMultiManyToManyUsingSpecialOffer(specialOfferInstance, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}
		

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which are related via a 
		/// relation of type 'm:n' with the passed in SpecialOfferEntity. 
		/// All current elements in the collection are removed from the collection.
		/// </summary>
		/// <param name="specialOfferInstance">SpecialOfferEntity object to be used as a filter in the m:n relation</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if the retrieval succeeded, false otherwise</returns>
		public bool GetMultiManyToManyUsingSpecialOffer(SpecialOfferEntity specialOfferInstance, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiUsingSpecialOffer(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, specialOfferInstance);
		}
	

		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve. When set to null 
		/// all entities will be retrieved (no filtering is being performed)</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMulti(IPredicate selectFilter)
		{
			return GetMulti(selectFilter, base.MaxNumberOfItemsToReturn, base.SortClauses);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve. When set to null 
		/// all entities will be retrieved (no filtering is being performed)</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMulti(IPredicate selectFilter, long maxNumberOfItemsToReturn)
		{
			return GetMulti(selectFilter, maxNumberOfItemsToReturn, base.SortClauses);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve. When set to null 
		/// all entities will be retrieved (no filtering is being performed)</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMulti(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, selectFilter);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMulti(IPredicate selectFilter, IRelationCollection relations)
		{
			return GetMulti(selectFilter, base.MaxNumberOfItemsToReturn, base.SortClauses, relations);
		}


		/// <summary>
		/// Retrieves in this ProductCollection object all ProductEntity objects which match with the specified filter, formulated in
		/// the predicate or predicate expression definition, using the passed in relations to construct the total query.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>true if succeeded, false otherwise</returns>
		public bool GetMulti(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			if(!base.SuppressClearInGetMulti)
			{
				this.Clear();
			}

			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMulti(base.Transaction, this, maxNumberOfItemsToReturn, sortClauses, base.EntityFactoryToUse, base.ValidatorToUse, selectFilter, relations);
		}


		/// <summary>
		/// Retrieves ProductEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter);
		}


		/// <summary>
		/// Retrieves ProductEntity rows in a datatable which match the specified filter. It will always create a new connection to the database.
		/// </summary>
		/// <param name="selectFilter">A predicate or predicate expression which should be used as filter for the entities to retrieve.</param>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return with this retrieval query.</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified, no sorting is applied.</param>
		/// <param name="relations">The set of relations to walk to construct to total query.</param>
		/// <returns>DataTable with the rows requested.</returns>
		public static DataTable GetMultiAsDataTable(IPredicate selectFilter, long maxNumberOfItemsToReturn, ISortExpression sortClauses, IRelationCollection relations)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.GetMultiAsDataTable(maxNumberOfItemsToReturn, sortClauses, selectFilter, relations);
		}


		/// <summary>
		/// Deletes from the persistent storage all Product entities which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete. Can be null, which
		/// will result in a query removing all Product entities from the persistent storage</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(IPredicate deleteFilter)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter);
		}


		/// <summary>
		/// Deletes from the persistent storage all Product entities which match with the specified filter, formulated in
		/// the predicate or predicate expression definition.
		/// </summary>
		/// <param name="deleteFilter">A predicate or predicate expression which should be used as filter for the entities to delete.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int DeleteMulti(IPredicate deleteFilter, IRelationCollection relations)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.DeleteMulti(base.Transaction, deleteFilter, relations);
		}


		/// <summary>
		/// Updates in the persistent storage all entities which have data in common with the specified ProductEntity. 
		/// If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. 
		/// </summary>
		/// <param name="entityWithNewValues">ProductEntity instance which holds the new values for the matching entities to update. Only
		/// changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update. Can be null, which
		/// will result in an update action which will affect all Product entities.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(ProductEntity entityWithNewValues, IPredicate updateFilter)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateMulti(entityWithNewValues.Fields, base.Transaction, updateFilter);
		}


		/// <summary>
		/// Updates in the persistent storage all entities which have data in common with the specified ProductEntity. 
		/// If one is omitted that entity is not used as a filter. Which fields are updated in those matching entities depends on which fields are
		/// <i>changed</i> in entityWithNewValues. The new values of these fields are read from entityWithNewValues. 
		/// </summary>
		/// <param name="entityWithNewValues">ProductEntity instance which holds the new values for the matching entities to update. Only
		/// changed fields are taken into account</param>
		/// <param name="updateFilter">A predicate or predicate expression which should be used as filter for the entities to update.</param>
		/// <param name="relations">The set of relations to walk to construct the total query.</param>
		/// <returns>Amount of entities affected, if the used persistent storage has rowcounting enabled.</returns>
		public int UpdateMulti(ProductEntity entityWithNewValues, IPredicate updateFilter, IRelationCollection relations)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateMulti(entityWithNewValues.Fields, base.Transaction, updateFilter, relations);
		}


		/// <summary>
		/// Saves all new/dirty Entities in the IEntityCollection in the persistent storage. If this IEntityCollection is added
		/// to a transaction, the save processes will be done in that transaction, if the entity isn't already added to another transaction.
		/// If the entity is already in another transaction, it will use that transaction. If no transaction is present, the saves are done in a
		/// new Transaction (which is created in an inherited method.)
		/// </summary>
		/// <param name="recurse">If true, will recursively save the entities inside the collection</param>
		/// <returns>Amount of entities inserted</returns>
		/// <remarks>All exceptions will be bubbled upwards so transaction code can anticipate on exceptions.</remarks>
		public override int SaveMulti(bool recurse)
		{
			int amountSaved = 0;

			// check if this collection is added to a transaction. If not start a new one.
			if(!this.ParticipatesInTransaction)
			{
				// start a new transaction and add this collection to it.
				Transaction transactionManager = new Transaction(IsolationLevel.ReadCommitted, "SaveMulti");
				transactionManager.Add(this);

				try
				{
					amountSaved = base.SaveMulti(recurse);
					transactionManager.Commit();
				}
				catch
				{
					// exception caught. roll back
					transactionManager.Rollback();

					// bubble exception 
					throw;
				}
			}
			else
			{
				amountSaved = base.SaveMulti(recurse);
			}

			return amountSaved;
		}


		/// <summary>
		/// Deletes all Entities in the IEntityCollection from the persistent storage. If this IEntityCollection is added
		/// to a transaction, the delete processes will be done in that transaction, if the entity isn't already added to another transaction.
		/// If the entity is already in another transaction, it will use that transaction. If no transaction is present, the deletes are done in a
		/// new Transaction.
		/// Deleted entities are marked deleted and are removed from the collection.
		/// </summary>
		/// <returns>Amount of entities deleted</returns>
		public override int DeleteMulti()
		{
			int amountDeleted = 0;

			// check if this collection is added to a transaction. If not start a new one.
			if(!this.ParticipatesInTransaction)
			{
				// start a new transaction and add this collection to it.
				Transaction transactionManager = new Transaction(IsolationLevel.ReadCommitted, "DeleteMulti");
				transactionManager.Add(this);

				try
				{
					amountDeleted = base.DeleteMulti();
					transactionManager.Commit();
				}
				catch
				{
					// exception caught. roll back
					transactionManager.Rollback();

					// bubble exception 
					throw;
				}
			}
			else
			{
				amountDeleted = base.DeleteMulti();
			}

			return amountDeleted;
		}


		/// <summary>
		/// Routine used for complex databinding. Part of ITypedList.
		/// </summary>
		/// <param name="listAccessors">An array of PropertyDescriptor objects, the list name for which is returned. This can be a null reference.</param>
		/// <returns>The name of this list</returns>
		public override string GetListName(PropertyDescriptor[] listAccessors)
		{
			return "ProductCollection";
		}


		#region Class Property Declarations
		/// <summary>
		/// Strong typed indexer. 
		/// </summary>
		public ProductEntity this [int index]
		{
			get { return (ProductEntity)List[index]; }
		}
		#endregion

	}
}
