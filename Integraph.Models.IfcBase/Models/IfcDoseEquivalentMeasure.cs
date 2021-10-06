using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdoseequivalentmeasure.htm
	/// </summary>
	public class IfcDoseEquivalentMeasure : BaseIfc
    {
        internal double _value;

        public IfcDoseEquivalentMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcDoseEquivalentMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcDoseEquivalentMeasure(double v)
        {
            return new IfcDoseEquivalentMeasure(v);
        }

        public static IfcDoseEquivalentMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDoseEquivalentMeasure>(json);
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