using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertyabstraction.htm" />
	/// </summary>
	public abstract class IfcPropertyAbstraction : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcPropertyAbstraction with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyAbstraction()
        {
            HasExternalReferences = new List<IfcExternalReferenceRelationship>();
        }

        public List<IfcExternalReferenceRelationship> HasExternalReferences { get; set; } // inverse

        public static IfcPropertyAbstraction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyAbstraction>(json);
        }
    }
}