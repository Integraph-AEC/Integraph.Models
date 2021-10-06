using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcellipseprofiledef.htm" />
	/// </summary>
	public class IfcEllipseProfileDef : IfcParameterizedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcEllipseProfileDef with all required attributes.
	    /// </summary>
	    public IfcEllipseProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure semiAxis1,
            IfcPositiveLengthMeasure semiAxis2) : base(profileType)
        {
            SemiAxis1 = semiAxis1;
            SemiAxis2 = semiAxis2;
        }

	    /// <summary>
	    ///     Construct a IfcEllipseProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcEllipseProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcAxis2Placement2D position,
            IfcPositiveLengthMeasure semiAxis1, IfcPositiveLengthMeasure semiAxis2) : base(profileType, profileName,
            position)
        {
            SemiAxis1 = semiAxis1;
            SemiAxis2 = semiAxis2;
        }

        public IfcPositiveLengthMeasure SemiAxis1 { get; set; }
        public IfcPositiveLengthMeasure SemiAxis2 { get; set; }

        public new static IfcEllipseProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcEllipseProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                Position != null ? Position.ToStepValue() : "$",
                SemiAxis1 != null ? SemiAxis1.ToStepValue() : "$",
                SemiAxis2 != null ? SemiAxis2.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}