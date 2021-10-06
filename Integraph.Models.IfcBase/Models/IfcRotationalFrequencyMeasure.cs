using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrotationalfrequencymeasure.htm
	/// </summary>
	public class IfcRotationalFrequencyMeasure : BaseIfc
    {
        internal double _value;

        public IfcRotationalFrequencyMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcRotationalFrequencyMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcRotationalFrequencyMeasure(double v)
        {
            return new IfcRotationalFrequencyMeasure(v);
        }

        public static IfcRotationalFrequencyMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRotationalFrequencyMeasure>(json);
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