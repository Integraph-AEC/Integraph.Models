using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcproject.htm" />
	/// </summary>
	public class IfcProject : IfcContext
    {
	    /// <summary>
	    ///     Construct a IfcProject with all required attributes.
	    /// </summary>
	    public IfcProject(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcProject with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProject(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcLabel longName, IfcLabel phase,
            List<IfcRepresentationContext> representationContexts, IfcUnitAssignment unitsInContext) : base(globalId,
            ownerHistory, name, description, objectType, longName, phase, representationContexts, unitsInContext)
        {
        }

        public new static IfcProject FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProject>(json);
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
	            LongName != null ? LongName.ToStepValue() : "$",
	            Phase != null ? Phase.ToStepValue() : "$",
	            RepresentationContexts != null ? RepresentationContexts.ToStepValue() : "$",
	            UnitsInContext != null ? UnitsInContext.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}