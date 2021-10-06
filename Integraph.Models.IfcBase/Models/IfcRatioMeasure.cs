using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcratiomeasure.htm
	/// </summary>
	public class IfcRatioMeasure : BaseIfc
    {
        internal double _value;

        public IfcRatioMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcRatioMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcRatioMeasure(double v)
        {
            return new IfcRatioMeasure(v);
        }

        public static IfcRatioMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRatioMeasure>(json);
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