using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsolidanglemeasure.htm
	/// </summary>
	public class IfcSolidAngleMeasure : BaseIfc
    {
        internal double _value;

        public IfcSolidAngleMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSolidAngleMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSolidAngleMeasure(double v)
        {
            return new IfcSolidAngleMeasure(v);
        }

        public static IfcSolidAngleMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSolidAngleMeasure>(json);
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