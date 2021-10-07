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
	public partial class @IfcObjectDefinition : IIfcObjectDefinition
	{
		IEnumerable<IIfcRelAssigns> IIfcObjectDefinition.HasAssignments 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssigns>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.Nests 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelNests>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelNests> IIfcObjectDefinition.IsNestedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelNests>(e => (e.RelatingObject as IfcObjectDefinition) == this, "RelatingObject", this);
			} 
		}
		IEnumerable<IIfcRelDeclares> IIfcObjectDefinition.HasContext 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelDeclares>(e => e.RelatedDefinitions != null &&  e.RelatedDefinitions.Contains(this), "RelatedDefinitions", this);
			} 
		}
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.IsDecomposedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAggregates>(e => (e.RelatingObject as IfcObjectDefinition) == this, "RelatingObject", this);
			} 
		}
		IEnumerable<IIfcRelAggregates> IIfcObjectDefinition.Decomposes 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAggregates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
		IEnumerable<IIfcRelAssociates> IIfcObjectDefinition.HasAssociations 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociates>(e => e.RelatedObjects != null &&  e.RelatedObjects.Contains(this), "RelatedObjects", this);
			} 
		}
	//## Custom code
        public IIfcValue this[string property]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(property))
                    return null;

                List<IIfcPropertySetDefinition> pSets = null;
                var obj = this as IIfcObject;
                if (obj != null)
                    pSets = obj.IsDefinedBy.SelectMany(GetDefinitions).Where(d => d != null).ToList();

                var type = this as IIfcTypeObject;
                if (type != null)
                    pSets = type.HasPropertySets.ToList();

                var ctx = this as IIfcContext;
                if (ctx != null)
                    pSets = ctx.IsDefinedBy.SelectMany(GetDefinitions).Where(d => d != null).ToList();

                if (pSets == null || !pSets.Any())
                    return null;

                var parts = property.Split('.');
                if (parts.Length == 2)
                {
                    pSets = pSets.Where(p => p.Name == parts[0]).ToList();
                    property = parts[1];
                }

                var prop =
                    pSets.OfType<IfcPropertySet>()
                        .SelectMany(p => p.HasProperties.OfType<IIfcPropertySingleValue>())
                        .FirstOrDefault(p => p.Name == property);
                if (prop != null)
                    return prop.NominalValue;

                var quant = pSets.OfType<IIfcElementQuantity>()
                        .SelectMany(p => p.Quantities.OfType<IIfcPhysicalSimpleQuantity>())
                        .FirstOrDefault(p => p.Name == property);
                if (quant == null)
                    return null;

                var area = quant as IIfcQuantityArea;
                if (area != null)
                    return area.AreaValue;
                var count = quant as IIfcQuantityCount;
                if (count != null)
                    return count.CountValue;
                var length = quant as IIfcQuantityLength;
                if (length != null)
                    return length.LengthValue;
                var time = quant as IIfcQuantityTime;
                if (time != null)
                    return time.TimeValue;
                var volume = quant as IIfcQuantityVolume;
                if (volume != null)
                    return volume.VolumeValue;
                var weight = quant as IIfcQuantityWeight;
                if (weight != null)
                    return weight.WeightValue;

                return null;
            }
        }

        private static IEnumerable<IIfcPropertySetDefinition> GetDefinitions(IIfcRelDefinesByProperties r)
        {
            if (r.RelatingPropertyDefinition == null)
                return null;
            var defSelect = r.RelatingPropertyDefinition;
            var def = defSelect as IIfcPropertySetDefinition;
            return def != null ? new[] { def } : null;
        }
	//##
	}
}