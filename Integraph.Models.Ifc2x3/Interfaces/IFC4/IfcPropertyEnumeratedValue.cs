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
namespace Integraph.Models.Ifc2x3.PropertyResource
{
	public partial class @IfcPropertyEnumeratedValue : IIfcPropertyEnumeratedValue
	{

		[CrossSchemaAttribute(typeof(IIfcPropertyEnumeratedValue), 3)]
		IItemSet<IIfcValue> IIfcPropertyEnumeratedValue.EnumerationValues 
		{ 
			get
			{
			
				return _enumerationValuesIfc4 ?? (_enumerationValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    EnumerationValues, 
                    new ItemSet<IIfcValue>(this, 0, -3), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _enumerationValuesIfc4;

		[CrossSchemaAttribute(typeof(IIfcPropertyEnumeratedValue), 4)]
		IIfcPropertyEnumeration IIfcPropertyEnumeratedValue.EnumerationReference 
		{ 
			get
			{
				return EnumerationReference;
			} 
			set
			{
				EnumerationReference = value as IfcPropertyEnumeration;
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcPropertyAbstraction.HasExternalReferences 
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