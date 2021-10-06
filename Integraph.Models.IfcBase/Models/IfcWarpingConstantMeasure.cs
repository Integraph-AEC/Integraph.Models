using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcwarpingconstantmeasure.htm
	/// </summary>
	public class IfcWarpingConstantMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcWarpingConstantMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcWarpingConstantMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcWarpingConstantMeasure(double v)
        {
            return new IfcWarpingConstantMeasure(v);
        }

        public static IfcWarpingConstantMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcWarpingConstantMeasure>(json);
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