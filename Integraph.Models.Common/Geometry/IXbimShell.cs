using Microsoft.Extensions.Logging;
using System;

namespace Integraph.Models.Common.Geometry
{
    /// <summary>
    /// A set of connected faces
    /// </summary>
    public interface IXbimShell : IXbimGeometryObject, IEquatable<IXbimShell>
    {

        IXbimFaceSet Faces { get; }
        IXbimEdgeSet Edges { get; }
        IXbimVertexSet Vertices { get; }
        double SurfaceArea { get; }
        bool IsPolyhedron { get; }
        /// <summary>
        /// The shell is a closed manifold shape
        /// </summary>
        bool IsClosed { get; }
        bool CanCreateSolid();
        IXbimSolid CreateSolid();
        IXbimGeometryObjectSet Cut(IXbimSolidSet toCut, double tolerance, ILogger logger = null);
        IXbimGeometryObjectSet Cut(IXbimSolid toCut, double tolerance, ILogger logger = null);
        IXbimGeometryObjectSet Union(IXbimSolidSet toCut, double tolerance, ILogger logger = null);
        IXbimGeometryObjectSet Union(IXbimSolid toCut, double tolerance, ILogger logger = null);
        IXbimGeometryObjectSet Intersection(IXbimSolidSet toCut, double tolerance, ILogger logger = null);
        IXbimGeometryObjectSet Intersection(IXbimSolid toCut, double tolerance, ILogger logger = null);
        IXbimFaceSet Section(IXbimFace toSection, double tolerance, ILogger logger = null);
        void SaveAsBrep(string fileName);
        /// <summary>
        /// Converts the object to a string in BRep format
        /// </summary>
        String ToBRep { get; }
    }
}
