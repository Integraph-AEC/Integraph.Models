using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingbartype.htm" />
	/// </summary>
	public class IfcReinforcingBarType : IfcReinforcingElementType
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingBarType with all required attributes.
	    /// </summary>
	    public IfcReinforcingBarType(IfcGloballyUniqueId globalId, IfcReinforcingBarTypeEnum predefinedType) :
            base(globalId)
        {
            BendingParameters = new List<IfcBendingParameterSelect>();

            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingBarType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingBarType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            List<IfcRepresentationMap> representationMaps, IfcLabel tag, IfcLabel elementType,
            IfcReinforcingBarTypeEnum predefinedType, IfcPositiveLengthMeasure nominalDiameter,
            IfcAreaMeasure crossSectionArea, IfcPositiveLengthMeasure barLength,
            IfcReinforcingBarSurfaceEnum barSurface, IfcLabel bendingShapeCode,
            List<IfcBendingParameterSelect> bendingParameters) : base(globalId, ownerHistory, name, description,
            applicableOccurrence, hasPropertySets, representationMaps, tag, elementType)
        {
            PredefinedType = predefinedType;
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            BarLength = barLength;
            BarSurface = barSurface;
            BendingShapeCode = bendingShapeCode;
            BendingParameters = bendingParameters;
        }

        public IfcReinforcingBarTypeEnum? PredefinedType { get; set; }
        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcAreaMeasure CrossSectionArea { get; set; } // optional
        public IfcPositiveLengthMeasure BarLength { get; set; } // optional
        public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; } // optional
        public IfcLabel BendingShapeCode { get; set; } // optional
        public List<IfcBendingParameterSelect> BendingParameters { get; set; } // optional

        public new static IfcReinforcingBarType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingBarType>(json);
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
                NominalDiameter != null ? NominalDiameter.ToStepValue() : "$",
                CrossSectionArea != null ? CrossSectionArea.ToStepValue() : "$",
                BarLength != null ? BarLength.ToStepValue() : "$",
                BarSurface.ToStepValue(),
                BendingShapeCode != null ? BendingShapeCode.ToStepValue() : "$",
                BendingParameters != null ? BendingParameters.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}