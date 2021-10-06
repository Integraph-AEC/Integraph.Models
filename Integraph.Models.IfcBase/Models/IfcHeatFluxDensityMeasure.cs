using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcheatfluxdensitymeasure.htm
	/// </summary>
	public class IfcHeatFluxDensityMeasure : BaseIfc
    {
        internal double _value;

        public IfcHeatFluxDensityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcHeatFluxDensityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcHeatFluxDensityMeasure(double v)
        {
            return new IfcHeatFluxDensityMeasure(v);
        }

        public static IfcHeatFluxDensityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcHeatFluxDensityMeasure>(json);
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