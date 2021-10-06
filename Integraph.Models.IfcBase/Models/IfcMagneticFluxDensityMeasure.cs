using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmagneticfluxdensitymeasure.htm
	/// </summary>
	public class IfcMagneticFluxDensityMeasure : BaseIfc
    {
        internal double _value;

        public IfcMagneticFluxDensityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMagneticFluxDensityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMagneticFluxDensityMeasure(double v)
        {
            return new IfcMagneticFluxDensityMeasure(v);
        }

        public static IfcMagneticFluxDensityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMagneticFluxDensityMeasure>(json);
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