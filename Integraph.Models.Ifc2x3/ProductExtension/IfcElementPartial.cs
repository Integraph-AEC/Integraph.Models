using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Ifc2x3.Kernel;

namespace Integraph.Models.Ifc2x3.ProductExtension
{
    public partial class IfcElement
    {

        public IEnumerable<IfcOpeningElement> Openings
        {
            get
            {               
                return Model.Instances.Where<IfcRelVoidsElement>(r => r.RelatingBuildingElement == this).Select(rv => rv.RelatedOpeningElement).OfType<IfcOpeningElement>();
            }
        }

        
    }
}
