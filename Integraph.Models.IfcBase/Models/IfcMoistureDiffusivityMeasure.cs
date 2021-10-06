using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmoisturediffusivitymeasure.htm
	/// </summary>
	public class IfcMoistureDiffusivityMeasure : BaseIfc
    {
        internal double _value;

        public IfcMoistureDiffusivityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcMoistureDiffusivityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcMoistureDiffusivityMeasure(double v)
        {
            return new IfcMoistureDiffusivityMeasure(v);
        }

        public static IfcMoistureDiffusivityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcMoistureDiffusivityMeasure>(json);
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