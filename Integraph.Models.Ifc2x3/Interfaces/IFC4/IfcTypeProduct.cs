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
namespace Integraph.Models.Ifc2x3.Kernel
{
	public partial class @IfcTypeProduct : IIfcTypeProduct
	{

		[CrossSchemaAttribute(typeof(IIfcTypeProduct), 7)]
		IItemSet<IIfcRepresentationMap> IIfcTypeProduct.RepresentationMaps 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<GeometryResource.IfcRepresentationMap, IIfcRepresentationMap>(RepresentationMaps);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcTypeProduct), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcTypeProduct.Tag 
		{ 
			get
			{
				if (!Tag.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Tag.Value);
			} 
			set
			{
				Tag = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcRelAssignsToProduct> IIfcTypeProduct.ReferencedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToProduct>(e => (e.RelatingProduct as IfcTypeProduct) == this, "RelatingProduct", this);
			} 
		}
	//## Custom code
	//##
	}
}