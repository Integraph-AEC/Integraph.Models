using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermalconductivitymeasure.htm
	/// </summary>
	public class IfcThermalConductivityMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcThermalConductivityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermalConductivityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermalConductivityMeasure(double v)
        {
            return new IfcThermalConductivityMeasure(v);
        }

        public static IfcThermalConductivityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermalConductivityMeasure>(json);
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