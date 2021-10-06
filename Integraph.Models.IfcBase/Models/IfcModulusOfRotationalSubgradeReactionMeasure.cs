using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmodulusofrotationalsubgradereactionmeasure.htm
	/// </summary>
	public class IfcModulusOfRotationalSubgradeReactionMeasure : BaseIfc
    {
        internal double _value;

        public IfcModulusOfRotationalSubgradeReactionMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcModulusOfRotationalSubgradeReactionMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcModulusOfRotationalSubgradeReactionMeasure(double v)
        {
            return new IfcModulusOfRotationalSubgradeReactionMeasure(v);
        }

        public static IfcModulusOfRotationalSubgradeReactionMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcModulusOfRotationalSubgradeReactionMeasure>(json);
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