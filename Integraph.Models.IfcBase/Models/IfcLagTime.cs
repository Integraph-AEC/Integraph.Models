using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifclagtime.htm" />
	/// </summary>
	public class IfcLagTime : IfcSchedulingTime
    {
	    /// <summary>
	    ///     Construct a IfcLagTime with all required attributes.
	    /// </summary>
	    public IfcLagTime(IfcTimeOrRatioSelect lagValue, IfcTaskDurationEnum durationType)
        {
            LagValue = lagValue;
            DurationType = durationType;
        }

	    /// <summary>
	    ///     Construct a IfcLagTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcLagTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin,
            IfcTimeOrRatioSelect lagValue, IfcTaskDurationEnum durationType) : base(name, dataOrigin,
            userDefinedDataOrigin)
        {
            LagValue = lagValue;
            DurationType = durationType;
        }

        public IfcTimeOrRatioSelect LagValue { get; set; }
        public IfcTaskDurationEnum? DurationType { get; set; }

        public new static IfcLagTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcLagTime>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
	            Name != null ? Name.ToStepValue() : "$",
	            DataOrigin.ToStepValue(),
	            UserDefinedDataOrigin != null ? UserDefinedDataOrigin.ToStepValue() : "$",
	            LagValue != null ? LagValue.ToStepValue() : "$",
	            DurationType.ToStepValue()
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}