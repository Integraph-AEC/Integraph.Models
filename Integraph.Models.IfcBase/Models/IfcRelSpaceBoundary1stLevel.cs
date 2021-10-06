using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelspaceboundary1stlevel.htm" />
	/// </summary>
	public class IfcRelSpaceBoundary1StLevel : IfcRelSpaceBoundary
    {
	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary1stLevel with all required attributes.
	    /// </summary>
	    public IfcRelSpaceBoundary1StLevel(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace,
            IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary) : base(globalId, relatingSpace,
            relatedBuildingElement, physicalOrVirtualBoundary, internalOrExternalBoundary)
        {
            InnerBoundaries = new List<IfcRelSpaceBoundary1StLevel>();
        }

	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary1stLevel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelSpaceBoundary1StLevel(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement,
            IfcConnectionGeometry connectionGeometry, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary, IfcRelSpaceBoundary1StLevel parentBoundary) : base(
            globalId, ownerHistory, name, description, relatingSpace, relatedBuildingElement, connectionGeometry,
            physicalOrVirtualBoundary, internalOrExternalBoundary)
        {
            InnerBoundaries = new List<IfcRelSpaceBoundary1StLevel>();

            ParentBoundary = parentBoundary;
        }

        public IfcRelSpaceBoundary1StLevel ParentBoundary { get; set; } // optional
        public List<IfcRelSpaceBoundary1StLevel> InnerBoundaries { get; set; } // inverse

        public new static IfcRelSpaceBoundary1StLevel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelSpaceBoundary1StLevel>(json);
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
                InternalOrExternalBoundary.ToStepValue(),
                ParentBoundary != null ? ParentBoundary.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}