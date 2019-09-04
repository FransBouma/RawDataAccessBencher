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
	/// Implements the static Relations variant for the entity: Employee.
	/// This class is generated. Do not modify.
	/// </summary>
	public class EmployeeRelations
	{
		/// <summary>
		/// CTor
		/// </summary>
		public EmployeeRelations()
		{
		}


		#region Class Property Declarations
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and EmployeeEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - Employee.ManagerID
		/// </summary>
		public IEntityRelation EmployeeEntityUsingManagerID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(EmployeeFieldIndex.ManagerID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and EmployeeAddressEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - EmployeeAddress.EmployeeID
		/// </summary>
		public IEntityRelation EmployeeAddressEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(EmployeeAddressFieldIndex.EmployeeID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - EmployeeDepartmentHistory.EmployeeID
		/// </summary>
		public IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(EmployeeDepartmentHistoryFieldIndex.EmployeeID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and EmployeePayHistoryEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - EmployeePayHistory.EmployeeID
		/// </summary>
		public IEntityRelation EmployeePayHistoryEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(EmployeePayHistoryFieldIndex.EmployeeID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and JobCandidateEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - JobCandidate.EmployeeID
		/// </summary>
		public IEntityRelation JobCandidateEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(JobCandidateFieldIndex.EmployeeID));

				return relation;
			}
		}
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and PurchaseOrderHeaderEntity over the 1:n relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - PurchaseOrderHeader.EmployeeID
		/// </summary>
		public IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToMany);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(PurchaseOrderHeaderFieldIndex.EmployeeID));

				return relation;
			}
		}
	
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and SalesPersonEntity over the 1:1 relation they have,
		/// using the relation between the fields:
		/// Employee.EmployeeID - SalesPerson.SalesPersonID
		/// </summary>
		public IEntityRelation SalesPersonEntityUsingSalesPersonID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.OneToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(EmployeeFieldIndex.EmployeeID), 
						EntityFieldFactory.Create(SalesPersonFieldIndex.SalesPersonID));



				

				return relation;
			}
		}
	
	
		/// <summary>
		/// Returns a new IEntityRelation object, between EmployeeEntity and ContactEntity over the m:1 relation they have,
		/// using the relation between the fields:
		/// Employee.ContactID - Contact.ContactID
		/// </summary>
		public IEntityRelation ContactEntityUsingContactID
		{
			get
			{
				IEntityRelation relation = new EntityRelation(RelationType.ManyToOne);
				
				relation.AddEntityFieldPair(EntityFieldFactory.Create(ContactFieldIndex.ContactID), 
						EntityFieldFactory.Create(EmployeeFieldIndex.ContactID));

				return relation;
			}
		}
	

	

		#endregion
	}
}
