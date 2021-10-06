using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsoundpressuremeasure.htm
	/// </summary>
	public class IfcSoundPressureMeasure : BaseIfc
    {
        internal double _value;

        public IfcSoundPressureMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSoundPressureMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSoundPressureMeasure(double v)
        {
            return new IfcSoundPressureMeasure(v);
        }

        public static IfcSoundPressureMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSoundPressureMeasure>(json);
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