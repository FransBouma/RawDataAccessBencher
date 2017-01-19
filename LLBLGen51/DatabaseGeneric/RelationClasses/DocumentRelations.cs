///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.2
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v51;
using AdventureWorks.Dal.Adapter.v51.FactoryClasses;
using AdventureWorks.Dal.Adapter.v51.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v51.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Document. </summary>
	public partial class DocumentRelations
	{
		/// <summary>CTor</summary>
		public DocumentRelations()
		{
		}

		/// <summary>Gets all relations of the DocumentEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductDocumentEntityUsingDocumentNode);
			toReturn.Add(this.EmployeeEntityUsingOwner);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and ProductDocumentEntity over the 1:n relation they have, using the relation between the fields:
		/// Document.DocumentNode - ProductDocument.DocumentNode
		/// </summary>
		public virtual IEntityRelation ProductDocumentEntityUsingDocumentNode
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductDocuments" , true);
				relation.AddEntityFieldPair(DocumentFields.DocumentNode, ProductDocumentFields.DocumentNode);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductDocumentEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between DocumentEntity and EmployeeEntity over the m:1 relation they have, using the relation between the fields:
		/// Document.Owner - Employee.EmployeeId
		/// </summary>
		public virtual IEntityRelation EmployeeEntityUsingOwner
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Employee", false);
				relation.AddEntityFieldPair(EmployeeFields.EmployeeId, DocumentFields.Owner);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("EmployeeEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("DocumentEntity", true);
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
	internal static class StaticDocumentRelations
	{
		internal static readonly IEntityRelation ProductDocumentEntityUsingDocumentNodeStatic = new DocumentRelations().ProductDocumentEntityUsingDocumentNode;
		internal static readonly IEntityRelation EmployeeEntityUsingOwnerStatic = new DocumentRelations().EmployeeEntityUsingOwner;

		/// <summary>CTor</summary>
		static StaticDocumentRelations()
		{
		}
	}
}
