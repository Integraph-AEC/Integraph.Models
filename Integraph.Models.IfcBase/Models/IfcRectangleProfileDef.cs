using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrectangleprofiledef.htm" />
	/// </summary>
	public class IfcRectangleProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcRectangleProfileDef with all required attributes.
	    /// </summary>
	    public IfcRectangleProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure xDim,
            IfcPositiveLengthMeasure yDim) : base(profileType)
        {
            XDim = xDim;
            YDim = yDim;
        }

	    /// <summary>
	    ///     Construct a IfcRectangleProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRectangleProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure xDim, IfcPositiveLengthMeasure yDim) : base(
            profileType, profileName, position)
        {
            XDim = xDim;
            YDim = yDim;
        }

        public IfcPositiveLengthMeasure XDim { get; set; }
        public IfcPositiveLengthMeasure YDim { get; set; }

        public new static IfcRectangleProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRectangleProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                XDim != null ? XDim.ToStepValue() : "$",
                YDim != null ? YDim.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}