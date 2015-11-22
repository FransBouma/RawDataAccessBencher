using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ2DB.Bencher
{
    public class SalesOrderHeaderRepository
    {
        public SalesOrderHeaderRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }        
        
        public SalesOrderHeader Get(int id)
        {
            using (var db = new Db(ConnectionString))
            {
                return db.SalesOrderHeader
                         .Where(p => p.SalesOrderId == id)
                         .FirstOrDefault();                
            }
        }

        static Func<Db, int, SalesOrderHeader> compiledGet = CompiledQuery.Compile((Db db, int id) =>
        (
            from soh in db.SalesOrderHeader
            where soh.SalesOrderId == id
            select soh
        ).FirstOrDefault());

        public SalesOrderHeader GetCompiled(int id)
        {
            using (var db = new Db(ConnectionString))
            {                
                return compiledGet(db, id);                
            }
        }

        public IEnumerable<SalesOrderHeader> All()
        {
            using (var db = new Db(ConnectionString))
            {
                return db.SalesOrderHeader.ToList();
            }
        }

        static Func<Db, IEnumerable<SalesOrderHeader>> compiledAll = CompiledQuery.Compile((Db db) =>        
            from soh in db.SalesOrderHeader
            select soh
        );

        public IEnumerable<SalesOrderHeader> AllCompiled()
        {
            using (var db = new Db(ConnectionString))
            {
                return compiledAll(db).ToList();
            }
        }        

        public string ConnectionString { get; set; }
    }
}
