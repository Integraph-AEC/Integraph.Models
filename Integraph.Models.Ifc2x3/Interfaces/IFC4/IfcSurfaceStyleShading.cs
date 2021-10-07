// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;

// ReSharper disable once CheckNamespace
namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	public partial class @IfcSurfaceStyleShading : IIfcSurfaceStyleShading
	{

		[CrossSchemaAttribute(typeof(IIfcSurfaceStyleShading), 1)]
		IIfcColourRgb IIfcSurfaceStyleShading.SurfaceColour 
		{ 
			get
			{
				return SurfaceColour;
			} 
			set
			{
				SurfaceColour = value as PresentationResource.IfcColourRgb;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSurfaceStyleShading), 2)]
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcSurfaceStyleShading.Transparency 
		{ 
			get
			{
				//## Handle return of Transparency for which no match was found
                var rendering = this as IfcSurfaceStyleRendering;
			    if (rendering == null) return _transparency;

			    if (rendering.Transparency.HasValue)
			        return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)rendering.Transparency);
			    return null;
			    //##
			} 
			set
			{
				//## Handle setting of Transparency for which no match was found
                var rendering = this as IfcSurfaceStyleRendering;
			    if (rendering == null)
			    {
			        SetValue(v => _transparency = v, _transparency, value, "Transparency", -2);
			        return;
			    }

			    if (value.HasValue)
			        rendering.Transparency = new MeasureResource.IfcNormalisedRatioMeasure(value.Value);
			    else
			        rendering.Transparency = null;
				//##
				NotifyPropertyChanged("Transparency");
				
			}
		}
	//## Custom code
	    private Ifc4.MeasureResource.IfcNormalisedRatioMeasure? _transparency ;
	    //##
	}
}