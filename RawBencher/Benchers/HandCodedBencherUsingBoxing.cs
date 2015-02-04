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
	/// Specific bencher for the DbDataReader using hand-coded materializer, doing no-change tracking fetch. It uses boxing to show the performance
	/// loss for when using GetValue(ordinal) vs. the typed methods on the datareader.
	/// </summary>
	public class HandCodedBencherUsingBoxing : BencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HandCodedBencherUsingBoxing"/> class.
		/// </summary>
		public HandCodedBencherUsingBoxing()
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
			return "Handcoded materializer using DbDataReader with GetValues(array) (boxing)";
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
				object[] values = new object[26];
				while(reader.Read())
				{
					var soh = new SalesOrderHeader();
					reader.GetValues(values);
					soh.SalesOrderId = (int)values[0];
					soh.RevisionNumber = (byte)values[1];
					soh.OrderDate = (DateTime)values[2];
					soh.DueDate = (DateTime)values[3];
					if(values[4]!=DBNull.Value)
					{
						soh.ShipDate = (DateTime?)values[4];
					}
					soh.Status = (byte)values[5];
					soh.OnlineOrderFlag = (bool)values[6];
					soh.SalesOrderNumber = (string)values[7];
					if(values[8] != DBNull.Value)
					{
						soh.PurchaseOrderNumber = (string)values[8];
					}
					if(values[9] != DBNull.Value)
					{
						soh.AccountNumber = (string)values[9];
					}
					soh.CustomerID = (int)values[10];
					if(values[11] != DBNull.Value)
					{
						soh.SalesPersonID = (int?)values[11];
					}
					if(values[12] != DBNull.Value)
					{
						soh.TerritoryID = (int?)values[12];
					}
					soh.BillToAddressID = (int)values[13];
					soh.ShipToAddressID = (int)values[14];
					soh.ShipMethodID = (int)values[15];
					if(values[16] != DBNull.Value)
					{
						soh.CreditCardID = (int?)values[16];
					}
					if(values[17] != DBNull.Value)
					{
						soh.CreditCardApprovalCode = (string)values[17];
					}
					if(values[18] != DBNull.Value)
					{
						soh.CurrencyRateID = (int?)values[18];
					}
					soh.SubTotal = (decimal)values[19];
					soh.TaxAmt = (decimal)values[20];
					soh.Freight = (decimal)values[21];
					soh.TotalDue = (decimal)values[22];
					if(values[23] != DBNull.Value)
					{
						soh.Comment = (string)values[23];
					}
					soh.Rowguid = (Guid)values[24];
					soh.ModifiedDate = (DateTime)values[25];
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
