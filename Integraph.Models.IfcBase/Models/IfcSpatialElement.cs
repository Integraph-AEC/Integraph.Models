using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspatialelement.htm" />
	/// </summary>
	public abstract class IfcSpatialElement : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcSpatialElement with all required attributes.
	    /// </summary>
	    public IfcSpatialElement(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ContainsElements = new List<IfcRelContainedInSpatialStructure>();
            ServicedBySystems = new List<IfcRelServicesBuildings>();
            ReferencesElements = new List<IfcRelReferencedInSpatialStructure>();
        }

	    /// <summary>
	    ///     Construct a IfcSpatialElement with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSpatialElement(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcLabel longName) : base(globalId, ownerHistory, name,
            description, objectType, objectPlacement, representation)
        {
            ContainsElements = new List<IfcRelContainedInSpatialStructure>();
            ServicedBySystems = new List<IfcRelServicesBuildings>();
            ReferencesElements = new List<IfcRelReferencedInSpatialStructure>();

            LongName = longName;
        }

        public IfcLabel LongName { get; set; } // optional
        public List<IfcRelContainedInSpatialStructure> ContainsElements { get; set; } // inverse
        public List<IfcRelServicesBuildings> ServicedBySystems { get; set; } // inverse
        public List<IfcRelReferencedInSpatialStructure> ReferencesElements { get; set; } // inverse

        public new static IfcSpatialElement FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpatialElement>(json);
        }
    }
}