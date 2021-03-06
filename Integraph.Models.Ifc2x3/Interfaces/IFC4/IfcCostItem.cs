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
namespace Integraph.Models.Ifc2x3.SharedMgmtElements
{
	public partial class @IfcCostItem : IIfcCostItem
	{

		private  Ifc4.Interfaces.IfcCostItemTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcCostItem), 7)]
		Ifc4.Interfaces.IfcCostItemTypeEnum? IIfcCostItem.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -7);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcCostItem), 8)]
		IItemSet<IIfcCostValue> IIfcCostItem.CostValues 
		{ 
			get
			{
				//## Handle return of CostValues for which no match was found
			    return _costValues ?? (_costValues = new ItemSet<IIfcCostValue>(this, 0, -8));
			    //##
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcCostItem), 9)]
		IItemSet<IIfcPhysicalQuantity> IIfcCostItem.CostQuantities 
		{ 
			get
			{
				//## Handle return of CostQuantities for which no match was found
                return _costQuantities ?? (_costQuantities = new ItemSet<IIfcPhysicalQuantity>(this, 0, -9));
				//##
			} 
		}
	//## Custom code
	    private IItemSet<IIfcCostValue> _costValues;
	    private IItemSet<IIfcPhysicalQuantity> _costQuantities;
	    //##
	}
}