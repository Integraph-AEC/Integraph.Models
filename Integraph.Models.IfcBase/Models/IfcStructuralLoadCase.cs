using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralloadcase.htm" />
	/// </summary>
	public class IfcStructuralLoadCase : IfcStructuralLoadGroup
    {
	    /// <summary>
	    ///     Construct a IfcStructuralLoadCase with all required attributes.
	    /// </summary>
	    public IfcStructuralLoadCase(IfcGloballyUniqueId globalId, IfcLoadGroupTypeEnum predefinedType,
            IfcActionTypeEnum actionType, IfcActionSourceTypeEnum actionSource) : base(globalId, predefinedType,
            actionType, actionSource)
        {
            SelfWeightCoefficients = new List<IfcRatioMeasure>();
        }

	    /// <summary>
	    ///     Construct a IfcStructuralLoadCase with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralLoadCase(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcLoadGroupTypeEnum predefinedType, IfcActionTypeEnum actionType,
            IfcActionSourceTypeEnum actionSource, IfcRatioMeasure coefficient, IfcLabel purpose,
            List<IfcRatioMeasure> selfWeightCoefficients) : base(globalId, ownerHistory, name, description, objectType,
            predefinedType, actionType, actionSource, coefficient, purpose)
        {
            SelfWeightCoefficients = selfWeightCoefficients;
        }

        public List<IfcRatioMeasure> SelfWeightCoefficients { get; set; } // optional

        public new static IfcStructuralLoadCase FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralLoadCase>(json);
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
                PredefinedType.ToStepValue(),
                ActionType.ToStepValue(),
                ActionSource.ToStepValue(),
                Coefficient != null ? Coefficient.ToStepValue() : "$",
                Purpose != null ? Purpose.ToStepValue() : "$",
                SelfWeightCoefficients != null ? SelfWeightCoefficients.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}