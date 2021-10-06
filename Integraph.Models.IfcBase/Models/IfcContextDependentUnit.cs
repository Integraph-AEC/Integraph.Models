using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccontextdependentunit.htm" />
	/// </summary>
	public class IfcContextDependentUnit : IfcNamedUnit
    {
	    /// <summary>
	    ///     Construct a IfcContextDependentUnit with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcContextDependentUnit(IfcDimensionalExponents dimensions, IfcUnitEnum unitType, IfcLabel name) : base(
            dimensions, unitType)
        {
            HasExternalReference = new List<IfcExternalReferenceRelationship>();

            Name = name;
        }

        public IfcLabel Name { get; set; }
        public List<IfcExternalReferenceRelationship> HasExternalReference { get; set; } // inverse

        public new static IfcContextDependentUnit FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcContextDependentUnit>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Dimensions != null ? Dimensions.ToStepValue() : "$",
                UnitType.ToStepValue(),
                Name != null ? Name.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}