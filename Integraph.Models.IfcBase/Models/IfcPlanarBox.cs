using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplanarbox.htm" />
	/// </summary>
	public class IfcPlanarBox : IfcPlanarExtent
    {
	    /// <summary>
	    ///     Construct a IfcPlanarBox with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPlanarBox(IfcLengthMeasure sizeInX, IfcLengthMeasure sizeInY, IfcAxis2Placement placement) : base(
            sizeInX, sizeInY)
        {
            Placement = placement;
        }

        public IfcAxis2Placement Placement { get; set; }

        public new static IfcPlanarBox FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlanarBox>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                SizeInX != null ? SizeInX.ToStepValue() : "$",
                SizeInY != null ? SizeInY.ToStepValue() : "$",
                Placement != null ? Placement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}