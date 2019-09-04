using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLBL2003.AdventureWorks2008.CollectionClasses;
using LLBL2003.AdventureWorks2008.EntityClasses;
using LLBL2003.AdventureWorks2008.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro 2003.3, doing normal fetch
	/// </summary>
	public class LLBLGenPro2003NormalBencher : BencherBase<SalesOrderHeaderEntity, CreditCardEntity>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProNormalBencher"/> class.
		/// </summary>
		public LLBLGenPro2003NormalBencher(string connectionString) 
					: base(e=>e.SalesOrderID, l=>l.CreditCardID, usesChangeTracking:true, usesCaching: false, supportsEagerLoading:false, supportsAsync:false, supportsInserts:false)
        {
            DbUtils.ConnectionStringToUse = connectionString;
        }


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override SalesOrderHeaderEntity FetchIndividual(int key)
		{
			return new SalesOrderHeaderEntity(key);
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<SalesOrderHeaderEntity> FetchSet()
		{
			var headers = new SalesOrderHeaderCollection();
			headers.GetMulti(null);
			return headers;
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1})", typeof(TransactionComPlusBase));
		}
	}
}

