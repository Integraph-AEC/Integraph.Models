using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermodynamictemperaturemeasure.htm
	/// </summary>
	public class IfcThermodynamicTemperatureMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcThermodynamicTemperatureMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermodynamicTemperatureMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermodynamicTemperatureMeasure(double v)
        {
            return new IfcThermodynamicTemperatureMeasure(v);
        }

        public static IfcThermodynamicTemperatureMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermodynamicTemperatureMeasure>(json);
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