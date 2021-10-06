using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctext.htm
	/// </summary>
	public class IfcText : BaseIfc
    {
        internal string _value;

        public IfcText(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcText v)
        {
            return v._value;
        }

        public static implicit operator IfcText(string v)
        {
            return new IfcText(v);
        }

        public static IfcText FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcText>(json);
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