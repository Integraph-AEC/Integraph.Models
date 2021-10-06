using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreal.htm
	/// </summary>
	public class IfcReal : BaseIfc
    {
        internal double _value;

        public IfcReal(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcReal v)
        {
            return v._value;
        }

        public static implicit operator IfcReal(double v)
        {
            return new IfcReal(v);
        }

        public static IfcReal FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReal>(json);
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