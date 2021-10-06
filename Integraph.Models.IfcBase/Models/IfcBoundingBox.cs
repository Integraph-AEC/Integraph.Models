using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundingbox.htm" />
	/// </summary>
	public class IfcBoundingBox : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcBoundingBox with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundingBox(IfcCartesianPoint corner, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim,
            IfcPositiveLengthMeasure zDim)
        {
            Corner = corner;
            XDim = xDim;
            YDim = yDim;
            ZDim = zDim;
        }

        public IfcCartesianPoint Corner { get; set; }
        public IfcPositiveLengthMeasure XDim { get; set; }
        public IfcPositiveLengthMeasure YDim { get; set; }
        public IfcPositiveLengthMeasure ZDim { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcBoundingBox FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundingBox>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Corner != null ? Corner.ToStepValue() : "$",
                XDim != null ? XDim.ToStepValue() : "$",
                YDim != null ? YDim.ToStepValue() : "$",
                ZDim != null ? ZDim.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}