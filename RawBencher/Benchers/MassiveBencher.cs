using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanillaMassive;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for Massive. It uses the VanillaMassive namespace as Oak also uses massive and exposes the same extension method.
	/// </summary>
	public class MassiveBencher : BencherBase<dynamic>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MassiveBencher"/> class.
		/// </summary>
		public MassiveBencher()
			: base(e => e.SalesOrderID, usesChangeTracking:false, usesCaching:false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override dynamic FetchIndividual(int key)
		{
			return new MassiveSalesOrderHeaders().Single(key);
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<dynamic> FetchSet()
		{
			var toReturn = new MassiveSalesOrderHeaders().All().ToList();
			return toReturn;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return "Massive using dynamic class";
		}
		
		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion
	}


	public class MassiveSalesOrderHeaders : DynamicModel
	{
		public MassiveSalesOrderHeaders():base("AdventureWorks.ConnectionString.SQL Server (SqlClient)", "Sales.SalesOrderHeader", "SalesOrderID")
		{
		}
	}
}
