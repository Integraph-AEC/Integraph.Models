using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcisothermalmoisturecapacitymeasure.htm
	/// </summary>
	public class IfcIsothermalMoistureCapacityMeasure : BaseIfc
    {
        internal double _value;

        public IfcIsothermalMoistureCapacityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcIsothermalMoistureCapacityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcIsothermalMoistureCapacityMeasure(double v)
        {
            return new IfcIsothermalMoistureCapacityMeasure(v);
        }

        public static IfcIsothermalMoistureCapacityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIsothermalMoistureCapacityMeasure>(json);
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