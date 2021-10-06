using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcarbitraryclosedprofiledef.htm" />
	/// </summary>
	public class IfcArbitraryClosedProfileDef : IfcProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcArbitraryClosedProfileDef with all required attributes.
	    /// </summary>
	    public IfcArbitraryClosedProfileDef(IfcProfileTypeEnum profileType, IfcCurve outerCurve) : base(profileType)
        {
            OuterCurve = outerCurve;
        }

	    /// <summary>
	    ///     Construct a IfcArbitraryClosedProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcArbitraryClosedProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName, IfcCurve outerCurve) :
            base(profileType, profileName)
        {
            OuterCurve = outerCurve;
        }

        public IfcCurve OuterCurve { get; set; }

        public new static IfcArbitraryClosedProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcArbitraryClosedProfileDef>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ProfileType.ToStepValue(),
	            ProfileName != null ? ProfileName.ToStepValue() : "$",
	            OuterCurve != null ? OuterCurve.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}