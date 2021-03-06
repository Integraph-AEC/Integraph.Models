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
	public partial class @IfcCShapeProfileDef : IIfcCShapeProfileDef
	{

		[CrossSchemaAttribute(typeof(IIfcCShapeProfileDef), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCShapeProfileDef.Depth 
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

		[CrossSchemaAttribute(typeof(IIfcCShapeProfileDef), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCShapeProfileDef.Width 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Width);
			} 
			set
			{
				Width = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCShapeProfileDef), 6)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCShapeProfileDef.WallThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(WallThickness);
			} 
			set
			{
				WallThickness = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCShapeProfileDef), 7)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcCShapeProfileDef.Girth 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(Girth);
			} 
			set
			{
				Girth = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCShapeProfileDef), 8)]
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcCShapeProfileDef.InternalFilletRadius 
		{ 
			get
			{
				if (!InternalFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(InternalFilletRadius.Value);
			} 
			set
			{
				InternalFilletRadius = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}