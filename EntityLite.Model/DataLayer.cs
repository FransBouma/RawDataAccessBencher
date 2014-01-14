

using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using Microsoft.SqlServer.Types;
using System.Runtime.Serialization;
using inercya.EntityLite;	
using inercya.EntityLite.Extensions;		

namespace EntityLite.Model
{
	[Serializable]
	[DataContract]
	[SqlEntity(BaseTableName="SalesOrderHeader")]
	public partial class SalesOrderHeader
	{
		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, IsKey=true, IsAutoincrement=true, IsReadOnly = true, ColumnName ="SalesOrderID", BaseColumnName ="SalesOrderID", BaseTableName = "SalesOrderHeader" )]
		public Int32 SalesOrderId { get; set; }

		[DataMember]
		[SqlField(DbType.Byte, 1, Precision = 3, ColumnName ="RevisionNumber", BaseColumnName ="RevisionNumber", BaseTableName = "SalesOrderHeader" )]
		public Byte RevisionNumber { get; set; }

		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="OrderDate", BaseColumnName ="OrderDate", BaseTableName = "SalesOrderHeader" )]
		public DateTime OrderDate { get; set; }

		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="DueDate", BaseColumnName ="DueDate", BaseTableName = "SalesOrderHeader" )]
		public DateTime DueDate { get; set; }

		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, AllowNull = true, ColumnName ="ShipDate", BaseColumnName ="ShipDate", BaseTableName = "SalesOrderHeader" )]
		public DateTime? ShipDate { get; set; }

		[DataMember]
		[SqlField(DbType.Byte, 1, Precision = 3, ColumnName ="Status", BaseColumnName ="Status", BaseTableName = "SalesOrderHeader" )]
		public Byte Status { get; set; }

		[DataMember]
		[SqlField(DbType.Boolean, 1, ColumnName ="OnlineOrderFlag", BaseColumnName ="OnlineOrderFlag", BaseTableName = "SalesOrderHeader" )]
		public Boolean OnlineOrderFlag { get; set; }

		[DataMember]
		[SqlField(DbType.String, 25, IsReadOnly = true, ColumnName ="SalesOrderNumber", BaseColumnName ="SalesOrderNumber", BaseTableName = "SalesOrderHeader" )]
		public String SalesOrderNumber { get; set; }

		[DataMember]
		[SqlField(DbType.String, 25, ColumnName ="PurchaseOrderNumber", BaseColumnName ="PurchaseOrderNumber", BaseTableName = "SalesOrderHeader" )]
		public String PurchaseOrderNumber { get; set; }

		[DataMember]
		[SqlField(DbType.String, 15, ColumnName ="AccountNumber", BaseColumnName ="AccountNumber", BaseTableName = "SalesOrderHeader" )]
		public String AccountNumber { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="CustomerID", BaseColumnName ="CustomerID", BaseTableName = "SalesOrderHeader" )]
		public Int32 CustomerId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="SalesPersonID", BaseColumnName ="SalesPersonID", BaseTableName = "SalesOrderHeader" )]
		public Int32? SalesPersonId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="TerritoryID", BaseColumnName ="TerritoryID", BaseTableName = "SalesOrderHeader" )]
		public Int32? TerritoryId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="BillToAddressID", BaseColumnName ="BillToAddressID", BaseTableName = "SalesOrderHeader" )]
		public Int32 BillToAddressId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ShipToAddressID", BaseColumnName ="ShipToAddressID", BaseTableName = "SalesOrderHeader" )]
		public Int32 ShipToAddressId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, ColumnName ="ShipMethodID", BaseColumnName ="ShipMethodID", BaseTableName = "SalesOrderHeader" )]
		public Int32 ShipMethodId { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="CreditCardID", BaseColumnName ="CreditCardID", BaseTableName = "SalesOrderHeader" )]
		public Int32? CreditCardId { get; set; }

		[DataMember]
		[SqlField(DbType.AnsiString, 15, ColumnName ="CreditCardApprovalCode", BaseColumnName ="CreditCardApprovalCode", BaseTableName = "SalesOrderHeader" )]
		public String CreditCardApprovalCode { get; set; }

		[DataMember]
		[SqlField(DbType.Int32, 4, Precision = 10, AllowNull = true, ColumnName ="CurrencyRateID", BaseColumnName ="CurrencyRateID", BaseTableName = "SalesOrderHeader" )]
		public Int32? CurrencyRateId { get; set; }

		[DataMember]
		[SqlField(DbType.Currency, 8, Precision = 19, ColumnName ="SubTotal", BaseColumnName ="SubTotal", BaseTableName = "SalesOrderHeader" )]
		public Decimal SubTotal { get; set; }

		[DataMember]
		[SqlField(DbType.Currency, 8, Precision = 19, ColumnName ="TaxAmt", BaseColumnName ="TaxAmt", BaseTableName = "SalesOrderHeader" )]
		public Decimal TaxAmt { get; set; }

		[DataMember]
		[SqlField(DbType.Currency, 8, Precision = 19, ColumnName ="Freight", BaseColumnName ="Freight", BaseTableName = "SalesOrderHeader" )]
		public Decimal Freight { get; set; }

		[DataMember]
		[SqlField(DbType.Currency, 8, Precision = 19, IsReadOnly = true, ColumnName ="TotalDue", BaseColumnName ="TotalDue", BaseTableName = "SalesOrderHeader" )]
		public Decimal TotalDue { get; set; }

		[DataMember]
		[SqlField(DbType.String, 128, ColumnName ="Comment", BaseColumnName ="Comment", BaseTableName = "SalesOrderHeader" )]
		public String Comment { get; set; }

		[DataMember]
		[SqlField(DbType.Guid, 16, ColumnName ="rowguid", BaseColumnName ="rowguid", BaseTableName = "SalesOrderHeader" )]
		public Guid Rowguid { get; set; }

		[DataMember]
		[SqlField(DbType.DateTime, 8, Precision = 23, Scale=3, ColumnName ="ModifiedDate", BaseColumnName ="ModifiedDate", BaseTableName = "SalesOrderHeader" )]
		public DateTime ModifiedDate { get; set; }


	}

	public partial class SalesOrderHeaderRepository : Repository<SalesOrderHeader> 
	{
		public SalesOrderHeaderRepository(DataService DataService) : base(DataService)
		{
		}

		public new AdventureWorksDataService  DataService  
		{
			get { return (AdventureWorksDataService) base.DataService; }
			set { base.DataService = value; }
		}

		public SalesOrderHeader Get(string projectionName, System.Int32 salesOrderId)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projectionName, salesOrderId, FetchMode.UseIdentityMap);
		}

		public SalesOrderHeader Get(string projectionName, System.Int32 salesOrderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projectionName, salesOrderId, fetchMode);
		}

		public SalesOrderHeader Get(Projection projection, System.Int32 salesOrderId)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projection, salesOrderId, FetchMode.UseIdentityMap);
		}

		public SalesOrderHeader Get(Projection projection, System.Int32 salesOrderId, FetchMode fetchMode = FetchMode.UseIdentityMap)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projection, salesOrderId, fetchMode);
		}

		public SalesOrderHeader Get(string projectionName, System.Int32 salesOrderId, params string[] fields)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projectionName, salesOrderId, fields);
		}

		public SalesOrderHeader Get(Projection projection, System.Int32 salesOrderId, params string[] fields)
		{
			return ((IRepository<SalesOrderHeader>)this).Get(projection, salesOrderId, fields);
		}

		public void Delete(System.Int32 salesOrderId)
		{
			var entity = new SalesOrderHeader { SalesOrderId = salesOrderId };
			this.Delete(entity);
		}
	}

	public static partial class SalesOrderHeaderFields
	{
		public const string SalesOrderId = "SalesOrderId";
		public const string RevisionNumber = "RevisionNumber";
		public const string OrderDate = "OrderDate";
		public const string DueDate = "DueDate";
		public const string ShipDate = "ShipDate";
		public const string Status = "Status";
		public const string OnlineOrderFlag = "OnlineOrderFlag";
		public const string SalesOrderNumber = "SalesOrderNumber";
		public const string PurchaseOrderNumber = "PurchaseOrderNumber";
		public const string AccountNumber = "AccountNumber";
		public const string CustomerId = "CustomerId";
		public const string SalesPersonId = "SalesPersonId";
		public const string TerritoryId = "TerritoryId";
		public const string BillToAddressId = "BillToAddressId";
		public const string ShipToAddressId = "ShipToAddressId";
		public const string ShipMethodId = "ShipMethodId";
		public const string CreditCardId = "CreditCardId";
		public const string CreditCardApprovalCode = "CreditCardApprovalCode";
		public const string CurrencyRateId = "CurrencyRateId";
		public const string SubTotal = "SubTotal";
		public const string TaxAmt = "TaxAmt";
		public const string Freight = "Freight";
		public const string TotalDue = "TotalDue";
		public const string Comment = "Comment";
		public const string Rowguid = "Rowguid";
		public const string ModifiedDate = "ModifiedDate";
	}

}

namespace EntityLite.Model
{
	public partial class AdventureWorksDataService : DataService
	{
		partial void OnCreated();

		private void Init()
		{
			EntityNameToEntityViewTransform = TextTransform.None;
			EntityLiteProvider.DefaultSchema = "Sales";
			OnCreated();
		}

        public AdventureWorksDataService() : base("AdventureWorks.ConnectionString.SQL Server (SqlClient)")
        {
			Init();
        }

        public AdventureWorksDataService(string connectionStringName) : base(connectionStringName)
        {
			Init();
        }

        public AdventureWorksDataService(string connectionString, string providerName) : base(connectionString, providerName)
        {
			Init();
        }

		private EntityLite.Model.SalesOrderHeaderRepository _SalesOrderHeaderRepository;
		public EntityLite.Model.SalesOrderHeaderRepository SalesOrderHeaderRepository
		{
			get 
			{
				if ( _SalesOrderHeaderRepository == null)
				{
					_SalesOrderHeaderRepository = new EntityLite.Model.SalesOrderHeaderRepository(this);
				}
				return _SalesOrderHeaderRepository;
			}
		}
	}
}
