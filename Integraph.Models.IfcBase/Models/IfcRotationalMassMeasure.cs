using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrotationalmassmeasure.htm
	/// </summary>
	public class IfcRotationalMassMeasure : BaseIfc
    {
        internal double _value;

        public IfcRotationalMassMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcRotationalMassMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcRotationalMassMeasure(double v)
        {
            return new IfcRotationalMassMeasure(v);
        }

        public static IfcRotationalMassMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRotationalMassMeasure>(json);
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