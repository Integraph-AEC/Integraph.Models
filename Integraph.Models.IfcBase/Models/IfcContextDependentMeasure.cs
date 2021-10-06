using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccontextdependentmeasure.htm
	/// </summary>
	public class IfcContextDependentMeasure : BaseIfc
    {
        internal double _value;

        public IfcContextDependentMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcContextDependentMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcContextDependentMeasure(double v)
        {
            return new IfcContextDependentMeasure(v);
        }

        public static IfcContextDependentMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcContextDependentMeasure>(json);
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