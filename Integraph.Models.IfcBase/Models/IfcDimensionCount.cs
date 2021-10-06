using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdimensioncount.htm
	/// </summary>
	public class IfcDimensionCount : BaseIfc
    {
        internal int _value;

        public IfcDimensionCount(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcDimensionCount v)
        {
            return v._value;
        }

        public static implicit operator IfcDimensionCount(int v)
        {
            return new IfcDimensionCount(v);
        }

        public static IfcDimensionCount FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDimensionCount>(json);
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