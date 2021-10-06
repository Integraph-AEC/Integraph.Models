using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcstructuralanalysismodel.htm" />
	/// </summary>
	public class IfcStructuralAnalysisModel : IfcSystem
    {
	    /// <summary>
	    ///     Construct a IfcStructuralAnalysisModel with all required attributes.
	    /// </summary>
	    public IfcStructuralAnalysisModel(IfcGloballyUniqueId globalId, IfcAnalysisModelTypeEnum predefinedType) :
            base(globalId)
        {
            LoadedBy = new List<IfcStructuralLoadGroup>();
            HasResults = new List<IfcStructuralResultGroup>();

            PredefinedType = predefinedType;
        }

	    /// <summary>
	    ///     Construct a IfcStructuralAnalysisModel with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcStructuralAnalysisModel(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel name,
            IfcText description, IfcLabel objectType, IfcAnalysisModelTypeEnum predefinedType,
            IfcAxis2Placement3D orientationOf2DPlane, List<IfcStructuralLoadGroup> loadedBy,
            List<IfcStructuralResultGroup> hasResults, IfcObjectPlacement sharedPlacement) : base(globalId,
            ownerHistory, name, description, objectType)
        {
            PredefinedType = predefinedType;
            OrientationOf2DPlane = orientationOf2DPlane;
            LoadedBy = loadedBy;
            HasResults = hasResults;
            SharedPlacement = sharedPlacement;
        }

        public IfcAnalysisModelTypeEnum? PredefinedType { get; set; }
        public IfcAxis2Placement3D OrientationOf2DPlane { get; set; } // optional
        public List<IfcStructuralLoadGroup> LoadedBy { get; set; } // optional
        public List<IfcStructuralResultGroup> HasResults { get; set; } // optional
        public IfcObjectPlacement SharedPlacement { get; set; } // optional

        public new static IfcStructuralAnalysisModel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcStructuralAnalysisModel>(json);
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
                PredefinedType.ToStepValue(),
                OrientationOf2DPlane != null ? OrientationOf2DPlane.ToStepValue() : "$",
                LoadedBy != null ? LoadedBy.ToStepValue() : "$",
                HasResults != null ? HasResults.ToStepValue() : "$",
                SharedPlacement != null ? SharedPlacement.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}