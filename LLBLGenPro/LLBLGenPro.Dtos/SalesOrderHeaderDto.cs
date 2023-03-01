﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace LLBLGenPro.Dtos.DtoClasses
{ 
	/// <summary> DTO class which is derived from the entity 'SalesOrderHeader'.</summary>
	[Serializable]
	[DataContract]
	public partial class SalesOrderHeaderDto
	{
		/// <summary>Gets or sets the AccountNumber field. Derived from Entity Model Field 'SalesOrderHeader.AccountNumber'</summary>
		[DataMember]
		public System.String AccountNumber { get; set; }
		/// <summary>Gets or sets the BillToAddressId field. Derived from Entity Model Field 'SalesOrderHeader.BillToAddressId (FK)'</summary>
		[DataMember]
		public System.Int32 BillToAddressId { get; set; }
		/// <summary>Gets or sets the Comment field. Derived from Entity Model Field 'SalesOrderHeader.Comment'</summary>
		[DataMember]
		public System.String Comment { get; set; }
		/// <summary>Gets or sets the CreditCardApprovalCode field. Derived from Entity Model Field 'SalesOrderHeader.CreditCardApprovalCode'</summary>
		[DataMember]
		public System.String CreditCardApprovalCode { get; set; }
		/// <summary>Gets or sets the CreditCardId field. Derived from Entity Model Field 'SalesOrderHeader.CreditCardId (FK)'</summary>
		[DataMember]
		public Nullable<System.Int32> CreditCardId { get; set; }
		/// <summary>Gets or sets the CurrencyRateId field. Derived from Entity Model Field 'SalesOrderHeader.CurrencyRateId (FK)'</summary>
		[DataMember]
		public Nullable<System.Int32> CurrencyRateId { get; set; }
		/// <summary>Gets or sets the Customer field. </summary>
		[DataMember]
		public SalesOrderHeaderDtoTypes.CustomerDto Customer { get; set; }
		/// <summary>Gets or sets the CustomerId field. Derived from Entity Model Field 'SalesOrderHeader.CustomerId (FK)'</summary>
		[DataMember]
		public System.Int32 CustomerId { get; set; }
		/// <summary>Gets or sets the DueDate field. Derived from Entity Model Field 'SalesOrderHeader.DueDate'</summary>
		[DataMember]
		public System.DateTime DueDate { get; set; }
		/// <summary>Gets or sets the Freight field. Derived from Entity Model Field 'SalesOrderHeader.Freight'</summary>
		[DataMember]
		public System.Decimal Freight { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. Derived from Entity Model Field 'SalesOrderHeader.ModifiedDate'</summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the OnlineOrderFlag field. Derived from Entity Model Field 'SalesOrderHeader.OnlineOrderFlag'</summary>
		[DataMember]
		public System.Boolean OnlineOrderFlag { get; set; }
		/// <summary>Gets or sets the OrderDate field. Derived from Entity Model Field 'SalesOrderHeader.OrderDate'</summary>
		[DataMember]
		public System.DateTime OrderDate { get; set; }
		/// <summary>Gets or sets the PurchaseOrderNumber field. Derived from Entity Model Field 'SalesOrderHeader.PurchaseOrderNumber'</summary>
		[DataMember]
		public System.String PurchaseOrderNumber { get; set; }
		/// <summary>Gets or sets the RevisionNumber field. Derived from Entity Model Field 'SalesOrderHeader.RevisionNumber'</summary>
		[DataMember]
		public System.Byte RevisionNumber { get; set; }
		/// <summary>Gets or sets the Rowguid field. Derived from Entity Model Field 'SalesOrderHeader.Rowguid'</summary>
		[DataMember]
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the SalesOrderDetails field. </summary>
		[DataMember]
		public List<SalesOrderHeaderDtoTypes.SalesOrderDetailDto> SalesOrderDetails { get; set; }
		/// <summary>Gets or sets the SalesOrderId field. Derived from Entity Model Field 'SalesOrderHeader.SalesOrderId'</summary>
		[DataMember]
		public System.Int32 SalesOrderId { get; set; }
		/// <summary>Gets or sets the SalesOrderNumber field. Derived from Entity Model Field 'SalesOrderHeader.SalesOrderNumber'</summary>
		[DataMember]
		public System.String SalesOrderNumber { get; set; }
		/// <summary>Gets or sets the SalesPersonId field. Derived from Entity Model Field 'SalesOrderHeader.SalesPersonId (FK)'</summary>
		[DataMember]
		public Nullable<System.Int32> SalesPersonId { get; set; }
		/// <summary>Gets or sets the ShipDate field. Derived from Entity Model Field 'SalesOrderHeader.ShipDate'</summary>
		[DataMember]
		public Nullable<System.DateTime> ShipDate { get; set; }
		/// <summary>Gets or sets the ShipMethodId field. Derived from Entity Model Field 'SalesOrderHeader.ShipMethodId (FK)'</summary>
		[DataMember]
		public System.Int32 ShipMethodId { get; set; }
		/// <summary>Gets or sets the ShipToAddressId field. Derived from Entity Model Field 'SalesOrderHeader.ShipToAddressId (FK)'</summary>
		[DataMember]
		public System.Int32 ShipToAddressId { get; set; }
		/// <summary>Gets or sets the Status field. Derived from Entity Model Field 'SalesOrderHeader.Status'</summary>
		[DataMember]
		public System.Byte Status { get; set; }
		/// <summary>Gets or sets the SubTotal field. Derived from Entity Model Field 'SalesOrderHeader.SubTotal'</summary>
		[DataMember]
		public System.Decimal SubTotal { get; set; }
		/// <summary>Gets or sets the TaxAmt field. Derived from Entity Model Field 'SalesOrderHeader.TaxAmt'</summary>
		[DataMember]
		public System.Decimal TaxAmt { get; set; }
		/// <summary>Gets or sets the TerritoryId field. Derived from Entity Model Field 'SalesOrderHeader.TerritoryId (FK)'</summary>
		[DataMember]
		public Nullable<System.Int32> TerritoryId { get; set; }
		/// <summary>Gets or sets the TotalDue field. Derived from Entity Model Field 'SalesOrderHeader.TotalDue'</summary>
		[DataMember]
		public System.Decimal TotalDue { get; set; }
	}

	namespace SalesOrderHeaderDtoTypes
	{
		/// <summary> DTO class which is derived from the entity 'Customer (Customer)'.</summary>
		[Serializable]
		[DataContract]
		public partial class CustomerDto
		{
			/// <summary>Gets or sets the AccountNumber field. Derived from Entity Model Field 'Customer.AccountNumber'</summary>
			[DataMember]
			public System.String AccountNumber { get; set; }
			/// <summary>Gets or sets the CustomerId field. Derived from Entity Model Field 'Customer.CustomerId'</summary>
			[DataMember]
			public System.Int32 CustomerId { get; set; }
			/// <summary>Gets or sets the ModifiedDate field. Derived from Entity Model Field 'Customer.ModifiedDate'</summary>
			[DataMember]
			public System.DateTime ModifiedDate { get; set; }
			/// <summary>Gets or sets the PersonId field. Derived from Entity Model Field 'Customer.PersonId (FK)'</summary>
			[DataMember]
			public Nullable<System.Int32> PersonId { get; set; }
			/// <summary>Gets or sets the Rowguid field. Derived from Entity Model Field 'Customer.Rowguid'</summary>
			[DataMember]
			public System.Guid Rowguid { get; set; }
			/// <summary>Gets or sets the StoreId field. Derived from Entity Model Field 'Customer.StoreId (FK)'</summary>
			[DataMember]
			public Nullable<System.Int32> StoreId { get; set; }
			/// <summary>Gets or sets the TerritoryId field. Derived from Entity Model Field 'Customer.TerritoryId (FK)'</summary>
			[DataMember]
			public Nullable<System.Int32> TerritoryId { get; set; }
		}

		/// <summary> DTO class which is derived from the entity 'SalesOrderDetail (SalesOrderDetails)'.</summary>
		[Serializable]
		[DataContract]
		public partial class SalesOrderDetailDto
		{
			/// <summary>Gets or sets the CarrierTrackingNumber field. Derived from Entity Model Field 'SalesOrderDetail.CarrierTrackingNumber'</summary>
			[DataMember]
			public System.String CarrierTrackingNumber { get; set; }
			/// <summary>Gets or sets the LineTotal field. Derived from Entity Model Field 'SalesOrderDetail.LineTotal'</summary>
			[DataMember]
			public System.Decimal LineTotal { get; set; }
			/// <summary>Gets or sets the ModifiedDate field. Derived from Entity Model Field 'SalesOrderDetail.ModifiedDate'</summary>
			[DataMember]
			public System.DateTime ModifiedDate { get; set; }
			/// <summary>Gets or sets the OrderQty field. Derived from Entity Model Field 'SalesOrderDetail.OrderQty'</summary>
			[DataMember]
			public System.Int16 OrderQty { get; set; }
			/// <summary>Gets or sets the ProductId field. Derived from Entity Model Field 'SalesOrderDetail.ProductId (FK)'</summary>
			[DataMember]
			public System.Int32 ProductId { get; set; }
			/// <summary>Gets or sets the Rowguid field. Derived from Entity Model Field 'SalesOrderDetail.Rowguid'</summary>
			[DataMember]
			public System.Guid Rowguid { get; set; }
			/// <summary>Gets or sets the SalesOrderDetailId field. Derived from Entity Model Field 'SalesOrderDetail.SalesOrderDetailId'</summary>
			[DataMember]
			public System.Int32 SalesOrderDetailId { get; set; }
			/// <summary>Gets or sets the SalesOrderId field. Derived from Entity Model Field 'SalesOrderDetail.SalesOrderId (FK)'</summary>
			[DataMember]
			public System.Int32 SalesOrderId { get; set; }
			/// <summary>Gets or sets the SpecialOfferId field. Derived from Entity Model Field 'SalesOrderDetail.SpecialOfferId (FK)'</summary>
			[DataMember]
			public System.Int32 SpecialOfferId { get; set; }
			/// <summary>Gets or sets the UnitPrice field. Derived from Entity Model Field 'SalesOrderDetail.UnitPrice'</summary>
			[DataMember]
			public System.Decimal UnitPrice { get; set; }
			/// <summary>Gets or sets the UnitPriceDiscount field. Derived from Entity Model Field 'SalesOrderDetail.UnitPriceDiscount'</summary>
			[DataMember]
			public System.Decimal UnitPriceDiscount { get; set; }
		}
	}

}




