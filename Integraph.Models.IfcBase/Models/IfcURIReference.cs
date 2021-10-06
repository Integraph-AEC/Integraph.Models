using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcurireference.htm
	/// </summary>
	public class IfcUriReference : BaseIfc
    {
        internal readonly string _value;

        public IfcUriReference(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcUriReference v)
        {
            return v._value;
        }

        public static implicit operator IfcUriReference(string v)
        {
            return new IfcUriReference(v);
        }

        public static IfcUriReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcUriReference>(json);
        }

        public override string ToString()
        {
            return _value;
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}