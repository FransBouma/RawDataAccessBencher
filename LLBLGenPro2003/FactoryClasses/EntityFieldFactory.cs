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
using System.Data;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.HelperClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.FactoryClasses
{
	/// <summary>
	/// Factory class for IEntityField instances, used in IEntityFields instances.
	/// </summary>
	public class EntityFieldFactory
	{
		/// <summary>
		/// Private CTor, no instantiation possible.
		/// </summary>
		private EntityFieldFactory()
		{
		}

	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AddressEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(AddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case AddressFieldIndex.AddressID:
					fieldToReturn = new EntityField("AddressID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "Address", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case AddressFieldIndex.AddressLine1:
					fieldToReturn = new EntityField("AddressLine1", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Address", "AddressLine1", false, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.AddressLine2:
					fieldToReturn = new EntityField("AddressLine2", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Address", "AddressLine2", true, (int)SqlDbType.NVarChar, 60, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.City:
					fieldToReturn = new EntityField("City", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Address", "City", false, (int)SqlDbType.NVarChar, 30, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.StateProvinceID:
					fieldToReturn = new EntityField("StateProvinceID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "Address", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.PostalCode:
					fieldToReturn = new EntityField("PostalCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Address", "PostalCode", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Person", "Address", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "Address", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AddressTypeEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(AddressTypeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case AddressTypeFieldIndex.AddressTypeID:
					fieldToReturn = new EntityField("AddressTypeID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "AddressType", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "AddressType", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Person", "AddressType", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AddressTypeFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "AddressType", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the AWBuildVersionEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(AWBuildVersionFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case AWBuildVersionFieldIndex.SystemInformationID:
					fieldToReturn = new EntityField("SystemInformationID", typeof(System.Byte), true, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "dbo", "AWBuildVersion", "SystemInformationID", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case AWBuildVersionFieldIndex.DatabaseVersion:
					fieldToReturn = new EntityField("DatabaseVersion", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "AWBuildVersion", "Database Version", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AWBuildVersionFieldIndex.VersionDate:
					fieldToReturn = new EntityField("VersionDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "AWBuildVersion", "VersionDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case AWBuildVersionFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "AWBuildVersion", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the BillOfMaterialsEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(BillOfMaterialsFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case BillOfMaterialsFieldIndex.BillOfMaterialsID:
					fieldToReturn = new EntityField("BillOfMaterialsID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "BillOfMaterials", "BillOfMaterialsID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.ProductAssemblyID:
					fieldToReturn = new EntityField("ProductAssemblyID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "BillOfMaterials", "ProductAssemblyID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.ComponentID:
					fieldToReturn = new EntityField("ComponentID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "BillOfMaterials", "ComponentID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "BillOfMaterials", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "BillOfMaterials", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.UnitMeasureCode:
					fieldToReturn = new EntityField("UnitMeasureCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "BillOfMaterials", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.BOMLevel:
					fieldToReturn = new EntityField("BOMLevel", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "BillOfMaterials", "BOMLevel", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.PerAssemblyQty:
					fieldToReturn = new EntityField("PerAssemblyQty", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "BillOfMaterials", "PerAssemblyQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", (int)fieldIndex);
					break;
				case BillOfMaterialsFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "BillOfMaterials", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ContactEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ContactFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ContactFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "Contact", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ContactFieldIndex.NameStyle:
					fieldToReturn = new EntityField("NameStyle", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Person", "Contact", "NameStyle", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "Title", true, (int)SqlDbType.NVarChar, 8, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.FirstName:
					fieldToReturn = new EntityField("FirstName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "FirstName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.MiddleName:
					fieldToReturn = new EntityField("MiddleName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "MiddleName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.LastName:
					fieldToReturn = new EntityField("LastName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "LastName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.Suffix:
					fieldToReturn = new EntityField("Suffix", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "Suffix", true, (int)SqlDbType.NVarChar, 10, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.EmailAddress:
					fieldToReturn = new EntityField("EmailAddress", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "EmailAddress", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.EmailPromotion:
					fieldToReturn = new EntityField("EmailPromotion", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "Contact", "EmailPromotion", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.Phone:
					fieldToReturn = new EntityField("Phone", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "Phone", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.PasswordHash:
					fieldToReturn = new EntityField("PasswordHash", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "PasswordHash", false, (int)SqlDbType.VarChar, 40, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.PasswordSalt:
					fieldToReturn = new EntityField("PasswordSalt", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "PasswordSalt", false, (int)SqlDbType.VarChar, 10, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.AdditionalContactInfo:
					fieldToReturn = new EntityField("AdditionalContactInfo", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "Contact", "AdditionalContactInfo", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Person", "Contact", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "Contact", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ContactCreditCardEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ContactCreditCardFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ContactCreditCardFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "ContactCreditCard", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ContactCreditCardFieldIndex.CreditCardID:
					fieldToReturn = new EntityField("CreditCardID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "ContactCreditCard", "CreditCardID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ContactCreditCardFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "ContactCreditCard", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ContactTypeEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ContactTypeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ContactTypeFieldIndex.ContactTypeID:
					fieldToReturn = new EntityField("ContactTypeID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "ContactType", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ContactTypeFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "ContactType", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ContactTypeFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "ContactType", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CountryRegionEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CountryRegionFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CountryRegionFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "CountryRegion", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case CountryRegionFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "CountryRegion", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CountryRegionFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "CountryRegion", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CountryRegionCurrencyEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CountryRegionCurrencyFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CountryRegionCurrencyFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CountryRegionCurrency", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case CountryRegionCurrencyFieldIndex.CurrencyCode:
					fieldToReturn = new EntityField("CurrencyCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CountryRegionCurrency", "CurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case CountryRegionCurrencyFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "CountryRegionCurrency", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CreativeAddressesEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CreativeAddressesFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CreativeAddressesFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "CreativeAddresses", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case CreativeAddressesFieldIndex.City:
					fieldToReturn = new EntityField("City", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "CreativeAddresses", "City", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CreativeAddressesFieldIndex.Latitude:
					fieldToReturn = new EntityField("Latitude", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "dbo", "CreativeAddresses", "Latitude", true, (int)SqlDbType.Decimal, 0, 10, 18, false, false, "", (int)fieldIndex);
					break;
				case CreativeAddressesFieldIndex.Longitude:
					fieldToReturn = new EntityField("Longitude", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "dbo", "CreativeAddresses", "Longitude", true, (int)SqlDbType.Decimal, 0, 10, 18, false, false, "", (int)fieldIndex);
					break;
				case CreativeAddressesFieldIndex.LatitudeF:
					fieldToReturn = new EntityField("LatitudeF", typeof(System.Double), false, TypeDefaultValue.GetDefaultValue(typeof(System.Double)), "dbo", "CreativeAddresses", "LatitudeF", true, (int)SqlDbType.Float, 0, 0, 38, false, false, "", (int)fieldIndex);
					break;
				case CreativeAddressesFieldIndex.LongitudeF:
					fieldToReturn = new EntityField("LongitudeF", typeof(System.Double), false, TypeDefaultValue.GetDefaultValue(typeof(System.Double)), "dbo", "CreativeAddresses", "LongitudeF", true, (int)SqlDbType.Float, 0, 0, 38, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CreditCardEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CreditCardFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CreditCardFieldIndex.CreditCardID:
					fieldToReturn = new EntityField("CreditCardID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "CreditCard", "CreditCardID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case CreditCardFieldIndex.CardType:
					fieldToReturn = new EntityField("CardType", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CreditCard", "CardType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CreditCardFieldIndex.CardNumber:
					fieldToReturn = new EntityField("CardNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CreditCard", "CardNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CreditCardFieldIndex.ExpMonth:
					fieldToReturn = new EntityField("ExpMonth", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Sales", "CreditCard", "ExpMonth", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case CreditCardFieldIndex.ExpYear:
					fieldToReturn = new EntityField("ExpYear", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Sales", "CreditCard", "ExpYear", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case CreditCardFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "CreditCard", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CultureEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CultureFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CultureFieldIndex.CultureID:
					fieldToReturn = new EntityField("CultureID", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Culture", "CultureID", false, (int)SqlDbType.NChar, 6, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case CultureFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Culture", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CultureFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Culture", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CurrencyEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CurrencyFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CurrencyFieldIndex.CurrencyCode:
					fieldToReturn = new EntityField("CurrencyCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Currency", "CurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case CurrencyFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Currency", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CurrencyFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "Currency", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CurrencyRateEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CurrencyRateFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CurrencyRateFieldIndex.CurrencyRateID:
					fieldToReturn = new EntityField("CurrencyRateID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "CurrencyRate", "CurrencyRateID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.CurrencyRateDate:
					fieldToReturn = new EntityField("CurrencyRateDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "CurrencyRate", "CurrencyRateDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.FromCurrencyCode:
					fieldToReturn = new EntityField("FromCurrencyCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CurrencyRate", "FromCurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.ToCurrencyCode:
					fieldToReturn = new EntityField("ToCurrencyCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "CurrencyRate", "ToCurrencyCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.AverageRate:
					fieldToReturn = new EntityField("AverageRate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "CurrencyRate", "AverageRate", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.EndOfDayRate:
					fieldToReturn = new EntityField("EndOfDayRate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "CurrencyRate", "EndOfDayRate", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case CurrencyRateFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "CurrencyRate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CustomerFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Customer", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case CustomerFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Customer", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case CustomerFieldIndex.AccountNumber:
					fieldToReturn = new EntityField("AccountNumber", typeof(System.String), true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Customer", "AccountNumber", false, (int)SqlDbType.VarChar, 10, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CustomerFieldIndex.CustomerType:
					fieldToReturn = new EntityField("CustomerType", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Customer", "CustomerType", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CustomerFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "Customer", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CustomerFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "Customer", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the CustomerAddressEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(CustomerAddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case CustomerAddressFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "CustomerAddress", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.AddressID:
					fieldToReturn = new EntityField("AddressID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "CustomerAddress", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.AddressTypeID:
					fieldToReturn = new EntityField("AddressTypeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "CustomerAddress", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "CustomerAddress", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case CustomerAddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "CustomerAddress", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the DatabaseLogEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(DatabaseLogFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case DatabaseLogFieldIndex.DatabaseLogID:
					fieldToReturn = new EntityField("DatabaseLogID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "DatabaseLog", "DatabaseLogID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.PostTime:
					fieldToReturn = new EntityField("PostTime", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "DatabaseLog", "PostTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.DatabaseUser:
					fieldToReturn = new EntityField("DatabaseUser", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "DatabaseUser", false, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.Event:
					fieldToReturn = new EntityField("Event", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "Event", false, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.Schema:
					fieldToReturn = new EntityField("Schema", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "Schema", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.Object:
					fieldToReturn = new EntityField("Object", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "Object", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.TSQL:
					fieldToReturn = new EntityField("TSQL", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "TSQL", false, (int)SqlDbType.NVarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DatabaseLogFieldIndex.XmlEvent:
					fieldToReturn = new EntityField("XmlEvent", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "DatabaseLog", "XmlEvent", false, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the DepartmentEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(DepartmentFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case DepartmentFieldIndex.DepartmentID:
					fieldToReturn = new EntityField("DepartmentID", typeof(System.Int16), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "HumanResources", "Department", "DepartmentID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case DepartmentFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Department", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DepartmentFieldIndex.GroupName:
					fieldToReturn = new EntityField("GroupName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Department", "GroupName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DepartmentFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Department", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the DocumentEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(DocumentFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case DocumentFieldIndex.DocumentID:
					fieldToReturn = new EntityField("DocumentID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Document", "DocumentID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case DocumentFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Document", "Title", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.FileName:
					fieldToReturn = new EntityField("FileName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Document", "FileName", false, (int)SqlDbType.NVarChar, 400, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.FileExtension:
					fieldToReturn = new EntityField("FileExtension", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Document", "FileExtension", false, (int)SqlDbType.NVarChar, 8, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.Revision:
					fieldToReturn = new EntityField("Revision", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Document", "Revision", false, (int)SqlDbType.NChar, 5, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.ChangeNumber:
					fieldToReturn = new EntityField("ChangeNumber", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Document", "ChangeNumber", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.Status:
					fieldToReturn = new EntityField("Status", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Production", "Document", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.DocumentSummary:
					fieldToReturn = new EntityField("DocumentSummary", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Document", "DocumentSummary", true, (int)SqlDbType.NVarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.Document:
					fieldToReturn = new EntityField("Document", typeof(System.Byte[]), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte[])), "Production", "Document", "Document", true, (int)SqlDbType.VarBinary, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case DocumentFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Document", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(EmployeeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeeFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "Employee", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.NationalIDNumber:
					fieldToReturn = new EntityField("NationalIDNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Employee", "NationalIDNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "Employee", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.LoginID:
					fieldToReturn = new EntityField("LoginID", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Employee", "LoginID", false, (int)SqlDbType.NVarChar, 256, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ManagerID:
					fieldToReturn = new EntityField("ManagerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "Employee", "ManagerID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Title:
					fieldToReturn = new EntityField("Title", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Employee", "Title", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.BirthDate:
					fieldToReturn = new EntityField("BirthDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Employee", "BirthDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.MaritalStatus:
					fieldToReturn = new EntityField("MaritalStatus", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Employee", "MaritalStatus", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Gender:
					fieldToReturn = new EntityField("Gender", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Employee", "Gender", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.HireDate:
					fieldToReturn = new EntityField("HireDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Employee", "HireDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.SalariedFlag:
					fieldToReturn = new EntityField("SalariedFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "HumanResources", "Employee", "SalariedFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.VacationHours:
					fieldToReturn = new EntityField("VacationHours", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "HumanResources", "Employee", "VacationHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.SickLeaveHours:
					fieldToReturn = new EntityField("SickLeaveHours", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "HumanResources", "Employee", "SickLeaveHours", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.CurrentFlag:
					fieldToReturn = new EntityField("CurrentFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "HumanResources", "Employee", "CurrentFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "HumanResources", "Employee", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Employee", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeAddressEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(EmployeeAddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeeAddressFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "EmployeeAddress", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.AddressID:
					fieldToReturn = new EntityField("AddressID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "EmployeeAddress", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "HumanResources", "EmployeeAddress", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeAddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeeAddress", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeeDepartmentHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(EmployeeDepartmentHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeeDepartmentHistoryFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "EmployeeDepartmentHistory", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case EmployeeDepartmentHistoryFieldIndex.DepartmentID:
					fieldToReturn = new EntityField("DepartmentID", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "HumanResources", "EmployeeDepartmentHistory", "DepartmentID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, false, "", (int)fieldIndex);
					break;
				case EmployeeDepartmentHistoryFieldIndex.ShiftID:
					fieldToReturn = new EntityField("ShiftID", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "HumanResources", "EmployeeDepartmentHistory", "ShiftID", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, false, "", (int)fieldIndex);
					break;
				case EmployeeDepartmentHistoryFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeeDepartmentHistory", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case EmployeeDepartmentHistoryFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeeDepartmentHistory", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case EmployeeDepartmentHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeeDepartmentHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the EmployeePayHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(EmployeePayHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case EmployeePayHistoryFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "EmployeePayHistory", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case EmployeePayHistoryFieldIndex.RateChangeDate:
					fieldToReturn = new EntityField("RateChangeDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeePayHistory", "RateChangeDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case EmployeePayHistoryFieldIndex.Rate:
					fieldToReturn = new EntityField("Rate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "HumanResources", "EmployeePayHistory", "Rate", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case EmployeePayHistoryFieldIndex.PayFrequency:
					fieldToReturn = new EntityField("PayFrequency", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "HumanResources", "EmployeePayHistory", "PayFrequency", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case EmployeePayHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "EmployeePayHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ErrorLogEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ErrorLogFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ErrorLogFieldIndex.ErrorLogID:
					fieldToReturn = new EntityField("ErrorLogID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "ErrorLogID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorTime:
					fieldToReturn = new EntityField("ErrorTime", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "ErrorLog", "ErrorTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.UserName:
					fieldToReturn = new EntityField("UserName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "ErrorLog", "UserName", false, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorNumber:
					fieldToReturn = new EntityField("ErrorNumber", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "ErrorNumber", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorSeverity:
					fieldToReturn = new EntityField("ErrorSeverity", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "ErrorSeverity", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorState:
					fieldToReturn = new EntityField("ErrorState", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "ErrorState", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorProcedure:
					fieldToReturn = new EntityField("ErrorProcedure", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "ErrorLog", "ErrorProcedure", true, (int)SqlDbType.NVarChar, 126, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorLine:
					fieldToReturn = new EntityField("ErrorLine", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "ErrorLine", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.ErrorMessage:
					fieldToReturn = new EntityField("ErrorMessage", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "ErrorLog", "ErrorMessage", false, (int)SqlDbType.NVarChar, 4000, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ErrorLogFieldIndex.TesTField:
					fieldToReturn = new EntityField("TesTField", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "ErrorLog", "TesTField", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the IllustrationEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(IllustrationFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case IllustrationFieldIndex.IllustrationID:
					fieldToReturn = new EntityField("IllustrationID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Illustration", "IllustrationID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case IllustrationFieldIndex.Diagram:
					fieldToReturn = new EntityField("Diagram", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Illustration", "Diagram", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case IllustrationFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Illustration", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the IndividualEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(IndividualFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case IndividualFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Individual", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case IndividualFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Individual", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case IndividualFieldIndex.Demographics:
					fieldToReturn = new EntityField("Demographics", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Individual", "Demographics", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case IndividualFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "Individual", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the JobCandidateEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(JobCandidateFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case JobCandidateFieldIndex.JobCandidateID:
					fieldToReturn = new EntityField("JobCandidateID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "JobCandidate", "JobCandidateID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case JobCandidateFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "HumanResources", "JobCandidate", "EmployeeID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case JobCandidateFieldIndex.Resume:
					fieldToReturn = new EntityField("Resume", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "JobCandidate", "Resume", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case JobCandidateFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "JobCandidate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the LocationEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(LocationFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case LocationFieldIndex.LocationID:
					fieldToReturn = new EntityField("LocationID", typeof(System.Int16), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "Location", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case LocationFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Location", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case LocationFieldIndex.CostRate:
					fieldToReturn = new EntityField("CostRate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "Location", "CostRate", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, false, "", (int)fieldIndex);
					break;
				case LocationFieldIndex.Availability:
					fieldToReturn = new EntityField("Availability", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "Location", "Availability", false, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", (int)fieldIndex);
					break;
				case LocationFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Location", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the NameTestTabEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(NameTestTabFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case NameTestTabFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NameTestTab", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case NameTestTabFieldIndex.Avg_grade:
					fieldToReturn = new EntityField("Avg_grade", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "dbo", "NameTestTab", "avg_grade", true, (int)SqlDbType.Decimal, 0, 1, 18, false, false, "", (int)fieldIndex);
					break;
				case NameTestTabFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "NameTestTab", "Name", false, (int)SqlDbType.VarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the NewSequentialIDTestEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(NewSequentialIDTestFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case NewSequentialIDTestFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "dbo", "NewSequentialIDTest", "ID", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case NewSequentialIDTestFieldIndex.Description:
					fieldToReturn = new EntityField("Description", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "NewSequentialIDTest", "Description", false, (int)SqlDbType.VarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the NonPresentTimeEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(NonPresentTimeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case NonPresentTimeFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTime", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case NonPresentTimeFieldIndex.HeaderID:
					fieldToReturn = new EntityField("HeaderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTime", "HeaderID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeFieldIndex.ReasonID:
					fieldToReturn = new EntityField("ReasonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTime", "ReasonID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeFieldIndex.DateStart:
					fieldToReturn = new EntityField("DateStart", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "NonPresentTime", "DateStart", true, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeFieldIndex.DateEnd:
					fieldToReturn = new EntityField("DateEnd", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "NonPresentTime", "DateEnd", true, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeFieldIndex.Notes:
					fieldToReturn = new EntityField("Notes", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "NonPresentTime", "Notes", true, (int)SqlDbType.VarChar, 250, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the NonPresentTimeHeaderEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(NonPresentTimeHeaderFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case NonPresentTimeHeaderFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTimeHeader", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case NonPresentTimeHeaderFieldIndex.UserID:
					fieldToReturn = new EntityField("UserID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTimeHeader", "UserID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeHeaderFieldIndex.ApprovedFromID:
					fieldToReturn = new EntityField("ApprovedFromID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "NonPresentTimeHeader", "ApprovedFromID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeHeaderFieldIndex.EnteredDate:
					fieldToReturn = new EntityField("EnteredDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "NonPresentTimeHeader", "EnteredDate", true, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case NonPresentTimeHeaderFieldIndex.ApprovedDate:
					fieldToReturn = new EntityField("ApprovedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "dbo", "NonPresentTimeHeader", "ApprovedDate", true, (int)SqlDbType.SmallDateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Product", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductNumber:
					fieldToReturn = new EntityField("ProductNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "ProductNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.MakeFlag:
					fieldToReturn = new EntityField("MakeFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Production", "Product", "MakeFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.FinishedGoodsFlag:
					fieldToReturn = new EntityField("FinishedGoodsFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Production", "Product", "FinishedGoodsFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Color:
					fieldToReturn = new EntityField("Color", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "Color", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.SafetyStockLevel:
					fieldToReturn = new EntityField("SafetyStockLevel", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "Product", "SafetyStockLevel", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ReorderPoint:
					fieldToReturn = new EntityField("ReorderPoint", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "Product", "ReorderPoint", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.StandardCost:
					fieldToReturn = new EntityField("StandardCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "Product", "StandardCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ListPrice:
					fieldToReturn = new EntityField("ListPrice", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "Product", "ListPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Size:
					fieldToReturn = new EntityField("Size", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "Size", true, (int)SqlDbType.NVarChar, 5, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.SizeUnitMeasureCode:
					fieldToReturn = new EntityField("SizeUnitMeasureCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "SizeUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.WeightUnitMeasureCode:
					fieldToReturn = new EntityField("WeightUnitMeasureCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "WeightUnitMeasureCode", true, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Weight:
					fieldToReturn = new EntityField("Weight", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "Product", "Weight", true, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.DaysToManufacture:
					fieldToReturn = new EntityField("DaysToManufacture", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Product", "DaysToManufacture", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductLine:
					fieldToReturn = new EntityField("ProductLine", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "ProductLine", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Class:
					fieldToReturn = new EntityField("Class", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "Class", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Style:
					fieldToReturn = new EntityField("Style", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "Product", "Style", true, (int)SqlDbType.NChar, 2, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductSubcategoryID:
					fieldToReturn = new EntityField("ProductSubcategoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Product", "ProductSubcategoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ProductModelID:
					fieldToReturn = new EntityField("ProductModelID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "Product", "ProductModelID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.SellStartDate:
					fieldToReturn = new EntityField("SellStartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Product", "SellStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.SellEndDate:
					fieldToReturn = new EntityField("SellEndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Product", "SellEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.DiscontinuedDate:
					fieldToReturn = new EntityField("DiscontinuedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Product", "DiscontinuedDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "Product", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "Product", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductCategoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductCategoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductCategoryFieldIndex.ProductCategoryID:
					fieldToReturn = new EntityField("ProductCategoryID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductCategory", "ProductCategoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductCategoryFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductCategory", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductCategoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "ProductCategory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductCategoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductCategory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductCostHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductCostHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductCostHistoryFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductCostHistory", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductCostHistoryFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductCostHistory", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case ProductCostHistoryFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductCostHistory", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductCostHistoryFieldIndex.StandardCost:
					fieldToReturn = new EntityField("StandardCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "ProductCostHistory", "StandardCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductCostHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductCostHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductDescriptionEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductDescriptionFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductDescriptionFieldIndex.ProductDescriptionID:
					fieldToReturn = new EntityField("ProductDescriptionID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductDescription", "ProductDescriptionID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductDescriptionFieldIndex.Description:
					fieldToReturn = new EntityField("Description", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductDescription", "Description", false, (int)SqlDbType.NVarChar, 400, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductDescriptionFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "ProductDescription", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductDescriptionFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductDescription", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductDocumentEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductDocumentFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductDocumentFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductDocument", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductDocumentFieldIndex.DocumentID:
					fieldToReturn = new EntityField("DocumentID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductDocument", "DocumentID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductDocumentFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductDocument", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductInventoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductInventoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductInventoryFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductInventory", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.LocationID:
					fieldToReturn = new EntityField("LocationID", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "ProductInventory", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.Shelf:
					fieldToReturn = new EntityField("Shelf", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductInventory", "Shelf", false, (int)SqlDbType.NVarChar, 10, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.Bin:
					fieldToReturn = new EntityField("Bin", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Production", "ProductInventory", "Bin", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.Quantity:
					fieldToReturn = new EntityField("Quantity", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "ProductInventory", "Quantity", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "ProductInventory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductInventoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductInventory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductListPriceHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductListPriceHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductListPriceHistoryFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductListPriceHistory", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductListPriceHistoryFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductListPriceHistory", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case ProductListPriceHistoryFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductListPriceHistory", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductListPriceHistoryFieldIndex.ListPrice:
					fieldToReturn = new EntityField("ListPrice", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "ProductListPriceHistory", "ListPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductListPriceHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductListPriceHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductModelEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductModelFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductModelFieldIndex.ProductModelID:
					fieldToReturn = new EntityField("ProductModelID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductModel", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductModelFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductModel", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductModelFieldIndex.CatalogDescription:
					fieldToReturn = new EntityField("CatalogDescription", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductModel", "CatalogDescription", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductModelFieldIndex.Instructions:
					fieldToReturn = new EntityField("Instructions", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductModel", "Instructions", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductModelFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "ProductModel", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductModelFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductModel", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductModelIllustrationEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductModelIllustrationFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductModelIllustrationFieldIndex.ProductModelID:
					fieldToReturn = new EntityField("ProductModelID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductModelIllustration", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductModelIllustrationFieldIndex.IllustrationID:
					fieldToReturn = new EntityField("IllustrationID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductModelIllustration", "IllustrationID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductModelIllustrationFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductModelIllustration", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductModelProductDescriptionCultureEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductModelProductDescriptionCultureFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductModelProductDescriptionCultureFieldIndex.ProductModelID:
					fieldToReturn = new EntityField("ProductModelID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductModelProductDescriptionCulture", "ProductModelID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductModelProductDescriptionCultureFieldIndex.ProductDescriptionID:
					fieldToReturn = new EntityField("ProductDescriptionID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductModelProductDescriptionCulture", "ProductDescriptionID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductModelProductDescriptionCultureFieldIndex.CultureID:
					fieldToReturn = new EntityField("CultureID", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductModelProductDescriptionCulture", "CultureID", false, (int)SqlDbType.NChar, 6, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case ProductModelProductDescriptionCultureFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductModelProductDescriptionCulture", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductPhotoEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductPhotoFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductPhotoFieldIndex.ProductPhotoID:
					fieldToReturn = new EntityField("ProductPhotoID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductPhoto", "ProductPhotoID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductPhotoFieldIndex.ThumbNailPhoto:
					fieldToReturn = new EntityField("ThumbNailPhoto", typeof(System.Byte[]), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte[])), "Production", "ProductPhoto", "ThumbNailPhoto", true, (int)SqlDbType.VarBinary, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductPhotoFieldIndex.ThumbnailPhotoFileName:
					fieldToReturn = new EntityField("ThumbnailPhotoFileName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductPhoto", "ThumbnailPhotoFileName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductPhotoFieldIndex.LargePhoto:
					fieldToReturn = new EntityField("LargePhoto", typeof(System.Byte[]), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte[])), "Production", "ProductPhoto", "LargePhoto", true, (int)SqlDbType.VarBinary, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductPhotoFieldIndex.LargePhotoFileName:
					fieldToReturn = new EntityField("LargePhotoFileName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductPhoto", "LargePhotoFileName", true, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductPhotoFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductPhoto", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductProductPhotoEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductProductPhotoFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductProductPhotoFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductProductPhoto", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductProductPhotoFieldIndex.ProductPhotoID:
					fieldToReturn = new EntityField("ProductPhotoID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductProductPhoto", "ProductPhotoID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductProductPhotoFieldIndex.Primary:
					fieldToReturn = new EntityField("Primary", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Production", "ProductProductPhoto", "Primary", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductProductPhotoFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductProductPhoto", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductReviewEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductReviewFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductReviewFieldIndex.ProductReviewID:
					fieldToReturn = new EntityField("ProductReviewID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductReview", "ProductReviewID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductReview", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.ReviewerName:
					fieldToReturn = new EntityField("ReviewerName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductReview", "ReviewerName", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.ReviewDate:
					fieldToReturn = new EntityField("ReviewDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductReview", "ReviewDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.EmailAddress:
					fieldToReturn = new EntityField("EmailAddress", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductReview", "EmailAddress", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.Rating:
					fieldToReturn = new EntityField("Rating", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductReview", "Rating", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.Comments:
					fieldToReturn = new EntityField("Comments", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductReview", "Comments", true, (int)SqlDbType.NVarChar, 3850, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductReviewFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductReview", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductSubcategoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductSubcategoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductSubcategoryFieldIndex.ProductSubcategoryID:
					fieldToReturn = new EntityField("ProductSubcategoryID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductSubcategory", "ProductSubcategoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ProductSubcategoryFieldIndex.ProductCategoryID:
					fieldToReturn = new EntityField("ProductCategoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "ProductSubcategory", "ProductCategoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductSubcategoryFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ProductSubcategory", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductSubcategoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Production", "ProductSubcategory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductSubcategoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ProductSubcategory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ProductVendorEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ProductVendorFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ProductVendorFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.VendorID:
					fieldToReturn = new EntityField("VendorID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.AverageLeadTime:
					fieldToReturn = new EntityField("AverageLeadTime", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "AverageLeadTime", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.StandardPrice:
					fieldToReturn = new EntityField("StandardPrice", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "ProductVendor", "StandardPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.LastReceiptCost:
					fieldToReturn = new EntityField("LastReceiptCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "ProductVendor", "LastReceiptCost", true, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.LastReceiptDate:
					fieldToReturn = new EntityField("LastReceiptDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "ProductVendor", "LastReceiptDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.MinOrderQty:
					fieldToReturn = new EntityField("MinOrderQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "MinOrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.MaxOrderQty:
					fieldToReturn = new EntityField("MaxOrderQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "MaxOrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.OnOrderQty:
					fieldToReturn = new EntityField("OnOrderQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ProductVendor", "OnOrderQty", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.UnitMeasureCode:
					fieldToReturn = new EntityField("UnitMeasureCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Purchasing", "ProductVendor", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ProductVendorFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "ProductVendor", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the PurchaseOrderDetailEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(PurchaseOrderDetailFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case PurchaseOrderDetailFieldIndex.PurchaseOrderID:
					fieldToReturn = new EntityField("PurchaseOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderDetail", "PurchaseOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.PurchaseOrderDetailID:
					fieldToReturn = new EntityField("PurchaseOrderDetailID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderDetail", "PurchaseOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.DueDate:
					fieldToReturn = new EntityField("DueDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "PurchaseOrderDetail", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.OrderQty:
					fieldToReturn = new EntityField("OrderQty", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Purchasing", "PurchaseOrderDetail", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderDetail", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.UnitPrice:
					fieldToReturn = new EntityField("UnitPrice", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderDetail", "UnitPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.LineTotal:
					fieldToReturn = new EntityField("LineTotal", typeof(System.Decimal), true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderDetail", "LineTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.ReceivedQty:
					fieldToReturn = new EntityField("ReceivedQty", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderDetail", "ReceivedQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.RejectedQty:
					fieldToReturn = new EntityField("RejectedQty", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderDetail", "RejectedQty", false, (int)SqlDbType.Decimal, 0, 2, 8, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.StockedQty:
					fieldToReturn = new EntityField("StockedQty", typeof(System.Decimal), true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderDetail", "StockedQty", false, (int)SqlDbType.Decimal, 0, 2, 9, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderDetailFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "PurchaseOrderDetail", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the PurchaseOrderHeaderEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(PurchaseOrderHeaderFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case PurchaseOrderHeaderFieldIndex.PurchaseOrderID:
					fieldToReturn = new EntityField("PurchaseOrderID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderHeader", "PurchaseOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.RevisionNumber:
					fieldToReturn = new EntityField("RevisionNumber", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Purchasing", "PurchaseOrderHeader", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.Status:
					fieldToReturn = new EntityField("Status", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Purchasing", "PurchaseOrderHeader", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.EmployeeID:
					fieldToReturn = new EntityField("EmployeeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderHeader", "EmployeeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.VendorID:
					fieldToReturn = new EntityField("VendorID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderHeader", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.ShipMethodID:
					fieldToReturn = new EntityField("ShipMethodID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "PurchaseOrderHeader", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.OrderDate:
					fieldToReturn = new EntityField("OrderDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "PurchaseOrderHeader", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.ShipDate:
					fieldToReturn = new EntityField("ShipDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "PurchaseOrderHeader", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.SubTotal:
					fieldToReturn = new EntityField("SubTotal", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderHeader", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.TaxAmt:
					fieldToReturn = new EntityField("TaxAmt", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderHeader", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.Freight:
					fieldToReturn = new EntityField("Freight", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderHeader", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.TotalDue:
					fieldToReturn = new EntityField("TotalDue", typeof(System.Decimal), true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "PurchaseOrderHeader", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case PurchaseOrderHeaderFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "PurchaseOrderHeader", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ReasonEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ReasonFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ReasonFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "Reason", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ReasonFieldIndex.Reason:
					fieldToReturn = new EntityField("Reason", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "Reason", "Reason", true, (int)SqlDbType.VarChar, 150, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderDetailEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesOrderDetailFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesOrderDetailFieldIndex.SalesOrderID:
					fieldToReturn = new EntityField("SalesOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderDetail", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.SalesOrderDetailID:
					fieldToReturn = new EntityField("SalesOrderDetailID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderDetail", "SalesOrderDetailID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.CarrierTrackingNumber:
					fieldToReturn = new EntityField("CarrierTrackingNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderDetail", "CarrierTrackingNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.OrderQty:
					fieldToReturn = new EntityField("OrderQty", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Sales", "SalesOrderDetail", "OrderQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderDetail", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.SpecialOfferID:
					fieldToReturn = new EntityField("SpecialOfferID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderDetail", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.UnitPrice:
					fieldToReturn = new EntityField("UnitPrice", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderDetail", "UnitPrice", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.UnitPriceDiscount:
					fieldToReturn = new EntityField("UnitPriceDiscount", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderDetail", "UnitPriceDiscount", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.LineTotal:
					fieldToReturn = new EntityField("LineTotal", typeof(System.Decimal), true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderDetail", "LineTotal", false, (int)SqlDbType.Decimal, 0, 6, 38, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesOrderDetail", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderDetailFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderDetail", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderHeaderEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesOrderHeaderFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesOrderHeaderFieldIndex.SalesOrderID:
					fieldToReturn = new EntityField("SalesOrderID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.RevisionNumber:
					fieldToReturn = new EntityField("RevisionNumber", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Sales", "SalesOrderHeader", "RevisionNumber", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.OrderDate:
					fieldToReturn = new EntityField("OrderDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderHeader", "OrderDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.DueDate:
					fieldToReturn = new EntityField("DueDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderHeader", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipDate:
					fieldToReturn = new EntityField("ShipDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderHeader", "ShipDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Status:
					fieldToReturn = new EntityField("Status", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Sales", "SalesOrderHeader", "Status", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.OnlineOrderFlag:
					fieldToReturn = new EntityField("OnlineOrderFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Sales", "SalesOrderHeader", "OnlineOrderFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SalesOrderNumber:
					fieldToReturn = new EntityField("SalesOrderNumber", typeof(System.String), true, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderHeader", "SalesOrderNumber", false, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.PurchaseOrderNumber:
					fieldToReturn = new EntityField("PurchaseOrderNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderHeader", "PurchaseOrderNumber", true, (int)SqlDbType.NVarChar, 25, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.AccountNumber:
					fieldToReturn = new EntityField("AccountNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderHeader", "AccountNumber", true, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SalesPersonID:
					fieldToReturn = new EntityField("SalesPersonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.BillToAddressID:
					fieldToReturn = new EntityField("BillToAddressID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "BillToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipToAddressID:
					fieldToReturn = new EntityField("ShipToAddressID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "ShipToAddressID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ShipMethodID:
					fieldToReturn = new EntityField("ShipMethodID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CreditCardID:
					fieldToReturn = new EntityField("CreditCardID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "CreditCardID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CreditCardApprovalCode:
					fieldToReturn = new EntityField("CreditCardApprovalCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderHeader", "CreditCardApprovalCode", true, (int)SqlDbType.VarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.CurrencyRateID:
					fieldToReturn = new EntityField("CurrencyRateID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeader", "CurrencyRateID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.SubTotal:
					fieldToReturn = new EntityField("SubTotal", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderHeader", "SubTotal", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TaxAmt:
					fieldToReturn = new EntityField("TaxAmt", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderHeader", "TaxAmt", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Freight:
					fieldToReturn = new EntityField("Freight", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderHeader", "Freight", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.TotalDue:
					fieldToReturn = new EntityField("TotalDue", typeof(System.Decimal), true, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesOrderHeader", "TotalDue", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Comment:
					fieldToReturn = new EntityField("Comment", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesOrderHeader", "Comment", true, (int)SqlDbType.NVarChar, 128, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesOrderHeader", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderHeader", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesOrderHeaderSalesReasonEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesOrderHeaderSalesReasonFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID:
					fieldToReturn = new EntityField("SalesOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeaderSalesReason", "SalesOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderSalesReasonFieldIndex.SalesReasonID:
					fieldToReturn = new EntityField("SalesReasonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesOrderHeaderSalesReason", "SalesReasonID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesOrderHeaderSalesReasonFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesOrderHeaderSalesReason", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesPersonEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesPersonFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesPersonFieldIndex.SalesPersonID:
					fieldToReturn = new EntityField("SalesPersonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesPerson", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesPerson", "TerritoryID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.SalesQuota:
					fieldToReturn = new EntityField("SalesQuota", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPerson", "SalesQuota", true, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.Bonus:
					fieldToReturn = new EntityField("Bonus", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPerson", "Bonus", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.CommissionPct:
					fieldToReturn = new EntityField("CommissionPct", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPerson", "CommissionPct", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.SalesYTD:
					fieldToReturn = new EntityField("SalesYTD", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPerson", "SalesYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.SalesLastYear:
					fieldToReturn = new EntityField("SalesLastYear", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPerson", "SalesLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesPerson", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesPerson", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesPersonQuotaHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesPersonQuotaHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesPersonQuotaHistoryFieldIndex.SalesPersonID:
					fieldToReturn = new EntityField("SalesPersonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesPersonQuotaHistory", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesPersonQuotaHistoryFieldIndex.QuotaDate:
					fieldToReturn = new EntityField("QuotaDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesPersonQuotaHistory", "QuotaDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case SalesPersonQuotaHistoryFieldIndex.SalesQuota:
					fieldToReturn = new EntityField("SalesQuota", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesPersonQuotaHistory", "SalesQuota", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonQuotaHistoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesPersonQuotaHistory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesPersonQuotaHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesPersonQuotaHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesReasonEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesReasonFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesReasonFieldIndex.SalesReasonID:
					fieldToReturn = new EntityField("SalesReasonID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesReason", "SalesReasonID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SalesReasonFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesReason", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesReasonFieldIndex.ReasonType:
					fieldToReturn = new EntityField("ReasonType", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesReason", "ReasonType", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesReasonFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesReason", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesTaxRateEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesTaxRateFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesTaxRateFieldIndex.SalesTaxRateID:
					fieldToReturn = new EntityField("SalesTaxRateID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesTaxRate", "SalesTaxRateID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.StateProvinceID:
					fieldToReturn = new EntityField("StateProvinceID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesTaxRate", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.TaxType:
					fieldToReturn = new EntityField("TaxType", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Sales", "SalesTaxRate", "TaxType", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.TaxRate:
					fieldToReturn = new EntityField("TaxRate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesTaxRate", "TaxRate", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, false, "", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesTaxRate", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesTaxRate", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTaxRateFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesTaxRate", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesTerritoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesTerritoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesTerritoryFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesTerritory", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesTerritory", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesTerritory", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.Group:
					fieldToReturn = new EntityField("Group", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SalesTerritory", "Group", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.SalesYTD:
					fieldToReturn = new EntityField("SalesYTD", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesTerritory", "SalesYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.SalesLastYear:
					fieldToReturn = new EntityField("SalesLastYear", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesTerritory", "SalesLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.CostYTD:
					fieldToReturn = new EntityField("CostYTD", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesTerritory", "CostYTD", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.CostLastYear:
					fieldToReturn = new EntityField("CostLastYear", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SalesTerritory", "CostLastYear", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesTerritory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesTerritory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SalesTerritoryHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SalesTerritoryHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SalesTerritoryHistoryFieldIndex.SalesPersonID:
					fieldToReturn = new EntityField("SalesPersonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesTerritoryHistory", "SalesPersonID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryHistoryFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SalesTerritoryHistory", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryHistoryFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesTerritoryHistory", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryHistoryFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesTerritoryHistory", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryHistoryFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SalesTerritoryHistory", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SalesTerritoryHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SalesTerritoryHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ScrapReasonEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ScrapReasonFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ScrapReasonFieldIndex.ScrapReasonID:
					fieldToReturn = new EntityField("ScrapReasonID", typeof(System.Int16), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "ScrapReason", "ScrapReasonID", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ScrapReasonFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "ScrapReason", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ScrapReasonFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "ScrapReason", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SequentialIDSubTypeEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SequentialIDSubTypeFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SequentialIDSubTypeFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "dbo", "SequentialIDSubType", "ID", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case SequentialIDSubTypeFieldIndex.IntValue:
					fieldToReturn = new EntityField("IntValue", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "SequentialIDSubType", "IntValue", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ShiftEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ShiftFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ShiftFieldIndex.ShiftID:
					fieldToReturn = new EntityField("ShiftID", typeof(System.Byte), true, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "HumanResources", "Shift", "ShiftID", false, (int)SqlDbType.TinyInt, 0, 0, 3, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ShiftFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "HumanResources", "Shift", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShiftFieldIndex.StartTime:
					fieldToReturn = new EntityField("StartTime", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Shift", "StartTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShiftFieldIndex.EndTime:
					fieldToReturn = new EntityField("EndTime", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Shift", "EndTime", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShiftFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "HumanResources", "Shift", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ShipMethodEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ShipMethodFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ShipMethodFieldIndex.ShipMethodID:
					fieldToReturn = new EntityField("ShipMethodID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "ShipMethod", "ShipMethodID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Purchasing", "ShipMethod", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ShipBase:
					fieldToReturn = new EntityField("ShipBase", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "ShipMethod", "ShipBase", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ShipRate:
					fieldToReturn = new EntityField("ShipRate", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Purchasing", "ShipMethod", "ShipRate", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Purchasing", "ShipMethod", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShipMethodFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "ShipMethod", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the ShoppingCartItemEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(ShoppingCartItemFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case ShoppingCartItemFieldIndex.ShoppingCartItemID:
					fieldToReturn = new EntityField("ShoppingCartItemID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "ShoppingCartItem", "ShoppingCartItemID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case ShoppingCartItemFieldIndex.ShoppingCartID:
					fieldToReturn = new EntityField("ShoppingCartID", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "ShoppingCartItem", "ShoppingCartID", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShoppingCartItemFieldIndex.Quantity:
					fieldToReturn = new EntityField("Quantity", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "ShoppingCartItem", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ShoppingCartItemFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "ShoppingCartItem", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case ShoppingCartItemFieldIndex.DateCreated:
					fieldToReturn = new EntityField("DateCreated", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "ShoppingCartItem", "DateCreated", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case ShoppingCartItemFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "ShoppingCartItem", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SpecialOfferFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SpecialOfferFieldIndex.SpecialOfferID:
					fieldToReturn = new EntityField("SpecialOfferID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SpecialOffer", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Description:
					fieldToReturn = new EntityField("Description", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SpecialOffer", "Description", false, (int)SqlDbType.NVarChar, 255, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.DiscountPct:
					fieldToReturn = new EntityField("DiscountPct", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Sales", "SpecialOffer", "DiscountPct", false, (int)SqlDbType.SmallMoney, 0, 4, 10, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Type:
					fieldToReturn = new EntityField("Type", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SpecialOffer", "Type", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Category:
					fieldToReturn = new EntityField("Category", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "SpecialOffer", "Category", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SpecialOffer", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SpecialOffer", "EndDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.MinQty:
					fieldToReturn = new EntityField("MinQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SpecialOffer", "MinQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.MaxQty:
					fieldToReturn = new EntityField("MaxQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SpecialOffer", "MaxQty", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SpecialOffer", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SpecialOffer", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the SpecialOfferProductEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(SpecialOfferProductFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case SpecialOfferProductFieldIndex.SpecialOfferID:
					fieldToReturn = new EntityField("SpecialOfferID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SpecialOfferProduct", "SpecialOfferID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "SpecialOfferProduct", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "SpecialOfferProduct", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case SpecialOfferProductFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "SpecialOfferProduct", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the StateProvinceEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(StateProvinceFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case StateProvinceFieldIndex.StateProvinceID:
					fieldToReturn = new EntityField("StateProvinceID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "StateProvince", "StateProvinceID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.StateProvinceCode:
					fieldToReturn = new EntityField("StateProvinceCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "StateProvince", "StateProvinceCode", false, (int)SqlDbType.NChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.CountryRegionCode:
					fieldToReturn = new EntityField("CountryRegionCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "StateProvince", "CountryRegionCode", false, (int)SqlDbType.NVarChar, 3, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.IsOnlyStateProvinceFlag:
					fieldToReturn = new EntityField("IsOnlyStateProvinceFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Person", "StateProvince", "IsOnlyStateProvinceFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Person", "StateProvince", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.TerritoryID:
					fieldToReturn = new EntityField("TerritoryID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Person", "StateProvince", "TerritoryID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Person", "StateProvince", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StateProvinceFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Person", "StateProvince", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the StoreEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(StoreFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case StoreFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Store", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case StoreFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Store", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StoreFieldIndex.SalesPersonID:
					fieldToReturn = new EntityField("SalesPersonID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "Store", "SalesPersonID", true, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case StoreFieldIndex.Demographics:
					fieldToReturn = new EntityField("Demographics", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Sales", "Store", "Demographics", true, (int)SqlDbType.VarChar, -1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StoreFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "Store", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StoreFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "Store", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the StoreContactEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(StoreContactFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case StoreContactFieldIndex.CustomerID:
					fieldToReturn = new EntityField("CustomerID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "StoreContact", "CustomerID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case StoreContactFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "StoreContact", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case StoreContactFieldIndex.ContactTypeID:
					fieldToReturn = new EntityField("ContactTypeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Sales", "StoreContact", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case StoreContactFieldIndex.Rowguid:
					fieldToReturn = new EntityField("Rowguid", typeof(System.Guid), false, TypeDefaultValue.GetDefaultValue(typeof(System.Guid)), "Sales", "StoreContact", "rowguid", false, (int)SqlDbType.UniqueIdentifier, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case StoreContactFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Sales", "StoreContact", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the TransactionHistoryEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(TransactionHistoryFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case TransactionHistoryFieldIndex.TransactionID:
					fieldToReturn = new EntityField("TransactionID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistory", "TransactionID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistory", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.ReferenceOrderID:
					fieldToReturn = new EntityField("ReferenceOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistory", "ReferenceOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.ReferenceOrderLineID:
					fieldToReturn = new EntityField("ReferenceOrderLineID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistory", "ReferenceOrderLineID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.TransactionDate:
					fieldToReturn = new EntityField("TransactionDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "TransactionHistory", "TransactionDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.TransactionType:
					fieldToReturn = new EntityField("TransactionType", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "TransactionHistory", "TransactionType", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.Quantity:
					fieldToReturn = new EntityField("Quantity", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistory", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.ActualCost:
					fieldToReturn = new EntityField("ActualCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "TransactionHistory", "ActualCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "TransactionHistory", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the TransactionHistoryArchiveEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(TransactionHistoryArchiveFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case TransactionHistoryArchiveFieldIndex.TransactionID:
					fieldToReturn = new EntityField("TransactionID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistoryArchive", "TransactionID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistoryArchive", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.ReferenceOrderID:
					fieldToReturn = new EntityField("ReferenceOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistoryArchive", "ReferenceOrderID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.ReferenceOrderLineID:
					fieldToReturn = new EntityField("ReferenceOrderLineID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistoryArchive", "ReferenceOrderLineID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.TransactionDate:
					fieldToReturn = new EntityField("TransactionDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "TransactionHistoryArchive", "TransactionDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.TransactionType:
					fieldToReturn = new EntityField("TransactionType", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "TransactionHistoryArchive", "TransactionType", false, (int)SqlDbType.NChar, 1, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.Quantity:
					fieldToReturn = new EntityField("Quantity", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "TransactionHistoryArchive", "Quantity", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.ActualCost:
					fieldToReturn = new EntityField("ActualCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "TransactionHistoryArchive", "ActualCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case TransactionHistoryArchiveFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "TransactionHistoryArchive", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the UdtTestEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(UdtTestFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case UdtTestFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "UdtTest", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case UdtTestFieldIndex.UdtField:
					fieldToReturn = new EntityField("UdtField", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UdtTest", "UdtField", true, (int)SqlDbType.VarChar, 17, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the UnitMeasureEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(UnitMeasureFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case UnitMeasureFieldIndex.UnitMeasureCode:
					fieldToReturn = new EntityField("UnitMeasureCode", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "UnitMeasure", "UnitMeasureCode", false, (int)SqlDbType.NChar, 3, 0, 0, true, false, "", (int)fieldIndex);
					break;
				case UnitMeasureFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Production", "UnitMeasure", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case UnitMeasureFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "UnitMeasure", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the UserDetailEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(UserDetailFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case UserDetailFieldIndex.ID:
					fieldToReturn = new EntityField("ID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "dbo", "UserDetail", "ID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case UserDetailFieldIndex.UserName:
					fieldToReturn = new EntityField("UserName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UserDetail", "UserName", false, (int)SqlDbType.VarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case UserDetailFieldIndex.SignaturePicPath:
					fieldToReturn = new EntityField("SignaturePicPath", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UserDetail", "SignaturePicPath", true, (int)SqlDbType.VarChar, 200, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case UserDetailFieldIndex.FullName:
					fieldToReturn = new EntityField("FullName", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UserDetail", "FullName", true, (int)SqlDbType.VarChar, 100, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case UserDetailFieldIndex.EmployeeNr:
					fieldToReturn = new EntityField("EmployeeNr", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UserDetail", "EmployeeNr", true, (int)SqlDbType.VarChar, 10, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case UserDetailFieldIndex.Department:
					fieldToReturn = new EntityField("Department", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "dbo", "UserDetail", "Department", true, (int)SqlDbType.VarChar, 20, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the VendorEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(VendorFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case VendorFieldIndex.VendorID:
					fieldToReturn = new EntityField("VendorID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "Vendor", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case VendorFieldIndex.AccountNumber:
					fieldToReturn = new EntityField("AccountNumber", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Purchasing", "Vendor", "AccountNumber", false, (int)SqlDbType.NVarChar, 15, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.Name:
					fieldToReturn = new EntityField("Name", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Purchasing", "Vendor", "Name", false, (int)SqlDbType.NVarChar, 50, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.CreditRating:
					fieldToReturn = new EntityField("CreditRating", typeof(System.Byte), false, TypeDefaultValue.GetDefaultValue(typeof(System.Byte)), "Purchasing", "Vendor", "CreditRating", false, (int)SqlDbType.TinyInt, 0, 0, 3, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.PreferredVendorStatus:
					fieldToReturn = new EntityField("PreferredVendorStatus", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Purchasing", "Vendor", "PreferredVendorStatus", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.ActiveFlag:
					fieldToReturn = new EntityField("ActiveFlag", typeof(System.Boolean), false, TypeDefaultValue.GetDefaultValue(typeof(System.Boolean)), "Purchasing", "Vendor", "ActiveFlag", false, (int)SqlDbType.Bit, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.PurchasingWebServiceURL:
					fieldToReturn = new EntityField("PurchasingWebServiceURL", typeof(System.String), false, TypeDefaultValue.GetDefaultValue(typeof(System.String)), "Purchasing", "Vendor", "PurchasingWebServiceURL", true, (int)SqlDbType.NVarChar, 1024, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case VendorFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "Vendor", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the VendorAddressEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(VendorAddressFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case VendorAddressFieldIndex.VendorID:
					fieldToReturn = new EntityField("VendorID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorAddress", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case VendorAddressFieldIndex.AddressID:
					fieldToReturn = new EntityField("AddressID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorAddress", "AddressID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case VendorAddressFieldIndex.AddressTypeID:
					fieldToReturn = new EntityField("AddressTypeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorAddress", "AddressTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case VendorAddressFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "VendorAddress", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the VendorContactEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(VendorContactFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case VendorContactFieldIndex.VendorID:
					fieldToReturn = new EntityField("VendorID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorContact", "VendorID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case VendorContactFieldIndex.ContactID:
					fieldToReturn = new EntityField("ContactID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorContact", "ContactID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case VendorContactFieldIndex.ContactTypeID:
					fieldToReturn = new EntityField("ContactTypeID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Purchasing", "VendorContact", "ContactTypeID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case VendorContactFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Purchasing", "VendorContact", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the WorkOrderEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(WorkOrderFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case WorkOrderFieldIndex.WorkOrderID:
					fieldToReturn = new EntityField("WorkOrderID", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrder", "WorkOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, true, "SCOPE_IDENTITY()", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrder", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.OrderQty:
					fieldToReturn = new EntityField("OrderQty", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrder", "OrderQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.StockedQty:
					fieldToReturn = new EntityField("StockedQty", typeof(System.Int32), true, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrder", "StockedQty", false, (int)SqlDbType.Int, 0, 0, 10, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.ScrappedQty:
					fieldToReturn = new EntityField("ScrappedQty", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "WorkOrder", "ScrappedQty", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.StartDate:
					fieldToReturn = new EntityField("StartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrder", "StartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.EndDate:
					fieldToReturn = new EntityField("EndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrder", "EndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.DueDate:
					fieldToReturn = new EntityField("DueDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrder", "DueDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.ScrapReasonID:
					fieldToReturn = new EntityField("ScrapReasonID", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "WorkOrder", "ScrapReasonID", true, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrder", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
		/// <summary>
		/// Creates a new IEntityField instance for usage in the EntityFields object for the WorkOrderRoutingEntity. 
		/// Which EntityField is created is specified by iField
		/// </summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in iField</returns>
		public static IEntityField Create(WorkOrderRoutingFieldIndex fieldIndex)
		{
			IEntityField fieldToReturn = null;
			switch(fieldIndex)
			{
				case WorkOrderRoutingFieldIndex.WorkOrderID:
					fieldToReturn = new EntityField("WorkOrderID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrderRouting", "WorkOrderID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ProductID:
					fieldToReturn = new EntityField("ProductID", typeof(System.Int32), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int32)), "Production", "WorkOrderRouting", "ProductID", false, (int)SqlDbType.Int, 0, 0, 10, true, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.OperationSequence:
					fieldToReturn = new EntityField("OperationSequence", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "WorkOrderRouting", "OperationSequence", false, (int)SqlDbType.SmallInt, 0, 0, 5, true, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.LocationID:
					fieldToReturn = new EntityField("LocationID", typeof(System.Int16), false, TypeDefaultValue.GetDefaultValue(typeof(System.Int16)), "Production", "WorkOrderRouting", "LocationID", false, (int)SqlDbType.SmallInt, 0, 0, 5, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ScheduledStartDate:
					fieldToReturn = new EntityField("ScheduledStartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrderRouting", "ScheduledStartDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ScheduledEndDate:
					fieldToReturn = new EntityField("ScheduledEndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrderRouting", "ScheduledEndDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ActualStartDate:
					fieldToReturn = new EntityField("ActualStartDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrderRouting", "ActualStartDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ActualEndDate:
					fieldToReturn = new EntityField("ActualEndDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrderRouting", "ActualEndDate", true, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ActualResourceHrs:
					fieldToReturn = new EntityField("ActualResourceHrs", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "WorkOrderRouting", "ActualResourceHrs", true, (int)SqlDbType.Decimal, 0, 4, 9, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.PlannedCost:
					fieldToReturn = new EntityField("PlannedCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "WorkOrderRouting", "PlannedCost", false, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ActualCost:
					fieldToReturn = new EntityField("ActualCost", typeof(System.Decimal), false, TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)), "Production", "WorkOrderRouting", "ActualCost", true, (int)SqlDbType.Money, 0, 4, 19, false, false, "", (int)fieldIndex);
					break;
				case WorkOrderRoutingFieldIndex.ModifiedDate:
					fieldToReturn = new EntityField("ModifiedDate", typeof(System.DateTime), false, TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)), "Production", "WorkOrderRouting", "ModifiedDate", false, (int)SqlDbType.DateTime, 0, 0, 0, false, false, "", (int)fieldIndex);
					break;
			}

			return fieldToReturn;
		}
	
	

	}
}
