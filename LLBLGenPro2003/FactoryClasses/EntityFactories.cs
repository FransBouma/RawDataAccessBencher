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

using LLBL2003.AdventureWorks2008.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.FactoryClasses
{
	
	/// <summary>
	/// Factory to create new, empty AddressEntity objects.
	/// </summary>
	[Serializable]
	public class AddressEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty AddressEntity object.
		/// </summary>
		/// <returns>A new, empty AddressEntity object.</returns>
		public virtual IEntity Create()
		{
			return new AddressEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty AddressTypeEntity objects.
	/// </summary>
	[Serializable]
	public class AddressTypeEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty AddressTypeEntity object.
		/// </summary>
		/// <returns>A new, empty AddressTypeEntity object.</returns>
		public virtual IEntity Create()
		{
			return new AddressTypeEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty AWBuildVersionEntity objects.
	/// </summary>
	[Serializable]
	public class AWBuildVersionEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty AWBuildVersionEntity object.
		/// </summary>
		/// <returns>A new, empty AWBuildVersionEntity object.</returns>
		public virtual IEntity Create()
		{
			return new AWBuildVersionEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty BillOfMaterialsEntity objects.
	/// </summary>
	[Serializable]
	public class BillOfMaterialsEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty BillOfMaterialsEntity object.
		/// </summary>
		/// <returns>A new, empty BillOfMaterialsEntity object.</returns>
		public virtual IEntity Create()
		{
			return new BillOfMaterialsEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ContactEntity objects.
	/// </summary>
	[Serializable]
	public class ContactEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ContactEntity object.
		/// </summary>
		/// <returns>A new, empty ContactEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ContactEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ContactCreditCardEntity objects.
	/// </summary>
	[Serializable]
	public class ContactCreditCardEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ContactCreditCardEntity object.
		/// </summary>
		/// <returns>A new, empty ContactCreditCardEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ContactCreditCardEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ContactTypeEntity objects.
	/// </summary>
	[Serializable]
	public class ContactTypeEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ContactTypeEntity object.
		/// </summary>
		/// <returns>A new, empty ContactTypeEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ContactTypeEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CountryRegionEntity objects.
	/// </summary>
	[Serializable]
	public class CountryRegionEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CountryRegionEntity object.
		/// </summary>
		/// <returns>A new, empty CountryRegionEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CountryRegionEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CountryRegionCurrencyEntity objects.
	/// </summary>
	[Serializable]
	public class CountryRegionCurrencyEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CountryRegionCurrencyEntity object.
		/// </summary>
		/// <returns>A new, empty CountryRegionCurrencyEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CountryRegionCurrencyEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CreativeAddressesEntity objects.
	/// </summary>
	[Serializable]
	public class CreativeAddressesEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CreativeAddressesEntity object.
		/// </summary>
		/// <returns>A new, empty CreativeAddressesEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CreativeAddressesEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CreditCardEntity objects.
	/// </summary>
	[Serializable]
	public class CreditCardEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CreditCardEntity object.
		/// </summary>
		/// <returns>A new, empty CreditCardEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CreditCardEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CultureEntity objects.
	/// </summary>
	[Serializable]
	public class CultureEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CultureEntity object.
		/// </summary>
		/// <returns>A new, empty CultureEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CultureEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CurrencyEntity objects.
	/// </summary>
	[Serializable]
	public class CurrencyEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CurrencyEntity object.
		/// </summary>
		/// <returns>A new, empty CurrencyEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CurrencyEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CurrencyRateEntity objects.
	/// </summary>
	[Serializable]
	public class CurrencyRateEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CurrencyRateEntity object.
		/// </summary>
		/// <returns>A new, empty CurrencyRateEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CurrencyRateEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CustomerEntity objects.
	/// </summary>
	[Serializable]
	public class CustomerEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CustomerEntity object.
		/// </summary>
		/// <returns>A new, empty CustomerEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CustomerEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty CustomerAddressEntity objects.
	/// </summary>
	[Serializable]
	public class CustomerAddressEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty CustomerAddressEntity object.
		/// </summary>
		/// <returns>A new, empty CustomerAddressEntity object.</returns>
		public virtual IEntity Create()
		{
			return new CustomerAddressEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty DatabaseLogEntity objects.
	/// </summary>
	[Serializable]
	public class DatabaseLogEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty DatabaseLogEntity object.
		/// </summary>
		/// <returns>A new, empty DatabaseLogEntity object.</returns>
		public virtual IEntity Create()
		{
			return new DatabaseLogEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty DepartmentEntity objects.
	/// </summary>
	[Serializable]
	public class DepartmentEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty DepartmentEntity object.
		/// </summary>
		/// <returns>A new, empty DepartmentEntity object.</returns>
		public virtual IEntity Create()
		{
			return new DepartmentEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty DocumentEntity objects.
	/// </summary>
	[Serializable]
	public class DocumentEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty DocumentEntity object.
		/// </summary>
		/// <returns>A new, empty DocumentEntity object.</returns>
		public virtual IEntity Create()
		{
			return new DocumentEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty EmployeeEntity objects.
	/// </summary>
	[Serializable]
	public class EmployeeEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty EmployeeEntity object.
		/// </summary>
		/// <returns>A new, empty EmployeeEntity object.</returns>
		public virtual IEntity Create()
		{
			return new EmployeeEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty EmployeeAddressEntity objects.
	/// </summary>
	[Serializable]
	public class EmployeeAddressEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty EmployeeAddressEntity object.
		/// </summary>
		/// <returns>A new, empty EmployeeAddressEntity object.</returns>
		public virtual IEntity Create()
		{
			return new EmployeeAddressEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty EmployeeDepartmentHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class EmployeeDepartmentHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty EmployeeDepartmentHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty EmployeeDepartmentHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new EmployeeDepartmentHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty EmployeePayHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class EmployeePayHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty EmployeePayHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty EmployeePayHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new EmployeePayHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ErrorLogEntity objects.
	/// </summary>
	[Serializable]
	public class ErrorLogEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ErrorLogEntity object.
		/// </summary>
		/// <returns>A new, empty ErrorLogEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ErrorLogEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty IllustrationEntity objects.
	/// </summary>
	[Serializable]
	public class IllustrationEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty IllustrationEntity object.
		/// </summary>
		/// <returns>A new, empty IllustrationEntity object.</returns>
		public virtual IEntity Create()
		{
			return new IllustrationEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty IndividualEntity objects.
	/// </summary>
	[Serializable]
	public class IndividualEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty IndividualEntity object.
		/// </summary>
		/// <returns>A new, empty IndividualEntity object.</returns>
		public virtual IEntity Create()
		{
			return new IndividualEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty JobCandidateEntity objects.
	/// </summary>
	[Serializable]
	public class JobCandidateEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty JobCandidateEntity object.
		/// </summary>
		/// <returns>A new, empty JobCandidateEntity object.</returns>
		public virtual IEntity Create()
		{
			return new JobCandidateEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty LocationEntity objects.
	/// </summary>
	[Serializable]
	public class LocationEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty LocationEntity object.
		/// </summary>
		/// <returns>A new, empty LocationEntity object.</returns>
		public virtual IEntity Create()
		{
			return new LocationEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty NameTestTabEntity objects.
	/// </summary>
	[Serializable]
	public class NameTestTabEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty NameTestTabEntity object.
		/// </summary>
		/// <returns>A new, empty NameTestTabEntity object.</returns>
		public virtual IEntity Create()
		{
			return new NameTestTabEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty NewSequentialIDTestEntity objects.
	/// </summary>
	[Serializable]
	public class NewSequentialIDTestEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty NewSequentialIDTestEntity object.
		/// </summary>
		/// <returns>A new, empty NewSequentialIDTestEntity object.</returns>
		public virtual IEntity Create()
		{
			return new NewSequentialIDTestEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty NonPresentTimeEntity objects.
	/// </summary>
	[Serializable]
	public class NonPresentTimeEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty NonPresentTimeEntity object.
		/// </summary>
		/// <returns>A new, empty NonPresentTimeEntity object.</returns>
		public virtual IEntity Create()
		{
			return new NonPresentTimeEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty NonPresentTimeHeaderEntity objects.
	/// </summary>
	[Serializable]
	public class NonPresentTimeHeaderEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty NonPresentTimeHeaderEntity object.
		/// </summary>
		/// <returns>A new, empty NonPresentTimeHeaderEntity object.</returns>
		public virtual IEntity Create()
		{
			return new NonPresentTimeHeaderEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductEntity objects.
	/// </summary>
	[Serializable]
	public class ProductEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductEntity object.
		/// </summary>
		/// <returns>A new, empty ProductEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductCategoryEntity objects.
	/// </summary>
	[Serializable]
	public class ProductCategoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductCategoryEntity object.
		/// </summary>
		/// <returns>A new, empty ProductCategoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductCategoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductCostHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class ProductCostHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductCostHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty ProductCostHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductCostHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductDescriptionEntity objects.
	/// </summary>
	[Serializable]
	public class ProductDescriptionEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductDescriptionEntity object.
		/// </summary>
		/// <returns>A new, empty ProductDescriptionEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductDescriptionEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductDocumentEntity objects.
	/// </summary>
	[Serializable]
	public class ProductDocumentEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductDocumentEntity object.
		/// </summary>
		/// <returns>A new, empty ProductDocumentEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductDocumentEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductInventoryEntity objects.
	/// </summary>
	[Serializable]
	public class ProductInventoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductInventoryEntity object.
		/// </summary>
		/// <returns>A new, empty ProductInventoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductInventoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductListPriceHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class ProductListPriceHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductListPriceHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty ProductListPriceHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductListPriceHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductModelEntity objects.
	/// </summary>
	[Serializable]
	public class ProductModelEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductModelEntity object.
		/// </summary>
		/// <returns>A new, empty ProductModelEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductModelEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductModelIllustrationEntity objects.
	/// </summary>
	[Serializable]
	public class ProductModelIllustrationEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductModelIllustrationEntity object.
		/// </summary>
		/// <returns>A new, empty ProductModelIllustrationEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductModelIllustrationEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductModelProductDescriptionCultureEntity objects.
	/// </summary>
	[Serializable]
	public class ProductModelProductDescriptionCultureEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductModelProductDescriptionCultureEntity object.
		/// </summary>
		/// <returns>A new, empty ProductModelProductDescriptionCultureEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductModelProductDescriptionCultureEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductPhotoEntity objects.
	/// </summary>
	[Serializable]
	public class ProductPhotoEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductPhotoEntity object.
		/// </summary>
		/// <returns>A new, empty ProductPhotoEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductPhotoEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductProductPhotoEntity objects.
	/// </summary>
	[Serializable]
	public class ProductProductPhotoEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductProductPhotoEntity object.
		/// </summary>
		/// <returns>A new, empty ProductProductPhotoEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductProductPhotoEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductReviewEntity objects.
	/// </summary>
	[Serializable]
	public class ProductReviewEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductReviewEntity object.
		/// </summary>
		/// <returns>A new, empty ProductReviewEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductReviewEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductSubcategoryEntity objects.
	/// </summary>
	[Serializable]
	public class ProductSubcategoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductSubcategoryEntity object.
		/// </summary>
		/// <returns>A new, empty ProductSubcategoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductSubcategoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ProductVendorEntity objects.
	/// </summary>
	[Serializable]
	public class ProductVendorEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ProductVendorEntity object.
		/// </summary>
		/// <returns>A new, empty ProductVendorEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ProductVendorEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty PurchaseOrderDetailEntity objects.
	/// </summary>
	[Serializable]
	public class PurchaseOrderDetailEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty PurchaseOrderDetailEntity object.
		/// </summary>
		/// <returns>A new, empty PurchaseOrderDetailEntity object.</returns>
		public virtual IEntity Create()
		{
			return new PurchaseOrderDetailEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty PurchaseOrderHeaderEntity objects.
	/// </summary>
	[Serializable]
	public class PurchaseOrderHeaderEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty PurchaseOrderHeaderEntity object.
		/// </summary>
		/// <returns>A new, empty PurchaseOrderHeaderEntity object.</returns>
		public virtual IEntity Create()
		{
			return new PurchaseOrderHeaderEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ReasonEntity objects.
	/// </summary>
	[Serializable]
	public class ReasonEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ReasonEntity object.
		/// </summary>
		/// <returns>A new, empty ReasonEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ReasonEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesOrderDetailEntity objects.
	/// </summary>
	[Serializable]
	public class SalesOrderDetailEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesOrderDetailEntity object.
		/// </summary>
		/// <returns>A new, empty SalesOrderDetailEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesOrderDetailEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesOrderHeaderEntity objects.
	/// </summary>
	[Serializable]
	public class SalesOrderHeaderEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesOrderHeaderEntity object.
		/// </summary>
		/// <returns>A new, empty SalesOrderHeaderEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesOrderHeaderEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesOrderHeaderSalesReasonEntity objects.
	/// </summary>
	[Serializable]
	public class SalesOrderHeaderSalesReasonEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesOrderHeaderSalesReasonEntity object.
		/// </summary>
		/// <returns>A new, empty SalesOrderHeaderSalesReasonEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesOrderHeaderSalesReasonEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesPersonEntity objects.
	/// </summary>
	[Serializable]
	public class SalesPersonEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesPersonEntity object.
		/// </summary>
		/// <returns>A new, empty SalesPersonEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesPersonEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesPersonQuotaHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class SalesPersonQuotaHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesPersonQuotaHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty SalesPersonQuotaHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesPersonQuotaHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesReasonEntity objects.
	/// </summary>
	[Serializable]
	public class SalesReasonEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesReasonEntity object.
		/// </summary>
		/// <returns>A new, empty SalesReasonEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesReasonEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesTaxRateEntity objects.
	/// </summary>
	[Serializable]
	public class SalesTaxRateEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesTaxRateEntity object.
		/// </summary>
		/// <returns>A new, empty SalesTaxRateEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesTaxRateEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesTerritoryEntity objects.
	/// </summary>
	[Serializable]
	public class SalesTerritoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesTerritoryEntity object.
		/// </summary>
		/// <returns>A new, empty SalesTerritoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesTerritoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SalesTerritoryHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class SalesTerritoryHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SalesTerritoryHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty SalesTerritoryHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SalesTerritoryHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ScrapReasonEntity objects.
	/// </summary>
	[Serializable]
	public class ScrapReasonEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ScrapReasonEntity object.
		/// </summary>
		/// <returns>A new, empty ScrapReasonEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ScrapReasonEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SequentialIDSubTypeEntity objects.
	/// </summary>
	[Serializable]
	public class SequentialIDSubTypeEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SequentialIDSubTypeEntity object.
		/// </summary>
		/// <returns>A new, empty SequentialIDSubTypeEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SequentialIDSubTypeEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ShiftEntity objects.
	/// </summary>
	[Serializable]
	public class ShiftEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ShiftEntity object.
		/// </summary>
		/// <returns>A new, empty ShiftEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ShiftEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ShipMethodEntity objects.
	/// </summary>
	[Serializable]
	public class ShipMethodEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ShipMethodEntity object.
		/// </summary>
		/// <returns>A new, empty ShipMethodEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ShipMethodEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty ShoppingCartItemEntity objects.
	/// </summary>
	[Serializable]
	public class ShoppingCartItemEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty ShoppingCartItemEntity object.
		/// </summary>
		/// <returns>A new, empty ShoppingCartItemEntity object.</returns>
		public virtual IEntity Create()
		{
			return new ShoppingCartItemEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SpecialOfferEntity objects.
	/// </summary>
	[Serializable]
	public class SpecialOfferEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SpecialOfferEntity object.
		/// </summary>
		/// <returns>A new, empty SpecialOfferEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SpecialOfferEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty SpecialOfferProductEntity objects.
	/// </summary>
	[Serializable]
	public class SpecialOfferProductEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty SpecialOfferProductEntity object.
		/// </summary>
		/// <returns>A new, empty SpecialOfferProductEntity object.</returns>
		public virtual IEntity Create()
		{
			return new SpecialOfferProductEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty StateProvinceEntity objects.
	/// </summary>
	[Serializable]
	public class StateProvinceEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty StateProvinceEntity object.
		/// </summary>
		/// <returns>A new, empty StateProvinceEntity object.</returns>
		public virtual IEntity Create()
		{
			return new StateProvinceEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty StoreEntity objects.
	/// </summary>
	[Serializable]
	public class StoreEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty StoreEntity object.
		/// </summary>
		/// <returns>A new, empty StoreEntity object.</returns>
		public virtual IEntity Create()
		{
			return new StoreEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty StoreContactEntity objects.
	/// </summary>
	[Serializable]
	public class StoreContactEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty StoreContactEntity object.
		/// </summary>
		/// <returns>A new, empty StoreContactEntity object.</returns>
		public virtual IEntity Create()
		{
			return new StoreContactEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty TransactionHistoryEntity objects.
	/// </summary>
	[Serializable]
	public class TransactionHistoryEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty TransactionHistoryEntity object.
		/// </summary>
		/// <returns>A new, empty TransactionHistoryEntity object.</returns>
		public virtual IEntity Create()
		{
			return new TransactionHistoryEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty TransactionHistoryArchiveEntity objects.
	/// </summary>
	[Serializable]
	public class TransactionHistoryArchiveEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty TransactionHistoryArchiveEntity object.
		/// </summary>
		/// <returns>A new, empty TransactionHistoryArchiveEntity object.</returns>
		public virtual IEntity Create()
		{
			return new TransactionHistoryArchiveEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty UdtTestEntity objects.
	/// </summary>
	[Serializable]
	public class UdtTestEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty UdtTestEntity object.
		/// </summary>
		/// <returns>A new, empty UdtTestEntity object.</returns>
		public virtual IEntity Create()
		{
			return new UdtTestEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty UnitMeasureEntity objects.
	/// </summary>
	[Serializable]
	public class UnitMeasureEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty UnitMeasureEntity object.
		/// </summary>
		/// <returns>A new, empty UnitMeasureEntity object.</returns>
		public virtual IEntity Create()
		{
			return new UnitMeasureEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty UserDetailEntity objects.
	/// </summary>
	[Serializable]
	public class UserDetailEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty UserDetailEntity object.
		/// </summary>
		/// <returns>A new, empty UserDetailEntity object.</returns>
		public virtual IEntity Create()
		{
			return new UserDetailEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty VendorEntity objects.
	/// </summary>
	[Serializable]
	public class VendorEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty VendorEntity object.
		/// </summary>
		/// <returns>A new, empty VendorEntity object.</returns>
		public virtual IEntity Create()
		{
			return new VendorEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty VendorAddressEntity objects.
	/// </summary>
	[Serializable]
	public class VendorAddressEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty VendorAddressEntity object.
		/// </summary>
		/// <returns>A new, empty VendorAddressEntity object.</returns>
		public virtual IEntity Create()
		{
			return new VendorAddressEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty VendorContactEntity objects.
	/// </summary>
	[Serializable]
	public class VendorContactEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty VendorContactEntity object.
		/// </summary>
		/// <returns>A new, empty VendorContactEntity object.</returns>
		public virtual IEntity Create()
		{
			return new VendorContactEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty WorkOrderEntity objects.
	/// </summary>
	[Serializable]
	public class WorkOrderEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty WorkOrderEntity object.
		/// </summary>
		/// <returns>A new, empty WorkOrderEntity object.</returns>
		public virtual IEntity Create()
		{
			return new WorkOrderEntity(new PropertyDescriptorFactory(), this);
		}
	}

	
	/// <summary>
	/// Factory to create new, empty WorkOrderRoutingEntity objects.
	/// </summary>
	[Serializable]
	public class WorkOrderRoutingEntityFactory : IEntityFactory
	{
		/// <summary>
		/// Creates a new, empty WorkOrderRoutingEntity object.
		/// </summary>
		/// <returns>A new, empty WorkOrderRoutingEntity object.</returns>
		public virtual IEntity Create()
		{
			return new WorkOrderRoutingEntity(new PropertyDescriptorFactory(), this);
		}
	}

}
