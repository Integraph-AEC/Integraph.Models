using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboundarycondition.htm" />
	/// </summary>
	public abstract class IfcBoundaryCondition : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcBoundaryCondition with all required attributes.
	    /// </summary>
	    public IfcBoundaryCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcBoundaryCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoundaryCondition(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; } // optional

        public static IfcBoundaryCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoundaryCondition>(json);
        }
    }
}