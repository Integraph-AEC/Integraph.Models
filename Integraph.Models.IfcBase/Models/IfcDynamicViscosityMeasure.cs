using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdynamicviscositymeasure.htm
	/// </summary>
	public class IfcDynamicViscosityMeasure : BaseIfc
    {
        internal double _value;

        public IfcDynamicViscosityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcDynamicViscosityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcDynamicViscosityMeasure(double v)
        {
            return new IfcDynamicViscosityMeasure(v);
        }

        public static IfcDynamicViscosityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDynamicViscosityMeasure>(json);
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