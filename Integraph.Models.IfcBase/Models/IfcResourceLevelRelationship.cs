using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcresourcelevelrelationship.htm" />
	/// </summary>
	public abstract class IfcResourceLevelRelationship : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcResourceLevelRelationship with all required attributes.
	    /// </summary>
	    public IfcResourceLevelRelationship()
        {
        }

	    /// <summary>
	    ///     Construct a IfcResourceLevelRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcResourceLevelRelationship(IfcLabel name, IfcText description)
        {
            Name = name;
            Description = description;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional

        public static IfcResourceLevelRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcResourceLevelRelationship>(json);
        }
    }
}