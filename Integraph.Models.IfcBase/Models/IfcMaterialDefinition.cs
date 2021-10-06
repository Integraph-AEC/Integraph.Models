using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialdefinition.htm" />
	/// </summary>
	public abstract class IfcMaterialDefinition : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMaterialDefinition with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialDefinition()
        {
            AssociatedTo = new List<IfcRelAssociatesMaterial>();
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
            HasProperties = new List<IfcMaterialProperties>();
        }

        public List<IfcRelAssociatesMaterial> AssociatedTo { get; set; } // inverse
        public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; } // inverse
        public List<IfcMaterialProperties> HasProperties { get; set; } // inverse

        public static IfcMaterialDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialDefinition>(json);
        }
    }
}