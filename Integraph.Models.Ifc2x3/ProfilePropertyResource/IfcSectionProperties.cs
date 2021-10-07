// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSectionProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionProperties : IPersistEntity
	{
		IfcSectionTypeEnum @SectionType { get;  set; }
		IIfcProfileDef @StartProfile { get;  set; }
		IIfcProfileDef @EndProfile { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcSectionProperties", 184)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionProperties : PersistEntity, IInstantiableEntity, IIfcSectionProperties, IContainsEntityReferences, IEquatable<@IfcSectionProperties>
	{
		#region IIfcSectionProperties explicit implementation
		IfcSectionTypeEnum IIfcSectionProperties.SectionType { 
 
			get { return @SectionType; } 
			set { SectionType = value;}
		}	
		IIfcProfileDef IIfcSectionProperties.StartProfile { 
 
 
			get { return @StartProfile; } 
			set { StartProfile = value as IfcProfileDef;}
		}	
		IIfcProfileDef IIfcSectionProperties.EndProfile { 
 
 
			get { return @EndProfile; } 
			set { EndProfile = value as IfcProfileDef;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSectionTypeEnum _sectionType;
		private IfcProfileDef _startProfile;
		private IfcProfileDef _endProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 1)]
		public IfcSectionTypeEnum @SectionType 
		{ 
			get 
			{
				if(_activated) return _sectionType;
				Activate();
				return _sectionType;
			} 
			set
			{
				SetValue( v =>  _sectionType = v, _sectionType, value,  "SectionType", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcProfileDef @StartProfile 
		{ 
			get 
			{
				if(_activated) return _startProfile;
				Activate();
				return _startProfile;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _startProfile = v, _startProfile, value,  "StartProfile", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcProfileDef @EndProfile 
		{ 
			get 
			{
				if(_activated) return _endProfile;
				Activate();
				return _endProfile;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _endProfile = v, _endProfile, value,  "EndProfile", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
                    _sectionType = (IfcSectionTypeEnum) System.Enum.Parse(typeof (IfcSectionTypeEnum), value.EnumVal, true);
					return;
				case 1: 
					_startProfile = (IfcProfileDef)(value.EntityVal);
					return;
				case 2: 
					_endProfile = (IfcProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@StartProfile != null)
					yield return @StartProfile;
				if (@EndProfile != null)
					yield return @EndProfile;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}