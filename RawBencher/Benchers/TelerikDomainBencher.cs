using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	public class TelerikDomainBencher : BencherBase<Telerik.Bencher.Model.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
		/// </summary>
		public TelerikDomainBencher()
			: base(e => e.SalesOrderID, usesChangeTracking: true, usesCaching: false)
		{
		}

		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override Telerik.Bencher.Model.SalesOrderHeader FetchIndividual(int key)
		{
			Telerik.Bencher.Model.SalesOrderHeader toReturn = null;
			try
			{
				using (var dbFactory = new Telerik.Bencher.Model.DomainModel(ConnectionStringToUse))
				{
					toReturn = dbFactory.SalesOrderHeaders.First<Telerik.Bencher.Model.SalesOrderHeader>(p => p.SalesOrderID == key);
				}
			}
			catch (TypeInitializationException ex)
			{
				throw new Exception("Error initializing context. See README.txt in Telerik.Bencher.Model project", ex);
			}
			return toReturn;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<Telerik.Bencher.Model.SalesOrderHeader> FetchSet()
		{
			List<Telerik.Bencher.Model.SalesOrderHeader> headers;
			try
			{
				using (var dbFactory = new Telerik.Bencher.Model.DomainModel(ConnectionStringToUse))
				{
					dbFactory.ContextOptions.IsolationLevel = System.Data.IsolationLevel.ReadCommitted;
					headers = dbFactory.SalesOrderHeaders.ToList<Telerik.Bencher.Model.SalesOrderHeader>();
				}
			}
			catch (TypeInitializationException ex)
			{
				throw new Exception("Error initializing context. See README.txt in Telerik.Bencher.Model project", ex);
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
			return "Telerik DataAccess/OpenAccess Domain v4.0.3";
		}

		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion
	}
}
