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
// Code is generated on: woensdag 4 september 2019 12:09:46
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.ComponentModel;

using LLBL2003.AdventureWorks2008.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.FactoryClasses
{
	/// <summary>
	/// class which creates different sets of property descriptor sets. Required for complex databinding.  
	/// </summary>
	[Serializable]
	public class PropertyDescriptorFactory : IPropertyDescriptorFactory
	{
		/// <summary>
		/// CTor
		/// </summary>
		public PropertyDescriptorFactory()
		{
		}


		/// <summary>
		/// Creates a new propertydescriptorcollection using the specialized methods of the types stored INSIDE the type specified.
		/// </summary>
		/// <param name="typeOfCollection">type which contains other types which properties we're interested in.</param>
		/// <returns>filled propertydescriptorcollection of type inside the type specified.</returns>
		public virtual PropertyDescriptorCollection GetItemProperties(Type typeOfCollection)
		{
			PropertyDescriptorCollection toReturn = null;
			switch(typeOfCollection.UnderlyingSystemType.Name)
			{
				
				case "AddressCollection":
					toReturn = GetPropertyDescriptors(new AddressEntity(), typeof(AddressEntity));
					break;

				case "AddressTypeCollection":
					toReturn = GetPropertyDescriptors(new AddressTypeEntity(), typeof(AddressTypeEntity));
					break;

				case "AWBuildVersionCollection":
					toReturn = GetPropertyDescriptors(new AWBuildVersionEntity(), typeof(AWBuildVersionEntity));
					break;

				case "BillOfMaterialsCollection":
					toReturn = GetPropertyDescriptors(new BillOfMaterialsEntity(), typeof(BillOfMaterialsEntity));
					break;

				case "ContactCollection":
					toReturn = GetPropertyDescriptors(new ContactEntity(), typeof(ContactEntity));
					break;

				case "ContactCreditCardCollection":
					toReturn = GetPropertyDescriptors(new ContactCreditCardEntity(), typeof(ContactCreditCardEntity));
					break;

				case "ContactTypeCollection":
					toReturn = GetPropertyDescriptors(new ContactTypeEntity(), typeof(ContactTypeEntity));
					break;

				case "CountryRegionCollection":
					toReturn = GetPropertyDescriptors(new CountryRegionEntity(), typeof(CountryRegionEntity));
					break;

				case "CountryRegionCurrencyCollection":
					toReturn = GetPropertyDescriptors(new CountryRegionCurrencyEntity(), typeof(CountryRegionCurrencyEntity));
					break;

				case "CreativeAddressesCollection":
					toReturn = GetPropertyDescriptors(new CreativeAddressesEntity(), typeof(CreativeAddressesEntity));
					break;

				case "CreditCardCollection":
					toReturn = GetPropertyDescriptors(new CreditCardEntity(), typeof(CreditCardEntity));
					break;

				case "CultureCollection":
					toReturn = GetPropertyDescriptors(new CultureEntity(), typeof(CultureEntity));
					break;

				case "CurrencyCollection":
					toReturn = GetPropertyDescriptors(new CurrencyEntity(), typeof(CurrencyEntity));
					break;

				case "CurrencyRateCollection":
					toReturn = GetPropertyDescriptors(new CurrencyRateEntity(), typeof(CurrencyRateEntity));
					break;

				case "CustomerCollection":
					toReturn = GetPropertyDescriptors(new CustomerEntity(), typeof(CustomerEntity));
					break;

				case "CustomerAddressCollection":
					toReturn = GetPropertyDescriptors(new CustomerAddressEntity(), typeof(CustomerAddressEntity));
					break;

				case "DatabaseLogCollection":
					toReturn = GetPropertyDescriptors(new DatabaseLogEntity(), typeof(DatabaseLogEntity));
					break;

				case "DepartmentCollection":
					toReturn = GetPropertyDescriptors(new DepartmentEntity(), typeof(DepartmentEntity));
					break;

				case "DocumentCollection":
					toReturn = GetPropertyDescriptors(new DocumentEntity(), typeof(DocumentEntity));
					break;

				case "EmployeeCollection":
					toReturn = GetPropertyDescriptors(new EmployeeEntity(), typeof(EmployeeEntity));
					break;

				case "EmployeeAddressCollection":
					toReturn = GetPropertyDescriptors(new EmployeeAddressEntity(), typeof(EmployeeAddressEntity));
					break;

				case "EmployeeDepartmentHistoryCollection":
					toReturn = GetPropertyDescriptors(new EmployeeDepartmentHistoryEntity(), typeof(EmployeeDepartmentHistoryEntity));
					break;

				case "EmployeePayHistoryCollection":
					toReturn = GetPropertyDescriptors(new EmployeePayHistoryEntity(), typeof(EmployeePayHistoryEntity));
					break;

				case "ErrorLogCollection":
					toReturn = GetPropertyDescriptors(new ErrorLogEntity(), typeof(ErrorLogEntity));
					break;

				case "IllustrationCollection":
					toReturn = GetPropertyDescriptors(new IllustrationEntity(), typeof(IllustrationEntity));
					break;

				case "IndividualCollection":
					toReturn = GetPropertyDescriptors(new IndividualEntity(), typeof(IndividualEntity));
					break;

				case "JobCandidateCollection":
					toReturn = GetPropertyDescriptors(new JobCandidateEntity(), typeof(JobCandidateEntity));
					break;

				case "LocationCollection":
					toReturn = GetPropertyDescriptors(new LocationEntity(), typeof(LocationEntity));
					break;

				case "NameTestTabCollection":
					toReturn = GetPropertyDescriptors(new NameTestTabEntity(), typeof(NameTestTabEntity));
					break;

				case "NewSequentialIDTestCollection":
					toReturn = GetPropertyDescriptors(new NewSequentialIDTestEntity(), typeof(NewSequentialIDTestEntity));
					break;

				case "NonPresentTimeCollection":
					toReturn = GetPropertyDescriptors(new NonPresentTimeEntity(), typeof(NonPresentTimeEntity));
					break;

				case "NonPresentTimeHeaderCollection":
					toReturn = GetPropertyDescriptors(new NonPresentTimeHeaderEntity(), typeof(NonPresentTimeHeaderEntity));
					break;

				case "ProductCollection":
					toReturn = GetPropertyDescriptors(new ProductEntity(), typeof(ProductEntity));
					break;

				case "ProductCategoryCollection":
					toReturn = GetPropertyDescriptors(new ProductCategoryEntity(), typeof(ProductCategoryEntity));
					break;

				case "ProductCostHistoryCollection":
					toReturn = GetPropertyDescriptors(new ProductCostHistoryEntity(), typeof(ProductCostHistoryEntity));
					break;

				case "ProductDescriptionCollection":
					toReturn = GetPropertyDescriptors(new ProductDescriptionEntity(), typeof(ProductDescriptionEntity));
					break;

				case "ProductDocumentCollection":
					toReturn = GetPropertyDescriptors(new ProductDocumentEntity(), typeof(ProductDocumentEntity));
					break;

				case "ProductInventoryCollection":
					toReturn = GetPropertyDescriptors(new ProductInventoryEntity(), typeof(ProductInventoryEntity));
					break;

				case "ProductListPriceHistoryCollection":
					toReturn = GetPropertyDescriptors(new ProductListPriceHistoryEntity(), typeof(ProductListPriceHistoryEntity));
					break;

				case "ProductModelCollection":
					toReturn = GetPropertyDescriptors(new ProductModelEntity(), typeof(ProductModelEntity));
					break;

				case "ProductModelIllustrationCollection":
					toReturn = GetPropertyDescriptors(new ProductModelIllustrationEntity(), typeof(ProductModelIllustrationEntity));
					break;

				case "ProductModelProductDescriptionCultureCollection":
					toReturn = GetPropertyDescriptors(new ProductModelProductDescriptionCultureEntity(), typeof(ProductModelProductDescriptionCultureEntity));
					break;

				case "ProductPhotoCollection":
					toReturn = GetPropertyDescriptors(new ProductPhotoEntity(), typeof(ProductPhotoEntity));
					break;

				case "ProductProductPhotoCollection":
					toReturn = GetPropertyDescriptors(new ProductProductPhotoEntity(), typeof(ProductProductPhotoEntity));
					break;

				case "ProductReviewCollection":
					toReturn = GetPropertyDescriptors(new ProductReviewEntity(), typeof(ProductReviewEntity));
					break;

				case "ProductSubcategoryCollection":
					toReturn = GetPropertyDescriptors(new ProductSubcategoryEntity(), typeof(ProductSubcategoryEntity));
					break;

				case "ProductVendorCollection":
					toReturn = GetPropertyDescriptors(new ProductVendorEntity(), typeof(ProductVendorEntity));
					break;

				case "PurchaseOrderDetailCollection":
					toReturn = GetPropertyDescriptors(new PurchaseOrderDetailEntity(), typeof(PurchaseOrderDetailEntity));
					break;

				case "PurchaseOrderHeaderCollection":
					toReturn = GetPropertyDescriptors(new PurchaseOrderHeaderEntity(), typeof(PurchaseOrderHeaderEntity));
					break;

				case "ReasonCollection":
					toReturn = GetPropertyDescriptors(new ReasonEntity(), typeof(ReasonEntity));
					break;

				case "SalesOrderDetailCollection":
					toReturn = GetPropertyDescriptors(new SalesOrderDetailEntity(), typeof(SalesOrderDetailEntity));
					break;

				case "SalesOrderHeaderCollection":
					toReturn = GetPropertyDescriptors(new SalesOrderHeaderEntity(), typeof(SalesOrderHeaderEntity));
					break;

				case "SalesOrderHeaderSalesReasonCollection":
					toReturn = GetPropertyDescriptors(new SalesOrderHeaderSalesReasonEntity(), typeof(SalesOrderHeaderSalesReasonEntity));
					break;

				case "SalesPersonCollection":
					toReturn = GetPropertyDescriptors(new SalesPersonEntity(), typeof(SalesPersonEntity));
					break;

				case "SalesPersonQuotaHistoryCollection":
					toReturn = GetPropertyDescriptors(new SalesPersonQuotaHistoryEntity(), typeof(SalesPersonQuotaHistoryEntity));
					break;

				case "SalesReasonCollection":
					toReturn = GetPropertyDescriptors(new SalesReasonEntity(), typeof(SalesReasonEntity));
					break;

				case "SalesTaxRateCollection":
					toReturn = GetPropertyDescriptors(new SalesTaxRateEntity(), typeof(SalesTaxRateEntity));
					break;

				case "SalesTerritoryCollection":
					toReturn = GetPropertyDescriptors(new SalesTerritoryEntity(), typeof(SalesTerritoryEntity));
					break;

				case "SalesTerritoryHistoryCollection":
					toReturn = GetPropertyDescriptors(new SalesTerritoryHistoryEntity(), typeof(SalesTerritoryHistoryEntity));
					break;

				case "ScrapReasonCollection":
					toReturn = GetPropertyDescriptors(new ScrapReasonEntity(), typeof(ScrapReasonEntity));
					break;

				case "SequentialIDSubTypeCollection":
					toReturn = GetPropertyDescriptors(new SequentialIDSubTypeEntity(), typeof(SequentialIDSubTypeEntity));
					break;

				case "ShiftCollection":
					toReturn = GetPropertyDescriptors(new ShiftEntity(), typeof(ShiftEntity));
					break;

				case "ShipMethodCollection":
					toReturn = GetPropertyDescriptors(new ShipMethodEntity(), typeof(ShipMethodEntity));
					break;

				case "ShoppingCartItemCollection":
					toReturn = GetPropertyDescriptors(new ShoppingCartItemEntity(), typeof(ShoppingCartItemEntity));
					break;

				case "SpecialOfferCollection":
					toReturn = GetPropertyDescriptors(new SpecialOfferEntity(), typeof(SpecialOfferEntity));
					break;

				case "SpecialOfferProductCollection":
					toReturn = GetPropertyDescriptors(new SpecialOfferProductEntity(), typeof(SpecialOfferProductEntity));
					break;

				case "StateProvinceCollection":
					toReturn = GetPropertyDescriptors(new StateProvinceEntity(), typeof(StateProvinceEntity));
					break;

				case "StoreCollection":
					toReturn = GetPropertyDescriptors(new StoreEntity(), typeof(StoreEntity));
					break;

				case "StoreContactCollection":
					toReturn = GetPropertyDescriptors(new StoreContactEntity(), typeof(StoreContactEntity));
					break;

				case "TransactionHistoryCollection":
					toReturn = GetPropertyDescriptors(new TransactionHistoryEntity(), typeof(TransactionHistoryEntity));
					break;

				case "TransactionHistoryArchiveCollection":
					toReturn = GetPropertyDescriptors(new TransactionHistoryArchiveEntity(), typeof(TransactionHistoryArchiveEntity));
					break;

				case "UdtTestCollection":
					toReturn = GetPropertyDescriptors(new UdtTestEntity(), typeof(UdtTestEntity));
					break;

				case "UnitMeasureCollection":
					toReturn = GetPropertyDescriptors(new UnitMeasureEntity(), typeof(UnitMeasureEntity));
					break;

				case "UserDetailCollection":
					toReturn = GetPropertyDescriptors(new UserDetailEntity(), typeof(UserDetailEntity));
					break;

				case "VendorCollection":
					toReturn = GetPropertyDescriptors(new VendorEntity(), typeof(VendorEntity));
					break;

				case "VendorAddressCollection":
					toReturn = GetPropertyDescriptors(new VendorAddressEntity(), typeof(VendorAddressEntity));
					break;

				case "VendorContactCollection":
					toReturn = GetPropertyDescriptors(new VendorContactEntity(), typeof(VendorContactEntity));
					break;

				case "WorkOrderCollection":
					toReturn = GetPropertyDescriptors(new WorkOrderEntity(), typeof(WorkOrderEntity));
					break;

				case "WorkOrderRoutingCollection":
					toReturn = GetPropertyDescriptors(new WorkOrderRoutingEntity(), typeof(WorkOrderRoutingEntity));
					break;
				default:
					toReturn = new PropertyDescriptorCollection(null);
					break;
			}

			return toReturn;
		}


		/// <summary>
		/// Constructs the actual property descriptor collection.
		/// </summary>
		/// <param name="entityToCheck">entity instance which properties should be included in the collection</param>
		/// <param name="typeOfEntity">full type of the entity</param>
		/// <returns>filled in property descriptor collection</returns>
		public PropertyDescriptorCollection GetPropertyDescriptors(IEntity entityToCheck, Type typeOfEntity)
		{
			// get the descriptors of this instance
			PropertyDescriptorCollection instancePropertiesCollection = TypeDescriptor.GetProperties(typeOfEntity);
			ArrayList instanceProperties = new ArrayList();

			Hashtable namesAdded = new Hashtable();

			for(int i=0;i<entityToCheck.Fields.Count;i++)
			{
				instanceProperties.Add(new EntityPropertyDescriptor(entityToCheck.Fields[i], typeOfEntity));
				namesAdded.Add(entityToCheck.Fields[i].Name, entityToCheck.Fields[i].Name);
			}

			// now walk all properties in the property descriptor collection. Check if the name occurs in the hashtable. if not and if browsable, copy the descriptor over.
			foreach(PropertyDescriptor property in instancePropertiesCollection)
			{
				if(!namesAdded.ContainsKey(property.Name))
				{
					if(!property.IsBrowsable)
					{
						continue;
					}

					// add it
					instanceProperties.Add(property);
				}
			}

			return new PropertyDescriptorCollection((PropertyDescriptor[])instanceProperties.ToArray(typeof(PropertyDescriptor))); 
		}

	}
}
