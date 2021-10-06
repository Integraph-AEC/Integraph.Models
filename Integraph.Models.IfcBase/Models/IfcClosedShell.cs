using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcclosedshell.htm" />
	/// </summary>
	public class IfcClosedShell : IfcConnectedFaceSet
    {
	    /// <summary>
	    ///     Construct a IfcClosedShell with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcClosedShell(List<IfcFace> cfsFaces) : base(cfsFaces)
        {
        }

        public new static IfcClosedShell FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcClosedShell>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CfsFaces != null ? CfsFaces.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}