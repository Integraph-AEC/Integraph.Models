using System.Collections.Generic;
using Integraph.Models.Ifc4.Interfaces;

namespace Integraph.Models.Ifc4.Interfaces
{
    /// <summary>
    /// Readonly interface for IfcTypeObject
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial interface IIfcTypeObject
    {
        IEnumerable<IIfcRelDefinesByProperties> DefinedByProperties { get; }
    }
}
namespace Integraph.Models.Ifc4.Kernel
{
    public partial class IfcTypeObject
    {
        public IEnumerable<IIfcRelDefinesByProperties> DefinedByProperties
        {
            get
            {
                return Model.Instances.Where<IfcRelDefinesByProperties>(e => e.RelatedObjects.Contains(this), "RelatedObjects", this);
            }
        }

    }
}
