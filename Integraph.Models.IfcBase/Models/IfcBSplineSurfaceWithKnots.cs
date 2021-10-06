using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbsplinesurfacewithknots.htm" />
	/// </summary>
	public class IfcBSplineSurfaceWithKnots : IfcBSplineSurface
    {
	    /// <summary>
	    ///     Construct a IfcBSplineSurfaceWithKnots with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBSplineSurfaceWithKnots(IfcInteger uDegree, IfcInteger vDegree,
            List<List<IfcCartesianPoint>> controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed,
            IfcLogical vClosed, IfcLogical selfIntersect, List<IfcInteger> uMultiplicities,
            List<IfcInteger> vMultiplicities, List<IfcParameterValue> uKnots, List<IfcParameterValue> vKnots,
            IfcKnotType knotSpec) : base(uDegree, vDegree, controlPointsList, surfaceForm, uClosed, vClosed,
            selfIntersect)
        {
            UMultiplicities = uMultiplicities;
            VMultiplicities = vMultiplicities;
            UKnots = uKnots;
            VKnots = vKnots;
            KnotSpec = knotSpec;
        }

        public List<IfcInteger> UMultiplicities { get; set; }
        public List<IfcInteger> VMultiplicities { get; set; }
        public List<IfcParameterValue> UKnots { get; set; }
        public List<IfcParameterValue> VKnots { get; set; }
        public IfcKnotType? KnotSpec { get; set; }

        [JsonIgnore]
        public IfcInteger KnotVUpper =>
            throw new NotImplementedException("Derived property logic has been implemented for KnotVUpper."); // derived

        [JsonIgnore]
        public IfcInteger KnotUUpper =>
            throw new NotImplementedException("Derived property logic has been implemented for KnotUUpper."); // derived

        public new static IfcBSplineSurfaceWithKnots FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBSplineSurfaceWithKnots>(json);
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
                KnotSpec != null ? KnotSpec.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}