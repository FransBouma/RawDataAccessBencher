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
using System.Text;
using System.Data;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Implementation of a Field Compare NULL expression using the following format:
	/// IEntityField(Core) IS NULL (f.e. Foo IS NULL).
	/// </summary>
	[Serializable]
	public class FieldCompareNullPredicate : Predicate
	{
		#region Class Member Declarations
		private IEntityFieldCore		_field;
		private IFieldPersistenceInfo	_persistenceInfo;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public FieldCompareNullPredicate()
		{
			InitClass(null, null, false, true);
		}


		/// <summary>
		/// CTor. Creates the Field IS NULL predicate. (SelfServicing version)
		/// </summary>
		/// <param name="field">Field used in the comparison expression</param>
		public FieldCompareNullPredicate(IEntityField field)
		{
			InitClass(field, field, false, true);
		}


		/// <summary>
		/// CTor. Creates the Field IS NULL predicate.
		/// </summary>
		/// <param name="field">Field used in the comparison expression</param>
		/// <param name="persistenceInfo">The persistence info object for the field</param>
		public FieldCompareNullPredicate(IEntityFieldCore field, IFieldPersistenceInfo persistenceInfo)
		{
			InitClass(field, persistenceInfo, false, false);
		}


		/// <summary>
		/// CTor. Creates the Field IS NULL predicate.
		/// </summary>
		/// <param name="field">Field used in the comparison expression</param>
		/// <param name="negate">Flag to make this expression add NOT to itself</param>
		public FieldCompareNullPredicate(IEntityField field, bool negate)
		{
			InitClass(field, field, negate, true);
		}


		/// <summary>
		/// CTor. Creates the Field IS NULL predicate.
		/// </summary>
		/// <param name="field">Field used in the comparison expression</param>
		/// <param name="persistenceInfo">The persistence info object for the field</param>
		/// <param name="negate">Flag to make this expression add NOT to itself</param>
		public FieldCompareNullPredicate(IEntityFieldCore field, IFieldPersistenceInfo persistenceInfo, bool negate)
		{
			InitClass(field, persistenceInfo, negate, false);
		}


		/// <summary>
		/// Implements the IPredicate ToQueryText method. Retrieves a ready to use text representation of the contained Predicate.
		/// </summary>
		/// <param name="uniqueMarker">int counter which is appended to every parameter. The refcounter is increased by every parameter creation,
		/// making sure the parameter is unique in the predicate and also in the predicate expression(s) containing the predicate.</param>
		/// <returns>The contained Predicate in textual format.</returns>
		/// <exception cref="System.ApplicationException">When IPredicate.DatabaseSpecificCreator is not set to a valid value.</exception>
		public override string ToQueryText(ref int uniqueMarker)
		{
			if(_field==null)
			{
				return "";
			}

			if(base.DatabaseSpecificCreator==null)
			{
				throw new System.ApplicationException("DatabaseSpecificCreator object not set. Cannot create query part.");
			}

			base.Parameters.Clear();

			StringBuilder queryText = new StringBuilder(128);
			queryText.AppendFormat("{0} IS", base.DatabaseSpecificCreator.CreateFieldName(_persistenceInfo, _field.Name));

			if(base.Negate)
			{
				queryText.Append(" NOT");
			}

			queryText.Append(" NULL");

			return queryText.ToString();
		}


		/// <summary>
		/// Inits the class
		/// </summary>
		/// <param name="field"></param>
		/// <param name="persistenceInfo"></param>
		/// <param name="negate"></param>
		/// <param name="selfServicing"></param>
		private void InitClass(IEntityFieldCore field, IFieldPersistenceInfo persistenceInfo, bool negate, bool selfServicing)
		{
			_field=field;
			_persistenceInfo = persistenceInfo;
			base.Negate=negate;
			base.SelfServicing = selfServicing;
			base.InstanceType = (int)PredicateType.FieldCompareNullPredicate;
		}


		#region Class Property Declarations
		/// <summary>
		/// Field used in the comparison expression (SelfServicing).
		/// </summary>
		/// <exception cref="InvalidOperationException">if this object was constructed using a non-selfservicing constructor.</exception>
		public virtual IEntityField Field
		{
			get 
			{ 
				if(!base.SelfServicing)
				{
					// not applicable
					throw new InvalidOperationException("This object was constructed using a non-selfservicing constructor. Can't retrieve an IEntityField after that.");
				}
				return (IEntityField)_field; 
			}
		}

		/// <summary>
		/// Field used in the comparison expression (IEntityFieldCore).
		/// </summary>
		public virtual IEntityFieldCore FieldCore
		{
			get 
			{ 
				return _field; 
			}
		}

		/// <summary>
		/// Gets / sets persistenceInfo for field
		/// </summary>
		/// <exception cref="InvalidOperationException">When a value is set for this property and this object was created using a selfservicing constructor.</exception>
		public IFieldPersistenceInfo PersistenceInfo
		{
			get
			{
				return _persistenceInfo;
			}
			set
			{
				if(base.SelfServicing)
				{
					// not applicable
					throw new InvalidOperationException("This object was constructed using a selfservicing constructor. Can't set persistence info after that.");
				}
				_persistenceInfo = value;
			}
		}
		#endregion
	
	}
}
