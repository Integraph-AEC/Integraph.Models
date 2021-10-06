using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcbinary.htm
	/// </summary>
	public class IfcBinary : BaseIfc
    {
        internal byte[] _value;

        public IfcBinary(byte[] value)
        {
            _value = value;
        }

        public static implicit operator byte[](IfcBinary v)
        {
            return v._value;
        }

        public static implicit operator IfcBinary(byte[] v)
        {
            return new IfcBinary(v);
        }

        public static IfcBinary FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBinary>(json);
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