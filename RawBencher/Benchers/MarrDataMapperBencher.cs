using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marr.Data;
using Marr.Data.Mapping;

namespace RawBencher.Benchers
{
    public class MarrDataMapperBencher : BencherBase<SalesOrderHeader>
    {
        private readonly string _connString;
        private readonly string _command;
        public MarrDataMapperBencher(string connectionString, string command)
            :base(s => s.SalesOrderId, usesChangeTracking: false, usesCaching: false)
        {
            _connString = connectionString;
            _command = command;
            InitMapping();
        }


        public override SalesOrderHeader FetchIndividual(int key)
        {
            using (var db = new DataMapper(System.Data.SqlClient.SqlClientFactory.Instance, _connString))
            {
                var entity = db.Queryable<SalesOrderHeader>().Where(x => x.SalesOrderId == key).FirstOrDefault();
                return entity;
            }
        }

        public override IEnumerable<SalesOrderHeader> FetchSet()
        {
            using (var db = new DataMapper(System.Data.SqlClient.SqlClientFactory.Instance, _connString))
            {
                db.SqlMode = SqlModes.Text;
                return db.Query<SalesOrderHeader>(_command).ToList();
                // altrnatively you can alos use an LINQ approach
                //return db.Query<SalesOrderHeader>().ToList();
            }
        }

        protected override string CreateFrameworkNameImpl()
        {
            return "Marr DataMapper";
        }

        private void InitMapping()
        {
            new FluentMappings().Entity<SalesOrderHeader>().Table.MapTable("Sales.SalesOrderHeader").Columns.AutoMapSimpleTypeProperties();
        }
    }
}
