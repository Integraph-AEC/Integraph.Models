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
namespace Integraph.Models.Ifc2x3.SharedComponentElements
{
	public partial class @IfcMechanicalFastener : IIfcMechanicalFastener
	{

		[CrossSchemaAttribute(typeof(IIfcMechanicalFastener), 9)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalDiameter 
		{ 
			get
			{
				if (!NominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter.Value);
			} 
			set
			{
				NominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMechanicalFastener), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcMechanicalFastener.NominalLength 
		{ 
			get
			{
				if (!NominalLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalLength.Value);
			} 
			set
			{
				NominalLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		private  Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcMechanicalFastener), 11)]
		Ifc4.Interfaces.IfcMechanicalFastenerTypeEnum? IIfcMechanicalFastener.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -11);
				
			}
		}
	//## Custom code
	//##
	}
}