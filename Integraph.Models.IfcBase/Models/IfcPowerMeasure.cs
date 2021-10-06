using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpowermeasure.htm
	/// </summary>
	public class IfcPowerMeasure : BaseIfc
    {
        internal double _value;

        public IfcPowerMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcPowerMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPowerMeasure(double v)
        {
            return new IfcPowerMeasure(v);
        }

        public static IfcPowerMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPowerMeasure>(json);
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