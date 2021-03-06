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
	public partial class @IfcSite : IIfcSite
	{

		[CrossSchemaAttribute(typeof(IIfcSite), 10)]
		Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure? IIfcSite.RefLatitude 
		{ 
			get
			{
				if (!RefLatitude.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure(RefLatitude.Value);
			} 
			set
			{
				RefLatitude = value.HasValue ? 
					new MeasureResource.IfcCompoundPlaneAngleMeasure(value.Value) :  
					 new MeasureResource.IfcCompoundPlaneAngleMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSite), 11)]
		Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure? IIfcSite.RefLongitude 
		{ 
			get
			{
				if (!RefLongitude.HasValue) return null;
				return new Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure(RefLongitude.Value);
			} 
			set
			{
				RefLongitude = value.HasValue ? 
					new MeasureResource.IfcCompoundPlaneAngleMeasure(value.Value) :  
					 new MeasureResource.IfcCompoundPlaneAngleMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSite), 12)]
		Ifc4.MeasureResource.IfcLengthMeasure? IIfcSite.RefElevation 
		{ 
			get
			{
				if (!RefElevation.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLengthMeasure(RefElevation.Value);
			} 
			set
			{
				RefElevation = value.HasValue ? 
					new MeasureResource.IfcLengthMeasure(value.Value) :  
					 new MeasureResource.IfcLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSite), 13)]
		Ifc4.MeasureResource.IfcLabel? IIfcSite.LandTitleNumber 
		{ 
			get
			{
				if (!LandTitleNumber.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LandTitleNumber.Value);
			} 
			set
			{
				LandTitleNumber = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSite), 14)]
		IIfcPostalAddress IIfcSite.SiteAddress 
		{ 
			get
			{
				return SiteAddress;
			} 
			set
			{
				SiteAddress = value as ActorResource.IfcPostalAddress;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSite), 8)]
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
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcSite) == this, "RelatingStructure", this);
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
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcSite) == this, "RelatingStructure", this);
			} 
		}
	//## Custom code
	//##
	}
}