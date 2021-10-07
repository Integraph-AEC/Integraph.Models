using System.Linq;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.ProductExtension;


namespace Integraph.Models.Ifc4.Interfaces
{
    /// <summary>
    /// Readonly interface for IfcProduct
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial interface @IIfcProduct
    {
        /// <summary>
        /// Returns the spatial structural elements that this product is in
        /// </summary>
        /// <returns></returns>
        IIfcSpatialElement IsContainedIn { get; }

    }
}

namespace Integraph.Models.Ifc4.Kernel
{
    public abstract partial class @IfcProduct
    {
        public IIfcSpatialElement IsContainedIn
        {
            get
            {
                return Model.Instances.Where<IIfcRelContainedInSpatialStructure>(r => r.RelatedElements.Contains(this)).Select(s => s.RelatingStructure).FirstOrDefault();
            }
        }
    }

}
