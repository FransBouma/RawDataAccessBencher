using System.Collections.Generic;
using System.Linq;
using ServiceStack.Data;
using ServiceStack.OrmLite;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for OrmLite, doing no-change tracking fetch
	/// </summary>
	public class OrmLiteBencher : BencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OrmLiteBencher"/> class.
		/// </summary>
		public OrmLiteBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
		{ }

		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeader FetchIndividual(int key)
		{
			SalesOrderHeader toReturn = null;
			using(var con = dbFactory.OpenDbConnection())
			{
				toReturn = con.SqlList<SalesOrderHeader>(this.CommandText + " WHERE SalesOrderId=@p", new { p = key }).FirstOrDefault();
				con.Close();
			}
			return toReturn;
		}

		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeader> FetchSet()
		{
			List<SalesOrderHeader> headers;
			using(var con = dbFactory.OpenDbConnection())
			{
				headers = con.SqlList<SalesOrderHeader>(this.CommandText);
				con.Close();
			}
			return headers;
		}

		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("ServiceStack OrmLite v{0} (v{1})", typeof(OrmLiteConnectionFactory));
		}

		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		IDbConnectionFactory dbFactory;
		public string ConnectionStringToUse
		{
			set { dbFactory = new OrmLiteConnectionFactory(value, SqlServerDialect.Provider); }
		}

		public string CommandText { get; set; }
		#endregion
	}
}
