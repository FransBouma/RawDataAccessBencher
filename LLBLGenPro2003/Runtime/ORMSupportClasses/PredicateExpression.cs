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
using System.Text;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Implementation of the IPredicateExpression interface.
	/// </summary>
	[Serializable]
	public class PredicateExpression : Predicate, IPredicateExpression
	{
		#region Class Member Declarations
		private ArrayList	_predicates;
		#endregion
		
		
		/// <summary>
		/// CTor. This empty constructor is not recommended when adding this instance directly
		/// to another PredicateExpression.
		/// </summary>
		public PredicateExpression()
		{
			_predicates = new ArrayList();
			base.InstanceType = (int)PredicateType.PredicateExpression;
		}

		/// <summary>
		/// CTor.
		/// </summary>
		/// <param name="predicateToAdd">Initial IPredicate implementing object for this PredicateExpression</param>
		public PredicateExpression(IPredicate predicateToAdd)
		{
			_predicates = new ArrayList();
			base.InstanceType = (int)PredicateType.PredicateExpression;
			Add(predicateToAdd);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="operand1">operand one of the expression</param>
		/// <param name="predicateExpressionOperator">operator of the expression</param>
		/// <param name="operand2">operand two of the expression</param>
		public PredicateExpression(IPredicate operand1, PredicateExpressionOperator predicateExpressionOperator, IPredicate operand2)
		{
			_predicates = new ArrayList();
			base.InstanceType = (int)PredicateType.PredicateExpression;
			Add(operand1);

			switch(predicateExpressionOperator)
			{
				case PredicateExpressionOperator.And:
					AddWithAnd(operand2);
					break;
				case PredicateExpressionOperator.Or:
					AddWithOr(operand2);
					break;
			}
		}


		/// <summary>
		/// Adds an IPredicate implementing object to the PredicateExpression. This can be a Predicate derived class or a PredicateExpression. 
		/// If no object is present yet in the PredicateExpression, no operator is added, otherwise the object is added with an 'And'-operator. 
		/// </summary>
		/// <param name="predicateToAdd">The IPredicate implementing object to add</param>
		/// <exception cref="ArgumentNullException">When prPredicateToAdd is null</exception>
		public void Add(IPredicate predicateToAdd)
		{
			if(predicateToAdd==null)
			{
				throw new ArgumentNullException("predicateToAdd", "The IPredicate implementing object to add to this PredicateExpression is null.");
			}

			if(_predicates.Count>0)
			{
				// add it with the And operator
				AddWithAnd(predicateToAdd);
			}
			else
			{
				_predicates.Add(new PredicateExpressionElement(PredicateExpressionElementType.Predicate, predicateToAdd));
			}
		}


		/// <summary>
		/// Adds an IPredicate implementing object to the PredicateExpression with an 'Or'-operator. 
		/// The object added can be a Predicate derived class or a PredicateExpression. If no objects are present yet in the PredicateExpression,
		/// the operator is ignored. 
		/// </summary>
		/// <param name="predicateToAdd">The IPredicate implementing object to add</param>
		/// <exception cref="ArgumentNullException">When predicateToAdd is null</exception>
		public void AddWithOr(IPredicate predicateToAdd)
		{
			if(predicateToAdd==null)
			{
				throw new ArgumentNullException("predicateToAdd", "The IPredicate implementing object to add to this PredicateExpression is null.");
			}

			if(_predicates.Count>0)
			{
				_predicates.Add(new PredicateExpressionElement(PredicateExpressionElementType.Operator, PredicateExpressionOperator.Or));
			}
			_predicates.Add(new PredicateExpressionElement(PredicateExpressionElementType.Predicate, predicateToAdd));
		}


		/// <summary>
		/// Adds an IPredicate implementing object to the PredicateExpression with an 'And'-operator. 
		/// The object added can be a Predicate derived class or a PredicateExpression. If no objects are present yet in the PredicateExpression,
		/// the operator is ignored. 
		/// </summary>
		/// <param name="predicateToAdd">The IPredicate implementing object to add</param>
		/// <exception cref="ArgumentNullException">When predicateToAdd is null</exception>
		public void AddWithAnd(IPredicate predicateToAdd)
		{
			if(predicateToAdd==null)
			{
				throw new ArgumentNullException("predicateToAdd", "The IPredicate implementing object to add to this PredicateExpression is null.");
			}

			if(_predicates.Count>0)
			{
				_predicates.Add(new PredicateExpressionElement(PredicateExpressionElementType.Operator, PredicateExpressionOperator.And));
			}
			_predicates.Add(new PredicateExpressionElement(PredicateExpressionElementType.Predicate, predicateToAdd));
		}


		/// <summary>
		/// Implements the IPredicate ToQueryText method. Retrieves a ready to use text representation of the contained PredicateExpression.
		/// </summary>
		/// <param name="uniqueMarker">int counter which is appended to every parameter. The refcounter is increased by every parameter creation,
		/// making sure the parameter is unique in the predicate and also in the predicate expression(s) containing the predicate.</param>
		/// <returns>The contained Predicate in textual format.</returns>
		/// <exception cref="System.ApplicationException">When IPredicate.DatabaseSpecificCreator is not set to a valid value.</exception>
		public override string ToQueryText(ref int uniqueMarker)
		{
			if(base.DatabaseSpecificCreator==null)
			{
				throw new System.ApplicationException("DatabaseSpecificCreator object not set. Cannot create query part.");
			}

			StringBuilder queryText = new StringBuilder(128);
			base.Parameters.Clear();
	
			if(base.Negate)
			{
				queryText.Append("NOT (");
			}
			else
			{
				queryText.Append("(");
			}

			for(int i=0;i<_predicates.Count;i++)
			{
				IPredicateExpressionElement element = (IPredicateExpressionElement)_predicates[i];

				switch(element.Type)
				{
					case PredicateExpressionElementType.Empty:
						// skip
						break;
					case PredicateExpressionElementType.Operator:
						queryText.AppendFormat(" {0}", ((PredicateExpressionOperator)element.Contents).ToString());
						break;
					case PredicateExpressionElementType.Predicate:
						IPredicate predicateToAdd = (IPredicate)element.Contents;
						// pass on the name creator object
						predicateToAdd.DatabaseSpecificCreator = base.DatabaseSpecificCreator;
						queryText.AppendFormat(" {0}", predicateToAdd.ToQueryText(ref uniqueMarker));
						base.Parameters.AddRange(predicateToAdd.Parameters);
						break;
				}
			}

			// add closing bracket
			queryText.Append(")");

			return queryText.ToString();
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets the predicate expression element at the index specified
		/// </summary>
		public IPredicateExpressionElement this[int index] 
		{
			get { return (IPredicateExpressionElement)_predicates[index];}
		}
		
		/// <summary>
		/// Gets the amount of predicate expression elements in this predicate expression. This is including all operators.
		/// </summary>
		public int Count 
		{
			get { return _predicates.Count;}
		}
		#endregion
	}
}
