using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgeometricrepresentationcontext.htm" />
	/// </summary>
	public class IfcGeometricRepresentationContext : IfcRepresentationContext
    {
	    /// <summary>
	    ///     Construct a IfcGeometricRepresentationContext with all required attributes.
	    /// </summary>
	    public IfcGeometricRepresentationContext(IfcDimensionCount coordinateSpaceDimension,
            IfcAxis2Placement worldCoordinateSystem)
        {
            HasSubContexts = new List<IfcGeometricRepresentationSubContext>();
            HasCoordinateOperation = new List<IfcCoordinateOperation>();

            CoordinateSpaceDimension = coordinateSpaceDimension;
            WorldCoordinateSystem = worldCoordinateSystem;
        }

	    /// <summary>
	    ///     Construct a IfcGeometricRepresentationContext with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGeometricRepresentationContext(IfcLabel contextIdentifier, IfcLabel contextType,
            IfcDimensionCount coordinateSpaceDimension, IfcReal precision, IfcAxis2Placement worldCoordinateSystem,
            IfcDirection trueNorth) : base(contextIdentifier, contextType)
        {
            HasSubContexts = new List<IfcGeometricRepresentationSubContext>();
            HasCoordinateOperation = new List<IfcCoordinateOperation>();

            CoordinateSpaceDimension = coordinateSpaceDimension;
            Precision = precision;
            WorldCoordinateSystem = worldCoordinateSystem;
            TrueNorth = trueNorth;
        }

        public IfcDimensionCount CoordinateSpaceDimension { get; set; }
        public IfcReal Precision { get; set; } // optional
        public IfcAxis2Placement WorldCoordinateSystem { get; set; }
        public IfcDirection TrueNorth { get; set; } // optional
        public List<IfcGeometricRepresentationSubContext> HasSubContexts { get; set; } // inverse
        public List<IfcCoordinateOperation> HasCoordinateOperation { get; set; } // inverse

        public new static IfcGeometricRepresentationContext FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGeometricRepresentationContext>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ContextIdentifier != null ? ContextIdentifier.ToStepValue() : "$",
                ContextType != null ? ContextType.ToStepValue() : "$",
                CoordinateSpaceDimension != null ? CoordinateSpaceDimension.ToStepValue() : "$",
                Precision != null ? Precision.ToStepValue() : "$",
                WorldCoordinateSystem != null ? WorldCoordinateSystem.ToStepValue() : "$",
                TrueNorth != null ? TrueNorth.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}