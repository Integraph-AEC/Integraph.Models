using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwarpingmomentmeasure.htm
	/// </summary>
	public class IfcWarpingMomentMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcWarpingMomentMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcWarpingMomentMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcWarpingMomentMeasure(double v)
        {
            return new IfcWarpingMomentMeasure(v);
        }

        public static IfcWarpingMomentMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWarpingMomentMeasure>(json);
        }

        public override string ToString()
        {
            return _value.ToString(CultureInfo.InvariantCulture);
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            return isSelectOption ? $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})" : _value.ToStepValue(isSelectOption);
        }
    }
}