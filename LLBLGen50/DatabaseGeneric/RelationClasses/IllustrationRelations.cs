///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v50;
using AdventureWorks.Dal.Adapter.v50.FactoryClasses;
using AdventureWorks.Dal.Adapter.v50.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v50.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Illustration. </summary>
	public partial class IllustrationRelations
	{
		/// <summary>CTor</summary>
		public IllustrationRelations()
		{
		}

		/// <summary>Gets all relations of the IllustrationEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductModelIllustrationEntityUsingIllustrationId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between IllustrationEntity and ProductModelIllustrationEntity over the 1:n relation they have, using the relation between the fields:
		/// Illustration.IllustrationId - ProductModelIllustration.IllustrationId
		/// </summary>
		public virtual IEntityRelation ProductModelIllustrationEntityUsingIllustrationId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelIllustrations" , true);
				relation.AddEntityFieldPair(IllustrationFields.IllustrationId, ProductModelIllustrationFields.IllustrationId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("IllustrationEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelIllustrationEntity", false);
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
	internal static class StaticIllustrationRelations
	{
		internal static readonly IEntityRelation ProductModelIllustrationEntityUsingIllustrationIdStatic = new IllustrationRelations().ProductModelIllustrationEntityUsingIllustrationId;

		/// <summary>CTor</summary>
		static StaticIllustrationRelations()
		{
		}
	}
}
