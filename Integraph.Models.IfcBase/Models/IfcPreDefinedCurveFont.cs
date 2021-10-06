using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpredefinedcurvefont.htm" />
	/// </summary>
	public abstract class IfcPreDefinedCurveFont : IfcPreDefinedItem
    {
	    /// <summary>
	    ///     Construct a IfcPreDefinedCurveFont with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPreDefinedCurveFont(IfcLabel name) : base(name)
        {
        }

        public new static IfcPreDefinedCurveFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPreDefinedCurveFont>(json);
        }
    }
}