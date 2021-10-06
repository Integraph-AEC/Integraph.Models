using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclinearvelocitymeasure.htm
	/// </summary>
	public class IfcLinearVelocityMeasure : BaseIfc
    {
        internal double _value;

        public IfcLinearVelocityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLinearVelocityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLinearVelocityMeasure(double v)
        {
            return new IfcLinearVelocityMeasure(v);
        }

        public static IfcLinearVelocityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLinearVelocityMeasure>(json);
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