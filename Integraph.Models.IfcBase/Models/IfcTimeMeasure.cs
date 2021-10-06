using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimemeasure.htm
	/// </summary>
	public class IfcTimeMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcTimeMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcTimeMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcTimeMeasure(double v)
        {
            return new IfcTimeMeasure(v);
        }

        public static IfcTimeMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTimeMeasure>(json);
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