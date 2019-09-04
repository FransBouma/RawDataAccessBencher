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

using LLBL2003.AdventureWorks2008;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.FactoryClasses
{
	/// <summary>
	/// Class which eases the creation of sort clauses used in a SortExpression, to sort resultsets on 
	/// specified fields.
	/// </summary>
	public class SortClauseFactory
	{
		/// <summary>
		/// Static class, no CTor
		/// </summary>
		private SortClauseFactory()
		{
		}

	
		/// <summary>
		/// Creates a new sort clause for the AddressEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(AddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the AddressTypeEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(AddressTypeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the AWBuildVersionEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(AWBuildVersionFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the BillOfMaterialsEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(BillOfMaterialsFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ContactEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ContactFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ContactCreditCardEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ContactCreditCardFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ContactTypeEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ContactTypeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CountryRegionEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CountryRegionFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CountryRegionCurrencyEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CountryRegionCurrencyFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CreativeAddressesEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CreativeAddressesFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CreditCardEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CreditCardFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CultureEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CultureFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CurrencyEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CurrencyFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CurrencyRateEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CurrencyRateFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CustomerEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CustomerFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the CustomerAddressEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(CustomerAddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the DatabaseLogEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(DatabaseLogFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the DepartmentEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(DepartmentFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the DocumentEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(DocumentFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the EmployeeEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(EmployeeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the EmployeeAddressEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(EmployeeAddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the EmployeeDepartmentHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(EmployeeDepartmentHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the EmployeePayHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(EmployeePayHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ErrorLogEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ErrorLogFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the IllustrationEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(IllustrationFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the IndividualEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(IndividualFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the JobCandidateEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(JobCandidateFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the LocationEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(LocationFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the NameTestTabEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(NameTestTabFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the NewSequentialIDTestEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(NewSequentialIDTestFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the NonPresentTimeEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(NonPresentTimeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the NonPresentTimeHeaderEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(NonPresentTimeHeaderFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductCategoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductCategoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductCostHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductCostHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductDescriptionEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductDescriptionFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductDocumentEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductDocumentFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductInventoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductInventoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductListPriceHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductListPriceHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductModelEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductModelFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductModelIllustrationEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductModelIllustrationFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductModelProductDescriptionCultureEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductModelProductDescriptionCultureFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductPhotoEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductPhotoFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductProductPhotoEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductProductPhotoFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductReviewEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductReviewFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductSubcategoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductSubcategoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ProductVendorEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ProductVendorFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the PurchaseOrderDetailEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(PurchaseOrderDetailFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the PurchaseOrderHeaderEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(PurchaseOrderHeaderFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ReasonEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ReasonFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesOrderDetailEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesOrderDetailFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesOrderHeaderEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesOrderHeaderFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesOrderHeaderSalesReasonEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesOrderHeaderSalesReasonFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesPersonEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesPersonFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesPersonQuotaHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesPersonQuotaHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesReasonEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesReasonFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesTaxRateEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesTaxRateFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesTerritoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesTerritoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SalesTerritoryHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SalesTerritoryHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ScrapReasonEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ScrapReasonFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SequentialIDSubTypeEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SequentialIDSubTypeFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ShiftEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ShiftFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ShipMethodEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ShipMethodFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the ShoppingCartItemEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(ShoppingCartItemFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SpecialOfferEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SpecialOfferFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the SpecialOfferProductEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(SpecialOfferProductFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the StateProvinceEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(StateProvinceFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the StoreEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(StoreFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the StoreContactEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(StoreContactFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the TransactionHistoryEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(TransactionHistoryFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the TransactionHistoryArchiveEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(TransactionHistoryArchiveFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the UdtTestEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(UdtTestFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the UnitMeasureEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(UnitMeasureFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the UserDetailEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(UserDetailFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the VendorEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(VendorFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the VendorAddressEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(VendorAddressFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the VendorContactEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(VendorContactFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the WorkOrderEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(WorkOrderFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	

		/// <summary>
		/// Creates a new sort clause for the WorkOrderRoutingEntity field specified.
		/// </summary>
		/// <param name="fieldToSort">field to sort on</param>
		/// <param name="operatorToUse">sort operator to use for this field</param>
		/// <returns>Sort clause to use in a SortExpression</returns>
		public static ISortClause Create(WorkOrderRoutingFieldIndex fieldToSort, SortOperator operatorToUse)
		{
			return new SortClause(EntityFieldFactory.Create(fieldToSort), operatorToUse);
		}
	
	
	
	}
}
