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
using System.Data;
using System.Text;
using System.Collections;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// Summary description for Query.
	/// </summary>
	[Serializable]
	public abstract class Query : IQuery
	{
		#region Class Member Declarations
			private IDbConnection	_connection;
			private IDbCommand		_command;
			private ArrayList		_parameterFieldRelations;
		#endregion
		
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="commandToUse">Command to use</param>
		public Query(IDbCommand commandToUse)
		{
			_command = commandToUse;
		}


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="connectionToUse">Connection object to use</param>
		/// <param name="commandToUse">Command to use</param>
		public Query(IDbConnection connectionToUse, IDbCommand commandToUse)
		{
			_connection = connectionToUse;
			_command = commandToUse;

			_command.Connection = _connection;
		}


		/// <summary>
		/// Will walk all <see cref="IParameterFieldRelation"/> instances of this query and reflect the parameter values in the related fields.
		/// Only output parameters are taken into account. Used by Insert queries which retrieve Identity / sequence values back from the database
		/// after a succesful insert.
		/// </summary>
		public void ReflectOutputValuesInRelatedFields()
		{
			if(_parameterFieldRelations==null)
			{
				// no parameter relations
				return;
			}

			if(_parameterFieldRelations.Count<=0)
			{
				// no parameter relations to reflect
				return;
			}

			for(int i=0;i<_parameterFieldRelations.Count;i++)
			{
				IParameterFieldRelation relation = (IParameterFieldRelation)_parameterFieldRelations[i];
				if((relation.Parameter.Direction == ParameterDirection.Output) || (relation.Parameter.Direction == ParameterDirection.InputOutput))
				{
					// reflect value in related field object.
					relation.Field.ForcedCurrentValueWrite(relation.Parameter.Value);
				}
			}
		}


		/// <summary>
		/// Overloaded ToString implementation
		/// </summary>
		/// <returns>Returns a complete textual representation of the command stored. The textual representation
		/// will not include parameter values, but will list their names and types.</returns>
		public override string ToString()
		{
			if(_command==null)
			{
				return "";
			}

			StringBuilder queryText = new StringBuilder();
			queryText.AppendFormat("Query: {0}{1}{0}{0}Parameters:{0}", Environment.NewLine, _command.CommandText);

			foreach(IDataParameter currentParameter in this.Parameters)
			{
				queryText.AppendFormat("{0} : {1}. Direction: {2}. {3}", currentParameter.ParameterName, currentParameter.DbType, 
					currentParameter.Direction, Environment.NewLine);
			}

			return queryText.ToString();
		}

		/// <summary>
		/// Adds a new <see cref="IParameterFieldRelation"/> to the collection of <see cref="ParameterFieldRelations"/>. 
		/// </summary>
		/// <param name="relation">The <see cref="IParameterFieldRelation"/> to add</param>
		public void AddParameterFieldRelation(IParameterFieldRelation relation)
		{
			if(_parameterFieldRelations==null)
			{
				_parameterFieldRelations = new ArrayList();
			}

			if(_parameterFieldRelations.Contains(relation))
			{
				// already there
				return;
			}

			// add it
			_parameterFieldRelations.Add(relation);
		}


		#region Class Property Declarations
		/// <summary>
		/// The connection object to use with the <see cref="Command"/>
		/// </summary>
		public IDbConnection Connection 
		{
			get { return _connection; }
			set 
			{
				_connection = value; 
				if(_command != null)
				{
					_command.Connection = value;
				}
			}
		}
		
		/// <summary>
		/// The command used for this query.
		/// </summary>
		public IDbCommand Command 
		{
			get { return _command; }
			set
			{
				_command = value;
				if(value!=null)
				{
					if(_connection!=null)
					{
						_command.Connection = _connection;
					}
				}
			}
		}

		/// <summary>
		/// The list of parameters used in the <see cref="Command"/>. 
		/// </summary>
		public IDataParameterCollection Parameters
		{
			get
			{
				if(_command!=null)
				{
					return _command.Parameters;
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Array list with the <see cref="IParameterFieldRelation"/> instances for the relations between IEntityFields and output parameters.
		/// </summary>
		public ArrayList ParameterFieldRelations 
		{
			get {return _parameterFieldRelations;}
		}
		#endregion
	}
}
