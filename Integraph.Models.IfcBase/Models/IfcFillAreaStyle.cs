using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfillareastyle.htm" />
	/// </summary>
	public class IfcFillAreaStyle : IfcPresentationStyle
    {
	    /// <summary>
	    ///     Construct a IfcFillAreaStyle with all required attributes.
	    /// </summary>
	    public IfcFillAreaStyle(List<IfcFillStyleSelect> fillStyles)
        {
            FillStyles = fillStyles;
        }

	    /// <summary>
	    ///     Construct a IfcFillAreaStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFillAreaStyle(IfcLabel name, List<IfcFillStyleSelect> fillStyles, IfcBoolean modelorDraughting) :
            base(name)
        {
            FillStyles = fillStyles;
            ModelorDraughting = modelorDraughting;
        }

        public List<IfcFillStyleSelect> FillStyles { get; set; }
        public IfcBoolean ModelorDraughting { get; set; } // optional

        public new static IfcFillAreaStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFillAreaStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            FillStyles != null ? FillStyles.ToStepValue() : "$",
	            ModelorDraughting != null ? ModelorDraughting.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}