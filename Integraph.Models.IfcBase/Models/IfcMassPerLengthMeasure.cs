using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmassperlengthmeasure.htm
	/// </summary>
	public class IfcMassPerLengthMeasure : BaseIfc
    {
        internal double _value;

        public IfcMassPerLengthMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMassPerLengthMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMassPerLengthMeasure(double v)
        {
            return new IfcMassPerLengthMeasure(v);
        }

        public static IfcMassPerLengthMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMassPerLengthMeasure>(json);
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