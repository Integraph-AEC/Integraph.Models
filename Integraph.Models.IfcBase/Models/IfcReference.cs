using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcreference.htm" />
	/// </summary>
	public class IfcReference : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcReference with all required attributes.
	    /// </summary>
	    public IfcReference()
        {
            ListPositions = new List<IfcInteger>();
        }

	    /// <summary>
	    ///     Construct a IfcReference with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcReference(IfcIdentifier typeIdentifier, IfcIdentifier attributeIdentifier, IfcLabel instanceName,
            List<IfcInteger> listPositions, IfcReference innerReference)
        {
            TypeIdentifier = typeIdentifier;
            AttributeIdentifier = attributeIdentifier;
            InstanceName = instanceName;
            ListPositions = listPositions;
            InnerReference = innerReference;
        }

        public IfcIdentifier TypeIdentifier { get; set; } // optional
        public IfcIdentifier AttributeIdentifier { get; set; } // optional
        public IfcLabel InstanceName { get; set; } // optional
        public List<IfcInteger> ListPositions { get; set; } // optional
        public IfcReference InnerReference { get; set; } // optional

        public static IfcReference FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcReference>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            TypeIdentifier != null ? TypeIdentifier.ToStepValue() : "$",
	            AttributeIdentifier != null ? AttributeIdentifier.ToStepValue() : "$",
	            InstanceName != null ? InstanceName.ToStepValue() : "$",
	            ListPositions != null ? ListPositions.ToStepValue() : "$",
	            InnerReference != null ? InnerReference.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}