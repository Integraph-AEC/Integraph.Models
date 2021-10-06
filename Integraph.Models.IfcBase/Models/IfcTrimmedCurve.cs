using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctrimmedcurve.htm" />
	/// </summary>
	public class IfcTrimmedCurve : IfcBoundedCurve
    {
	    /// <summary>
	    ///     Construct a IfcTrimmedCurve with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTrimmedCurve(IfcCurve basisCurve, List<IfcTrimmingSelect> trim1, List<IfcTrimmingSelect> trim2,
            IfcBoolean senseAgreement, IfcTrimmingPreference masterRepresentation)
        {
            BasisCurve = basisCurve;
            Trim1 = trim1;
            Trim2 = trim2;
            SenseAgreement = senseAgreement;
            MasterRepresentation = masterRepresentation;
        }

        public IfcCurve BasisCurve { get; set; }
        public List<IfcTrimmingSelect> Trim1 { get; set; }
        public List<IfcTrimmingSelect> Trim2 { get; set; }
        public IfcBoolean SenseAgreement { get; set; }
        public IfcTrimmingPreference? MasterRepresentation { get; set; }

        public new static IfcTrimmedCurve FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTrimmedCurve>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BasisCurve != null ? BasisCurve.ToStepValue() : "$",
                Trim1 != null ? Trim1.ToStepValue() : "$",
                Trim2 != null ? Trim2.ToStepValue() : "$",
                SenseAgreement != null ? SenseAgreement.ToStepValue() : "$",
                MasterRepresentation != null ? MasterRepresentation.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}