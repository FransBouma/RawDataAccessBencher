///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 5.3
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using AdventureWorks.Dal.Adapter.v53;
using AdventureWorks.Dal.Adapter.v53.FactoryClasses;
using AdventureWorks.Dal.Adapter.v53.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.v53.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Culture. </summary>
	public partial class CultureRelations
	{
		/// <summary>CTor</summary>
		public CultureRelations()
		{
		}

		/// <summary>Gets all relations of the CultureEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.ProductModelProductDescriptionCultureEntityUsingCultureId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between CultureEntity and ProductModelProductDescriptionCultureEntity over the 1:n relation they have, using the relation between the fields:
		/// Culture.CultureId - ProductModelProductDescriptionCulture.CultureId
		/// </summary>
		public virtual IEntityRelation ProductModelProductDescriptionCultureEntityUsingCultureId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "ProductModelProductDescriptionCultures" , true);
				relation.AddEntityFieldPair(CultureFields.CultureId, ProductModelProductDescriptionCultureFields.CultureId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CultureEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("ProductModelProductDescriptionCultureEntity", false);
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
	internal static class StaticCultureRelations
	{
		internal static readonly IEntityRelation ProductModelProductDescriptionCultureEntityUsingCultureIdStatic = new CultureRelations().ProductModelProductDescriptionCultureEntityUsingCultureId;

		/// <summary>CTor</summary>
		static StaticCultureRelations()
		{
		}
	}
}
