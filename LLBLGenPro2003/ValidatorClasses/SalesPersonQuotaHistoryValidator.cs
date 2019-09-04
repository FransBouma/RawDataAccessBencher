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
// Code is generated on: woensdag 4 september 2019 11:28:41
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.ValidatorClasses
{
	/// <summary>
	/// Implementation of the SalesPersonQuotaHistory Validator class. This class formulates validation rules for the
	/// SalesPersonQuotaHistoryEntity class. It is plugged into an instance of the SalesPersonQuotaHistoryEntity class using the Strategy
	/// Pattern [GoF]. This class is generated. 
	/// </summary>
	/// <remarks>
	/// If you want to add additional business logic to this class, derive from this
	/// class, override the validate method and pass an instance of that class to the
	/// SalesPersonQuotaHistoryEntity class instead of an instance of this class. The SalesPersonQuotaHistoryEntity code will then call your
	/// override methods when available and will use the method in this class.
	/// You can also adjust this class with validator rules. Keep in mind that re-generating the code will overwrite your work.
	/// If you decide to alter this generated code, be sure to make the file read-only.
	/// </remarks>
	[Serializable]
	public class SalesPersonQuotaHistoryValidator : IValidator
	{
		/// <summary>
		/// CTor
		/// </summary>
		public SalesPersonQuotaHistoryValidator()
		{
		}

		
		/// <summary>
		/// Validation method which is called when a field value changes. When a value fails the test, this method will return false
		/// and the field will keep its current value. When true is returned, the field will receive value as its new value.
		/// </summary>
		/// <param name="fieldIndex">Index of the field which value is changed</param>
		/// <param name="value">new value of the field. This value should be validated</param>
		/// <returns>true, if value is a valid value for the field with index fieldIndex, false otherwise.</returns>
		public virtual bool Validate(int fieldIndex, object value)
		{
			// TODO:  Add SalesPersonQuotaHistoryValidator.Validate implementation
			return true;
		}
	}
}

