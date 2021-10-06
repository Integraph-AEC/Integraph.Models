using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcilluminancemeasure.htm
	/// </summary>
	public class IfcIlluminanceMeasure : BaseIfc
    {
        internal double _value;

        public IfcIlluminanceMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcIlluminanceMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcIlluminanceMeasure(double v)
        {
            return new IfcIlluminanceMeasure(v);
        }

        public static IfcIlluminanceMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIlluminanceMeasure>(json);
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