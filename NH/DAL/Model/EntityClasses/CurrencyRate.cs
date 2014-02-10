﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace NH.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'CurrencyRate'</summary>
	public partial class CurrencyRate
	{
		#region Class Member Declarations
		private Currency _currency;
		private Currency _currency1;
		private Iesi.Collections.Generic.ISet<SalesOrderHeader> _salesOrderHeaders;
		private System.Decimal _averageRate;
		private System.DateTime _currencyRateDate;
		private System.Int32 _currencyRateId;
		private System.Decimal _endOfDayRate;
		private System.DateTime _modifiedDate;
		#endregion

		/// <summary>Initializes a new instance of the <see cref="CurrencyRate"/> class.</summary>
		public CurrencyRate() : base()
		{
			_salesOrderHeaders = new Iesi.Collections.Generic.HashedSet<SalesOrderHeader>();
			_currencyRateId = default(System.Int32);
			OnCreated();
		}

		/// <summary>Method called from the constructor</summary>
		partial void OnCreated();

		/// <summary>Returns a hash code for this instance.</summary>
		/// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. </returns>
		public override int GetHashCode()
		{
			int toReturn = base.GetHashCode();
			toReturn ^= this.CurrencyRateId.GetHashCode();
			return toReturn;
		}
	
		/// <summary>Determines whether the specified object is equal to this instance.</summary>
		/// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
		/// <returns><c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj)
		{
			if(obj == null) 
			{
				return false;
			}
			CurrencyRate toCompareWith = obj as CurrencyRate;
			return toCompareWith == null ? false : ((this.CurrencyRateId == toCompareWith.CurrencyRateId));
		}
		

		#region Class Property Declarations
		/// <summary>Gets or sets the AverageRate field. </summary>	
		public virtual System.Decimal AverageRate
		{ 
			get { return _averageRate; }
			set { _averageRate = value; }
		}

		/// <summary>Gets or sets the CurrencyRateDate field. </summary>	
		public virtual System.DateTime CurrencyRateDate
		{ 
			get { return _currencyRateDate; }
			set { _currencyRateDate = value; }
		}

		/// <summary>Gets the CurrencyRateId field. </summary>	
		public virtual System.Int32 CurrencyRateId
		{ 
			get { return _currencyRateId; }
		}

		/// <summary>Gets or sets the EndOfDayRate field. </summary>	
		public virtual System.Decimal EndOfDayRate
		{ 
			get { return _endOfDayRate; }
			set { _endOfDayRate = value; }
		}

		/// <summary>Gets or sets the ModifiedDate field. </summary>	
		public virtual System.DateTime ModifiedDate
		{ 
			get { return _modifiedDate; }
			set { _modifiedDate = value; }
		}

		/// <summary>Represents the navigator which is mapped onto the association 'CurrencyRate.Currency - Currency.CurrencyRates (m:1)'</summary>
		public virtual Currency Currency
		{
			get { return _currency; }
			set { _currency = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'CurrencyRate.Currency1 - Currency.CurrencyRates1 (m:1)'</summary>
		public virtual Currency Currency1
		{
			get { return _currency1; }
			set { _currency1 = value; }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.CurrencyRate - CurrencyRate.SalesOrderHeaders (m:1)'</summary>
		public virtual Iesi.Collections.Generic.ISet<SalesOrderHeader> SalesOrderHeaders
		{
			get { return _salesOrderHeaders; }
			set { _salesOrderHeaders = value; }
		}
		
		#endregion
	}
}
