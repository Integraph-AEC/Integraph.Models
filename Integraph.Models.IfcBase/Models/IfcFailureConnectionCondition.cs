using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfailureconnectioncondition.htm" />
	/// </summary>
	public class IfcFailureConnectionCondition : IfcStructuralConnectionCondition
    {
	    /// <summary>
	    ///     Construct a IfcFailureConnectionCondition with all required attributes.
	    /// </summary>
	    public IfcFailureConnectionCondition()
        {
        }

	    /// <summary>
	    ///     Construct a IfcFailureConnectionCondition with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcFailureConnectionCondition(IfcLabel name, IfcForceMeasure tensionFailureX,
            IfcForceMeasure tensionFailureY, IfcForceMeasure tensionFailureZ, IfcForceMeasure compressionFailureX,
            IfcForceMeasure compressionFailureY, IfcForceMeasure compressionFailureZ) : base(name)
        {
            TensionFailureX = tensionFailureX;
            TensionFailureY = tensionFailureY;
            TensionFailureZ = tensionFailureZ;
            CompressionFailureX = compressionFailureX;
            CompressionFailureY = compressionFailureY;
            CompressionFailureZ = compressionFailureZ;
        }

        public IfcForceMeasure TensionFailureX { get; set; } // optional
        public IfcForceMeasure TensionFailureY { get; set; } // optional
        public IfcForceMeasure TensionFailureZ { get; set; } // optional
        public IfcForceMeasure CompressionFailureX { get; set; } // optional
        public IfcForceMeasure CompressionFailureY { get; set; } // optional
        public IfcForceMeasure CompressionFailureZ { get; set; } // optional

        public new static IfcFailureConnectionCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFailureConnectionCondition>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            TensionFailureX != null ? TensionFailureX.ToStepValue() : "$",
	            TensionFailureY != null ? TensionFailureY.ToStepValue() : "$",
	            TensionFailureZ != null ? TensionFailureZ.ToStepValue() : "$",
	            CompressionFailureX != null ? CompressionFailureX.ToStepValue() : "$",
	            CompressionFailureY != null ? CompressionFailureY.ToStepValue() : "$",
	            CompressionFailureZ != null ? CompressionFailureZ.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}