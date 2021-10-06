using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclinearmomentmeasure.htm
	/// </summary>
	public class IfcLinearMomentMeasure : BaseIfc
    {
        internal double _value;

        public IfcLinearMomentMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLinearMomentMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLinearMomentMeasure(double v)
        {
            return new IfcLinearMomentMeasure(v);
        }

        public static IfcLinearMomentMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLinearMomentMeasure>(json);
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