using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifchalfspacesolid.htm" />
	/// </summary>
	public class IfcHalfSpaceSolid : IfcGeometricRepresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcHalfSpaceSolid with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcHalfSpaceSolid(IfcSurface baseSurface, IfcBoolean agreementFlag)
        {
            BaseSurface = baseSurface;
            AgreementFlag = agreementFlag;
        }

        public IfcSurface BaseSurface { get; set; }
        public IfcBoolean AgreementFlag { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public new static IfcHalfSpaceSolid FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcHalfSpaceSolid>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BaseSurface != null ? BaseSurface.ToStepValue() : "$",
                AgreementFlag != null ? AgreementFlag.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}