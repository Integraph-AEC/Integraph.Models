using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelsequence.htm" />
	/// </summary>
	public class IfcRelSequence : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelSequence with all required attributes.
	    /// </summary>
	    public IfcRelSequence(IfcGloballyUniqueId globalId, IfcProcess relatingProcess, IfcProcess relatedProcess) :
            base(globalId)
        {
            RelatingProcess = relatingProcess;
            RelatedProcess = relatedProcess;
        }

	    /// <summary>
	    ///     Construct a IfcRelSequence with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelSequence(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcProcess relatingProcess, IfcProcess relatedProcess, IfcLagTime timeLag,
            IfcSequenceEnum sequenceType, IfcLabel userDefinedSequenceType) : base(globalId, ownerHistory, name,
            description)
        {
            RelatingProcess = relatingProcess;
            RelatedProcess = relatedProcess;
            TimeLag = timeLag;
            SequenceType = sequenceType;
            UserDefinedSequenceType = userDefinedSequenceType;
        }

        public IfcProcess RelatingProcess { get; set; }
        public IfcProcess RelatedProcess { get; set; }
        public IfcLagTime TimeLag { get; set; } // optional
        public IfcSequenceEnum? SequenceType { get; set; } // optional
        public IfcLabel UserDefinedSequenceType { get; set; } // optional

        public new static IfcRelSequence FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelSequence>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingProcess != null ? RelatingProcess.ToStepValue() : "$",
                RelatedProcess != null ? RelatedProcess.ToStepValue() : "$",
                TimeLag != null ? TimeLag.ToStepValue() : "$",
                SequenceType.ToStepValue(),
                UserDefinedSequenceType != null ? UserDefinedSequenceType.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}