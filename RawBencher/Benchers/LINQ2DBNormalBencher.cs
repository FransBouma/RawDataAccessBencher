using System;
using System.Collections.Generic;

namespace RawBencher.Benchers
{
	public class LINQ2DBNormalBencher : FetchOnlyBencherBase<LINQ2DB.Bencher.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LINQ2DBNormalBencher"/> class.
		/// </summary>
		public LINQ2DBNormalBencher(string connectionString)
			: base(e => e.SalesOrderId, usesChangeTracking:false, usesCaching:false)
		{
			Repository = new LINQ2DB.Bencher.SalesOrderHeaderRepository(connectionString);
		}

		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override LINQ2DB.Bencher.SalesOrderHeader FetchIndividual(int key)
		{
			return Repository.Get(key);
		}

		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<LINQ2DB.Bencher.SalesOrderHeader> FetchSet()
		{
			return Repository.All();
		}

		/// <summary>
		/// Creates the name of the framework this bencher is for. 
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LINQ to DB v{0} (v{1}) (normal)", typeof(LinqToDB.Data.DataConnection));
		}

		private LINQ2DB.Bencher.SalesOrderHeaderRepository Repository { get; set; }
	}
}
