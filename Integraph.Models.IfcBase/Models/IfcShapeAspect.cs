using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcshapeaspect.htm" />
	/// </summary>
	public class IfcShapeAspect : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcShapeAspect with all required attributes.
	    /// </summary>
	    public IfcShapeAspect(List<IfcShapeModel> shapeRepresentations, IfcLogical productDefinitional)
        {
            ShapeRepresentations = shapeRepresentations;
            ProductDefinitional = productDefinitional;
        }

	    /// <summary>
	    ///     Construct a IfcShapeAspect with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcShapeAspect(List<IfcShapeModel> shapeRepresentations, IfcLabel name, IfcText description,
            IfcLogical productDefinitional, IfcProductRepresentationSelect partOfProductDefinitionShape)
        {
            ShapeRepresentations = shapeRepresentations;
            Name = name;
            Description = description;
            ProductDefinitional = productDefinitional;
            PartOfProductDefinitionShape = partOfProductDefinitionShape;
        }

        public List<IfcShapeModel> ShapeRepresentations { get; set; }
        public IfcLabel Name { get; set; } // optional
        public IfcText Description { get; set; } // optional
        public IfcLogical ProductDefinitional { get; set; }
        public IfcProductRepresentationSelect PartOfProductDefinitionShape { get; set; } // optional

        public static IfcShapeAspect FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcShapeAspect>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            ShapeRepresentations != null ? ShapeRepresentations.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ProductDefinitional != null ? ProductDefinitional.ToStepValue() : "$",
	            PartOfProductDefinitionShape != null ? PartOfProductDefinitionShape.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}