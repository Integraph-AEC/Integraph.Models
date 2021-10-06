using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccardinalpointreference.htm
	/// </summary>
	public class IfcCardinalPointReference : BaseIfc
    {
        internal int _value;

        public IfcCardinalPointReference(int value)
        {
            _value = value;
        }

        public static implicit operator int(IfcCardinalPointReference v)
        {
            return v._value;
        }

        public static implicit operator IfcCardinalPointReference(int v)
        {
            return new IfcCardinalPointReference(v);
        }

        public static IfcCardinalPointReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCardinalPointReference>(json);
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