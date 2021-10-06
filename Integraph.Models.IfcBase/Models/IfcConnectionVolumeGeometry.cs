using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcconnectionvolumegeometry.htm" />
	/// </summary>
	public class IfcConnectionVolumeGeometry : IfcConnectionGeometry
    {
	    /// <summary>
	    ///     Construct a IfcConnectionVolumeGeometry with all required attributes.
	    /// </summary>
	    public IfcConnectionVolumeGeometry(IfcSolidOrShell volumeOnRelatingElement)
        {
            VolumeOnRelatingElement = volumeOnRelatingElement;
        }

	    /// <summary>
	    ///     Construct a IfcConnectionVolumeGeometry with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcConnectionVolumeGeometry(IfcSolidOrShell volumeOnRelatingElement,
            IfcSolidOrShell volumeOnRelatedElement)
        {
            VolumeOnRelatingElement = volumeOnRelatingElement;
            VolumeOnRelatedElement = volumeOnRelatedElement;
        }

        public IfcSolidOrShell VolumeOnRelatingElement { get; set; }
        public IfcSolidOrShell VolumeOnRelatedElement { get; set; } // optional

        public new static IfcConnectionVolumeGeometry FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcConnectionVolumeGeometry>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            VolumeOnRelatingElement != null ? VolumeOnRelatingElement.ToStepValue() : "$",
	            VolumeOnRelatedElement != null ? VolumeOnRelatedElement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}