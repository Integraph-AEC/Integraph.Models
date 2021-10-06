using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccolourrgblist.htm" />
	/// </summary>
	public class IfcColourRgbList : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcColourRgbList with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcColourRgbList(List<List<IfcNormalisedRatioMeasure>> colourList)
        {
            ColourList = colourList;
        }

        public List<List<IfcNormalisedRatioMeasure>> ColourList { get; set; }

        public new static IfcColourRgbList FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcColourRgbList>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {ColourList != null ? ColourList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}