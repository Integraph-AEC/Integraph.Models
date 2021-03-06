using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.MeasureResource;
using Integraph.Models.Ifc4.QuantityResource;

namespace Integraph.Models.Ifc4.Interfaces
{
    /// <summary>
    /// Readonly interface for IfcBuildingStorey
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial interface @IIfcBuildingStorey : IIfcSpatialStructureElement
    {
        IEnumerable<IIfcSpace> Spaces { get; }
        IEnumerable<IIfcBuildingStorey> BuildingStoreys { get; }
        IfcAreaMeasure? GrossFloorArea { get; }
        IfcLengthMeasure? TotalHeight { get; }
    }
}


namespace Integraph.Models.Ifc4.ProductExtension
{
    public partial class IfcBuildingStorey
    {
        internal static int CompareStoreysByElevation(IIfcBuildingStorey x, IIfcBuildingStorey y)
        {
            double a = x.Elevation ?? 0;
            double b = y.Elevation ?? 0;
            return a.CompareTo(b);
        }
       
        /// <summary>
        /// Returns all spaces that are sub-spaces of this storey
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IIfcSpace> Spaces
        {
            get
            {              
                return IsDecomposedBy.SelectMany(s => s.RelatedObjects).OfType<IIfcSpace>();
            }
        }


        public IEnumerable<IIfcBuildingStorey> BuildingStoreys
        {
            get
            {
                var storeys = IsDecomposedBy.SelectMany(s => s.RelatedObjects).OfType<IIfcBuildingStorey>().ToList();         
                storeys.Sort(CompareStoreysByElevation);
                return storeys;
            }
        }

#region Properties

        /// <summary>
        /// Returns the Gross Floor Area, if the element base quantity GrossFloorArea is defined
        /// </summary>
        /// <returns></returns>
        public IfcAreaMeasure? GrossFloorArea
        {
            get
            {
                var qArea = GetQuantity<IIfcQuantityArea>("BaseQuantities", "GrossFloorArea") ??
                            GetQuantity<IIfcQuantityArea>("GrossFloorArea");
                return qArea != null ? (IfcAreaMeasure?)qArea.AreaValue : null;
            }
        }

        public IfcLengthMeasure? TotalHeight
        {
            get
            {
                var qLen = GetQuantity<IIfcQuantityLength>("BaseQuantities", "TotalHeight") ??
                           GetQuantity<IIfcQuantityLength>("TotalHeight");
                return qLen != null ? (IfcLengthMeasure?)qLen.LengthValue : null;
            }
        }

#endregion
    }
}
