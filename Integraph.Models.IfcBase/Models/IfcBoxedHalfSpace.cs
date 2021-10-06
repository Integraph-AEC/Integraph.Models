using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcboxedhalfspace.htm" />
	/// </summary>
	public class IfcBoxedHalfSpace : IfcHalfSpaceSolid
    {
	    /// <summary>
	    ///     Construct a IfcBoxedHalfSpace with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcBoxedHalfSpace(IfcSurface baseSurface, IfcBoolean agreementFlag, IfcBoundingBox enclosure) : base(
            baseSurface, agreementFlag)
        {
            Enclosure = enclosure;
        }

        public IfcBoundingBox Enclosure { get; set; }

        public new static IfcBoxedHalfSpace FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcBoxedHalfSpace>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                BaseSurface != null ? BaseSurface.ToStepValue() : "$",
                AgreementFlag != null ? AgreementFlag.ToStepValue() : "$",
                Enclosure != null ? Enclosure.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}