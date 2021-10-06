using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgrid.htm" />
	/// </summary>
	public class IfcGrid : IfcProduct
    {
	    /// <summary>
	    ///     Construct a IfcGrid with all required attributes.
	    /// </summary>
	    public IfcGrid(IfcGloballyUniqueId globalId, List<IfcGridAxis> uAxes, List<IfcGridAxis> vAxes) : base(globalId)
        {
            WAxes = new List<IfcGridAxis>();
            ContainedInStructure = new List<IfcRelContainedInSpatialStructure>();

            UAxes = uAxes;
            VAxes = vAxes;
        }

	    /// <summary>
	    ///     Construct a IfcGrid with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGrid(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name, IfcText description,
            IfcLabel objectType, IfcObjectPlacement objectPlacement, IfcProductRepresentation representation,
            List<IfcGridAxis> uAxes, List<IfcGridAxis> vAxes, List<IfcGridAxis> wAxes, IfcGridTypeEnum predefinedType) :
            base(globalId, ownerHistory, name, description, objectType, objectPlacement, representation)
        {
            ContainedInStructure = new List<IfcRelContainedInSpatialStructure>();

            UAxes = uAxes;
            VAxes = vAxes;
            WAxes = wAxes;
            PredefinedType = predefinedType;
        }

        public List<IfcGridAxis> UAxes { get; set; }
        public List<IfcGridAxis> VAxes { get; set; }
        public List<IfcGridAxis> WAxes { get; set; } // optional
        public IfcGridTypeEnum? PredefinedType { get; set; } // optional
        public List<IfcRelContainedInSpatialStructure> ContainedInStructure { get; set; } // inverse

        public new static IfcGrid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGrid>(json);
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
	            UAxes != null ? UAxes.ToStepValue() : "$",
	            VAxes != null ? VAxes.ToStepValue() : "$",
	            WAxes != null ? WAxes.ToStepValue() : "$",
	            PredefinedType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}