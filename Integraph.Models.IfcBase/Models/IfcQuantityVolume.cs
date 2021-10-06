using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcquantityvolume.htm" />
	/// </summary>
	public class IfcQuantityVolume : IfcPhysicalSimpleQuantity
    {
	    /// <summary>
	    ///     Construct a IfcQuantityVolume with all required attributes.
	    /// </summary>
	    public IfcQuantityVolume(IfcLabel name, IfcVolumeMeasure volumeValue) : base(name)
        {
            VolumeValue = volumeValue;
        }

	    /// <summary>
	    ///     Construct a IfcQuantityVolume with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcQuantityVolume(IfcLabel name, IfcText description, IfcNamedUnit unit, IfcVolumeMeasure volumeValue,
            IfcLabel formula) : base(name, description, unit)
        {
            VolumeValue = volumeValue;
            Formula = formula;
        }

        public IfcVolumeMeasure VolumeValue { get; set; }
        public IfcLabel Formula { get; set; } // optional

        public new static IfcQuantityVolume FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcQuantityVolume>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            Description != null ? Description.ToStepValue() : "$",
	            Unit != null ? Unit.ToStepValue() : "$",
	            VolumeValue != null ? VolumeValue.ToStepValue() : "$",
	            Formula != null ? Formula.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}