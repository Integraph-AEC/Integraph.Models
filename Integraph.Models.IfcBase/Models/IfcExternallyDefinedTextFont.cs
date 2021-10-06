using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternallydefinedtextfont.htm" />
	/// </summary>
	public class IfcExternallyDefinedTextFont : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcExternallyDefinedTextFont with all required attributes.
	    /// </summary>
	    public IfcExternallyDefinedTextFont()
        {
        }

	    /// <summary>
	    ///     Construct a IfcExternallyDefinedTextFont with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternallyDefinedTextFont(IfcUriReference location, IfcIdentifier identification, IfcLabel name) :
            base(location, identification, name)
        {
        }

        public new static IfcExternallyDefinedTextFont FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternallyDefinedTextFont>(json);
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