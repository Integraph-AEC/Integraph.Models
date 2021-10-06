using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcinteger.htm
	/// </summary>
	public class IfcInteger : BaseIfc
    {
        internal int _value;

        public IfcInteger(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcInteger v)
        {
            return v._value;
        }

        public static implicit operator IfcInteger(int v)
        {
            return new IfcInteger(v);
        }

        public static IfcInteger FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcInteger>(json);
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