using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctextfontname.htm
	/// </summary>
	public class IfcTextFontName : BaseIfc
    {
        internal string _value;

        public IfcTextFontName(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcTextFontName v)
        {
            return v._value;
        }

        public static implicit operator IfcTextFontName(string v)
        {
            return new IfcTextFontName(v);
        }

        public static IfcTextFontName FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTextFontName>(json);
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