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
	public partial class @IfcPresentationStyleAssignment : IIfcPresentationStyleAssignment
	{

		[CrossSchemaAttribute(typeof(IIfcPresentationStyleAssignment), 1)]
		IItemSet<IIfcPresentationStyleSelect> IIfcPresentationStyleAssignment.Styles 
		{ 
			get
			{
			
				return _stylesIfc4 ?? (_stylesIfc4 = new Common.Collections.ExtendedItemSet<IfcPresentationStyleSelect, IIfcPresentationStyleSelect>(
                    Styles, 
                    new ItemSet<IIfcPresentationStyleSelect>(this, 0, -1), 
					StylesToIfc4, 
                    StylesToIfc2X3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcPresentationStyleSelect> _stylesIfc4;
		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private static IIfcPresentationStyleSelect StylesToIfc4 (IfcPresentationStyleSelect member)
		{
			if (member == null) 
				return null;
			switch (member.GetType().Name)
			{
				case "IfcCurveStyle":
					return member as IfcCurveStyle;
				case "IfcSymbolStyle":
					//## Handle entity IfcSymbolStyle which is not a part of the target select interface IIfcPresentationStyleSelect in property Styles
				{
				  /*  var colour = ifcsymbolstyle.StyleOfSymbol as IIfcColourRgb;
                    if(colour!=null)
                        return colour;*/
				    return new Ifc4.PresentationAppearanceResource.IfcNullStyle();
				}
				//##
				case "IfcFillAreaStyle":
					return member as IfcFillAreaStyle;
				case "IfcTextStyle":
					return member as IfcTextStyle;
				case "IfcSurfaceStyle":
					return member as IfcSurfaceStyle;
				case "IfcNullStyle":
					//## Handle defined type IfcNullStyle which is not a part of the target select interface IItemSet<IIfcPresentationStyleSelect> in property Styles
		        return null;
				//##
				default:
					throw new System.NotSupportedException();
			}
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private static IfcPresentationStyleSelect StylesToIfc2X3 (IIfcPresentationStyleSelect member){
			if (member == null) 
				return null;
			var name = member.GetType().Name;
			switch (name)
			{
				case "IfcCurveStyle":
					return member as IfcCurveStyle;
				case "IfcFillAreaStyle":
					return member as IfcFillAreaStyle;
				case "IfcSurfaceStyle":
					return member as IfcSurfaceStyle;
				case "IfcTextStyle":
					return member as IfcTextStyle;
				case "IfcNullStyle":
					//## Handle return defined type IfcNullStyle which is not a part of the target select interface IfcPresentationStyleSelect in property Styles
				    return null;
				    //##
				default:
					throw new System.NotSupportedException();
			}
		}
	//## Custom code
	    public IEnumerable<IIfcSurfaceStyle> SurfaceStyles
	    {
	        get { return Styles.OfType<IfcSurfaceStyle>(); }
	    }

	    //##
	}
}