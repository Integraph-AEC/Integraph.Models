using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcangularvelocitymeasure.htm
	/// </summary>
	public class IfcAngularVelocityMeasure : BaseIfc
    {
        internal double _value;

        public IfcAngularVelocityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcAngularVelocityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcAngularVelocityMeasure(double v)
        {
            return new IfcAngularVelocityMeasure(v);
        }

        public static IfcAngularVelocityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAngularVelocityMeasure>(json);
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