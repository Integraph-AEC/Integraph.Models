using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplanarextent.htm" />
	/// </summary>
	public class IfcPlanarExtent : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcPlanarExtent with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPlanarExtent(IfcLengthMeasure sizeInX, IfcLengthMeasure sizeInY)
        {
            SizeInX = sizeInX;
            SizeInY = sizeInY;
        }

        public IfcLengthMeasure SizeInX { get; set; }
        public IfcLengthMeasure SizeInY { get; set; }

        public new static IfcPlanarExtent FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlanarExtent>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            SizeInX != null ? SizeInX.ToStepValue() : "$",
	            SizeInY != null ? SizeInY.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}