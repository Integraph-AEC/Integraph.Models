using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcforcemeasure.htm
	/// </summary>
	public class IfcForceMeasure : BaseIfc
    {
        internal double _value;

        public IfcForceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcForceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcForceMeasure(double v)
        {
            return new IfcForceMeasure(v);
        }

        public static IfcForceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcForceMeasure>(json);
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