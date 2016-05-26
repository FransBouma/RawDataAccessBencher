using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for the DbDataReader using object array bencher, it can't get much more raw than this, doing no-change tracking fetch
	/// </summary>
	public class RawDbDataReaderBencher : BencherBase<object[]>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="RawDbDataReaderBencher"/> class.
		/// </summary>
		public RawDbDataReaderBencher()
			: base(r => Convert.ToInt32(r[0]), usesChangeTracking:false, usesCaching:false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override object[] FetchIndividual(int key)
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
		public override IEnumerable<object[]> FetchSet()
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
			return "Raw DbDataReader materializer using object arrays";
		}



		/// <summary>
		/// Materializes the set which is returned by the query specified
		/// </summary>
		/// <param name="toExecute">To execute.</param>
		/// <returns>
		/// set of elements materialized from the set returned by the query specified
		/// </returns>
		private IEnumerable<object[]> MaterializeSet(SqlCommand toExecute)
		{
			var headers = new List<object[]>(31000);
			using(var con = new SqlConnection(this.ConnectionStringToUse))
			{
				toExecute.Connection = con;
				con.Open();
				con.StatisticsEnabled = false;
				var reader = toExecute.ExecuteReader();
				var fieldCount = reader.FieldCount;
				while(reader.Read())
				{
					var values = new object[fieldCount];
					reader.GetValues(values);
					headers.Add(values);
				}
				// optimization: call cancel first, this will greatly reduce the time it takes to Close the datareader as we're not interested in
				// any statistics gathered by Close anyway. Required for SqlServer, other providers don't have a slow Close() method.
				// Every ORM should utilize this trick to get fast individual fetches. Most do, not all of them though.
				toExecute.Cancel();
				reader.Close();
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
