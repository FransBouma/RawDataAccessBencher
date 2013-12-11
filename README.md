RawDataAccessBencher
====================

Bench code which tests entity materialization speed of various .NET data access / ORM implementations. The tests focus solely on entity / object materialization and therefore don't do any fancy queries, graph fetches or other nice things which one expects from ORMs. 

### Results ###
Results obtained on 8-dec-2013: http://pastebin.com/KhcauUN3. See the link for details about results.

### Requirements ###

.NET 4.5.1, SQL Server with AdventureWorks example database (2008 version, available on [Microsoft's codeplex site](https://msftdbprodsamples.codeplex.com/releases/view/93587)). See below how to install/configure it. The mappings supplied are for the 2008 version of the example database. 

### How to attach / install the database ###

Install SQL Server 2008 or higher and download the 2008 version of the database from the link above. Unpacking the zip will give you two files. Copy the two files in the DATA folder of your sql server installation and attach the mdf file in SQL Server Management Studio. 

*Important*: it's important you attach the database as 'AdventureWorks', as the code expects it to be called that way. If you leave the name as-is, the Catalog name has '_2008' as suffix. LLBLGen Pro has the catalog name in the persistence information (so it can have multiple catalogs in one model) and to make it work you have to enable the catalog name overwriting defined in the app.config file in the rawbencher project. It's commented so it's straight forward. If you attached the database as AdventureWorks, you don't have to do anything.

### How to run the benchmarks ###

Please run the benchmarks on a DB accessed over a network to avoid having the DB consume performance of the CPU / memory which thus doesn't give a real-life scenario overview of the real fetch speed of the used Data-access / ORM framework. The entity SalesOrderHeader was chosen as it has more than a couple of fields, a variety of types, many rows in the table and several relationships with other entities which could or could not affect the ORM's internal performance. 

### Remarks per used framework ###
NHibernate uses .hbm mappings, as this is of no relevance to the fetch speed and it avoids a dependency on FluentNHibernate.

Entity Framework has two sets of results, one without change tracking. This is to show the difference in performance when change tracking is used with fetching entities (which is the default). 

The Dapper code might be slightly outdated with the latest and greatest, the one included is from October 23rd, 2013.

Including data-table fetches might look like an apple/oranges comparison, but so is Full ORM vs. Micro 'ORM', as a souped up object materializer like Dapper has less things to worry about than, say NHibernate or LLBLGen Pro. The inclusion of these frameworks is done to show what can be achieved if there's little overhead between the DbDataReader and the materialized object. The closer an ORM gets to these lower-level object materializers, the better it is in fetching data with inclusion of the extra features if has to offer to the developer and the application it is used in. 

### Disclaimer ###
I wrote [LLBLGen Pro](http://www.llblgen.com/), though I tried to keep this benchmark as honest and open as possible.

### Further reading ###


