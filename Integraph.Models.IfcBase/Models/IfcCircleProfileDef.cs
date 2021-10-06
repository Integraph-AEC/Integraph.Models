using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccircleprofiledef.htm" />
	/// </summary>
	public class IfcCircleProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcCircleProfileDef with all required attributes.
	    /// </summary>
	    public IfcCircleProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure radius) : base(profileType)
        {
            Radius = radius;
        }

	    /// <summary>
	    ///     Construct a IfcCircleProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCircleProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure radius) : base(profileType, profileName, position)
        {
            Radius = radius;
        }

        public IfcPositiveLengthMeasure Radius { get; set; }

        public new static IfcCircleProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCircleProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$",
	            Position != null ? Position.ToStepValue() : "$",
	            Radius != null ? Radius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}