using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsweptsurface.htm" />
	/// </summary>
	public abstract class IfcSweptSurface : IfcSurface
    {
	    /// <summary>
	    ///     Construct a IfcSweptSurface with all required attributes.
	    /// </summary>
	    public IfcSweptSurface(IfcProfileDef sweptCurve)
        {
            SweptCurve = sweptCurve;
        }

	    /// <summary>
	    ///     Construct a IfcSweptSurface with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSweptSurface(IfcProfileDef sweptCurve, IfcAxis2Placement3D position)
        {
            SweptCurve = sweptCurve;
            Position = position;
        }

        public IfcProfileDef SweptCurve { get; set; }
        public IfcAxis2Placement3D Position { get; set; } // optional

        public new static IfcSweptSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSweptSurface>(json);
        }
    }
}