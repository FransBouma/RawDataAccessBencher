using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPoco;

namespace RawBencher.Benchers
{
    public class NPocoBencher : FetchOnlyBencherBase<SalesOrderHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
        /// </summary>
        public NPocoBencher()
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
            var dbFactory = new Database(ConnectionStringToUse, "System.Data.SqlClient");
            dbFactory.OpenSharedConnection();
            dbFactory.EnableAutoSelect = false;
            toReturn = dbFactory.First<SalesOrderHeader>(CommandText + " where SalesOrderId=@0 ", key);
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
            var dbFactory = new Database(ConnectionStringToUse, "System.Data.SqlClient");
            dbFactory.OpenSharedConnection();
            dbFactory.EnableAutoSelect = false;
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
            return CreateFrameworkName("NPoco v{0} (v{1})", typeof(Database));
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
