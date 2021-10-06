using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstyleditem.htm" />
	/// </summary>
	public class IfcStyledItem : IfcRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcStyledItem with all required attributes.
	    /// </summary>
	    public IfcStyledItem(List<IfcStyleAssignmentSelect> styles)
        {
            Styles = styles;
        }

	    /// <summary>
	    ///     Construct a IfcStyledItem with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStyledItem(IfcRepresentationItem item, List<IfcStyleAssignmentSelect> styles, IfcLabel name)
        {
            Item = item;
            Styles = styles;
            Name = name;
        }

        public IfcRepresentationItem Item { get; set; } // optional
        public List<IfcStyleAssignmentSelect> Styles { get; set; }
        public IfcLabel Name { get; set; } // optional

        public new static IfcStyledItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStyledItem>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Item != null ? Item.ToStepValue() : "$",
	            Styles != null ? Styles.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}