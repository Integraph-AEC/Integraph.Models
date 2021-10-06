using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvaporpermeabilitymeasure.htm
	/// </summary>
	public class IfcVaporPermeabilityMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcVaporPermeabilityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcVaporPermeabilityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcVaporPermeabilityMeasure(double v)
        {
            return new IfcVaporPermeabilityMeasure(v);
        }

        public static IfcVaporPermeabilityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVaporPermeabilityMeasure>(json);
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