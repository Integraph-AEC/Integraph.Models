using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclibraryinformation.htm" />
	/// </summary>
	public class IfcLibraryInformation : IfcExternalInformation
    {
	    /// <summary>
	    ///     Construct a IfcLibraryInformation with all required attributes.
	    /// </summary>
	    public IfcLibraryInformation(IfcLabel name)
        {
            LibraryInfoForObjects = new List<IfcRelAssociatesLibrary>();
            HasLibraryReferences = new List<IfcLibraryReference>();

            Name = name;
        }

	    /// <summary>
	    ///     Construct a IfcLibraryInformation with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLibraryInformation(IfcLabel name, IfcLabel version, IfcActorSelect publisher, IfcDateTime versionDate,
            IfcUriReference location, IfcText description)
        {
            LibraryInfoForObjects = new List<IfcRelAssociatesLibrary>();
            HasLibraryReferences = new List<IfcLibraryReference>();

            Name = name;
            Version = version;
            Publisher = publisher;
            VersionDate = versionDate;
            Location = location;
            Description = description;
        }

        public IfcLabel Name { get; set; }
        public IfcLabel Version { get; set; } // optional
        public IfcActorSelect Publisher { get; set; } // optional
        public IfcDateTime VersionDate { get; set; } // optional
        public IfcUriReference Location { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public List<IfcRelAssociatesLibrary> LibraryInfoForObjects { get; set; } // inverse
        public List<IfcLibraryReference> HasLibraryReferences { get; set; } // inverse

        public new static IfcLibraryInformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLibraryInformation>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Version != null ? Version.ToStepValue() : "$",
	            Publisher != null ? Publisher.ToStepValue() : "$",
	            VersionDate != null ? VersionDate.ToStepValue() : "$",
	            Location != null ? Location.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}