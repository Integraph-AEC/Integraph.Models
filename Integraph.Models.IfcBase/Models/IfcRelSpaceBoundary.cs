using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelspaceboundary.htm" />
	/// </summary>
	public class IfcRelSpaceBoundary : IfcRelConnects
    {
	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary with all required attributes.
	    /// </summary>
	    public IfcRelSpaceBoundary(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace,
            IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary) : base(globalId)
        {
            RelatingSpace = relatingSpace;
            RelatedBuildingElement = relatedBuildingElement;
            PhysicalOrVirtualBoundary = physicalOrVirtualBoundary;
            InternalOrExternalBoundary = internalOrExternalBoundary;
        }

	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelSpaceBoundary(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement,
            IfcConnectionGeometry connectionGeometry, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary) : base(globalId, ownerHistory, name, description)
        {
            RelatingSpace = relatingSpace;
            RelatedBuildingElement = relatedBuildingElement;
            ConnectionGeometry = connectionGeometry;
            PhysicalOrVirtualBoundary = physicalOrVirtualBoundary;
            InternalOrExternalBoundary = internalOrExternalBoundary;
        }

        public IfcSpaceBoundarySelect RelatingSpace { get; set; }
        public IfcElement RelatedBuildingElement { get; set; }
        public IfcConnectionGeometry ConnectionGeometry { get; set; } // optional
        public IfcPhysicalOrVirtualEnum? PhysicalOrVirtualBoundary { get; set; }
        public IfcInternalOrExternalEnum? InternalOrExternalBoundary { get; set; }

        public new static IfcRelSpaceBoundary FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelSpaceBoundary>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                GlobalId != null ? GlobalId.ToStepValue() : "$",
                OwnerHistory != null ? OwnerHistory.ToStepValue() : "$",
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingSpace != null ? RelatingSpace.ToStepValue() : "$",
                RelatedBuildingElement != null ? RelatedBuildingElement.ToStepValue() : "$",
                ConnectionGeometry != null ? ConnectionGeometry.ToStepValue() : "$",
                PhysicalOrVirtualBoundary.ToStepValue(),
                InternalOrExternalBoundary.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}