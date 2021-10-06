using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmaterialusagedefinition.htm" />
	/// </summary>
	public abstract class IfcMaterialUsageDefinition : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMaterialUsageDefinition with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialUsageDefinition()
        {
            AssociatedTo = new List<IfcRelAssociatesMaterial>();
        }

        public List<IfcRelAssociatesMaterial> AssociatedTo { get; set; } // inverse

        public static IfcMaterialUsageDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialUsageDefinition>(json);
        }
    }
}