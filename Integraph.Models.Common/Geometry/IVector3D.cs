#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Integraph.Models.Ifc
// Filename:    IVector3D.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

namespace Integraph.Models.Common.Geometry
{
    public interface IVector3D
    {
        double X { get; }
        double Y { get; }
        double Z { get; }
        bool IsInvalid();
       
        
    }
}