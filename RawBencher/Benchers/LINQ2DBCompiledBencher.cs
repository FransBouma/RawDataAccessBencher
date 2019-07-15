using LINQ2DB.Bencher;
using LinqToDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	public class LINQ2DBCompiledBencher : LINQ2DBNormalBencher
	{
		private static readonly Func<Db, int, LINQ2DB.Bencher.SalesOrderHeader> _fetchIndividual
			= CompiledQuery.Compile((Db db, int id) => db.SalesOrderHeader
														.Where(p => p.SalesOrderID == id)
														.FirstOrDefault());

		private static readonly Func<Db, IEnumerable<LINQ2DB.Bencher.SalesOrderHeader>> _fetchSet
			= CompiledQuery.Compile((Db db) => db.SalesOrderHeader);

		private static readonly Func<Db, IQueryable<LINQ2DB.Bencher.SalesOrderHeader>> _fetchGraph
			= CompiledQuery.Compile((Db db) => from soh in db.SalesOrderHeaders
													.LoadWith(x => x.SalesOrderDetails)
													.LoadWith(x => x.Customer)
												where soh.SalesOrderID > 50000 && soh.SalesOrderID <= 51000
												select soh);

		private static readonly Func<Db, IQueryable<CreditCard>> _fetchInserted
			= CompiledQuery.Compile((Db db) => db.CreditCards
												.Where(_ => _.CreditCardID > 19237));

		private static readonly Func<Db, IEnumerable<CreditCard>, int> _deleteInserted
			= CompiledQuery.Compile((Db db, IEnumerable<CreditCard> toDelete) => db.CreditCards.Delete(r => r.CreditCardID > 19237));

		public LINQ2DBCompiledBencher(string connectionString)
			: base(connectionString)
		{
		}

		public override LINQ2DB.Bencher.SalesOrderHeader FetchIndividual(int key)
		{
			using (var db = new Db(ConnectionString))
				return _fetchIndividual(db, key);
		}

		public override IEnumerable<LINQ2DB.Bencher.SalesOrderHeader> FetchSet()
		{
			using (var db = new Db(ConnectionString))
				return _fetchSet(db).ToList();
		}

		public override IEnumerable<LINQ2DB.Bencher.SalesOrderHeader> FetchGraph()
		{
			using (var db = new Db(ConnectionString))
				return _fetchGraph(db).ToList();
		}

		public override async Task<IEnumerable<LINQ2DB.Bencher.SalesOrderHeader>> FetchGraphAsync()
		{
			using (var db = new Db(ConnectionString))
				return await _fetchGraph(db).ToListAsync();
		}

		protected override IEnumerable<CreditCard> FetchInserted(int amountInserted)
		{
			using (var db = new Db(ConnectionString))
				return _fetchInserted(db).ToList();
		}

		protected override void DeleteInserted(IEnumerable<CreditCard> toDelete)
		{
			using (var db = new Db(ConnectionString))
				_deleteInserted(db, toDelete);
		}

		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LINQ to DB v{0} (v{1}) (compiled)", typeof(LinqToDB.Data.DataConnection));
		}
	}
}
