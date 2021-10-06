using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectriccurrentmeasure.htm
	/// </summary>
	public class IfcElectricCurrentMeasure : BaseIfc
    {
        internal double _value;

        public IfcElectricCurrentMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcElectricCurrentMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcElectricCurrentMeasure(double v)
        {
            return new IfcElectricCurrentMeasure(v);
        }

        public static IfcElectricCurrentMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricCurrentMeasure>(json);
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