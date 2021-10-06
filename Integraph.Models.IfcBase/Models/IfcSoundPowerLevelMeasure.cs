using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsoundpowerlevelmeasure.htm
	/// </summary>
	public class IfcSoundPowerLevelMeasure : BaseIfc
    {
        internal double _value;

        public IfcSoundPowerLevelMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSoundPowerLevelMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSoundPowerLevelMeasure(double v)
        {
            return new IfcSoundPowerLevelMeasure(v);
        }

        public static IfcSoundPowerLevelMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSoundPowerLevelMeasure>(json);
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