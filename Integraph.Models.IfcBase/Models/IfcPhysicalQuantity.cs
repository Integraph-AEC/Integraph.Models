using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcphysicalquantity.htm" />
	/// </summary>
	public abstract class IfcPhysicalQuantity : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPhysicalQuantity with all required attributes.
	    /// </summary>
	    public IfcPhysicalQuantity(IfcLabel name)
        {
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
            PartOfComplex = new List<IfcPhysicalComplexQuantity>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcPhysicalQuantity with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPhysicalQuantity(IfcLabel name, IfcText description)
        {
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
            PartOfComplex = new List<IfcPhysicalComplexQuantity>();

            Name = name;
            Description = description;
        }

        public IfcLabel Name { get; set; }
        public IfcText Description { get; set; } // optional
        public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; } // inverse
        public List<IfcPhysicalComplexQuantity> PartOfComplex { get; set; } // inverse

        public static IfcPhysicalQuantity FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPhysicalQuantity>(json);
        }
    }
}