using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctypeproduct.htm" />
	/// </summary>
	public class IfcTypeProduct : IfcTypeObject
    {
	    /// <summary>
	    ///     Construct a IfcTypeProduct with all required attributes.
	    /// </summary>
	    public IfcTypeProduct(IfcGloballyUniqueId globalId) : base(globalId)
        {
            RepresentationMaps = new List<IfcRepresentationMap>();
            ReferencedBy = new List<IfcRelAssignsToProduct>();
        }

	    /// <summary>
	    ///     Construct a IfcTypeProduct with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTypeProduct(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag) : base(globalId, ownerHistory, name,
            description, applicableOccurrence, hasPropertySets)
        {
            ReferencedBy = new List<IfcRelAssignsToProduct>();

            RepresentationMaps = representationMaps;
            Tag = tag;
        }

        public List<IfcRepresentationMap> RepresentationMaps { get; set; } // optional
        public IfcLabel Tag { get; set; } // optional
        public List<IfcRelAssignsToProduct> ReferencedBy { get; set; } // inverse

        public new static IfcTypeProduct FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTypeProduct>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
	            HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
	            RepresentationMaps != null ? RepresentationMaps.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}