using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmassmeasure.htm
	/// </summary>
	public class IfcMassMeasure : BaseIfc
    {
        internal double _value;

        public IfcMassMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMassMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMassMeasure(double v)
        {
            return new IfcMassMeasure(v);
        }

        public static IfcMassMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMassMeasure>(json);
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