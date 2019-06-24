﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplinq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TRBills")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMonthlyBill(MonthlyBill instance);
    partial void UpdateMonthlyBill(MonthlyBill instance);
    partial void DeleteMonthlyBill(MonthlyBill instance);
    partial void InsertWeeklyBill(WeeklyBill instance);
    partial void UpdateWeeklyBill(WeeklyBill instance);
    partial void DeleteWeeklyBill(WeeklyBill instance);
    partial void InsertBringHomePay(BringHomePay instance);
    partial void UpdateBringHomePay(BringHomePay instance);
    partial void DeleteBringHomePay(BringHomePay instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApplinq.Properties.Settings.Default.TRBillsConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MonthlyBill> MonthlyBills
		{
			get
			{
				return this.GetTable<MonthlyBill>();
			}
		}
		
		public System.Data.Linq.Table<WeeklyBill> WeeklyBills
		{
			get
			{
				return this.GetTable<WeeklyBill>();
			}
		}
		
		public System.Data.Linq.Table<BringHomePay> BringHomePays
		{
			get
			{
				return this.GetTable<BringHomePay>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MonthlyBill")]
	public partial class MonthlyBill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _BILL;
		
		private System.Nullable<float> _COST;
		
		private string _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBILLChanging(string value);
    partial void OnBILLChanged();
    partial void OnCOSTChanging(System.Nullable<float> value);
    partial void OnCOSTChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public MonthlyBill()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BILL", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string BILL
		{
			get
			{
				return this._BILL;
			}
			set
			{
				if ((this._BILL != value))
				{
					this.OnBILLChanging(value);
					this.SendPropertyChanging();
					this._BILL = value;
					this.SendPropertyChanged("BILL");
					this.OnBILLChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_COST", DbType="Real")]
		public System.Nullable<float> COST
		{
			get
			{
				return this._COST;
			}
			set
			{
				if ((this._COST != value))
				{
					this.OnCOSTChanging(value);
					this.SendPropertyChanging();
					this._COST = value;
					this.SendPropertyChanged("COST");
					this.OnCOSTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="VarChar(2)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WeeklyBill")]
	public partial class WeeklyBill : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Bill;
		
		private System.Nullable<float> _Cost;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnBillChanging(string value);
    partial void OnBillChanged();
    partial void OnCostChanging(System.Nullable<float> value);
    partial void OnCostChanged();
    #endregion
		
		public WeeklyBill()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bill", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Bill
		{
			get
			{
				return this._Bill;
			}
			set
			{
				if ((this._Bill != value))
				{
					this.OnBillChanging(value);
					this.SendPropertyChanging();
					this._Bill = value;
					this.SendPropertyChanged("Bill");
					this.OnBillChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Real")]
		public System.Nullable<float> Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BringHomePay")]
	public partial class BringHomePay : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private System.Nullable<decimal> _Amount;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAmountChanging(System.Nullable<decimal> value);
    partial void OnAmountChanged();
    #endregion
		
		public BringHomePay()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Amount", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> Amount
		{
			get
			{
				return this._Amount;
			}
			set
			{
				if ((this._Amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._Amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
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
