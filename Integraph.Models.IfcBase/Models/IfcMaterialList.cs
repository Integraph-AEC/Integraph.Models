using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmateriallist.htm" />
	/// </summary>
	public class IfcMaterialList : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcMaterialList with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMaterialList(List<IfcMaterial> materials)
        {
            Materials = materials;
        }

        public List<IfcMaterial> Materials { get; set; }

        public static IfcMaterialList FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMaterialList>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Materials != null ? Materials.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}