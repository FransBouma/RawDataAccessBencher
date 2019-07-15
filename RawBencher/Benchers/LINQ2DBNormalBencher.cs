using LINQ2DB.Bencher;
using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
    public class LINQ2DBNormalBencher : BencherBase<LINQ2DB.Bencher.SalesOrderHeader, CreditCard>
    {
        protected readonly string ConnectionString;

        public LINQ2DBNormalBencher(string connectionString)
            : base(
                  e => e.SalesOrderID,
                  l => l.CreditCardID,
                  usesChangeTracking: false,
                  usesCaching: false,
                  supportsEagerLoading: true,
                  supportsAsync: true,
                  supportsInserts: true)
        {
            // needed for EagerLoad tests
            // should be removed after https://github.com/linq2db/linq2db/pull/1756 release
            LinqToDB.Common.Configuration.Linq.AllowMultipleQuery = true;
            ConnectionString = connectionString;
        }

        public override LINQ2DB.Bencher.SalesOrderHeader FetchIndividual(int key)
        {
            using (var db = new Db(ConnectionString))
            {
                return db.SalesOrderHeader
                    .Where(p => p.SalesOrderID == key)
                    .FirstOrDefault();
            }
        }

        public override IEnumerable<LINQ2DB.Bencher.SalesOrderHeader> FetchSet()
        {
            using (var db = new Db(ConnectionString))
            {
                return db.SalesOrderHeader.ToList();
            }
        }

        protected override string CreateFrameworkNameImpl()
        {
            return CreateFrameworkName("LINQ to DB v{0} (v{1}) (normal)", typeof(DataConnection));
        }

        public override IEnumerable<LINQ2DB.Bencher.SalesOrderHeader> FetchGraph()
        {
            using (var db = new Db(ConnectionString))
            {
                return (from soh in db.SalesOrderHeaders
                               .LoadWith(x => x.SalesOrderDetails)
                               .LoadWith(x => x.Customer)
                        where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
                        select soh)
                             .ToList();
            }

        }
        public override async Task<IEnumerable<LINQ2DB.Bencher.SalesOrderHeader>> FetchGraphAsync()
        {
            using (var db = new Db(ConnectionString))
            {
                return await (from soh in db.SalesOrderHeaders
                                .LoadWith(x => x.SalesOrderDetails)
                                .LoadWith(x => x.Customer)
                              where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
                              select soh)
                    .ToListAsync();
            }
        }

        public override void VerifyGraphElementChildren(LINQ2DB.Bencher.SalesOrderHeader parent, BenchResult resultContainer)
        {
            int amount = 0;
            foreach (var sod in parent.SalesOrderDetails)
            {
                if (sod.SalesOrderID > 0)
                {
                    amount++;
                }
                else
                {
                    return;
                }
            }

            resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetail), amount);

            if ((parent.Customer == null) || (parent.Customer.CustomerID <= 0))
            {
                return;
            }

            resultContainer.IncNumberOfRowsForType(typeof(Customer), 1);
        }

        public override IEnumerable<CreditCard> CreateSetForInserts(int amountToInsert)
        {
            var toReturn = new CreditCard[amountToInsert];

            for (int i = 0; i < amountToInsert; i++)
            {
                toReturn[i] = new CreditCard()
                {
                    CardNumber = Guid.NewGuid().ToString("N").Substring(0, 24),
                    CardType = "Vista",
                    ExpMonth = 11,
                    ExpYear = 2018,
                    ModifiedDate = DateTime.Now
                };
            }

            return toReturn;
        }

        protected override IEnumerable<CreditCard> FetchInserted(int amountInserted)
        {
            using (var db = new Db(ConnectionString))
            {
                return db.CreditCards
                    .Where(_ => _.CreditCardID > 19237)
                   .ToList();
            }
        }

        protected override void DeleteInserted(IEnumerable<CreditCard> toDelete)
        {
            using (var db = new Db(ConnectionString))
            {
                db.CreditCards.Delete(r => r.CreditCardID > 19237);
            }
        }

        public override void InsertSet(IEnumerable<CreditCard> toInsert, int batchSize)
        {
            using (var db = new Db(ConnectionString))
            {
                db.BulkCopy(new BulkCopyOptions { BulkCopyType = BulkCopyType.MultipleRows, MaxBatchSize = batchSize }, toInsert);
            }
        }
    }
}
