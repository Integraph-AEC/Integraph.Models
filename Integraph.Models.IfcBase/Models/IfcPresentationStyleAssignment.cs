using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentationstyleassignment.htm" />
	/// </summary>
	public class IfcPresentationStyleAssignment : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPresentationStyleAssignment with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPresentationStyleAssignment(List<IfcPresentationStyleSelect> styles)
        {
            Styles = styles;
        }

        public List<IfcPresentationStyleSelect> Styles { get; set; }

        public static IfcPresentationStyleAssignment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentationStyleAssignment>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {Styles != null ? Styles.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}