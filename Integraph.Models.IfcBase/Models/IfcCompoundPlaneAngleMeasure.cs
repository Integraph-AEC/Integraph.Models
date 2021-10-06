using System.Collections.Generic;
using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccompoundplaneanglemeasure.htm
	/// </summary>
	public class IfcCompoundPlaneAngleMeasure : BaseIfc
    {
        internal List<int> _value;

        public IfcCompoundPlaneAngleMeasure(List<int> value)
        {
            _value = value;
        }

        public static implicit operator List<int>(IfcCompoundPlaneAngleMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcCompoundPlaneAngleMeasure(List<int> v)
        {
            return new IfcCompoundPlaneAngleMeasure(v);
        }

        public static IfcCompoundPlaneAngleMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCompoundPlaneAngleMeasure>(json);
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