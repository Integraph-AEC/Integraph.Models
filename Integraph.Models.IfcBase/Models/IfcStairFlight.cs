using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstairflight.htm" />
	/// </summary>
	public class IfcStairFlight : IfcBuildingElement
    {
	    /// <summary>
	    ///     Construct a IfcStairFlight with all required attributes.
	    /// </summary>
	    public IfcStairFlight(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcStairFlight with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStairFlight(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcObjectPlacement objectPlacement,
            IfcProductRepresentation representation, IfcIdentifier tag, IfcInteger numberOfRisers,
            IfcInteger numberOfTreads, IfcPositiveLengthMeasure riserHeight, IfcPositiveLengthMeasure treadLength,
            IfcStairFlightTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, objectType,
            objectPlacement, representation, tag)
        {
            NumberOfRisers = numberOfRisers;
            NumberOfTreads = numberOfTreads;
            RiserHeight = riserHeight;
            TreadLength = treadLength;
            PredefinedType = predefinedType;
        }

        public IfcInteger NumberOfRisers { get; set; } // optional
        public IfcInteger NumberOfTreads { get; set; } // optional
        public IfcPositiveLengthMeasure RiserHeight { get; set; } // optional
        public IfcPositiveLengthMeasure TreadLength { get; set; } // optional
        public IfcStairFlightTypeEnum? PredefinedType { get; set; } // optional

        public new static IfcStairFlight FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStairFlight>(json);
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
	            NumberOfRisers != null ? NumberOfRisers.ToStepValue() : "$",
	            NumberOfTreads != null ? NumberOfTreads.ToStepValue() : "$",
	            RiserHeight != null ? RiserHeight.ToStepValue() : "$",
	            TreadLength != null ? TreadLength.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}