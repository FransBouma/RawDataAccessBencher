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
	/// Class which eases the creation of the different predicate clauses defined in the ORM support classes. 
	/// Use these methods to create predicate clauses for filters without a lot of code.
	/// </summary>
	public class PredicateFactory
	{
		/// <summary>
		/// Static class, no CTor
		/// </summary>
		private PredicateFactory()
		{
		}

		#region FieldCompareValuePredicate creators (2 per entity type)
	
		/// <summary>
		/// FieldCompareValuePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AddressTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AWBuildVersionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(AWBuildVersionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(BillOfMaterialsFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(BillOfMaterialsFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactCreditCardFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactCreditCardFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ContactTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CountryRegionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CountryRegionCurrencyFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CountryRegionCurrencyFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CreativeAddressesFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CreativeAddressesFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CreditCardFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CreditCardFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CultureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CultureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CurrencyFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CurrencyFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CurrencyRateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CurrencyRateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CustomerFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(CustomerAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DatabaseLogFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DatabaseLogFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DepartmentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DepartmentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DocumentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(DocumentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeDepartmentHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeeDepartmentHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeePayHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(EmployeePayHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ErrorLogFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ErrorLogFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(IllustrationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(IllustrationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(IndividualFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(JobCandidateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(JobCandidateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(LocationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(LocationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NameTestTabFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NameTestTabFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NewSequentialIDTestFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NewSequentialIDTestFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NonPresentTimeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NonPresentTimeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NonPresentTimeHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(NonPresentTimeHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductCategoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductCategoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductCostHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductCostHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductDescriptionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductDescriptionFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductDocumentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductDocumentFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductInventoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductInventoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductListPriceHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductListPriceHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelIllustrationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelIllustrationFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelProductDescriptionCultureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductModelProductDescriptionCultureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductPhotoFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductPhotoFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductProductPhotoFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductProductPhotoFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductReviewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductReviewFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductSubcategoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductSubcategoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductVendorFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ProductVendorFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(PurchaseOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(PurchaseOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(PurchaseOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(PurchaseOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderSalesReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesOrderHeaderSalesReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesPersonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesPersonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesPersonQuotaHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesPersonQuotaHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTaxRateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTaxRateFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTerritoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTerritoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTerritoryHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SalesTerritoryHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ScrapReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ScrapReasonFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SequentialIDSubTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SequentialIDSubTypeFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShiftFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShiftFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShipMethodFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShoppingCartItemFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(ShoppingCartItemFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(SpecialOfferProductFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StateProvinceFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StoreFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StoreFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StoreContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(StoreContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(TransactionHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(TransactionHistoryFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(TransactionHistoryArchiveFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(TransactionHistoryArchiveFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UdtTestFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UdtTestFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UnitMeasureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UnitMeasureFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UserDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(UserDetailFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorAddressFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(VendorContactFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(WorkOrderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(WorkOrderFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	

		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(WorkOrderRoutingFieldIndex indexOfField, ComparisonOperator operatorToUse, object value)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="operatorToUse">The comparison operator to use</param>
		/// <param name="value">The value to compare with</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareValuePredicate instance</returns>
		public static FieldCompareValuePredicate CompareValue(WorkOrderRoutingFieldIndex indexOfField, ComparisonOperator operatorToUse, object value, bool negate)
		{
			return new FieldCompareValuePredicate(EntityFieldFactory.Create(indexOfField), operatorToUse, value, negate);
		}
	
		#endregion

		#region FieldCompareValuePredicate creators (2 per typed view type)
	
		#endregion

		#region FieldCompareNullPredicate creators (2 per entity type)
	
		/// <summary>
		/// FieldCompareNullPredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AddressTypeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AWBuildVersionFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(AWBuildVersionFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(BillOfMaterialsFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(BillOfMaterialsFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactCreditCardFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactCreditCardFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactTypeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ContactTypeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CountryRegionFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CountryRegionCurrencyFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CountryRegionCurrencyFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CreativeAddressesFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CreativeAddressesFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CreditCardFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CreditCardFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CultureFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CultureFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CurrencyFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CurrencyFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CurrencyRateFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CurrencyRateFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CustomerFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(CustomerAddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DatabaseLogFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DatabaseLogFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DepartmentFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DepartmentFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DocumentFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(DocumentFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeAddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeDepartmentHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeeDepartmentHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeePayHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(EmployeePayHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ErrorLogFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ErrorLogFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(IllustrationFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(IllustrationFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(IndividualFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(JobCandidateFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(JobCandidateFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(LocationFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(LocationFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NameTestTabFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NameTestTabFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NewSequentialIDTestFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NewSequentialIDTestFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NonPresentTimeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NonPresentTimeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NonPresentTimeHeaderFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(NonPresentTimeHeaderFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductCategoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductCategoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductCostHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductCostHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductDescriptionFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductDescriptionFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductDocumentFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductDocumentFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductInventoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductInventoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductListPriceHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductListPriceHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelIllustrationFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelIllustrationFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelProductDescriptionCultureFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductModelProductDescriptionCultureFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductPhotoFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductPhotoFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductProductPhotoFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductProductPhotoFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductReviewFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductReviewFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductSubcategoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductSubcategoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductVendorFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ProductVendorFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(PurchaseOrderDetailFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(PurchaseOrderDetailFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(PurchaseOrderHeaderFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(PurchaseOrderHeaderFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ReasonFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ReasonFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderDetailFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderSalesReasonFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesOrderHeaderSalesReasonFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesPersonFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesPersonFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesPersonQuotaHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesPersonQuotaHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesReasonFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesReasonFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTaxRateFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTaxRateFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTerritoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTerritoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTerritoryHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SalesTerritoryHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ScrapReasonFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ScrapReasonFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SequentialIDSubTypeFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SequentialIDSubTypeFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShiftFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShiftFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShipMethodFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShoppingCartItemFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(ShoppingCartItemFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(SpecialOfferProductFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StateProvinceFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StoreFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StoreFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StoreContactFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(StoreContactFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(TransactionHistoryFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(TransactionHistoryFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(TransactionHistoryArchiveFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(TransactionHistoryArchiveFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UdtTestFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UdtTestFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UnitMeasureFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UnitMeasureFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UserDetailFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(UserDetailFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorAddressFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorAddressFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorContactFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(VendorContactFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(WorkOrderFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(WorkOrderFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	

		/// <summary>
		/// FieldCompareNullPredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(WorkOrderRoutingFieldIndex indexOfField)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField));
		}

		/// <summary>
		/// FieldCompareNullPredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare to NULL</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>A new FieldCompareNullPredicate instance</returns>
		public static FieldCompareNullPredicate CompareNull(WorkOrderRoutingFieldIndex indexOfField, bool negate)
		{
			return new FieldCompareNullPredicate(EntityFieldFactory.Create(indexOfField), negate);
		}
	
		#endregion

		#region FieldCompareNullPredicate creators (2 per typed view type)
	
		#endregion

		#region FieldBetweenPredicate creators (2 per entity type)
	
		/// <summary>
		/// FieldBetweenPredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AddressTypeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AWBuildVersionFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(AWBuildVersionFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(BillOfMaterialsFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(BillOfMaterialsFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactCreditCardFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactCreditCardFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactTypeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ContactTypeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CountryRegionFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CountryRegionCurrencyFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CountryRegionCurrencyFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CreativeAddressesFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CreativeAddressesFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CreditCardFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CreditCardFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CultureFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CultureFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CurrencyFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CurrencyFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CurrencyRateFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CurrencyRateFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CustomerFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(CustomerAddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DatabaseLogFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DatabaseLogFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DepartmentFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DepartmentFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DocumentFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(DocumentFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeAddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeDepartmentHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeeDepartmentHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeePayHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(EmployeePayHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ErrorLogFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ErrorLogFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(IllustrationFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(IllustrationFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(IndividualFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(JobCandidateFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(JobCandidateFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(LocationFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(LocationFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NameTestTabFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NameTestTabFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NewSequentialIDTestFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NewSequentialIDTestFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NonPresentTimeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NonPresentTimeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NonPresentTimeHeaderFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(NonPresentTimeHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductCategoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductCategoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductCostHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductCostHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductDescriptionFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductDescriptionFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductDocumentFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductDocumentFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductInventoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductInventoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductListPriceHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductListPriceHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelIllustrationFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelIllustrationFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelProductDescriptionCultureFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductModelProductDescriptionCultureFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductPhotoFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductPhotoFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductProductPhotoFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductProductPhotoFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductReviewFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductReviewFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductSubcategoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductSubcategoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductVendorFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ProductVendorFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(PurchaseOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(PurchaseOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(PurchaseOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(PurchaseOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ReasonFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ReasonFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderDetailFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderHeaderFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderHeaderSalesReasonFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesOrderHeaderSalesReasonFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesPersonFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesPersonFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesPersonQuotaHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesPersonQuotaHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesReasonFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesReasonFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTaxRateFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTaxRateFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTerritoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTerritoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTerritoryHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SalesTerritoryHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ScrapReasonFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ScrapReasonFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SequentialIDSubTypeFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SequentialIDSubTypeFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShiftFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShiftFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShipMethodFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShoppingCartItemFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(ShoppingCartItemFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SpecialOfferFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(SpecialOfferProductFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StateProvinceFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StoreFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StoreFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StoreContactFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(StoreContactFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(TransactionHistoryFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(TransactionHistoryFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(TransactionHistoryArchiveFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(TransactionHistoryArchiveFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UdtTestFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UdtTestFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UnitMeasureFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UnitMeasureFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UserDetailFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(UserDetailFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorAddressFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorAddressFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorContactFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(VendorContactFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(WorkOrderFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(WorkOrderFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	

		/// <summary>
		/// FieldBetweenPredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(WorkOrderRoutingFieldIndex indexOfField, object valueBegin, object valueEnd)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd);
		}

		/// <summary>
		/// FieldBetweenPredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a between operation</param>
		/// <param name="valueBegin">the begin value for the Between compare</param>
		/// <param name="valueEnd">the end value for the Between compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldBetweenPredicate instance</returns>
		public static FieldBetweenPredicate Between(WorkOrderRoutingFieldIndex indexOfField, object valueBegin, object valueEnd, bool negate)
		{
			return new FieldBetweenPredicate(EntityFieldFactory.Create(indexOfField), valueBegin, valueEnd, negate);
		}
	
		#endregion

		#region FieldBetweenPredicate creators (2 per typed view type)
	
		#endregion

		#region FieldLikePredicate creators (2 per entity type)
	
		/// <summary>
		/// FieldLikePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AddressTypeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AWBuildVersionFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(AWBuildVersionFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(BillOfMaterialsFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(BillOfMaterialsFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactCreditCardFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactCreditCardFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactTypeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ContactTypeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CountryRegionFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CountryRegionCurrencyFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CountryRegionCurrencyFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CreativeAddressesFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CreativeAddressesFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CreditCardFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CreditCardFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CultureFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CultureFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CurrencyFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CurrencyFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CurrencyRateFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CurrencyRateFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CustomerFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(CustomerAddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DatabaseLogFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DatabaseLogFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DepartmentFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DepartmentFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DocumentFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(DocumentFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeAddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeDepartmentHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeeDepartmentHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeePayHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(EmployeePayHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ErrorLogFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ErrorLogFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(IllustrationFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(IllustrationFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(IndividualFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(JobCandidateFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(JobCandidateFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(LocationFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(LocationFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NameTestTabFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NameTestTabFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NewSequentialIDTestFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NewSequentialIDTestFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NonPresentTimeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NonPresentTimeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NonPresentTimeHeaderFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(NonPresentTimeHeaderFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductCategoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductCategoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductCostHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductCostHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductDescriptionFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductDescriptionFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductDocumentFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductDocumentFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductInventoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductInventoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductListPriceHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductListPriceHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelIllustrationFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelIllustrationFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelProductDescriptionCultureFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductModelProductDescriptionCultureFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductPhotoFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductPhotoFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductProductPhotoFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductProductPhotoFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductReviewFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductReviewFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductSubcategoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductSubcategoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductVendorFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ProductVendorFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(PurchaseOrderDetailFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(PurchaseOrderDetailFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(PurchaseOrderHeaderFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(PurchaseOrderHeaderFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ReasonFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ReasonFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderDetailFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderHeaderFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderHeaderSalesReasonFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesOrderHeaderSalesReasonFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesPersonFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesPersonFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesPersonQuotaHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesPersonQuotaHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesReasonFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesReasonFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTaxRateFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTaxRateFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTerritoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTerritoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTerritoryHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SalesTerritoryHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ScrapReasonFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ScrapReasonFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SequentialIDSubTypeFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SequentialIDSubTypeFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShiftFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShiftFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShipMethodFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShoppingCartItemFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(ShoppingCartItemFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SpecialOfferFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(SpecialOfferProductFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StateProvinceFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StoreFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StoreFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StoreContactFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(StoreContactFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(TransactionHistoryFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(TransactionHistoryFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(TransactionHistoryArchiveFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(TransactionHistoryArchiveFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UdtTestFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UdtTestFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UnitMeasureFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UnitMeasureFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UserDetailFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(UserDetailFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorAddressFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorAddressFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorContactFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(VendorContactFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(WorkOrderFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(WorkOrderFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	

		/// <summary>
		/// FieldLikePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(WorkOrderRoutingFieldIndex indexOfField, string pattern)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern);
		}

		/// <summary>
		/// FieldLikePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare using a Like operation</param>
		/// <param name="pattern">the pattern to use in the like operation</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <returns>a new FieldLikePredicate instance</returns>
		public static FieldLikePredicate Like(WorkOrderRoutingFieldIndex indexOfField, string pattern, bool negate)
		{
			return new FieldLikePredicate(EntityFieldFactory.Create(indexOfField), pattern, negate);
		}
	
		#endregion

		#region FieldLikePredicate creators (2 per typed view type)
	
		#endregion
		
		
		#region FieldCompareRangePredicate creators (2 per entity type)
	
		/// <summary>
		/// FieldCompareRangePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AddressTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AddressTypeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AWBuildVersionFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for AWBuildVersionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(AWBuildVersionFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(BillOfMaterialsFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for BillOfMaterialsEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(BillOfMaterialsFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactCreditCardFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactCreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactCreditCardFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactTypeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ContactTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ContactTypeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CountryRegionFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CountryRegionCurrencyFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CountryRegionCurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CountryRegionCurrencyFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CreativeAddressesFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CreativeAddressesEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CreativeAddressesFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CreditCardFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CreditCardEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CreditCardFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CultureFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CultureFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CurrencyFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CurrencyFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CurrencyRateFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CurrencyRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CurrencyRateFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CustomerFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for CustomerAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(CustomerAddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DatabaseLogFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DatabaseLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DatabaseLogFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DepartmentFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DepartmentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DepartmentFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DocumentFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for DocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(DocumentFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeAddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeDepartmentHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeeDepartmentHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeeDepartmentHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeePayHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for EmployeePayHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(EmployeePayHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ErrorLogFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ErrorLogEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ErrorLogFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(IllustrationFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for IllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(IllustrationFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for IndividualEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(IndividualFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(JobCandidateFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for JobCandidateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(JobCandidateFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(LocationFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for LocationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(LocationFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NameTestTabFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NameTestTabEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NameTestTabFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NewSequentialIDTestFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NewSequentialIDTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NewSequentialIDTestFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NonPresentTimeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NonPresentTimeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NonPresentTimeHeaderFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for NonPresentTimeHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(NonPresentTimeHeaderFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductCategoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductCategoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductCostHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductCostHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductCostHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductDescriptionFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDescriptionEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductDescriptionFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductDocumentFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductDocumentEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductDocumentFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductInventoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductInventoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductInventoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductListPriceHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductListPriceHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductListPriceHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelIllustrationFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelIllustrationEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelIllustrationFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelProductDescriptionCultureFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductModelProductDescriptionCultureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductModelProductDescriptionCultureFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductPhotoFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductPhotoFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductProductPhotoFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductProductPhotoEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductProductPhotoFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductReviewFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductReviewEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductReviewFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductSubcategoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductSubcategoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductSubcategoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductVendorFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ProductVendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ProductVendorFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(PurchaseOrderDetailFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(PurchaseOrderDetailFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(PurchaseOrderHeaderFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for PurchaseOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(PurchaseOrderHeaderFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ReasonFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ReasonFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderDetailFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderSalesReasonFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesOrderHeaderSalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesOrderHeaderSalesReasonFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesPersonFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesPersonFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesPersonQuotaHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesPersonQuotaHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesPersonQuotaHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesReasonFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesReasonFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTaxRateFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTaxRateEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTaxRateFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTerritoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTerritoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTerritoryHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SalesTerritoryHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SalesTerritoryHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ScrapReasonFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ScrapReasonEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ScrapReasonFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SequentialIDSubTypeFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SequentialIDSubTypeEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SequentialIDSubTypeFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShiftFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShiftEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShiftFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShipMethodEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShipMethodFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShoppingCartItemFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for ShoppingCartItemEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(ShoppingCartItemFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for SpecialOfferProductEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(SpecialOfferProductFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StateProvinceEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StateProvinceFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StoreFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StoreEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StoreFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StoreContactFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for StoreContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(StoreContactFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(TransactionHistoryFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(TransactionHistoryFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(TransactionHistoryArchiveFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for TransactionHistoryArchiveEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(TransactionHistoryArchiveFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UdtTestFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UdtTestEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UdtTestFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UnitMeasureFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UnitMeasureEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UnitMeasureFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UserDetailFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for UserDetailEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(UserDetailFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorAddressFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorAddressEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorAddressFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorContactFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for VendorContactEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(VendorContactFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(WorkOrderFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(WorkOrderFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	

		/// <summary>
		/// FieldCompareRangePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(WorkOrderRoutingFieldIndex indexOfField, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), values);
		}
		
		/// <summary>
		/// FieldCompareValuePredicate factory for WorkOrderRoutingEntity.
		/// </summary>
		/// <param name="indexOfField">The index of the field to compare</param>
		/// <param name="negate">When true the compare operation is negated</param>
		/// <param name="values">Value range to set for the IN clause. Specify any range of values.</param>
		/// <returns>A new FieldCompareRangePredicate instance</returns>
		public static FieldCompareRangePredicate CompareRange(WorkOrderRoutingFieldIndex indexOfField, bool negate, params object[] values)
		{
			return new FieldCompareRangePredicate(EntityFieldFactory.Create(indexOfField), negate, values);
		}
	
		#endregion

		#region FieldCompareRangePredicate creators (2 per typed view type)
	
		#endregion
	}
}
