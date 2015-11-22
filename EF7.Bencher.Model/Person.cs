using System;
using System.Collections.Generic;

namespace EF7.Bencher.Model
{
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
        }

        public int BusinessEntityID { get; set; }
        public int EmailPromotion { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string PersonType { get; set; }
        public Guid rowguid { get; set; }
        public string Suffix { get; set; }
        public string Title { get; set; }

        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
