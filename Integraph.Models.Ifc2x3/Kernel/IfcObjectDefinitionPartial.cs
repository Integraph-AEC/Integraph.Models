using System.Linq;
using Integraph.Models.Ifc2x3.MaterialResource;
using Integraph.Models.Ifc2x3.ProductExtension;
using Integraph.Models.Ifc4.Interfaces;

namespace Integraph.Models.Ifc2x3.Kernel
{
    public partial class IfcObjectDefinition
    {     
        public IIfcMaterialSelect Material
        {
            get
            {
                var relMat = HasAssociations.OfType<IIfcRelAssociatesMaterial>().FirstOrDefault();
                if (relMat != null) return relMat.RelatingMaterial;
                return null;
            }
        }
    }
}
