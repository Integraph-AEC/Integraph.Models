using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrepresentationcontext.htm" />
	/// </summary>
	public abstract class IfcRepresentationContext : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRepresentationContext with all required attributes.
	    /// </summary>
	    public IfcRepresentationContext()
        {
            RepresentationsInContext = new List<IfcRepresentation>();
        }

	    /// <summary>
	    ///     Construct a IfcRepresentationContext with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRepresentationContext(IfcLabel contextIdentifier, IfcLabel contextType)
        {
            RepresentationsInContext = new List<IfcRepresentation>();

            ContextIdentifier = contextIdentifier;
            ContextType = contextType;
        }

        public IfcLabel ContextIdentifier { get; set; } // optional
        public IfcLabel ContextType { get; set; } // optional
        public List<IfcRepresentation> RepresentationsInContext { get; set; } // inverse

        public static IfcRepresentationContext FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRepresentationContext>(json);
        }
    }
}