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
using System.Xml;
using System.ComponentModel;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Class which contains the data to set an entity reference found in an XmlNode to an entity instance.
	/// Instances of this class are used to store entity references found in an Xml tree in ReadXml() so these
	/// references can be set once the complete object tree is created and objects are known.
	/// </summary>
	internal class NodeEntityReference
	{
		/// <summary>
		/// The instance holding the ReferenceingProperty.
		/// </summary>
		public object				PropertyHoldingInstance;
		/// <summary>
		/// The ObjectID of the entity object to set as value of the ReferencingProperty
		/// </summary>
		public Guid					ObjectID;
		/// <summary>
		/// The property descriptor of the property to set to the instance with the ObjectID stored in ObjectID
		/// </summary>
		public PropertyDescriptor	ReferencingProperty;
		/// <summary>
		/// If set to true, this reference is not a property set but a collection add. Collection to add to is referenced
		/// by PropertyHoldingInstance
		/// </summary>
		public bool					IsCollectionAdd;
	}


	/// <summary>
	/// Generic XML helper class to work more efficient with an XmlDocument and XmlNodes. This class
	/// contains various utility methods to ease the (de)serialization process of the data to /from Xml
	/// </summary>
	public class XmlHelper
	{
		/// <summary>
		/// CTor
		/// </summary>
		public XmlHelper()
		{
		}



		/// <summary>
		/// Sets the references found during deserialization to the objects instantiated
		/// </summary>
		/// <param name="nodeEntityReferences">list of references</param>
		/// <param name="processedObjectIDs">list of processed objects to set references to</param>
		public static void SetReadReferences(ArrayList nodeEntityReferences, Hashtable processedObjectIDs)
		{
			for (int i = 0; i < nodeEntityReferences.Count; i++)
			{
				NodeEntityReference currentReference = (NodeEntityReference)nodeEntityReferences[i];
				if(currentReference.IsCollectionAdd)
				{
					// is a collection addition. Add it
					EntityCollectionBase2 collection = (EntityCollectionBase2)currentReference.PropertyHoldingInstance;
					collection.DeserializationInProgress=true;
					collection.Add((IEntity2)processedObjectIDs[currentReference.ObjectID]);
					collection.DeserializationInProgress=false;
				}
				else
				{
					// entity reference set in another entity.
					EntityBase2 currentEntity = (EntityBase2)currentReference.PropertyHoldingInstance;
					currentEntity.IsDeserializing=true;
					currentReference.ReferencingProperty.SetValue(currentEntity, (IEntity2)processedObjectIDs[currentReference.ObjectID]);
					currentEntity.IsDeserializing=false;
				}
			}
		}


		/// <summary>
		/// Sets the references found during deserialization to the objects instantiated
		/// SelfServicing version
		/// </summary>
		/// <param name="nodeEntityReferences">list of references</param>
		/// <param name="processedObjectIDs">list of processed objects to set references to</param>
		public static void SetReadReferencesSS(ArrayList nodeEntityReferences, Hashtable processedObjectIDs)
		{
			for (int i = 0; i < nodeEntityReferences.Count; i++)
			{
				NodeEntityReference currentReference = (NodeEntityReference)nodeEntityReferences[i];
				if(currentReference.IsCollectionAdd)
				{
					// is a collection addition. Add it
					EntityCollectionBase collection = (EntityCollectionBase)currentReference.PropertyHoldingInstance;
					collection.DeserializationInProgress=true;
					collection.Add((IEntity)processedObjectIDs[currentReference.ObjectID]);
					collection.DeserializationInProgress=false;
				}
				else
				{
					// entity reference set in another entity.
					EntityBase currentEntity = (EntityBase)currentReference.PropertyHoldingInstance;
					currentEntity.IsDeserializing=true;
					currentReference.ReferencingProperty.SetValue(currentEntity, (IEntity)processedObjectIDs[currentReference.ObjectID]);
					currentEntity.IsDeserializing=false;
				}
			}
		}


		/// <summary>
		/// Adds a new XmlNode with the name nodeName to the document specified. Does not add the node to any
		/// parent node.
		/// </summary>
		/// <param name="parentDocument">document the new node will be added to</param>
		/// <param name="nodeName">name of node</param>
		/// <returns>New node created</returns>
		public virtual XmlNode CreateNewNode(XmlDocument parentDocument, string nodeName)
		{
			XmlNode newNode = parentDocument.CreateNode(XmlNodeType.Element, nodeName, "");
			return newNode;
		}


		/// <summary>
		/// Adds a new XmlNode with the name nodeName and the value nodeValue to the node parentNode specified
		/// </summary>
		/// <param name="parentNode">the parent node the node will be added to as a childnode</param>
		/// <param name="nodeName">name of node</param>
		/// <param name="nodeValue">value of node</param>
		/// <returns>New node created</returns>
		public virtual XmlNode AddNode(XmlNode parentNode, string nodeName, string nodeValue)
		{
			XmlNode newNode = CreateNewNode(parentNode.OwnerDocument, nodeName);
			parentNode.AppendChild(newNode);
			newNode.AppendChild(parentNode.OwnerDocument.CreateTextNode(nodeValue));
			return newNode;
		}


		/// <summary>
		/// Adds a new XmlNode with the name nodeName to the node parentNode specified
		/// </summary>
		/// <param name="parentNode">the parent node the node will be added to as a childnode</param>
		/// <param name="nodeName">name of node</param>
		/// <returns>New node created</returns>
		public virtual XmlNode AddNode(XmlNode parentNode, string nodeName)
		{
			XmlNode newNode = CreateNewNode(parentNode.OwnerDocument, nodeName);
			parentNode.AppendChild(newNode);
			return newNode;
		}


		/// <summary>
		/// Creates a new attribute with the name attributeName and the value attributeValue in the attributeCollection of the node parentNode, using
		/// the parentNode's owner document
		/// </summary>
		/// <param name="parentNode">the attribute's parent node</param>
		/// <param name="attributeName">the name for the new attribute</param>
		/// <param name="attributeValue">the value for the new attribute</param>
		/// <returns>the new attribute</returns>
		public virtual XmlAttribute AddAttribute(XmlNode parentNode, string attributeName, string attributeValue)
		{
			XmlAttribute newAttribute = parentNode.OwnerDocument.CreateAttribute(attributeName);
			newAttribute.Value = attributeValue;
			parentNode.Attributes.Append(newAttribute);
			return newAttribute;
		}


		/// <summary>
		/// Converts the passed in value to the type with the name typeName. The typeName has to be a known type in .NET, and
		/// currently can only be a simple type. The value is returned as 'object'. 
		/// </summary>
		/// <param name="typeName">name of the type the value should be converted in.</param>
		/// <param name="xmlValue">value of the xml node which should be converted into an object.</param>
		/// <returns>the value converted into its native type.</returns>
		public object XmlValueToObject(string typeName, string xmlValue)
		{
			object toReturn = null;

			switch(typeName)
			{
				case "System.String":
					toReturn = xmlValue;
					break;
				case "System.Byte":
					toReturn = Convert.ToByte(xmlValue);
					break;
				case "System.Int32":
					toReturn = Convert.ToInt32(xmlValue);
					break;
				case "System.Int16":
					toReturn = Convert.ToInt16(xmlValue);
					break;
				case "System.Int64":
					toReturn = Convert.ToInt64(xmlValue);
					break;
				case "System.Decimal":
					toReturn = Convert.ToDecimal(xmlValue);
					break;
				case "System.Double":
					toReturn = Convert.ToDouble(xmlValue);
					break;
				case "System.Single":
					toReturn = Convert.ToSingle(xmlValue);
					break;
				case "System.Boolean":
					toReturn = Convert.ToBoolean(xmlValue);
					break;
				case "System.Guid":
					toReturn = new Guid(xmlValue);
					break;
				case "System.DateTime":
					long ticks = Convert.ToInt64(xmlValue);
					toReturn = new DateTime(ticks);
					break;
				case "System.Byte[]":
					toReturn = Convert.FromBase64String(xmlValue);
					break;
				default:
					if(xmlValue.Length<=0)
					{
						toReturn=null;
					}
					else
					{
						toReturn = xmlValue;
					}
					break;
			}

			return toReturn;
		}
	}
}
















