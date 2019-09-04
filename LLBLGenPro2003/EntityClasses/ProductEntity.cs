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
	/// Entity class which represents the entity 'Product' in the 'AdventureWorks' database.
	/// </summary>
	[Serializable]
	public class ProductEntity : EntityBase, ISerializable
	{
		#region Class Member Declarations
		private BillOfMaterialsCollection	_billOfMaterials;
		private bool	_alwaysFetchBillOfMaterials, _alreadyFetchedBillOfMaterials;
		private BillOfMaterialsCollection	_billOfMaterials_;
		private bool	_alwaysFetchBillOfMaterials_, _alreadyFetchedBillOfMaterials_;
		private ProductCostHistoryCollection	_productCostHistory;
		private bool	_alwaysFetchProductCostHistory, _alreadyFetchedProductCostHistory;
		private ProductDocumentCollection	_productDocument;
		private bool	_alwaysFetchProductDocument, _alreadyFetchedProductDocument;
		private ProductInventoryCollection	_productInventory;
		private bool	_alwaysFetchProductInventory, _alreadyFetchedProductInventory;
		private ProductListPriceHistoryCollection	_productListPriceHistory;
		private bool	_alwaysFetchProductListPriceHistory, _alreadyFetchedProductListPriceHistory;
		private ProductProductPhotoCollection	_productProductPhoto;
		private bool	_alwaysFetchProductProductPhoto, _alreadyFetchedProductProductPhoto;
		private ProductReviewCollection	_productReview;
		private bool	_alwaysFetchProductReview, _alreadyFetchedProductReview;
		private TransactionHistoryCollection	_transactionHistory;
		private bool	_alwaysFetchTransactionHistory, _alreadyFetchedTransactionHistory;
		private WorkOrderCollection	_workOrder;
		private bool	_alwaysFetchWorkOrder, _alreadyFetchedWorkOrder;
		private ProductVendorCollection	_productVendor;
		private bool	_alwaysFetchProductVendor, _alreadyFetchedProductVendor;
		private PurchaseOrderDetailCollection	_purchaseOrderDetail;
		private bool	_alwaysFetchPurchaseOrderDetail, _alreadyFetchedPurchaseOrderDetail;
		private ShoppingCartItemCollection	_shoppingCartItem;
		private bool	_alwaysFetchShoppingCartItem, _alreadyFetchedShoppingCartItem;
		private SpecialOfferProductCollection	_specialOfferProduct;
		private bool	_alwaysFetchSpecialOfferProduct, _alreadyFetchedSpecialOfferProduct;
		private UnitMeasureCollection _unitMeasure__;
		private bool	_alwaysFetchUnitMeasure__, _alreadyFetchedUnitMeasure__;
		private UnitMeasureCollection _unitMeasure___;
		private bool	_alwaysFetchUnitMeasure___, _alreadyFetchedUnitMeasure___;
		private DocumentCollection _document;
		private bool	_alwaysFetchDocument, _alreadyFetchedDocument;
		private LocationCollection _location;
		private bool	_alwaysFetchLocation, _alreadyFetchedLocation;
		private ProductPhotoCollection _productPhoto;
		private bool	_alwaysFetchProductPhoto, _alreadyFetchedProductPhoto;
		private ScrapReasonCollection _scrapReason;
		private bool	_alwaysFetchScrapReason, _alreadyFetchedScrapReason;
		private UnitMeasureCollection _unitMeasure____;
		private bool	_alwaysFetchUnitMeasure____, _alreadyFetchedUnitMeasure____;
		private VendorCollection _vendor;
		private bool	_alwaysFetchVendor, _alreadyFetchedVendor;
		private PurchaseOrderHeaderCollection _purchaseOrderHeader;
		private bool	_alwaysFetchPurchaseOrderHeader, _alreadyFetchedPurchaseOrderHeader;
		private SpecialOfferCollection _specialOffer;
		private bool	_alwaysFetchSpecialOffer, _alreadyFetchedSpecialOffer;
		private ProductModelEntity _productModel;
		private bool	_alwaysFetchProductModel, _alreadyFetchedProductModel;
		private ProductSubcategoryEntity _productSubcategory;
		private bool	_alwaysFetchProductSubcategory, _alreadyFetchedProductSubcategory;
		private UnitMeasureEntity _unitMeasure;
		private bool	_alwaysFetchUnitMeasure, _alreadyFetchedUnitMeasure;
		private UnitMeasureEntity _unitMeasure_;
		private bool	_alwaysFetchUnitMeasure_, _alreadyFetchedUnitMeasure_;

		#endregion

		#region DataBinding Change Event Handler Declarations

		/// <summary>
		/// Event which is thrown when ProductID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductIDChanged;

		/// <summary>
		/// Event which is thrown when Name changes value. Databinding related.
		/// </summary>
		public event EventHandler NameChanged;

		/// <summary>
		/// Event which is thrown when ProductNumber changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductNumberChanged;

		/// <summary>
		/// Event which is thrown when MakeFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler MakeFlagChanged;

		/// <summary>
		/// Event which is thrown when FinishedGoodsFlag changes value. Databinding related.
		/// </summary>
		public event EventHandler FinishedGoodsFlagChanged;

		/// <summary>
		/// Event which is thrown when Color changes value. Databinding related.
		/// </summary>
		public event EventHandler ColorChanged;

		/// <summary>
		/// Event which is thrown when SafetyStockLevel changes value. Databinding related.
		/// </summary>
		public event EventHandler SafetyStockLevelChanged;

		/// <summary>
		/// Event which is thrown when ReorderPoint changes value. Databinding related.
		/// </summary>
		public event EventHandler ReorderPointChanged;

		/// <summary>
		/// Event which is thrown when StandardCost changes value. Databinding related.
		/// </summary>
		public event EventHandler StandardCostChanged;

		/// <summary>
		/// Event which is thrown when ListPrice changes value. Databinding related.
		/// </summary>
		public event EventHandler ListPriceChanged;

		/// <summary>
		/// Event which is thrown when Size changes value. Databinding related.
		/// </summary>
		public event EventHandler SizeChanged;

		/// <summary>
		/// Event which is thrown when SizeUnitMeasureCode changes value. Databinding related.
		/// </summary>
		public event EventHandler SizeUnitMeasureCodeChanged;

		/// <summary>
		/// Event which is thrown when WeightUnitMeasureCode changes value. Databinding related.
		/// </summary>
		public event EventHandler WeightUnitMeasureCodeChanged;

		/// <summary>
		/// Event which is thrown when Weight changes value. Databinding related.
		/// </summary>
		public event EventHandler WeightChanged;

		/// <summary>
		/// Event which is thrown when DaysToManufacture changes value. Databinding related.
		/// </summary>
		public event EventHandler DaysToManufactureChanged;

		/// <summary>
		/// Event which is thrown when ProductLine changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductLineChanged;

		/// <summary>
		/// Event which is thrown when Class changes value. Databinding related.
		/// </summary>
		public event EventHandler ClassChanged;

		/// <summary>
		/// Event which is thrown when Style changes value. Databinding related.
		/// </summary>
		public event EventHandler StyleChanged;

		/// <summary>
		/// Event which is thrown when ProductSubcategoryID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductSubcategoryIDChanged;

		/// <summary>
		/// Event which is thrown when ProductModelID changes value. Databinding related.
		/// </summary>
		public event EventHandler ProductModelIDChanged;

		/// <summary>
		/// Event which is thrown when SellStartDate changes value. Databinding related.
		/// </summary>
		public event EventHandler SellStartDateChanged;

		/// <summary>
		/// Event which is thrown when SellEndDate changes value. Databinding related.
		/// </summary>
		public event EventHandler SellEndDateChanged;

		/// <summary>
		/// Event which is thrown when DiscontinuedDate changes value. Databinding related.
		/// </summary>
		public event EventHandler DiscontinuedDateChanged;

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
		public ProductEntity()
		{
			InitClassEmpty(new PropertyDescriptorFactory(), new ProductEntityFactory());
		}

	
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		public ProductEntity(System.Int32 productID)
		{
			InitClassFetch(productID, new ProductValidator(), new PropertyDescriptorFactory(), new ProductEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		public ProductEntity(System.Int32 productID, ProductValidator validator)
		{
			InitClassFetch(productID, validator, new PropertyDescriptorFactory(), new ProductEntityFactory());
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="validator">The custom validator object for this ProductEntity</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductEntity(System.Int32 productID, ProductValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassFetch(productID, validator, propertyDescriptorFactoryToUse, entityFactoryToUse);
		}
	

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		public ProductEntity(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassEmpty(propertyDescriptorFactoryToUse, entityFactoryToUse);
		}


		/// <summary>
		/// Private CTor for deserialization
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		private ProductEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{

			_billOfMaterials = (BillOfMaterialsCollection)info.GetValue("_billOfMaterials", typeof(BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials = info.GetBoolean("_alwaysFetchBillOfMaterials");
			_alreadyFetchedBillOfMaterials = info.GetBoolean("_alreadyFetchedBillOfMaterials");

			_billOfMaterials_ = (BillOfMaterialsCollection)info.GetValue("_billOfMaterials_", typeof(BillOfMaterialsCollection));
			_alwaysFetchBillOfMaterials_ = info.GetBoolean("_alwaysFetchBillOfMaterials_");
			_alreadyFetchedBillOfMaterials_ = info.GetBoolean("_alreadyFetchedBillOfMaterials_");

			_productCostHistory = (ProductCostHistoryCollection)info.GetValue("_productCostHistory", typeof(ProductCostHistoryCollection));
			_alwaysFetchProductCostHistory = info.GetBoolean("_alwaysFetchProductCostHistory");
			_alreadyFetchedProductCostHistory = info.GetBoolean("_alreadyFetchedProductCostHistory");

			_productDocument = (ProductDocumentCollection)info.GetValue("_productDocument", typeof(ProductDocumentCollection));
			_alwaysFetchProductDocument = info.GetBoolean("_alwaysFetchProductDocument");
			_alreadyFetchedProductDocument = info.GetBoolean("_alreadyFetchedProductDocument");

			_productInventory = (ProductInventoryCollection)info.GetValue("_productInventory", typeof(ProductInventoryCollection));
			_alwaysFetchProductInventory = info.GetBoolean("_alwaysFetchProductInventory");
			_alreadyFetchedProductInventory = info.GetBoolean("_alreadyFetchedProductInventory");

			_productListPriceHistory = (ProductListPriceHistoryCollection)info.GetValue("_productListPriceHistory", typeof(ProductListPriceHistoryCollection));
			_alwaysFetchProductListPriceHistory = info.GetBoolean("_alwaysFetchProductListPriceHistory");
			_alreadyFetchedProductListPriceHistory = info.GetBoolean("_alreadyFetchedProductListPriceHistory");

			_productProductPhoto = (ProductProductPhotoCollection)info.GetValue("_productProductPhoto", typeof(ProductProductPhotoCollection));
			_alwaysFetchProductProductPhoto = info.GetBoolean("_alwaysFetchProductProductPhoto");
			_alreadyFetchedProductProductPhoto = info.GetBoolean("_alreadyFetchedProductProductPhoto");

			_productReview = (ProductReviewCollection)info.GetValue("_productReview", typeof(ProductReviewCollection));
			_alwaysFetchProductReview = info.GetBoolean("_alwaysFetchProductReview");
			_alreadyFetchedProductReview = info.GetBoolean("_alreadyFetchedProductReview");

			_transactionHistory = (TransactionHistoryCollection)info.GetValue("_transactionHistory", typeof(TransactionHistoryCollection));
			_alwaysFetchTransactionHistory = info.GetBoolean("_alwaysFetchTransactionHistory");
			_alreadyFetchedTransactionHistory = info.GetBoolean("_alreadyFetchedTransactionHistory");

			_workOrder = (WorkOrderCollection)info.GetValue("_workOrder", typeof(WorkOrderCollection));
			_alwaysFetchWorkOrder = info.GetBoolean("_alwaysFetchWorkOrder");
			_alreadyFetchedWorkOrder = info.GetBoolean("_alreadyFetchedWorkOrder");

			_productVendor = (ProductVendorCollection)info.GetValue("_productVendor", typeof(ProductVendorCollection));
			_alwaysFetchProductVendor = info.GetBoolean("_alwaysFetchProductVendor");
			_alreadyFetchedProductVendor = info.GetBoolean("_alreadyFetchedProductVendor");

			_purchaseOrderDetail = (PurchaseOrderDetailCollection)info.GetValue("_purchaseOrderDetail", typeof(PurchaseOrderDetailCollection));
			_alwaysFetchPurchaseOrderDetail = info.GetBoolean("_alwaysFetchPurchaseOrderDetail");
			_alreadyFetchedPurchaseOrderDetail = info.GetBoolean("_alreadyFetchedPurchaseOrderDetail");

			_shoppingCartItem = (ShoppingCartItemCollection)info.GetValue("_shoppingCartItem", typeof(ShoppingCartItemCollection));
			_alwaysFetchShoppingCartItem = info.GetBoolean("_alwaysFetchShoppingCartItem");
			_alreadyFetchedShoppingCartItem = info.GetBoolean("_alreadyFetchedShoppingCartItem");

			_specialOfferProduct = (SpecialOfferProductCollection)info.GetValue("_specialOfferProduct", typeof(SpecialOfferProductCollection));
			_alwaysFetchSpecialOfferProduct = info.GetBoolean("_alwaysFetchSpecialOfferProduct");
			_alreadyFetchedSpecialOfferProduct = info.GetBoolean("_alreadyFetchedSpecialOfferProduct");

			_unitMeasure__ = (UnitMeasureCollection)info.GetValue("_unitMeasure__", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure__ = info.GetBoolean("_alwaysFetchUnitMeasure__");
			_alreadyFetchedUnitMeasure__ = info.GetBoolean("_alreadyFetchedUnitMeasure__");

			_unitMeasure___ = (UnitMeasureCollection)info.GetValue("_unitMeasure___", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure___ = info.GetBoolean("_alwaysFetchUnitMeasure___");
			_alreadyFetchedUnitMeasure___ = info.GetBoolean("_alreadyFetchedUnitMeasure___");

			_document = (DocumentCollection)info.GetValue("_document", typeof(DocumentCollection));
			_alwaysFetchDocument = info.GetBoolean("_alwaysFetchDocument");
			_alreadyFetchedDocument = info.GetBoolean("_alreadyFetchedDocument");

			_location = (LocationCollection)info.GetValue("_location", typeof(LocationCollection));
			_alwaysFetchLocation = info.GetBoolean("_alwaysFetchLocation");
			_alreadyFetchedLocation = info.GetBoolean("_alreadyFetchedLocation");

			_productPhoto = (ProductPhotoCollection)info.GetValue("_productPhoto", typeof(ProductPhotoCollection));
			_alwaysFetchProductPhoto = info.GetBoolean("_alwaysFetchProductPhoto");
			_alreadyFetchedProductPhoto = info.GetBoolean("_alreadyFetchedProductPhoto");

			_scrapReason = (ScrapReasonCollection)info.GetValue("_scrapReason", typeof(ScrapReasonCollection));
			_alwaysFetchScrapReason = info.GetBoolean("_alwaysFetchScrapReason");
			_alreadyFetchedScrapReason = info.GetBoolean("_alreadyFetchedScrapReason");

			_unitMeasure____ = (UnitMeasureCollection)info.GetValue("_unitMeasure____", typeof(UnitMeasureCollection));
			_alwaysFetchUnitMeasure____ = info.GetBoolean("_alwaysFetchUnitMeasure____");
			_alreadyFetchedUnitMeasure____ = info.GetBoolean("_alreadyFetchedUnitMeasure____");

			_vendor = (VendorCollection)info.GetValue("_vendor", typeof(VendorCollection));
			_alwaysFetchVendor = info.GetBoolean("_alwaysFetchVendor");
			_alreadyFetchedVendor = info.GetBoolean("_alreadyFetchedVendor");

			_purchaseOrderHeader = (PurchaseOrderHeaderCollection)info.GetValue("_purchaseOrderHeader", typeof(PurchaseOrderHeaderCollection));
			_alwaysFetchPurchaseOrderHeader = info.GetBoolean("_alwaysFetchPurchaseOrderHeader");
			_alreadyFetchedPurchaseOrderHeader = info.GetBoolean("_alreadyFetchedPurchaseOrderHeader");

			_specialOffer = (SpecialOfferCollection)info.GetValue("_specialOffer", typeof(SpecialOfferCollection));
			_alwaysFetchSpecialOffer = info.GetBoolean("_alwaysFetchSpecialOffer");
			_alreadyFetchedSpecialOffer = info.GetBoolean("_alreadyFetchedSpecialOffer");
			_productModel = (ProductModelEntity)info.GetValue("_productModel", typeof(ProductModelEntity));
			if(_productModel!=null)
			{
				// rewire event handler.
				_productModel.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProductModel = info.GetBoolean("_alwaysFetchProductModel");
			_alreadyFetchedProductModel = info.GetBoolean("_alreadyFetchedProductModel");
			_productSubcategory = (ProductSubcategoryEntity)info.GetValue("_productSubcategory", typeof(ProductSubcategoryEntity));
			if(_productSubcategory!=null)
			{
				// rewire event handler.
				_productSubcategory.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchProductSubcategory = info.GetBoolean("_alwaysFetchProductSubcategory");
			_alreadyFetchedProductSubcategory = info.GetBoolean("_alreadyFetchedProductSubcategory");
			_unitMeasure = (UnitMeasureEntity)info.GetValue("_unitMeasure", typeof(UnitMeasureEntity));
			if(_unitMeasure!=null)
			{
				// rewire event handler.
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchUnitMeasure = info.GetBoolean("_alwaysFetchUnitMeasure");
			_alreadyFetchedUnitMeasure = info.GetBoolean("_alreadyFetchedUnitMeasure");
			_unitMeasure_ = (UnitMeasureEntity)info.GetValue("_unitMeasure_", typeof(UnitMeasureEntity));
			if(_unitMeasure_!=null)
			{
				// rewire event handler.
				_unitMeasure_.AfterSave+=new EventHandler(OnEntityAfterSave);
			}
			_alwaysFetchUnitMeasure_ = info.GetBoolean("_alwaysFetchUnitMeasure_");
			_alreadyFetchedUnitMeasure_ = info.GetBoolean("_alreadyFetchedUnitMeasure_");

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
			_alreadyFetchedBillOfMaterials_ = (_billOfMaterials_.Count > 0);
			_alreadyFetchedProductCostHistory = (_productCostHistory.Count > 0);
			_alreadyFetchedProductDocument = (_productDocument.Count > 0);
			_alreadyFetchedProductInventory = (_productInventory.Count > 0);
			_alreadyFetchedProductListPriceHistory = (_productListPriceHistory.Count > 0);
			_alreadyFetchedProductProductPhoto = (_productProductPhoto.Count > 0);
			_alreadyFetchedProductReview = (_productReview.Count > 0);
			_alreadyFetchedTransactionHistory = (_transactionHistory.Count > 0);
			_alreadyFetchedWorkOrder = (_workOrder.Count > 0);
			_alreadyFetchedProductVendor = (_productVendor.Count > 0);
			_alreadyFetchedPurchaseOrderDetail = (_purchaseOrderDetail.Count > 0);
			_alreadyFetchedShoppingCartItem = (_shoppingCartItem.Count > 0);
			_alreadyFetchedSpecialOfferProduct = (_specialOfferProduct.Count > 0);
			_alreadyFetchedUnitMeasure__ = (_unitMeasure__.Count > 0);
			_alreadyFetchedUnitMeasure___ = (_unitMeasure___.Count > 0);
			_alreadyFetchedDocument = (_document.Count > 0);
			_alreadyFetchedLocation = (_location.Count > 0);
			_alreadyFetchedProductPhoto = (_productPhoto.Count > 0);
			_alreadyFetchedScrapReason = (_scrapReason.Count > 0);
			_alreadyFetchedUnitMeasure____ = (_unitMeasure____.Count > 0);
			_alreadyFetchedVendor = (_vendor.Count > 0);
			_alreadyFetchedPurchaseOrderHeader = (_purchaseOrderHeader.Count > 0);
			_alreadyFetchedSpecialOffer = (_specialOffer.Count > 0);
			_alreadyFetchedProductModel = (_productModel != null);
			_alreadyFetchedProductSubcategory = (_productSubcategory != null);
			_alreadyFetchedUnitMeasure = (_unitMeasure != null);
			_alreadyFetchedUnitMeasure_ = (_unitMeasure_ != null);

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
			info.AddValue("_billOfMaterials_", _billOfMaterials_);
			info.AddValue("_alwaysFetchBillOfMaterials_", _alwaysFetchBillOfMaterials_);
			info.AddValue("_alreadyFetchedBillOfMaterials_", _alreadyFetchedBillOfMaterials_);
			info.AddValue("_productCostHistory", _productCostHistory);
			info.AddValue("_alwaysFetchProductCostHistory", _alwaysFetchProductCostHistory);
			info.AddValue("_alreadyFetchedProductCostHistory", _alreadyFetchedProductCostHistory);
			info.AddValue("_productDocument", _productDocument);
			info.AddValue("_alwaysFetchProductDocument", _alwaysFetchProductDocument);
			info.AddValue("_alreadyFetchedProductDocument", _alreadyFetchedProductDocument);
			info.AddValue("_productInventory", _productInventory);
			info.AddValue("_alwaysFetchProductInventory", _alwaysFetchProductInventory);
			info.AddValue("_alreadyFetchedProductInventory", _alreadyFetchedProductInventory);
			info.AddValue("_productListPriceHistory", _productListPriceHistory);
			info.AddValue("_alwaysFetchProductListPriceHistory", _alwaysFetchProductListPriceHistory);
			info.AddValue("_alreadyFetchedProductListPriceHistory", _alreadyFetchedProductListPriceHistory);
			info.AddValue("_productProductPhoto", _productProductPhoto);
			info.AddValue("_alwaysFetchProductProductPhoto", _alwaysFetchProductProductPhoto);
			info.AddValue("_alreadyFetchedProductProductPhoto", _alreadyFetchedProductProductPhoto);
			info.AddValue("_productReview", _productReview);
			info.AddValue("_alwaysFetchProductReview", _alwaysFetchProductReview);
			info.AddValue("_alreadyFetchedProductReview", _alreadyFetchedProductReview);
			info.AddValue("_transactionHistory", _transactionHistory);
			info.AddValue("_alwaysFetchTransactionHistory", _alwaysFetchTransactionHistory);
			info.AddValue("_alreadyFetchedTransactionHistory", _alreadyFetchedTransactionHistory);
			info.AddValue("_workOrder", _workOrder);
			info.AddValue("_alwaysFetchWorkOrder", _alwaysFetchWorkOrder);
			info.AddValue("_alreadyFetchedWorkOrder", _alreadyFetchedWorkOrder);
			info.AddValue("_productVendor", _productVendor);
			info.AddValue("_alwaysFetchProductVendor", _alwaysFetchProductVendor);
			info.AddValue("_alreadyFetchedProductVendor", _alreadyFetchedProductVendor);
			info.AddValue("_purchaseOrderDetail", _purchaseOrderDetail);
			info.AddValue("_alwaysFetchPurchaseOrderDetail", _alwaysFetchPurchaseOrderDetail);
			info.AddValue("_alreadyFetchedPurchaseOrderDetail", _alreadyFetchedPurchaseOrderDetail);
			info.AddValue("_shoppingCartItem", _shoppingCartItem);
			info.AddValue("_alwaysFetchShoppingCartItem", _alwaysFetchShoppingCartItem);
			info.AddValue("_alreadyFetchedShoppingCartItem", _alreadyFetchedShoppingCartItem);
			info.AddValue("_specialOfferProduct", _specialOfferProduct);
			info.AddValue("_alwaysFetchSpecialOfferProduct", _alwaysFetchSpecialOfferProduct);
			info.AddValue("_alreadyFetchedSpecialOfferProduct", _alreadyFetchedSpecialOfferProduct);
			info.AddValue("_unitMeasure__", _unitMeasure__);
			info.AddValue("_alwaysFetchUnitMeasure__", _alwaysFetchUnitMeasure__);
			info.AddValue("_alreadyFetchedUnitMeasure__", _alreadyFetchedUnitMeasure__);
			info.AddValue("_unitMeasure___", _unitMeasure___);
			info.AddValue("_alwaysFetchUnitMeasure___", _alwaysFetchUnitMeasure___);
			info.AddValue("_alreadyFetchedUnitMeasure___", _alreadyFetchedUnitMeasure___);
			info.AddValue("_document", _document);
			info.AddValue("_alwaysFetchDocument", _alwaysFetchDocument);
			info.AddValue("_alreadyFetchedDocument", _alreadyFetchedDocument);
			info.AddValue("_location", _location);
			info.AddValue("_alwaysFetchLocation", _alwaysFetchLocation);
			info.AddValue("_alreadyFetchedLocation", _alreadyFetchedLocation);
			info.AddValue("_productPhoto", _productPhoto);
			info.AddValue("_alwaysFetchProductPhoto", _alwaysFetchProductPhoto);
			info.AddValue("_alreadyFetchedProductPhoto", _alreadyFetchedProductPhoto);
			info.AddValue("_scrapReason", _scrapReason);
			info.AddValue("_alwaysFetchScrapReason", _alwaysFetchScrapReason);
			info.AddValue("_alreadyFetchedScrapReason", _alreadyFetchedScrapReason);
			info.AddValue("_unitMeasure____", _unitMeasure____);
			info.AddValue("_alwaysFetchUnitMeasure____", _alwaysFetchUnitMeasure____);
			info.AddValue("_alreadyFetchedUnitMeasure____", _alreadyFetchedUnitMeasure____);
			info.AddValue("_vendor", _vendor);
			info.AddValue("_alwaysFetchVendor", _alwaysFetchVendor);
			info.AddValue("_alreadyFetchedVendor", _alreadyFetchedVendor);
			info.AddValue("_purchaseOrderHeader", _purchaseOrderHeader);
			info.AddValue("_alwaysFetchPurchaseOrderHeader", _alwaysFetchPurchaseOrderHeader);
			info.AddValue("_alreadyFetchedPurchaseOrderHeader", _alreadyFetchedPurchaseOrderHeader);
			info.AddValue("_specialOffer", _specialOffer);
			info.AddValue("_alwaysFetchSpecialOffer", _alwaysFetchSpecialOffer);
			info.AddValue("_alreadyFetchedSpecialOffer", _alreadyFetchedSpecialOffer);
			info.AddValue("_productModel", _productModel);
			info.AddValue("_alwaysFetchProductModel", _alwaysFetchProductModel);
			info.AddValue("_alreadyFetchedProductModel", _alreadyFetchedProductModel);
			info.AddValue("_productSubcategory", _productSubcategory);
			info.AddValue("_alwaysFetchProductSubcategory", _alwaysFetchProductSubcategory);
			info.AddValue("_alreadyFetchedProductSubcategory", _alreadyFetchedProductSubcategory);
			info.AddValue("_unitMeasure", _unitMeasure);
			info.AddValue("_alwaysFetchUnitMeasure", _alwaysFetchUnitMeasure);
			info.AddValue("_alreadyFetchedUnitMeasure", _alreadyFetchedUnitMeasure);
			info.AddValue("_unitMeasure_", _unitMeasure_);
			info.AddValue("_alwaysFetchUnitMeasure_", _alwaysFetchUnitMeasure_);
			info.AddValue("_alreadyFetchedUnitMeasure_", _alreadyFetchedUnitMeasure_);

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
				case "ProductModel":
					SetupSyncProductModel(relatedEntity);
					break;
				case "ProductSubcategory":
					SetupSyncProductSubcategory(relatedEntity);
					break;
				case "UnitMeasure":
					SetupSyncUnitMeasure(relatedEntity);
					break;
				case "UnitMeasure_":
					SetupSyncUnitMeasure_(relatedEntity);
					break;
				case "BillOfMaterials":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_billOfMaterials.Add(relatedEntity);
					break;
				case "BillOfMaterials_":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_billOfMaterials_.Add(relatedEntity);
					break;
				case "ProductCostHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productCostHistory.Add(relatedEntity);
					break;
				case "ProductDocument":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productDocument.Add(relatedEntity);
					break;
				case "ProductInventory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productInventory.Add(relatedEntity);
					break;
				case "ProductListPriceHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productListPriceHistory.Add(relatedEntity);
					break;
				case "ProductProductPhoto":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productProductPhoto.Add(relatedEntity);
					break;
				case "ProductReview":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productReview.Add(relatedEntity);
					break;
				case "TransactionHistory":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_transactionHistory.Add(relatedEntity);
					break;
				case "WorkOrder":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_workOrder.Add(relatedEntity);
					break;
				case "ProductVendor":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_productVendor.Add(relatedEntity);
					break;
				case "PurchaseOrderDetail":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_purchaseOrderDetail.Add(relatedEntity);
					break;
				case "ShoppingCartItem":
					// add it to the collection as well. If it's already present, the Add() will not add it again.
					_shoppingCartItem.Add(relatedEntity);
					break;
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
				case "ProductModel":
					DesetupSyncProductModel(false);
					break;
				case "ProductSubcategory":
					DesetupSyncProductSubcategory(false);
					break;
				case "UnitMeasure":
					DesetupSyncUnitMeasure(false);
					break;
				case "UnitMeasure_":
					DesetupSyncUnitMeasure_(false);
					break;
				case "BillOfMaterials":
					// Remove it from the collection.
					_billOfMaterials.Remove(relatedEntity);
					break;
				case "BillOfMaterials_":
					// Remove it from the collection.
					_billOfMaterials_.Remove(relatedEntity);
					break;
				case "ProductCostHistory":
					// Remove it from the collection.
					_productCostHistory.Remove(relatedEntity);
					break;
				case "ProductDocument":
					// Remove it from the collection.
					_productDocument.Remove(relatedEntity);
					break;
				case "ProductInventory":
					// Remove it from the collection.
					_productInventory.Remove(relatedEntity);
					break;
				case "ProductListPriceHistory":
					// Remove it from the collection.
					_productListPriceHistory.Remove(relatedEntity);
					break;
				case "ProductProductPhoto":
					// Remove it from the collection.
					_productProductPhoto.Remove(relatedEntity);
					break;
				case "ProductReview":
					// Remove it from the collection.
					_productReview.Remove(relatedEntity);
					break;
				case "TransactionHistory":
					// Remove it from the collection.
					_transactionHistory.Remove(relatedEntity);
					break;
				case "WorkOrder":
					// Remove it from the collection.
					_workOrder.Remove(relatedEntity);
					break;
				case "ProductVendor":
					// Remove it from the collection.
					_productVendor.Remove(relatedEntity);
					break;
				case "PurchaseOrderDetail":
					// Remove it from the collection.
					_purchaseOrderDetail.Remove(relatedEntity);
					break;
				case "ShoppingCartItem":
					// Remove it from the collection.
					_shoppingCartItem.Remove(relatedEntity);
					break;
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
			if(_productModel!=null)
			{
				toReturn.Add(_productModel);
			}
			if(_productSubcategory!=null)
			{
				toReturn.Add(_productSubcategory);
			}
			if(_unitMeasure!=null)
			{
				toReturn.Add(_unitMeasure);
			}
			if(_unitMeasure_!=null)
			{
				toReturn.Add(_unitMeasure_);
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

			toReturn.Add(_billOfMaterials);
			toReturn.Add(_billOfMaterials_);
			toReturn.Add(_productCostHistory);
			toReturn.Add(_productDocument);
			toReturn.Add(_productInventory);
			toReturn.Add(_productListPriceHistory);
			toReturn.Add(_productProductPhoto);
			toReturn.Add(_productReview);
			toReturn.Add(_transactionHistory);
			toReturn.Add(_workOrder);
			toReturn.Add(_productVendor);
			toReturn.Add(_purchaseOrderDetail);
			toReturn.Add(_shoppingCartItem);
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
			return base.ToXml("ProductEntity");
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
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		public bool FetchUsingPK(System.Int32 productID)
		{
			return Fetch(productID);
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
			return Fetch(this.ProductID);
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
			ProductDAO dao = DAOFactory.CreateProductDAO();
			bool wasSuccesful = dao.DeleteProduct(base.Fields, base.Transaction, deleteRestriction);
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
		public bool TestOriginalFieldValueForNull(ProductFieldIndex fieldIndex)
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
				_billOfMaterials.GetMultiManyToOne(this, null, null);
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
				_billOfMaterials.GetMultiManyToOne(this, null, null, filter);
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
				_billOfMaterials.GetMultiManyToOne(this, null, null);
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
				_billOfMaterials.GetMultiManyToOne(this, null, null, filter);
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
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedBillOfMaterials_ || forceFetch || _alwaysFetchBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials_);
					}
				}
				_billOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials_.GetMultiManyToOne(null, this, null);
				_billOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials_ = true;
			}
			return _billOfMaterials_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'BillOfMaterialsEntity'</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials_ || forceFetch || _alwaysFetchBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials_);
					}
				}
				_billOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials_.GetMultiManyToOne(null, this, null, filter);
				_billOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials_ = true;
			}
			return _billOfMaterials_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedBillOfMaterials_ || forceFetch || _alwaysFetchBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials_);
					}
				}
				_billOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials_.EntityFactoryToUse = entityFactoryToUse;
				_billOfMaterials_.GetMultiManyToOne(null, this, null);
				_billOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials_ = true;
			}
			return _billOfMaterials_;
		}


		/// <summary>
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual BillOfMaterialsCollection GetMultiBillOfMaterials_(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedBillOfMaterials_ || forceFetch || _alwaysFetchBillOfMaterials_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_billOfMaterials_.ParticipatesInTransaction)
					{
						base.Transaction.Add(_billOfMaterials_);
					}
				}
				_billOfMaterials_.SuppressClearInGetMulti=!forceFetch;
				_billOfMaterials_.EntityFactoryToUse = entityFactoryToUse;
				_billOfMaterials_.GetMultiManyToOne(null, this, null, filter);
				_billOfMaterials_.SuppressClearInGetMulti=false;
				_alreadyFetchedBillOfMaterials_ = true;
			}
			return _billOfMaterials_;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'BillOfMaterials_'. These settings will be taken into account
		/// when the property BillOfMaterials_ is requested or GetMultiBillOfMaterials_ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersBillOfMaterials_(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_billOfMaterials_.SortClauses=sortClauses;
			_billOfMaterials_.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public virtual ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductCostHistory || forceFetch || _alwaysFetchProductCostHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productCostHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCostHistory);
					}
				}
				_productCostHistory.SuppressClearInGetMulti=!forceFetch;
				_productCostHistory.GetMultiManyToOne(this);
				_productCostHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistory = true;
			}
			return _productCostHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductCostHistoryEntity'</returns>
		public virtual ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductCostHistory || forceFetch || _alwaysFetchProductCostHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productCostHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCostHistory);
					}
				}
				_productCostHistory.SuppressClearInGetMulti=!forceFetch;
				_productCostHistory.GetMultiManyToOne(this, filter);
				_productCostHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistory = true;
			}
			return _productCostHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductCostHistory || forceFetch || _alwaysFetchProductCostHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productCostHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCostHistory);
					}
				}
				_productCostHistory.SuppressClearInGetMulti=!forceFetch;
				_productCostHistory.EntityFactoryToUse = entityFactoryToUse;
				_productCostHistory.GetMultiManyToOne(this);
				_productCostHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistory = true;
			}
			return _productCostHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductCostHistoryCollection GetMultiProductCostHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductCostHistory || forceFetch || _alwaysFetchProductCostHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productCostHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productCostHistory);
					}
				}
				_productCostHistory.SuppressClearInGetMulti=!forceFetch;
				_productCostHistory.EntityFactoryToUse = entityFactoryToUse;
				_productCostHistory.GetMultiManyToOne(this, filter);
				_productCostHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductCostHistory = true;
			}
			return _productCostHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductCostHistory'. These settings will be taken into account
		/// when the property ProductCostHistory is requested or GetMultiProductCostHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductCostHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productCostHistory.SortClauses=sortClauses;
			_productCostHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productDocument.GetMultiManyToOne(null, this);
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
				_productDocument.GetMultiManyToOne(null, this, filter);
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
				_productDocument.GetMultiManyToOne(null, this);
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
				_productDocument.GetMultiManyToOne(null, this, filter);
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
		/// Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public virtual ProductInventoryCollection GetMultiProductInventory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				_productInventory.GetMultiManyToOne(null, this);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductInventoryEntity'</returns>
		public virtual ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				_productInventory.GetMultiManyToOne(null, this, filter);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				_productInventory.EntityFactoryToUse = entityFactoryToUse;
				_productInventory.GetMultiManyToOne(null, this);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductInventoryCollection GetMultiProductInventory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductInventory || forceFetch || _alwaysFetchProductInventory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productInventory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productInventory);
					}
				}
				_productInventory.SuppressClearInGetMulti=!forceFetch;
				_productInventory.EntityFactoryToUse = entityFactoryToUse;
				_productInventory.GetMultiManyToOne(null, this, filter);
				_productInventory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductInventory = true;
			}
			return _productInventory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductInventory'. These settings will be taken into account
		/// when the property ProductInventory is requested or GetMultiProductInventory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductInventory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productInventory.SortClauses=sortClauses;
			_productInventory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public virtual ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductListPriceHistory || forceFetch || _alwaysFetchProductListPriceHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productListPriceHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productListPriceHistory);
					}
				}
				_productListPriceHistory.SuppressClearInGetMulti=!forceFetch;
				_productListPriceHistory.GetMultiManyToOne(this);
				_productListPriceHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistory = true;
			}
			return _productListPriceHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductListPriceHistoryEntity'</returns>
		public virtual ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductListPriceHistory || forceFetch || _alwaysFetchProductListPriceHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productListPriceHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productListPriceHistory);
					}
				}
				_productListPriceHistory.SuppressClearInGetMulti=!forceFetch;
				_productListPriceHistory.GetMultiManyToOne(this, filter);
				_productListPriceHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistory = true;
			}
			return _productListPriceHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductListPriceHistory || forceFetch || _alwaysFetchProductListPriceHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productListPriceHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productListPriceHistory);
					}
				}
				_productListPriceHistory.SuppressClearInGetMulti=!forceFetch;
				_productListPriceHistory.EntityFactoryToUse = entityFactoryToUse;
				_productListPriceHistory.GetMultiManyToOne(this);
				_productListPriceHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistory = true;
			}
			return _productListPriceHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductListPriceHistoryCollection GetMultiProductListPriceHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductListPriceHistory || forceFetch || _alwaysFetchProductListPriceHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productListPriceHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productListPriceHistory);
					}
				}
				_productListPriceHistory.SuppressClearInGetMulti=!forceFetch;
				_productListPriceHistory.EntityFactoryToUse = entityFactoryToUse;
				_productListPriceHistory.GetMultiManyToOne(this, filter);
				_productListPriceHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedProductListPriceHistory = true;
			}
			return _productListPriceHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductListPriceHistory'. These settings will be taken into account
		/// when the property ProductListPriceHistory is requested or GetMultiProductListPriceHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductListPriceHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productListPriceHistory.SortClauses=sortClauses;
			_productListPriceHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productProductPhoto.GetMultiManyToOne(this, null);
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
				_productProductPhoto.GetMultiManyToOne(this, null, filter);
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
				_productProductPhoto.GetMultiManyToOne(this, null);
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
				_productProductPhoto.GetMultiManyToOne(this, null, filter);
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
		/// Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public virtual ProductReviewCollection GetMultiProductReview(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductReview || forceFetch || _alwaysFetchProductReview) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productReview.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productReview);
					}
				}
				_productReview.SuppressClearInGetMulti=!forceFetch;
				_productReview.GetMultiManyToOne(this);
				_productReview.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReview = true;
			}
			return _productReview;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ProductReviewEntity'</returns>
		public virtual ProductReviewCollection GetMultiProductReview(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductReview || forceFetch || _alwaysFetchProductReview) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productReview.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productReview);
					}
				}
				_productReview.SuppressClearInGetMulti=!forceFetch;
				_productReview.GetMultiManyToOne(this, filter);
				_productReview.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReview = true;
			}
			return _productReview;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductReviewCollection GetMultiProductReview(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductReview || forceFetch || _alwaysFetchProductReview) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productReview.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productReview);
					}
				}
				_productReview.SuppressClearInGetMulti=!forceFetch;
				_productReview.EntityFactoryToUse = entityFactoryToUse;
				_productReview.GetMultiManyToOne(this);
				_productReview.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReview = true;
			}
			return _productReview;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductReviewCollection GetMultiProductReview(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedProductReview || forceFetch || _alwaysFetchProductReview) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productReview.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productReview);
					}
				}
				_productReview.SuppressClearInGetMulti=!forceFetch;
				_productReview.EntityFactoryToUse = entityFactoryToUse;
				_productReview.GetMultiManyToOne(this, filter);
				_productReview.SuppressClearInGetMulti=false;
				_alreadyFetchedProductReview = true;
			}
			return _productReview;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductReview'. These settings will be taken into account
		/// when the property ProductReview is requested or GetMultiProductReview is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductReview(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productReview.SortClauses=sortClauses;
			_productReview.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public virtual TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedTransactionHistory || forceFetch || _alwaysFetchTransactionHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_transactionHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_transactionHistory);
					}
				}
				_transactionHistory.SuppressClearInGetMulti=!forceFetch;
				_transactionHistory.GetMultiManyToOne(this);
				_transactionHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistory = true;
			}
			return _transactionHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'TransactionHistoryEntity'</returns>
		public virtual TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedTransactionHistory || forceFetch || _alwaysFetchTransactionHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_transactionHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_transactionHistory);
					}
				}
				_transactionHistory.SuppressClearInGetMulti=!forceFetch;
				_transactionHistory.GetMultiManyToOne(this, filter);
				_transactionHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistory = true;
			}
			return _transactionHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedTransactionHistory || forceFetch || _alwaysFetchTransactionHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_transactionHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_transactionHistory);
					}
				}
				_transactionHistory.SuppressClearInGetMulti=!forceFetch;
				_transactionHistory.EntityFactoryToUse = entityFactoryToUse;
				_transactionHistory.GetMultiManyToOne(this);
				_transactionHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistory = true;
			}
			return _transactionHistory;
		}


		/// <summary>
		/// Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual TransactionHistoryCollection GetMultiTransactionHistory(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedTransactionHistory || forceFetch || _alwaysFetchTransactionHistory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_transactionHistory.ParticipatesInTransaction)
					{
						base.Transaction.Add(_transactionHistory);
					}
				}
				_transactionHistory.SuppressClearInGetMulti=!forceFetch;
				_transactionHistory.EntityFactoryToUse = entityFactoryToUse;
				_transactionHistory.GetMultiManyToOne(this, filter);
				_transactionHistory.SuppressClearInGetMulti=false;
				_alreadyFetchedTransactionHistory = true;
			}
			return _transactionHistory;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'TransactionHistory'. These settings will be taken into account
		/// when the property TransactionHistory is requested or GetMultiTransactionHistory is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersTransactionHistory(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_transactionHistory.SortClauses=sortClauses;
			_transactionHistory.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public virtual WorkOrderCollection GetMultiWorkOrder(bool forceFetch)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				_workOrder.GetMultiManyToOne(this, null);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'WorkOrderEntity'</returns>
		public virtual WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				_workOrder.GetMultiManyToOne(this, null, filter);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				_workOrder.EntityFactoryToUse = entityFactoryToUse;
				_workOrder.GetMultiManyToOne(this, null);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}


		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual WorkOrderCollection GetMultiWorkOrder(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedWorkOrder || forceFetch || _alwaysFetchWorkOrder) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_workOrder.ParticipatesInTransaction)
					{
						base.Transaction.Add(_workOrder);
					}
				}
				_workOrder.SuppressClearInGetMulti=!forceFetch;
				_workOrder.EntityFactoryToUse = entityFactoryToUse;
				_workOrder.GetMultiManyToOne(this, null, filter);
				_workOrder.SuppressClearInGetMulti=false;
				_alreadyFetchedWorkOrder = true;
			}
			return _workOrder;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'WorkOrder'. These settings will be taken into account
		/// when the property WorkOrder is requested or GetMultiWorkOrder is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersWorkOrder(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_workOrder.SortClauses=sortClauses;
			_workOrder.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_productVendor.GetMultiManyToOne(this, null, null);
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
				_productVendor.GetMultiManyToOne(this, null, null, filter);
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
				_productVendor.GetMultiManyToOne(this, null, null);
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
				_productVendor.GetMultiManyToOne(this, null, null, filter);
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
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.GetMultiManyToOne(this, null);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'PurchaseOrderDetailEntity'</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.GetMultiManyToOne(this, null, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetail.GetMultiManyToOne(this, null);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual PurchaseOrderDetailCollection GetMultiPurchaseOrderDetail(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedPurchaseOrderDetail || forceFetch || _alwaysFetchPurchaseOrderDetail) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_purchaseOrderDetail.ParticipatesInTransaction)
					{
						base.Transaction.Add(_purchaseOrderDetail);
					}
				}
				_purchaseOrderDetail.SuppressClearInGetMulti=!forceFetch;
				_purchaseOrderDetail.EntityFactoryToUse = entityFactoryToUse;
				_purchaseOrderDetail.GetMultiManyToOne(this, null, filter);
				_purchaseOrderDetail.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderDetail = true;
			}
			return _purchaseOrderDetail;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'PurchaseOrderDetail'. These settings will be taken into account
		/// when the property PurchaseOrderDetail is requested or GetMultiPurchaseOrderDetail is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersPurchaseOrderDetail(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_purchaseOrderDetail.SortClauses=sortClauses;
			_purchaseOrderDetail.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public virtual ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch)
		{
 			if( ( !_alreadyFetchedShoppingCartItem || forceFetch || _alwaysFetchShoppingCartItem) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shoppingCartItem.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shoppingCartItem);
					}
				}
				_shoppingCartItem.SuppressClearInGetMulti=!forceFetch;
				_shoppingCartItem.GetMultiManyToOne(this);
				_shoppingCartItem.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItem = true;
			}
			return _shoppingCartItem;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of type 'ShoppingCartItemEntity'</returns>
		public virtual ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedShoppingCartItem || forceFetch || _alwaysFetchShoppingCartItem) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shoppingCartItem.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shoppingCartItem);
					}
				}
				_shoppingCartItem.SuppressClearInGetMulti=!forceFetch;
				_shoppingCartItem.GetMultiManyToOne(this, filter);
				_shoppingCartItem.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItem = true;
			}
			return _shoppingCartItem;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedShoppingCartItem || forceFetch || _alwaysFetchShoppingCartItem) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shoppingCartItem.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shoppingCartItem);
					}
				}
				_shoppingCartItem.SuppressClearInGetMulti=!forceFetch;
				_shoppingCartItem.EntityFactoryToUse = entityFactoryToUse;
				_shoppingCartItem.GetMultiManyToOne(this);
				_shoppingCartItem.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItem = true;
			}
			return _shoppingCartItem;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToOne() routine.</param>
		/// <param name="filter">Extra filter to limit the resultset.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ShoppingCartItemCollection GetMultiShoppingCartItem(bool forceFetch, IEntityFactory entityFactoryToUse, IPredicateExpression filter)
		{
 			if( ( !_alreadyFetchedShoppingCartItem || forceFetch || _alwaysFetchShoppingCartItem) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_shoppingCartItem.ParticipatesInTransaction)
					{
						base.Transaction.Add(_shoppingCartItem);
					}
				}
				_shoppingCartItem.SuppressClearInGetMulti=!forceFetch;
				_shoppingCartItem.EntityFactoryToUse = entityFactoryToUse;
				_shoppingCartItem.GetMultiManyToOne(this, filter);
				_shoppingCartItem.SuppressClearInGetMulti=false;
				_alreadyFetchedShoppingCartItem = true;
			}
			return _shoppingCartItem;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ShoppingCartItem'. These settings will be taken into account
		/// when the property ShoppingCartItem is requested or GetMultiShoppingCartItem is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersShoppingCartItem(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_shoppingCartItem.SortClauses=sortClauses;
			_shoppingCartItem.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_specialOfferProduct.GetMultiManyToOne(this, null);
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
				_specialOfferProduct.GetMultiManyToOne(this, null, filter);
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
				_specialOfferProduct.GetMultiManyToOne(this, null);
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
				_specialOfferProduct.GetMultiManyToOne(this, null, filter);
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
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure__(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure__ || forceFetch || _alwaysFetchUnitMeasure__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure__);
					}
				}
				_unitMeasure__.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure__.GetMultiManyToManyUsingProduct__(this);
				_unitMeasure__.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure__ = true;
			}
			return _unitMeasure__;
		}


		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure__(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasure__ || forceFetch || _alwaysFetchUnitMeasure__) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure__.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure__);
					}
				}
				_unitMeasure__.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure__.EntityFactoryToUse = entityFactoryToUse;
				_unitMeasure__.GetMultiManyToManyUsingProduct__(this);
				_unitMeasure__.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure__ = true;
			}
			return _unitMeasure__;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'UnitMeasure__'. These settings will be taken into account
		/// when the property UnitMeasure__ is requested or GetMultiUnitMeasure__ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasure__(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasure__.SortClauses=sortClauses;
			_unitMeasure__.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure___(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure___ || forceFetch || _alwaysFetchUnitMeasure___) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure___);
					}
				}
				_unitMeasure___.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure___.GetMultiManyToManyUsingProduct___(this);
				_unitMeasure___.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure___ = true;
			}
			return _unitMeasure___;
		}


		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure___(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasure___ || forceFetch || _alwaysFetchUnitMeasure___) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure___.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure___);
					}
				}
				_unitMeasure___.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure___.EntityFactoryToUse = entityFactoryToUse;
				_unitMeasure___.GetMultiManyToManyUsingProduct___(this);
				_unitMeasure___.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure___ = true;
			}
			return _unitMeasure___;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'UnitMeasure___'. These settings will be taken into account
		/// when the property UnitMeasure___ is requested or GetMultiUnitMeasure___ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasure___(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasure___.SortClauses=sortClauses;
			_unitMeasure___.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'DocumentEntity'</returns>
		public virtual DocumentCollection GetMultiDocument(bool forceFetch)
		{
 			if( ( !_alreadyFetchedDocument || forceFetch || _alwaysFetchDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_document.ParticipatesInTransaction)
					{
						base.Transaction.Add(_document);
					}
				}
				_document.SuppressClearInGetMulti=!forceFetch;
				_document.GetMultiManyToManyUsingProduct(this);
				_document.SuppressClearInGetMulti=false;
				_alreadyFetchedDocument = true;
			}
			return _document;
		}


		/// <summary>
		/// Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual DocumentCollection GetMultiDocument(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedDocument || forceFetch || _alwaysFetchDocument) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_document.ParticipatesInTransaction)
					{
						base.Transaction.Add(_document);
					}
				}
				_document.SuppressClearInGetMulti=!forceFetch;
				_document.EntityFactoryToUse = entityFactoryToUse;
				_document.GetMultiManyToManyUsingProduct(this);
				_document.SuppressClearInGetMulti=false;
				_alreadyFetchedDocument = true;
			}
			return _document;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Document'. These settings will be taken into account
		/// when the property Document is requested or GetMultiDocument is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersDocument(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_document.SortClauses=sortClauses;
			_document.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'LocationEntity'</returns>
		public virtual LocationCollection GetMultiLocation(bool forceFetch)
		{
 			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_location.ParticipatesInTransaction)
					{
						base.Transaction.Add(_location);
					}
				}
				_location.SuppressClearInGetMulti=!forceFetch;
				_location.GetMultiManyToManyUsingProduct(this);
				_location.SuppressClearInGetMulti=false;
				_alreadyFetchedLocation = true;
			}
			return _location;
		}


		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual LocationCollection GetMultiLocation(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedLocation || forceFetch || _alwaysFetchLocation) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_location.ParticipatesInTransaction)
					{
						base.Transaction.Add(_location);
					}
				}
				_location.SuppressClearInGetMulti=!forceFetch;
				_location.EntityFactoryToUse = entityFactoryToUse;
				_location.GetMultiManyToManyUsingProduct(this);
				_location.SuppressClearInGetMulti=false;
				_alreadyFetchedLocation = true;
			}
			return _location;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'Location'. These settings will be taken into account
		/// when the property Location is requested or GetMultiLocation is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersLocation(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_location.SortClauses=sortClauses;
			_location.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ProductPhotoEntity'</returns>
		public virtual ProductPhotoCollection GetMultiProductPhoto(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductPhoto || forceFetch || _alwaysFetchProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productPhoto);
					}
				}
				_productPhoto.SuppressClearInGetMulti=!forceFetch;
				_productPhoto.GetMultiManyToManyUsingProduct(this);
				_productPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductPhoto = true;
			}
			return _productPhoto;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ProductPhotoCollection GetMultiProductPhoto(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedProductPhoto || forceFetch || _alwaysFetchProductPhoto) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_productPhoto.ParticipatesInTransaction)
					{
						base.Transaction.Add(_productPhoto);
					}
				}
				_productPhoto.SuppressClearInGetMulti=!forceFetch;
				_productPhoto.EntityFactoryToUse = entityFactoryToUse;
				_productPhoto.GetMultiManyToManyUsingProduct(this);
				_productPhoto.SuppressClearInGetMulti=false;
				_alreadyFetchedProductPhoto = true;
			}
			return _productPhoto;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ProductPhoto'. These settings will be taken into account
		/// when the property ProductPhoto is requested or GetMultiProductPhoto is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersProductPhoto(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_productPhoto.SortClauses=sortClauses;
			_productPhoto.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'ScrapReasonEntity'</returns>
		public virtual ScrapReasonCollection GetMultiScrapReason(bool forceFetch)
		{
 			if( ( !_alreadyFetchedScrapReason || forceFetch || _alwaysFetchScrapReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_scrapReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_scrapReason);
					}
				}
				_scrapReason.SuppressClearInGetMulti=!forceFetch;
				_scrapReason.GetMultiManyToManyUsingProduct(this);
				_scrapReason.SuppressClearInGetMulti=false;
				_alreadyFetchedScrapReason = true;
			}
			return _scrapReason;
		}


		/// <summary>
		/// Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual ScrapReasonCollection GetMultiScrapReason(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedScrapReason || forceFetch || _alwaysFetchScrapReason) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_scrapReason.ParticipatesInTransaction)
					{
						base.Transaction.Add(_scrapReason);
					}
				}
				_scrapReason.SuppressClearInGetMulti=!forceFetch;
				_scrapReason.EntityFactoryToUse = entityFactoryToUse;
				_scrapReason.GetMultiManyToManyUsingProduct(this);
				_scrapReason.SuppressClearInGetMulti=false;
				_alreadyFetchedScrapReason = true;
			}
			return _scrapReason;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'ScrapReason'. These settings will be taken into account
		/// when the property ScrapReason is requested or GetMultiScrapReason is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersScrapReason(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_scrapReason.SortClauses=sortClauses;
			_scrapReason.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
		}

	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'UnitMeasureEntity'</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure____(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure____ || forceFetch || _alwaysFetchUnitMeasure____) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure____);
					}
				}
				_unitMeasure____.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure____.GetMultiManyToManyUsingProduct____(this);
				_unitMeasure____.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure____ = true;
			}
			return _unitMeasure____;
		}


		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual UnitMeasureCollection GetMultiUnitMeasure____(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedUnitMeasure____ || forceFetch || _alwaysFetchUnitMeasure____) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_unitMeasure____.ParticipatesInTransaction)
					{
						base.Transaction.Add(_unitMeasure____);
					}
				}
				_unitMeasure____.SuppressClearInGetMulti=!forceFetch;
				_unitMeasure____.EntityFactoryToUse = entityFactoryToUse;
				_unitMeasure____.GetMultiManyToManyUsingProduct____(this);
				_unitMeasure____.SuppressClearInGetMulti=false;
				_alreadyFetchedUnitMeasure____ = true;
			}
			return _unitMeasure____;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'UnitMeasure____'. These settings will be taken into account
		/// when the property UnitMeasure____ is requested or GetMultiUnitMeasure____ is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersUnitMeasure____(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_unitMeasure____.SortClauses=sortClauses;
			_unitMeasure____.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
				_vendor.GetMultiManyToManyUsingProduct(this);
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
				_vendor.GetMultiManyToManyUsingProduct(this);
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

	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.
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
				_purchaseOrderHeader.GetMultiManyToManyUsingProduct(this);
				_purchaseOrderHeader.SuppressClearInGetMulti=false;
				_alreadyFetchedPurchaseOrderHeader = true;
			}
			return _purchaseOrderHeader;
		}


		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
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
				_purchaseOrderHeader.GetMultiManyToManyUsingProduct(this);
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
		/// Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <returns>Filled collection with all related entities of type 'SpecialOfferEntity'</returns>
		public virtual SpecialOfferCollection GetMultiSpecialOffer(bool forceFetch)
		{
 			if( ( !_alreadyFetchedSpecialOffer || forceFetch || _alwaysFetchSpecialOffer) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOffer.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOffer);
					}
				}
				_specialOffer.SuppressClearInGetMulti=!forceFetch;
				_specialOffer.GetMultiManyToManyUsingProduct(this);
				_specialOffer.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOffer = true;
			}
			return _specialOffer;
		}


		/// <summary>
		/// Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the collection and will rerun the complete query instead</param>
		/// <param name="entityFactoryToUse">The entity factory to use for the GetMultiManyToMany() routine.</param>
		/// <returns>Filled collection with all related entities of the type constructed by the passed in entity factory</returns>
		public virtual SpecialOfferCollection GetMultiSpecialOffer(bool forceFetch, IEntityFactory entityFactoryToUse)
		{
 			if( ( !_alreadyFetchedSpecialOffer || forceFetch || _alwaysFetchSpecialOffer) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				if(base.ParticipatesInTransaction)
				{
					if(!_specialOffer.ParticipatesInTransaction)
					{
						base.Transaction.Add(_specialOffer);
					}
				}
				_specialOffer.SuppressClearInGetMulti=!forceFetch;
				_specialOffer.EntityFactoryToUse = entityFactoryToUse;
				_specialOffer.GetMultiManyToManyUsingProduct(this);
				_specialOffer.SuppressClearInGetMulti=false;
				_alreadyFetchedSpecialOffer = true;
			}
			return _specialOffer;
		}


		/// <summary>
		/// Sets the collection parameters for the collection for 'SpecialOffer'. These settings will be taken into account
		/// when the property SpecialOffer is requested or GetMultiSpecialOffer is called.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn"> The maximum number of items to return. When set to 0, this parameter is ignored</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When not specified (null), no sorting is applied.</param>
		public virtual void SetCollectionParametersSpecialOffer(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			_specialOffer.SortClauses=sortClauses;
			_specialOffer.MaxNumberOfItemsToReturn=maxNumberOfItemsToReturn;
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
	
		/// <summary>
		/// Retrieves the related entity of type 'ProductSubcategoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'ProductSubcategoryEntity' which is related to this entity.</returns>
		public virtual ProductSubcategoryEntity GetSingleProductSubcategory()
		{
			return GetSingleProductSubcategory(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'ProductSubcategoryEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'ProductSubcategoryEntity' which is related to this entity.</returns>
		public virtual ProductSubcategoryEntity GetSingleProductSubcategory(bool forceFetch)
		{
 			if( ( !_alreadyFetchedProductSubcategory || forceFetch || _alwaysFetchProductSubcategory) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				ProductSubcategoryEntity newEntity = new ProductSubcategoryEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.ProductSubcategoryID);
				this.ProductSubcategory = newEntity;

				_alreadyFetchedProductSubcategory = true;
			}
			return _productSubcategory;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure()
		{
			return GetSingleUnitMeasure(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure || forceFetch || _alwaysFetchUnitMeasure) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.SizeUnitMeasureCode);
				this.UnitMeasure = newEntity;

				_alreadyFetchedUnitMeasure = true;
			}
			return _unitMeasure;
		}
	
		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure_()
		{
			return GetSingleUnitMeasure_(false);
		}


		/// <summary>
		/// Retrieves the related entity of type 'UnitMeasureEntity', using a relation of type 'n:1'
		/// </summary>
		/// <param name="forceFetch">if true, it will discard any changes currently in the currently loaded related entity and will refetch the entity from 
		/// the persistent storage</param>
		/// <returns>A fetched entity of type 'UnitMeasureEntity' which is related to this entity.</returns>
		public virtual UnitMeasureEntity GetSingleUnitMeasure_(bool forceFetch)
		{
 			if( ( !_alreadyFetchedUnitMeasure_ || forceFetch || _alwaysFetchUnitMeasure_) && !base.IsSerializing && !base.IsDeserializing )
			{
				// refetch it.
				UnitMeasureEntity newEntity = new UnitMeasureEntity();
				if(base.ParticipatesInTransaction)
				{
					base.Transaction.Add(newEntity);
				}
				newEntity.FetchUsingPK(this.WeightUnitMeasureCode);
				this.UnitMeasure_ = newEntity;

				_alreadyFetchedUnitMeasure_ = true;
			}
			return _unitMeasure_;
		}
	
	
	
		#region Data binding change event raising methods
	
		/// <summary>
		/// Event thrower for the ProductIDChanged event, which is thrown when ProductID changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductIDChanged()
		{
			if(ProductIDChanged!=null)
			{
				ProductIDChanged(this, new EventArgs());
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
		/// Event thrower for the ProductNumberChanged event, which is thrown when ProductNumber changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductNumberChanged()
		{
			if(ProductNumberChanged!=null)
			{
				ProductNumberChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the MakeFlagChanged event, which is thrown when MakeFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnMakeFlagChanged()
		{
			if(MakeFlagChanged!=null)
			{
				MakeFlagChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the FinishedGoodsFlagChanged event, which is thrown when FinishedGoodsFlag changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnFinishedGoodsFlagChanged()
		{
			if(FinishedGoodsFlagChanged!=null)
			{
				FinishedGoodsFlagChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ColorChanged event, which is thrown when Color changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnColorChanged()
		{
			if(ColorChanged!=null)
			{
				ColorChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SafetyStockLevelChanged event, which is thrown when SafetyStockLevel changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSafetyStockLevelChanged()
		{
			if(SafetyStockLevelChanged!=null)
			{
				SafetyStockLevelChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ReorderPointChanged event, which is thrown when ReorderPoint changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnReorderPointChanged()
		{
			if(ReorderPointChanged!=null)
			{
				ReorderPointChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StandardCostChanged event, which is thrown when StandardCost changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStandardCostChanged()
		{
			if(StandardCostChanged!=null)
			{
				StandardCostChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ListPriceChanged event, which is thrown when ListPrice changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnListPriceChanged()
		{
			if(ListPriceChanged!=null)
			{
				ListPriceChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SizeChanged event, which is thrown when Size changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSizeChanged()
		{
			if(SizeChanged!=null)
			{
				SizeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SizeUnitMeasureCodeChanged event, which is thrown when SizeUnitMeasureCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSizeUnitMeasureCodeChanged()
		{
			if(SizeUnitMeasureCodeChanged!=null)
			{
				SizeUnitMeasureCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the WeightUnitMeasureCodeChanged event, which is thrown when WeightUnitMeasureCode changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnWeightUnitMeasureCodeChanged()
		{
			if(WeightUnitMeasureCodeChanged!=null)
			{
				WeightUnitMeasureCodeChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the WeightChanged event, which is thrown when Weight changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnWeightChanged()
		{
			if(WeightChanged!=null)
			{
				WeightChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DaysToManufactureChanged event, which is thrown when DaysToManufacture changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDaysToManufactureChanged()
		{
			if(DaysToManufactureChanged!=null)
			{
				DaysToManufactureChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ProductLineChanged event, which is thrown when ProductLine changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnProductLineChanged()
		{
			if(ProductLineChanged!=null)
			{
				ProductLineChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the ClassChanged event, which is thrown when Class changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnClassChanged()
		{
			if(ClassChanged!=null)
			{
				ClassChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the StyleChanged event, which is thrown when Style changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnStyleChanged()
		{
			if(StyleChanged!=null)
			{
				StyleChanged(this, new EventArgs());
			}
		}
	
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
		/// Event thrower for the SellStartDateChanged event, which is thrown when SellStartDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSellStartDateChanged()
		{
			if(SellStartDateChanged!=null)
			{
				SellStartDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the SellEndDateChanged event, which is thrown when SellEndDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnSellEndDateChanged()
		{
			if(SellEndDateChanged!=null)
			{
				SellEndDateChanged(this, new EventArgs());
			}
		}
	
		/// <summary>
		/// Event thrower for the DiscontinuedDateChanged event, which is thrown when DiscontinuedDate changes value.
		/// Databinding related.
		/// </summary>
		protected virtual void OnDiscontinuedDateChanged()
		{
			if(DiscontinuedDateChanged!=null)
			{
				DiscontinuedDateChanged(this, new EventArgs());
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
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.AddProduct(base.Fields, base.Transaction);
		}

	
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity()
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateProduct(base.Fields, base.Transaction);
		}
		
		
		/// <summary>
		/// Performs the update action of an existing Entity to the persistent storage.
		/// </summary>
		/// <param name="updateRestriction">Predicate expression, meant for concurrency checks in an Update query</param>
		/// <returns>true if succeeded, false otherwise</returns>
		protected override bool UpdateEntity(IPredicate updateRestriction)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();
			return dao.UpdateProduct(base.Fields, base.Transaction, updateRestriction);
		}
	
	
		/// <summary>
		/// Initializes the class with empty data, as if it is a new Entity.
		/// </summary>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		private void InitClassEmpty(IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
	
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductEntity);
			base.IsNew=true;
			base.EntityFactoryToUse = entityFactoryToUse;
			base.Validator = new ProductValidator();
		}

	
		/// <summary>
		/// Initializes the the entity and fetches the data related to the entity in this entity.
		/// </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <param name="propertyDescriptorFactoryToUse">PropertyDescriptor factory to use in GetItemProperties method of contained collections. Complex databinding related.</param>
		/// <param name="entityFactoryToUse">The EntityFactory to use when creating entity objects during a GetMulti() call.</param>
		/// <param name="validator">The validator object for this ProductEntity</param>
		private void InitClassFetch(System.Int32 productID, ProductValidator validator, IPropertyDescriptorFactory propertyDescriptorFactoryToUse, IEntityFactory entityFactoryToUse)
		{
			InitClassMembers(propertyDescriptorFactoryToUse, entityFactoryToUse);
			base.Fields = EntityFieldsFactory.CreateEntityFieldsObject(EntityType.ProductEntity);
			bool wasSuccesful = Fetch(productID);
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
			_billOfMaterials.SetContainingEntityInfo(this, "Product");
			_alwaysFetchBillOfMaterials = false;
			_alreadyFetchedBillOfMaterials = false;
			_billOfMaterials_ = new BillOfMaterialsCollection(propertyDescriptorFactoryToUse, new BillOfMaterialsEntityFactory());
			_billOfMaterials_.SetContainingEntityInfo(this, "Product_");
			_alwaysFetchBillOfMaterials_ = false;
			_alreadyFetchedBillOfMaterials_ = false;
			_productCostHistory = new ProductCostHistoryCollection(propertyDescriptorFactoryToUse, new ProductCostHistoryEntityFactory());
			_productCostHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductCostHistory = false;
			_alreadyFetchedProductCostHistory = false;
			_productDocument = new ProductDocumentCollection(propertyDescriptorFactoryToUse, new ProductDocumentEntityFactory());
			_productDocument.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductDocument = false;
			_alreadyFetchedProductDocument = false;
			_productInventory = new ProductInventoryCollection(propertyDescriptorFactoryToUse, new ProductInventoryEntityFactory());
			_productInventory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductInventory = false;
			_alreadyFetchedProductInventory = false;
			_productListPriceHistory = new ProductListPriceHistoryCollection(propertyDescriptorFactoryToUse, new ProductListPriceHistoryEntityFactory());
			_productListPriceHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductListPriceHistory = false;
			_alreadyFetchedProductListPriceHistory = false;
			_productProductPhoto = new ProductProductPhotoCollection(propertyDescriptorFactoryToUse, new ProductProductPhotoEntityFactory());
			_productProductPhoto.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductProductPhoto = false;
			_alreadyFetchedProductProductPhoto = false;
			_productReview = new ProductReviewCollection(propertyDescriptorFactoryToUse, new ProductReviewEntityFactory());
			_productReview.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductReview = false;
			_alreadyFetchedProductReview = false;
			_transactionHistory = new TransactionHistoryCollection(propertyDescriptorFactoryToUse, new TransactionHistoryEntityFactory());
			_transactionHistory.SetContainingEntityInfo(this, "Product");
			_alwaysFetchTransactionHistory = false;
			_alreadyFetchedTransactionHistory = false;
			_workOrder = new WorkOrderCollection(propertyDescriptorFactoryToUse, new WorkOrderEntityFactory());
			_workOrder.SetContainingEntityInfo(this, "Product");
			_alwaysFetchWorkOrder = false;
			_alreadyFetchedWorkOrder = false;
			_productVendor = new ProductVendorCollection(propertyDescriptorFactoryToUse, new ProductVendorEntityFactory());
			_productVendor.SetContainingEntityInfo(this, "Product");
			_alwaysFetchProductVendor = false;
			_alreadyFetchedProductVendor = false;
			_purchaseOrderDetail = new PurchaseOrderDetailCollection(propertyDescriptorFactoryToUse, new PurchaseOrderDetailEntityFactory());
			_purchaseOrderDetail.SetContainingEntityInfo(this, "Product");
			_alwaysFetchPurchaseOrderDetail = false;
			_alreadyFetchedPurchaseOrderDetail = false;
			_shoppingCartItem = new ShoppingCartItemCollection(propertyDescriptorFactoryToUse, new ShoppingCartItemEntityFactory());
			_shoppingCartItem.SetContainingEntityInfo(this, "Product");
			_alwaysFetchShoppingCartItem = false;
			_alreadyFetchedShoppingCartItem = false;
			_specialOfferProduct = new SpecialOfferProductCollection(propertyDescriptorFactoryToUse, new SpecialOfferProductEntityFactory());
			_specialOfferProduct.SetContainingEntityInfo(this, "Product");
			_alwaysFetchSpecialOfferProduct = false;
			_alreadyFetchedSpecialOfferProduct = false;
			_unitMeasure__ = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure__ = false;
			_alreadyFetchedUnitMeasure__ = false;
			_unitMeasure___ = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure___ = false;
			_alreadyFetchedUnitMeasure___ = false;
			_document = new DocumentCollection(propertyDescriptorFactoryToUse, new DocumentEntityFactory());
			_alwaysFetchDocument = false;
			_alreadyFetchedDocument = false;
			_location = new LocationCollection(propertyDescriptorFactoryToUse, new LocationEntityFactory());
			_alwaysFetchLocation = false;
			_alreadyFetchedLocation = false;
			_productPhoto = new ProductPhotoCollection(propertyDescriptorFactoryToUse, new ProductPhotoEntityFactory());
			_alwaysFetchProductPhoto = false;
			_alreadyFetchedProductPhoto = false;
			_scrapReason = new ScrapReasonCollection(propertyDescriptorFactoryToUse, new ScrapReasonEntityFactory());
			_alwaysFetchScrapReason = false;
			_alreadyFetchedScrapReason = false;
			_unitMeasure____ = new UnitMeasureCollection(propertyDescriptorFactoryToUse, new UnitMeasureEntityFactory());
			_alwaysFetchUnitMeasure____ = false;
			_alreadyFetchedUnitMeasure____ = false;
			_vendor = new VendorCollection(propertyDescriptorFactoryToUse, new VendorEntityFactory());
			_alwaysFetchVendor = false;
			_alreadyFetchedVendor = false;
			_purchaseOrderHeader = new PurchaseOrderHeaderCollection(propertyDescriptorFactoryToUse, new PurchaseOrderHeaderEntityFactory());
			_alwaysFetchPurchaseOrderHeader = false;
			_alreadyFetchedPurchaseOrderHeader = false;
			_specialOffer = new SpecialOfferCollection(propertyDescriptorFactoryToUse, new SpecialOfferEntityFactory());
			_alwaysFetchSpecialOffer = false;
			_alreadyFetchedSpecialOffer = false;
			_productModel = null;
			_alwaysFetchProductModel = false;
			_alreadyFetchedProductModel = false;
			_productSubcategory = null;
			_alwaysFetchProductSubcategory = false;
			_alreadyFetchedProductSubcategory = false;
			_unitMeasure = null;
			_alwaysFetchUnitMeasure = false;
			_alreadyFetchedUnitMeasure = false;
			_unitMeasure_ = null;
			_alwaysFetchUnitMeasure_ = false;
			_alreadyFetchedUnitMeasure_ = false;

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
					_productModel.UnsetRelatedEntity(this, "Product");
				}
				base.UnsetEntitySyncInformation("ProductModel", _productModel, ProductEntity.Relations.ProductModelEntityUsingProductModelID);
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
				base.SetEntitySyncInformation("ProductModel", _productModel, ProductEntity.Relations.ProductModelEntityUsingProductModelID);
				if(!_productModel.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductEntity.Relations.ProductModelEntityUsingProductModelID, _productModel);
				}
			}

			_alreadyFetchedProductModel = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _productSubcategory
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncProductSubcategory(bool signalRelatedEntity)
		{
			if(_productSubcategory != null)
			{
				// disconnect the entity from this entity
				_productSubcategory.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_productSubcategory.UnsetRelatedEntity(this, "Product");
				}
				base.UnsetEntitySyncInformation("ProductSubcategory", _productSubcategory, ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID);
				_productSubcategory = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _productSubcategory
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncProductSubcategory(IEntity relatedEntity)
		{
			DesetupSyncProductSubcategory(true);
			
			if(relatedEntity!=null)
			{
				_productSubcategory = (ProductSubcategoryEntity)relatedEntity;
				_productSubcategory.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("ProductSubcategory", _productSubcategory, ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID);
				if(!_productSubcategory.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductEntity.Relations.ProductSubcategoryEntityUsingProductSubcategoryID, _productSubcategory);
				}
			}

			_alreadyFetchedProductSubcategory = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _unitMeasure
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncUnitMeasure(bool signalRelatedEntity)
		{
			if(_unitMeasure != null)
			{
				// disconnect the entity from this entity
				_unitMeasure.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_unitMeasure.UnsetRelatedEntity(this, "Product");
				}
				base.UnsetEntitySyncInformation("UnitMeasure", _unitMeasure, ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
				_unitMeasure = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _unitMeasure
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure(IEntity relatedEntity)
		{
			DesetupSyncUnitMeasure(true);
			
			if(relatedEntity!=null)
			{
				_unitMeasure = (UnitMeasureEntity)relatedEntity;
				_unitMeasure.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("UnitMeasure", _unitMeasure, ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode);
				if(!_unitMeasure.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductEntity.Relations.UnitMeasureEntityUsingSizeUnitMeasureCode, _unitMeasure);
				}
			}

			_alreadyFetchedUnitMeasure = (relatedEntity != null);
		}

		/// <summary>
		/// Removes the sync logic for member _unitMeasure_
		/// </summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		private void DesetupSyncUnitMeasure_(bool signalRelatedEntity)
		{
			if(_unitMeasure_ != null)
			{
				// disconnect the entity from this entity
				_unitMeasure_.AfterSave-=new EventHandler(OnEntityAfterSave);
				if(signalRelatedEntity)
				{
					_unitMeasure_.UnsetRelatedEntity(this, "Product_");
				}
				base.UnsetEntitySyncInformation("UnitMeasure_", _unitMeasure_, ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
				_unitMeasure_ = null;
			}
		}
		
		
		/// <summary>
		/// setups the sync logic for member _unitMeasure_
		/// </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncUnitMeasure_(IEntity relatedEntity)
		{
			DesetupSyncUnitMeasure_(true);
			
			if(relatedEntity!=null)
			{
				_unitMeasure_ = (UnitMeasureEntity)relatedEntity;
				_unitMeasure_.AfterSave+=new EventHandler(OnEntityAfterSave);
				base.SetEntitySyncInformation("UnitMeasure_", _unitMeasure_, ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode);
				if(!_unitMeasure_.IsNew)
				{
					// sync now
					base.SyncFKFields(ProductEntity.Relations.UnitMeasureEntityUsingWeightUnitMeasureCode, _unitMeasure_);
				}
			}

			_alreadyFetchedUnitMeasure_ = (relatedEntity != null);
		}



	
		/// <summary>
		/// Fetches the entity from the persistent storage. Fetch simply reads the entity into an EntityFields object. 
		/// </summary>
		/// <param name="productID">PK value for Product which data should be fetched into this Product object</param>
		/// <returns>True if succeeded, false otherwise.</returns>
		private bool Fetch(System.Int32 productID)
		{
			ProductDAO dao = DAOFactory.CreateProductDAO();

			// Load EntityFields of Product
			dao.FetchProduct(base.Fields, base.Transaction, productID);

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
		public static ProductRelations Relations
		{
			get	{ return new ProductRelations(); }
		}

	
		/// <summary>
		/// The ProductID property of the Entity Product
		/// </summary>
		public virtual System.Int32 ProductID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ProductID, value))
				{
					OnProductIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The Name property of the Entity Product
		/// </summary>
		public virtual System.String Name
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Name);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Name because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Name, value))
				{
					OnNameChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductNumber property of the Entity Product
		/// </summary>
		public virtual System.String ProductNumber
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductNumber);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductNumber because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ProductNumber, value))
				{
					OnProductNumberChanged();
				}
			}
		}
	
		/// <summary>
		/// The MakeFlag property of the Entity Product
		/// </summary>
		public virtual System.Boolean MakeFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.MakeFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for MakeFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.MakeFlag, value))
				{
					OnMakeFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The FinishedGoodsFlag property of the Entity Product
		/// </summary>
		public virtual System.Boolean FinishedGoodsFlag
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.FinishedGoodsFlag);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for FinishedGoodsFlag because it is set to NULL.");
				}
				return (System.Boolean)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.FinishedGoodsFlag, value))
				{
					OnFinishedGoodsFlagChanged();
				}
			}
		}
	
		/// <summary>
		/// The Color property of the Entity Product
		/// </summary>
		public virtual System.String Color
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Color);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Color because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Color, value))
				{
					OnColorChanged();
				}
			}
		}
	
		/// <summary>
		/// The SafetyStockLevel property of the Entity Product
		/// </summary>
		public virtual System.Int16 SafetyStockLevel
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SafetyStockLevel);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SafetyStockLevel because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.SafetyStockLevel, value))
				{
					OnSafetyStockLevelChanged();
				}
			}
		}
	
		/// <summary>
		/// The ReorderPoint property of the Entity Product
		/// </summary>
		public virtual System.Int16 ReorderPoint
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ReorderPoint);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ReorderPoint because it is set to NULL.");
				}
				return (System.Int16)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ReorderPoint, value))
				{
					OnReorderPointChanged();
				}
			}
		}
	
		/// <summary>
		/// The StandardCost property of the Entity Product
		/// </summary>
		public virtual System.Decimal StandardCost
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.StandardCost);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for StandardCost because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.StandardCost, value))
				{
					OnStandardCostChanged();
				}
			}
		}
	
		/// <summary>
		/// The ListPrice property of the Entity Product
		/// </summary>
		public virtual System.Decimal ListPrice
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ListPrice);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ListPrice because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ListPrice, value))
				{
					OnListPriceChanged();
				}
			}
		}
	
		/// <summary>
		/// The Size property of the Entity Product
		/// </summary>
		public virtual System.String Size
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Size);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Size because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Size, value))
				{
					OnSizeChanged();
				}
			}
		}
	
		/// <summary>
		/// The SizeUnitMeasureCode property of the Entity Product
		/// </summary>
		public virtual System.String SizeUnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SizeUnitMeasureCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SizeUnitMeasureCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.SizeUnitMeasureCode, value))
				{
					OnSizeUnitMeasureCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The WeightUnitMeasureCode property of the Entity Product
		/// </summary>
		public virtual System.String WeightUnitMeasureCode
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.WeightUnitMeasureCode);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for WeightUnitMeasureCode because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.WeightUnitMeasureCode, value))
				{
					OnWeightUnitMeasureCodeChanged();
				}
			}
		}
	
		/// <summary>
		/// The Weight property of the Entity Product
		/// </summary>
		public virtual System.Decimal Weight
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Weight);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Weight because it is set to NULL.");
				}
				return (System.Decimal)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Weight, value))
				{
					OnWeightChanged();
				}
			}
		}
	
		/// <summary>
		/// The DaysToManufacture property of the Entity Product
		/// </summary>
		public virtual System.Int32 DaysToManufacture
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.DaysToManufacture);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DaysToManufacture because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.DaysToManufacture, value))
				{
					OnDaysToManufactureChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductLine property of the Entity Product
		/// </summary>
		public virtual System.String ProductLine
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductLine);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductLine because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ProductLine, value))
				{
					OnProductLineChanged();
				}
			}
		}
	
		/// <summary>
		/// The Class property of the Entity Product
		/// </summary>
		public virtual System.String Class
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Class);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Class because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Class, value))
				{
					OnClassChanged();
				}
			}
		}
	
		/// <summary>
		/// The Style property of the Entity Product
		/// </summary>
		public virtual System.String Style
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Style);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Style because it is set to NULL.");
				}
				return (System.String)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Style, value))
				{
					OnStyleChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductSubcategoryID property of the Entity Product
		/// </summary>
		public virtual System.Int32 ProductSubcategoryID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductSubcategoryID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductSubcategoryID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ProductSubcategoryID, value))
				{
					OnProductSubcategoryIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The ProductModelID property of the Entity Product
		/// </summary>
		public virtual System.Int32 ProductModelID
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ProductModelID);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ProductModelID because it is set to NULL.");
				}
				return (System.Int32)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ProductModelID, value))
				{
					OnProductModelIDChanged();
				}
			}
		}
	
		/// <summary>
		/// The SellStartDate property of the Entity Product
		/// </summary>
		public virtual System.DateTime SellStartDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SellStartDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SellStartDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.SellStartDate, value))
				{
					OnSellStartDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The SellEndDate property of the Entity Product
		/// </summary>
		public virtual System.DateTime SellEndDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.SellEndDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for SellEndDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.SellEndDate, value))
				{
					OnSellEndDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The DiscontinuedDate property of the Entity Product
		/// </summary>
		public virtual System.DateTime DiscontinuedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.DiscontinuedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for DiscontinuedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.DiscontinuedDate, value))
				{
					OnDiscontinuedDateChanged();
				}
			}
		}
	
		/// <summary>
		/// The Rowguid property of the Entity Product
		/// </summary>
		public virtual System.Guid Rowguid
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.Rowguid);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for Rowguid because it is set to NULL.");
				}
				return (System.Guid)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.Rowguid, value))
				{
					OnRowguidChanged();
				}
			}
		}
	
		/// <summary>
		/// The ModifiedDate property of the Entity Product
		/// </summary>
		public virtual System.DateTime ModifiedDate
		{
			get
			{
				object valueToReturn = base.GetCurrentFieldValue((int)ProductFieldIndex.ModifiedDate);
				if(valueToReturn == null)
				{
					throw new ORMFieldIsNullException("Cannot get the value for ModifiedDate because it is set to NULL.");
				}
				return (System.DateTime)valueToReturn;
			}
			set
			{
				if(base.SetNewFieldValue((int)ProductFieldIndex.ModifiedDate, value))
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
		/// Retrieves all related entities of type 'BillOfMaterialsEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiBillOfMaterials_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual BillOfMaterialsCollection BillOfMaterials_
		{
			get
			{
				return GetMultiBillOfMaterials_(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for BillOfMaterials_. When set to true, BillOfMaterials_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time BillOfMaterials_ is accessed. You can always execute
		/// a forced fetch by calling GetMultiBillOfMaterials_(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchBillOfMaterials_
		{
			get
			{
				return _alwaysFetchBillOfMaterials_;
			}
			set
			{
				_alwaysFetchBillOfMaterials_ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductCostHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductCostHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductCostHistoryCollection ProductCostHistory
		{
			get
			{
				return GetMultiProductCostHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductCostHistory. When set to true, ProductCostHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductCostHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductCostHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductCostHistory
		{
			get
			{
				return _alwaysFetchProductCostHistory;
			}
			set
			{
				_alwaysFetchProductCostHistory = value;
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
		/// Retrieves all related entities of type 'ProductInventoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductInventory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductInventoryCollection ProductInventory
		{
			get
			{
				return GetMultiProductInventory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductInventory. When set to true, ProductInventory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductInventory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductInventory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductInventory
		{
			get
			{
				return _alwaysFetchProductInventory;
			}
			set
			{
				_alwaysFetchProductInventory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductListPriceHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductListPriceHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductListPriceHistoryCollection ProductListPriceHistory
		{
			get
			{
				return GetMultiProductListPriceHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductListPriceHistory. When set to true, ProductListPriceHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductListPriceHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductListPriceHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductListPriceHistory
		{
			get
			{
				return _alwaysFetchProductListPriceHistory;
			}
			set
			{
				_alwaysFetchProductListPriceHistory = value;
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
		/// Retrieves all related entities of type 'ProductReviewEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductReview()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductReviewCollection ProductReview
		{
			get
			{
				return GetMultiProductReview(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductReview. When set to true, ProductReview is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductReview is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductReview(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductReview
		{
			get
			{
				return _alwaysFetchProductReview;
			}
			set
			{
				_alwaysFetchProductReview = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'TransactionHistoryEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiTransactionHistory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual TransactionHistoryCollection TransactionHistory
		{
			get
			{
				return GetMultiTransactionHistory(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for TransactionHistory. When set to true, TransactionHistory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time TransactionHistory is accessed. You can always execute
		/// a forced fetch by calling GetMultiTransactionHistory(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchTransactionHistory
		{
			get
			{
				return _alwaysFetchTransactionHistory;
			}
			set
			{
				_alwaysFetchTransactionHistory = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'WorkOrderEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiWorkOrder()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual WorkOrderCollection WorkOrder
		{
			get
			{
				return GetMultiWorkOrder(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for WorkOrder. When set to true, WorkOrder is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time WorkOrder is accessed. You can always execute
		/// a forced fetch by calling GetMultiWorkOrder(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchWorkOrder
		{
			get
			{
				return _alwaysFetchWorkOrder;
			}
			set
			{
				_alwaysFetchWorkOrder = value;
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
		/// Retrieves all related entities of type 'PurchaseOrderDetailEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiPurchaseOrderDetail()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual PurchaseOrderDetailCollection PurchaseOrderDetail
		{
			get
			{
				return GetMultiPurchaseOrderDetail(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for PurchaseOrderDetail. When set to true, PurchaseOrderDetail is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time PurchaseOrderDetail is accessed. You can always execute
		/// a forced fetch by calling GetMultiPurchaseOrderDetail(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchPurchaseOrderDetail
		{
			get
			{
				return _alwaysFetchPurchaseOrderDetail;
			}
			set
			{
				_alwaysFetchPurchaseOrderDetail = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ShoppingCartItemEntity' using a relation of type '1:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiShoppingCartItem()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ShoppingCartItemCollection ShoppingCartItem
		{
			get
			{
				return GetMultiShoppingCartItem(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ShoppingCartItem. When set to true, ShoppingCartItem is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ShoppingCartItem is accessed. You can always execute
		/// a forced fetch by calling GetMultiShoppingCartItem(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchShoppingCartItem
		{
			get
			{
				return _alwaysFetchShoppingCartItem;
			}
			set
			{
				_alwaysFetchShoppingCartItem = value;
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
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasure__()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual UnitMeasureCollection UnitMeasure__
		{
			get
			{
				return GetMultiUnitMeasure__(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure__. When set to true, UnitMeasure__ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure__ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasure__(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure__
		{
			get
			{
				return _alwaysFetchUnitMeasure__;
			}
			set
			{
				_alwaysFetchUnitMeasure__ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasure___()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual UnitMeasureCollection UnitMeasure___
		{
			get
			{
				return GetMultiUnitMeasure___(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure___. When set to true, UnitMeasure___ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure___ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasure___(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure___
		{
			get
			{
				return _alwaysFetchUnitMeasure___;
			}
			set
			{
				_alwaysFetchUnitMeasure___ = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'DocumentEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiDocument()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual DocumentCollection Document
		{
			get
			{
				return GetMultiDocument(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Document. When set to true, Document is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Document is accessed. You can always execute
		/// a forced fetch by calling GetMultiDocument(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchDocument
		{
			get
			{
				return _alwaysFetchDocument;
			}
			set
			{
				_alwaysFetchDocument = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'LocationEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiLocation()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual LocationCollection Location
		{
			get
			{
				return GetMultiLocation(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for Location. When set to true, Location is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time Location is accessed. You can always execute
		/// a forced fetch by calling GetMultiLocation(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchLocation
		{
			get
			{
				return _alwaysFetchLocation;
			}
			set
			{
				_alwaysFetchLocation = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ProductPhotoEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiProductPhoto()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ProductPhotoCollection ProductPhoto
		{
			get
			{
				return GetMultiProductPhoto(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductPhoto. When set to true, ProductPhoto is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductPhoto is accessed. You can always execute
		/// a forced fetch by calling GetMultiProductPhoto(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchProductPhoto
		{
			get
			{
				return _alwaysFetchProductPhoto;
			}
			set
			{
				_alwaysFetchProductPhoto = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'ScrapReasonEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiScrapReason()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual ScrapReasonCollection ScrapReason
		{
			get
			{
				return GetMultiScrapReason(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ScrapReason. When set to true, ScrapReason is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ScrapReason is accessed. You can always execute
		/// a forced fetch by calling GetMultiScrapReason(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchScrapReason
		{
			get
			{
				return _alwaysFetchScrapReason;
			}
			set
			{
				_alwaysFetchScrapReason = value;
			}	
		}
	
		/// <summary>
		/// Retrieves all related entities of type 'UnitMeasureEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiUnitMeasure____()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual UnitMeasureCollection UnitMeasure____
		{
			get
			{
				return GetMultiUnitMeasure____(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure____. When set to true, UnitMeasure____ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure____ is accessed. You can always execute
		/// a forced fetch by calling GetMultiUnitMeasure____(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchUnitMeasure____
		{
			get
			{
				return _alwaysFetchUnitMeasure____;
			}
			set
			{
				_alwaysFetchUnitMeasure____ = value;
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
	
		/// <summary>
		/// Retrieves all related entities of type 'PurchaseOrderHeaderEntity' using a relation of type 'm:n'.
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
		/// Retrieves all related entities of type 'SpecialOfferEntity' using a relation of type 'm:n'.
		/// </summary>
		/// <remarks>This property is added for databinding conveniance, however it is recommeded to use the method 'GetMultiSpecialOffer()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope.</remarks>
		public virtual SpecialOfferCollection SpecialOffer
		{
			get
			{
				return GetMultiSpecialOffer(false);
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for SpecialOffer. When set to true, SpecialOffer is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time SpecialOffer is accessed. You can always execute
		/// a forced fetch by calling GetMultiSpecialOffer(true).
		/// </summary>
		[Browsable(false)]
		public bool AlwaysFetchSpecialOffer
		{
			get
			{
				return _alwaysFetchSpecialOffer;
			}
			set
			{
				_alwaysFetchSpecialOffer = value;
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
							_productModel.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Product");
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
	
		/// <summary>
		/// Gets / sets related entity of type 'ProductSubcategoryEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleProductSubcategory()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual ProductSubcategoryEntity ProductSubcategory
		{
			get
			{
				return GetSingleProductSubcategory(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncProductSubcategory(value);
				}
				else
				{
					if(value==null)
					{
						if(_productSubcategory != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_productSubcategory.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Product");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for ProductSubcategory. When set to true, ProductSubcategory is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time ProductSubcategory is accessed. You can always execute
		/// a forced fetch by calling GetSingleProductSubcategory(true).
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
		/// Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get
			{
				return GetSingleUnitMeasure(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_unitMeasure.UnsetRelatedEntity(this, "Product");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Product");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure. When set to true, UnitMeasure is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure(true).
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
		/// Gets / sets related entity of type 'UnitMeasureEntity'. This property is not visible in databinded grids.
		/// Setting this property to a new object will make the load-on-demand feature to stop fetching data from the database, until you set this
		/// property to null. Setting this property to an entity will make sure that FK-PK relations are synchronized when appropriate.
		/// </summary>
		/// <remarks>This property is added for conveniance, however it is recommeded to use the method 'GetSingleUnitMeasure_()', because 
		/// this property is rather expensive and a method tells the user to cache the result when it has to be used more than once in the
		/// same scope. The property is marked non-browsable to make it hidden in binded controls, f.e. datagrids.</remarks>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure_
		{
			get
			{
				return GetSingleUnitMeasure_(false);
			}
			set
			{
				if(base.IsDeserializing)
				{
					SetupSyncUnitMeasure_(value);
				}
				else
				{
					if(value==null)
					{
						if(_unitMeasure_ != null)
						{
							// signal the related entity to unset the sync info. Because this will boil down to the collection object, this class
							// get notified by the collection class, which will then clean up the sync info from this object to the related object.
							_unitMeasure_.UnsetRelatedEntity(this, "Product_");
						}
					}
					else
					{
						// just call SetRelatedEntity, as it will bubble down to the collection which will call our SetRelatedEntity, which
						// will do the actual set action
						((IEntity)value).SetRelatedEntity(this, "Product_");
					}
				}
			}
		}

		/// <summary>
		/// Gets / sets the lazy loading flag for UnitMeasure_. When set to true, UnitMeasure_ is always refetched from the 
		/// persistent storage. When set to false, the data is only fetched the first time UnitMeasure_ is accessed. You can always execute
		/// a forced fetch by calling GetSingleUnitMeasure_(true).
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
	
	
		#endregion
	}
}
