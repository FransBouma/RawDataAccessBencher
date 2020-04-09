using System.Collections.Generic;
using System.Linq;
using RepoDb;
using System.Data.SqlClient;

namespace RawBencher.Benchers
{
    /// <summary>
    /// Specific bencher for RepoDb (POCO), doing no-change tracking fetch
    /// </summary>
    public class RepoDbPocoBencher : FetchOnlyBencherBase<SalesOrderHeader>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RepoDbPocoBencher"/> class.
        /// </summary>
        public RepoDbPocoBencher()
            : base(e => e.SalesOrderId, usesChangeTracking: false, usesCaching: false)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the current bencher instance.
        /// </summary>
        public override void Initialize()
        {
            base.Initialize();
            SqlServerBootstrap.Initialize();
        }

        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (var connection = new SqlConnection(ConnectionStringToUse))
            {
                return connection.Query<SalesOrderHeader>(new { SalesOrderId = key }).First();
            }
        }

        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (var connection = new SqlConnection(ConnectionStringToUse))
            {
                return connection.QueryAll<SalesOrderHeader>();
            }
        }

        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return "RepoDb (Poco) v" + BencherUtils.GetVersion(typeof(TypeMapper));
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
