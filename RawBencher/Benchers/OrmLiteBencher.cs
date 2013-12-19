using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for OrmLite , doing no-change tracking fetch
	/// </summary>
	public class OrmLiteBencher : BencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="OrmLiteBencher"/> class.
		/// </summary>
		public OrmLiteBencher()
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
			SalesOrderHeader toReturn = null;
			var dbFactory = new OrmLiteConnectionFactory(ConnectionStringToUse, SqlServerOrmLiteDialectProvider.Instance);
			using(var con = dbFactory.OpenDbConnection())
			{
				toReturn = con.Single<SalesOrderHeader>("SalesOrderId=@p", new {p=key});
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
			var headers = new List<SalesOrderHeader>();
			var dbFactory = new OrmLiteConnectionFactory(ConnectionStringToUse, SqlServerOrmLiteDialectProvider.Instance);
			using(var con = dbFactory.OpenDbConnection())
			{
				headers = con.Select<SalesOrderHeader>();
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
		public string ConnectionStringToUse { get; set; }
		#endregion
	}
}
