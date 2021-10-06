namespace Integraph.Models.IfcBase.Models
{
    public class IfcSurfaceStyleElementSelect : Select
    {
        public IfcSurfaceStyleElementSelect(IfcExternallyDefinedSurfaceStyle choice)
        {
            _choice = choice;
        }

        public IfcSurfaceStyleElementSelect(IfcSurfaceStyleLighting choice)
        {
            _choice = choice;
        }

        public IfcSurfaceStyleElementSelect(IfcSurfaceStyleRefraction choice)
        {
            _choice = choice;
        }

        public IfcSurfaceStyleElementSelect(IfcSurfaceStyleShading choice)
        {
            _choice = choice;
        }

        public IfcSurfaceStyleElementSelect(IfcSurfaceStyleWithTextures choice)
        {
            _choice = choice;
        }
    }
}