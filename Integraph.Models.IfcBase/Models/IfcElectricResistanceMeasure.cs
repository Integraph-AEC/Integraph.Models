using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcelectricresistancemeasure.htm
	/// </summary>
	public class IfcElectricResistanceMeasure : BaseIfc
    {
        internal double _value;

        public IfcElectricResistanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcElectricResistanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcElectricResistanceMeasure(double v)
        {
            return new IfcElectricResistanceMeasure(v);
        }

        public static IfcElectricResistanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcElectricResistanceMeasure>(json);
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