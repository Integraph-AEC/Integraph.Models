using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfontweight.htm
	/// </summary>
	public class IfcFontWeight : BaseIfc
    {
        internal string _value;

        public IfcFontWeight(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcFontWeight v)
        {
            return v._value;
        }

        public static implicit operator IfcFontWeight(string v)
        {
            return new IfcFontWeight(v);
        }

        public static IfcFontWeight FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFontWeight>(json);
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