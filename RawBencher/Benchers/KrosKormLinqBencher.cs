using Kros.Data.SqlServer;
using Kros.KORM;
using Kros.KORM.Metadata.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RawBencher.Benchers
{
    public class KrosKormLinqBencher : BencherBase<KrosKormLinqBencher.SalesOrderHeader>
    {
        #region Nested types

        /// <summary>Class which represents the entity 'SalesOrderHeader'.</summary>
        [Alias("Sales.SalesOrderHeader")]
        public class SalesOrderHeader
        {
            /// <summary>Gets or sets the AccountNumber field. </summary>
            public string AccountNumber { get; set; }
            /// <summary>Gets or sets the BillToAddressId field. </summary>
            public int BillToAddressId { get; set; }
            /// <summary>Gets or sets the Comment field. </summary>
            public string Comment { get; set; }
            /// <summary>Gets or sets the CreditCardApprovalCode field. </summary>
            public string CreditCardApprovalCode { get; set; }
            /// <summary>Gets or sets the CreditCardId field. </summary>
            public int? CreditCardId { get; set; }
            /// <summary>Gets or sets the CurrencyRateId field. </summary>
            public int? CurrencyRateId { get; set; }
            /// <summary>Gets or sets the CustomerId field. </summary>
            public int CustomerId { get; set; }
            /// <summary>Gets or sets the DueDate field. </summary>
            public DateTime DueDate { get; set; }
            /// <summary>Gets or sets the Freight field. </summary>
            public decimal Freight { get; set; }
            /// <summary>Gets or sets the ModifiedDate field. </summary>
            public DateTime ModifiedDate { get; set; }
            /// <summary>Gets or sets the OnlineOrderFlag field. </summary>
            public bool OnlineOrderFlag { get; set; }
            /// <summary>Gets or sets the OrderDate field. </summary>
            public DateTime OrderDate { get; set; }
            /// <summary>Gets or sets the PurchaseOrderNumber field. </summary>
            public string PurchaseOrderNumber { get; set; }
            /// <summary>Gets or sets the RevisionNumber field. </summary>
            public byte RevisionNumber { get; set; }
            /// <summary>Gets or sets the Rowguid field. </summary>
            public Guid Rowguid { get; set; }
            /// <summary>Gets or sets the SalesOrderId field. </summary>
            public int SalesOrderId { get; set; }
            /// <summary>Gets or sets the SalesOrderNumber field. </summary>
            public string SalesOrderNumber { get; set; }
            /// <summary>Gets or sets the SalesPersonId field. </summary>
            public int? SalesPersonId { get; set; }
            /// <summary>Gets or sets the ShipDate field. </summary>
            public DateTime? ShipDate { get; set; }
            /// <summary>Gets or sets the ShipMethodId field. </summary>
            public int ShipMethodId { get; set; }
            /// <summary>Gets or sets the ShipToAddressId field. </summary>
            public int ShipToAddressId { get; set; }
            /// <summary>Gets or sets the Status field. </summary>
            public byte Status { get; set; }
            /// <summary>Gets or sets the SubTotal field. </summary>
            public decimal SubTotal { get; set; }
            /// <summary>Gets or sets the TaxAmt field. </summary>
            public decimal TaxAmt { get; set; }
            /// <summary>Gets or sets the TerritoryId field. </summary>
            public int? TerritoryId { get; set; }
            /// <summary>Gets or sets the TotalDue field. </summary>
            public decimal TotalDue { get; set; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="KrosKormLinqBencher`1" /> class.
        /// </summary>
        public KrosKormLinqBencher()
            : base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false, supportsEagerLoading: false, supportsAsync: false)
        {
        }

        #endregion

        #region BencherBase overrides

        public string ConnectionStringToUse { get; set; }

        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (IDatabase db = new Database(ConnectionStringToUse, SqlServerDataHelper.ClientId))
            {
                return db.Query<SalesOrderHeader>().Single(e => e.SalesOrderId == key);
            }
        }

        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (IDatabase db = new Database(ConnectionStringToUse, SqlServerDataHelper.ClientId))
            {
                return db.Query<SalesOrderHeader>().ToList();
            }
        }

        protected override string CreateFrameworkNameImpl()
        {
            return CreateFrameworkName("Kros.KORM v{0} (v{1}) - LINQ", typeof(Database));
        }

        #endregion
    }
}
