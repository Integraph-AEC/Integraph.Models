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
namespace Integraph.Models.Ifc2x3.SharedFacilitiesElements
{
	public partial class @IfcInventory : IIfcInventory
	{

		[CrossSchemaAttribute(typeof(IIfcInventory), 6)]
		Ifc4.Interfaces.IfcInventoryTypeEnum? IIfcInventory.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (InventoryType)
				{
					case IfcInventoryTypeEnum.ASSETINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.ASSETINVENTORY;
					case IfcInventoryTypeEnum.SPACEINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.SPACEINVENTORY;
					case IfcInventoryTypeEnum.FURNITUREINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.FURNITUREINVENTORY;
					case IfcInventoryTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcInventoryTypeEnum.USERDEFINED;
					case IfcInventoryTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcInventoryTypeEnum.ASSETINVENTORY:
						InventoryType = IfcInventoryTypeEnum.ASSETINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.SPACEINVENTORY:
						InventoryType = IfcInventoryTypeEnum.SPACEINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.FURNITUREINVENTORY:
						InventoryType = IfcInventoryTypeEnum.FURNITUREINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.USERDEFINED:
						InventoryType = IfcInventoryTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.NOTDEFINED:
						InventoryType = IfcInventoryTypeEnum.NOTDEFINED;
						return;
					case null:
						InventoryType = IfcInventoryTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 7)]
		IIfcActorSelect IIfcInventory.Jurisdiction 
		{ 
			get
			{
				if (Jurisdiction == null) return null;
				var ifcorganization = Jurisdiction as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = Jurisdiction as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = Jurisdiction as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					Jurisdiction = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					Jurisdiction = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					Jurisdiction = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					Jurisdiction = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 8)]
		IItemSet<IIfcPerson> IIfcInventory.ResponsiblePersons 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ActorResource.IfcPerson, IIfcPerson>(ResponsiblePersons);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 9)]
		Ifc4.DateTimeResource.IfcDate? IIfcInventory.LastUpdateDate 
		{ 
			get
			{
				//## Handle return of LastUpdateDate for which no match was found
			    return LastUpdateDate != null
			        ? new Ifc4.DateTimeResource.IfcDate(LastUpdateDate.ToISODateTimeString())
			        : null;
				//##
			} 
			set
			{
				//## Handle setting of LastUpdateDate for which no match was found
                if (!value.HasValue)
                {
                    LastUpdateDate = null;
                    return;
                }
                System.DateTime date = value.Value;
                LastUpdateDate = Model.Instances.New<DateTimeResource.IfcCalendarDate>(d =>
                {
                    d.YearComponent = date.Year;
                    d.MonthComponent = date.Month;
                    d.DayComponent = date.Day;
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 10)]
		IIfcCostValue IIfcInventory.CurrentValue 
		{ 
			get
			{
				return CurrentValue;
			} 
			set
			{
				CurrentValue = value as CostResource.IfcCostValue;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 11)]
		IIfcCostValue IIfcInventory.OriginalValue 
		{ 
			get
			{
				return OriginalValue;
			} 
			set
			{
				OriginalValue = value as CostResource.IfcCostValue;
				
			}
		}
	//## Custom code
	//##
	}
}