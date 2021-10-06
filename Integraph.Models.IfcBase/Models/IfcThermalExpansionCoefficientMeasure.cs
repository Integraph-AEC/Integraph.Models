using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermalexpansioncoefficientmeasure.htm
	/// </summary>
	public class IfcThermalExpansionCoefficientMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcThermalExpansionCoefficientMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermalExpansionCoefficientMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermalExpansionCoefficientMeasure(double v)
        {
            return new IfcThermalExpansionCoefficientMeasure(v);
        }

        public static IfcThermalExpansionCoefficientMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermalExpansionCoefficientMeasure>(json);
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