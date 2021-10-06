using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextalignment.htm
	/// </summary>
	public class IfcTextAlignment : BaseIfc
    {
        internal string _value;

        public IfcTextAlignment(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcTextAlignment v)
        {
            return v._value;
        }

        public static implicit operator IfcTextAlignment(string v)
        {
            return new IfcTextAlignment(v);
        }

        public static IfcTextAlignment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextAlignment>(json);
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