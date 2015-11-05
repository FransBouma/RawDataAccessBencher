#if !(DNXCORE50 || DNX451)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for PetaPocoBencher , doing no-change tracking fetch
	/// </summary>
	public class PetaPocoBencher : BencherBase<SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
		/// </summary>
		public PetaPocoBencher()
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
			
			var dbFactory = new PetaPoco.Database(ConnectionStringToUse, "System.Data.SqlClient");
			dbFactory.OpenSharedConnection();
			toReturn = dbFactory.First<SalesOrderHeader>(CommandText + " where SalesOrderId=@0", key);
			dbFactory.CloseSharedConnection();
			return toReturn;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeader> FetchSet()
		{
			var headers = new List<SalesOrderHeader>();
			var dbFactory = new PetaPoco.Database(ConnectionStringToUse, "System.Data.SqlClient");
			dbFactory.OpenSharedConnection();
			headers = dbFactory.Fetch<SalesOrderHeader>(CommandText);
			dbFactory.CloseSharedConnection();
			return headers;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return "PetaPoco v" + Program.GetVersion(typeof(PetaPoco.Database));
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
#endif