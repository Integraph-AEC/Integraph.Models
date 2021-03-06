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
namespace Integraph.Models.Ifc2x3.StructuralAnalysisDomain
{
	public partial class @IfcStructuralPlanarAction : IIfcStructuralPlanarAction
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralPlanarAction), 11)]
		Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum? IIfcStructuralSurfaceAction.ProjectedOrTrue 
		{ 
			get
			{
				//## Custom code to handle enumeration of ProjectedOrTrue
				//##
				switch (ProjectedOrTrue)
				{
					case IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
					case IfcProjectedOrTrueLengthEnum.TRUE_LENGTH:
						return Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ProjectedOrTrue
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH:
						ProjectedOrTrue = IfcProjectedOrTrueLengthEnum.PROJECTED_LENGTH;
						return;
					case Ifc4.Interfaces.IfcProjectedOrTrueLengthEnum.TRUE_LENGTH:
						ProjectedOrTrue = IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
						return;
					case null:
						ProjectedOrTrue = IfcProjectedOrTrueLengthEnum.TRUE_LENGTH;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		private  Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcStructuralPlanarAction), 12)]
		Ifc4.Interfaces.IfcStructuralSurfaceActivityTypeEnum IIfcStructuralSurfaceAction.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -12);
				
			}
		}
	//## Custom code
	//##
	}
}