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
namespace Integraph.Models.Ifc2x3.PresentationDefinitionResource
{
	public partial class @IfcTextureVertex : IIfcTextureVertex
	{

		[CrossSchemaAttribute(typeof(IIfcTextureVertex), 1)]
		IItemSet<Integraph.Models.Ifc4.MeasureResource.IfcParameterValue> IIfcTextureVertex.Coordinates 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcParameterValue, Ifc4.MeasureResource.IfcParameterValue>(Coordinates, 
					s => new Ifc4.MeasureResource.IfcParameterValue(s), 
					t => new MeasureResource.IfcParameterValue(t));
			} 
		}
	//## Custom code
	//##
	}
}