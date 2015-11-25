using LinqToDB;
using LinqToDB.DataProvider;
using LinqToDB.DataProvider.SqlServer;

namespace LINQ2DB.Bencher
{
    public class Db : LinqToDB.Data.DataConnection
    {
        public Db(string connetionString) : base(GetDataProvider(), connetionString)
        {

        }

        private static IDataProvider GetDataProvider()
        {
            return new SqlServerDataProvider("", SqlServerVersion.v2008);
        }

        internal ITable<SalesOrderHeader> SalesOrderHeader { get { return GetTable<SalesOrderHeader>(); } }
    }
}
