// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.GeometryResource;
using Integraph.Models.Ifc2x3.PresentationResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.PresentationOrganizationResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightSourceGoniometric
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightSourceGoniometric : IIfcLightSource
	{
		IIfcAxis2Placement3D @Position { get;  set; }
		IIfcColourRgb @ColourAppearance { get;  set; }
		IfcThermodynamicTemperatureMeasure @ColourTemperature { get;  set; }
		IfcLuminousFluxMeasure @LuminousFlux { get;  set; }
		IfcLightEmissionSourceEnum @LightEmissionSource { get;  set; }
		IIfcLightDistributionDataSourceSelect @LightDistributionDataSource { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IfcLightSourceGoniometric", 758)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceGoniometric : IfcLightSource, IInstantiableEntity, IIfcLightSourceGoniometric, IContainsEntityReferences, IEquatable<@IfcLightSourceGoniometric>
	{
		#region IIfcLightSourceGoniometric explicit implementation
		IIfcAxis2Placement3D IIfcLightSourceGoniometric.Position { 
 
 
			get { return @Position; } 
			set { Position = value as IfcAxis2Placement3D;}
		}	
		IIfcColourRgb IIfcLightSourceGoniometric.ColourAppearance { 
 
 
			get { return @ColourAppearance; } 
			set { ColourAppearance = value as IfcColourRgb;}
		}	
		IfcThermodynamicTemperatureMeasure IIfcLightSourceGoniometric.ColourTemperature { 
 
			get { return @ColourTemperature; } 
			set { ColourTemperature = value;}
		}	
		IfcLuminousFluxMeasure IIfcLightSourceGoniometric.LuminousFlux { 
 
			get { return @LuminousFlux; } 
			set { LuminousFlux = value;}
		}	
		IfcLightEmissionSourceEnum IIfcLightSourceGoniometric.LightEmissionSource { 
 
			get { return @LightEmissionSource; } 
			set { LightEmissionSource = value;}
		}	
		IIfcLightDistributionDataSourceSelect IIfcLightSourceGoniometric.LightDistributionDataSource { 
 
 
			get { return @LightDistributionDataSource; } 
			set { LightDistributionDataSource = value as IfcLightDistributionDataSourceSelect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceGoniometric(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis2Placement3D _position;
		private IfcColourRgb _colourAppearance;
		private IfcThermodynamicTemperatureMeasure _colourTemperature;
		private IfcLuminousFluxMeasure _luminousFlux;
		private IfcLightEmissionSourceEnum _lightEmissionSource;
		private IfcLightDistributionDataSourceSelect _lightDistributionDataSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcAxis2Placement3D @Position 
		{ 
			get 
			{
				if(_activated) return _position;
				Activate();
				return _position;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _position = v, _position, value,  "Position", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 8)]
		public IfcColourRgb @ColourAppearance 
		{ 
			get 
			{
				if(_activated) return _colourAppearance;
				Activate();
				return _colourAppearance;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _colourAppearance = v, _colourAppearance, value,  "ColourAppearance", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcThermodynamicTemperatureMeasure @ColourTemperature 
		{ 
			get 
			{
				if(_activated) return _colourTemperature;
				Activate();
				return _colourTemperature;
			} 
			set
			{
				SetValue( v =>  _colourTemperature = v, _colourTemperature, value,  "ColourTemperature", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcLuminousFluxMeasure @LuminousFlux 
		{ 
			get 
			{
				if(_activated) return _luminousFlux;
				Activate();
				return _luminousFlux;
			} 
			set
			{
				SetValue( v =>  _luminousFlux = v, _luminousFlux, value,  "LuminousFlux", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 11)]
		public IfcLightEmissionSourceEnum @LightEmissionSource 
		{ 
			get 
			{
				if(_activated) return _lightEmissionSource;
				Activate();
				return _lightEmissionSource;
			} 
			set
			{
				SetValue( v =>  _lightEmissionSource = v, _lightEmissionSource, value,  "LightEmissionSource", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcLightDistributionDataSourceSelect @LightDistributionDataSource 
		{ 
			get 
			{
				if(_activated) return _lightDistributionDataSource;
				Activate();
				return _lightDistributionDataSource;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lightDistributionDataSource = v, _lightDistributionDataSource, value,  "LightDistributionDataSource", 10);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				case 5: 
					_colourAppearance = (IfcColourRgb)(value.EntityVal);
					return;
				case 6: 
					_colourTemperature = value.RealVal;
					return;
				case 7: 
					_luminousFlux = value.RealVal;
					return;
				case 8: 
                    _lightEmissionSource = (IfcLightEmissionSourceEnum) System.Enum.Parse(typeof (IfcLightEmissionSourceEnum), value.EnumVal, true);
					return;
				case 9: 
					_lightDistributionDataSource = (IfcLightDistributionDataSourceSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightSourceGoniometric other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@LightColour != null)
					yield return @LightColour;
				if (@Position != null)
					yield return @Position;
				if (@ColourAppearance != null)
					yield return @ColourAppearance;
				if (@LightDistributionDataSource != null)
					yield return @LightDistributionDataSource;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}