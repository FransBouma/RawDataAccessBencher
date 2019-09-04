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
	/// GroupByCollection class which is used to collect EntityFields which are used for the 
	/// GROUP BY clause in a retrieval query. When a group by collection is specified in a retrieval query, all
	/// fields in the resultset have to be in this collection.
	/// SelfServicing specific
	/// </summary>
	[Serializable]
	public class GroupByCollection : CollectionBase
	{
		/// <summary>
		/// CTor
		/// </summary>
		public GroupByCollection()
		{
		}


		/// <summary>
		/// Adds the passed in IEntityField instance to the list. IEntityFields can be added just once.
		/// If the field is already in the collection, the index of the field in the list is returned.
		/// </summary>
		/// <param name="fieldToAdd">IEntityField instance to add</param>
		/// <returns>Index of added field in the list.</returns>
		public int Add(IEntityField fieldToAdd)
		{
			int index=this.IndexOf(fieldToAdd);

			if(index > 0)
			{
				// already in list
				return index;
			}

			return List.Add(fieldToAdd);
		}


		/// <summary>
		/// Removes the passed in IEntityField instance. Finds the object to remove using value compare.
		/// </summary>
		/// <param name="fieldToRemove">IEntityField instance to remove</param>
		public void Remove(IEntityField fieldToRemove)
		{
			int index = this.IndexOf(fieldToRemove);

			if(index <0)
			{
				// not in list
				return;
			}

			List.RemoveAt(index);
		}


		/// <summary>
		/// Checks if the field is in the list. Does a value compare, not an object reference compare. 
		/// </summary>
		/// <param name="fieldToCheck">IEntityField to check for presencee.</param>
		/// <returns>true if a similar field is found in the collection, false otherwise.</returns>
		public bool Contains(IEntityField fieldToCheck)
		{
			bool isInList=false;
			for(int i=0;i<List.Count;i++)
			{
				isInList|=(((EntityField)List[i]).CompareTo(fieldToCheck)==0);
				if(isInList)
				{
					break;
				}
			}

			return isInList;
		}


		/// <summary>
		/// Gets the index of the specified field in the list. Uses value compare to find the instance. 
		/// </summary>
		/// <param name="fieldToCheck">field to get the index of</param>
		/// <returns>-1 if not found, index otherwise</returns>
		public int IndexOf(IEntityField fieldToCheck)
		{
			int indexToReturn=-1;
			for(int i=0;i<List.Count;i++)
			{
				if(((EntityField)List[i]).CompareTo(fieldToCheck)==0)
				{
					indexToReturn = i;
					break;
				}
			}

			return indexToReturn;
		}


		#region Class Property Declarations
		/// <summary>
		/// Indexer in the collection.
		/// </summary>
		public IEntityField this [int index] 
		{
			get { return (IEntityField)(List[index]); }
			set { List[index] = value; }
		}

		/// <summary>
		/// The amount of items currently stored in the IGroupByCollection
		/// </summary>
		public new int Count 
		{
			get { return List.Count;}
		}
		#endregion
	}
}
