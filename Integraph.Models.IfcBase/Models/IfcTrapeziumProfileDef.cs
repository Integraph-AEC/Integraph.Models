using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctrapeziumprofiledef.htm" />
	/// </summary>
	public class IfcTrapeziumProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcTrapeziumProfileDef with all required attributes.
	    /// </summary>
	    public IfcTrapeziumProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure bottomXDim,
            IfcPositiveLengthMeasure topXDim, IfcPositiveLengthMeasure yDim, IfcLengthMeasure topXOffset) : base(
            profileType)
        {
            BottomXDim = bottomXDim;
            TopXDim = topXDim;
            YDim = yDim;
            TopXOffset = topXOffset;
        }

	    /// <summary>
	    ///     Construct a IfcTrapeziumProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTrapeziumProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position, IfcPositiveLengthMeasure bottomXDim, IfcPositiveLengthMeasure topXDim,
            IfcPositiveLengthMeasure yDim, IfcLengthMeasure topXOffset) : base(profileType, profileName, position)
        {
            BottomXDim = bottomXDim;
            TopXDim = topXDim;
            YDim = yDim;
            TopXOffset = topXOffset;
        }

        public IfcPositiveLengthMeasure BottomXDim { get; set; }
        public IfcPositiveLengthMeasure TopXDim { get; set; }
        public IfcPositiveLengthMeasure YDim { get; set; }
        public IfcLengthMeasure TopXOffset { get; set; }

        public new static IfcTrapeziumProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTrapeziumProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                BottomXDim != null ? BottomXDim.ToStepValue() : "$",
                TopXDim != null ? TopXDim.ToStepValue() : "$",
                YDim != null ? YDim.ToStepValue() : "$",
                TopXOffset != null ? TopXOffset.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}