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
	public partial class @IfcAsset : IIfcAsset
	{

		[CrossSchemaAttribute(typeof(IIfcAsset), 6)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcAsset.Identification 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier(AssetID);
			} 
			set
			{
				AssetID = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 default(MeasureResource.IfcIdentifier) ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 7)]
		IIfcCostValue IIfcAsset.OriginalValue 
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

		[CrossSchemaAttribute(typeof(IIfcAsset), 8)]
		IIfcCostValue IIfcAsset.CurrentValue 
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

		[CrossSchemaAttribute(typeof(IIfcAsset), 9)]
		IIfcCostValue IIfcAsset.TotalReplacementCost 
		{ 
			get
			{
				return TotalReplacementCost;
			} 
			set
			{
				TotalReplacementCost = value as CostResource.IfcCostValue;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 10)]
		IIfcActorSelect IIfcAsset.Owner 
		{ 
			get
			{
				if (Owner == null) return null;
				var ifcorganization = Owner as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = Owner as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = Owner as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					Owner = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					Owner = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					Owner = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					Owner = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 11)]
		IIfcActorSelect IIfcAsset.User 
		{ 
			get
			{
				if (User == null) return null;
				var ifcorganization = User as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = User as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = User as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					User = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					User = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					User = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					User = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 12)]
		IIfcPerson IIfcAsset.ResponsiblePerson 
		{ 
			get
			{
				return ResponsiblePerson;
			} 
			set
			{
				ResponsiblePerson = value as ActorResource.IfcPerson;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 13)]
		Ifc4.DateTimeResource.IfcDate? IIfcAsset.IncorporationDate 
		{ 
			get
			{
				//## Handle return of IncorporationDate for which no match was found
			    return IncorporationDate != null
			        ? new Ifc4.DateTimeResource.IfcDate(IncorporationDate.ToISODateTimeString())
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of IncorporationDate for which no match was found
                if (!value.HasValue)
                {
                    IncorporationDate = null;
                    return;
                }
                System.DateTime d = value.Value;
                IncorporationDate = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                {
                    date.YearComponent = d.Year;
                    date.MonthComponent = d.Month;
                    date.DayComponent = d.Day;
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcAsset), 14)]
		IIfcCostValue IIfcAsset.DepreciatedValue 
		{ 
			get
			{
				return DepreciatedValue;
			} 
			set
			{
				DepreciatedValue = value as CostResource.IfcCostValue;
				
			}
		}
	//## Custom code
	//##
	}
}