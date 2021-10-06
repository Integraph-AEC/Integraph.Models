using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcintegercountratemeasure.htm
	/// </summary>
	public class IfcIntegerCountRateMeasure : BaseIfc
    {
        internal int _value;

        public IfcIntegerCountRateMeasure(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcIntegerCountRateMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcIntegerCountRateMeasure(int v)
        {
            return new IfcIntegerCountRateMeasure(v);
        }

        public static IfcIntegerCountRateMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIntegerCountRateMeasure>(json);
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