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
	public partial class @IfcCurveBoundedPlane : IIfcCurveBoundedPlane
	{

		[CrossSchemaAttribute(typeof(IIfcCurveBoundedPlane), 1)]
		IIfcPlane IIfcCurveBoundedPlane.BasisSurface 
		{ 
			get
			{
				return BasisSurface;
			} 
			set
			{
				BasisSurface = value as IfcPlane;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurveBoundedPlane), 2)]
		IIfcCurve IIfcCurveBoundedPlane.OuterBoundary 
		{ 
			get
			{
				return OuterBoundary;
			} 
			set
			{
				OuterBoundary = value as IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCurveBoundedPlane), 3)]
		IItemSet<IIfcCurve> IIfcCurveBoundedPlane.InnerBoundaries 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcCurve, IIfcCurve>(InnerBoundaries);
			} 
		}
	//## Custom code
	//##
	}
}