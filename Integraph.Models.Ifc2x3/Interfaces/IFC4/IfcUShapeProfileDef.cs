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
namespace Integraph.Models.Ifc2x3.ProfileResource
{
	public partial class @IfcUShapeProfileDef : IIfcUShapeProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcUShapeProfileDef.Depth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Depth);
			} 
			set
			{
				Depth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcUShapeProfileDef.FlangeWidth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FlangeWidth);
			} 
			set
			{
				FlangeWidth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcUShapeProfileDef.WebThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(WebThickness);
			} 
			set
			{
				WebThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 7)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcUShapeProfileDef.FlangeThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(FlangeThickness);
			} 
			set
			{
				FlangeThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 8)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcUShapeProfileDef.FilletRadius 
		{ 
			get
			{
				if (!FilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(FilletRadius.Value);
			} 
			set
			{
				FilletRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 9)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcUShapeProfileDef.EdgeRadius 
		{ 
			get
			{
				if (!EdgeRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(EdgeRadius.Value);
			} 
			set
			{
				EdgeRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcUShapeProfileDef), 10)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcUShapeProfileDef.FlangeSlope 
		{ 
			get
			{
				if (!FlangeSlope.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(FlangeSlope.Value);
			} 
			set
			{
				FlangeSlope = value.HasValue ? 
					new MeasureResource.IfcPlaneAngleMeasure(value.Value) :  
					 new MeasureResource.IfcPlaneAngleMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}