using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcparameterizedprofiledef.htm" />
	/// </summary>
	public abstract class IfcParameterizedProfileDef : IfcProfileDef
    {
	    /// <summary>
	    ///     Construct a IfcParameterizedProfileDef with all required attributes.
	    /// </summary>
	    public IfcParameterizedProfileDef(IfcProfileTypeEnum profileType) : base(profileType)
        {
        }

	    /// <summary>
	    ///     Construct a IfcParameterizedProfileDef with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcParameterizedProfileDef(IfcProfileTypeEnum profileType, IfcLabel profileName,
            IfcAxis2Placement2D position) : base(profileType, profileName)
        {
            Position = position;
        }

        public IfcAxis2Placement2D Position { get; set; } // optional

        public new static IfcParameterizedProfileDef FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcParameterizedProfileDef>(json);
        }
    }
}