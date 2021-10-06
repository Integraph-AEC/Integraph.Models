using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpressuremeasure.htm
	/// </summary>
	public class IfcPressureMeasure : BaseIfc
    {
        internal double _value;

        public IfcPressureMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcPressureMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPressureMeasure(double v)
        {
            return new IfcPressureMeasure(v);
        }

        public static IfcPressureMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPressureMeasure>(json);
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