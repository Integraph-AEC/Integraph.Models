using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclengthmeasure.htm
	/// </summary>
	public class IfcLengthMeasure : BaseIfc
    {
        internal double _value;

        public IfcLengthMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLengthMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLengthMeasure(double v)
        {
            return new IfcLengthMeasure(v);
        }

        public static IfcLengthMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLengthMeasure>(json);
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