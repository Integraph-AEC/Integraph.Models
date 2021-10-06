using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmirroredprofiledef.htm" />
	/// </summary>
	public class IfcMirroredProfileDef : IfcDerivedProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcMirroredProfileDef with all required attributes.
	    /// </summary>
	    public IfcMirroredProfileDef(IfcProfileTypeEnum profileType, IfcProfileDef parentProfile,
            IfcCartesianTransformationOperator2D op) : base(profileType, parentProfile, op)
        {
        }

	    /// <summary>
	    ///     Construct a IfcMirroredProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMirroredProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcProfileDef parentProfile,
            IfcCartesianTransformationOperator2D op, IfcLabel label) : base(profileType, profileName, parentProfile, op,
            label)
        {
        }

        [JsonIgnore]
        public new IfcCartesianTransformationOperator2D Operator =>
            throw new NotImplementedException("Derived property logic has been implemented for Operator."); // derived

        public new static IfcMirroredProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMirroredProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$",
	            ParentProfile != null ? ParentProfile.ToStepValue() : "$",
	            "*",
	            Label != null ? Label.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}