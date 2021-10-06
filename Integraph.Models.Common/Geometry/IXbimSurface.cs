using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integraph.Models.Common.Geometry
{
    interface IXbimSurface : IXbimGeometryObject
    {
        double Area { get; }
        double Perimeter { get; }
        /// <summary>
        /// Converts the object to a string in BRep format
        /// </summary>
        String ToBRep { get; }
    }
    
}
