﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ScrapReason'.</summary>
	public partial class ScrapReason : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ScrapReason"/> class.</summary>
		public ScrapReason() : base()
		{
			this.WorkOrders = new List<WorkOrder>();
			this.Name = string.Empty;
			OnCreated();
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the Name field. </summary>
		public System.String Name { get; set; }
		/// <summary>Gets or sets the ScrapReasonId field. </summary>
		public System.Int16 ScrapReasonId { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'WorkOrder.ScrapReason - ScrapReason.WorkOrders (m:1)'</summary>
		public virtual List<WorkOrder> WorkOrders { get; set; }
	}
}
