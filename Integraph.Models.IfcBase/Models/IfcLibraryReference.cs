using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclibraryreference.htm" />
	/// </summary>
	public class IfcLibraryReference : IfcExternalReference
    {
	    /// <summary>
	    ///     Construct a IfcLibraryReference with all required attributes.
	    /// </summary>
	    public IfcLibraryReference()
        {
            LibraryRefForObjects = new List<IfcRelAssociatesLibrary>();
        }

	    /// <summary>
	    ///     Construct a IfcLibraryReference with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLibraryReference(IfcUriReference location, IfcIdentifier identification, IfcLabel name,
            IfcText description, IfcLanguageId language, IfcLibraryInformation referencedLibrary) : base(location,
            identification, name)
        {
            LibraryRefForObjects = new List<IfcRelAssociatesLibrary>();

            Description = description;
            Language = language;
            ReferencedLibrary = referencedLibrary;
        }

        public IfcText Description { get; set; } // optional
        public IfcLanguageId Language { get; set; } // optional
        public IfcLibraryInformation ReferencedLibrary { get; set; } // optional
        public List<IfcRelAssociatesLibrary> LibraryRefForObjects { get; set; } // inverse

        public new static IfcLibraryReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLibraryReference>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Location != null ? Location.ToStepValue() : "$",
	            Identification != null ? Identification.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Language != null ? Language.ToStepValue() : "$",
	            ReferencedLibrary != null ? ReferencedLibrary.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}