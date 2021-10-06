using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccurrencyrelationship.htm" />
	/// </summary>
	public class IfcCurrencyRelationship : IfcResourceLevelRelationship
    {
	    /// <summary>
	    ///     Construct a IfcCurrencyRelationship with all required attributes.
	    /// </summary>
	    public IfcCurrencyRelationship(IfcMonetaryUnit relatingMonetaryUnit, IfcMonetaryUnit relatedMonetaryUnit,
            IfcPositiveRatioMeasure exchangeRate)
        {
            RelatingMonetaryUnit = relatingMonetaryUnit;
            RelatedMonetaryUnit = relatedMonetaryUnit;
            ExchangeRate = exchangeRate;
        }

	    /// <summary>
	    ///     Construct a IfcCurrencyRelationship with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCurrencyRelationship(IfcLabel name, IfcText description, IfcMonetaryUnit relatingMonetaryUnit,
            IfcMonetaryUnit relatedMonetaryUnit, IfcPositiveRatioMeasure exchangeRate, IfcDateTime rateDateTime,
            IfcLibraryInformation rateSource) : base(name, description)
        {
            RelatingMonetaryUnit = relatingMonetaryUnit;
            RelatedMonetaryUnit = relatedMonetaryUnit;
            ExchangeRate = exchangeRate;
            RateDateTime = rateDateTime;
            RateSource = rateSource;
        }

        public IfcMonetaryUnit RelatingMonetaryUnit { get; set; }
        public IfcMonetaryUnit RelatedMonetaryUnit { get; set; }
        public IfcPositiveRatioMeasure ExchangeRate { get; set; }
        public IfcDateTime RateDateTime { get; set; } // optional
        public IfcLibraryInformation RateSource { get; set; } // optional

        public new static IfcCurrencyRelationship FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCurrencyRelationship>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                Name != null ? Name.ToStepValue() : "$",
                Description != null ? Description.ToStepValue() : "$",
                RelatingMonetaryUnit != null ? RelatingMonetaryUnit.ToStepValue() : "$",
                RelatedMonetaryUnit != null ? RelatedMonetaryUnit.ToStepValue() : "$",
                ExchangeRate != null ? ExchangeRate.ToStepValue() : "$",
                RateDateTime != null ? RateDateTime.ToStepValue() : "$",
                RateSource != null ? RateSource.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}