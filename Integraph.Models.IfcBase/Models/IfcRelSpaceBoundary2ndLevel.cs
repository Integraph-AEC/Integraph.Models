using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrelspaceboundary2ndlevel.htm" />
	/// </summary>
	public class IfcRelSpaceBoundary2NdLevel : IfcRelSpaceBoundary1StLevel
    {
	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary2ndLevel with all required attributes.
	    /// </summary>
	    public IfcRelSpaceBoundary2NdLevel(IfcGloballyUniqueId globalId, IfcSpaceBoundarySelect relatingSpace,
            IfcElement relatedBuildingElement, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary) : base(globalId, relatingSpace,
            relatedBuildingElement, physicalOrVirtualBoundary, internalOrExternalBoundary)
        {
            Corresponds = new List<IfcRelSpaceBoundary2NdLevel>();
        }

	    /// <summary>
	    ///     Construct a IfcRelSpaceBoundary2ndLevel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRelSpaceBoundary2NdLevel(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcSpaceBoundarySelect relatingSpace, IfcElement relatedBuildingElement,
            IfcConnectionGeometry connectionGeometry, IfcPhysicalOrVirtualEnum physicalOrVirtualBoundary,
            IfcInternalOrExternalEnum internalOrExternalBoundary, IfcRelSpaceBoundary1StLevel parentBoundary,
            IfcRelSpaceBoundary2NdLevel correspondingBoundary) : base(globalId, ownerHistory, name, description,
            relatingSpace, relatedBuildingElement, connectionGeometry, physicalOrVirtualBoundary,
            internalOrExternalBoundary, parentBoundary)
        {
            Corresponds = new List<IfcRelSpaceBoundary2NdLevel>();

            CorrespondingBoundary = correspondingBoundary;
        }

        public IfcRelSpaceBoundary2NdLevel CorrespondingBoundary { get; set; } // optional
        public List<IfcRelSpaceBoundary2NdLevel> Corresponds { get; set; } // inverse

        public new static IfcRelSpaceBoundary2NdLevel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRelSpaceBoundary2NdLevel>(json);
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
                ParentBoundary != null ? ParentBoundary.ToStepValue() : "$",
                CorrespondingBoundary != null ? CorrespondingBoundary.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}