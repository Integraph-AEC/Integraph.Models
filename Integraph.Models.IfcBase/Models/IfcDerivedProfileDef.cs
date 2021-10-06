using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcderivedprofiledef.htm" />
	/// </summary>
	public class IfcDerivedProfileDef : IfcProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcDerivedProfileDef with all required attributes.
	    /// </summary>
	    public IfcDerivedProfileDef(IfcProfileTypeEnum profileType, IfcProfileDef parentProfile,
            IfcCartesianTransformationOperator2D op) : base(profileType)
        {
            ParentProfile = parentProfile;
            Operator = op;
        }

	    /// <summary>
	    ///     Construct a IfcDerivedProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDerivedProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcProfileDef parentProfile,
            IfcCartesianTransformationOperator2D op, IfcLabel label) : base(profileType, profileName)
        {
            ParentProfile = parentProfile;
            Operator = op;
            Label = label;
        }

        public IfcProfileDef ParentProfile { get; set; }
        public IfcCartesianTransformationOperator2D Operator { get; set; }
        public IfcLabel Label { get; set; } // optional

        public new static IfcDerivedProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDerivedProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ProfileType.ToStepValue(),
                ProfileName != null ? ProfileName.ToStepValue() : "$",
                ParentProfile != null ? ParentProfile.ToStepValue() : "$",
                Operator != null ? Operator.ToStepValue() : "$",
                Label != null ? Label.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}