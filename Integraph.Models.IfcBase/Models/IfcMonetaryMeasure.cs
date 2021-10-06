using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmonetarymeasure.htm
	/// </summary>
	public class IfcMonetaryMeasure : BaseIfc
    {
        internal double _value;

        public IfcMonetaryMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMonetaryMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMonetaryMeasure(double v)
        {
            return new IfcMonetaryMeasure(v);
        }

        public static IfcMonetaryMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMonetaryMeasure>(json);
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