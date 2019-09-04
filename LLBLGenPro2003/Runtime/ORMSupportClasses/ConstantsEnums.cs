
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Enum to specify to the IConcurrencyPredicateFactory what kind of predicate to produce
	/// </summary>
	public enum ConcurrencyPredicateType
	{
		/// <summary>
		/// The predicate type requested is for a Save action
		/// </summary>
		Save,
		/// <summary>
		/// The predicate type requested is for a Delete action
		/// </summary>
		Delete
	}


	/// <summary>
	/// SqlServer specific enum definition for Adapter template set. Specifies for the active DataAccessAdapter object what
	/// to do with the catalog name in persistence information set into fields. 
	/// </summary>
	public enum CatalogNameUsage:int
	{
		/// <summary>
		/// Use default behaviour, which means that nothing is done to the catalog name specified in the persistence info.
		/// </summary>
		Default,
		/// <summary>
		/// Force the name specified in the property DataAccessAdapter.CatalogNameToUse. 
		/// </summary>
		ForceName,
		/// <summary>
		/// Clears the catalog name specified in the persistence information. This means that the catalog name specified in the
		/// connection string is used by SqlServer where to locate specified tables etc.. Clearing of the catalog name makes the
		/// SqlServer DQE ignore the catalog name when generating names.
		/// </summary>
		Clear
	}

	/// <summary>
	/// Enum definition for the type of a PredicateExpressionElement
	/// </summary>
	public enum PredicateExpressionElementType:int
	{
		/// <summary>
		/// Element contains an Operator
		/// </summary>
		Operator,
		/// <summary>
		/// Element contains an IPredicate implementing object.
		/// </summary>
		Predicate,
		/// <summary>
		/// The element is empty.
		/// </summary>
		Empty
	}


	/// <summary>
	/// Enum definition for the type of a predicate instance.
	/// This enum is stored in Predicate as an int and is used in DataAccessAdapterBase derived classes.
	/// </summary>
	public enum PredicateType:int
	{
		/// <summary>
		/// Undefined type. 
		/// </summary>
		Undefined=0,
		/// <summary>
		/// A FieldBetweenPredicate instance
		/// </summary>
		FieldBetweenPredicate,
		/// <summary>
		/// A FieldCompareNullPredicate instance
		/// </summary>
		FieldCompareNullPredicate,
		/// <summary>
		/// A FieldCompareValuePredicate instance
		/// </summary>
		FieldCompareValuePredicate,
		/// <summary>
		/// A FieldLikePredicate instance
		/// </summary>
		FieldLikePredicate, 
		/// <summary>
		/// A predicate expression object containing 0 or more predicate elements.
		/// </summary>
		PredicateExpression,
		/// <summary>
		/// A FieldCompareRangePredicate instance. Future enhancement
		/// </summary>
		FieldCompareRangePredicate,
		/// <summary>
		/// A FieldFullTextSearchPredicate (SqlServer 2000 specific). Future enhancement.
		/// </summary>
		FieldFullTextSearchPredicate
	}


	/// <summary>
	/// Enum definition for the type of relation an EntityRelation object represents.
	/// There is no definition for m:n relation because EntityRelation can't represent a m:n relation
	/// </summary>
	public enum RelationType:int
	{
		/// <summary>
		/// A 1:n relation
		/// </summary>
		OneToMany,
		/// <summary>
		/// A 1:1 relation
		/// </summary>
		OneToOne,
		/// <summary>
		/// A m:1 relation
		/// </summary>
		ManyToOne
	}


	/// <summary>
	/// Enum definition for the operator used in the FieldCompareValue Predicate.
	/// </summary>
	public enum ComparisonOperator:int
	{
		/// <summary>
		/// == . The only operator useful for boolean (bit) Fields.
		/// </summary>
		Equal,
		/// <summary>
		/// &lt;=
		/// </summary>
		LessEqual,
		/// <summary>
		/// &lt;
		/// </summary>
		LesserThan,
		/// <summary>
		/// &gt;=
		/// </summary>
		GreaterEqual,
		/// <summary>
		/// &gt;
		/// </summary>
		GreaterThan,
		/// <summary>
		/// &lt;&gt; or !=
		/// </summary>
		NotEqual	
	}


	/// <summary>
	/// Enum definition for the Operators used in PredicateExpressions
	/// </summary>
	public enum PredicateExpressionOperator:int
	{
		/// <summary>
		/// The AND operator.
		/// </summary>
		And,
		/// <summary>
		/// The OR operator.
		/// </summary>
		Or
	}


	/// <summary>
	/// Enum definition for the sort operator, which can be specified with IEntityField instances to create
	/// order by clauses.
	/// </summary>
	public enum SortOperator:int
	{
		/// <summary>
		/// Makes sorts Ascending
		/// </summary>
		Ascending,
		/// <summary>
		/// Makes sorts Descending
		/// </summary>
		Descending
	}


	/// <summary>
	/// Enum definition for the state an Entity can be in.
	/// </summary>
	public enum EntityState:int
	{
		/// <summary>
		/// Entity is new. It can be empty or filled, but is not saved (yet) to the persistent storage.
		/// </summary>
		New,
		/// <summary>
		/// Entity is filled with its data from the persistent storage. It can be changed since the fetch.
		/// </summary>
		Fetched,
		/// <summary>
		/// Entity is out of sync with its physical entity in the persistent storage. 
		/// An Entity is marked OutOfSync when a succesful Save action is performed. 
		/// An Entity will re-fetch itself when in the state OutOfSync when a property
		/// is read or Refetch() is called. The state will then be set to Fetched.
		/// </summary>
		OutOfSync,
		/// <summary>
		/// Adapter specific. If an entity has the state Deleted, it is no longer
		/// available in the persistent storage.
		/// </summary>
		Deleted
	}


	/// <summary>
	/// Constant holder for the version of this library. Because the library is signed, it has a general version, like 1.0.2003.2, but
	/// it also has an internal version, stored in this struct, which reflects the build date. Versions are always equal for the DQE's and the ORM
	/// support classes.
	/// </summary>
	[Serializable]
	public struct RuntimeLibraryVersion
	{
		/// <summary>
		/// Version reflects the general version of this library, for example 1.0.2003.2
		/// </summary>
		public const string Version = "1.0.2003.3";
		/// <summary>
		/// Contains the build number of this version, which is build up like this: MMDDYYYY
		/// </summary>
		public const string Build = "06172004";
	}
}
