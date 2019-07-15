using LinqToDB;

namespace LINQ2DB.Bencher
{
    public class Db : LinqToDB.Data.DataConnection
    {
        public Db(string connetionString) : base(ProviderName.SqlServer2008, connetionString)
        {
        }

        public ITable<SalesOrderHeader> SalesOrderHeader  => GetTable<SalesOrderHeader>();

        public ITable<CreditCard>       CreditCards       => GetTable<CreditCard>();

        public ITable<SalesOrderHeader> SalesOrderHeaders => GetTable<SalesOrderHeader>();
    }
}
