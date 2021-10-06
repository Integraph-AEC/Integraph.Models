using System.Collections.Generic;
using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclineindex.htm
	/// </summary>
	public class IfcLineIndex : BaseIfc
    {
        internal List<IfcPositiveInteger> _value;

        public IfcLineIndex(List<IfcPositiveInteger> value)
        {
            _value = value;
        }

        public static implicit operator List<IfcPositiveInteger>(IfcLineIndex v)
        {
            return v._value;
        }

        public static implicit operator IfcLineIndex(List<IfcPositiveInteger> v)
        {
            return new IfcLineIndex(v);
        }

        public static IfcLineIndex FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLineIndex>(json);
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