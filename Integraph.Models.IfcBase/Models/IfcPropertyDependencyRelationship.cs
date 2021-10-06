using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertydependencyrelationship.htm" />
	/// </summary>
	public class IfcPropertyDependencyRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcPropertyDependencyRelationship with all required attributes.
	    /// </summary>
	    public IfcPropertyDependencyRelationship(IfcProperty dependingProperty, IfcProperty dependantProperty)
        {
            DependingProperty = dependingProperty;
            DependantProperty = dependantProperty;
        }

	    /// <summary>
	    ///     Construct a IfcPropertyDependencyRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPropertyDependencyRelationship(IfcLabel name, IfcText description, IfcProperty dependingProperty,
            IfcProperty dependantProperty, IfcText expression) : base(name, description)
        {
            DependingProperty = dependingProperty;
            DependantProperty = dependantProperty;
            Expression = expression;
        }

        public IfcProperty DependingProperty { get; set; }
        public IfcProperty DependantProperty { get; set; }
        public IfcText Expression { get; set; } // optional

        public new static IfcPropertyDependencyRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertyDependencyRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            DependingProperty != null ? DependingProperty.ToStepValue() : "$",
	            DependantProperty != null ? DependantProperty.ToStepValue() : "$",
	            Expression != null ? Expression.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}