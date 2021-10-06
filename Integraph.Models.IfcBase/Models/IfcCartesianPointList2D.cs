using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesianpointlist2d.htm" />
	/// </summary>
	public class IfcCartesianPointList2D : IfcCartesianPointList
    {
	    /// <summary>
	    ///     Construct a IfcCartesianPointList2D with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianPointList2D(List<List<IfcLengthMeasure>> coordList)
        {
            CoordList = coordList;
        }

        public List<List<IfcLengthMeasure>> CoordList { get; set; }

        public new static IfcCartesianPointList2D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianPointList2D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CoordList != null ? CoordList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}