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
	/// Generic class which holds the generic information for entity field persistence of an entity field. Instances of this interface
	/// are passed to logic with an instance of the IEntityFieldCore interface. SelfServicing implements both interfaces in one interface: IEntityField.
	/// Generic
	/// </summary>
	[Serializable]
	public class FieldPersistenceInfo: IFieldPersistenceInfo
	{
		#region Class Member Declarations
		private	string			_sourceColumnName, _sourceObjectName, _sourceSchemaName, _identityValueSequenceName, _sourceCatalogName;
		private bool			_isSourceColumnNullable, _isIdentity;
		private int				_sourceColumnMaxLength, _sourceColumnDbType;
		private byte			_sourceColumnScale, _sourceColumnPrecision;
		#endregion
		

		/// <summary>
		/// CTor. Necessary for serialization. Do not use this CTor in code.
		/// </summary>
		public FieldPersistenceInfo()
		{
			_sourceColumnName = String.Empty;
			_sourceObjectName = String.Empty;
			_sourceSchemaName = String.Empty;
			_sourceCatalogName = String.Empty;
			_identityValueSequenceName = String.Empty;
		}

		
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="sourceSchemaName">The name of the schema which holds SourceObjectName. Schema is used to generate SQL on the fly.
		/// A common schema name in SqlServer is f.e. 'dbo'.</param>
		/// <param name="sourceObjectName">The name of the source object which holds SourceColumnName. Can be a view or a table. 
		/// Used to generate SQL on the fly.</param>
		/// <param name="sourceColumnName">The name of the corresponding column in a view or table for the corresponding entity/view field. This name is used 
		/// to map a column in a resultset onto the entity field.</param>
		/// <param name="isSourceColumnNullable">Flag if the Column mapped is nullable or not. </param>
		/// <param name="sourceColumnDbType">The type of the Column. The value stored here is the integer representation of the enum value of the type, f.e.
		/// SqlDbType.Int or OracleType.Int16</param>
		/// <param name="sourceColumnMaxLength">The maximum length of the value for this column (string/binary data). 
		/// Is ignored for columns which hold non-string and non-binary values.</param>
		/// <param name="sourceColumnScale">The scale of the Column mapped onto the entityfield.</param>
		/// <param name="sourceColumnPrecision">The precision of the Column mapped onto the entityfield.</param>
		/// <param name="isIdentity">If set to true, the Dynamic Query Engine (DQE) will assume the field is an Identity field and will act 
		/// accordingly (i.e.: as the target database handles Identity fields: SqlServer will generate a new value itself, Oracle wants to have a 
		/// sequence input.</param>
		/// <param name="identityValueSequenceName">If isIdentity is set to true, this property has to be set to the name of the sequence which 
		/// supplies the value for the column. On SqlServer this is @@IDENTITY or SCOPE_IDENTITY() and only used when the row is succesfully 
		/// inserted, however on Oracle f.e. this value is used to specify a new value and to retrieve the new value. Is undefined when 
		/// isIdentity is set to false.</param>
		public FieldPersistenceInfo(string sourceSchemaName, string sourceObjectName, string sourceColumnName, 
			bool isSourceColumnNullable, int sourceColumnDbType, int sourceColumnMaxLength, byte sourceColumnScale, byte sourceColumnPrecision, 
			bool isIdentity, string identityValueSequenceName)
		{
			InitClass(String.Empty, sourceSchemaName, sourceObjectName, sourceColumnName, isSourceColumnNullable, 
				sourceColumnDbType, sourceColumnMaxLength, sourceColumnScale, sourceColumnPrecision, isIdentity, identityValueSequenceName);
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="sourceCatalogName">The name of the catalog the sourceSchemaName is in.</param>
		/// <param name="sourceSchemaName">The name of the schema which holds SourceObjectName. Schema is used to generate SQL on the fly.
		/// A common schema name in SqlServer is f.e. 'dbo'.</param>
		/// <param name="sourceObjectName">The name of the source object which holds SourceColumnName. Can be a view or a table. 
		/// Used to generate SQL on the fly.</param>
		/// <param name="sourceColumnName">The name of the corresponding column in a view or table for the corresponding entity/view field. This name is used 
		/// to map a column in a resultset onto the entity field.</param>
		/// <param name="isSourceColumnNullable">Flag if the Column mapped is nullable or not. </param>
		/// <param name="sourceColumnDbType">The type of the Column. The value stored here is the integer representation of the enum value of the type, f.e.
		/// SqlDbType.Int or OracleType.Int16</param>
		/// <param name="sourceColumnMaxLength">The maximum length of the value for this column (string/binary data). 
		/// Is ignored for columns which hold non-string and non-binary values.</param>
		/// <param name="sourceColumnScale">The scale of the Column mapped onto the entityfield.</param>
		/// <param name="sourceColumnPrecision">The precision of the Column mapped onto the entityfield.</param>
		/// <param name="isIdentity">If set to true, the Dynamic Query Engine (DQE) will assume the field is an Identity field and will act 
		/// accordingly (i.e.: as the target database handles Identity fields: SqlServer will generate a new value itself, Oracle wants to have a 
		/// sequence input.</param>
		/// <param name="identityValueSequenceName">If isIdentity is set to true, this property has to be set to the name of the sequence which 
		/// supplies the value for the column. On SqlServer this is @@IDENTITY or SCOPE_IDENTITY() and only used when the row is succesfully 
		/// inserted, however on Oracle f.e. this value is used to specify a new value and to retrieve the new value. Is undefined when 
		/// isIdentity is set to false.</param>
		public FieldPersistenceInfo(string sourceCatalogName, string sourceSchemaName, string sourceObjectName, string sourceColumnName, 
			bool isSourceColumnNullable, int sourceColumnDbType, int sourceColumnMaxLength, byte sourceColumnScale, byte sourceColumnPrecision, 
			bool isIdentity, string identityValueSequenceName)
		{
			InitClass(sourceCatalogName, sourceSchemaName, sourceObjectName, sourceColumnName, isSourceColumnNullable, 
				sourceColumnDbType, sourceColumnMaxLength, sourceColumnScale, sourceColumnPrecision, isIdentity, identityValueSequenceName);
		}


		/// <summary>
		/// Initializes the class' member variables. for parameter descriptions, see the constructor(s).
		/// </summary>
		/// <param name="sourceCatalogName"></param>
		/// <param name="sourceSchemaName"></param>
		/// <param name="sourceObjectName"></param>
		/// <param name="sourceColumnName"></param>
		/// <param name="isSourceColumnNullable"></param>
		/// <param name="sourceColumnDbType"></param>
		/// <param name="sourceColumnMaxLength"></param>
		/// <param name="sourceColumnScale"></param>
		/// <param name="sourceColumnPrecision"></param>
		/// <param name="isIdentity"></param>
		/// <param name="identityValueSequenceName"></param>
		private void InitClass(string sourceCatalogName, string sourceSchemaName, string sourceObjectName, string sourceColumnName, bool isSourceColumnNullable, 
			int sourceColumnDbType, int sourceColumnMaxLength, byte sourceColumnScale, 
			byte sourceColumnPrecision, bool isIdentity, string identityValueSequenceName)
		{
			_sourceCatalogName = sourceCatalogName;
			_sourceSchemaName = sourceSchemaName;
			_sourceObjectName = sourceObjectName;
			_sourceColumnName = sourceColumnName;
			_isSourceColumnNullable = isSourceColumnNullable;
			_sourceColumnDbType = sourceColumnDbType;
			_sourceColumnMaxLength = sourceColumnMaxLength;
			_sourceColumnPrecision = sourceColumnPrecision;
			_sourceColumnScale = sourceColumnScale;
			_isIdentity = isIdentity;
			_identityValueSequenceName = identityValueSequenceName;
		}


		#region Class Property Declarations
		/// <summary>
		/// The name of the catalog the SourceSchemaName is located in. 
		/// </summary>
		public string SourceCatalogName
		{
			get
			{
				return _sourceCatalogName;
			}
			set
			{
				_sourceCatalogName = value;
			}
		}

		
		/// <summary>
		/// The name of the schema which holds <see cref="SourceObjectName"/>. Schema is used to generate SQL on the fly. 
		/// A common schema name in SqlServer is f.e. 'dbo'.
		/// </summary>
		public string SourceSchemaName 
		{
			get { return _sourceSchemaName; }
			set { _sourceSchemaName = value; }
		}
			
		/// <summary>
		/// The name of the source object which holds <see cref="SourceColumnName"/>. Can be a view or a table. Used to generate SQL on the fly.
		/// </summary>
		public string SourceObjectName 
		{
			get { return _sourceObjectName; }
			set { _sourceObjectName = value; }
		}
			

		/// <summary>
		/// The name of the corresponding column in a view or table for this entityfield. This name is used to map a column in a resultset onto the entity field.
		/// Used for update/insert operations on the column
		/// </summary>
		public string SourceColumnName 
		{
			get { return _sourceColumnName; }
			set { _sourceColumnName = value; }
		}
		
		/// <summary>
		/// The maximum length of the value of this entityfield (string/binary data). Is ignored for entityfields which hold non-string and non-binary values.
		/// ColumnMaxLength
		/// Used for update/insert operations on the column
		/// </summary>
		public int SourceColumnMaxLength
		{
			get { return _sourceColumnMaxLength; }
			set { _sourceColumnMaxLength = value; }
		}
		
		/// <summary>
		/// The type of the Column mapped onto the EntityField. The value stored here is the integer representation of the enum value of the type, f.e.
		/// SqlDbType.Int or OracleType.Int16
		/// Used for update/insert operations on the column
		/// </summary>
		public int SourceColumnDbType
		{
			get { return _sourceColumnDbType; }
			set { _sourceColumnDbType = value; }
		}
		
		/// <summary>
		/// Flag if the Column mapped onto the entityfield is nullable or not. 
		/// Used for update/insert operations on the column
		/// </summary>
		public bool SourceColumnIsNullable
		{
			get { return _isSourceColumnNullable; }
			set { _isSourceColumnNullable = value; }
		}
		
		/// <summary>
		/// The scale of the Column mapped onto the entityfield.
		/// Used for update/insert operations on the column
		/// </summary>
		public byte SourceColumnScale
		{
			get { return _sourceColumnScale; }
			set { _sourceColumnScale = value; }
		}
		
		/// <summary>
		/// The precision of the Column mapped onto the entityfield.
		/// Used for update/insert operations on the column
		/// </summary>
		public byte SourceColumnPrecision
		{
			get { return _sourceColumnPrecision; }
			set { _sourceColumnPrecision = value; }
		}

		
		/// <summary>
		/// If set to true, the Dynamic Query Engine (DQE) will assume the field is an Identity field and will act accordingly (i.e.: as the target database
		/// handles Identity fields: SqlServer will generate a new value itself, Oracle wants to have a sequence input.
		/// </summary>
		public bool IsIdentity 
		{
			get { return _isIdentity; }
		}

		/// <summary>
		/// If <see cref="IsIdentity"/> is set to true, this property has to be set to the name of the sequence which supplies the value for the EntityField's
		/// corresponding table field. On SqlServer this is @@IDENTITY or SCOPE_IDENTITY() and only used when the row is succesfully inserted, however on Oracle
		/// f.e. this value is used to specify a new value and to retrieve the new value. Is undefined when <see cref="IsIdentity"/> is set to false.
		/// </summary>
		public string IdentityValueSequenceName 
		{
			get { return _identityValueSequenceName; } 
		}
		#endregion

	}
}