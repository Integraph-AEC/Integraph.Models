using Integraph.Models.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace

namespace Integraph.Models.Ifc2x3.ProductExtension
{
    public partial class IfcElement : IIfcDistributionElement
    {

        IEnumerable<IIfcRelConnectsPortToElement> IIfcDistributionElement.HasPorts
        {
            get { return HasPorts; }
        }
    }
}