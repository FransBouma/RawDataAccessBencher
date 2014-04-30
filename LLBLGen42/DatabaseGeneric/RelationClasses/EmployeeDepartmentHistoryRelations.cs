///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v42;
using AdventureWorks.Dal.Adapter.v42.FactoryClasses;
using AdventureWorks.Dal.Adapter.v42.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v42.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: EmployeeDepartmentHistory. </summary>
	public partial class EmployeeDepartmentHistoryRelations
	{
		/// <summary>CTor</summary>
		public EmployeeDepartmentHistoryRelations()
		{
		}

		/// <summary>Gets all relations of the EmployeeDepartmentHistoryEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.DepartmentEntityUsingDepartmentId);
			toReturn.Add(this.EmployeeEntityUsingEmployeeId);
			toReturn.Add(this.ShiftEntityUsingShiftId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and DepartmentEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.DepartmentId - Department.DepartmentId
		/// </summary>
		public virtual IEntityRelation DepartmentEntityUsingDepartmentId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Department", false);
				relation.AddEntityFieldPair(DepartmentFields.DepartmentId, EmployeeDepartmentHistoryFields.DepartmentId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DepartmentEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.EmployeeId - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingEmployeeId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, EmployeeDepartmentHistoryFields.EmployeeId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between EmployeeDepartmentHistoryEntity and ShiftEntity over the m:1 relation they have, using the relation between the fields:
		/// EmployeeDepartmentHistory.ShiftId - Shift.ShiftId
		/// </summary>
		public virtual IEntityRelation ShiftEntityUsingShiftId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Shift", false);
				relation.AddEntityFieldPair(ShiftFields.ShiftId, EmployeeDepartmentHistoryFields.ShiftId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ShiftEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeDepartmentHistoryEntity", true);
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
	internal static class StaticEmployeeDepartmentHistoryRelations
	{
		internal static readonly IEntityRelation DepartmentEntityUsingDepartmentIdStatic = new EmployeeDepartmentHistoryRelations().DepartmentEntityUsingDepartmentId;
		internal static readonly IEntityRelation EmployeeEntityUsingEmployeeIdStatic = new EmployeeDepartmentHistoryRelations().EmployeeEntityUsingEmployeeId;
		internal static readonly IEntityRelation ShiftEntityUsingShiftIdStatic = new EmployeeDepartmentHistoryRelations().ShiftEntityUsingShiftId;

		/// <summary>CTor</summary>
		static StaticEmployeeDepartmentHistoryRelations()
		{
		}
	}
}
