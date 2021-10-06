using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcspecificheatcapacitymeasure.htm
	/// </summary>
	public class IfcSpecificHeatCapacityMeasure : BaseIfc
    {
        internal double _value;

        public IfcSpecificHeatCapacityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSpecificHeatCapacityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSpecificHeatCapacityMeasure(double v)
        {
            return new IfcSpecificHeatCapacityMeasure(v);
        }

        public static IfcSpecificHeatCapacityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSpecificHeatCapacityMeasure>(json);
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