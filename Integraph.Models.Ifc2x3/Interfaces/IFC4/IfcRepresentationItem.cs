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
	public partial class @IfcRepresentationItem : IIfcRepresentationItem
	{
		IEnumerable<IIfcPresentationLayerAssignment> IIfcRepresentationItem.LayerAssignment 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this), "AssignedItems", this);
			} 
		}
		IEnumerable<IIfcStyledItem> IIfcRepresentationItem.StyledByItem 
		{ 
			get
			{
				return Model.Instances.Where<IIfcStyledItem>(e => (e.Item as IfcRepresentationItem) == this, "Item", this);
			} 
		}
	//## Custom code
	//##
	}
}