/////////////////////////////////////////////////////////////
// LLBLGen Pro ORM Support Classes Library
// (c) 2002-2003 Solutions Design. All rights reserved.
// http://www.llblgen.com
// http://www.sd.nl/llblgen
// 
// THIS IS NOT OPEN SOURCE SOFTWARE OF ANY KIND.
// SOURCECODE DISTRIBUTION IS NOT ALLOWED IN ANY WAY.
/////////////////////////////////////////////////////////////
using System;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// General synchronization information class for related entities to an existing entity. 
	/// Used to keep track of which entity is set as a related entity using which relation and which field mapped on that
	/// relation so when the related entity is saved, it will be synced with the correct fields. The related
	/// entity is called a Data Suppling Entity.
	/// AdapterVersion
	/// </summary>
	[Serializable]
	public class EntitySyncInfo
	{
		#region Class Member Declarations
		private IEntity2			_dataSupplyingEntity;
		private	IEntityRelation		_relation;
		#endregion


		/// <summary>
		/// CTor
		/// </summary>
		public EntitySyncInfo()
		{
			_dataSupplyingEntity = null;
			_relation = null;
		}

		#region Class Property Declarations
		/// <summary>
		/// Gets / sets Data Supplying Entity value. Used for synchronization between related entities when they have to be synchronized.
		/// </summary>
		public IEntity2 DataSupplyingEntity
		{
			get
			{
				return _dataSupplyingEntity;
			}
			set
			{
				_dataSupplyingEntity = value;
			}
		}


		/// <summary>
		/// Gets / sets the specific Entity Relation between two related entities (the entity holding this object and the entity specified in
		/// DataSupplyingEntity) for synchronization of values.
		/// </summary>
		public IEntityRelation Relation
		{
			get
			{
				return _relation;
			}
			set
			{
				_relation = value;
			}
		}

		#endregion
	}


	/// <summary>
	/// General synchronization information class for related entities to an existing entity. 
	/// Used to keep track of which entity is set as a related entity using which relation and which field mapped on that
	/// relation so when the related entity is saved, it will be synced with the correct fields. The related
	/// entity is called a Data Suppling Entity.
	/// SelfServicing version
	/// </summary>
	[Serializable]
	public class EntitySyncInfoSS
	{
		#region Class Member Declarations
		private IEntity				_dataSupplyingEntity;
		private	IEntityRelation		_relation;
		#endregion


		/// <summary>
		/// CTor
		/// </summary>
		public EntitySyncInfoSS()
		{
			_dataSupplyingEntity = null;
			_relation = null;
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets Data Supplying Entity value. Used for synchronization between related entities when they have to be synchronized.
		/// </summary>
		public IEntity DataSupplyingEntity
		{
			get
			{
				return _dataSupplyingEntity;
			}
			set
			{
				_dataSupplyingEntity = value;
			}
		}


		/// <summary>
		/// Gets / sets the specific Entity Relation between two related entities (the entity holding this object and the entity specified in
		/// DataSupplyingEntity) for synchronization of values.
		/// </summary>
		public IEntityRelation Relation
		{
			get
			{
				return _relation;
			}
			set
			{
				_relation = value;
			}
		}

		#endregion


	}
}
