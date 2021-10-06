using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcduration.htm
	/// </summary>
	public class IfcDuration : BaseIfc
    {
        internal string _value;

        public IfcDuration(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcDuration v)
        {
            return v._value;
        }

        public static implicit operator IfcDuration(string v)
        {
            return new IfcDuration(v);
        }

        public static IfcDuration FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDuration>(json);
        }

        public override string ToString()
        {
            return _value;
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}