///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//
// Do not try to run this code on another version of the database than the database
// which was used to generate this code. This means that when you used f.e. SqlServer 2000
// to generate this code, it is likely that you will not be able to use that code on
// SqlServer 7 due to SQL syntax mismatches. Most code is generic code which will work
// with any database, but some code relies on a specific database type/vendor/version used. 
// This code is located in the DaoClasses which target a specific specified database. Also all
// classes target a specific specified Dynamic Query Engine (DQE) in the using/imports
// directives. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2003.1
// Code is generated on: woensdag 4 september 2019 12:09:46
// Code is generated using templates: C# template set for SqlServer
// Templates vendor: Solutions Design.
// Templates version: 1.0.2003.3.061104
//////////////////////////////////////////////////////////////
using System;

using LLBL2003.AdventureWorks2008;
using LLBL2003.AdventureWorks2008.FactoryClasses;

using SD.LLBLGen.Pro.ORMSupportClasses2003;

namespace LLBL2003.AdventureWorks2008.RelationClasses
{
	/// <summary>
	/// Implements the static Relations variant for the entity: SalesOrderHeader.
	/// This class is generated. Do not modify.
	/// </summary>
	public class SalesOrderHeaderRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public SalesOrderHeaderRelations()
		{
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderDetailEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.SalesOrderID - SalesOrderDetail.SalesOrderID
		/// </summary>
		public IEntityRelation SalesOrderDetailEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderID), 
						EntityFieldFactory.Create(SalesOrderDetailFieldIndex.SalesOrderID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesOrderHeaderSalesReasonEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.SalesOrderID - SalesOrderHeaderSalesReason.SalesOrderID
		/// </summary>
		public IEntityRelation SalesOrderHeaderSalesReasonEntityUsingSalesOrderID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesOrderID), 
						EntityFieldFactory.Create(SalesOrderHeaderSalesReasonFieldIndex.SalesOrderID));

				return relation;
			}
		}
	
	
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.BillToAddressID - Address.AddressID
		/// </summary>
		public IEntityRelation AddressEntityUsingBillToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.BillToAddressID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and AddressEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.ShipToAddressID - Address.AddressID
		/// </summary>
		public IEntityRelation AddressEntityUsingShipToAddressID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(AddressFieldIndex.AddressID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipToAddressID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CreditCardEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.CreditCardID - CreditCard.CreditCardID
		/// </summary>
		public IEntityRelation CreditCardEntityUsingCreditCardID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CreditCardFieldIndex.CreditCardID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CreditCardID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CurrencyRateEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.CurrencyRateID - CurrencyRate.CurrencyRateID
		/// </summary>
		public IEntityRelation CurrencyRateEntityUsingCurrencyRateID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CurrencyRateFieldIndex.CurrencyRateID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CurrencyRateID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and CustomerEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.CustomerID - Customer.CustomerID
		/// </summary>
		public IEntityRelation CustomerEntityUsingCustomerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(CustomerFieldIndex.CustomerID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.CustomerID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesPersonEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.SalesPersonID - SalesPerson.SalesPersonID
		/// </summary>
		public IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalesPersonFieldIndex.SalesPersonID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.SalesPersonID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and SalesTerritoryEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.TerritoryID - SalesTerritory.TerritoryID
		/// </summary>
		public IEntityRelation SalesTerritoryEntityUsingTerritoryID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(SalesTerritoryFieldIndex.TerritoryID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.TerritoryID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between SalesOrderHeaderEntity and ShipMethodEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// SalesOrderHeader.ShipMethodID - ShipMethod.ShipMethodID
		/// </summary>
		public IEntityRelation ShipMethodEntityUsingShipMethodID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ShipMethodFieldIndex.ShipMethodID), 
						EntityFieldFactory.Create(SalesOrderHeaderFieldIndex.ShipMethodID));

				return relation;
			}
		}
	

		#endregion
	}
}
