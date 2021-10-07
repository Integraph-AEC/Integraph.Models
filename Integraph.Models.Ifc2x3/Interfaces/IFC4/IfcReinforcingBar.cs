// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;

// ReSharper disable once CheckNamespace
namespace Integraph.Models.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcReinforcingBar : IIfcReinforcingBar
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.NominalDiameter 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter);
			} 
			set
			{
				NominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 default(MeasureResource.IfcPositiveLengthMeasure) ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 11)]
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingBar.CrossSectionArea 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcAreaMeasure(CrossSectionArea);
			} 
			set
			{
				CrossSectionArea = value.HasValue ? 
					new MeasureResource.IfcAreaMeasure(value.Value) :  
					 default(MeasureResource.IfcAreaMeasure) ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 12)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.BarLength 
		{ 
			get
			{
				if (!BarLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(BarLength.Value);
			} 
			set
			{
				BarLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		private  Ifc4.Interfaces.IfcReinforcingBarTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 13)]
		Ifc4.Interfaces.IfcReinforcingBarTypeEnum? IIfcReinforcingBar.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -13);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 14)]
		Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum? IIfcReinforcingBar.BarSurface 
		{ 
			get
			{
				//## Custom code to handle enumeration of BarSurface
				//##
				switch (BarSurface)
				{
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN;
					case ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of BarSurface
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN:
						BarSurface = ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.PLAIN;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED:
						BarSurface = ProfilePropertyResource.IfcReinforcingBarSurfaceEnum.TEXTURED;
						return;
					
					case null:
						BarSurface = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}