using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcroot.htm" />
	/// </summary>
	public abstract class IfcRoot : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRoot with all required attributes.
	    /// </summary>
	    public IfcRoot(IfcGloballyUniqueId globalId)
        {
            GlobalId = globalId;
        }

	    /// <summary>
	    ///     Construct a IfcRoot with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRoot(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description)
        {
            GlobalId = globalId;
            OwnerHistory = ownerHistory;
            Name = name;
            Description = description;
        }

        public IfcGloballyUniqueId GlobalId { get; set; }
        public IfcOwnerHistory OwnerHistory { get; set; } // optional
        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional

        public static IfcRoot FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRoot>(json);
        }
    }
}