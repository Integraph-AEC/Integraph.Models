using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpositiveratiomeasure.htm
	/// </summary>
	public class IfcPositiveRatioMeasure : BaseIfc
    {
        internal IfcRatioMeasure _value;

        public IfcPositiveRatioMeasure(IfcRatioMeasure value)
        {
            _value = value;
        }

        public static implicit operator IfcRatioMeasure(IfcPositiveRatioMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPositiveRatioMeasure(IfcRatioMeasure v)
        {
            return new IfcPositiveRatioMeasure(v);
        }

        public static IfcPositiveRatioMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPositiveRatioMeasure>(json);
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