using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcidentifier.htm
	/// </summary>
	public class IfcIdentifier : BaseIfc
    {
        internal string _value;

        public IfcIdentifier(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcIdentifier v)
        {
            return v._value;
        }

        public static implicit operator IfcIdentifier(string v)
        {
            return new IfcIdentifier(v);
        }

        public static IfcIdentifier FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIdentifier>(json);
        }

        public override string ToString()
        {
            return _value;
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}