using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifccoordinateoperation.htm" />
	/// </summary>
	public abstract class IfcCoordinateOperation : BaseIfc
    {
	    /// <summary>
	    ///     Construct a IfcCoordinateOperation with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcCoordinateOperation(IfcCoordinateReferenceSystemSelect sourceCrs,
            IfcCoordinateReferenceSystem targetCrs)
        {
            SourceCrs = sourceCrs;
            TargetCrs = targetCrs;
        }

        public IfcCoordinateReferenceSystemSelect SourceCrs { get; set; }
        public IfcCoordinateReferenceSystem TargetCrs { get; set; }

        public static IfcCoordinateOperation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcCoordinateOperation>(json);
        }
    }
}