using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawBencher.Benchers
{
    class CodeFluentEntitiesBencher : BencherBase<CodeFluentEntities.Bencher.Sales.SalesOrderHeader>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeFluentEntitiesBencher" /> class.
        /// </summary>
        public CodeFluentEntitiesBencher()
            : base(e => e.SalesOrderID, usesChangeTracking: false, usesCaching: false)
        {
            // Check if stored procedures exist, and create them when needed.

            try
            {
                CodeFluentEntities.Bencher.Sales.SalesOrderHeader.Load(0);
            }
            catch (SqlException e)
            {
                if (e.Number == 2812)
                {
                    string sqlConnectionString = CodeFluent.Runtime.CodeFluentContext.Get(CodeFluentEntities.Bencher.Constants.CodeFluentEntities_BencherStoreName).Persistence.ConnectionString;
                    var command = File.ReadAllText(@".\..\..\..\CodeFluentEntities.Bencher\Persistence\CodeFluentEntities.Bencher_procedures.sql");
                    var commands = command.Split(new string[] { @"GO" }, StringSplitOptions.RemoveEmptyEntries);
                    
                    using (var conn = new SqlConnection(sqlConnectionString))
                    {
                        conn.Open();

                        foreach (var c in commands)
                        { 
                            new SqlCommand(c, conn).ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fetches the individual element
        /// </summary>
        /// <param name="key">The key of the element to fetch.</param>
        /// <returns>The fetched element, or null if not found</returns>
        public override CodeFluentEntities.Bencher.Sales.SalesOrderHeader FetchIndividual(int key)
        {
            return CodeFluentEntities.Bencher.Sales.SalesOrderHeader.Load(key);
        }


        /// <summary>
        /// Fetches the complete set of elements and returns this set as an IEnumerable.
        /// </summary>
        /// <returns>the set fetched</returns>
        public override IEnumerable<CodeFluentEntities.Bencher.Sales.SalesOrderHeader> FetchSet()
        {
            var output = CodeFluentEntities.Bencher.Sales.SalesOrderHeaderCollection.LoadAll();
            return output;
        }


        /// <summary>
        /// Creates the name of the framework this bencher is for. Use the overload which accepts a format string and a type to create a name based on a
        /// specific version
        /// </summary>
        /// <returns>the framework name.</returns>
        protected override string CreateFrameworkNameImpl()
        {
            return "CodeFluentEntities, using stored procedures";
        }

    }
}
