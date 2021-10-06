using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcluminousfluxmeasure.htm
	/// </summary>
	public class IfcLuminousFluxMeasure : BaseIfc
    {
        internal double _value;

        public IfcLuminousFluxMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLuminousFluxMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLuminousFluxMeasure(double v)
        {
            return new IfcLuminousFluxMeasure(v);
        }

        public static IfcLuminousFluxMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLuminousFluxMeasure>(json);
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