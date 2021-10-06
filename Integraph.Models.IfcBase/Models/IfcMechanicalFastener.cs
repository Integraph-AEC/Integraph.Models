using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmechanicalfastener.htm" />
	/// </summary>
	public class IfcMechanicalFastener : IfcElementComponent
    {
	    /// <summary>
	    ///     Construct a IfcMechanicalFastener with all required attributes.
	    /// </summary>
	    public IfcMechanicalFastener(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcMechanicalFastener with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMechanicalFastener(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcPositiveLengthMeasure nominalDiameter,
            IfcPositiveLengthMeasure nominalLength, IfcMechanicalFastenerTypeEnum predefinedType) : base(globalId,
            ownerHistory, name, description, objectType, objectPlacement, representation, tag)
        {
            NominalDiameter = nominalDiameter;
            NominalLength = nominalLength;
            PredefinedType = predefinedType;
        }

        public IfcPositiveLengthMeasure NominalDiameter { get; set; } // optional
        public IfcPositiveLengthMeasure NominalLength { get; set; } // optional
        public IfcMechanicalFastenerTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcMechanicalFastener FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMechanicalFastener>(json);
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
	            NominalDiameter != null ? NominalDiameter.ToStepValue() : "$",
	            NominalLength != null ? NominalLength.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}