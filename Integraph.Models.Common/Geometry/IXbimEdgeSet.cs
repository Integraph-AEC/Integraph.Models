using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimEdgeSet : IEnumerable<IXbimEdge>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimEdge First { get; }
    }
}
