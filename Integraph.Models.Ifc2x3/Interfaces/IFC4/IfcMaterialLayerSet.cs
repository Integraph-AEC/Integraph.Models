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
namespace Integraph.Models.Ifc2x3.MaterialResource
{
	public partial class @IfcMaterialLayerSet : IIfcMaterialLayerSet
	{

		[CrossSchemaAttribute(typeof(IIfcMaterialLayerSet), 1)]
		IItemSet<IIfcMaterialLayer> IIfcMaterialLayerSet.MaterialLayers 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcMaterialLayer, IIfcMaterialLayer>(MaterialLayers);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcMaterialLayerSet), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterialLayerSet.LayerSetName 
		{ 
			get
			{
				if (!LayerSetName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LayerSetName.Value);
			} 
			set
			{
				LayerSetName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _description;


		[CrossSchemaAttribute(typeof(IIfcMaterialLayerSet), 3)]
		Ifc4.MeasureResource.IfcText? IIfcMaterialLayerSet.Description 
		{ 
			get
			{
				return _description;
			} 
			set
			{
				SetValue(v => _description = v, _description, value, "Description", -3);
				
			}
		}
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialDefinition.AssociatedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesMaterial>(e => (e.RelatingMaterial as IfcMaterialLayerSet) == this, "RelatingMaterial", this);
			} 
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcMaterialDefinition.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcMaterialProperties> IIfcMaterialDefinition.HasProperties 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialProperties>(e => (e.Material as IfcMaterialLayerSet) == this, "Material", this);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure IIfcMaterialLayerSet.TotalThickness 
		{
			get 
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(TotalThickness);
			}
		}

	//## Custom code
	//##
	}
}