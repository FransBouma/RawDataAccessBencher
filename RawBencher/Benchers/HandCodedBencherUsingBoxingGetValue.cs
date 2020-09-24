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
	public class HandCodedBencherUsingBoxingGetValue : FetchOnlyBencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="HandCodedBencherUsingBoxingGetValue"/> class.
		/// </summary>
		public HandCodedBencherUsingBoxingGetValue()
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
			return "Handcoded materializer using DbDataReader (GetValue(Ordinal), boxing)";
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
					soh.SalesOrderId = (int)reader.GetValue(0);
					soh.RevisionNumber = (byte)reader.GetValue(1);
					soh.OrderDate = (DateTime)reader.GetValue(2);
					soh.DueDate = (DateTime)reader.GetValue(3);
					object value = reader.GetValue(4);
					soh.ShipDate = value == DBNull.Value ? null : (DateTime?)value;
					soh.Status = (byte)reader.GetValue(5);
					soh.OnlineOrderFlag = (bool)reader.GetValue(6);
					soh.SalesOrderNumber = (string)reader.GetValue(7);
					value = reader.GetValue(8);
					soh.PurchaseOrderNumber = value == DBNull.Value ? null : (string)value;
					value = reader.GetValue(9);
					soh.AccountNumber = value == DBNull.Value ? null : (string)value;
					soh.CustomerID = (int)reader.GetValue(10);
					value = reader.GetValue(11);
					soh.SalesPersonID = value == DBNull.Value ? null : (int?)value;
					value = reader.GetValue(12);
					soh.TerritoryID = value == DBNull.Value ? null : (int?)value;
					soh.BillToAddressID = (int)reader.GetValue(13);
					soh.ShipToAddressID = (int)reader.GetValue(14);
					soh.ShipMethodID = (int)reader.GetValue(15);
					value = reader.GetValue(16);
					soh.CreditCardID = value == DBNull.Value ? null : (int?)value;
					value = reader.GetValue(17);
					soh.CreditCardApprovalCode = value == DBNull.Value ? null : (string)value;
					value = reader.GetValue(18);
					soh.CurrencyRateID = value == DBNull.Value ? null : (int?)value;
					soh.SubTotal = (decimal)reader.GetValue(19);
					soh.TaxAmt = (decimal)reader.GetValue(20);
					soh.Freight = (decimal)reader.GetValue(21);
					soh.TotalDue = (decimal)reader.GetValue(22);
					value = reader.GetValue(23);
					soh.Comment = value == DBNull.Value ? null : (string)value;
					soh.Rowguid = (Guid)reader.GetValue(24);
					soh.ModifiedDate = (DateTime)reader.GetValue(25);
					
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
