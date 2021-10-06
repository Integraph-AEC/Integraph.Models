using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcluminousintensitydistributionmeasure.htm
	/// </summary>
	public class IfcLuminousIntensityDistributionMeasure : BaseIfc
    {
        internal double _value;

        public IfcLuminousIntensityDistributionMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLuminousIntensityDistributionMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLuminousIntensityDistributionMeasure(double v)
        {
            return new IfcLuminousIntensityDistributionMeasure(v);
        }

        public static IfcLuminousIntensityDistributionMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLuminousIntensityDistributionMeasure>(json);
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