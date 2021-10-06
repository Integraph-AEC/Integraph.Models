using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcphmeasure.htm
	/// </summary>
	public class IfcPhMeasure : BaseIfc
    {
        internal double _value;

        public IfcPhMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcPhMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcPhMeasure(double v)
        {
            return new IfcPhMeasure(v);
        }

        public static IfcPhMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPhMeasure>(json);
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