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
namespace Integraph.Models.Ifc2x3.ProductExtension
{
	public partial class @IfcBuildingStorey : IIfcBuildingStorey
	{

		[CrossSchemaAttribute(typeof(IIfcBuildingStorey), 10)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcBuildingStorey.Elevation 
		{ 
			get
			{
				if (!Elevation.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(Elevation.Value);
			} 
			set
			{
				Elevation = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBuildingStorey), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcSpatialElement.LongName 
		{ 
			get
			{
				if (!LongName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LongName.Value);
			} 
			set
			{
				LongName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcBuildingStorey) == this, "RelatingStructure", this);
			} 
		}
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this), "RelatedBuildings", this);
			} 
		}
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcBuildingStorey) == this, "RelatingStructure", this);
			} 
		}
	//## Custom code
	//##
	}
}