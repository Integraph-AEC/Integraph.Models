using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctablerow.htm" />
	/// </summary>
	public class IfcTableRow : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTableRow with all required attributes.
	    /// </summary>
	    public IfcTableRow()
        {
            RowCells = new List<IfcValue>();
        }

	    /// <summary>
	    ///     Construct a IfcTableRow with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTableRow(List<IfcValue> rowCells, IfcBoolean isHeading)
        {
            RowCells = rowCells;
            IsHeading = isHeading;
        }

        public List<IfcValue> RowCells { get; set; } // optional
        public IfcBoolean IsHeading { get; set; } // optional

        public static IfcTableRow FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTableRow>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            RowCells != null ? RowCells.ToStepValue() : "$",
	            IsHeading != null ? IsHeading.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}