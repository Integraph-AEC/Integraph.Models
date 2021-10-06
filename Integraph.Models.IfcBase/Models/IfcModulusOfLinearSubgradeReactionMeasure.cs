using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmodulusoflinearsubgradereactionmeasure.htm
	/// </summary>
	public class IfcModulusOfLinearSubgradeReactionMeasure : BaseIfc
    {
        internal double _value;

        public IfcModulusOfLinearSubgradeReactionMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcModulusOfLinearSubgradeReactionMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcModulusOfLinearSubgradeReactionMeasure(double v)
        {
            return new IfcModulusOfLinearSubgradeReactionMeasure(v);
        }

        public static IfcModulusOfLinearSubgradeReactionMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcModulusOfLinearSubgradeReactionMeasure>(json);
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