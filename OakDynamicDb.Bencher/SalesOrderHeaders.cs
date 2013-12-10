using Massive;
using Oak;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OakDynamicDb.Bencher
{
    public class SalesOrderHeader : DynamicModel 
    {
        public SalesOrderHeader(object dto) : base(dto) { }
        public SalesOrderHeader() : base() { }
    }

    public class SalesOrderHeaders : DynamicRepository
    {
        public SalesOrderHeaders() : base("Sales.SalesOrderHeader", "SalesOrderID") 
        {
            Projection = d => new SalesOrderHeader(d);
        }
    }
}