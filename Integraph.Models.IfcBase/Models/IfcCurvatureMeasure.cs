using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurvaturemeasure.htm
	/// </summary>
	public class IfcCurvatureMeasure : BaseIfc
    {
        internal double _value;

        public IfcCurvatureMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcCurvatureMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcCurvatureMeasure(double v)
        {
            return new IfcCurvatureMeasure(v);
        }

        public static IfcCurvatureMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurvatureMeasure>(json);
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