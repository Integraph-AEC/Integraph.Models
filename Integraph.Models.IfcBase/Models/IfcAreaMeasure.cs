using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcareameasure.htm
	/// </summary>
	public class IfcAreaMeasure : BaseIfc
    {
        internal double _value;

        public IfcAreaMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcAreaMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcAreaMeasure(double v)
        {
            return new IfcAreaMeasure(v);
        }

        public static IfcAreaMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAreaMeasure>(json);
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