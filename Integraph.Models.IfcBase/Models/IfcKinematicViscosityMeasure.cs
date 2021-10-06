using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifckinematicviscositymeasure.htm
	/// </summary>
	public class IfcKinematicViscosityMeasure : BaseIfc
    {
        internal double _value;

        public IfcKinematicViscosityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcKinematicViscosityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcKinematicViscosityMeasure(double v)
        {
            return new IfcKinematicViscosityMeasure(v);
        }

        public static IfcKinematicViscosityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcKinematicViscosityMeasure>(json);
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