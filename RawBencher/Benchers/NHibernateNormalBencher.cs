using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NH.Bencher;
using NHibernate;
using NHibernate.Linq;

namespace RawBencher.Benchers
{
	/// <summary>
	/// Specific bencher for NHibernate, doing normal fetch
	/// </summary>
	public class NHibernateNormalBencher : BencherBase<NH.Bencher.EntityClasses.SalesOrderHeader>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NHibernateNormalBencher"/> class.
		/// </summary>
		public NHibernateNormalBencher()
			: base(e => e.SalesOrderId, usesChangeTracking: true, usesCaching: false)
		{
		}


		/// <summary>
		/// Fetches the individual element
		/// </summary>
		/// <param name="key">The key of the element to fetch.</param>
		/// <returns>The fetched element, or null if not found</returns>
		public override NH.Bencher.EntityClasses.SalesOrderHeader FetchIndividual(int key)
		{
			using(var session = SessionManager.OpenSession())
			{
				return session.Get<NH.Bencher.EntityClasses.SalesOrderHeader>(key);
			}
		}


		/// <summary>
		/// Fetches the complete set of elements and returns this set as an IEnumerable.
		/// </summary>
		/// <returns>the set fetched</returns>
		public override IEnumerable<NH.Bencher.EntityClasses.SalesOrderHeader> FetchSet()
		{
			using(var session = SessionManager.OpenSession())
			{
				return session.Query<NH.Bencher.EntityClasses.SalesOrderHeader>().ToList();
			}
		}


		/// <summary>
		/// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
		/// specific version
		/// </summary>
		/// <returns>the framework name.</returns>
		public override string CreateFrameworkName()
		{
			return CreateFrameworkName("NHibernate v{0} (v{1})", typeof(ISession));
		}
	}
}
