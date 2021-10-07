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
	public partial class @IfcSpatialStructureElement : IIfcSpatialStructureElement
	{

		[CrossSchemaAttribute(typeof(IIfcSpatialStructureElement), 9)]
		Ifc4.Interfaces.IfcElementCompositionEnum? IIfcSpatialStructureElement.CompositionType 
		{ 
			get
			{
				//## Custom code to handle enumeration of CompositionType
				//##
				switch (CompositionType)
				{
					case IfcElementCompositionEnum.COMPLEX:
						return Ifc4.Interfaces.IfcElementCompositionEnum.COMPLEX;
					case IfcElementCompositionEnum.ELEMENT:
						return Ifc4.Interfaces.IfcElementCompositionEnum.ELEMENT;
					case IfcElementCompositionEnum.PARTIAL:
						return Ifc4.Interfaces.IfcElementCompositionEnum.PARTIAL;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of CompositionType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcElementCompositionEnum.COMPLEX:
						CompositionType = IfcElementCompositionEnum.COMPLEX;
						return;
					case Ifc4.Interfaces.IfcElementCompositionEnum.ELEMENT:
						CompositionType = IfcElementCompositionEnum.ELEMENT;
						return;
					case Ifc4.Interfaces.IfcElementCompositionEnum.PARTIAL:
						CompositionType = IfcElementCompositionEnum.PARTIAL;
						return;
					case null:
						CompositionType = IfcElementCompositionEnum.ELEMENT;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSpatialStructureElement), 8)]
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
				return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(e => (e.RelatingStructure as IfcSpatialStructureElement) == this, "RelatingStructure", this);
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
				return Model.Instances.Where<IIfcRelReferencedInSpatialStructure>(e => (e.RelatingStructure as IfcSpatialStructureElement) == this, "RelatingStructure", this);
			} 
		}
	//## Custom code
	//##
	}
}