using System.Collections.Generic;
using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcarcindex.htm
	/// </summary>
	public class IfcArcIndex : BaseIfc
    {
        internal List<IfcPositiveInteger> _value;

        public IfcArcIndex(List<IfcPositiveInteger> value)
        {
            _value = value;
        }

        public static implicit operator List<IfcPositiveInteger>(IfcArcIndex v)
        {
            return v._value;
        }

        public static implicit operator IfcArcIndex(List<IfcPositiveInteger> v)
        {
            return new IfcArcIndex(v);
        }

        public static IfcArcIndex FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcArcIndex>(json);
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