using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbsplinesurface.htm" />
	/// </summary>
	public abstract class IfcBSplineSurface : IfcBoundedSurface
    {
	    /// <summary>
	    ///     Construct a IfcBSplineSurface with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBSplineSurface(IfcInteger uDegree, IfcInteger vDegree,
            List<List<IfcCartesianPoint>> controlPointsList, IfcBSplineSurfaceForm surfaceForm, IfcLogical uClosed,
            IfcLogical vClosed, IfcLogical selfIntersect)
        {
            UDegree = uDegree;
            VDegree = vDegree;
            ControlPointsList = controlPointsList;
            SurfaceForm = surfaceForm;
            UClosed = uClosed;
            VClosed = vClosed;
            SelfIntersect = selfIntersect;
        }

        public IfcInteger UDegree { get; set; }
        public IfcInteger VDegree { get; set; }
        public List<List<IfcCartesianPoint>> ControlPointsList { get; set; }
        public IfcBSplineSurfaceForm? SurfaceForm { get; set; }
        public IfcLogical UClosed { get; set; }
        public IfcLogical VClosed { get; set; }
        public IfcLogical SelfIntersect { get; set; }

        [JsonIgnore]
        public IfcInteger UUpper =>
            throw new NotImplementedException("Derived property logic has been implemented for UUpper."); // derived

        [JsonIgnore]
        public IfcInteger VUpper =>
            throw new NotImplementedException("Derived property logic has been implemented for VUpper."); // derived

        [JsonIgnore]
        public List<List<IfcCartesianPoint>> ControlPoints =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for ControlPoints."); // derived

        public new static IfcBSplineSurface FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBSplineSurface>(json);
        }
    }
}