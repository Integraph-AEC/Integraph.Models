using System.Globalization;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcsectionalareaintegralmeasure.htm
	/// </summary>
	public class IfcSectionalAreaIntegralMeasure : BaseIfc
    {
        internal double _value;

        public IfcSectionalAreaIntegralMeasure(double value)
        {
            _value = value;
        }

        public static implicit operator double(IfcSectionalAreaIntegralMeasure v)
        {
            return v._value;
        }

        public static implicit operator IfcSectionalAreaIntegralMeasure(double v)
        {
            return new IfcSectionalAreaIntegralMeasure(v);
        }

        public static IfcSectionalAreaIntegralMeasure FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSectionalAreaIntegralMeasure>(json);
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