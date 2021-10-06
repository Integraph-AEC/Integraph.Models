using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmomentofinertiameasure.htm
	/// </summary>
	public class IfcMomentOfInertiaMeasure : BaseIfc
    {
        internal double _value;

        public IfcMomentOfInertiaMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMomentOfInertiaMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMomentOfInertiaMeasure(double v)
        {
            return new IfcMomentOfInertiaMeasure(v);
        }

        public static IfcMomentOfInertiaMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMomentOfInertiaMeasure>(json);
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