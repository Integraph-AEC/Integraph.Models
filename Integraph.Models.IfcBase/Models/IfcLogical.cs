using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclogical.htm
	/// </summary>
	public class IfcLogical : BaseIfc
    {
        internal bool? _value;

        public IfcLogical(bool? value)
        {
            _value = value;
        }

        public static implicit operator bool?(IfcLogical v)
        {
            return v._value;
        }

        public static implicit operator IfcLogical(bool? v)
        {
            return new IfcLogical(v);
        }

        public static IfcLogical FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLogical>(json);
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