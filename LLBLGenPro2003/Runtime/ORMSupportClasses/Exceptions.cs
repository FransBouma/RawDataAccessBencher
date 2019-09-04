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
using System.Runtime.Serialization;

namespace SD.LLBLGen.Pro.ORMSupportClasses2003
{
	/// <summary>
	/// General exception class which is thrown when a user sets a field which is readonly.
	/// </summary>
	[Serializable]
	public class ORMFieldIsReadonlyException : System.ApplicationException
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		public ORMFieldIsReadonlyException(string message):base(message)
		{
		}


		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMFieldIsReadonlyException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}
	}

	/// <summary>
	/// General exception class which is thrown when a user tries to get a value from a field which is null.
	/// </summary>
	[Serializable]
	public class ORMFieldIsNullException : System.ApplicationException
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		public ORMFieldIsNullException(string message):base(message)
		{
		}

		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMFieldIsNullException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}
	}


	/// <summary>
	/// General exception class which is thrown when a user tries to get a value from a field of an entity which is
	/// marked as OutOfSync, and needs to be refetched.
	/// </summary>
	[Serializable]
	public class ORMEntityOutOfSyncException : System.ApplicationException
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		public ORMEntityOutOfSyncException(string message):base(message)
		{
		}

		
		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMEntityOutOfSyncException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}
	}


	/// <summary>
	/// General exception class which is thrown when a user tries to get a value from a field of an entity which is
	/// marked as Deleted.
	/// </summary>
	[Serializable]
	public class ORMEntityIsDeletedException : System.ApplicationException
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		public ORMEntityIsDeletedException(string message):base(message)
		{
		}

		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMEntityIsDeletedException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}
	}


	/// <summary>
	/// General exception class which is thrown when an exception was caught during a query execution.
	/// Contains the original exception as inner exception.
	/// </summary>
	[Serializable]
	public class ORMQueryExecutionException : System.ApplicationException
	{
		#region Class Member Declarations
		private string						_queryExecuted;
		private Exception					_innerException;

		[NonSerialized]
		private IDataParameterCollection	_parameters;
		#endregion

		/// <summary>
		/// ctor
		/// </summary>
		/// <param name="message">The message of the query</param>
		/// <param name="queryExecuted">The query string executed</param>
		/// <param name="parameters">the parameters collection of the command object executed</param>
		/// <param name="innerException">The actual exception caught</param>
		public ORMQueryExecutionException(string message, string queryExecuted, IDataParameterCollection parameters,
				Exception innerException):base(message)
		{
			_queryExecuted = queryExecuted;
			_parameters = parameters;
			_innerException = innerException;
		}


		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMQueryExecutionException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}

		#region Class Property Declarations
		/// <summary>
		/// Gets the query string (formatted) executed which caused the exception.
		/// </summary>
		public string QueryExecuted
		{
			get
			{
				return _queryExecuted;
			}
		}

		/// <summary>
		/// Gets the parameters collection of the command object executed
		/// </summary>
		/// <remarks>Will be null when the class is instantiated by a deserialization process as parameters can't be serialized.</remarks>
		public IDataParameterCollection Parameters
		{
			get
			{
				return _parameters;
			}
		}

		/// <summary>
		/// Returns the inner exception object of this exception
		/// </summary>
		public new Exception InnerException
		{
			get { return _innerException;}
		}

		#endregion
	}


	/// <summary>
	/// General exception class which is thrown when a user sets a field to a value which 
	/// doesn't match the type of the field.
	/// </summary>
	[Serializable]
	public class ORMValueTypeMismatchException : System.ApplicationException
	{
		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		public ORMValueTypeMismatchException(string message):base(message)
		{
		}

		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMValueTypeMismatchException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}
	}


	/// <summary>
	/// General exception class which is thrown when there is a concurrency error during a save action.
	/// A concurrency error occurs if the Save action of an entity fails, i.e. when no rows are affected by the
	/// save.
	/// </summary>
	[Serializable]
	public class ORMConcurrencyException : System.ApplicationException
	{
		#region Class Member Declarations
		private object _entityWhichFailed;
		#endregion


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		/// <param name="entityWhichFailed">The entity object which save action failed.</param>
		public ORMConcurrencyException(string message, object entityWhichFailed):base(message)
		{
			_entityWhichFailed = entityWhichFailed;
		}


		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMConcurrencyException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets / sets entityWhichFailed
		/// </summary>
		public object EntityWhichFailed
		{
			get
			{
				return _entityWhichFailed;
			}
			set
			{
				_entityWhichFailed = value;
			}
		}
		#endregion

	}


	/// <summary>
	/// General exception class which is thrown by IEntityValidator.Validate()
	/// </summary>
	[Serializable]
	public class ORMEntityValidationException : System.ApplicationException
	{
		#region Class Member Declarations
		private object _entityValidated;
		#endregion


		/// <summary>
		/// CTor
		/// </summary>
		/// <param name="message">The message of the exception</param>
		/// <param name="entityValidated">the entity object validated. Offered as object to share exception objects between adapter/selfservicing.</param>
		public ORMEntityValidationException(string message, object entityValidated):base(message)
		{
			_entityValidated = entityValidated;
		}


		/// <summary>
		/// Constructor for deserialization as the base class already implements ISerializable.
		/// </summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ORMEntityValidationException(SerializationInfo info, StreamingContext context):base(info, context) 
		{
		}


		#region Class Property Declarations
		/// <summary>
		/// Gets EntityValidated
		/// </summary>
		public object EntityValidated
		{
			get
			{
				return _entityValidated;
			}
		}

		#endregion
	}
}
