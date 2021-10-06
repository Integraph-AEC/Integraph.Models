using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermalresistancemeasure.htm
	/// </summary>
	public class IfcThermalResistanceMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcThermalResistanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermalResistanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermalResistanceMeasure(double v)
        {
            return new IfcThermalResistanceMeasure(v);
        }

        public static IfcThermalResistanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermalResistanceMeasure>(json);
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