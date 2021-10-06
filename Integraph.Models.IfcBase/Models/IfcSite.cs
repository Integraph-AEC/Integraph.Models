using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsite.htm" />
	/// </summary>
	public class IfcSite : IfcSpatialStructureElement
    {
	    /// <summary>
	    ///     Construct a IfcSite with all required attributes.
	    /// </summary>
	    public IfcSite(IfcGloballyUniqueId globalId) : base(globalId)
        {
        }

	    /// <summary>
	    ///     Construct a IfcSite with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSite(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            IfcLabel longName, IfcElementCompositionEnum compositionType, IfcCompoundPlaneAngleMeasure refLatitude,
            IfcCompoundPlaneAngleMeasure refLongitude, IfcLengthMeasure refElevation, IfcLabel landTitleNumber,
            IfcPostalAddress siteAddress) : base(globalId, ownerHistory, name, description, objectType, objectPlacement,
            representation, longName, compositionType)
        {
            RefLatitude = refLatitude;
            RefLongitude = refLongitude;
            RefElevation = refElevation;
            LandTitleNumber = landTitleNumber;
            SiteAddress = siteAddress;
        }

        public IfcCompoundPlaneAngleMeasure RefLatitude { get; set; } // optional
        public IfcCompoundPlaneAngleMeasure RefLongitude { get; set; } // optional
        public IfcLengthMeasure RefElevation { get; set; } // optional
        public IfcLabel LandTitleNumber { get; set; } // optional
        public IfcPostalAddress SiteAddress { get; set; } // optional

        public new static IfcSite FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSite>(json);
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
	            ObjectPlacement != null ? ObjectPlacement.ToStepValue() : "$",
	            Representation != null ? Representation.ToStepValue() : "$",
	            LongName != null ? LongName.ToStepValue() : "$",
	            CompositionType.ToStepValue(),
	            RefLatitude != null ? RefLatitude.ToStepValue() : "$",
	            RefLongitude != null ? RefLongitude.ToStepValue() : "$",
	            RefElevation != null ? RefElevation.ToStepValue() : "$",
	            LandTitleNumber != null ? LandTitleNumber.ToStepValue() : "$",
	            SiteAddress != null ? SiteAddress.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}