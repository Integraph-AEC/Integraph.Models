using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertytemplate.htm" />
	/// </summary>
	public abstract class IfcPropertyTemplate : IfcPropertyTemplateDefinition
    {
	    /// <summary>
	    ///     Construct a IfcPropertyTemplate with all required attributes.
	    /// </summary>
	    public IfcPropertyTemplate(IfcGloballyUniqueId globalId) : base(globalId)
        {
            PartOfComplexTemplate = new List<IfcComplexPropertyTemplate>();
            PartOfPsetTemplate = new List<IfcPropertySetTemplate>();
        }

	    /// <summary>
	    ///     Construct a IfcPropertyTemplate with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyTemplate(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
            PartOfComplexTemplate = new List<IfcComplexPropertyTemplate>();
            PartOfPsetTemplate = new List<IfcPropertySetTemplate>();
        }

        public List<IfcComplexPropertyTemplate> PartOfComplexTemplate { get; set; } // inverse
        public List<IfcPropertySetTemplate> PartOfPsetTemplate { get; set; } // inverse

        public new static IfcPropertyTemplate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyTemplate>(json);
        }
    }
}