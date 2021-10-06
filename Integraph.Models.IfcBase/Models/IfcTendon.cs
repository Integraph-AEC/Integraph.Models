using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctendon.htm" />
	/// </summary>
	public class IfcTendon : IfcReinforcingElement
    {
	    /// <summary>
	    ///     Construct a IfcTendon with all required attributes.
	    /// </summary>
	    public IfcTendon(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcTendon with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTendon(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcIdentifier tag, IfcLabel steelGrade, IfcTendonTypeEnum predefinedType,
            IfcPositiveLengthMeasure nominalDiameter, IfcAreaMeasure crossSectionArea, IfcForceMeasure tensionForce,
            IfcPressureMeasure preStress, IfcNormalisedRatioMeasure frictionCoefficient,
            IfcPositiveLengthMeasure anchorageSlip, IfcPositiveLengthMeasure minCurvatureRadius) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag, steelGrade)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            TensionForce = tensionForce;
            PreStress = preStress;
            FrictionCoefficient = frictionCoefficient;
            AnchorageSlip = anchorageSlip;
            MinCurvatureRadius = minCurvatureRadius;
        }

        public IfcTendonTypeEnum? PredefinedType { get; set; } // optional
        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcAreaMeasure CrossSectionArea { get; set; } // optional
        public IfcForceMeasure TensionForce { get; set; } // optional
        public IfcPressureMeasure PreStress { get; set; } // optional
        public IfcNormalisedRatioMeasure FrictionCoefficient { get; set; } // optional
        public IfcPositiveLengthMeasure AnchorageSlip { get; set; } // optional
        public IfcPositiveLengthMeasure MinCurvatureRadius { get; set; } // optional

        public new static IfcTendon FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTendon>(json);
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
	            PredefinedType.ToStepValue(),
	            NominalDiameter != null ? NominalDiameter.ToStepValue() : "$",
	            CrossSectionArea != null ? CrossSectionArea.ToStepValue() : "$",
	            TensionForce != null ? TensionForce.ToStepValue() : "$",
	            PreStress != null ? PreStress.ToStepValue() : "$",
	            FrictionCoefficient != null ? FrictionCoefficient.ToStepValue() : "$",
	            AnchorageSlip != null ? AnchorageSlip.ToStepValue() : "$",
	            MinCurvatureRadius != null ? MinCurvatureRadius.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}