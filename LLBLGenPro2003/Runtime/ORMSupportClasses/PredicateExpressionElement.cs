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

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Implementation of the IPredicateExpressionElement interface
	/// </summary>
	[Serializable]
	public class PredicateExpressionElement : IPredicateExpressionElement
	{
		#region Class Member Declarations
		private PredicateExpressionElementType	_type;
		private object							_contents;
		#endregion
		
		/// <summary>
		/// CTor
		/// </summary>
		public PredicateExpressionElement()
		{
			_contents = null;
			_type = PredicateExpressionElementType.Empty;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="elementType">The type of the Element. </param>
		/// <param name="contents">The contents of the Element</param>
		public PredicateExpressionElement(PredicateExpressionElementType elementType, object contents)
		{
			_contents = contents;
			_type = elementType;
		}

		#region Class Property Declarations
		/// <summary>
		/// The type of the Element. 
		/// </summary>
		public PredicateExpressionElementType Type 
		{
			get { return _type; }
			set {_type = value; }
		}

		/// <summary>
		/// The contents of the Element
		/// </summary>
		public object Contents 
		{
			get { return _contents; }
			set { _contents = value; }
		}
		#endregion
		
	}
}
