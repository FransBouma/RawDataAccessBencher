using LinqToDB;

namespace LINQ2DB.Bencher
{
    public class Db : LinqToDB.Data.DataConnection
    {
        public Db(string connectionString) : base(ProviderName.SqlServer2008, connectionString)
        {
        }

        public ITable<SalesOrderHeader> SalesOrderHeader  => this.GetTable<SalesOrderHeader>();

        public ITable<CreditCard>       CreditCards       => this.GetTable<CreditCard>();

        public ITable<SalesOrderHeader> SalesOrderHeaders => this.GetTable<SalesOrderHeader>();
    }
}
