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
	public partial class @IfcEdgeLoop : IIfcEdgeLoop
	{

		[CrossSchemaAttribute(typeof(IIfcEdgeLoop), 1)]
		IItemSet<IIfcOrientedEdge> IIfcEdgeLoop.EdgeList 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcOrientedEdge, IIfcOrientedEdge>(EdgeList);
			} 
		}
		Ifc4.MeasureResource.IfcInteger IIfcEdgeLoop.Ne 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcInteger(Ne);
			}
		}

	//## Custom code
	//##
	}
}