using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctelecomaddress.htm" />
	/// </summary>
	public class IfcTelecomAddress : IfcAddress
    {
	    /// <summary>
	    ///     Construct a IfcTelecomAddress with all required attributes.
	    /// </summary>
	    public IfcTelecomAddress()
        {
            TelephoneNumbers = new List<IfcLabel>();
            FacsimileNumbers = new List<IfcLabel>();
            ElectronicMailAddresses = new List<IfcLabel>();
            MessagingIDs = new List<IfcUriReference>();
        }

	    /// <summary>
	    ///     Construct a IfcTelecomAddress with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTelecomAddress(IfcAddressTypeEnum purpose, IfcText description, IfcLabel userDefinedPurpose,
            List<IfcLabel> telephoneNumbers, List<IfcLabel> facsimileNumbers, IfcLabel pagerNumber,
            List<IfcLabel> electronicMailAddresses, IfcUriReference wWwHomePageUrl, List<IfcUriReference> messagingIDs)
            : base(purpose, description, userDefinedPurpose)
        {
            TelephoneNumbers = telephoneNumbers;
            FacsimileNumbers = facsimileNumbers;
            PagerNumber = pagerNumber;
            ElectronicMailAddresses = electronicMailAddresses;
            WwwHomePageUrl = wWwHomePageUrl;
            MessagingIDs = messagingIDs;
        }

        public List<IfcLabel> TelephoneNumbers { get; set; } // optional
        public List<IfcLabel> FacsimileNumbers { get; set; } // optional
        public IfcLabel PagerNumber { get; set; } // optional
        public List<IfcLabel> ElectronicMailAddresses { get; set; } // optional
        public IfcUriReference WwwHomePageUrl { get; set; } // optional
        public List<IfcUriReference> MessagingIDs { get; set; } // optional

        public new static IfcTelecomAddress FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTelecomAddress>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Purpose.ToStepValue(),
	            Description != null ? Description.ToStepValue() : "$",
	            UserDefinedPurpose != null ? UserDefinedPurpose.ToStepValue() : "$",
	            TelephoneNumbers != null ? TelephoneNumbers.ToStepValue() : "$",
	            FacsimileNumbers != null ? FacsimileNumbers.ToStepValue() : "$",
	            PagerNumber != null ? PagerNumber.ToStepValue() : "$",
	            ElectronicMailAddresses != null ? ElectronicMailAddresses.ToStepValue() : "$",
	            WwwHomePageUrl != null ? WwwHomePageUrl.ToStepValue() : "$",
	            MessagingIDs != null ? MessagingIDs.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}