using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplaneanglemeasure.htm
	/// </summary>
	public class IfcPlaneAngleMeasure : BaseIfc
    {
        internal double _value;

        public IfcPlaneAngleMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcPlaneAngleMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPlaneAngleMeasure(double v)
        {
            return new IfcPlaneAngleMeasure(v);
        }

        public static IfcPlaneAngleMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlaneAngleMeasure>(json);
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