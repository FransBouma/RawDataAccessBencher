using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
	public abstract class FetchOnlyBencherBase<TFetch> : BencherBase<TFetch, object>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BencherBase{TFetch, TInsert}" /> class.
		/// </summary>
		/// <param name="salesOrderIdRetriever">The salesOrderId retriever func, to be used in the data verification step.</param>
		/// <param name="usesChangeTracking">if set to <c>true</c> the fetches will be resulting in change tracked elements</param>
		/// <param name="usesCaching">if set to <c>true</c> the fetches will be using some form of caching (resultset caching, element caching)</param>
		/// <param name="supportsEagerLoading">if set to <c>true</c> this bencher supports eager loading and will participate in eager loading benchmarks.</param>
		/// <param name="supportsAsync">if set to <c>true</c> this bencher supports async and will participate in async benchmarks.</param>
		/// <param name="supportsSetFetch">If set to true, this bencher supports set fetches and will participate in set fetch benchmarks</param>
		/// <param name="supportsIndividualFetch">If set to true, this bencher supports individual element fetches and will participate in individual fetch benchmarks.</param>
		/// <exception cref="ArgumentNullException">salesOrderIdRetriever</exception>
		/// <exception cref="System.ArgumentNullException">salesOrderIdRetriever</exception>
		protected FetchOnlyBencherBase(Func<TFetch, int> salesOrderIdRetriever, bool usesChangeTracking, bool usesCaching, bool supportsEagerLoading = false, bool supportsAsync = false,
									   bool supportsSetFetch=true, bool supportsIndividualFetch=true)
							: base(salesOrderIdRetriever, null, usesChangeTracking, usesCaching, supportsEagerLoading, supportsAsync, false, supportsSetFetch, supportsIndividualFetch)
		{
		}
	}
}
