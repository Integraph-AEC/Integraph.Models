using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcfrequencymeasure.htm
	/// </summary>
	public class IfcFrequencyMeasure : BaseIfc
    {
        internal double _value;

        public IfcFrequencyMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcFrequencyMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcFrequencyMeasure(double v)
        {
            return new IfcFrequencyMeasure(v);
        }

        public static IfcFrequencyMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcFrequencyMeasure>(json);
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