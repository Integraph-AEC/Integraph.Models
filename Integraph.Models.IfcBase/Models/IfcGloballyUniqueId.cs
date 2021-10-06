using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgloballyuniqueid.htm
	/// </summary>
	public class IfcGloballyUniqueId : BaseIfc
    {
        internal string _value;

        public IfcGloballyUniqueId(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcGloballyUniqueId v)
        {
            return v._value;
        }

        public static implicit operator IfcGloballyUniqueId(string v)
        {
            return new IfcGloballyUniqueId(v);
        }

        public static IfcGloballyUniqueId FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGloballyUniqueId>(json);
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