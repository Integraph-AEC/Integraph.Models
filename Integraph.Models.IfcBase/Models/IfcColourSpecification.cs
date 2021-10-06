using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccolourspecification.htm" />
	/// </summary>
	public abstract class IfcColourSpecification : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcColourSpecification with all required attributes.
	    /// </summary>
	    public IfcColourSpecification()
        {
        }

	    /// <summary>
	    ///     Construct a IfcColourSpecification with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcColourSpecification(IfcLabel name)
        {
            Name = name;
        }

        public IfcLabel Name { get; set; } // optional

        public new static IfcColourSpecification FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcColourSpecification>(json);
        }
    }
}