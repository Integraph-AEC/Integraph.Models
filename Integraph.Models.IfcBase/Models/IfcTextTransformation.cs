using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctexttransformation.htm
	/// </summary>
	public class IfcTextTransformation : BaseIfc
    {
        internal string _value;

        public IfcTextTransformation(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcTextTransformation v)
        {
            return v._value;
        }

        public static implicit operator IfcTextTransformation(string v)
        {
            return new IfcTextTransformation(v);
        }

        public static IfcTextTransformation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextTransformation>(json);
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