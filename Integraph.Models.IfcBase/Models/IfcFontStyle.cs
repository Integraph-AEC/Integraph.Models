using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfontstyle.htm
	/// </summary>
	public class IfcFontStyle : BaseIfc
    {
        internal string _value;

        public IfcFontStyle(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcFontStyle v)
        {
            return v._value;
        }

        public static implicit operator IfcFontStyle(string v)
        {
            return new IfcFontStyle(v);
        }

        public static IfcFontStyle FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFontStyle>(json);
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