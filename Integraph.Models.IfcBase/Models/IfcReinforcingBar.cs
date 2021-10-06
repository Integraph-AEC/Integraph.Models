using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreinforcingbar.htm" />
	/// </summary>
	public class IfcReinforcingBar : IfcReinforcingElement
    {
	    /// <summary>
	    ///     Construct a IfcReinforcingBar with all required attributes.
	    /// </summary>
	    public IfcReinforcingBar(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcReinforcingBar with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReinforcingBar(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcLabel steelGrade,
            IfcPositiveLengthMeasure nominalDiameter, IfcAreaMeasure crossSectionArea,
            IfcPositiveLengthMeasure barLength, IfcReinforcingBarTypeEnum predefinedType,
            IfcReinforcingBarSurfaceEnum barSurface) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, tag, steelGrade)
        {
            NominalDiameter = nominalDiameter;
            CrossSectionArea = crossSectionArea;
            BarLength = barLength;
            PredefinedType = predefinedType;
            BarSurface = barSurface;
        }

        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcAreaMeasure CrossSectionArea { get; set; } // optional
        public IfcPositiveLengthMeasure BarLength { get; set; } // optional
        public IfcReinforcingBarTypeEnum? PredefinedType { get; set; } // optional
        public IfcReinforcingBarSurfaceEnum? BarSurface { get; set; } // optional

        public new static IfcReinforcingBar FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReinforcingBar>(json);
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
	            NominalDiameter != null ? NominalDiameter.ToStepValue() : "$",
	            CrossSectionArea != null ? CrossSectionArea.ToStepValue() : "$",
	            BarLength != null ? BarLength.ToStepValue() : "$",
	            PredefinedType.ToStepValue(),
	            BarSurface.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}