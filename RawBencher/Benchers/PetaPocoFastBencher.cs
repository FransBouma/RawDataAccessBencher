using System.Collections.Generic;
using Microsoft.Data.SqlClient;


namespace RawBencher.Benchers
{
    /// <summary>
    /// Specific bencher for PetaPocoBencher , doing no-change tracking fetch
    /// </summary>
    public class PetaPocoFastBencher : FetchOnlyBencherBase<SalesOrderHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PetaPocoBencher" /> class.
        /// </summary>
        public PetaPocoFastBencher()
            : base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
        {
        }

        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (var conn = new SqlConnection(ConnectionStringToUse))
            {
                conn.Open();
                var dbFactory = new PetaPoco.Database(conn) {EnableAutoSelect = false, EnableNamedParams = false};
                //dbFactory.ForceDateTimesToUtc = false;
                var toReturn = dbFactory.First<SalesOrderHeader>(CommandText + " where SalesOrderId=@0 ", key);
                return toReturn;
            }
        }


        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (var conn = new SqlConnection(ConnectionStringToUse))
            {
                conn.Open();
                var dbFactory = new PetaPoco.Database(conn) {EnableAutoSelect = false, EnableNamedParams = false};
                var headers = dbFactory.Fetch<SalesOrderHeader>(CommandText);
                return headers;
            }
        }


        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return CreateFrameworkName("PetaPoco Fast v{0} (v{1})", typeof(PetaPoco.Database));        }



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
