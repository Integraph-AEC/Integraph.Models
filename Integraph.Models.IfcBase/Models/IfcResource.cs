using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcresource.htm" />
	/// </summary>
	public abstract class IfcResource : IfcObject
    {
	    /// <summary>
	    ///     Construct a IfcResource with all required attributes.
	    /// </summary>
	    public IfcResource(IfcGloballyUniqueId globalId) : base(globalId)
        {
            ResourceOf = new List<IfcRelAssignsToResource>();
        }

	    /// <summary>
	    ///     Construct a IfcResource with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcResource(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcIdentifier identification, IfcText longDescription) : base(
            globalId, ownerHistory, name, description, objectType)
        {
            ResourceOf = new List<IfcRelAssignsToResource>();

            Identification = identification;
            LongDescription = longDescription;
        }

        public IfcIdentifier Identification { get; set; } // optional
        public IfcText LongDescription { get; set; } // optional
        public List<IfcRelAssignsToResource> ResourceOf { get; set; } // inverse

        public new static IfcResource FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcResource>(json);
        }
    }
}