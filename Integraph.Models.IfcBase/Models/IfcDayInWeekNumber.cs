using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdayinweeknumber.htm
	/// </summary>
	public class IfcDayInWeekNumber : BaseIfc
    {
        internal int _value;

        public IfcDayInWeekNumber(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcDayInWeekNumber v)
        {
            return v._value;
        }

        public static implicit operator IfcDayInWeekNumber(int v)
        {
            return new IfcDayInWeekNumber(v);
        }

        public static IfcDayInWeekNumber FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDayInWeekNumber>(json);
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