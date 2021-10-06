using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmonthinyearnumber.htm
	/// </summary>
	public class IfcMonthInYearNumber : BaseIfc
    {
        internal int _value;

        public IfcMonthInYearNumber(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcMonthInYearNumber v)
        {
            return v._value;
        }

        public static implicit operator IfcMonthInYearNumber(int v)
        {
            return new IfcMonthInYearNumber(v);
        }

        public static IfcMonthInYearNumber FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMonthInYearNumber>(json);
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