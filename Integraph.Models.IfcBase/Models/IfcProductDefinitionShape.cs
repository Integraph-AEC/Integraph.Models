using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcproductdefinitionshape.htm" />
	/// </summary>
	public class IfcProductDefinitionShape : IfcProductRepresentation
    {
	    /// <summary>
	    ///     Construct a IfcProductDefinitionShape with all required attributes.
	    /// </summary>
	    public IfcProductDefinitionShape(List<IfcRepresentation> representations) : base(representations)
        {
            ShapeOfProduct = new List<IfcProduct>();
            HasShapeAspects = new List<IfcShapeAspect>();
        }

	    /// <summary>
	    ///     Construct a IfcProductDefinitionShape with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProductDefinitionShape(IfcLabel name, IfcText description, List<IfcRepresentation> representations) :
            base(name, description, representations)
        {
            ShapeOfProduct = new List<IfcProduct>();
            HasShapeAspects = new List<IfcShapeAspect>();
        }

        public List<IfcProduct> ShapeOfProduct { get; set; } // inverse
        public List<IfcShapeAspect> HasShapeAspects { get; set; } // inverse

        public new static IfcProductDefinitionShape FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProductDefinitionShape>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Representations != null ? Representations.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}