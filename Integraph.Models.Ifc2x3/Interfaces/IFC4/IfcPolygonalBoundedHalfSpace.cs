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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class @IfcPolygonalBoundedHalfSpace : IIfcPolygonalBoundedHalfSpace
	{

		[CrossSchemaAttribute(typeof(IIfcPolygonalBoundedHalfSpace), 3)]
		IIfcAxis2Placement3D IIfcPolygonalBoundedHalfSpace.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcAxis2Placement3D;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPolygonalBoundedHalfSpace), 4)]
		IIfcBoundedCurve IIfcPolygonalBoundedHalfSpace.PolygonalBoundary 
		{ 
			get
			{
				return PolygonalBoundary;
			} 
			set
			{
				PolygonalBoundary = value as GeometryResource.IfcBoundedCurve;
				
			}
		}
	//## Custom code
	//##
	}
}