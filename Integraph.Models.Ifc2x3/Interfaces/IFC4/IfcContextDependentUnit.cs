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
	public partial class @IfcContextDependentUnit : IIfcContextDependentUnit
	{

		[CrossSchemaAttribute(typeof(IIfcContextDependentUnit), 3)]
		Ifc4.MeasureResource.IfcLabel IIfcContextDependentUnit.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new IfcLabel(value);
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcContextDependentUnit.HasExternalReference 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
	//## Custom code
	//##
	}
}