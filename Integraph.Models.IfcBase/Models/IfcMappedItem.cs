using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmappeditem.htm" />
	/// </summary>
	public class IfcMappedItem : IfcRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcMappedItem with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcMappedItem(IfcRepresentationMap mappingSource, IfcCartesianTransformationOperator mappingTarget)
        {
            MappingSource = mappingSource;
            MappingTarget = mappingTarget;
        }

        public IfcRepresentationMap MappingSource { get; set; }
        public IfcCartesianTransformationOperator MappingTarget { get; set; }

        public new static IfcMappedItem FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMappedItem>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            MappingSource != null ? MappingSource.ToStepValue() : "$",
	            MappingTarget != null ? MappingTarget.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}