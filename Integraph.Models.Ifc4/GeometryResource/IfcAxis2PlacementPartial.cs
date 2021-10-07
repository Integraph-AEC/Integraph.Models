using System.Collections.Generic;
using Integraph.Models.Common.Geometry;

namespace Integraph.Models.Ifc4.GeometryResource
{
    // ReSharper disable once InconsistentNaming
    public partial interface IfcAxis2Placement
    {
        IfcDimensionCount Dim { get; }
        List<XbimVector3D> P { get; }
    }

}
