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
	public partial class @IfcCartesianPoint : IIfcCartesianPoint
	{

		[CrossSchemaAttribute(typeof(IIfcCartesianPoint), 1)]
		IItemSet<Integraph.Models.Ifc4.MeasureResource.IfcLengthMeasure> IIfcCartesianPoint.Coordinates 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLengthMeasure, Ifc4.MeasureResource.IfcLengthMeasure>(Coordinates, 
					s => new Ifc4.MeasureResource.IfcLengthMeasure(s), 
					t => new MeasureResource.IfcLengthMeasure(t));
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcGeometricSetSelect.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}