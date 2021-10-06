using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcluminousintensitymeasure.htm
	/// </summary>
	public class IfcLuminousIntensityMeasure : BaseIfc
    {
        internal double _value;

        public IfcLuminousIntensityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLuminousIntensityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLuminousIntensityMeasure(double v)
        {
            return new IfcLuminousIntensityMeasure(v);
        }

        public static IfcLuminousIntensityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLuminousIntensityMeasure>(json);
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