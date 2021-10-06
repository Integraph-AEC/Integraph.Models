using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpresentabletext.htm
	/// </summary>
	public class IfcPresentableText : BaseIfc
    {
        internal string _value;

        public IfcPresentableText(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcPresentableText v)
        {
            return v._value;
        }

        public static implicit operator IfcPresentableText(string v)
        {
            return new IfcPresentableText(v);
        }

        public static IfcPresentableText FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPresentableText>(json);
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