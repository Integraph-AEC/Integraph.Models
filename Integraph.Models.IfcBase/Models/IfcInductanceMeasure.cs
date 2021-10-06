using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcinductancemeasure.htm
	/// </summary>
	public class IfcInductanceMeasure : BaseIfc
    {
        internal double _value;

        public IfcInductanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcInductanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcInductanceMeasure(double v)
        {
            return new IfcInductanceMeasure(v);
        }

        public static IfcInductanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcInductanceMeasure>(json);
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