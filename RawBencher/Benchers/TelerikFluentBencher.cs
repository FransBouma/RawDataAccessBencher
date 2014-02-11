using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	public class TelerikFluentBencher : BencherBase<Telerik.Bencher.Model.Fluent.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
		/// </summary>
		public TelerikFluentBencher()
			: base(e => e.SalesOrderID, usesChangeTracking: true, usesCaching: false)
		{
		}

		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override Telerik.Bencher.Model.Fluent.SalesOrderHeader FetchIndividual(int key)
		{
			Telerik.Bencher.Model.Fluent.SalesOrderHeader toReturn = null;
			using (var dbFactory = new Telerik.Bencher.Model.Fluent.FluentModel(ConnectionStringToUse))
			{
				toReturn = dbFactory.SalesOrderHeaders.First<Telerik.Bencher.Model.Fluent.SalesOrderHeader>(p => p.SalesOrderID == key);
			}
			return toReturn;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<Telerik.Bencher.Model.Fluent.SalesOrderHeader> FetchSet()
		{
			List<Telerik.Bencher.Model.Fluent.SalesOrderHeader> headers;
			using (var dbFactory = new Telerik.Bencher.Model.Fluent.FluentModel(ConnectionStringToUse))
			{
				headers = dbFactory.SalesOrderHeaders.ToList<Telerik.Bencher.Model.Fluent.SalesOrderHeader>();
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
			return "Telerik DataAccess Fluent v4.0.3";
		}

		#region Properties
		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }
		#endregion
	}
}
