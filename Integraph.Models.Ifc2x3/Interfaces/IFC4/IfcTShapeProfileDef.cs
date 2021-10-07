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
	public partial class @IfcTShapeProfileDef : IIfcTShapeProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTShapeProfileDef.Depth 
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

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTShapeProfileDef.FlangeWidth 
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

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTShapeProfileDef.WebThickness 
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

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 7)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcTShapeProfileDef.FlangeThickness 
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

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 8)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcTShapeProfileDef.FilletRadius 
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

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 9)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcTShapeProfileDef.FlangeEdgeRadius 
		{ 
			get
			{
				if (!FlangeEdgeRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(FlangeEdgeRadius.Value);
			} 
			set
			{
				FlangeEdgeRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 10)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcTShapeProfileDef.WebEdgeRadius 
		{ 
			get
			{
				if (!WebEdgeRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(WebEdgeRadius.Value);
			} 
			set
			{
				WebEdgeRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 11)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcTShapeProfileDef.WebSlope 
		{ 
			get
			{
				if (!WebSlope.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPlaneAngleMeasure(WebSlope.Value);
			} 
			set
			{
				WebSlope = value.HasValue ? 
					new MeasureResource.IfcPlaneAngleMeasure(value.Value) :  
					 new MeasureResource.IfcPlaneAngleMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTShapeProfileDef), 12)]
		Ifc4.MeasureResource.IfcPlaneAngleMeasure? IIfcTShapeProfileDef.FlangeSlope 
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