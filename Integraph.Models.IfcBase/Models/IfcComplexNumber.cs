using System.Collections.Generic;
using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccomplexnumber.htm
	/// </summary>
	public class IfcComplexNumber : BaseIfc
    {
        internal List<double> _value;

        public IfcComplexNumber(List<double> value)
        {
            _value = value;
        }

        public static implicit operator List<double>(IfcComplexNumber v)
        {
            return v._value;
        }

        public static implicit operator IfcComplexNumber(List<double> v)
        {
            return new IfcComplexNumber(v);
        }

        public static IfcComplexNumber FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcComplexNumber>(json);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override string ToStepValue(bool isSelectOption = false)
        {
            if (isSelectOption)
                return $"{GetType().Name.ToUpper()}({_value.ToStepValue(isSelectOption)})";
            return _value.ToStepValue(isSelectOption);
        }
    }
}