using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrationalbsplinecurvewithknots.htm" />
	/// </summary>
	public class IfcRationalBSplineCurveWithKnots : IfcBSplineCurveWithKnots
    {
	    /// <summary>
	    ///     Construct a IfcRationalBSplineCurveWithKnots with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcRationalBSplineCurveWithKnots(IfcInteger degree, List<IfcCartesianPoint> controlPointsList,
            IfcBSplineCurveForm curveForm, IfcLogical closedCurve, IfcLogical selfIntersect,
            List<IfcInteger> knotMultiplicities, List<IfcParameterValue> knots, IfcKnotType knotSpec,
            List<IfcReal> weightsData) : base(degree, controlPointsList, curveForm, closedCurve, selfIntersect,
            knotMultiplicities, knots, knotSpec)
        {
            WeightsData = weightsData;
        }

        public List<IfcReal> WeightsData { get; set; }

        [JsonIgnore]
        public List<IfcReal> Weights =>
            throw new NotImplementedException("Derived property logic has been implemented for Weights."); // derived

        public new static IfcRationalBSplineCurveWithKnots FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRationalBSplineCurveWithKnots>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Degree != null ? Degree.ToStepValue() : "$",
                ControlPointsList != null ? ControlPointsList.ToStepValue() : "$",
                CurveForm != null ? CurveForm.ToStepValue() : "$",
                ClosedCurve != null ? ClosedCurve.ToStepValue() : "$",
                SelfIntersect != null ? SelfIntersect.ToStepValue() : "$",
                KnotMultiplicities != null ? KnotMultiplicities.ToStepValue() : "$",
                Knots != null ? Knots.ToStepValue() : "$",
                KnotSpec != null ? KnotSpec.ToStepValue() : "$",
                WeightsData != null ? WeightsData.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}