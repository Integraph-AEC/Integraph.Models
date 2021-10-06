using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboolean.htm
	/// </summary>
	public class IfcBoolean : BaseIfc
    {
        internal bool _value;

        public IfcBoolean(bool value)
        {
            _value = value;
        }

        public static implicit operator bool(IfcBoolean v)
        {
            return v._value;
        }

        public static implicit operator IfcBoolean(bool v)
        {
            return new IfcBoolean(v);
        }

        public static IfcBoolean FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoolean>(json);
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