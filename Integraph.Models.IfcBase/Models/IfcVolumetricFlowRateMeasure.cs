using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvolumetricflowratemeasure.htm
	/// </summary>
	public class IfcVolumetricFlowRateMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcVolumetricFlowRateMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcVolumetricFlowRateMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcVolumetricFlowRateMeasure(double v)
        {
            return new IfcVolumetricFlowRateMeasure(v);
        }

        public static IfcVolumetricFlowRateMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVolumetricFlowRateMeasure>(json);
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