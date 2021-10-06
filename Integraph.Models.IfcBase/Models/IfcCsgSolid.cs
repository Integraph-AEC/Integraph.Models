using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccsgsolid.htm" />
	/// </summary>
	public class IfcCsgSolid : IfcSolidModel
    {
	    /// <summary>
	    ///     Construct a IfcCsgSolid with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCsgSolid(IfcCsgSelect treeRootExpression)
        {
            TreeRootExpression = treeRootExpression;
        }

        public IfcCsgSelect TreeRootExpression { get; set; }

        public new static IfcCsgSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCsgSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {TreeRootExpression != null ? TreeRootExpression.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}