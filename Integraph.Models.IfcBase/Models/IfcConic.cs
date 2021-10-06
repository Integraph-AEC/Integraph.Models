using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconic.htm" />
	/// </summary>
	public abstract class IfcConic : IfcCurve
    {
	    /// <summary>
	    ///     Construct a IfcConic with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConic(IfcAxis2Placement position)
        {
            Position = position;
        }

        public IfcAxis2Placement Position { get; set; }

        public new static IfcConic FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConic>(json);
        }
    }
}