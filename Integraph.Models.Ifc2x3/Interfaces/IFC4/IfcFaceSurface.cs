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
namespace Integraph.Models.Ifc2x3.TopologyResource
{
	public partial class @IfcFaceSurface : IIfcFaceSurface
	{

		[CrossSchemaAttribute(typeof(IIfcFaceSurface), 2)]
		IIfcSurface IIfcFaceSurface.FaceSurface 
		{ 
			get
			{
				return FaceSurface;
			} 
			set
			{
				FaceSurface = value as GeometryResource.IfcSurface;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFaceSurface), 3)]
		Ifc4.MeasureResource.IfcBoolean IIfcFaceSurface.SameSense 
		{ 
			get
			{
				//## Handle return of SameSense for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(SameSense);
				//##
			} 
			set
			{
				SameSense = value;
				
			}
		}
	//## Custom code
	//##
	}
}