using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctime.htm
	/// </summary>
	public class IfcTime : BaseIfc
    {
        internal readonly string _value;

        public IfcTime(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcTime v)
        {
            return v._value;
        }

        public static implicit operator IfcTime(string v)
        {
            return new IfcTime(v);
        }

        public static IfcTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTime>(json);
        }

        public override string ToString()
        {
            return _value;
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}