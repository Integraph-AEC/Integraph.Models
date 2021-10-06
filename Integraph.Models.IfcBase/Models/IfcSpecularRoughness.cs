using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspecularroughness.htm
	/// </summary>
	public class IfcSpecularRoughness : BaseIfc
    {
        internal double _value;

        public IfcSpecularRoughness(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSpecularRoughness v)
        {
            return v._value;
        }

        public static implicit operator IfcSpecularRoughness(double v)
        {
            return new IfcSpecularRoughness(v);
        }

        public static IfcSpecularRoughness FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpecularRoughness>(json);
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}