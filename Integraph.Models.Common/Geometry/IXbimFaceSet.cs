using System.Collections.Generic;

namespace Integraph.Models.Common.Geometry
{
    public interface IXbimFaceSet : IEnumerable<IXbimFace>, IXbimGeometryObject
    {
        int Count { get; }
        IXbimFace First { get; }
    }
}
