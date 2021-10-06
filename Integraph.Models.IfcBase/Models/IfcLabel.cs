using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclabel.htm
	/// </summary>
	public class IfcLabel : BaseIfc
    {
        internal string _value;

        public IfcLabel(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcLabel v)
        {
            return v._value;
        }

        public static implicit operator IfcLabel(string v)
        {
            return new IfcLabel(v);
        }

        public static IfcLabel FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLabel>(json);
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