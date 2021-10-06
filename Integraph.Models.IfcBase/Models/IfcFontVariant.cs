using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfontvariant.htm
	/// </summary>
	public class IfcFontVariant : BaseIfc
    {
        internal string _value;

        public IfcFontVariant(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcFontVariant v)
        {
            return v._value;
        }

        public static implicit operator IfcFontVariant(string v)
        {
            return new IfcFontVariant(v);
        }

        public static IfcFontVariant FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFontVariant>(json);
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