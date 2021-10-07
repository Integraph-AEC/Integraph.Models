// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSpatialStructureElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSpatialStructureElement : IIfcProduct
	{
		IfcLabel? @LongName { get;  set; }
		IfcElementCompositionEnum @CompositionType { get;  set; }
		IEnumerable<IIfcRelReferencedInSpatialStructure> @ReferencesElements {  get; }
		IEnumerable<IIfcRelServicesBuildings> @ServicedBySystems {  get; }
		IEnumerable<IIfcRelContainedInSpatialStructure> @ContainsElements {  get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProductExtension
{
	[ExpressType("IfcSpatialStructureElement", 170)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSpatialStructureElement : IfcProduct, IIfcSpatialStructureElement, IEquatable<@IfcSpatialStructureElement>
	{
		#region IIfcSpatialStructureElement explicit implementation
		IfcLabel? IIfcSpatialStructureElement.LongName { 
 
			get { return @LongName; } 
			set { LongName = value;}
		}	
		IfcElementCompositionEnum IIfcSpatialStructureElement.CompositionType { 
 
			get { return @CompositionType; } 
			set { CompositionType = value;}
		}	
		 
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialStructureElement.ReferencesElements {  get { return @ReferencesElements; } }
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialStructureElement.ServicedBySystems {  get { return @ServicedBySystems; } }
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialStructureElement.ContainsElements {  get { return @ContainsElements; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpatialStructureElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcElementCompositionEnum _compositionType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(_activated) return _longName;
				Activate();
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 15)]
		public IfcElementCompositionEnum @CompositionType 
		{ 
			get 
			{
				if(_activated) return _compositionType;
				Activate();
				return _compositionType;
			} 
			set
			{
				SetValue( v =>  _compositionType = v, _compositionType, value,  "CompositionType", 9);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingStructure")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 16)]
		public IEnumerable<IfcRelReferencedInSpatialStructure> @ReferencesElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelReferencedInSpatialStructure>(e => Equals(e.RelatingStructure), "RelatingStructure", this);
			} 
		}
		[InverseProperty("RelatedBuildings")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 17)]
		public IEnumerable<IfcRelServicesBuildings> @ServicedBySystems 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this), "RelatedBuildings", this);
			} 
		}
		[InverseProperty("RelatingStructure")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 18)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainsElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => Equals(e.RelatingStructure), "RelatingStructure", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_longName = value.StringVal;
					return;
				case 8: 
                    _compositionType = (IfcElementCompositionEnum) System.Enum.Parse(typeof (IfcElementCompositionEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpatialStructureElement other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}