using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcnormalisedratiomeasure.htm
	/// </summary>
	public class IfcNormalisedRatioMeasure : BaseIfc
    {
        internal readonly IfcRatioMeasure _value;

        public IfcNormalisedRatioMeasure(IfcRatioMeasure value)
        {
            _value = value;
        }

        public static implicit operator IfcRatioMeasure(IfcNormalisedRatioMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcNormalisedRatioMeasure(IfcRatioMeasure v)
        {
            return new IfcNormalisedRatioMeasure(v);
        }

        public static IfcNormalisedRatioMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcNormalisedRatioMeasure>(json);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}