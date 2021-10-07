// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcThermalMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcThermalMaterialProperties : IIfcMaterialProperties
	{
		IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity { get;  set; }
		IfcThermodynamicTemperatureMeasure? @BoilingPoint { get;  set; }
		IfcThermodynamicTemperatureMeasure? @FreezingPoint { get;  set; }
		IfcThermalConductivityMeasure? @ThermalConductivity { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcThermalMaterialProperties", 720)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcThermalMaterialProperties : IfcMaterialProperties, IInstantiableEntity, IIfcThermalMaterialProperties, IContainsEntityReferences, IEquatable<@IfcThermalMaterialProperties>
	{
		#region IIfcThermalMaterialProperties explicit implementation
		IfcSpecificHeatCapacityMeasure? IIfcThermalMaterialProperties.SpecificHeatCapacity { 
 
			get { return @SpecificHeatCapacity; } 
			set { SpecificHeatCapacity = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcThermalMaterialProperties.BoilingPoint { 
 
			get { return @BoilingPoint; } 
			set { BoilingPoint = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcThermalMaterialProperties.FreezingPoint { 
 
			get { return @FreezingPoint; } 
			set { FreezingPoint = value;}
		}	
		IfcThermalConductivityMeasure? IIfcThermalMaterialProperties.ThermalConductivity { 
 
			get { return @ThermalConductivity; } 
			set { ThermalConductivity = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcThermalMaterialProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSpecificHeatCapacityMeasure? _specificHeatCapacity;
		private IfcThermodynamicTemperatureMeasure? _boilingPoint;
		private IfcThermodynamicTemperatureMeasure? _freezingPoint;
		private IfcThermalConductivityMeasure? _thermalConductivity;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcSpecificHeatCapacityMeasure? @SpecificHeatCapacity 
		{ 
			get 
			{
				if(_activated) return _specificHeatCapacity;
				Activate();
				return _specificHeatCapacity;
			} 
			set
			{
				SetValue( v =>  _specificHeatCapacity = v, _specificHeatCapacity, value,  "SpecificHeatCapacity", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcThermodynamicTemperatureMeasure? @BoilingPoint 
		{ 
			get 
			{
				if(_activated) return _boilingPoint;
				Activate();
				return _boilingPoint;
			} 
			set
			{
				SetValue( v =>  _boilingPoint = v, _boilingPoint, value,  "BoilingPoint", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcThermodynamicTemperatureMeasure? @FreezingPoint 
		{ 
			get 
			{
				if(_activated) return _freezingPoint;
				Activate();
				return _freezingPoint;
			} 
			set
			{
				SetValue( v =>  _freezingPoint = v, _freezingPoint, value,  "FreezingPoint", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcThermalConductivityMeasure? @ThermalConductivity 
		{ 
			get 
			{
				if(_activated) return _thermalConductivity;
				Activate();
				return _thermalConductivity;
			} 
			set
			{
				SetValue( v =>  _thermalConductivity = v, _thermalConductivity, value,  "ThermalConductivity", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_specificHeatCapacity = value.RealVal;
					return;
				case 2: 
					_boilingPoint = value.RealVal;
					return;
				case 3: 
					_freezingPoint = value.RealVal;
					return;
				case 4: 
					_thermalConductivity = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcThermalMaterialProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}