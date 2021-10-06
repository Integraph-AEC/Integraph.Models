using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcexternallydefinedsurfacestyle.htm" />
	/// </summary>
	public class IfcExternallyDefinedSurfaceStyle : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcExternallyDefinedSurfaceStyle with all required attributes.
	    /// </summary>
	    public IfcExternallyDefinedSurfaceStyle()
        {
        }

	    /// <summary>
	    ///     Construct a IfcExternallyDefinedSurfaceStyle with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcExternallyDefinedSurfaceStyle(IfcUriReference location, IfcIdentifier identification, IfcLabel name) :
            base(location, identification, name)
        {
        }

        public new static IfcExternallyDefinedSurfaceStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcExternallyDefinedSurfaceStyle>(json);
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