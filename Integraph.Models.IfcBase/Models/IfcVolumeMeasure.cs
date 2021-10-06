using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcvolumemeasure.htm
	/// </summary>
	public class IfcVolumeMeasure : BaseIfc
    {
        internal readonly double _value;

        public IfcVolumeMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcVolumeMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcVolumeMeasure(double v)
        {
            return new IfcVolumeMeasure(v);
        }

        public static IfcVolumeMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcVolumeMeasure>(json);
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