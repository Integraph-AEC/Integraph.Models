using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdatetime.htm
	/// </summary>
	public class IfcDateTime : BaseIfc
    {
        internal string _value;

        public IfcDateTime(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcDateTime v)
        {
            return v._value;
        }

        public static implicit operator IfcDateTime(string v)
        {
            return new IfcDateTime(v);
        }

        public static IfcDateTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDateTime>(json);
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