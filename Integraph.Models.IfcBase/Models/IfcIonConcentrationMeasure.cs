using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcionconcentrationmeasure.htm
	/// </summary>
	public class IfcIonConcentrationMeasure : BaseIfc
    {
        internal double _value;

        public IfcIonConcentrationMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcIonConcentrationMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcIonConcentrationMeasure(double v)
        {
            return new IfcIonConcentrationMeasure(v);
        }

        public static IfcIonConcentrationMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIonConcentrationMeasure>(json);
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