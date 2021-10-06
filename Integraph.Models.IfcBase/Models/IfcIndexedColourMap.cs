using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcindexedcolourmap.htm" />
	/// </summary>
	public class IfcIndexedColourMap : IfcPresentationItem
    {
	    /// <summary>
	    ///     Construct a IfcIndexedColourMap with all required attributes.
	    /// </summary>
	    public IfcIndexedColourMap(IfcTessellatedFaceSet mappedTo, IfcColourRgbList colours,
            List<IfcPositiveInteger> colourIndex)
        {
            MappedTo = mappedTo;
            Colours = colours;
            ColourIndex = colourIndex;
        }

	    /// <summary>
	    ///     Construct a IfcIndexedColourMap with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcIndexedColourMap(IfcTessellatedFaceSet mappedTo, IfcNormalisedRatioMeasure opacity,
            IfcColourRgbList colours, List<IfcPositiveInteger> colourIndex)
        {
            MappedTo = mappedTo;
            Opacity = opacity;
            Colours = colours;
            ColourIndex = colourIndex;
        }

        public IfcTessellatedFaceSet MappedTo { get; set; }
        public IfcNormalisedRatioMeasure Opacity { get; set; } // optional
        public IfcColourRgbList Colours { get; set; }
        public List<IfcPositiveInteger> ColourIndex { get; set; }

        public new static IfcIndexedColourMap FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcIndexedColourMap>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                MappedTo != null ? MappedTo.ToStepValue() : "$",
                Opacity != null ? Opacity.ToStepValue() : "$",
                Colours != null ? Colours.ToStepValue() : "$",
                ColourIndex != null ? ColourIndex.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}