using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdayinmonthnumber.htm
	/// </summary>
	public class IfcDayInMonthNumber : BaseIfc
    {
        internal int _value;

        public IfcDayInMonthNumber(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcDayInMonthNumber v)
        {
            return v._value;
        }

        public static implicit operator IfcDayInMonthNumber(int v)
        {
            return new IfcDayInMonthNumber(v);
        }

        public static IfcDayInMonthNumber FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDayInMonthNumber>(json);
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