using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmanifoldsolidbrep.htm" />
	/// </summary>
	public abstract class IfcManifoldSolidBrep : IfcSolidModel
    {
	    /// <summary>
	    ///     Construct a IfcManifoldSolidBrep with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcManifoldSolidBrep(IfcClosedShell outer)
        {
            Outer = outer;
        }

        public IfcClosedShell Outer { get; set; }

        public new static IfcManifoldSolidBrep FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcManifoldSolidBrep>(json);
        }
    }
}