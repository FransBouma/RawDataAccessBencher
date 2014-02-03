using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
    public class TelerikBencher : BencherBase<TDA.Bencher.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
		/// </summary>
        public TelerikBencher()
			: base(e => e.SalesOrderID, usesChangeTracking:true, usesCaching:false)
		{
		}
		
		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override TDA.Bencher.SalesOrderHeader FetchIndividual(int key)
		{
            TDA.Bencher.SalesOrderHeader toReturn = null;
			var dbFactory = new TDA.Bencher.FluentModel("AdventureWorksConnection");
            toReturn = dbFactory.SalesOrderHeaders.First<TDA.Bencher.SalesOrderHeader>(p => p.SalesOrderID == key);
			return toReturn;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
        public override IEnumerable<TDA.Bencher.SalesOrderHeader> FetchSet()
		{
            List<TDA.Bencher.SalesOrderHeader> headers;
            using (var dbFactory = new TDA.Bencher.FluentModel("AdventureWorksConnection"))
            {
                headers = dbFactory.SalesOrderHeaders.ToList<TDA.Bencher.SalesOrderHeader>();
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
			return "Telerik DataAccess v4.0.3";
		}
	}
}
