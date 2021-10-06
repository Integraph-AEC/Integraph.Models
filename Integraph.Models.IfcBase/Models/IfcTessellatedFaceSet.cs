using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifctessellatedfaceset.htm" />
	/// </summary>
	public abstract class IfcTessellatedFaceSet : IfcTessellatedItem
    {
	    /// <summary>
	    ///     Construct a IfcTessellatedFaceSet with all required attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcTessellatedFaceSet(IfcCartesianPointList3D coordinates)
        {
            HasColours = new List<IfcIndexedColourMap>();
            HasTextures = new List<IfcIndexedTextureMap>();

            Coordinates = coordinates;
        }

        public IfcCartesianPointList3D Coordinates { get; set; }

        [JsonIgnore]
        public IfcDimensionCount Dim =>
            throw new NotImplementedException("Derived property logic has been implemented for Dim."); // derived

        public List<IfcIndexedColourMap> HasColours { get; set; } // inverse
        public List<IfcIndexedTextureMap> HasTextures { get; set; } // inverse

        public new static IfcTessellatedFaceSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcTessellatedFaceSet>(json);
        }
    }
}