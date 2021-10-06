using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrepresentationmap.htm" />
	/// </summary>
	public class IfcRepresentationMap : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcRepresentationMap with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRepresentationMap(IfcAxis2Placement mappingOrigin, IfcRepresentation mappedRepresentation)
        {
            HasShapeAspects = new List<IfcShapeAspect>();
            MapUsage = new List<IfcMappedItem>();

            MappingOrigin = mappingOrigin;
            MappedRepresentation = mappedRepresentation;
        }

        public IfcAxis2Placement MappingOrigin { get; set; }
        public IfcRepresentation MappedRepresentation { get; set; }
        public List<IfcShapeAspect> HasShapeAspects { get; set; } // inverse
        public List<IfcMappedItem> MapUsage { get; set; } // inverse

        public static IfcRepresentationMap FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRepresentationMap>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            MappingOrigin != null ? MappingOrigin.ToStepValue() : "$",
	            MappedRepresentation != null ? MappedRepresentation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}