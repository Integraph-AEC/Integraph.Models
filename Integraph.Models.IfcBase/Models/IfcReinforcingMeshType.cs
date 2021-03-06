using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingmeshtype.htm" />
	/// </summary>
	public class IfcReinforcingMeshType : IfcReinforcingElementType
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingMeshType with all required attributes.
	    /// </summary>
	    public IfcReinforcingMeshType(IfcGloballyUniqueId globalId, IfcReinforcingMeshTypeEnum predefinedType) :
            base(globalId)
        {
            BendingParameters = new List<IfcBendingParameterSelect>();

            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingMeshType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingMeshType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcReinforcingMeshTypeEnum predefinedType, IfcPositiveLengthMeasure meshLength,
            IfcPositiveLengthMeasure meshWidth, IfcPositiveLengthMeasure longitudinalBarNominalDiameter,
            IfcPositiveLengthMeasure transverseBarNominalDiameter, IfcAreaMeasure longitudinalBarCrossSectionArea,
            IfcAreaMeasure transverseBarCrossSectionArea, IfcPositiveLengthMeasure longitudinalBarSpacing,
            IfcPositiveLengthMeasure transverseBarSpacing, IfcLabel bendingShapeCode,
            List<IfcBendingParameterSelect> bendingParameters) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            MeshLength = meshLength;
            MeshWidth = meshWidth;
            LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
            TransverseBarNominalDiameter = transverseBarNominalDiameter;
            LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
            TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
            LongitudinalBarSpacing = longitudinalBarSpacing;
            TransverseBarSpacing = transverseBarSpacing;
            BendingShapeCode = bendingShapeCode;
            BendingParameters = bendingParameters;
        }

        public IfcReinforcingMeshTypeEnum? PredefinedType { get; set; }
        public IfcPositiveLengthMeasure MeshLength { get; set; } // optional
        public IfcPositiveLengthMeasure MeshWidth { get; set; } // optional
        public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; } // optional
        public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; } // optional
        public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; } // optional
        public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; } // optional
        public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; } // optional
        public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; } // optional
        public IfcLabel BendingShapeCode { get; set; } // optional
        public List<IfcBendingParameterSelect> BendingParameters { get; set; } // optional

        public new static IfcReinforcingMeshType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingMeshType>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                ApplicableOccurrence != null ? ApplicableOccurrence.ToStepValue() : "$",
                HasPropertySets != null ? HasPropertySets.ToStepValue() : "$",
                RepresentationMaps != null ? RepresentationMaps.ToStepValue() : "$",
                Tag != null ? Tag.ToStepValue() : "$",
                ElementType != null ? ElementType.ToStepValue() : "$",
                PredefinedType.ToStepValue(),
                MeshLength != null ? MeshLength.ToStepValue() : "$",
                MeshWidth != null ? MeshWidth.ToStepValue() : "$",
                LongitudinalBarNominalDiameter != null ? LongitudinalBarNominalDiameter.ToStepValue() : "$",
                TransverseBarNominalDiameter != null ? TransverseBarNominalDiameter.ToStepValue() : "$",
                LongitudinalBarCrossSectionArea != null ? LongitudinalBarCrossSectionArea.ToStepValue() : "$",
                TransverseBarCrossSectionArea != null ? TransverseBarCrossSectionArea.ToStepValue() : "$",
                LongitudinalBarSpacing != null ? LongitudinalBarSpacing.ToStepValue() : "$",
                TransverseBarSpacing != null ? TransverseBarSpacing.ToStepValue() : "$",
                BendingShapeCode != null ? BendingShapeCode.ToStepValue() : "$",
                BendingParameters != null ? BendingParameters.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}