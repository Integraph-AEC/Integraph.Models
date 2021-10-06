using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcapplication.htm" />
	/// </summary>
	public class IfcApplication : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcApplication with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcApplication(IfcOrganization applicationDeveloper, IfcLabel version, IfcLabel applicationFullName,
            IfcIdentifier applicationIdentifier)
        {
            ApplicationDeveloper = applicationDeveloper;
            Version = version;
            ApplicationFullName = applicationFullName;
            ApplicationIdentifier = applicationIdentifier;
        }

        public IfcOrganization ApplicationDeveloper { get; set; }
        public IfcLabel Version { get; set; }
        public IfcLabel ApplicationFullName { get; set; }
        public IfcIdentifier ApplicationIdentifier { get; set; }

        public static IfcApplication FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcApplication>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ApplicationDeveloper != null ? ApplicationDeveloper.ToStepValue() : "$",
                Version != null ? Version.ToStepValue() : "$",
                ApplicationFullName != null ? ApplicationFullName.ToStepValue() : "$",
                ApplicationIdentifier != null ? ApplicationIdentifier.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}