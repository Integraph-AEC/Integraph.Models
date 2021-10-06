using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrationalbsplinesurfacewithknots.htm" />
	/// </summary>
	public class IfcRationalBSplineSurfaceWithKnots : IfcBSplineSurfaceWithKnots
    {
	    /// <summary>
	    ///     Construct a IfcRationalBSplineSurfaceWithKnots with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRationalBSplineSurfaceWithKnots(IfcInteger uDegree, IfcInteger vDegree,
            List<List<IfcCartesianPoint>> controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed,
            IfcLogical vClosed, IfcLogical selfIntersect, List<IfcInteger> uMultiplicities,
            List<IfcInteger> vMultiplicities, List<IfcParameterValue> uKnots, List<IfcParameterValue> vKnots,
            IfcKnotType knotSpec, List<List<IfcReal>> weightsData) : base(uDegree, vDegree, controlPointsList,
            surfaceForm, uClosed, vClosed, selfIntersect, uMultiplicities, vMultiplicities, uKnots, vKnots, knotSpec)
        {
            WeightsData = weightsData;
        }

        public List<List<IfcReal>> WeightsData { get; set; }

        [JsonIgnore]
        public List<List<IfcReal>> Weights =>
            throw new NotImplementedException("Derived property logic has been implemented for Weights."); // derived

        public new static IfcRationalBSplineSurfaceWithKnots FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRationalBSplineSurfaceWithKnots>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                UDegree != null ? UDegree.ToStepValue() : "$",
                VDegree != null ? VDegree.ToStepValue() : "$",
                ControlPointsList != null ? ControlPointsList.ToStepValue() : "$",
                SurfaceForm != null ? SurfaceForm.ToStepValue() : "$",
                UClosed != null ? UClosed.ToStepValue() : "$",
                VClosed != null ? VClosed.ToStepValue() : "$",
                SelfIntersect != null ? SelfIntersect.ToStepValue() : "$",
                UMultiplicities != null ? UMultiplicities.ToStepValue() : "$",
                VMultiplicities != null ? VMultiplicities.ToStepValue() : "$",
                UKnots != null ? UKnots.ToStepValue() : "$",
                VKnots != null ? VKnots.ToStepValue() : "$",
                KnotSpec != null ? KnotSpec.ToStepValue() : "$",
                WeightsData != null ? WeightsData.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}