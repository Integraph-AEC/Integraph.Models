using System;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsolidmodel.htm" />
	/// </summary>
	public abstract class IfcSolidModel : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcSolidModel with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSolidModel()
        {
        }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcSolidModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSolidModel>(json);
        }
    }
}