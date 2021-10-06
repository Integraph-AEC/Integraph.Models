using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimCurveSet : IEnumerable<IXbimCurve>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimCurve First { get; }
    }
}
