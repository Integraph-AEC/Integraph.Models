using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdescriptivemeasure.htm
	/// </summary>
	public class IfcDescriptiveMeasure : BaseIfc
    {
        internal string _value;

        public IfcDescriptiveMeasure(string value)
        {
            _value = value;
        }

        public static implicit operator string(IfcDescriptiveMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcDescriptiveMeasure(string v)
        {
            return new IfcDescriptiveMeasure(v);
        }

        public static IfcDescriptiveMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDescriptiveMeasure>(json);
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