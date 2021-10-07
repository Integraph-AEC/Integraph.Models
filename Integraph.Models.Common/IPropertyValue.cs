#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Integraph.Models.Ifc
// Filename:    IPropertyValue.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

using Integraph.Models.Common.Step21;

namespace Integraph.Models.Common
{
    public interface IPropertyValue
    {
        bool BooleanVal { get; }
        string EnumVal { get; }
        object EntityVal { get; }
        byte[] HexadecimalVal { get; }
        long IntegerVal { get; }
        double NumberVal { get; }
        double RealVal { get; }
        string StringVal { get; }
        StepParserType Type { get; }
    }
}