using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcmodulusofelasticitymeasure.htm
	/// </summary>
	public class IfcModulusOfElasticityMeasure : BaseIfc
    {
        internal double _value;

        public IfcModulusOfElasticityMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcModulusOfElasticityMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcModulusOfElasticityMeasure(double v)
        {
            return new IfcModulusOfElasticityMeasure(v);
        }

        public static IfcModulusOfElasticityMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcModulusOfElasticityMeasure>(json);
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