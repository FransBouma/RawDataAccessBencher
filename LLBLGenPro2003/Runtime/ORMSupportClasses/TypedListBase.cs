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
using System.Data;
using System.Collections;
using System.Runtime.Serialization;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Abstract base class for Typed Lists. This class is a thin wrapper around the DataTable to make sure
	/// the member variable obeyWeakRelations is serialized: in VB.NET it's not possible to program
	/// this construct, because in VB.NET you can't re-implement an interface. 
	/// </summary>
	[Serializable]
	public abstract class TypedListBase : DataTable, ISerializable, ITypedListCore
	{
		#region Class Member Declarations
		private bool _obeyWeakRelations;
		#endregion


		/// <summary>
		/// Empty CTor
		/// </summary>
		public TypedListBase()
		{
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="tableName">name for the datatable</param>
		public TypedListBase(string tableName):base(tableName)
		{
		}


		/// <summary>
		/// Protected constructor for deserialization.
		/// Idea borrowed from Dino Esposito's article: http://msdn.microsoft.com/msdnmag/issues/02/12/CuttingEdge/default.aspx
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TypedListBase(SerializationInfo info, StreamingContext context)
		{
			// Extract from the serialization info
			ArrayList colNames, colTypes, dataRows;

			colNames = (ArrayList)info.GetValue("ColNames", typeof(ArrayList));
			colTypes = (ArrayList)info.GetValue("ColTypes", typeof(ArrayList)); 
			dataRows = (ArrayList)info.GetValue("DataRows", typeof(ArrayList)); 

			// Add columns
			for(int i=0;i<colNames.Count; i++)
			{
				DataColumn col = new DataColumn(colNames[i].ToString(), Type.GetType(colTypes[i].ToString() )); 	
				this.Columns.Add(col);
			}

			// Add rows
			for(int i=0; i<dataRows.Count; i++)
			{
				DataRow row = this.NewRow();
				row.ItemArray = (object[]) dataRows[i];
				this.Rows.Add(row);
			}

			_obeyWeakRelations=info.GetBoolean("_obeyWeakRelations");
			base.TableName = info.GetString("_tableName");
		}


		/// <summary>
		/// ISerializable member. Does custom serialization so members also get serialized (obeyWeakRelationships).
		/// Serializes members of this entity class and uses the base class' implementation to serialize the rest.
		/// Idea borrowed from Dino Esposito's article: http://msdn.microsoft.com/msdnmag/issues/02/12/CuttingEdge/default.aspx
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			// Add arrays
			ArrayList colNames = new ArrayList();
			ArrayList colTypes = new ArrayList();
			ArrayList dataRows = new ArrayList();

			// Insert column information (names and types) into worker arrays
			foreach(DataColumn col in this.Columns)
			{
				colNames.Add(col.ColumnName); 
				colTypes.Add(col.DataType.FullName);   
			}

			// Insert rows information into a worker array
			foreach(DataRow row in this.Rows)
			{
				dataRows.Add(row.ItemArray);
			}

			// Add arrays to the serialization info structure
			info.AddValue("ColNames", colNames);
			info.AddValue("ColTypes", colTypes);
			info.AddValue("DataRows", dataRows);

			info.AddValue("_obeyWeakRelations", _obeyWeakRelations);
			info.AddValue("_tableName", base.TableName);
		}

		#region Class Property Declarations
		/// <summary>
		/// Returns the amount of rows in this typed list.
		/// </summary>
		public abstract int Count {get; }

		/// <summary>
		/// Gets / sets ObeyWeakRelations, which is the flag to signal the collection what kind of join statements to generate in the
		/// query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order.
		/// When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.
		/// </summary>
		public bool ObeyWeakRelations
		{
			get { return _obeyWeakRelations; }
			set { _obeyWeakRelations = value; }
		}
		#endregion

	}
}
