using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcproceduretype.htm" />
	/// </summary>
	public class IfcProcedureType : IfcTypeProcess
    {
	    /// <summary>
	    ///     Construct a IfcProcedureType with all required attributes.
	    /// </summary>
	    public IfcProcedureType(IfcGloballyUniqueId globalId, IfcProcedureTypeEnum predefinedType) : base(globalId)
        {
            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcProcedureType with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcProcedureType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcIdentifier applicableOccurrence, List<IfcPropertySetDefinition> hasPropertySets,
            IfcIdentifier identification, IfcText longDescription, IfcLabel processType,
            IfcProcedureTypeEnum predefinedType) : base(globalId, ownerHistory, name, description, applicableOccurrence,
            hasPropertySets, identification, longDescription, processType)
        {
            PredefinedType = predefinedType;
        }

        public IfcProcedureTypeEnum? PredefinedType { get; set; }

        public new static IfcProcedureType FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcProcedureType>(json);
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
	            Identification != null ? Identification.ToStepValue() : "$",
	            LongDescription != null ? LongDescription.ToStepValue() : "$",
	            ProcessType != null ? ProcessType.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}