using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for the DbDataReader using hand-coded materializer, doing no-change tracking fetch
	/// </summary>
	public class HandCodedBencher : FetchOnlyBencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HandCodedBencher"/> class.
		/// </summary>
		public HandCodedBencher()
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
			return "Handcoded materializer using DbDataReader";
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
					soh.ModifiedDate = reader.GetDateTime(25);
					soh.SalesOrderId = reader.GetInt32(0);
					soh.RevisionNumber = reader.GetByte(1);
					soh.OrderDate = reader.GetDateTime(2);
					soh.DueDate = reader.GetDateTime(3);
					if(!reader.IsDBNull(4))
					{
						soh.ShipDate = reader.GetDateTime(4);
					}
					soh.Status = reader.GetByte(5);
					soh.OnlineOrderFlag = reader.GetBoolean(6);
					soh.SalesOrderNumber = reader.GetString(7);
					if(!reader.IsDBNull(8))
					{
						soh.PurchaseOrderNumber =  reader.GetString(8);
					}
					if(!reader.IsDBNull(9))
					{
						soh.AccountNumber = reader.GetString(9);
					}
					soh.CustomerID = reader.GetInt32(10);
					if(!reader.IsDBNull(11))
					{
						soh.SalesPersonID = reader.GetInt32(11);
					}
					if(!reader.IsDBNull(12))
					{
						soh.TerritoryID = reader.GetInt32(12);
					}
					soh.BillToAddressID = reader.GetInt32(13);
					soh.ShipToAddressID = reader.GetInt32(14);
					soh.ShipMethodID = reader.GetInt32(15);
					if(!reader.IsDBNull(16))
					{
						soh.CreditCardID = reader.GetInt32(16);
					}
					if(!reader.IsDBNull(17))
					{
						soh.CreditCardApprovalCode = reader.GetString(17);
					}
					if(!reader.IsDBNull(18))
					{
						soh.CurrencyRateID = reader.GetInt32(18);
					}
					soh.SubTotal = reader.GetDecimal(19);
					soh.TaxAmt = reader.GetDecimal(20);
					soh.Freight = reader.GetDecimal(21);
					soh.TotalDue = reader.GetDecimal(22);
					if(!reader.IsDBNull(23))
					{
						soh.Comment = reader.GetString(23);
					}
					soh.Rowguid = reader.GetGuid(24);
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
