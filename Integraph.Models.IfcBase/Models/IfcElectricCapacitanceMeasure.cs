using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectriccapacitancemeasure.htm
	/// </summary>
	public class IfcElectricCapacitanceMeasure : BaseIfc
    {
        internal double _value;

        public IfcElectricCapacitanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcElectricCapacitanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcElectricCapacitanceMeasure(double v)
        {
            return new IfcElectricCapacitanceMeasure(v);
        }

        public static IfcElectricCapacitanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricCapacitanceMeasure>(json);
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