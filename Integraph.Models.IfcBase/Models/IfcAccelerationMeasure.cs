using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcaccelerationmeasure.htm
	/// </summary>
	public class IfcAccelerationMeasure : BaseIfc
    {
        internal double _value;

        public IfcAccelerationMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcAccelerationMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcAccelerationMeasure(double v)
        {
            return new IfcAccelerationMeasure(v);
        }

        public static IfcAccelerationMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAccelerationMeasure>(json);
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