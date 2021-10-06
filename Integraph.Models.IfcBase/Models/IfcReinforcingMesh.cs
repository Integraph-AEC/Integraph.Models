using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingmesh.htm" />
	/// </summary>
	public class IfcReinforcingMesh : IfcReinforcingElement
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingMesh with all required attributes.
	    /// </summary>
	    public IfcReinforcingMesh(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingMesh with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingMesh(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcLabel steelGrade,
            IfcPositiveLengthMeasure meshLength, IfcPositiveLengthMeasure meshWidth,
            IfcPositiveLengthMeasure longitudinalBarNominalDiameter,
            IfcPositiveLengthMeasure transverseBarNominalDiameter, IfcAreaMeasure longitudinalBarCrossSectionArea,
            IfcAreaMeasure transverseBarCrossSectionArea, IfcPositiveLengthMeasure longitudinalBarSpacing,
            IfcPositiveLengthMeasure transverseBarSpacing, IfcReinforcingMeshTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, steelGrade)
        {
            MeshLength = meshLength;
            MeshWidth = meshWidth;
            LongitudinalBarNominalDiameter = longitudinalBarNominalDiameter;
            TransverseBarNominalDiameter = transverseBarNominalDiameter;
            LongitudinalBarCrossSectionArea = longitudinalBarCrossSectionArea;
            TransverseBarCrossSectionArea = transverseBarCrossSectionArea;
            LongitudinalBarSpacing = longitudinalBarSpacing;
            TransverseBarSpacing = transverseBarSpacing;
            PredefinedType = predefinedType;
        }

        public IfcPositiveLengthMeasure MeshLength { get; set; } // optional
        public IfcPositiveLengthMeasure MeshWidth { get; set; } // optional
        public IfcPositiveLengthMeasure LongitudinalBarNominalDiameter { get; set; } // optional
        public IfcPositiveLengthMeasure TransverseBarNominalDiameter { get; set; } // optional
        public IfcAreaMeasure LongitudinalBarCrossSectionArea { get; set; } // optional
        public IfcAreaMeasure TransverseBarCrossSectionArea { get; set; } // optional
        public IfcPositiveLengthMeasure LongitudinalBarSpacing { get; set; } // optional
        public IfcPositiveLengthMeasure TransverseBarSpacing { get; set; } // optional
        public IfcReinforcingMeshTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcReinforcingMesh FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingMesh>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            GlobalId != null ? GlobalId.ToStepValue() : "$",
	            OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            ObjectType != null ? ObjectType.ToStepValue() : "$",
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            Tag != null ? Tag.ToStepValue() : "$",
	            SteelGrade != null ? SteelGrade.ToStepValue() : "$",
	            MeshLength != null ? MeshLength.ToStepValue() : "$",
	            MeshWidth != null ? MeshWidth.ToStepValue() : "$",
	            LongitudinalBarNominalDiameter != null ? LongitudinalBarNominalDiameter.ToStepValue() : "$",
	            TransverseBarNominalDiameter != null ? TransverseBarNominalDiameter.ToStepValue() : "$",
	            LongitudinalBarCrossSectionArea != null ? LongitudinalBarCrossSectionArea.ToStepValue() : "$",
	            TransverseBarCrossSectionArea != null ? TransverseBarCrossSectionArea.ToStepValue() : "$",
	            LongitudinalBarSpacing != null ? LongitudinalBarSpacing.ToStepValue() : "$",
	            TransverseBarSpacing != null ? TransverseBarSpacing.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}