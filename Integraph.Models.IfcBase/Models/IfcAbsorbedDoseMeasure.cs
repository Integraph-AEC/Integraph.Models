using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcabsorbeddosemeasure.htm
	/// </summary>
	public class IfcAbsorbedDoseMeasure : BaseIfc
    {
        internal double _value;

        public IfcAbsorbedDoseMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcAbsorbedDoseMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcAbsorbedDoseMeasure(double v)
        {
            return new IfcAbsorbedDoseMeasure(v);
        }

        public static IfcAbsorbedDoseMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcAbsorbedDoseMeasure>(json);
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