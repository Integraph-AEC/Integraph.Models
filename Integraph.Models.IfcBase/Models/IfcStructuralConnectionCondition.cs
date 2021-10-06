using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralconnectioncondition.htm" />
	/// </summary>
	public abstract class IfcStructuralConnectionCondition : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcStructuralConnectionCondition with all required attributes.
	    /// </summary>
	    public IfcStructuralConnectionCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcStructuralConnectionCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralConnectionCondition(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; } // optional

        public static IfcStructuralConnectionCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralConnectionCondition>(json);
        }
    }
}