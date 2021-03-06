using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimVertexSet : IEnumerable<IXbimVertex>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimVertex First { get; }
    }
}
