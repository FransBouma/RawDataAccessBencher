﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'SalesOrderHeaderSalesReason'.</summary>
	public partial class SalesOrderHeaderSalesReason : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="SalesOrderHeaderSalesReason"/> class.</summary>
		public SalesOrderHeaderSalesReason() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the SalesOrderId field. </summary>
		public System.Int32 SalesOrderId { get; set; }
		/// <summary>Gets or sets the SalesReasonId field. </summary>
		public System.Int32 SalesReasonId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeaderSalesReason.SalesOrderHeader - SalesOrderHeader.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual SalesOrderHeader SalesOrderHeader { get; set; } = null!;
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeaderSalesReason.SalesReason - SalesReason.SalesOrderHeaderSalesReasons (m:1)'</summary>
		public virtual SalesReason SalesReason { get; set; } = null!;
	}
}
