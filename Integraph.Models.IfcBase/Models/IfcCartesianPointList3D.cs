using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccartesianpointlist3d.htm" />
	/// </summary>
	public class IfcCartesianPointList3D : IfcCartesianPointList
    {
	    /// <summary>
	    ///     Construct a IfcCartesianPointList3D with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCartesianPointList3D(List<List<IfcLengthMeasure>> coordList)
        {
            CoordList = coordList;
        }

        public List<List<IfcLengthMeasure>> CoordList { get; set; }

        public new static IfcCartesianPointList3D FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCartesianPointList3D>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string> {CoordList != null ? CoordList.ToStepValue() : "$"};

            return string.Join(", ", parameters.ToArray());
        }
    }
}