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
namespace Integraph.Models.Ifc2x3.GeometricConstraintResource
{
	public partial class @IfcVirtualGridIntersection : IIfcVirtualGridIntersection
	{

		[CrossSchemaAttribute(typeof(IIfcVirtualGridIntersection), 1)]
		IItemSet<IIfcGridAxis> IIfcVirtualGridIntersection.IntersectingAxes 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcGridAxis, IIfcGridAxis>(IntersectingAxes);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcVirtualGridIntersection), 2)]
		IItemSet<Integraph.Models.Ifc4.MeasureResource.IfcLengthMeasure> IIfcVirtualGridIntersection.OffsetDistances 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcLengthMeasure, Ifc4.MeasureResource.IfcLengthMeasure>(OffsetDistances, 
					s => new Ifc4.MeasureResource.IfcLengthMeasure(s), 
					t => new MeasureResource.IfcLengthMeasure(t));
			} 
		}
	//## Custom code
	//##
	}
}