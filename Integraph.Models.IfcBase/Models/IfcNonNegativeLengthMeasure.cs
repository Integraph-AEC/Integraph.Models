using System.Globalization;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcnonnegativelengthmeasure.htm
	/// </summary>
	public class IfcNonNegativeLengthMeasure : BaseIfc
    {
        internal IfcLengthMeasure _value;

        public IfcNonNegativeLengthMeasure(IfcLengthMeasure value)
        {
            _value = value;
        }

        public static implicit operator IfcLengthMeasure(IfcNonNegativeLengthMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcNonNegativeLengthMeasure(IfcLengthMeasure v)
        {
            return new IfcNonNegativeLengthMeasure(v);
        }

        public static IfcNonNegativeLengthMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcNonNegativeLengthMeasure>(json);
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