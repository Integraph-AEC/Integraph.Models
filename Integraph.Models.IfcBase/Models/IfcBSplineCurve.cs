using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbsplinecurve.htm" />
	/// </summary>
	public abstract class IfcBSplineCurve : IfcBoundedCurve
    {
	    /// <summary>
	    ///     Construct a IfcBSplineCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBSplineCurve(IfcInteger degree, List<IfcCartesianPoint> controlPointsList,
            IfcBSplineCurveForm curveForm, IfcLogical closedCurve, IfcLogical selfIntersect)
        {
            Degree = degree;
            ControlPointsList = controlPointsList;
            CurveForm = curveForm;
            ClosedCurve = closedCurve;
            SelfIntersect = selfIntersect;
        }

        public IfcInteger Degree { get; set; }
        public List<IfcCartesianPoint> ControlPointsList { get; set; }
        public IfcBSplineCurveForm? CurveForm { get; set; }
        public IfcLogical ClosedCurve { get; set; }
        public IfcLogical SelfIntersect { get; set; }

        [JsonIgnore]
        public IfcInteger UpperIndexOnControlPoints =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for UpperIndexOnControlPoints."); // derived

        [JsonIgnore]
        public List<IfcCartesianPoint> ControlPoints =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for ControlPoints."); // derived

        public new static IfcBSplineCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBSplineCurve>(json);
        }
    }
}