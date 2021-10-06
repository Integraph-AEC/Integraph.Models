using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcdimensionalexponents.htm" />
	/// </summary>
	public class IfcDimensionalExponents : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcDimensionalExponents with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcDimensionalExponents(int lengthExponent, int massExponent, int timeExponent,
            int electricCurrentExponent, int thermodynamicTemperatureExponent, int amountOfSubstanceExponent,
            int luminousIntensityExponent)
        {
            LengthExponent = lengthExponent;
            MassExponent = massExponent;
            TimeExponent = timeExponent;
            ElectricCurrentExponent = electricCurrentExponent;
            ThermodynamicTemperatureExponent = thermodynamicTemperatureExponent;
            AmountOfSubstanceExponent = amountOfSubstanceExponent;
            LuminousIntensityExponent = luminousIntensityExponent;
        }

        public int LengthExponent { get; set; }
        public int MassExponent { get; set; }
        public int TimeExponent { get; set; }
        public int ElectricCurrentExponent { get; set; }
        public int ThermodynamicTemperatureExponent { get; set; }
        public int AmountOfSubstanceExponent { get; set; }
        public int LuminousIntensityExponent { get; set; }

        public static IfcDimensionalExponents FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcDimensionalExponents>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                LengthExponent.ToStepValue(),
                MassExponent.ToStepValue(),
                TimeExponent.ToStepValue(),
                ElectricCurrentExponent.ToStepValue(),
                ThermodynamicTemperatureExponent.ToStepValue(),
                AmountOfSubstanceExponent.ToStepValue(),
                LuminousIntensityExponent.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}