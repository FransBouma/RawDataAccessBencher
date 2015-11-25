///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace AdventureWorks.Dal.Adapter.v50.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'SohQuerySpecPoco'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the method <see cref="AdventureWorks.Dal.Adapter.v50.FactoryClasses.QueryFactory.GetSohQuerySpecPocoTypedView"/>.
	/// Custom Properties: <br/>
	/// </remarks>
	[Serializable]
	public partial class SohQuerySpecPocoRow 
	{
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SohQuerySpecPocoRow"/> class.</summary>
		public SohQuerySpecPocoRow()
		{
			OnCreated();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field.</summary>
		public System.String AccountNumber { get; set; }
		/// <summary>Gets or sets the BillToAddressId field.</summary>
		public System.Int32 BillToAddressId { get; set; }
		/// <summary>Gets or sets the Comment field.</summary>
		public System.String Comment { get; set; }
		/// <summary>Gets or sets the CreditCardApprovalCode field.</summary>
		public System.String CreditCardApprovalCode { get; set; }
		/// <summary>Gets or sets the CreditCardId field.</summary>
		public Nullable<System.Int32> CreditCardId { get; set; }
		/// <summary>Gets or sets the CurrencyRateId field.</summary>
		public Nullable<System.Int32> CurrencyRateId { get; set; }
		/// <summary>Gets or sets the CustomerId field.</summary>
		public System.Int32 CustomerId { get; set; }
		/// <summary>Gets or sets the DueDate field.</summary>
		public System.DateTime DueDate { get; set; }
		/// <summary>Gets or sets the Freight field.</summary>
		public System.Decimal Freight { get; set; }
		/// <summary>Gets or sets the ModifiedDate field.</summary>
		public System.DateTime ModifiedDate { get; set; }
		/// <summary>Gets or sets the OnlineOrderFlag field.</summary>
		public System.Boolean OnlineOrderFlag { get; set; }
		/// <summary>Gets or sets the OrderDate field.</summary>
		public System.DateTime OrderDate { get; set; }
		/// <summary>Gets or sets the PurchaseOrderNumber field.</summary>
		public System.String PurchaseOrderNumber { get; set; }
		/// <summary>Gets or sets the RevisionNumber field.</summary>
		public System.Byte RevisionNumber { get; set; }
		/// <summary>Gets or sets the Rowguid field.</summary>
		public System.Guid Rowguid { get; set; }
		/// <summary>Gets or sets the SalesOrderId field.</summary>
		public System.Int32 SalesOrderId { get; set; }
		/// <summary>Gets or sets the SalesOrderNumber field.</summary>
		public System.String SalesOrderNumber { get; set; }
		/// <summary>Gets or sets the SalesPersonId field.</summary>
		public Nullable<System.Int32> SalesPersonId { get; set; }
		/// <summary>Gets or sets the ShipDate field.</summary>
		public Nullable<System.DateTime> ShipDate { get; set; }
		/// <summary>Gets or sets the ShipMethodId field.</summary>
		public System.Int32 ShipMethodId { get; set; }
		/// <summary>Gets or sets the ShipToAddressId field.</summary>
		public System.Int32 ShipToAddressId { get; set; }
		/// <summary>Gets or sets the Status field.</summary>
		public System.Byte Status { get; set; }
		/// <summary>Gets or sets the SubTotal field.</summary>
		public System.Decimal SubTotal { get; set; }
		/// <summary>Gets or sets the TaxAmt field.</summary>
		public System.Decimal TaxAmt { get; set; }
		/// <summary>Gets or sets the TerritoryId field.</summary>
		public Nullable<System.Int32> TerritoryId { get; set; }
		/// <summary>Gets or sets the TotalDue field.</summary>
		public System.Decimal TotalDue { get; set; }
		#endregion
	}
}

