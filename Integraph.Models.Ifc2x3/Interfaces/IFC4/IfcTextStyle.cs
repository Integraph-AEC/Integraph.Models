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
	public partial class @IfcTextStyle : IIfcTextStyle
	{

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 2)]
		IIfcTextStyleForDefinedFont IIfcTextStyle.TextCharacterAppearance 
		{ 
			get
			{
				//## Handle return of TextCharacterAppearance for which no match was found
                return TextCharacterAppearance as IIfcTextStyleForDefinedFont;
				//##
			} 
			set
			{
				//## Handle setting of TextCharacterAppearance for which no match was found
                TextCharacterAppearance = value as IfcCharacterStyleSelect; ;
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 3)]
		IIfcTextStyleTextModel IIfcTextStyle.TextStyle 
		{ 
			get
			{
				//## Handle return of TextStyle for which no match was found
                return TextStyle as IIfcTextStyleTextModel;
				//##
			} 
			set
			{
				//## Handle setting of TextStyle for which no match was found
				TextStyle = value as IfcTextStyleSelect;
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTextStyle), 4)]
		IIfcTextFontSelect IIfcTextStyle.TextFontStyle 
		{ 
			get
			{
				if (TextFontStyle == null) return null;
				var ifcpredefinedtextfont = TextFontStyle as PresentationResource.IfcPreDefinedTextFont;
				if (ifcpredefinedtextfont != null) 
					return ifcpredefinedtextfont;
				var ifcexternallydefinedtextfont = TextFontStyle as PresentationResource.IfcExternallyDefinedTextFont;
				if (ifcexternallydefinedtextfont != null) 
					return ifcexternallydefinedtextfont;
				return null;
			} 
			set
			{
				if (value == null)
				{
					TextFontStyle = null;
					return;
				}	
				var ifcexternallydefinedtextfont = value as PresentationResource.IfcExternallyDefinedTextFont;
				if (ifcexternallydefinedtextfont != null) 
				{
					TextFontStyle = ifcexternallydefinedtextfont;
					return;
				}
				var ifcpredefinedtextfont = value as PresentationResource.IfcPreDefinedTextFont;
				if (ifcpredefinedtextfont != null) 
				{
					TextFontStyle = ifcpredefinedtextfont;
					return;
				}
				
			}
		}

		private  Ifc4.MeasureResource.IfcBoolean? _modelOrDraughting;


		[CrossSchemaAttribute(typeof(IIfcTextStyle), 5)]
		Ifc4.MeasureResource.IfcBoolean? IIfcTextStyle.ModelOrDraughting 
		{ 
			get
			{
				return _modelOrDraughting;
			} 
			set
			{
				SetValue(v => _modelOrDraughting = v, _modelOrDraughting, value, "ModelOrDraughting", -5);
				
			}
		}
	//## Custom code
	//##
	}
}