using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextdecoration.htm
	/// </summary>
	public class IfcTextDecoration : BaseIfc
    {
        internal string _value;

        public IfcTextDecoration(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcTextDecoration v)
        {
            return v._value;
        }

        public static implicit operator IfcTextDecoration(string v)
        {
            return new IfcTextDecoration(v);
        }

        public static IfcTextDecoration FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextDecoration>(json);
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