using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcrotationalstiffnessmeasure.htm
	/// </summary>
	public class IfcRotationalStiffnessMeasure : BaseIfc
    {
        internal double _value;

        public IfcRotationalStiffnessMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcRotationalStiffnessMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcRotationalStiffnessMeasure(double v)
        {
            return new IfcRotationalStiffnessMeasure(v);
        }

        public static IfcRotationalStiffnessMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcRotationalStiffnessMeasure>(json);
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