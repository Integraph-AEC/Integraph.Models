using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcplanarforcemeasure.htm
	/// </summary>
	public class IfcPlanarForceMeasure : BaseIfc
    {
        internal double _value;

        public IfcPlanarForceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcPlanarForceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPlanarForceMeasure(double v)
        {
            return new IfcPlanarForceMeasure(v);
        }

        public static IfcPlanarForceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPlanarForceMeasure>(json);
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