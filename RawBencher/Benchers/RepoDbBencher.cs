using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using RepoDb;

namespace RawBencher.Benchers
{
    /// <summary>
    /// Specific bencher for RepoDbBencher, doing no-change tracking fetch
    /// </summary>
    public class RepoDbBencher : BencherBase<SalesOrderHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoDbBencher"/> class.
        /// </summary>
        public RepoDbBencher()
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
            using (var connection = new SqlConnection(ConnectionStringToUse))
            {
                return connection.ExecuteQuery<SalesOrderHeader>(CommandText + " WHERE SalesOrderId = @SalesOrderId;", new { SalesOrderId = key }).FirstOrDefault();
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
                return connection.ExecuteQuery<SalesOrderHeader>(CommandText);
            }
        }

        //public override IEnumerable<RepoDb.Bencher.Model.SalesOrderHeader> FetchGraph()
        //{
        //    var repository = new DbRepository<SqlConnection>(this.ConnectionStringToUse);
        //    return repository.Query<RepoDb.Bencher.Model.SalesOrderHeader>(recursive: true, recursionDepth: 3);
        //}

        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return "RepoDb v" + BencherUtils.GetVersion(typeof(TypeMapper));
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
