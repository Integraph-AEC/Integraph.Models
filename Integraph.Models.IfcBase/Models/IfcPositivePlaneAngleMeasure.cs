using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpositiveplaneanglemeasure.htm
	/// </summary>
	public class IfcPositivePlaneAngleMeasure : BaseIfc
    {
        internal IfcPlaneAngleMeasure _value;

        public IfcPositivePlaneAngleMeasure(IfcPlaneAngleMeasure value)
        {
            _value = value;
        }

        public static implicit operator IfcPlaneAngleMeasure(IfcPositivePlaneAngleMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPositivePlaneAngleMeasure(IfcPlaneAngleMeasure v)
        {
            return new IfcPositivePlaneAngleMeasure(v);
        }

        public static IfcPositivePlaneAngleMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPositivePlaneAngleMeasure>(json);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}