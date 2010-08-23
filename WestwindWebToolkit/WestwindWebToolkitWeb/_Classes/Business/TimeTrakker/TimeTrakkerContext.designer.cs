﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Westwind.WebToolkit
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DevSamples")]
	public partial class TimeTrakkerContext : Westwind.BusinessFramework.LinqToSql.DataContextSql
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTimeEntry(TimeEntry instance);
    partial void UpdateTimeEntry(TimeEntry instance);
    partial void DeleteTimeEntry(TimeEntry instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    #endregion
		
		public TimeTrakkerContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DevSampleConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TimeTrakkerContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimeTrakkerContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimeTrakkerContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TimeTrakkerContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TimeEntry> TimeEntries
		{
			get
			{
				return this.GetTable<TimeEntry>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TimeEntries")]
	public partial class TimeEntry : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pk;
		
		private int _CustomerPk;
		
		private int _ProjectPk;
		
		private int _InvoicePk;
		
		private int _UserPk;
		
		private string _Title;
		
		private string _Description;
		
		private System.DateTime _TimeIn;
		
		private System.DateTime _TimeOut;
		
		private bool _PunchedOut;
		
		private decimal _Qty;
		
		private decimal _Rate;
		
		private decimal _TotalHours;
		
		private decimal _ItemTotal;
		
		private bool _Taxable;
		
		private bool _Billed;
		
		private bool _Imported;
		
		private string _Xml;
		
		private System.Data.Linq.Binary _tversion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPkChanging(int value);
    partial void OnPkChanged();
    partial void OnCustomerPkChanging(int value);
    partial void OnCustomerPkChanged();
    partial void OnProjectPkChanging(int value);
    partial void OnProjectPkChanged();
    partial void OnInvoicePkChanging(int value);
    partial void OnInvoicePkChanged();
    partial void OnUserPkChanging(int value);
    partial void OnUserPkChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnTimeInChanging(System.DateTime value);
    partial void OnTimeInChanged();
    partial void OnTimeOutChanging(System.DateTime value);
    partial void OnTimeOutChanged();
    partial void OnPunchedOutChanging(bool value);
    partial void OnPunchedOutChanged();
    partial void OnQtyChanging(decimal value);
    partial void OnQtyChanged();
    partial void OnRateChanging(decimal value);
    partial void OnRateChanged();
    partial void OnTotalHoursChanging(decimal value);
    partial void OnTotalHoursChanged();
    partial void OnItemTotalChanging(decimal value);
    partial void OnItemTotalChanged();
    partial void OnTaxableChanging(bool value);
    partial void OnTaxableChanged();
    partial void OnBilledChanging(bool value);
    partial void OnBilledChanged();
    partial void OnImportedChanging(bool value);
    partial void OnImportedChanged();
    partial void OnXmlChanging(string value);
    partial void OnXmlChanged();
    partial void OntversionChanging(System.Data.Linq.Binary value);
    partial void OntversionChanged();
    #endregion
		
		public TimeEntry()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pk", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int Pk
		{
			get
			{
				return this._Pk;
			}
			set
			{
				if ((this._Pk != value))
				{
					this.OnPkChanging(value);
					this.SendPropertyChanging();
					this._Pk = value;
					this.SendPropertyChanged("Pk");
					this.OnPkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerPk", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int CustomerPk
		{
			get
			{
				return this._CustomerPk;
			}
			set
			{
				if ((this._CustomerPk != value))
				{
					this.OnCustomerPkChanging(value);
					this.SendPropertyChanging();
					this._CustomerPk = value;
					this.SendPropertyChanged("CustomerPk");
					this.OnCustomerPkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectPk", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int ProjectPk
		{
			get
			{
				return this._ProjectPk;
			}
			set
			{
				if ((this._ProjectPk != value))
				{
					this.OnProjectPkChanging(value);
					this.SendPropertyChanging();
					this._ProjectPk = value;
					this.SendPropertyChanged("ProjectPk");
					this.OnProjectPkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InvoicePk", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int InvoicePk
		{
			get
			{
				return this._InvoicePk;
			}
			set
			{
				if ((this._InvoicePk != value))
				{
					this.OnInvoicePkChanging(value);
					this.SendPropertyChanging();
					this._InvoicePk = value;
					this.SendPropertyChanged("InvoicePk");
					this.OnInvoicePkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserPk", DbType="Int NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public int UserPk
		{
			get
			{
				return this._UserPk;
			}
			set
			{
				if ((this._UserPk != value))
				{
					this.OnUserPkChanging(value);
					this.SendPropertyChanging();
					this._UserPk = value;
					this.SendPropertyChanged("UserPk");
					this.OnUserPkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(128)", UpdateCheck=UpdateCheck.Never)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeIn", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime TimeIn
		{
			get
			{
				return this._TimeIn;
			}
			set
			{
				if ((this._TimeIn != value))
				{
					this.OnTimeInChanging(value);
					this.SendPropertyChanging();
					this._TimeIn = value;
					this.SendPropertyChanged("TimeIn");
					this.OnTimeInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeOut", DbType="DateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime TimeOut
		{
			get
			{
				return this._TimeOut;
			}
			set
			{
				if ((this._TimeOut != value))
				{
					this.OnTimeOutChanging(value);
					this.SendPropertyChanging();
					this._TimeOut = value;
					this.SendPropertyChanged("TimeOut");
					this.OnTimeOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PunchedOut", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool PunchedOut
		{
			get
			{
				return this._PunchedOut;
			}
			set
			{
				if ((this._PunchedOut != value))
				{
					this.OnPunchedOutChanging(value);
					this.SendPropertyChanging();
					this._PunchedOut = value;
					this.SendPropertyChanged("PunchedOut");
					this.OnPunchedOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Qty", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal Qty
		{
			get
			{
				return this._Qty;
			}
			set
			{
				if ((this._Qty != value))
				{
					this.OnQtyChanging(value);
					this.SendPropertyChanging();
					this._Qty = value;
					this.SendPropertyChanged("Qty");
					this.OnQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rate", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal Rate
		{
			get
			{
				return this._Rate;
			}
			set
			{
				if ((this._Rate != value))
				{
					this.OnRateChanging(value);
					this.SendPropertyChanging();
					this._Rate = value;
					this.SendPropertyChanged("Rate");
					this.OnRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TotalHours", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal TotalHours
		{
			get
			{
				return this._TotalHours;
			}
			set
			{
				if ((this._TotalHours != value))
				{
					this.OnTotalHoursChanging(value);
					this.SendPropertyChanging();
					this._TotalHours = value;
					this.SendPropertyChanged("TotalHours");
					this.OnTotalHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemTotal", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal ItemTotal
		{
			get
			{
				return this._ItemTotal;
			}
			set
			{
				if ((this._ItemTotal != value))
				{
					this.OnItemTotalChanging(value);
					this.SendPropertyChanging();
					this._ItemTotal = value;
					this.SendPropertyChanged("ItemTotal");
					this.OnItemTotalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Taxable", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool Taxable
		{
			get
			{
				return this._Taxable;
			}
			set
			{
				if ((this._Taxable != value))
				{
					this.OnTaxableChanging(value);
					this.SendPropertyChanging();
					this._Taxable = value;
					this.SendPropertyChanged("Taxable");
					this.OnTaxableChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Billed", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool Billed
		{
			get
			{
				return this._Billed;
			}
			set
			{
				if ((this._Billed != value))
				{
					this.OnBilledChanging(value);
					this.SendPropertyChanging();
					this._Billed = value;
					this.SendPropertyChanged("Billed");
					this.OnBilledChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Imported", DbType="Bit NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public bool Imported
		{
			get
			{
				return this._Imported;
			}
			set
			{
				if ((this._Imported != value))
				{
					this.OnImportedChanging(value);
					this.SendPropertyChanging();
					this._Imported = value;
					this.SendPropertyChanged("Imported");
					this.OnImportedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Xml", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Xml
		{
			get
			{
				return this._Xml;
			}
			set
			{
				if ((this._Xml != value))
				{
					this.OnXmlChanging(value);
					this.SendPropertyChanging();
					this._Xml = value;
					this.SendPropertyChanged("Xml");
					this.OnXmlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tversion", AutoSync=AutoSync.Always, DbType="rowversion", CanBeNull=true, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary tversion
		{
			get
			{
				return this._tversion;
			}
			set
			{
				if ((this._tversion != value))
				{
					this.OntversionChanging(value);
					this.SendPropertyChanging();
					this._tversion = value;
					this.SendPropertyChanged("tversion");
					this.OntversionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customers")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Pk;
		
		private string _LastName;
		
		private string _FirstName;
		
		private string _Company;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
		private string _Country;
		
		private string _CountryId;
		
		private string _Phone;
		
		private string _Email;
		
		private string _Fax;
		
		private string _Notes;
		
		private System.DateTime _Entered;
		
		private System.DateTime _Updated;
		
		private decimal _BillingRate;
		
		private System.Data.Linq.Binary _tversion;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPkChanging(int value);
    partial void OnPkChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnCompanyChanging(string value);
    partial void OnCompanyChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    partial void OnCountryChanging(string value);
    partial void OnCountryChanged();
    partial void OnCountryIdChanging(string value);
    partial void OnCountryIdChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    partial void OnEnteredChanging(System.DateTime value);
    partial void OnEnteredChanged();
    partial void OnUpdatedChanging(System.DateTime value);
    partial void OnUpdatedChanged();
    partial void OnBillingRateChanging(decimal value);
    partial void OnBillingRateChanged();
    partial void OntversionChanging(System.Data.Linq.Binary value);
    partial void OntversionChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pk", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public int Pk
		{
			get
			{
				return this._Pk;
			}
			set
			{
				if ((this._Pk != value))
				{
					this.OnPkChanging(value);
					this.SendPropertyChanging();
					this._Pk = value;
					this.SendPropertyChanged("Pk");
					this.OnPkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Company", DbType="NVarChar(80) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Company
		{
			get
			{
				return this._Company;
			}
			set
			{
				if ((this._Company != value))
				{
					this.OnCompanyChanging(value);
					this.SendPropertyChanging();
					this._Company = value;
					this.SendPropertyChanged("Company");
					this.OnCompanyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(2048) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NChar(10) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="NChar(12) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Country", DbType="NVarChar(50) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Country
		{
			get
			{
				return this._Country;
			}
			set
			{
				if ((this._Country != value))
				{
					this.OnCountryChanging(value);
					this.SendPropertyChanging();
					this._Country = value;
					this.SendPropertyChanged("Country");
					this.OnCountryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryId", DbType="NChar(10) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string CountryId
		{
			get
			{
				return this._CountryId;
			}
			set
			{
				if ((this._CountryId != value))
				{
					this.OnCountryIdChanging(value);
					this.SendPropertyChanging();
					this._CountryId = value;
					this.SendPropertyChanged("CountryId");
					this.OnCountryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(128) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="NVarChar(256) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Entered", DbType="SmallDateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime Entered
		{
			get
			{
				return this._Entered;
			}
			set
			{
				if ((this._Entered != value))
				{
					this.OnEnteredChanging(value);
					this.SendPropertyChanging();
					this._Entered = value;
					this.SendPropertyChanged("Entered");
					this.OnEnteredChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Updated", DbType="SmallDateTime NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTime Updated
		{
			get
			{
				return this._Updated;
			}
			set
			{
				if ((this._Updated != value))
				{
					this.OnUpdatedChanging(value);
					this.SendPropertyChanging();
					this._Updated = value;
					this.SendPropertyChanged("Updated");
					this.OnUpdatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BillingRate", DbType="Decimal(18,2) NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public decimal BillingRate
		{
			get
			{
				return this._BillingRate;
			}
			set
			{
				if ((this._BillingRate != value))
				{
					this.OnBillingRateChanging(value);
					this.SendPropertyChanging();
					this._BillingRate = value;
					this.SendPropertyChanged("BillingRate");
					this.OnBillingRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tversion", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary tversion
		{
			get
			{
				return this._tversion;
			}
			set
			{
				if ((this._tversion != value))
				{
					this.OntversionChanging(value);
					this.SendPropertyChanging();
					this._tversion = value;
					this.SendPropertyChanged("tversion");
					this.OntversionChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591