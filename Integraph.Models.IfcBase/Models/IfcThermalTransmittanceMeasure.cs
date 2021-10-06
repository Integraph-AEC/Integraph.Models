using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermaltransmittancemeasure.htm
	/// </summary>
	public class IfcThermalTransmittanceMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcThermalTransmittanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermalTransmittanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermalTransmittanceMeasure(double v)
        {
            return new IfcThermalTransmittanceMeasure(v);
        }

        public static IfcThermalTransmittanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermalTransmittanceMeasure>(json);
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}