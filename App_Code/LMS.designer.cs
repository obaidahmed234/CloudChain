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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB_9D902A_wplproject")]
public partial class LMSDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertInformation(Information instance);
  partial void UpdateInformation(Information instance);
  partial void DeleteInformation(Information instance);
  #endregion
	
	public LMSDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB_9D902A_wplprojectConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public LMSDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LMSDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LMSDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public LMSDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Information> Informations
	{
		get
		{
			return this.GetTable<Information>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Information")]
public partial class Information : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _id;
	
	private string _Name;
	
	private string _Address;
	
	private string _CellNumber;
	
	private string _Gender;
	
	private string _Occupation;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCellNumberChanging(string value);
    partial void OnCellNumberChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnOccupationChanging(string value);
    partial void OnOccupationChanged();
    #endregion
	
	public Information()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int id
	{
		get
		{
			return this._id;
		}
		set
		{
			if ((this._id != value))
			{
				this.OnidChanging(value);
				this.SendPropertyChanging();
				this._id = value;
				this.SendPropertyChanged("id");
				this.OnidChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="NVarChar(50)")]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CellNumber", DbType="NVarChar(50)")]
	public string CellNumber
	{
		get
		{
			return this._CellNumber;
		}
		set
		{
			if ((this._CellNumber != value))
			{
				this.OnCellNumberChanging(value);
				this.SendPropertyChanging();
				this._CellNumber = value;
				this.SendPropertyChanged("CellNumber");
				this.OnCellNumberChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="NVarChar(50)")]
	public string Gender
	{
		get
		{
			return this._Gender;
		}
		set
		{
			if ((this._Gender != value))
			{
				this.OnGenderChanging(value);
				this.SendPropertyChanging();
				this._Gender = value;
				this.SendPropertyChanged("Gender");
				this.OnGenderChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Occupation", DbType="NVarChar(50)")]
	public string Occupation
	{
		get
		{
			return this._Occupation;
		}
		set
		{
			if ((this._Occupation != value))
			{
				this.OnOccupationChanging(value);
				this.SendPropertyChanging();
				this._Occupation = value;
				this.SendPropertyChanged("Occupation");
				this.OnOccupationChanged();
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
#pragma warning restore 1591