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
// Code is generated on: woensdag 4 september 2019 13:44:29
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using System.Collections;
using System.Runtime.Serialization;

using LLBL2003.AdventureWorks2008.HelperClasses;
using LLBL2003.AdventureWorks2008.DaoClasses;
using LLBL2003.AdventureWorks2008.EntityClasses;
using LLBL2003.AdventureWorks2008.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.TypedListClasses
{
	/// <summary>
	/// Typed datatable for the list 'SalesOrderHeader'.
	/// </summary>
	/// <remarks>
	/// It embeds a fill method which accepts a filter.
	/// The code doesn't support any changing of data. Users who do that are on their own.
	/// It also doesn't support any event throwing. This list should be used as a base for readonly databinding
	/// or dataview construction.
	/// </remarks>
	[Serializable]
	public partial class SalesOrderHeaderTypedList : TypedListBase, IEnumerable, ITypedListLgp
	{
		#region Class Member Declarations
		private DataColumn _columnModifiedDate;
		private DataColumn _columnRowguid;
		private DataColumn _columnComment;
		private DataColumn _columnTotalDue;
		private DataColumn _columnFreight;
		private DataColumn _columnTaxAmt;
		private DataColumn _columnSubTotal;
		private DataColumn _columnCurrencyRateID;
		private DataColumn _columnCreditCardApprovalCode;
		private DataColumn _columnCreditCardID;
		private DataColumn _columnShipMethodID;
		private DataColumn _columnShipToAddressID;
		private DataColumn _columnBillToAddressID;
		private DataColumn _columnTerritoryID;
		private DataColumn _columnSalesPersonID;
		private DataColumn _columnCustomerID;
		private DataColumn _columnAccountNumber;
		private DataColumn _columnPurchaseOrderNumber;
		private DataColumn _columnSalesOrderNumber;
		private DataColumn _columnOnlineOrderFlag;
		private DataColumn _columnStatus;
		private DataColumn _columnShipDate;
		private DataColumn _columnDueDate;
		private DataColumn _columnOrderDate;
		private DataColumn _columnRevisionNumber;
		private DataColumn _columnSalesOrderID;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 26;
		#endregion
		

		/// <summary>
		/// CTor
		/// </summary>
		public SalesOrderHeaderTypedList():base("SalesOrderHeader")
		{
			InitClass(false);
		}
		
		
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="obeyWeakRelations">The flag to signal the collection what kind of join statements to generate in the
		/// query statement. Weak relationships are relationships which are optional, for example a
		/// customer with no orders is possible, because the relationship between customer and order is based on a field in order.
		/// When this property is set to true (default: false), weak relationships will result in LEFT JOIN statements. When
		/// set to false (which is the default), INNER JOIN statements are used.
		/// </param>
		public SalesOrderHeaderTypedList(bool obeyWeakRelations):base("SalesOrderHeader")
		{
			InitClass(obeyWeakRelations);
		}
		
		
		/// <summary>
		/// Protected constructor for deserialization.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected SalesOrderHeaderTypedList(SerializationInfo info, StreamingContext context):base(info, context)
		{
			InitMembers();
		}
		
		
		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will use no sort filter, no select filter, will allow duplicate rows and will not limit the amount of rows returned
		/// </summary>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill()
		{
			return Fill(0, null, true, null, null);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will not use a filter, will allow duplicate rows.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, true, null, null);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query. 
		/// Will not use a filter.
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, null, null);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter)
		{
			return Fill(maxNumberOfItemsToReturn, sortClauses, allowDuplicates, selectFilter, null);
		}


		/// <summary>
		/// Fills itself with data. it builds a dynamic query and loads itself with that query, using the specified filter
		/// </summary>
		/// <param name="maxNumberOfItemsToReturn">The maximum amount of rows to return. specifying 0 means all rows are returned</param>
		/// <param name="sortClauses">The order by specifications for the sorting of the resultset. When null is specified, no sorting is applied.</param>
		/// <param name="allowDuplicates">Flag to allow duplicate rows (true) or not (false)</param>
		/// <param name="selectFilter">Predicate which is used to filter the rows to insert in this Typed List instance</param>
		/// <param name="transactionToUse">The transaction object to use. Can be null. If specified, the connection object of the transaction is
		/// used to fill the TypedView, which avoids deadlocks on SqlServer.</param>
		/// <returns>true if fill succeeded, false otherwise</returns>
		public virtual bool Fill(long maxNumberOfItemsToReturn, ISortExpression sortClauses, bool allowDuplicates, IPredicate selectFilter, ITransaction transactionToUse)
		{
			// Build resultset
			IEntityFields fieldsInResultset = BuildResultset();

			// Build relationset
			IRelationCollection relations = BuildRelationSet();

			TypedListDAO dao = DAOFactory.CreateTypedListDAO();
			return dao.GetMultiAsDataTable(fieldsInResultset, this, maxNumberOfItemsToReturn, sortClauses, selectFilter, relations, allowDuplicates, null, transactionToUse);
		}


		/// <summary>
		/// Gets the enumerator for this class.
		/// </summary>
		/// <returns>Enumerator for this class.</returns>
		public IEnumerator GetEnumerator()
		{
			return this.Rows.GetEnumerator();
		}


		/// <summary>
		/// Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.
		/// </summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new SalesOrderHeaderRow(rowBuilder);
		}


		/// <summary>
		/// Builds the relation set for this typed list.
		/// </summary>
		/// <returns>ready to use relation set</returns>
		private IRelationCollection BuildRelationSet()
		{
			IRelationCollection toReturn = new RelationCollection();
			toReturn.ObeyWeakRelations = base.ObeyWeakRelations;


			return toReturn;
		}


		/// <summary>
		/// Builds the resultset fields.
		/// </summary>
		/// <returns>ready to use resultset</returns>
		private IEntityFields BuildResultset()
		{
			ResultsetFields toReturn = new ResultsetFields(AmountOfFields);

			toReturn.DefineField(SalesOrderHeaderFieldIndex.ModifiedDate, 0, "ModifiedDate");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.Rowguid, 1, "Rowguid");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.Comment, 2, "Comment");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.TotalDue, 3, "TotalDue");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.Freight, 4, "Freight");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.TaxAmt, 5, "TaxAmt");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.SubTotal, 6, "SubTotal");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.CurrencyRateID, 7, "CurrencyRateID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.CreditCardApprovalCode, 8, "CreditCardApprovalCode");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.CreditCardID, 9, "CreditCardID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.ShipMethodID, 10, "ShipMethodID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.ShipToAddressID, 11, "ShipToAddressID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.BillToAddressID, 12, "BillToAddressID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.TerritoryID, 13, "TerritoryID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.SalesPersonID, 14, "SalesPersonID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.CustomerID, 15, "CustomerID");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.AccountNumber, 16, "AccountNumber");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.PurchaseOrderNumber, 17, "PurchaseOrderNumber");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.SalesOrderNumber, 18, "SalesOrderNumber");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.OnlineOrderFlag, 19, "OnlineOrderFlag");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.Status, 20, "Status");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.ShipDate, 21, "ShipDate");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.DueDate, 22, "DueDate");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.OrderDate, 23, "OrderDate");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.RevisionNumber, 24, "RevisionNumber");
			toReturn.DefineField(SalesOrderHeaderFieldIndex.SalesOrderID, 25, "SalesOrderID");
			return toReturn;
		}


		/// <summary>
		/// Initialize the datastructures.
		/// </summary>
		/// <param name="obeyWeakRelations">flag for the internal used relations object</param>
		private void InitClass(bool obeyWeakRelations)
		{
			
			_columnModifiedDate = new DataColumn("ModifiedDate", typeof(System.DateTime), null, MappingType.Element);
			_columnModifiedDate.ReadOnly = true;
			this.Columns.Add(_columnModifiedDate);

			_columnRowguid = new DataColumn("Rowguid", typeof(System.Guid), null, MappingType.Element);
			_columnRowguid.ReadOnly = true;
			this.Columns.Add(_columnRowguid);

			_columnComment = new DataColumn("Comment", typeof(System.String), null, MappingType.Element);
			_columnComment.ReadOnly = true;
			this.Columns.Add(_columnComment);

			_columnTotalDue = new DataColumn("TotalDue", typeof(System.Decimal), null, MappingType.Element);
			_columnTotalDue.ReadOnly = true;
			this.Columns.Add(_columnTotalDue);

			_columnFreight = new DataColumn("Freight", typeof(System.Decimal), null, MappingType.Element);
			_columnFreight.ReadOnly = true;
			this.Columns.Add(_columnFreight);

			_columnTaxAmt = new DataColumn("TaxAmt", typeof(System.Decimal), null, MappingType.Element);
			_columnTaxAmt.ReadOnly = true;
			this.Columns.Add(_columnTaxAmt);

			_columnSubTotal = new DataColumn("SubTotal", typeof(System.Decimal), null, MappingType.Element);
			_columnSubTotal.ReadOnly = true;
			this.Columns.Add(_columnSubTotal);

			_columnCurrencyRateID = new DataColumn("CurrencyRateID", typeof(System.Int32), null, MappingType.Element);
			_columnCurrencyRateID.ReadOnly = true;
			this.Columns.Add(_columnCurrencyRateID);

			_columnCreditCardApprovalCode = new DataColumn("CreditCardApprovalCode", typeof(System.String), null, MappingType.Element);
			_columnCreditCardApprovalCode.ReadOnly = true;
			this.Columns.Add(_columnCreditCardApprovalCode);

			_columnCreditCardID = new DataColumn("CreditCardID", typeof(System.Int32), null, MappingType.Element);
			_columnCreditCardID.ReadOnly = true;
			this.Columns.Add(_columnCreditCardID);

			_columnShipMethodID = new DataColumn("ShipMethodID", typeof(System.Int32), null, MappingType.Element);
			_columnShipMethodID.ReadOnly = true;
			this.Columns.Add(_columnShipMethodID);

			_columnShipToAddressID = new DataColumn("ShipToAddressID", typeof(System.Int32), null, MappingType.Element);
			_columnShipToAddressID.ReadOnly = true;
			this.Columns.Add(_columnShipToAddressID);

			_columnBillToAddressID = new DataColumn("BillToAddressID", typeof(System.Int32), null, MappingType.Element);
			_columnBillToAddressID.ReadOnly = true;
			this.Columns.Add(_columnBillToAddressID);

			_columnTerritoryID = new DataColumn("TerritoryID", typeof(System.Int32), null, MappingType.Element);
			_columnTerritoryID.ReadOnly = true;
			this.Columns.Add(_columnTerritoryID);

			_columnSalesPersonID = new DataColumn("SalesPersonID", typeof(System.Int32), null, MappingType.Element);
			_columnSalesPersonID.ReadOnly = true;
			this.Columns.Add(_columnSalesPersonID);

			_columnCustomerID = new DataColumn("CustomerID", typeof(System.Int32), null, MappingType.Element);
			_columnCustomerID.ReadOnly = true;
			this.Columns.Add(_columnCustomerID);

			_columnAccountNumber = new DataColumn("AccountNumber", typeof(System.String), null, MappingType.Element);
			_columnAccountNumber.ReadOnly = true;
			this.Columns.Add(_columnAccountNumber);

			_columnPurchaseOrderNumber = new DataColumn("PurchaseOrderNumber", typeof(System.String), null, MappingType.Element);
			_columnPurchaseOrderNumber.ReadOnly = true;
			this.Columns.Add(_columnPurchaseOrderNumber);

			_columnSalesOrderNumber = new DataColumn("SalesOrderNumber", typeof(System.String), null, MappingType.Element);
			_columnSalesOrderNumber.ReadOnly = true;
			this.Columns.Add(_columnSalesOrderNumber);

			_columnOnlineOrderFlag = new DataColumn("OnlineOrderFlag", typeof(System.Boolean), null, MappingType.Element);
			_columnOnlineOrderFlag.ReadOnly = true;
			this.Columns.Add(_columnOnlineOrderFlag);

			_columnStatus = new DataColumn("Status", typeof(System.Byte), null, MappingType.Element);
			_columnStatus.ReadOnly = true;
			this.Columns.Add(_columnStatus);

			_columnShipDate = new DataColumn("ShipDate", typeof(System.DateTime), null, MappingType.Element);
			_columnShipDate.ReadOnly = true;
			this.Columns.Add(_columnShipDate);

			_columnDueDate = new DataColumn("DueDate", typeof(System.DateTime), null, MappingType.Element);
			_columnDueDate.ReadOnly = true;
			this.Columns.Add(_columnDueDate);

			_columnOrderDate = new DataColumn("OrderDate", typeof(System.DateTime), null, MappingType.Element);
			_columnOrderDate.ReadOnly = true;
			this.Columns.Add(_columnOrderDate);

			_columnRevisionNumber = new DataColumn("RevisionNumber", typeof(System.Byte), null, MappingType.Element);
			_columnRevisionNumber.ReadOnly = true;
			this.Columns.Add(_columnRevisionNumber);

			_columnSalesOrderID = new DataColumn("SalesOrderID", typeof(System.Int32), null, MappingType.Element);
			_columnSalesOrderID.ReadOnly = true;
			this.Columns.Add(_columnSalesOrderID);
			
			base.ObeyWeakRelations = obeyWeakRelations;
		}


		/// <summary>
		/// Initializes the members, after a clone action.
		/// </summary>
		private void InitMembers()
		{
			_columnModifiedDate = this.Columns["ModifiedDate"];
			_columnRowguid = this.Columns["Rowguid"];
			_columnComment = this.Columns["Comment"];
			_columnTotalDue = this.Columns["TotalDue"];
			_columnFreight = this.Columns["Freight"];
			_columnTaxAmt = this.Columns["TaxAmt"];
			_columnSubTotal = this.Columns["SubTotal"];
			_columnCurrencyRateID = this.Columns["CurrencyRateID"];
			_columnCreditCardApprovalCode = this.Columns["CreditCardApprovalCode"];
			_columnCreditCardID = this.Columns["CreditCardID"];
			_columnShipMethodID = this.Columns["ShipMethodID"];
			_columnShipToAddressID = this.Columns["ShipToAddressID"];
			_columnBillToAddressID = this.Columns["BillToAddressID"];
			_columnTerritoryID = this.Columns["TerritoryID"];
			_columnSalesPersonID = this.Columns["SalesPersonID"];
			_columnCustomerID = this.Columns["CustomerID"];
			_columnAccountNumber = this.Columns["AccountNumber"];
			_columnPurchaseOrderNumber = this.Columns["PurchaseOrderNumber"];
			_columnSalesOrderNumber = this.Columns["SalesOrderNumber"];
			_columnOnlineOrderFlag = this.Columns["OnlineOrderFlag"];
			_columnStatus = this.Columns["Status"];
			_columnShipDate = this.Columns["ShipDate"];
			_columnDueDate = this.Columns["DueDate"];
			_columnOrderDate = this.Columns["OrderDate"];
			_columnRevisionNumber = this.Columns["RevisionNumber"];
			_columnSalesOrderID = this.Columns["SalesOrderID"];
		}


		/// <summary>
		/// Return the type of the typed datarow
		/// </summary>
		/// <returns>returns the requested type</returns>
		protected override Type GetRowType() 
		{
			return typeof(SalesOrderHeaderRow);
		}


		/// <summary>
		/// Clones this instance.
		/// </summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			SalesOrderHeaderTypedList cloneToReturn = ((SalesOrderHeaderTypedList)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}
            
		/// <summary>
		/// Creates a new instance of the DataTable class.
		/// </summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new SalesOrderHeaderTypedList();
		}

		#region Class Property Declarations
		/// <summary>
		/// Returns the amount of rows in this typed list.
		/// </summary>
		[System.ComponentModel.Browsable(false)]
		public override int Count 
		{
			get 
			{
				return this.Rows.Count;
			}
		}

		/// <summary>
		/// Indexer of this strong typed list
		/// </summary>
		public SalesOrderHeaderRow this[int index] 
		{
			get 
			{
				return ((SalesOrderHeaderRow)(this.Rows[index]));
			}
		}

	
		/// <summary>
		/// Returns the column object belonging to the TypedList field ModifiedDate
		/// </summary>
		internal DataColumn ModifiedDateColumn 
		{
			get { return _columnModifiedDate; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field Rowguid
		/// </summary>
		internal DataColumn RowguidColumn 
		{
			get { return _columnRowguid; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field Comment
		/// </summary>
		internal DataColumn CommentColumn 
		{
			get { return _columnComment; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field TotalDue
		/// </summary>
		internal DataColumn TotalDueColumn 
		{
			get { return _columnTotalDue; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field Freight
		/// </summary>
		internal DataColumn FreightColumn 
		{
			get { return _columnFreight; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field TaxAmt
		/// </summary>
		internal DataColumn TaxAmtColumn 
		{
			get { return _columnTaxAmt; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field SubTotal
		/// </summary>
		internal DataColumn SubTotalColumn 
		{
			get { return _columnSubTotal; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field CurrencyRateID
		/// </summary>
		internal DataColumn CurrencyRateIDColumn 
		{
			get { return _columnCurrencyRateID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field CreditCardApprovalCode
		/// </summary>
		internal DataColumn CreditCardApprovalCodeColumn 
		{
			get { return _columnCreditCardApprovalCode; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field CreditCardID
		/// </summary>
		internal DataColumn CreditCardIDColumn 
		{
			get { return _columnCreditCardID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field ShipMethodID
		/// </summary>
		internal DataColumn ShipMethodIDColumn 
		{
			get { return _columnShipMethodID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field ShipToAddressID
		/// </summary>
		internal DataColumn ShipToAddressIDColumn 
		{
			get { return _columnShipToAddressID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field BillToAddressID
		/// </summary>
		internal DataColumn BillToAddressIDColumn 
		{
			get { return _columnBillToAddressID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field TerritoryID
		/// </summary>
		internal DataColumn TerritoryIDColumn 
		{
			get { return _columnTerritoryID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field SalesPersonID
		/// </summary>
		internal DataColumn SalesPersonIDColumn 
		{
			get { return _columnSalesPersonID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field CustomerID
		/// </summary>
		internal DataColumn CustomerIDColumn 
		{
			get { return _columnCustomerID; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field AccountNumber
		/// </summary>
		internal DataColumn AccountNumberColumn 
		{
			get { return _columnAccountNumber; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field PurchaseOrderNumber
		/// </summary>
		internal DataColumn PurchaseOrderNumberColumn 
		{
			get { return _columnPurchaseOrderNumber; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field SalesOrderNumber
		/// </summary>
		internal DataColumn SalesOrderNumberColumn 
		{
			get { return _columnSalesOrderNumber; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field OnlineOrderFlag
		/// </summary>
		internal DataColumn OnlineOrderFlagColumn 
		{
			get { return _columnOnlineOrderFlag; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field Status
		/// </summary>
		internal DataColumn StatusColumn 
		{
			get { return _columnStatus; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field ShipDate
		/// </summary>
		internal DataColumn ShipDateColumn 
		{
			get { return _columnShipDate; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field DueDate
		/// </summary>
		internal DataColumn DueDateColumn 
		{
			get { return _columnDueDate; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field OrderDate
		/// </summary>
		internal DataColumn OrderDateColumn 
		{
			get { return _columnOrderDate; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field RevisionNumber
		/// </summary>
		internal DataColumn RevisionNumberColumn 
		{
			get { return _columnRevisionNumber; }
		}
    
		/// <summary>
		/// Returns the column object belonging to the TypedList field SalesOrderID
		/// </summary>
		internal DataColumn SalesOrderIDColumn 
		{
			get { return _columnSalesOrderID; }
		}
    
 		#endregion
	}


	/// <summary>
	/// Typed datarow for the typed datatable SalesOrderHeader
	/// </summary>
	public class SalesOrderHeaderRow : DataRow
	{
		#region Class Member Declarations
		private SalesOrderHeaderTypedList	_parent;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		internal SalesOrderHeaderRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((SalesOrderHeaderTypedList)(this.Table));
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Gets / sets the value of the TypedList field ModifiedDate
		/// </summary>
		public System.DateTime ModifiedDate 
		{
			get 
			{
				try
				{
					return (System.DateTime)this[_parent.ModifiedDateColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.ModifiedDateColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field ModifiedDate is NULL, false otherwise.
		/// </summary>
		public bool IsModifiedDateNull() 
		{
			return IsNull(_parent.ModifiedDateColumn);
		}

		/// <summary>
		/// Sets the TypedList field ModifiedDate to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetModifiedDateNull() 
		{
			this[_parent.ModifiedDateColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field Rowguid
		/// </summary>
		public System.Guid Rowguid 
		{
			get 
			{
				try
				{
					return (System.Guid)this[_parent.RowguidColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.RowguidColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field Rowguid is NULL, false otherwise.
		/// </summary>
		public bool IsRowguidNull() 
		{
			return IsNull(_parent.RowguidColumn);
		}

		/// <summary>
		/// Sets the TypedList field Rowguid to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetRowguidNull() 
		{
			this[_parent.RowguidColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field Comment
		/// </summary>
		public System.String Comment 
		{
			get 
			{
				try
				{
					return (System.String)this[_parent.CommentColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.CommentColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field Comment is NULL, false otherwise.
		/// </summary>
		public bool IsCommentNull() 
		{
			return IsNull(_parent.CommentColumn);
		}

		/// <summary>
		/// Sets the TypedList field Comment to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCommentNull() 
		{
			this[_parent.CommentColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field TotalDue
		/// </summary>
		public System.Decimal TotalDue 
		{
			get 
			{
				try
				{
					return (System.Decimal)this[_parent.TotalDueColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.TotalDueColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field TotalDue is NULL, false otherwise.
		/// </summary>
		public bool IsTotalDueNull() 
		{
			return IsNull(_parent.TotalDueColumn);
		}

		/// <summary>
		/// Sets the TypedList field TotalDue to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetTotalDueNull() 
		{
			this[_parent.TotalDueColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field Freight
		/// </summary>
		public System.Decimal Freight 
		{
			get 
			{
				try
				{
					return (System.Decimal)this[_parent.FreightColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.FreightColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field Freight is NULL, false otherwise.
		/// </summary>
		public bool IsFreightNull() 
		{
			return IsNull(_parent.FreightColumn);
		}

		/// <summary>
		/// Sets the TypedList field Freight to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetFreightNull() 
		{
			this[_parent.FreightColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field TaxAmt
		/// </summary>
		public System.Decimal TaxAmt 
		{
			get 
			{
				try
				{
					return (System.Decimal)this[_parent.TaxAmtColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.TaxAmtColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field TaxAmt is NULL, false otherwise.
		/// </summary>
		public bool IsTaxAmtNull() 
		{
			return IsNull(_parent.TaxAmtColumn);
		}

		/// <summary>
		/// Sets the TypedList field TaxAmt to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetTaxAmtNull() 
		{
			this[_parent.TaxAmtColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field SubTotal
		/// </summary>
		public System.Decimal SubTotal 
		{
			get 
			{
				try
				{
					return (System.Decimal)this[_parent.SubTotalColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.SubTotalColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field SubTotal is NULL, false otherwise.
		/// </summary>
		public bool IsSubTotalNull() 
		{
			return IsNull(_parent.SubTotalColumn);
		}

		/// <summary>
		/// Sets the TypedList field SubTotal to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetSubTotalNull() 
		{
			this[_parent.SubTotalColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field CurrencyRateID
		/// </summary>
		public System.Int32 CurrencyRateID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.CurrencyRateIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.CurrencyRateIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field CurrencyRateID is NULL, false otherwise.
		/// </summary>
		public bool IsCurrencyRateIDNull() 
		{
			return IsNull(_parent.CurrencyRateIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field CurrencyRateID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCurrencyRateIDNull() 
		{
			this[_parent.CurrencyRateIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field CreditCardApprovalCode
		/// </summary>
		public System.String CreditCardApprovalCode 
		{
			get 
			{
				try
				{
					return (System.String)this[_parent.CreditCardApprovalCodeColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.CreditCardApprovalCodeColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field CreditCardApprovalCode is NULL, false otherwise.
		/// </summary>
		public bool IsCreditCardApprovalCodeNull() 
		{
			return IsNull(_parent.CreditCardApprovalCodeColumn);
		}

		/// <summary>
		/// Sets the TypedList field CreditCardApprovalCode to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCreditCardApprovalCodeNull() 
		{
			this[_parent.CreditCardApprovalCodeColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field CreditCardID
		/// </summary>
		public System.Int32 CreditCardID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.CreditCardIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.CreditCardIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field CreditCardID is NULL, false otherwise.
		/// </summary>
		public bool IsCreditCardIDNull() 
		{
			return IsNull(_parent.CreditCardIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field CreditCardID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCreditCardIDNull() 
		{
			this[_parent.CreditCardIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field ShipMethodID
		/// </summary>
		public System.Int32 ShipMethodID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.ShipMethodIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.ShipMethodIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field ShipMethodID is NULL, false otherwise.
		/// </summary>
		public bool IsShipMethodIDNull() 
		{
			return IsNull(_parent.ShipMethodIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field ShipMethodID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetShipMethodIDNull() 
		{
			this[_parent.ShipMethodIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field ShipToAddressID
		/// </summary>
		public System.Int32 ShipToAddressID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.ShipToAddressIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.ShipToAddressIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field ShipToAddressID is NULL, false otherwise.
		/// </summary>
		public bool IsShipToAddressIDNull() 
		{
			return IsNull(_parent.ShipToAddressIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field ShipToAddressID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetShipToAddressIDNull() 
		{
			this[_parent.ShipToAddressIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field BillToAddressID
		/// </summary>
		public System.Int32 BillToAddressID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.BillToAddressIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.BillToAddressIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field BillToAddressID is NULL, false otherwise.
		/// </summary>
		public bool IsBillToAddressIDNull() 
		{
			return IsNull(_parent.BillToAddressIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field BillToAddressID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetBillToAddressIDNull() 
		{
			this[_parent.BillToAddressIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field TerritoryID
		/// </summary>
		public System.Int32 TerritoryID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.TerritoryIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.TerritoryIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field TerritoryID is NULL, false otherwise.
		/// </summary>
		public bool IsTerritoryIDNull() 
		{
			return IsNull(_parent.TerritoryIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field TerritoryID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetTerritoryIDNull() 
		{
			this[_parent.TerritoryIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field SalesPersonID
		/// </summary>
		public System.Int32 SalesPersonID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.SalesPersonIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.SalesPersonIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field SalesPersonID is NULL, false otherwise.
		/// </summary>
		public bool IsSalesPersonIDNull() 
		{
			return IsNull(_parent.SalesPersonIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field SalesPersonID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetSalesPersonIDNull() 
		{
			this[_parent.SalesPersonIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field CustomerID
		/// </summary>
		public System.Int32 CustomerID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.CustomerIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.CustomerIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field CustomerID is NULL, false otherwise.
		/// </summary>
		public bool IsCustomerIDNull() 
		{
			return IsNull(_parent.CustomerIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field CustomerID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetCustomerIDNull() 
		{
			this[_parent.CustomerIDColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field AccountNumber
		/// </summary>
		public System.String AccountNumber 
		{
			get 
			{
				try
				{
					return (System.String)this[_parent.AccountNumberColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.AccountNumberColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field AccountNumber is NULL, false otherwise.
		/// </summary>
		public bool IsAccountNumberNull() 
		{
			return IsNull(_parent.AccountNumberColumn);
		}

		/// <summary>
		/// Sets the TypedList field AccountNumber to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetAccountNumberNull() 
		{
			this[_parent.AccountNumberColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field PurchaseOrderNumber
		/// </summary>
		public System.String PurchaseOrderNumber 
		{
			get 
			{
				try
				{
					return (System.String)this[_parent.PurchaseOrderNumberColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.PurchaseOrderNumberColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field PurchaseOrderNumber is NULL, false otherwise.
		/// </summary>
		public bool IsPurchaseOrderNumberNull() 
		{
			return IsNull(_parent.PurchaseOrderNumberColumn);
		}

		/// <summary>
		/// Sets the TypedList field PurchaseOrderNumber to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetPurchaseOrderNumberNull() 
		{
			this[_parent.PurchaseOrderNumberColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field SalesOrderNumber
		/// </summary>
		public System.String SalesOrderNumber 
		{
			get 
			{
				try
				{
					return (System.String)this[_parent.SalesOrderNumberColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.SalesOrderNumberColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field SalesOrderNumber is NULL, false otherwise.
		/// </summary>
		public bool IsSalesOrderNumberNull() 
		{
			return IsNull(_parent.SalesOrderNumberColumn);
		}

		/// <summary>
		/// Sets the TypedList field SalesOrderNumber to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetSalesOrderNumberNull() 
		{
			this[_parent.SalesOrderNumberColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field OnlineOrderFlag
		/// </summary>
		public System.Boolean OnlineOrderFlag 
		{
			get 
			{
				try
				{
					return (System.Boolean)this[_parent.OnlineOrderFlagColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.OnlineOrderFlagColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field OnlineOrderFlag is NULL, false otherwise.
		/// </summary>
		public bool IsOnlineOrderFlagNull() 
		{
			return IsNull(_parent.OnlineOrderFlagColumn);
		}

		/// <summary>
		/// Sets the TypedList field OnlineOrderFlag to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetOnlineOrderFlagNull() 
		{
			this[_parent.OnlineOrderFlagColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field Status
		/// </summary>
		public System.Byte Status 
		{
			get 
			{
				try
				{
					return (System.Byte)this[_parent.StatusColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.StatusColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field Status is NULL, false otherwise.
		/// </summary>
		public bool IsStatusNull() 
		{
			return IsNull(_parent.StatusColumn);
		}

		/// <summary>
		/// Sets the TypedList field Status to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetStatusNull() 
		{
			this[_parent.StatusColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field ShipDate
		/// </summary>
		public System.DateTime ShipDate 
		{
			get 
			{
				try
				{
					return (System.DateTime)this[_parent.ShipDateColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.ShipDateColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field ShipDate is NULL, false otherwise.
		/// </summary>
		public bool IsShipDateNull() 
		{
			return IsNull(_parent.ShipDateColumn);
		}

		/// <summary>
		/// Sets the TypedList field ShipDate to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetShipDateNull() 
		{
			this[_parent.ShipDateColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field DueDate
		/// </summary>
		public System.DateTime DueDate 
		{
			get 
			{
				try
				{
					return (System.DateTime)this[_parent.DueDateColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.DueDateColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field DueDate is NULL, false otherwise.
		/// </summary>
		public bool IsDueDateNull() 
		{
			return IsNull(_parent.DueDateColumn);
		}

		/// <summary>
		/// Sets the TypedList field DueDate to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetDueDateNull() 
		{
			this[_parent.DueDateColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field OrderDate
		/// </summary>
		public System.DateTime OrderDate 
		{
			get 
			{
				try
				{
					return (System.DateTime)this[_parent.OrderDateColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.OrderDateColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field OrderDate is NULL, false otherwise.
		/// </summary>
		public bool IsOrderDateNull() 
		{
			return IsNull(_parent.OrderDateColumn);
		}

		/// <summary>
		/// Sets the TypedList field OrderDate to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetOrderDateNull() 
		{
			this[_parent.OrderDateColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field RevisionNumber
		/// </summary>
		public System.Byte RevisionNumber 
		{
			get 
			{
				try
				{
					return (System.Byte)this[_parent.RevisionNumberColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.RevisionNumberColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field RevisionNumber is NULL, false otherwise.
		/// </summary>
		public bool IsRevisionNumberNull() 
		{
			return IsNull(_parent.RevisionNumberColumn);
		}

		/// <summary>
		/// Sets the TypedList field RevisionNumber to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetRevisionNumberNull() 
		{
			this[_parent.RevisionNumberColumn] = System.Convert.DBNull;
		}

	

		/// <summary>
		/// Gets / sets the value of the TypedList field SalesOrderID
		/// </summary>
		public System.Int32 SalesOrderID 
		{
			get 
			{
				try
				{
					return (System.Int32)this[_parent.SalesOrderIDColumn];
				}
				catch (InvalidCastException e) 
				{
					throw new StrongTypingException("Cannot get value because it is NULL.", e);
				}
			}
			set 
			{
				this[_parent.SalesOrderIDColumn] = value;
			}
		}

		/// <summary>
		/// Returns true if the TypedList field SalesOrderID is NULL, false otherwise.
		/// </summary>
		public bool IsSalesOrderIDNull() 
		{
			return IsNull(_parent.SalesOrderIDColumn);
		}

		/// <summary>
		/// Sets the TypedList field SalesOrderID to NULL. Not recommended; a typed list should be used
		/// as a readonly object.
		/// </summary>
    	public void SetSalesOrderIDNull() 
		{
			this[_parent.SalesOrderIDColumn] = System.Convert.DBNull;
		}

	
		#endregion
	}
}
