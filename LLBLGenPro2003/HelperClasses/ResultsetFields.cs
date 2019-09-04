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

using LLBL2003.AdventureWorks2008.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.HelperClasses
{
	/// <summary>
	/// Helper class which will eases the creation of custom made resultsets. Usable in typed lists
	/// and dynamic lists created using the dynamic query engine.
	/// </summary>
	public class ResultsetFields : EntityFields
	{
		/// <summary>
		/// CTor
		/// </summary>
		public ResultsetFields(int amountFields) : base(amountFields)
		{
		}

	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(AddressFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(AddressTypeFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(AWBuildVersionFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(BillOfMaterialsFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ContactFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ContactCreditCardFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ContactTypeFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CountryRegionFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CountryRegionCurrencyFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CreativeAddressesFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CreditCardFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CultureFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CurrencyFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CurrencyRateFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CustomerFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(CustomerAddressFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(DatabaseLogFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(DepartmentFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(DocumentFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EmployeeFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EmployeeAddressFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EmployeeDepartmentHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(EmployeePayHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ErrorLogFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(IllustrationFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(IndividualFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(JobCandidateFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(LocationFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(NameTestTabFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(NewSequentialIDTestFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(NonPresentTimeFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(NonPresentTimeHeaderFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductCategoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductCostHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductDescriptionFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductDocumentFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductInventoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductListPriceHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductModelFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductModelIllustrationFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductModelProductDescriptionCultureFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductPhotoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductProductPhotoFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductReviewFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductSubcategoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ProductVendorFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(PurchaseOrderDetailFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(PurchaseOrderHeaderFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ReasonFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesOrderDetailFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesOrderHeaderFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesOrderHeaderSalesReasonFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesPersonFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesPersonQuotaHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesReasonFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesTaxRateFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesTerritoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SalesTerritoryHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ScrapReasonFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SequentialIDSubTypeFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ShiftFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ShipMethodFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(ShoppingCartItemFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SpecialOfferFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(SpecialOfferProductFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(StateProvinceFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(StoreFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(StoreContactFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(TransactionHistoryFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(TransactionHistoryArchiveFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(UdtTestFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(UnitMeasureFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(UserDetailFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(VendorFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(VendorAddressFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(VendorContactFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(WorkOrderFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
		/// <summary>
		/// Creates the specified field on the position indexInResultset in the resultset.
		/// </summary>
		/// <param name="fieldToDefine">The specification of the field to create.</param>
		/// <param name="indexInResultset">The position in the resultset where the field will be created on</param>
		/// <param name="alias">The alias to use for this field in the resultset</param>
		public void DefineField(WorkOrderRoutingFieldIndex fieldToDefine, int indexInResultset, string alias)
		{
			IEntityField fieldToAdd = EntityFieldFactory.Create(fieldToDefine); 
			fieldToAdd.Name = alias;
			base[indexInResultset] = fieldToAdd;
		}
	
	
	}
}
