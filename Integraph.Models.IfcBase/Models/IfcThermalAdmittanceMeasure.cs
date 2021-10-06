using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcthermaladmittancemeasure.htm
	/// </summary>
	public class IfcThermalAdmittanceMeasure : BaseIfc
    {
        internal double _value;

        public IfcThermalAdmittanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcThermalAdmittanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcThermalAdmittanceMeasure(double v)
        {
            return new IfcThermalAdmittanceMeasure(v);
        }

        public static IfcThermalAdmittanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcThermalAdmittanceMeasure>(json);
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