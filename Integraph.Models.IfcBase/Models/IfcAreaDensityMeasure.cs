using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcareadensitymeasure.htm
	/// </summary>
	public class IfcAreaDensityMeasure : BaseIfc
    {
        internal double _value;

        public IfcAreaDensityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcAreaDensityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcAreaDensityMeasure(double v)
        {
            return new IfcAreaDensityMeasure(v);
        }

        public static IfcAreaDensityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAreaDensityMeasure>(json);
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