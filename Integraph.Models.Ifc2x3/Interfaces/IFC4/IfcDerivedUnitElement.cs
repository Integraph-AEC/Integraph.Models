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
namespace Integraph.Models.Ifc2x3.MeasureResource
{
	public partial class @IfcDerivedUnitElement : IIfcDerivedUnitElement
	{

		[CrossSchemaAttribute(typeof(IIfcDerivedUnitElement), 1)]
		IIfcNamedUnit IIfcDerivedUnitElement.Unit 
		{ 
			get
			{
				return Unit;
			} 
			set
			{
				Unit = value as IfcNamedUnit;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDerivedUnitElement), 2)]
		long IIfcDerivedUnitElement.Exponent 
		{ 
			get
			{
				return Exponent;
			} 
			set
			{
				Exponent = value;
				
			}
		}
	//## Custom code
	//##
	}
}