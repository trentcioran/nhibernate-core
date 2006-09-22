// 
// NHibernate.Mapping.Attributes
// This product is under the terms of the GNU Lesser General Public License.
//
//
//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2032
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------
//
//
// This source code was auto-generated by Refly, Version=2.21.1.0 (modified).
//
namespace NHibernate.Mapping.Attributes
{
	
	
	/// <summary> </summary>
	[System.AttributeUsage(System.AttributeTargets.Property | System.AttributeTargets.Field, AllowMultiple=true)]
	[System.Serializable()]
	public class ManyToOneAttribute : BaseAttribute
	{
		
		private string _foreignkey = null;
		
		private string _access = null;
		
		private bool _insert = true;
		
		private bool _notnullspecified;
		
		private bool _uniquespecified;
		
		private bool _notnull = false;
		
		private string _name = null;
		
		private NotFoundMode _notfound = NotFoundMode.Unspecified;
		
		private bool _insertspecified;
		
		private OuterJoinStrategy _outerjoin = OuterJoinStrategy.Unspecified;
		
		private string _propertyref = null;
		
		private string _column = null;
		
		private bool _unique = false;
		
		private bool _updatespecified;
		
		private string _class = null;
		
		private CascadeStyle _cascade = CascadeStyle.Unspecified;
		
		private FetchMode _fetch = FetchMode.Unspecified;
		
		private bool _update = true;
		
		/// <summary> Default constructor (position=0) </summary>
		public ManyToOneAttribute() : 
				base(0)
		{
		}
		
		/// <summary> Constructor taking the position of the attribute. </summary>
		public ManyToOneAttribute(int position) : 
				base(position)
		{
		}
		
		/// <summary> </summary>
		public virtual string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string Access
		{
			get
			{
				return this._access;
			}
			set
			{
				this._access = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type AccessType
		{
			get
			{
				return System.Type.GetType( this.Access );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Access = value.FullName.Substring(7);
				else
					this.Access = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual string Class
		{
			get
			{
				return this._class;
			}
			set
			{
				this._class = value;
			}
		}
		
		/// <summary> </summary>
		public virtual System.Type ClassType
		{
			get
			{
				return System.Type.GetType( this.Class );
			}
			set
			{
				if(value.Assembly == typeof(int).Assembly)
					this.Class = value.FullName.Substring(7);
				else
					this.Class = value.FullName + ", " + value.Assembly.GetName().Name;
			}
		}
		
		/// <summary> </summary>
		public virtual string Column
		{
			get
			{
				return this._column;
			}
			set
			{
				this._column = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool NotNull
		{
			get
			{
				return this._notnull;
			}
			set
			{
				this._notnull = value;
				_notnullspecified = true;
			}
		}
		
		/// <summary> Tells if NotNull has been specified. </summary>
		public virtual bool NotNullSpecified
		{
			get
			{
				return this._notnullspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Unique
		{
			get
			{
				return this._unique;
			}
			set
			{
				this._unique = value;
				_uniquespecified = true;
			}
		}
		
		/// <summary> Tells if Unique has been specified. </summary>
		public virtual bool UniqueSpecified
		{
			get
			{
				return this._uniquespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual CascadeStyle Cascade
		{
			get
			{
				return this._cascade;
			}
			set
			{
				this._cascade = value;
			}
		}
		
		/// <summary> </summary>
		public virtual OuterJoinStrategy OuterJoin
		{
			get
			{
				return this._outerjoin;
			}
			set
			{
				this._outerjoin = value;
			}
		}
		
		/// <summary> </summary>
		public virtual FetchMode Fetch
		{
			get
			{
				return this._fetch;
			}
			set
			{
				this._fetch = value;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Update
		{
			get
			{
				return this._update;
			}
			set
			{
				this._update = value;
				_updatespecified = true;
			}
		}
		
		/// <summary> Tells if Update has been specified. </summary>
		public virtual bool UpdateSpecified
		{
			get
			{
				return this._updatespecified;
			}
		}
		
		/// <summary> </summary>
		public virtual bool Insert
		{
			get
			{
				return this._insert;
			}
			set
			{
				this._insert = value;
				_insertspecified = true;
			}
		}
		
		/// <summary> Tells if Insert has been specified. </summary>
		public virtual bool InsertSpecified
		{
			get
			{
				return this._insertspecified;
			}
		}
		
		/// <summary> </summary>
		public virtual string ForeignKey
		{
			get
			{
				return this._foreignkey;
			}
			set
			{
				this._foreignkey = value;
			}
		}
		
		/// <summary> </summary>
		public virtual string PropertyRef
		{
			get
			{
				return this._propertyref;
			}
			set
			{
				this._propertyref = value;
			}
		}
		
		/// <summary> </summary>
		public virtual NotFoundMode NotFound
		{
			get
			{
				return this._notfound;
			}
			set
			{
				this._notfound = value;
			}
		}
	}
}
