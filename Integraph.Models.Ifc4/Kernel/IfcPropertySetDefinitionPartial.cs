using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Integraph.Models.Ifc4.Interfaces;

namespace Integraph.Models.Ifc4.Kernel
{
    public abstract partial class IfcPropertySetDefinition 
    {
        public IEnumerable<IIfcPropertySetDefinition> PropertySetDefinitions
        {
            get
            {
                return new IIfcPropertySetDefinition[] { this };
            }
        }
    }
}
