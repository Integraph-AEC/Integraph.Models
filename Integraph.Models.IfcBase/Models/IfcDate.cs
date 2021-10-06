using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdate.htm
	/// </summary>
	public class IfcDate : BaseIfc
    {
        internal string _value;

        public IfcDate(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcDate v)
        {
            return v._value;
        }

        public static implicit operator IfcDate(string v)
        {
            return new IfcDate(v);
        }

        public static IfcDate FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDate>(json);
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