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
	public partial class @IfcPropertyListValue : IIfcPropertyListValue
	{

		[CrossSchemaAttribute(typeof(IIfcPropertyListValue), 3)]
		IItemSet<IIfcValue> IIfcPropertyListValue.ListValues 
		{ 
			get
			{
			
				return _listValuesIfc4 ?? (_listValuesIfc4 = new Common.Collections.ExtendedItemSet<MeasureResource.IfcValue, IIfcValue>(
                    ListValues, 
                    new ItemSet<IIfcValue>(this, 0, -3), 
                    v => v.ToIfc4(), 
                    v => v.ToIfc3()));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcValue> _listValuesIfc4;

		[CrossSchemaAttribute(typeof(IIfcPropertyListValue), 4)]
		IIfcUnit IIfcPropertyListValue.Unit 
		{ 
			get
			{
				if (Unit == null) return null;
				var ifcderivedunit = Unit as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
					return ifcderivedunit;
				var ifcnamedunit = Unit as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
					return ifcnamedunit;
				var ifcmonetaryunit = Unit as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
					return ifcmonetaryunit;
				return null;
			} 
			set
			{
				if (value == null)
				{
					Unit = null;
					return;
				}	
				var ifcderivedunit = value as MeasureResource.IfcDerivedUnit;
				if (ifcderivedunit != null) 
				{
					Unit = ifcderivedunit;
					return;
				}
				var ifcmonetaryunit = value as MeasureResource.IfcMonetaryUnit;
				if (ifcmonetaryunit != null) 
				{
					Unit = ifcmonetaryunit;
					return;
				}
				var ifcnamedunit = value as MeasureResource.IfcNamedUnit;
				if (ifcnamedunit != null) 
				{
					Unit = ifcnamedunit;
					return;
				}
				
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