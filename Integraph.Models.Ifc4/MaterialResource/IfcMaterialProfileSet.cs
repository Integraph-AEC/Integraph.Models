// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.MeasureResource;
using Integraph.Models.Ifc4.ProfileResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialProfileSet
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfileSet : IIfcMaterialDefinition
	{
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IItemSet<IIfcMaterialProfile> @MaterialProfiles { get; }
		IIfcCompositeProfileDef @CompositeProfile { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialProfileSet", 1206)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSet : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialProfileSet, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcMaterialProfileSet>
	{
		#region IIfcMaterialProfileSet explicit implementation
		IfcLabel? IIfcMaterialProfileSet.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcMaterialProfileSet.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IItemSet<IIfcMaterialProfile> IIfcMaterialProfileSet.MaterialProfiles { 
			get { return new Common.Collections.ProxyItemSet<IfcMaterialProfile, IIfcMaterialProfile>( @MaterialProfiles); } 
		}	
		IIfcCompositeProfileDef IIfcMaterialProfileSet.CompositeProfile { 
 
 
			get { return @CompositeProfile; } 
			set { CompositeProfile = value as IfcCompositeProfileDef;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSet(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_materialProfiles = new ItemSet<IfcMaterialProfile>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private readonly ItemSet<IfcMaterialProfile> _materialProfiles;
		private IfcCompositeProfileDef _compositeProfile;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcMaterialProfile> @MaterialProfiles 
		{ 
			get 
			{
				if(_activated) return _materialProfiles;
				Activate();
				return _materialProfiles;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcCompositeProfileDef @CompositeProfile 
		{ 
			get 
			{
				if(_activated) return _compositeProfile;
				Activate();
				return _compositeProfile;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _compositeProfile = v, _compositeProfile, value,  "CompositeProfile", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_materialProfiles.InternalAdd((IfcMaterialProfile)value.EntityVal);
					return;
				case 3: 
					_compositeProfile = (IfcCompositeProfileDef)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialProfileSet other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @MaterialProfiles)
					yield return entity;
				if (@CompositeProfile != null)
					yield return @CompositeProfile;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @MaterialProfiles)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}