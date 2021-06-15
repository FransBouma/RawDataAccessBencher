RawDataAccessBencher
====================
Bench code which tests entity materialization speed of various .NET data access / ORM implementations. The tests focus solely on entity / object materialization and therefore don't do any fancy queries, graph fetches or other nice things which one expects from ORMs. It's not a scientific benchmark system, but an indication to see which framework is fast and which is slow compared to each other. See for more details about what this test is not: http://weblogs.asp.net/fbouma/archive/2014/02/13/re-create-benchmarks-and-results-that-have-value.aspx

### Results ###

The results of various runs of the benchmark are available as files in the repository, please see the [Results](https://github.com/FransBouma/RawDataAccessBencher/tree/master/Results) folder, which contains per run a .txt file with the results measured.

### Requirements ###

.NET 4.8.0 and .NET 5.0, SQL Server with AdventureWorks example database (2008 version, available on [Github](https://github.com/Microsoft/sql-server-samples/releases/tag/adventureworks)). See below how to install/configure it. The mappings supplied are for the 2008 version of the example database. 

### How to attach / install the database ###

Install SQL Server 2008 or higher and download the 2008 version of the database from the link above. Unpacking the zip will give you two files. Copy the two files in the DATA folder of your sql server installation and attach the mdf file in SQL Server Management Studio. 

*Important*: it's important you attach the database as 'AdventureWorks', as the code expects it to be called that way. If you leave the name as-is, the Catalog name has '_2008' as suffix. LLBLGen Pro has the catalog name in the persistence information (so it can have multiple catalogs in one model) and to make it work you have to enable the catalog name overwriting defined in the app.config file in the rawbencher project. It's commented so it's straight forward. If you attached the database as AdventureWorks, you don't have to do anything.

### How to run the benchmarks ###

Please run the benchmarks on a DB accessed over a network to avoid having the DB consume performance of the CPU / memory which thus doesn't give a real-life scenario overview of the real fetch speed of the used Data-access / ORM framework. The entity SalesOrderHeader was chosen as it has more than a couple of fields, a variety of types, many rows in the table and several relationships with other entities which could or could not affect the ORM's internal performance. 

If you want to export the results to a file directly, run the RawBencher.exe from the command line and specify /a at the end so it will exit immediately when it's done. Example: `RawBencher.exe /a > results.txt`

### 'Framework X isn't there anymore, why?'

* CodeFluent Entities was part of the code base, but has been removed, as they kept the connection open during individual fetches, which gave them an unfair advantage. 
* In previous versions the Telerik Open Access ORM was present, however compiling the code is impossible without the 'enhancer' tool of Telerik present on the system. To make it easier for people to download and compile the code, we therefore removed the Telerik bencher. If you want them, browse to a previous commit and pull the bencher classes and model from there. 

### Remarks per used framework ###

NHibernate uses .hbm mappings, as this is of no relevance to the fetch speed and it avoids a dependency on FluentNHibernate.

In the Entity Framework code, Foreign key fields are present in the code base, as other frameworks fetch them too. This makes Entity Framework become slow in 6.0.2 and earlier. With 6.1 this is partially fixed with 20%-30% faster code (see: http://entityframework.codeplex.com/workitem/1829) however it's still slower most frameworks with FK fields in Entity Framework v6.1. Without Foreign key fields present, Entity Framework takes roughly half the performance of 6.0.2 with FK fields present and ~70% of 6.1. 

Including data-table fetches might look like an apple/oranges comparison, but so is Full ORM vs. Micro 'ORM', as a Micro ORM like Dapper has less things to worry about than, say NHibernate or LLBLGen Pro. The inclusion of these frameworks is done to show what can be achieved if there's little overhead between the DbDataReader and the materialized object. The closer an ORM gets to these lower-level object materializers, the better it is in fetching data with inclusion of the extra features if has to offer to the developer and the application it is used in. 

### Disclaimer ###
I wrote [LLBLGen Pro](http://www.llblgen.com/), though I tried to keep this benchmark as honest and open as possible.

### Further reading ###

* [First blogpost about this subject](http://weblogs.asp.net/fbouma/archive/2013/12/09/fetch-performance-of-various-net-orm-data-access-frameworks.aspx)
* [Second blogpost about this subject](http://weblogs.asp.net/fbouma/archive/2014/02/11/fetch-performance-of-various-net-orm-data-access-frameworks-part-2.aspx)
* [re: Create benchmarks and results that have value](http://weblogs.asp.net/fbouma/archive/2014/02/13/re-create-benchmarks-and-results-that-have-value.aspx)
