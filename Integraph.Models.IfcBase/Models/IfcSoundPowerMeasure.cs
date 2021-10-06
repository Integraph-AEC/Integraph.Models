using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsoundpowermeasure.htm
	/// </summary>
	public class IfcSoundPowerMeasure : BaseIfc
    {
        internal double _value;

        public IfcSoundPowerMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSoundPowerMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSoundPowerMeasure(double v)
        {
            return new IfcSoundPowerMeasure(v);
        }

        public static IfcSoundPowerMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSoundPowerMeasure>(json);
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