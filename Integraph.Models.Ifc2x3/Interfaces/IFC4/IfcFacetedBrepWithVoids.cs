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
	public partial class @IfcFacetedBrepWithVoids : IIfcFacetedBrepWithVoids
	{

		[CrossSchemaAttribute(typeof(IIfcFacetedBrepWithVoids), 2)]
		IItemSet<IIfcClosedShell> IIfcFacetedBrepWithVoids.Voids 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<TopologyResource.IfcClosedShell, IIfcClosedShell>(Voids);
			} 
		}
	//## Custom code
	//##
	}
}