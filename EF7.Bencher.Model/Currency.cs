using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Currency
    {
        public Currency()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            CurrencyRate = new HashSet<CurrencyRate>();
            CurrencyRateNavigation = new HashSet<CurrencyRate>();
        }

        public string CurrencyCode { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRate { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRateNavigation { get; set; }
    }
}
