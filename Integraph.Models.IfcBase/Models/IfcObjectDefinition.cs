using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcobjectdefinition.htm" />
	/// </summary>
	public abstract class IfcObjectDefinition : IfcRoot
    {
	    /// <summary>
	    ///     Construct a IfcObjectDefinition with all required attributes.
	    /// </summary>
	    public IfcObjectDefinition(IfcGloballyUniqueId globalId) : base(globalId)
        {
            HasAssignments = new List<IfcRelAssigns>();
            Nests = new List<IfcRelNests>();
            IsNestedBy = new List<IfcRelNests>();
            HasContext = new List<IfcRelDeclares>();
            IsDecomposedBy = new List<IfcRelAggregates>();
            Decomposes = new List<IfcRelAggregates>();
            HasAssociations = new List<IfcRelAssociates>();
        }

	    /// <summary>
	    ///     Construct a IfcObjectDefinition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcObjectDefinition(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description) : base(globalId, ownerHistory, name, description)
        {
            HasAssignments = new List<IfcRelAssigns>();
            Nests = new List<IfcRelNests>();
            IsNestedBy = new List<IfcRelNests>();
            HasContext = new List<IfcRelDeclares>();
            IsDecomposedBy = new List<IfcRelAggregates>();
            Decomposes = new List<IfcRelAggregates>();
            HasAssociations = new List<IfcRelAssociates>();
        }

        public List<IfcRelAssigns> HasAssignments { get; set; } // inverse
        public List<IfcRelNests> Nests { get; set; } // inverse
        public List<IfcRelNests> IsNestedBy { get; set; } // inverse
        public List<IfcRelDeclares> HasContext { get; set; } // inverse
        public List<IfcRelAggregates> IsDecomposedBy { get; set; } // inverse
        public List<IfcRelAggregates> Decomposes { get; set; } // inverse
        public List<IfcRelAssociates> HasAssociations { get; set; } // inverse

        public new static IfcObjectDefinition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcObjectDefinition>(json);
        }
    }
}