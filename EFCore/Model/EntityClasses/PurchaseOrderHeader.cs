﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'PurchaseOrderHeader'.</summary>
	public partial class PurchaseOrderHeader : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="PurchaseOrderHeader"/> class.</summary>
		public PurchaseOrderHeader() : base()
		{
			this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
			OnCreated();
		}

		/// <summary>Gets or sets the EmployeeId field. </summary>
		public System.Int32 EmployeeId { get; set; }
		/// <summary>Gets or sets the Freight field. </summary>
		public System.Decimal Freight { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the OrderDate field. </summary>
		public System.DateTime OrderDate { get; set; }
		/// <summary>Gets or sets the PurchaseOrderId field. </summary>
		public System.Int32 PurchaseOrderId { get; set; }
		/// <summary>Gets or sets the RevisionNumber field. </summary>
		public System.Byte RevisionNumber { get; set; }
		/// <summary>Gets or sets the ShipDate field. </summary>
		public Nullable<System.DateTime> ShipDate { get; set; }
		/// <summary>Gets or sets the ShipMethodId field. </summary>
		public System.Int32 ShipMethodId { get; set; }
		/// <summary>Gets or sets the Status field. </summary>
		public System.Byte Status { get; set; }
		/// <summary>Gets or sets the SubTotal field. </summary>
		public System.Decimal SubTotal { get; set; }
		/// <summary>Gets or sets the TaxAmt field. </summary>
		public System.Decimal TaxAmt { get; set; }
		/// <summary>Gets or sets the TotalDue field. </summary>
		public System.Decimal TotalDue { get; set; }
		/// <summary>Gets or sets the VendorId field. </summary>
		public System.Int32 VendorId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Employee - Employee.PurchaseOrderHeaders (m:1)'</summary>
		public virtual Employee Employee { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderDetail.PurchaseOrderHeader - PurchaseOrderHeader.PurchaseOrderDetails (m:1)'</summary>
		public virtual List<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.ShipMethod - ShipMethod.PurchaseOrderHeaders (m:1)'</summary>
		public virtual ShipMethod ShipMethod { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'PurchaseOrderHeader.Vendor - Vendor.PurchaseOrderHeaders (m:1)'</summary>
		public virtual Vendor Vendor { get; set; } = null!;
	}
}
