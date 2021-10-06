using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctimestamp.htm
	/// </summary>
	public class IfcTimeStamp : BaseIfc
    {
        internal readonly int _value;

        public IfcTimeStamp(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcTimeStamp v)
        {
            return v._value;
        }

        public static implicit operator IfcTimeStamp(int v)
        {
            return new IfcTimeStamp(v);
        }

        public static IfcTimeStamp FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTimeStamp>(json);
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}