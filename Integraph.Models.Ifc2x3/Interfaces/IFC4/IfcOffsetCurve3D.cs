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
namespace Integraph.Models.Ifc2x3.GeometryResource
{
	public partial class @IfcOffsetCurve3D : IIfcOffsetCurve3D
	{

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve3D), 2)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcOffsetCurve3D.Distance 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(Distance);
			} 
			set
			{
				Distance = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve3D), 3)]
		Ifc4.MeasureResource.IfcLogical IIfcOffsetCurve3D.SelfIntersect 
		{ 
			get
			{
				//## Handle return of SelfIntersect for which no match was found
                return new Ifc4.MeasureResource.IfcLogical(SelfIntersect);
				//##
			} 
			set
			{
				SelfIntersect = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve3D), 4)]
		IIfcDirection IIfcOffsetCurve3D.RefDirection 
		{ 
			get
			{
				return RefDirection;
			} 
			set
			{
				RefDirection = value as IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOffsetCurve3D), 1)]
		IIfcCurve IIfcOffsetCurve.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
			set
			{
				BasisCurve = value as IfcCurve;
				
			}
		}
	//## Custom code
	//##
	}
}