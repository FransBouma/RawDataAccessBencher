﻿using System;

namespace RawBencher
{
    /// <summary>Class which represents the entity 'Sales.SalesOrderHeaderChangeTracking' with internal change tracking</summary>
    public class SalesOrderHeaderChangeTracking : Tortuga.Anchor.Modeling.ChangeTrackingModelBase
    {
        /// <summary>Returns a hash code for this instance.</summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
        public override int GetHashCode()
        {
            int toReturn = base.GetHashCode();
            toReturn ^= this.SalesOrderId.GetHashCode();
            return toReturn;
        }

        /// <summary>Determines whether the specified object is equal to this instance.</summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
			SalesOrderHeaderChangeTracking toCompareWith = obj as SalesOrderHeaderChangeTracking;
            return toCompareWith == null ? false : ((this.SalesOrderId == toCompareWith.SalesOrderId));
        }


        #region Class Property Declarations
        /// <summary>Gets or sets the AccountNumber field. </summary>	
        public System.String AccountNumber { get => Get<string>(); set => Set(value); }

        /// <summary>Gets or sets the Comment field. </summary>	
        public System.String Comment { get => Get<string>(); set => Set(value); }

        /// <summary>Gets or sets the CreditCardApprovalCode field. </summary>	
        public System.String CreditCardApprovalCode { get => Get<string>(); set => Set(value); }

        /// <summary>Gets or sets the DueDate field. </summary>	
        public System.DateTime DueDate { get => Get<DateTime>(); set => Set(value); }

        /// <summary>Gets or sets the Freight field. </summary>	
        public System.Decimal Freight { get => Get<Decimal>(); set => Set(value); }

        /// <summary>Gets or sets the ModifiedDate field. </summary>	
        public System.DateTime ModifiedDate { get => Get<DateTime>(); set => Set(value); }

        /// <summary>Gets or sets the OnlineOrderFlag field. </summary>	
        public System.Boolean OnlineOrderFlag { get => Get<Boolean>(); set => Set(value); }

        /// <summary>Gets or sets the OrderDate field. </summary>	
        public System.DateTime OrderDate { get => Get<DateTime>(); set => Set(value); }

        /// <summary>Gets or sets the PurchaseOrderNumber field. </summary>	
        public System.String PurchaseOrderNumber { get => Get<string>(); set => Set(value); }

        /// <summary>Gets or sets the RevisionNumber field. </summary>	
        public System.Byte RevisionNumber { get => Get<Byte>(); set => Set(value); }

        /// <summary>Gets or sets the Rowguid field. </summary>	
        public System.Guid Rowguid { get => Get<Guid>(); set => Set(value); }

        /// <summary>Gets the SalesOrderId field. </summary>	
        public System.Int32 SalesOrderId { get => Get<Int32>(); set => Set(value); }

        /// <summary>Gets the SalesOrderNumber field. </summary>	
        public System.String SalesOrderNumber { get => Get<string>(); set => Set(value); }

        /// <summary>Gets or sets the ShipDate field. </summary>	
        public Nullable<System.DateTime> ShipDate { get => Get<DateTime>(); set => Set(value); }

        /// <summary>Gets or sets the Status field. </summary>	
        public System.Byte Status { get => Get<Byte>(); set => Set(value); }

        /// <summary>Gets or sets the SubTotal field. </summary>	
        public System.Decimal SubTotal { get => Get<Decimal>(); set => Set(value); }

        /// <summary>Gets or sets the TaxAmt field. </summary>	
        public System.Decimal TaxAmt { get => Get<Decimal>(); set => Set(value); }

        /// <summary>Gets the TotalDue field. </summary>	
        public System.Decimal TotalDue { get => Get<Decimal>(); set => Set(value); }

        public int CustomerID { get => Get<int>(); set => Set(value); }
        public int? SalesPersonID { get => Get<int?>(); set => Set(value); }
        public int? TerritoryID { get => Get<int?>(); set => Set(value); }
        public int BillToAddressID { get => Get<int>(); set => Set(value); }
        public int ShipToAddressID { get => Get<int>(); set => Set(value); }
        public int ShipMethodID { get => Get<int>(); set => Set(value); }
        public int? CreditCardID { get => Get<int?>(); set => Set(value); }
        public int? CurrencyRateID { get => Get<int?>(); set => Set(value); }

        #endregion
    }
}
