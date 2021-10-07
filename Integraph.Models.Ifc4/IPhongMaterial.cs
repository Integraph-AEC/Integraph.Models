using Integraph.Models.Ifc4.Interfaces;

namespace Integraph.Models.Ifc4
{
    public interface IPhongMaterial
    {
        string Name { get; set; }
        RgbaColour AmbientColour { get; set; }
        RgbaColour DiffuseColour { get; set; }
        RgbaColour EmissiveColour { get; set; }
        RgbaColour SpecularColour { get; set; }
        double SpecularShininess{ get; set; }
        IIfcPixelTexture DiffuseMap { get; set; }
        IIfcPixelTexture DisplacementMap{ get; set; }
        IIfcPixelTexture NormalMap { get; set; }
    }
}
