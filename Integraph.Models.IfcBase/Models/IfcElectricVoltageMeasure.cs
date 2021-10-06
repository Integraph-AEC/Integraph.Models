using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectricvoltagemeasure.htm
	/// </summary>
	public class IfcElectricVoltageMeasure : BaseIfc
    {
        internal double _value;

        public IfcElectricVoltageMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcElectricVoltageMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcElectricVoltageMeasure(double v)
        {
            return new IfcElectricVoltageMeasure(v);
        }

        public static IfcElectricVoltageMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricVoltageMeasure>(json);
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}