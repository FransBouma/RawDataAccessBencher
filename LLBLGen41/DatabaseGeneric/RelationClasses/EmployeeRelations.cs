///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.1
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v41;
using AdventureWorks.Dal.Adapter.v41.FactoryClasses;
using AdventureWorks.Dal.Adapter.v41.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v41.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Employee. </summary>
	public partial class EmployeeRelations
	{
		/// <summary>CTor</summary>
		public EmployeeRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DocumentEntityUsingOwner);
			toReturn.Add(this.EmployeeDepartmentHistoryEntityUsingEmployeeId);
			toReturn.Add(this.EmployeePayHistoryEntityUsingEmployeeId);
			toReturn.Add(this.JobCandidateEntityUsingEmployeeId);
			toReturn.Add(this.PurchaseOrderHeaderEntityUsingEmployeeId);
			toReturn.Add(this.PersonEntityUsingEmployeeId);
			toReturn.Add(this.SalesPersonEntityUsingSalesPersonId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and DocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - Document.Owner
		/// </summary>
		public virtual IEntityRelation DocumentEntityUsingOwner
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "Documents" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DocumentFields.Owner);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeeDepartmentHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - EmployeeDepartmentHistory.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeeDepartmentHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeDepartmentHistoryFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and EmployeePayHistoryEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - EmployeePayHistory.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeePayHistoryEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "EmployeePayHistories" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeePayHistoryFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeePayHistoryEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and JobCandidateEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - JobCandidate.EmployeeId
		/// </summary>
		public virtual IEntityRelation JobCandidateEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "JobCandidates" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, JobCandidateFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("JobCandidateEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PurchaseOrderHeaderEntity over the 1:n relation they have, using the relation between the fields:
		/// Employee.EmployeeId - PurchaseOrderHeader.EmployeeId
		/// </summary>
		public virtual IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "PurchaseOrderHeaders" , true);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, PurchaseOrderHeaderFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PurchaseOrderHeaderEntity", false);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and PersonEntity over the 1:1 relation they have, using the relation between the fields:
		/// Employee.EmployeeId - Person.BusinessEntityId
		/// </summary>
		public virtual IEntityRelation PersonEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "Person", false);



				relation.AddEntityFieldPair(PersonFields.BusinessEntityId, EmployeeFields.EmployeeId);

				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("PersonEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between EmployeeEntity and SalesPersonEntity over the 1:1 relation they have, using the relation between the fields:
		/// Employee.EmployeeId - SalesPerson.SalesPersonId
		/// </summary>
		public virtual IEntityRelation SalesPersonEntityUsingSalesPersonId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, "SalesPerson", true);

				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, SalesPersonFields.SalesPersonId);



				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SalesPersonEntity", false);
				return relation;
			}
		}

		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticEmployeeRelations
	{
		internal static readonly IEntityRelation DocumentEntityUsingOwnerStatic = new EmployeeRelations().DocumentEntityUsingOwner;
		internal static readonly IEntityRelation EmployeeDepartmentHistoryEntityUsingEmployeeIdStatic = new EmployeeRelations().EmployeeDepartmentHistoryEntityUsingEmployeeId;
		internal static readonly IEntityRelation EmployeePayHistoryEntityUsingEmployeeIdStatic = new EmployeeRelations().EmployeePayHistoryEntityUsingEmployeeId;
		internal static readonly IEntityRelation JobCandidateEntityUsingEmployeeIdStatic = new EmployeeRelations().JobCandidateEntityUsingEmployeeId;
		internal static readonly IEntityRelation PurchaseOrderHeaderEntityUsingEmployeeIdStatic = new EmployeeRelations().PurchaseOrderHeaderEntityUsingEmployeeId;
		internal static readonly IEntityRelation PersonEntityUsingEmployeeIdStatic = new EmployeeRelations().PersonEntityUsingEmployeeId;
		internal static readonly IEntityRelation SalesPersonEntityUsingSalesPersonIdStatic = new EmployeeRelations().SalesPersonEntityUsingSalesPersonId;

		/// <summary>CTor</summary>
		static StaticEmployeeRelations()
		{
		}
	}
}
