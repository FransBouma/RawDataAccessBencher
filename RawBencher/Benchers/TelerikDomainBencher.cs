using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
    public class TelerikDomainBencher : BencherBase<TDA.Bencher.Domain.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
		/// </summary>
        public TelerikDomainBencher()
			: base(e => e.SalesOrderID, usesChangeTracking:true, usesCaching:false)
		{
		}
		
		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override TDA.Bencher.Domain.SalesOrderHeader FetchIndividual(int key)
		{
            TDA.Bencher.Domain.SalesOrderHeader toReturn = null;
            using (var dbFactory = new TDA.Bencher.Domain.DomainModel(ConnectionStringToUse))
            {
                toReturn = dbFactory.SalesOrderHeaders.First<TDA.Bencher.Domain.SalesOrderHeader>(p => p.SalesOrderID == key);
            }
			return toReturn;
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
        public override IEnumerable<TDA.Bencher.Domain.SalesOrderHeader> FetchSet()
		{
            List<TDA.Bencher.Domain.SalesOrderHeader> headers;
            using (var dbFactory = new TDA.Bencher.Domain.DomainModel(ConnectionStringToUse))
            {
                dbFactory.ContextOptions.IsolationLevel = System.Data.IsolationLevel.ReadCommitted;
                headers = dbFactory.SalesOrderHeaders.ToList<TDA.Bencher.Domain.SalesOrderHeader>();
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
			return "Telerik DataAccess Domain v4.0.3";
		}

        #region Properties
        /// <summary>
        /// Gets or sets the connection string to use
        /// </summary>
        public string ConnectionStringToUse { get; set; }
        #endregion
	}
}
