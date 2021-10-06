using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcschedulingtime.htm" />
	/// </summary>
	public abstract class IfcSchedulingTime : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcSchedulingTime with all required attributes.
	    /// </summary>
	    public IfcSchedulingTime()
        {
        }

	    /// <summary>
	    ///     Construct a IfcSchedulingTime with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcSchedulingTime(IfcLabel name, IfcDataOriginEnum dataOrigin, IfcLabel userDefinedDataOrigin)
        {
            Name = name;
            DataOrigin = dataOrigin;
            UserDefinedDataOrigin = userDefinedDataOrigin;
        }

        public IfcLabel Name { get; set; } // optional
        public IfcDataOriginEnum? DataOrigin { get; set; } // optional
        public IfcLabel UserDefinedDataOrigin { get; set; } // optional

        public static IfcSchedulingTime FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcSchedulingTime>(json);
        }
    }
}