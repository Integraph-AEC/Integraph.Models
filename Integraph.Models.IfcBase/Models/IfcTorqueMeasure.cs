using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctorquemeasure.htm
	/// </summary>
	public class IfcTorqueMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcTorqueMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcTorqueMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcTorqueMeasure(double v)
        {
            return new IfcTorqueMeasure(v);
        }

        public static IfcTorqueMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTorqueMeasure>(json);
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