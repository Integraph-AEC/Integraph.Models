using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternallydefinedhatchstyle.htm" />
	/// </summary>
	public class IfcExternallyDefinedHatchStyle : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcExternallyDefinedHatchStyle with all required attributes.
	    /// </summary>
	    public IfcExternallyDefinedHatchStyle()
        {
        }

	    /// <summary>
	    ///     Construct a IfcExternallyDefinedHatchStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternallyDefinedHatchStyle(IfcUriReference location, IfcIdentifier identification, IfcLabel name) :
            base(location, identification, name)
        {
        }

        public new static IfcExternallyDefinedHatchStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternallyDefinedHatchStyle>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}