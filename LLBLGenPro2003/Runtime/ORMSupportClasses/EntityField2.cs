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
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Generic class which is used for the columns in the EntityFields collection, which forms the data store of
	/// any Entity class generated by LLBLGen Pro. 
	/// </summary>
	[Serializable]
	public class EntityField2: IEntityField2, ICloneable, IComparable
	{
		#region Class Member Declarations
		private	string			_name, _containingObjectName, _alias;
		private System.Type		_dataType;
		private object			_currentValue, _originalValue;
		private bool			_isChanged, _isNull, _isPrimaryKey;
		private int				_fieldIndex, _maxLength;
		private byte			_scale, _precision;
		#endregion
		

		/// <summary>
		/// CTor. Necessary for serialization. Do not use this CTor in code.
		/// </summary>
		public EntityField2()
		{
			_name = String.Empty;
			_containingObjectName = String.Empty;
			_dataType=null;
			_currentValue=null;
			_originalValue=null;
			_maxLength=0;
			_scale=0;
			_precision=0;
			_alias = String.Empty;
		}

		
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="name">The name of the field. Used in XML output. </param>
		/// <param name="containingObjectName">Name of containing object this field belongs to.</param>
		/// <param name="dataType">The <see cref="System.Type"/> of the values of this field.</param>
		/// <param name="isPrimaryKey">If set to true, this field will end up in the PrimaryKey field list of the containing IEntityFields object.
		/// handles Identity fields: SqlServer will generate a new value itself, Oracle wants to have a sequence input.</param>
		/// <param name="fieldIndex">the field index related to this IEntityField, so the field can be used to retrieve the field index.</param>
		/// <param name="maxLength">The maximum length of the value of the entityfield (string/binary data). Is ignored for entityfields which hold 
		/// non-string and non-binary values.</param>
		/// <param name="scale">The scale of the value for this field.</param>
		/// <param name="precision">The precision of the value for this field.</param>
		public EntityField2(string name, string containingObjectName, System.Type dataType, bool isPrimaryKey, int fieldIndex, int maxLength, byte scale, byte precision)
		{
			InitClass(name, containingObjectName, dataType, null, isPrimaryKey, fieldIndex, maxLength, scale, precision);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="name">The name of the field. Used in XML output. </param>
		/// <param name="containingObjectName">Name of containing object this field belongs to.</param>
		/// <param name="dataType">The <see cref="System.Type"/> of the values of this field.</param>
		/// <param name="currentValue">The current value for this field.</param>
		/// <param name="isPrimaryKey">If set to true, this field will end up in the PrimaryKey field list of the containing IEntityFields object.</param>
		/// <param name="fieldIndex">the field index related to this IEntityField, so the field can be used to retrieve the field index.</param>
		/// <param name="maxLength">The maximum length of the value of the entityfield (string/binary data). Is ignored for entityfields which hold 
		/// non-string and non-binary values.</param>
		/// <param name="scale">The scale of the value for this field.</param>
		/// <param name="precision">The precision of the value for this field.</param>
		public EntityField2(string name, string containingObjectName, System.Type dataType, object currentValue, bool isPrimaryKey, int fieldIndex, 
				int maxLength, byte scale, byte precision)
		{
			InitClass(name, containingObjectName, dataType, currentValue, isPrimaryKey, fieldIndex, maxLength, scale, precision);
		}


		/// <summary>
		/// Compares the given entityfield instance with this instance using a value compare with <b>case sensitive</b> comparer logic.
		/// this is done by comparing the name, the source schema, object and column name. If there is any mismatch, the
		/// comparisson is stopped and the result of the mismatching compare is returned.
		/// </summary>
		/// <param name="fieldToCompare">The EntityField to compare with the current value.</param>
		/// <returns>A 32-bit signed integer that indicates the relative order of the comparands. See <see cref="System.IComparable.CompareTo"/>.</returns>
		public int CompareTo(object fieldToCompare)
		{
			IEntityField2 comparedField = fieldToCompare as IEntityField2;

			if(comparedField==null)
			{
				// not an EntityField2
				throw new ArgumentException("fieldToCompare is not of type IEntityField2", "fieldToCompare");
			}

			// compare the passed in field with this instance.
			int compareResult = 0;
			compareResult = this._name.CompareTo(comparedField.Name);
			if(compareResult!=0)
			{
				// done
				return compareResult;
			}

			// compare values
			compareResult = _currentValue.ToString().CompareTo(comparedField.CurrentValue.ToString());
			return compareResult;
		}


		/// <summary>
		/// Overrides the GetHashCode() method. It will return the hashcode of the value of the field as the hashcode. 
		/// </summary>
		/// <returns>hashcode of the value of the field.</returns>
		public override int GetHashCode()
		{
			if(_currentValue!=null)
			{
				return _currentValue.GetHashCode();
			}
			else
			{
				return base.GetHashCode();
			}
		}


		/// <summary>
		/// Converts this EntityField2 to an XmlNode. 
		/// </summary>
		/// <param name="parentDocument">the XmlDocument which will contain the node this method will return. This document is required
		/// to create the new node object</param>
		/// <param name="entityFieldNode">The output parameter which will represent this EntityField2 as XmlNode</param>
		public virtual void WriteXml(XmlDocument parentDocument, out XmlNode entityFieldNode)
		{
			entityFieldNode = parentDocument.CreateNode(XmlNodeType.Element, _name, "");
			
			XmlHelper nodeCreator = new XmlHelper();

			// create child nodes and attributes for this node.
			XmlNode childNode = nodeCreator.AddNode(entityFieldNode, "CurrentValue");

			string valueTypeName = _currentValue.GetType().UnderlyingSystemType.FullName.ToString();
			nodeCreator.AddAttribute(childNode, "Type", valueTypeName);

			// the value of this field can be of a variety of types. Some types require extra treatment before they can be
			// put as a value in an XmlNode.
			string valueAsString = String.Empty;

			if(_currentValue!=null)
			{
				switch(valueTypeName)
				{
					case "System.String":
					case "System.Byte":
					case "System.Int32":
					case "System.Int16":
					case "System.Int64":
					case "System.Decimal":
					case "System.Double":
					case "System.Single":
					case "System.Boolean":
					case "System.Guid":
						valueAsString = _currentValue.ToString();
						break;
					case "System.DateTime":
						valueAsString = ((DateTime)_currentValue).Ticks.ToString();
						break;
					case "System.Byte[]":
						// special case, base64encode it
						valueAsString = Convert.ToBase64String((byte[])_currentValue);
						break;
					default:
						valueAsString = _currentValue.ToString();
						break;
				}
			}
			childNode.AppendChild(parentDocument.CreateTextNode(valueAsString));

			childNode = nodeCreator.AddNode(entityFieldNode, "IsChanged", _isChanged.ToString());
			nodeCreator.AddAttribute(childNode, "Type", "System.Boolean");

			childNode = nodeCreator.AddNode(entityFieldNode, "IsNull", _isNull.ToString());
			nodeCreator.AddAttribute(childNode, "Type", "System.Boolean");
		}

		
		/// <summary>
		/// Accepts the value of the current value as the final current value. Original value is discarded
		/// </summary>
		public void AcceptChange()
		{
			if(!_isChanged)
			{
				// no change to accept
				return;
			}

			_originalValue = null;
			_isChanged = false;
		}


		/// <summary>
		/// Rejects the value of the current value and resets current value with the original value, and <see cref="IsChanged"/> will report false.
		/// </summary>
		public void RejectChange()
		{
			if(!_isChanged)
			{
				// no change to reject
				return;
			}

			_currentValue = _originalValue;
			_isChanged = false;
		}


		/// <summary>
		/// Initializes the class' member variables. for parameter descriptions, see the constructor(s).
		/// </summary>
		/// <param name="name"></param>
		/// <param name="containingObjectName"></param>
		/// <param name="dataType"></param>
		/// <param name="currentValue"></param>
		/// <param name="isPrimaryKey"></param>
		/// <param name="fieldIndex"></param>
		/// <param name="maxLength"></param>
		/// <param name="scale"></param>
		/// <param name="precision"></param>
		private void InitClass(string name, string containingObjectName, System.Type dataType, object currentValue, bool isPrimaryKey, int fieldIndex, 
				int maxLength, byte scale, byte precision)
		{
			_name = name;
			_containingObjectName = containingObjectName;
			_dataType = dataType;
			_originalValue = null;
			_currentValue = currentValue;
			_isChanged = false;
			_isNull=false;
			_isPrimaryKey = isPrimaryKey;
			_fieldIndex = fieldIndex;
			_maxLength = maxLength;
			_scale = scale;
			_precision = precision;
			_alias = name;
		}


		/// <summary>
		/// Creates a deep copy of this IEntityField2 object
		/// </summary>
		/// <returns>A deep copy of this object</returns>
		public virtual object Clone()
		{
			EntityField2 fieldToReturn = (EntityField2)this.MemberwiseClone();

			// fill in the blanks.
			fieldToReturn.OriginalValue = _originalValue;
			fieldToReturn.ForcedCurrentValueWrite(_currentValue);

			return fieldToReturn;
		}


		/// <summary>
		/// Overwrites the current value with the value passed. This bypasses value checking and field properties. 
		/// Used by internal code only. Do not call this from your code.
		/// </summary>
		/// <param name="value">Value to store as the current value</param>
		public void ForcedCurrentValueWrite(object value)
		{
			_currentValue = value;
		}


		/// <summary>
		/// Overwrites DataType with the value specified without checking for type compatibility or readonly flags.
		/// </summary>
		/// <remarks>Do not call this method from your code. This is an internal method</remarks>
		/// <param name="dataType">Value to store as DataType</param>
		internal void ForcedTypeWrite(System.Type dataType)
		{
			_dataType = dataType;
		}


		/// <summary>
		/// Forces a set of the IsChanged flag for this field. 
		/// </summary>
		/// <param name="isChangedValue">new value for IsChanged.</param>
		/// <remarks>Do not call this method from your code. This is an internal method</remarks>
		internal void ForcedChangedWrite(bool isChangedValue)
		{
			_isChanged = isChangedValue;
		}


		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// The field is kept marked changed, in effect, this method is empty.
		/// </summary>
		public void EndEdit()
		{
			// empty
		}


		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// The currentvalue is reset by the original value.
		/// The field is marked unchanged.
		/// </summary>
		public void CancelEdit()
		{
			_currentValue = _originalValue;
			_isChanged = false;
		}

		
		/// <summary>
		/// IEditableObject method. Used by databinding.
		/// Original value is overwritten by currentValue, currentValue keeps its value.
		/// </summary>
		public void BeginEdit()
		{
			_originalValue = _currentValue;
		}


		#region Class Property Declarations
		/// <summary>
		/// The maximum length of the value of the entityfield (string/binary data). Is ignored for entityfields which hold non-string and non-binary values.
		/// Value initially set for this field is the length of the database column this field is mapped on.
		/// </summary>
		public int MaxLength 
		{
			get {return _maxLength;}
			set {_maxLength=value;}
		}
		
		/// <summary>
		/// The scale of the value for this field. 
		/// Value initially set for this field is the scale of the database column this field is mapped on.
		/// </summary>
		public byte Scale 
		{
			get {return _scale;}
			set {_scale=value;}
		}

		/// <summary>
		/// The precision of the value for this field.
		/// Value initially set for this field is the precision of the database column this field is mapped on.
		/// </summary>
		public byte Precision 
		{
			get {return _precision;}
			set {_precision=value;}
		}
		
		/// <summary>
		/// The name of the field. Used in XML output. 
		/// </summary>
		public string Name
		{
			get { return _name; }
			set 
			{ 
				if(value.Length <= 0)
				{
					// Names of zero length are rejected
					throw new ArgumentException("Name cannot be of zero length.");
				}
				if(value.Trim().Length <= 0)
				{
					throw new ArgumentException("Name has to contain other characters than just spaces.");
				}

				_name = value.Trim(); 
			}
		}

		/// <summary>
		/// The alias to use for this field. Only used when this field object is part of a typed list. 
		/// Adapter: returns the alias set in the designer
		/// SelfServicing: returns Name
		/// </summary>
		public string Alias
		{
			get
			{
				return _alias;
			}
			set
			{
				_alias = value;
			}
		}

		/// <summary>
		/// The original value for this field when the field is changed and the change has not been accepted yet.
		/// </summary>
		internal object OriginalValue
		{
			get { return _originalValue;}
			set { _originalValue = value; }
		}
		
		
		/// <summary>
		/// Gets the current value for this field and sets the new value for this field, by overwriting current value. The value in 
		/// currentValue is discarded, versioning control has to save the original value of currentValue before this property is called. 
		/// </summary>
		/// <remarks>
		/// Calling this property directly will not trigger versioning control,
		/// thus calling this property directly is not recommended. Call <see cref="EntityBase.SetNewFieldValue"/> instead.
		/// Type of the new value has to be the same as <see cref="DataType"/>, which is set in the
		/// constructor. If this field is set to readonly, an exception is raised. 
		/// </remarks>
		/// <exception cref="ORMFieldIsReadonlyException">The field is set to readonly and can't be changed.</exception>
		/// <exception cref="ORMValueTypeMismatchException">The value specified is not of the same <see cref="DataType"/> as this field.</exception>
		public object CurrentValue
		{
			get { return _currentValue; }
			set 
			{ 
				if(value!=null)
				{
					if((_dataType!= typeof(object)) && (value.GetType() != _dataType))
					{
						throw new ORMValueTypeMismatchException("The value " + value.ToString() + " is of type '" + value.GetType().ToString() + "' while the field is of type '" + _dataType + "'");
					}
				}

				_currentValue = value; 
				_isChanged = true;
			}
		}

		/// <summary>
		/// The <see cref="System.Type"/> of the values of this field.
		/// </summary>
		public System.Type DataType
		{
			get { return _dataType; }
		}
		
		/// <summary>
		/// If set to true, in the constructor, this field will end up in the PrimaryKey field list of the containing IEntityFields object.
		/// </summary>
		public bool IsPrimaryKey 
		{
			get { return _isPrimaryKey; }
		}

		/// <summary>
		/// If the value of this field is changed, this property is set to true. Set when <see cref="CurrentValue"/> receives a valid value. Set to 
		/// false when <see cref="AcceptChange"/> is called succesfully.
		/// </summary>
		public bool IsChanged
		{
			get { return _isChanged; }
			set { _isChanged = value; }
		}
		
		/// <summary>
		/// If the original value in the column for this entityfield is DBNull (NULL), this parameter should be set to true, otherwise to false.
		/// In BL Logic, it's impractical to work with NULL values, so these are converted to workable values. The developer can still determine if
		/// the original value was DBNull by checking this field. Using NULL values is not recommended. 
		/// </summary>
		public bool IsNull
		{
			get { return _isNull; }
			set	{ _isNull = value;}
		}

		/// <summary>
		/// Gets the field index related to this IEntityField, so the field can be used to retrieve the field index.
		/// </summary>
		public int FieldIndex 
		{
			get { return _fieldIndex; }
		}

		/// <summary>
		/// Name of the containing object this field belongs to (entity or typed view). This name is required to retrieve persistence information.
		/// Set via constructor.
		/// </summary>
		public string ContainingObjectName 
		{
			get { return _containingObjectName;}
		}
		
		#endregion

	}
}