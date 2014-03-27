RawDataAccessBencher
====================

Bench code which tests entity materialization speed of various .NET data access / ORM implementations. The tests focus solely on entity / object materialization and therefore don't do any fancy queries, graph fetches or other nice things which one expects from ORMs. 

### Results ###

* Results obtained on 11-feb-2014: http://pastebin.com/AAqRhH4X. 
* Results obtained on 8-dec-2013 : http://pastebin.com/KhcauUN3. 

See the links for details about results.

### Requirements ###

.NET 4.5.1, SQL Server with AdventureWorks example database (2008 version, available on [Microsoft's codeplex site](https://msftdbprodsamples.codeplex.com/releases/view/93587)). See below how to install/configure it. The mappings supplied are for the 2008 version of the example database. 

### How to attach / install the database ###

Install SQL Server 2008 or higher and download the 2008 version of the database from the link above. Unpacking the zip will give you two files. Copy the two files in the DATA folder of your sql server installation and attach the mdf file in SQL Server Management Studio. 

*Important*: it's important you attach the database as 'AdventureWorks', as the code expects it to be called that way. If you leave the name as-is, the Catalog name has '_2008' as suffix. LLBLGen Pro has the catalog name in the persistence information (so it can have multiple catalogs in one model) and to make it work you have to enable the catalog name overwriting defined in the app.config file in the rawbencher project. It's commented so it's straight forward. If you attached the database as AdventureWorks, you don't have to do anything.

### How to run the benchmarks ###

Please run the benchmarks on a DB accessed over a network to avoid having the DB consume performance of the CPU / memory which thus doesn't give a real-life scenario overview of the real fetch speed of the used Data-access / ORM framework. The entity SalesOrderHeader was chosen as it has more than a couple of fields, a variety of types, many rows in the table and several relationships with other entities which could or could not affect the ORM's internal performance. 

If you want to export the results to a file directly, run the RawBencher.exe from the command line and specify /a at the end so it will exit immediately when it's done. Example: RawBencher.exe /a > results.txt

### Remarks per used framework ###
NHibernate uses .hbm mappings, as this is of no relevance to the fetch speed and it avoids a dependency on FluentNHibernate.

In the Entity Framework code, Foreign key fields are present in the code base, as other frameworks fetch them too. This makes Entity Framework become slow in 6.0.2 and earlier. With 6.1 this should be partially fixed with 20%-30% faster code (see: http://entityframework.codeplex.com/workitem/1829) however it's still slower than NHibernate with FK fields in Entity Framework v6.1. Without Foreign key fields present, Entity Framework takes roughly half the performance of 6.0.2 with FK fields present and ~70% of 6.1. 

Including data-table fetches might look like an apple/oranges comparison, but so is Full ORM vs. Micro 'ORM', as a souped up object materializer like Dapper has less things to worry about than, say NHibernate or LLBLGen Pro. The inclusion of these frameworks is done to show what can be achieved if there's little overhead between the DbDataReader and the materialized object. The closer an ORM gets to these lower-level object materializers, the better it is in fetching data with inclusion of the extra features if has to offer to the developer and the application it is used in. 

[CodeFluent Entities](http://www.softfluent.com/products/codefluent-entities) is a Model-First code generator integrated into Visual Studio. CodeFluent Entities will access database using automatically generated stored procedures. 
For more information about CodeFluent Entities and this benchmark: http://blog.codefluententities.com/2014/03/27/fetch-performance-of-codefluent-entities/.

### Disclaimer ###
I wrote [LLBLGen Pro](http://www.llblgen.com/), though I tried to keep this benchmark as honest and open as possible.

### Further reading ###

* [First blogpost about this subject](http://weblogs.asp.net/fbouma/archive/2013/12/09/fetch-performance-of-various-net-orm-data-access-frameworks.aspx)
* [Second blogpost about this subject](http://weblogs.asp.net/fbouma/archive/2014/02/11/fetch-performance-of-various-net-orm-data-access-frameworks-part-2.aspx)
