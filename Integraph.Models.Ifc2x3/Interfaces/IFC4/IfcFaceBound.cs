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
	public partial class @IfcFaceBound : IIfcFaceBound
	{

		[CrossSchemaAttribute(typeof(IIfcFaceBound), 1)]
		IIfcLoop IIfcFaceBound.Bound 
		{ 
			get
			{
				return Bound;
			} 
			set
			{
				Bound = value as IfcLoop;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcFaceBound), 2)]
		Ifc4.MeasureResource.IfcBoolean IIfcFaceBound.Orientation 
		{ 
			get
			{
				//## Handle return of Orientation for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(Orientation);
			    //##
			} 
			set
			{
				Orientation = value;
				
			}
		}
	//## Custom code
	//##
	}
}