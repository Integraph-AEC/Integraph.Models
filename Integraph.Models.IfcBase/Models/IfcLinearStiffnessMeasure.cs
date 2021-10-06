using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclinearstiffnessmeasure.htm
	/// </summary>
	public class IfcLinearStiffnessMeasure : BaseIfc
    {
        internal double _value;

        public IfcLinearStiffnessMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcLinearStiffnessMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcLinearStiffnessMeasure(double v)
        {
            return new IfcLinearStiffnessMeasure(v);
        }

        public static IfcLinearStiffnessMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLinearStiffnessMeasure>(json);
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