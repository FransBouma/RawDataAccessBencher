/////////////////////////////////////////////////////////////
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Abstract base implementation of the IPredicate interface.
	/// </summary>
	[Serializable]
	public abstract class Predicate : IPredicate
	{
		#region Class Member Declarations
		private ArrayList			_parameters;
		private bool				_negate, _selfServicing;
		private IDbSpecificCreator	_databaseSpecificCreator;
		private int					_instanceType;
		#endregion
		
		
		/// <summary>
		/// CTor
		/// </summary>
		public Predicate()
		{
			_negate = false;
			_parameters = new ArrayList();
			_databaseSpecificCreator = null;
			_selfServicing = true;
			_instanceType=(int)PredicateType.Undefined;
		}

		/// <summary>
		/// Retrieves a ready to use text representation of the contained Predicate. 
		/// </summary>
		/// <param name="uniqueMarker">int counter which is appended to every parameter. The refcounter is increased by every parameter creation,
		/// making sure the parameter is unique in the predicate and also in the predicate expression(s) containing the predicate.</param>
		/// <returns>The contained Predicate in textual format.</returns>
		public abstract string ToQueryText(ref int uniqueMarker);


		#region Class Property Declarations
		/// <summary>
		/// The PredicateType of this instance. Used to determine the instance nature without a lot of casting.
		/// </summary>
		/// <summary>
		/// Gets / sets instanceType
		/// </summary>
		public int InstanceType
		{
			get
			{
				return _instanceType;
			}
			set
			{
				_instanceType = value;
			}
		}

		/// <summary>
		/// The list of parameters created when the Predicate was translated to text usable in a query. Only valid after a succesful call to
		/// <see cref="ToQueryText"/>
		/// </summary>
		public ArrayList Parameters 
		{
			get {return _parameters;}
		}

		/// <summary>
		/// Flag for setting the Predicate to negate itself, i.e. to add 'NOT' to its result.
		/// </summary>
		public bool Negate 
		{
			get { return _negate; } 
			set { _negate = value; }
		}

		/// <summary>
		/// Object which will be used to create valid parameter objects, field names, including prefix/postfix characters, 
		/// and conversion routines, and field names, including prefix/postfix characters. 
		/// Uses the strategy pattern so the generic code can work with more than one target database.
		/// </summary>
		public IDbSpecificCreator DatabaseSpecificCreator
		{
			get { return _databaseSpecificCreator; }
			set { _databaseSpecificCreator = value; }
		}


		/// <summary>
		/// Gets / sets selfServicing, a flag to signal if this predicate is constructed using a selfservicing constructor (field is of type IEntityField)
		/// Default: true;
		/// </summary>
		internal bool SelfServicing
		{
			get
			{
				return _selfServicing;
			}
			set
			{
				_selfServicing = value;
			}
		}
		#endregion
		
	}
}
