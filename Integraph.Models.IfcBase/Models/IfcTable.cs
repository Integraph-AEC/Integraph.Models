using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctable.htm" />
	/// </summary>
	public class IfcTable : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcTable with all required attributes.
	    /// </summary>
	    public IfcTable()
        {
            Rows = new List<IfcTableRow>();
            Columns = new List<IfcTableColumn>();
        }

	    /// <summary>
	    ///     Construct a IfcTable with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTable(IfcLabel name, List<IfcTableRow> rows, List<IfcTableColumn> columns)
        {
            Name = name;
            Rows = rows;
            Columns = columns;
        }

        public IfcLabel Name { get; set; } // optional
        public List<IfcTableRow> Rows { get; set; } // optional
        public List<IfcTableColumn> Columns { get; set; } // optional

        [JsonIgnore]
        public IfcInteger NumberOfCellsInRow =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for NumberOfCellsInRow."); // derived

        [JsonIgnore]
        public IfcInteger NumberOfHeadings =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for NumberOfHeadings."); // derived

        [JsonIgnore]
        public IfcInteger NumberOfDataRows =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for NumberOfDataRows."); // derived

        public static IfcTable FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTable>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Rows != null ? Rows.ToStepValue() : "$",
                Columns != null ? Columns.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}