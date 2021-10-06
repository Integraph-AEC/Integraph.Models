using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimMeshSet : IEnumerable<IXbimMesh>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimMesh First { get; }
    }
}
