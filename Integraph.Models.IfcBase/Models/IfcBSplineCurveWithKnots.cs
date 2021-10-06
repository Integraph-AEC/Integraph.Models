using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbsplinecurvewithknots.htm" />
	/// </summary>
	public class IfcBSplineCurveWithKnots : IfcBSplineCurve
    {
	    /// <summary>
	    ///     Construct a IfcBSplineCurveWithKnots with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBSplineCurveWithKnots(IfcInteger degree, List<IfcCartesianPoint> controlPointsList,
            IfcBSplineCurveForm curveForm, IfcLogical closedCurve, IfcLogical selfIntersect,
            List<IfcInteger> knotMultiplicities, List<IfcParameterValue> knots, IfcKnotType knotSpec) : base(degree,
            controlPointsList, curveForm, closedCurve, selfIntersect)
        {
            KnotMultiplicities = knotMultiplicities;
            Knots = knots;
            KnotSpec = knotSpec;
        }

        public List<IfcInteger> KnotMultiplicities { get; set; }
        public List<IfcParameterValue> Knots { get; set; }
        public IfcKnotType? KnotSpec { get; set; }

        [JsonIgnore]
        public IfcInteger UpperIndexOnKnots =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for UpperIndexOnKnots."); // derived

        public new static IfcBSplineCurveWithKnots FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBSplineCurveWithKnots>(json);
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
                KnotSpec != null ? KnotSpec.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}