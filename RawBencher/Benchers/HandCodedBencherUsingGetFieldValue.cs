using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for the DbDataReader using hand-coded materializer, doing no-change tracking fetch. This particular variant
	/// tries to avoid IsDbNull by using GetFieldValue(Of T) to obtain a nullable value type and check that. 
	/// </summary>
	public class HandCodedBencherUsingGetFieldValue : FetchOnlyBencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HandCodedBencherUsingGetFieldValue"/> class.
		/// </summary>
		public HandCodedBencherUsingGetFieldValue()
			: base(e => e.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeader FetchIndividual(int key)
		{
			var toExecute = new SqlCommand(this.CommandText + " WHERE SalesOrderId=@p");
			toExecute.Parameters.Add(new SqlParameter("@p", key));

			var results = MaterializeSet(toExecute);
			return results.FirstOrDefault();
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeader> FetchSet()
		{
			return MaterializeSet(new SqlCommand(this.CommandText));
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return "Handcoded materializer using DbDataReader and GetFieldValue<T>";
		}



		/// <summary>
		/// Materializes the set which is returned by the query specified
		/// </summary>
		/// <param name="toExecute">To execute.</param>
		/// <returns>
		/// set of elements materialized from the set returned by the query specified
		/// </returns>
		private IEnumerable<SalesOrderHeader> MaterializeSet(SqlCommand toExecute)
		{
			var headers = new List<SalesOrderHeader>();
			using(var con = new SqlConnection(this.ConnectionStringToUse))
			{
				toExecute.Connection = con;
				con.Open();
				var reader = toExecute.ExecuteReader();
				while(reader.Read())
				{
					var soh = new SalesOrderHeader();
					// using IsDBNull(ordinal) is slow, however it allows the usage of the typed Get<type>(ordinal) methods. This avoids
					// boxing / unboxing of the value again, which enhances performance more than IsDBNull can slow it down.
					// This is the bare minimum amount of work to do with materializing this resultset: it incorporates knowledge which columns
					// could be null.
					soh.SalesOrderId = reader.GetFieldValue<int>(0);
					soh.RevisionNumber = reader.GetFieldValue<byte>(1);
					soh.OrderDate = reader.GetFieldValue<DateTime>(2);
					soh.DueDate = reader.GetFieldValue<DateTime>(3);
					if(!reader.IsDBNull(4))
					{
						soh.ShipDate = reader.GetFieldValue<DateTime?>(4);
					}
					soh.Status = reader.GetFieldValue<byte>(5);
					soh.OnlineOrderFlag = reader.GetFieldValue<bool>(6);
					soh.SalesOrderNumber = reader.GetFieldValue<string>(7);
					if(!reader.IsDBNull(8))
					{
						soh.PurchaseOrderNumber = reader.GetFieldValue<string>(8);
					}
					if(!reader.IsDBNull(9))
					{
						soh.AccountNumber = reader.GetFieldValue<string>(9);
					}
					soh.CustomerID = reader.GetFieldValue<int>(10);
					if(!reader.IsDBNull(11))
					{
						soh.SalesPersonID = reader.GetFieldValue<int?>(11);
					}
					if(!reader.IsDBNull(12))
					{
						soh.TerritoryID = reader.GetFieldValue<int?>(12);
					}
					soh.BillToAddressID = reader.GetFieldValue<int>(13);
					soh.ShipToAddressID = reader.GetFieldValue<int>(14);
					soh.ShipMethodID = reader.GetFieldValue<int>(15);
					if(!reader.IsDBNull(16))
					{
						soh.CreditCardID = reader.GetFieldValue<int?>(16);
					}
					if(!reader.IsDBNull(17))
					{
						soh.CreditCardApprovalCode = reader.GetFieldValue<string>(17);
					}

					if(!reader.IsDBNull(18))
					{
						soh.CurrencyRateID = reader.GetFieldValue<int?>(18);
					}
					soh.SubTotal = reader.GetFieldValue<decimal>(19);
					soh.TaxAmt = reader.GetFieldValue<decimal>(20);
					soh.Freight = reader.GetFieldValue<decimal>(21);
					soh.TotalDue = reader.GetFieldValue<decimal>(22);
					if(!reader.IsDBNull(23))
					{
						soh.Comment = reader.GetFieldValue<string>(23);
					}
					soh.Rowguid = reader.GetFieldValue<Guid>(24);
					soh.ModifiedDate = reader.GetFieldValue<DateTime>(25);
					headers.Add(soh);
				}
				reader.Close();
				reader.Dispose();
				con.Close();
			}
			return headers;
		}



		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		/// <summary>
		/// Gets or sets the command text.
		/// </summary>
		public string CommandText { get; set; }
		#endregion
	}
}
