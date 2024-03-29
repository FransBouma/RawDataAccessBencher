﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.9.</auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System;
using System.Collections.Generic;

namespace EFCore.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'ProductCostHistory'.</summary>
	public partial class ProductCostHistory : CommonEntityBase
	{
		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Initializes a new instance of the <see cref="ProductCostHistory"/> class.</summary>
		public ProductCostHistory() : base()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the EndDate field. </summary>
		public Nullable<System.DateTime> EndDate { get; set; }
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the ProductId field. </summary>
		public System.Int32 ProductId { get; set; }
		/// <summary>Gets or sets the StandardCost field. </summary>
		public System.Decimal StandardCost { get; set; }
		/// <summary>Gets or sets the StartDate field. </summary>
		public System.DateTime StartDate { get; set; }
		/// <summary>Represents the navigator which is mapped onto the association 'ProductCostHistory.Product - Product.ProductCostHistories (m:1)'</summary>
		public virtual Product Product { get; set; } = null!;
	}
}
