using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorks.Dal.Adapter.DatabaseSpecific;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.Linq;
using SD.LLBLGen.Pro.DQE.SqlServer;
using SD.LLBLGen.Pro.ORMSupportClasses;
using LLBLGenPro.Dtos.DtoClasses;
using LLBLGenPro.Dtos;
using LLBLGenPro.Dtos.DtoClasses.SalesOrderHeaderDtoTypes;
using LLBLGenPro.Dtos.Persistence;
using SD.LLBLGen.Pro.LinqSupportClasses;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for LLBLGen Pro, doing a DTO graph fetch
	/// </summary>bg
	public class LLBLGenProDTOBencher : FetchOnlyBencherBase<SalesOrderHeaderDto>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LLBLGenProDTOBencher"/> class.
		/// </summary>
		public LLBLGenProDTOBencher(string connectionString)
			: base(r => r.SalesOrderId, usesChangeTracking:false, usesCaching:false, supportsAsync:true, supportsEagerLoading:true, supportsIndividualFetch:false, supportsSetFetch:false)
		{
			RuntimeConfiguration.AddConnectionString("AdventureWorks.ConnectionString.SQL Server (SqlClient)", connectionString);
			RuntimeConfiguration.ConfigureDQE<SQLServerDQEConfiguration>(c=>c.AddDbProviderFactory(typeof(Microsoft.Data.SqlClient.SqlClientFactory)));
		}


		public override IEnumerable<SalesOrderHeaderDto> FetchGraph()
		{
			using(var adapter = new DataAccessAdapter())
			{
				var metaData = new LinqMetaData(adapter);
				var q = from soh in metaData.SalesOrderHeader
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh;
				return q.ProjectToSalesOrderHeaderDto().ToList();
			}
		}


		public override async Task<IEnumerable<SalesOrderHeaderDto>> FetchGraphAsync()
		{
			using(var adapter = new DataAccessAdapter())
			{
				var metaData = new LinqMetaData(adapter);
				var q = from soh in metaData.SalesOrderHeader
						where soh.SalesOrderId > 50000 && soh.SalesOrderId <= 51000
						select soh;
				var toReturn = await q.ProjectToSalesOrderHeaderDto().ToListAsync();
				return toReturn;
			}
		}


		public override void VerifyGraphElementChildren(SalesOrderHeaderDto parent, BenchResult resultContainer)
		{
			int amount = 0;
			foreach(var sod in parent.SalesOrderDetails)
			{
				if(sod.SalesOrderId > 0)
				{
					amount++;
				}
				else
				{
					return;
				}
			}
			resultContainer.IncNumberOfRowsForType(typeof(SalesOrderDetailDto), amount);
			if((parent.Customer == null) || (parent.Customer.CustomerId<=0))
			{
				return;
			}
			resultContainer.IncNumberOfRowsForType(typeof(CustomerDto), 1);
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		protected override string CreateFrameworkNameImpl()
		{
			return CreateFrameworkName("LLBLGen Pro v{0} (v{1}), Poco DTO graph", typeof(DataAccessAdapterBase));
		}
	}
}
