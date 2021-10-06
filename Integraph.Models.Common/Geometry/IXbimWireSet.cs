using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimWireSet : IEnumerable<IXbimWire>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimWire First { get; }
    }
}
