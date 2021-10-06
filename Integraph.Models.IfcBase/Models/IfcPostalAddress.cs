using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcpostaladdress.htm" />
	/// </summary>
	public class IfcPostalAddress : IfcAddress
    {
	    /// <summary>
	    ///     Construct a IfcPostalAddress with all required attributes.
	    /// </summary>
	    public IfcPostalAddress()
        {
            AddressLines = new List<IfcLabel>();
        }

	    /// <summary>
	    ///     Construct a IfcPostalAddress with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcPostalAddress(IfcAddressTypeEnum purpose, IfcText description, IfcLabel userDefinedPurpose,
            IfcLabel internalLocation, List<IfcLabel> addressLines, IfcLabel postalBox, IfcLabel town, IfcLabel region,
            IfcLabel postalCode, IfcLabel country) : base(purpose, description, userDefinedPurpose)
        {
            InternalLocation = internalLocation;
            AddressLines = addressLines;
            PostalBox = postalBox;
            Town = town;
            Region = region;
            PostalCode = postalCode;
            Country = country;
        }

        public IfcLabel InternalLocation { get; set; } // optional
        public List<IfcLabel> AddressLines { get; set; } // optional
        public IfcLabel PostalBox { get; set; } // optional
        public IfcLabel Town { get; set; } // optional
        public IfcLabel Region { get; set; } // optional
        public IfcLabel PostalCode { get; set; } // optional
        public IfcLabel Country { get; set; } // optional

        public new static IfcPostalAddress FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcPostalAddress>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Purpose.ToStepValue(),
	            Description != null ? Description.ToStepValue() : "$",
	            UserDefinedPurpose != null ? UserDefinedPurpose.ToStepValue() : "$",
	            InternalLocation != null ? InternalLocation.ToStepValue() : "$",
	            AddressLines != null ? AddressLines.ToStepValue() : "$",
	            PostalBox != null ? PostalBox.ToStepValue() : "$",
	            Town != null ? Town.ToStepValue() : "$",
	            Region != null ? Region.ToStepValue() : "$",
	            PostalCode != null ? PostalCode.ToStepValue() : "$",
	            Country != null ? Country.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}