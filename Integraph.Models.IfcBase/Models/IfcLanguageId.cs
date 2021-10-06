using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclanguageid.htm
	/// </summary>
	public class IfcLanguageId : BaseIfc
    {
        internal IfcIdentifier _value;

        public IfcLanguageId(IfcIdentifier value)
        {
            _value = value;
        }

        public static implicit operator IfcIdentifier(IfcLanguageId v)
        {
            return v._value;
        }

        public static implicit operator IfcLanguageId(IfcIdentifier v)
        {
            return new IfcLanguageId(v);
        }

        public static IfcLanguageId FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLanguageId>(json);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}