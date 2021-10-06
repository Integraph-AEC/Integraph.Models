using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectedfaceset.htm" />
	/// </summary>
	public class IfcConnectedFaceSet : IfcTopologicalRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcConnectedFaceSet with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectedFaceSet(List<IfcFace> cfsFaces)
        {
            CfsFaces = cfsFaces;
        }

        public List<IfcFace> CfsFaces { get; set; }

        public new static IfcConnectedFaceSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectedFaceSet>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CfsFaces != null ? CfsFaces.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}