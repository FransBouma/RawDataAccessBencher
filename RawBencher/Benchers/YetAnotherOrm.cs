using System;
using System.Collections.Generic;
using System.Globalization;
using JPB.DataAccess.DbInfoConfig;
using JPB.DataAccess.Manager;
using JPB.DataAccess.ModelsAnotations;
using JPB.DataAccess.Contacts;

namespace RawBencher.Benchers
{
	public class YetAnotherOrm : BencherBase<SalesOrderHeader>
	{
		public YetAnotherOrm(string sqlSelectCommandText, string connectionString)
			: base(e => e.SalesOrderId, 
			usesChangeTracking: false, 
			usesCaching: false)
		{
			//Will do some checks, if any of them fail an exception will be thrown
			DbConfig.ConstructorSettings.EnforceCreation = true;

			//as we will not change the existing class
			//we will add the nessesary config data from outside
			new DbConfig().Include<SalesOrderHeader>().SetConfig<SalesOrderHeader>(s =>
			{
				//define the Primary key to allow lookup with Db.Select(key)
				s.SetPrimaryKey(f => f.SalesOrderId);
				//the Id Property is namend diverent from the ID Column so map those
				s.SetForModelKey(f => f.SalesOrderId, "SalesOrderID");
				s.SetForModelKey(f => f.Rowguid, "rowguid");
				//define a static select string
				s.SetClassAttribute(new SelectFactoryAttribute(sqlSelectCommandText));
				//allow an C# Code dom creation of an ADO.net loader consturctor
				s.SetClassAttribute(new AutoGenerateCtorAttribute());
				s.ClassInfoCache.Refresh(true);
			});
			Db = new DbAccessLayer(DbAccessType.MsSql, connectionString)
			{
				LoadCompleteResultBeforeMapping = false,
			};
	
			Db.CheckDatabase();
		}

		public DbAccessLayer Db { get; set; }

		/// <summary>
		/// Gets or sets the connection string to use
		/// </summary>
		public string ConnectionStringToUse { get; set; }

		public override SalesOrderHeader FetchIndividual(int key)
		{
			return Db.Select<SalesOrderHeader>(key);
		}

		public override IEnumerable<SalesOrderHeader> FetchSet()
		{
			return Db.Select<SalesOrderHeader>();
		}

		protected override string CreateFrameworkNameImpl()
		{
			return "Yet another ORM by JPB";
		}
	}
}
