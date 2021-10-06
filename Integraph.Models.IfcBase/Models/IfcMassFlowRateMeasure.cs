using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmassflowratemeasure.htm
	/// </summary>
	public class IfcMassFlowRateMeasure : BaseIfc
    {
        internal double _value;

        public IfcMassFlowRateMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMassFlowRateMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMassFlowRateMeasure(double v)
        {
            return new IfcMassFlowRateMeasure(v);
        }

        public static IfcMassFlowRateMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMassFlowRateMeasure>(json);
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