using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstylemodel.htm" />
	/// </summary>
	public abstract class IfcStyleModel : IfcRepresentation
    {
	    /// <summary>
	    ///     Construct a IfcStyleModel with all required attributes.
	    /// </summary>
	    public IfcStyleModel(IfcRepresentationContext contextOfItems, List<IfcRepresentationItem> items) : base(
            contextOfItems, items)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStyleModel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStyleModel(IfcRepresentationContext contextOfItems, IfcLabel representationIdentifier,
            IfcLabel representationType, List<IfcRepresentationItem> items) : base(contextOfItems,
            representationIdentifier, representationType, items)
        {
        }

        public new static IfcStyleModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStyleModel>(json);
        }
    }
}