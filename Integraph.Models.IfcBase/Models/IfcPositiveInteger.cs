using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpositiveinteger.htm
	/// </summary>
	public class IfcPositiveInteger : BaseIfc
    {
        internal IfcInteger _value;

        public IfcPositiveInteger(IfcInteger value)
        {
            _value = value;
        }

        public static implicit operator IfcInteger(IfcPositiveInteger v)
        {
            return v._value;
        }

        public static implicit operator IfcPositiveInteger(IfcInteger v)
        {
            return new IfcPositiveInteger(v);
        }

        public static IfcPositiveInteger FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPositiveInteger>(json);
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