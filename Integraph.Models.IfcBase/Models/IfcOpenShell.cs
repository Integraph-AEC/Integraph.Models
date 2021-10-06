using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcopenshell.htm" />
	/// </summary>
	public class IfcOpenShell : IfcConnectedFaceSet
    {
	    /// <summary>
	    ///     Construct a IfcOpenShell with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcOpenShell(List<IfcFace> cfsFaces) : base(cfsFaces)
        {
        }

        public new static IfcOpenShell FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcOpenShell>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CfsFaces != null ? CfsFaces.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}