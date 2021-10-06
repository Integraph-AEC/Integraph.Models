using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmagneticfluxmeasure.htm
	/// </summary>
	public class IfcMagneticFluxMeasure : BaseIfc
    {
        internal double _value;

        public IfcMagneticFluxMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMagneticFluxMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMagneticFluxMeasure(double v)
        {
            return new IfcMagneticFluxMeasure(v);
        }

        public static IfcMagneticFluxMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMagneticFluxMeasure>(json);
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