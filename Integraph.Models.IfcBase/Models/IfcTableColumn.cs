using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctablecolumn.htm" />
	/// </summary>
	public class IfcTableColumn : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTableColumn with all required attributes.
	    /// </summary>
	    public IfcTableColumn()
        {
        }

	    /// <summary>
	    ///     Construct a IfcTableColumn with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTableColumn(IfcIdentifier identifier, IfcLabel name, IfcText description, IfcUnit unit,
            IfcReference referencePath)
        {
            Identifier = identifier;
            Name = name;
            Description = description;
            Unit = unit;
            ReferencePath = referencePath;
        }

        public IfcIdentifier Identifier { get; set; } // optional
        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcUnit Unit { get; set; } // optional
        public IfcReference ReferencePath { get; set; } // optional

        public static IfcTableColumn FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTableColumn>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Identifier != null ? Identifier.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            ReferencePath != null ? ReferencePath.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}