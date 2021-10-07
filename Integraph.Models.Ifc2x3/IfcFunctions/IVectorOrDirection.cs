namespace Integraph.Models.Ifc2x3
{
    internal interface IVectorOrDirection
    {
        int Dim { get; set; }
        double[] DirectionRatios { get; }
    }
}