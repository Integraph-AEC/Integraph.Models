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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class @IfcHalfSpaceSolid : IIfcHalfSpaceSolid
	{

		[CrossSchemaAttribute(typeof(IIfcHalfSpaceSolid), 1)]
		IIfcSurface IIfcHalfSpaceSolid.BaseSurface 
		{ 
			get
			{
				return BaseSurface;
			} 
			set
			{
				BaseSurface = value as GeometryResource.IfcSurface;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcHalfSpaceSolid), 2)]
		Ifc4.MeasureResource.IfcBoolean IIfcHalfSpaceSolid.AgreementFlag 
		{ 
			get
			{
				//## Handle return of AgreementFlag for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(AgreementFlag);
				//##
			} 
			set
			{
				AgreementFlag = value;
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount Ifc4.GeometricModelResource.IfcBooleanOperand.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}