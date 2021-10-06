using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboxalignment.htm
	/// </summary>
	public class IfcBoxAlignment : BaseIfc
    {
        internal IfcLabel _value;

        public IfcBoxAlignment(IfcLabel value)
        {
            _value = value;
        }

        public static implicit operator IfcLabel(IfcBoxAlignment v)
        {
            return v._value;
        }

        public static implicit operator IfcBoxAlignment(IfcLabel v)
        {
            return new IfcBoxAlignment(v);
        }

        public static IfcBoxAlignment FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoxAlignment>(json);
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