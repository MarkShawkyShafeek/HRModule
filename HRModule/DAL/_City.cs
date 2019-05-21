
/*
'===============================================================================
'  Generated From - CSharp_dOOdads_BusinessEntity.vbgen
' 
'  ** IMPORTANT  ** 
'  How to Generate your stored procedures:
' 
'  SQL        = SQL_StoredProcs.vbgen
'  ACCESS     = Access_StoredProcs.vbgen
'  ORACLE     = Oracle_StoredProcs.vbgen
'  FIREBIRD   = FirebirdStoredProcs.vbgen
'  POSTGRESQL = PostgreSQL_StoredProcs.vbgen
'
'  The supporting base class SqlClientEntity is in the Architecture directory in "dOOdads".
'  
'  This object is 'abstract' which means you need to inherit from it to be able
'  to instantiate it.  This is very easilly done. You can override properties and
'  methods in your derived class, this allows you to regenerate this class at any
'  time and not worry about overwriting custom code. 
'
'  NEVER EDIT THIS FILE.
'
'  public class YourObject :  _YourObject
'  {
'
'  }
'
'===============================================================================
*/

// Generated by MyGeneration Version # (1.2.0.1)

using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Specialized;

using MyGeneration.dOOdads;

namespace HRModuleEntity
{
	public abstract class _City : SqlClientEntity
	{
		public _City()
		{
			this.QuerySource = "City";
			this.MappingName = "City";

		}	

		//=================================================================
		//  public Overrides void AddNew()
		//=================================================================
		//
		//=================================================================
		public override void AddNew()
		{
			base.AddNew();
			
		}
		
		
		public override void FlushData()
		{
			this._whereClause = null;
			this._aggregateClause = null;
			base.FlushData();
		}
		
		//=================================================================
		//  	public Function LoadAll() As Boolean
		//=================================================================
		//  Loads all of the records in the database, and sets the currentRow to the first row
		//=================================================================
		public bool LoadAll() 
		{
			ListDictionary parameters = null;
			
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CityLoadAll]", parameters);
		}
	
		//=================================================================
		// public Overridable Function LoadByPrimaryKey()  As Boolean
		//=================================================================
		//  Loads a single row of via the primary key
		//=================================================================
		public virtual bool LoadByPrimaryKey(int ID)
		{
			ListDictionary parameters = new ListDictionary();
			parameters.Add(Parameters.ID, ID);

		
			return base.LoadFromSql("[" + this.SchemaStoredProcedure + "proc_CityLoadByPrimaryKey]", parameters);
		}
		
		#region Parameters
		protected class Parameters
		{
			
			public static SqlParameter ID
			{
				get
				{
					return new SqlParameter("@ID", SqlDbType.Int, 0);
				}
			}
			
			public static SqlParameter Name
			{
				get
				{
					return new SqlParameter("@Name", SqlDbType.NVarChar, 50);
				}
			}
			
			public static SqlParameter CreationDate
			{
				get
				{
					return new SqlParameter("@CreationDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter CreatedBy
			{
				get
				{
					return new SqlParameter("@CreatedBy", SqlDbType.BigInt, 0);
				}
			}
			
			public static SqlParameter ModifiedDate
			{
				get
				{
					return new SqlParameter("@ModifiedDate", SqlDbType.DateTime, 0);
				}
			}
			
			public static SqlParameter ModifiedBy
			{
				get
				{
					return new SqlParameter("@ModifiedBy", SqlDbType.BigInt, 0);
				}
			}
			
		}
		#endregion		
	
		#region ColumnNames
		public class ColumnNames
		{  
            public const string ID = "ID";
            public const string Name = "Name";
            public const string CreationDate = "CreationDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";

			static public string ToPropertyName(string columnName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _City.PropertyNames.ID;
					ht[Name] = _City.PropertyNames.Name;
					ht[CreationDate] = _City.PropertyNames.CreationDate;
					ht[CreatedBy] = _City.PropertyNames.CreatedBy;
					ht[ModifiedDate] = _City.PropertyNames.ModifiedDate;
					ht[ModifiedBy] = _City.PropertyNames.ModifiedBy;

				}
				return (string)ht[columnName];
			}

			static private Hashtable ht = null;			 
		}
		#endregion
		
		#region PropertyNames
		public class PropertyNames
		{  
            public const string ID = "ID";
            public const string Name = "Name";
            public const string CreationDate = "CreationDate";
            public const string CreatedBy = "CreatedBy";
            public const string ModifiedDate = "ModifiedDate";
            public const string ModifiedBy = "ModifiedBy";

			static public string ToColumnName(string propertyName)
			{
				if(ht == null)
				{
					ht = new Hashtable();
					
					ht[ID] = _City.ColumnNames.ID;
					ht[Name] = _City.ColumnNames.Name;
					ht[CreationDate] = _City.ColumnNames.CreationDate;
					ht[CreatedBy] = _City.ColumnNames.CreatedBy;
					ht[ModifiedDate] = _City.ColumnNames.ModifiedDate;
					ht[ModifiedBy] = _City.ColumnNames.ModifiedBy;

				}
				return (string)ht[propertyName];
			}

			static private Hashtable ht = null;			 
		}			 
		#endregion	

		#region StringPropertyNames
		public class StringPropertyNames
		{  
            public const string ID = "s_ID";
            public const string Name = "s_Name";
            public const string CreationDate = "s_CreationDate";
            public const string CreatedBy = "s_CreatedBy";
            public const string ModifiedDate = "s_ModifiedDate";
            public const string ModifiedBy = "s_ModifiedBy";

		}
		#endregion		
		
		#region Properties
	
		public virtual int ID
	    {
			get
	        {
				return base.Getint(ColumnNames.ID);
			}
			set
	        {
				base.Setint(ColumnNames.ID, value);
			}
		}

		public virtual string Name
	    {
			get
	        {
				return base.Getstring(ColumnNames.Name);
			}
			set
	        {
				base.Setstring(ColumnNames.Name, value);
			}
		}

		public virtual DateTime CreationDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.CreationDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.CreationDate, value);
			}
		}

		public virtual long CreatedBy
	    {
			get
	        {
				return base.Getlong(ColumnNames.CreatedBy);
			}
			set
	        {
				base.Setlong(ColumnNames.CreatedBy, value);
			}
		}

		public virtual DateTime ModifiedDate
	    {
			get
	        {
				return base.GetDateTime(ColumnNames.ModifiedDate);
			}
			set
	        {
				base.SetDateTime(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual long ModifiedBy
	    {
			get
	        {
				return base.Getlong(ColumnNames.ModifiedBy);
			}
			set
	        {
				base.Setlong(ColumnNames.ModifiedBy, value);
			}
		}


		#endregion
		
		#region String Properties
	
		public virtual string s_ID
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ID) ? string.Empty : base.GetintAsString(ColumnNames.ID);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ID);
				else
					this.ID = base.SetintAsString(ColumnNames.ID, value);
			}
		}

		public virtual string s_Name
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.Name) ? string.Empty : base.GetstringAsString(ColumnNames.Name);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.Name);
				else
					this.Name = base.SetstringAsString(ColumnNames.Name, value);
			}
		}

		public virtual string s_CreationDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreationDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.CreationDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreationDate);
				else
					this.CreationDate = base.SetDateTimeAsString(ColumnNames.CreationDate, value);
			}
		}

		public virtual string s_CreatedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.CreatedBy) ? string.Empty : base.GetlongAsString(ColumnNames.CreatedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.CreatedBy);
				else
					this.CreatedBy = base.SetlongAsString(ColumnNames.CreatedBy, value);
			}
		}

		public virtual string s_ModifiedDate
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedDate) ? string.Empty : base.GetDateTimeAsString(ColumnNames.ModifiedDate);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedDate);
				else
					this.ModifiedDate = base.SetDateTimeAsString(ColumnNames.ModifiedDate, value);
			}
		}

		public virtual string s_ModifiedBy
	    {
			get
	        {
				return this.IsColumnNull(ColumnNames.ModifiedBy) ? string.Empty : base.GetlongAsString(ColumnNames.ModifiedBy);
			}
			set
	        {
				if(string.Empty == value)
					this.SetColumnNull(ColumnNames.ModifiedBy);
				else
					this.ModifiedBy = base.SetlongAsString(ColumnNames.ModifiedBy, value);
			}
		}


		#endregion		
	
		#region Where Clause
		public class WhereClause
		{
			public WhereClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffWhereParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffWhereParameter(this);
					}

					return _tearOff;
				}
			}

			#region WhereParameter TearOff's
			public class TearOffWhereParameter
			{
				public TearOffWhereParameter(WhereClause clause)
				{
					this._clause = clause;
				}
				
				
				public WhereParameter ID
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter Name
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreationDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreationDate, Parameters.CreationDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter CreatedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedDate
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}

				public WhereParameter ModifiedBy
				{
					get
					{
							WhereParameter where = new WhereParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddWhereParameter(where);
							return where;
					}
				}


				private WhereClause _clause;
			}
			#endregion
		
			public WhereParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public WhereParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public WhereParameter CreationDate
		    {
				get
		        {
					if(_CreationDate_W == null)
	        	    {
						_CreationDate_W = TearOff.CreationDate;
					}
					return _CreationDate_W;
				}
			}

			public WhereParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public WhereParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public WhereParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			private WhereParameter _ID_W = null;
			private WhereParameter _Name_W = null;
			private WhereParameter _CreationDate_W = null;
			private WhereParameter _CreatedBy_W = null;
			private WhereParameter _ModifiedDate_W = null;
			private WhereParameter _ModifiedBy_W = null;

			public void WhereClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_CreationDate_W = null;
				_CreatedBy_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;

				this._entity.Query.FlushWhereParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffWhereParameter _tearOff;
			
		}
	
		public WhereClause Where
		{
			get
			{
				if(_whereClause == null)
				{
					_whereClause = new WhereClause(this);
				}
		
				return _whereClause;
			}
		}
		
		private WhereClause _whereClause = null;	
		#endregion
	
		#region Aggregate Clause
		public class AggregateClause
		{
			public AggregateClause(BusinessEntity entity)
			{
				this._entity = entity;
			}
			
			public TearOffAggregateParameter TearOff
			{
				get
				{
					if(_tearOff == null)
					{
						_tearOff = new TearOffAggregateParameter(this);
					}

					return _tearOff;
				}
			}

			#region AggregateParameter TearOff's
			public class TearOffAggregateParameter
			{
				public TearOffAggregateParameter(AggregateClause clause)
				{
					this._clause = clause;
				}
				
				
				public AggregateParameter ID
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ID, Parameters.ID);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter Name
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.Name, Parameters.Name);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreationDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreationDate, Parameters.CreationDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter CreatedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.CreatedBy, Parameters.CreatedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedDate
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedDate, Parameters.ModifiedDate);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}

				public AggregateParameter ModifiedBy
				{
					get
					{
							AggregateParameter aggregate = new AggregateParameter(ColumnNames.ModifiedBy, Parameters.ModifiedBy);
							this._clause._entity.Query.AddAggregateParameter(aggregate);
							return aggregate;
					}
				}


				private AggregateClause _clause;
			}
			#endregion
		
			public AggregateParameter ID
		    {
				get
		        {
					if(_ID_W == null)
	        	    {
						_ID_W = TearOff.ID;
					}
					return _ID_W;
				}
			}

			public AggregateParameter Name
		    {
				get
		        {
					if(_Name_W == null)
	        	    {
						_Name_W = TearOff.Name;
					}
					return _Name_W;
				}
			}

			public AggregateParameter CreationDate
		    {
				get
		        {
					if(_CreationDate_W == null)
	        	    {
						_CreationDate_W = TearOff.CreationDate;
					}
					return _CreationDate_W;
				}
			}

			public AggregateParameter CreatedBy
		    {
				get
		        {
					if(_CreatedBy_W == null)
	        	    {
						_CreatedBy_W = TearOff.CreatedBy;
					}
					return _CreatedBy_W;
				}
			}

			public AggregateParameter ModifiedDate
		    {
				get
		        {
					if(_ModifiedDate_W == null)
	        	    {
						_ModifiedDate_W = TearOff.ModifiedDate;
					}
					return _ModifiedDate_W;
				}
			}

			public AggregateParameter ModifiedBy
		    {
				get
		        {
					if(_ModifiedBy_W == null)
	        	    {
						_ModifiedBy_W = TearOff.ModifiedBy;
					}
					return _ModifiedBy_W;
				}
			}

			private AggregateParameter _ID_W = null;
			private AggregateParameter _Name_W = null;
			private AggregateParameter _CreationDate_W = null;
			private AggregateParameter _CreatedBy_W = null;
			private AggregateParameter _ModifiedDate_W = null;
			private AggregateParameter _ModifiedBy_W = null;

			public void AggregateClauseReset()
			{
				_ID_W = null;
				_Name_W = null;
				_CreationDate_W = null;
				_CreatedBy_W = null;
				_ModifiedDate_W = null;
				_ModifiedBy_W = null;

				this._entity.Query.FlushAggregateParameters();

			}
	
			private BusinessEntity _entity;
			private TearOffAggregateParameter _tearOff;
			
		}
	
		public AggregateClause Aggregate
		{
			get
			{
				if(_aggregateClause == null)
				{
					_aggregateClause = new AggregateClause(this);
				}
		
				return _aggregateClause;
			}
		}
		
		private AggregateClause _aggregateClause = null;	
		#endregion
	
		protected override IDbCommand GetInsertCommand() 
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CityInsert]";
	
			CreateParameters(cmd);
			
			SqlParameter p;
			p = cmd.Parameters[Parameters.ID.ParameterName];
			p.Direction = ParameterDirection.Output;
    
			return cmd;
		}
	
		protected override IDbCommand GetUpdateCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CityUpdate]";
	
			CreateParameters(cmd);
			      
			return cmd;
		}
	
		protected override IDbCommand GetDeleteCommand()
		{
		
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "[" + this.SchemaStoredProcedure + "proc_CityDelete]";
	
			SqlParameter p;
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

  
			return cmd;
		}
		
		private IDbCommand CreateParameters(SqlCommand cmd)
		{
			SqlParameter p;
		
			p = cmd.Parameters.Add(Parameters.ID);
			p.SourceColumn = ColumnNames.ID;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.Name);
			p.SourceColumn = ColumnNames.Name;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreationDate);
			p.SourceColumn = ColumnNames.CreationDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.CreatedBy);
			p.SourceColumn = ColumnNames.CreatedBy;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedDate);
			p.SourceColumn = ColumnNames.ModifiedDate;
			p.SourceVersion = DataRowVersion.Current;

			p = cmd.Parameters.Add(Parameters.ModifiedBy);
			p.SourceColumn = ColumnNames.ModifiedBy;
			p.SourceVersion = DataRowVersion.Current;


			return cmd;
		}
	}
}
