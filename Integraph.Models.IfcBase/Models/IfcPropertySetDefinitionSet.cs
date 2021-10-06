using System.Collections.Generic;
using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpropertysetdefinitionset.htm
	/// </summary>
	public class IfcPropertySetDefinitionSet : BaseIfc
    {
        internal List<IfcPropertySetDefinition> _value;

        public IfcPropertySetDefinitionSet(List<IfcPropertySetDefinition> value)
        {
            _value = value;
        }

        public static implicit operator List<IfcPropertySetDefinition>(IfcPropertySetDefinitionSet v)
        {
            return v._value;
        }

        public static implicit operator IfcPropertySetDefinitionSet(List<IfcPropertySetDefinition> v)
        {
            return new IfcPropertySetDefinitionSet(v);
        }

        public static IfcPropertySetDefinitionSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPropertySetDefinitionSet>(json);
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