// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.ActorResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.UtilityResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOwnerHistory
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOwnerHistory : IPersistEntity
	{
		IIfcPersonAndOrganization @OwningUser { get;  set; }
		IIfcApplication @OwningApplication { get;  set; }
		IfcStateEnum? @State { get;  set; }
		IfcChangeActionEnum @ChangeAction { get;  set; }
		IfcTimeStamp? @LastModifiedDate { get;  set; }
		IIfcPersonAndOrganization @LastModifyingUser { get;  set; }
		IIfcApplication @LastModifyingApplication { get;  set; }
		IfcTimeStamp @CreationDate { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.UtilityResource
{
	[ExpressType("IfcOwnerHistory", 519)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOwnerHistory : PersistEntity, IInstantiableEntity, IIfcOwnerHistory, IContainsEntityReferences, IEquatable<@IfcOwnerHistory>
	{
		#region IIfcOwnerHistory explicit implementation
		IIfcPersonAndOrganization IIfcOwnerHistory.OwningUser { 
 
 
			get { return @OwningUser; } 
			set { OwningUser = value as IfcPersonAndOrganization;}
		}	
		IIfcApplication IIfcOwnerHistory.OwningApplication { 
 
 
			get { return @OwningApplication; } 
			set { OwningApplication = value as IfcApplication;}
		}	
		IfcStateEnum? IIfcOwnerHistory.State { 
 
			get { return @State; } 
			set { State = value;}
		}	
		IfcChangeActionEnum IIfcOwnerHistory.ChangeAction { 
 
			get { return @ChangeAction; } 
			set { ChangeAction = value;}
		}	
		IfcTimeStamp? IIfcOwnerHistory.LastModifiedDate { 
 
			get { return @LastModifiedDate; } 
			set { LastModifiedDate = value;}
		}	
		IIfcPersonAndOrganization IIfcOwnerHistory.LastModifyingUser { 
 
 
			get { return @LastModifyingUser; } 
			set { LastModifyingUser = value as IfcPersonAndOrganization;}
		}	
		IIfcApplication IIfcOwnerHistory.LastModifyingApplication { 
 
 
			get { return @LastModifyingApplication; } 
			set { LastModifyingApplication = value as IfcApplication;}
		}	
		IfcTimeStamp IIfcOwnerHistory.CreationDate { 
 
			get { return @CreationDate; } 
			set { CreationDate = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOwnerHistory(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPersonAndOrganization _owningUser;
		private IfcApplication _owningApplication;
		private IfcStateEnum? _state;
		private IfcChangeActionEnum _changeAction;
		private IfcTimeStamp? _lastModifiedDate;
		private IfcPersonAndOrganization _lastModifyingUser;
		private IfcApplication _lastModifyingApplication;
		private IfcTimeStamp _creationDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcPersonAndOrganization @OwningUser 
		{ 
			get 
			{
				if(_activated) return _owningUser;
				Activate();
				return _owningUser;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _owningUser = v, _owningUser, value,  "OwningUser", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcApplication @OwningApplication 
		{ 
			get 
			{
				if(_activated) return _owningApplication;
				Activate();
				return _owningApplication;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _owningApplication = v, _owningApplication, value,  "OwningApplication", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 3)]
		public IfcStateEnum? @State 
		{ 
			get 
			{
				if(_activated) return _state;
				Activate();
				return _state;
			} 
			set
			{
				SetValue( v =>  _state = v, _state, value,  "State", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 4)]
		public IfcChangeActionEnum @ChangeAction 
		{ 
			get 
			{
				if(_activated) return _changeAction;
				Activate();
				return _changeAction;
			} 
			set
			{
				SetValue( v =>  _changeAction = v, _changeAction, value,  "ChangeAction", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcTimeStamp? @LastModifiedDate 
		{ 
			get 
			{
				if(_activated) return _lastModifiedDate;
				Activate();
				return _lastModifiedDate;
			} 
			set
			{
				SetValue( v =>  _lastModifiedDate = v, _lastModifiedDate, value,  "LastModifiedDate", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcPersonAndOrganization @LastModifyingUser 
		{ 
			get 
			{
				if(_activated) return _lastModifyingUser;
				Activate();
				return _lastModifyingUser;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lastModifyingUser = v, _lastModifyingUser, value,  "LastModifyingUser", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcApplication @LastModifyingApplication 
		{ 
			get 
			{
				if(_activated) return _lastModifyingApplication;
				Activate();
				return _lastModifyingApplication;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lastModifyingApplication = v, _lastModifyingApplication, value,  "LastModifyingApplication", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcTimeStamp @CreationDate 
		{ 
			get 
			{
				if(_activated) return _creationDate;
				Activate();
				return _creationDate;
			} 
			set
			{
				SetValue( v =>  _creationDate = v, _creationDate, value,  "CreationDate", 8);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_owningUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 1: 
					_owningApplication = (IfcApplication)(value.EntityVal);
					return;
				case 2: 
                    _state = (IfcStateEnum) System.Enum.Parse(typeof (IfcStateEnum), value.EnumVal, true);
					return;
				case 3: 
                    _changeAction = (IfcChangeActionEnum) System.Enum.Parse(typeof (IfcChangeActionEnum), value.EnumVal, true);
					return;
				case 4: 
					_lastModifiedDate = value.IntegerVal;
					return;
				case 5: 
					_lastModifyingUser = (IfcPersonAndOrganization)(value.EntityVal);
					return;
				case 6: 
					_lastModifyingApplication = (IfcApplication)(value.EntityVal);
					return;
				case 7: 
					_creationDate = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOwnerHistory other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwningUser != null)
					yield return @OwningUser;
				if (@OwningApplication != null)
					yield return @OwningApplication;
				if (@LastModifyingUser != null)
					yield return @LastModifyingUser;
				if (@LastModifyingApplication != null)
					yield return @LastModifyingApplication;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}