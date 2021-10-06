namespace Integraph.Models.IfcBase.Models
{
    public class IfcSurfaceOrFaceSurface : Select
    {
        public IfcSurfaceOrFaceSurface(IfcFaceBasedSurfaceModel choice)
        {
            _choice = choice;
        }

        public IfcSurfaceOrFaceSurface(IfcFaceSurface choice)
        {
            _choice = choice;
        }

        public IfcSurfaceOrFaceSurface(IfcSurface choice)
        {
            _choice = choice;
        }
    }
}