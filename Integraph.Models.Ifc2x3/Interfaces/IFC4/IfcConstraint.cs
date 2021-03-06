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
namespace Integraph.Models.Ifc2x3.ConstraintResource
{
	public partial class @IfcConstraint : IIfcConstraint
	{

		[CrossSchemaAttribute(typeof(IIfcConstraint), 1)]
		Ifc4.MeasureResource.IfcLabel IIfcConstraint.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 2)]
		Ifc4.MeasureResource.IfcText? IIfcConstraint.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 3)]
		Ifc4.Interfaces.IfcConstraintEnum IIfcConstraint.ConstraintGrade 
		{ 
			get
			{
				//## Custom code to handle enumeration of ConstraintGrade
				//##
				switch (ConstraintGrade)
				{
					case IfcConstraintEnum.HARD:
						return Ifc4.Interfaces.IfcConstraintEnum.HARD;
					case IfcConstraintEnum.SOFT:
						return Ifc4.Interfaces.IfcConstraintEnum.SOFT;
					case IfcConstraintEnum.ADVISORY:
						return Ifc4.Interfaces.IfcConstraintEnum.ADVISORY;
					case IfcConstraintEnum.USERDEFINED:
						//## Optional custom handling of ConstraintGrade == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcConstraintEnum.USERDEFINED;
					case IfcConstraintEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcConstraintEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ConstraintGrade
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcConstraintEnum.HARD:
						ConstraintGrade = IfcConstraintEnum.HARD;
						return;
					case Ifc4.Interfaces.IfcConstraintEnum.SOFT:
						ConstraintGrade = IfcConstraintEnum.SOFT;
						return;
					case Ifc4.Interfaces.IfcConstraintEnum.ADVISORY:
						ConstraintGrade = IfcConstraintEnum.ADVISORY;
						return;
					case Ifc4.Interfaces.IfcConstraintEnum.USERDEFINED:
						ConstraintGrade = IfcConstraintEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcConstraintEnum.NOTDEFINED:
						ConstraintGrade = IfcConstraintEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 4)]
		Ifc4.MeasureResource.IfcLabel? IIfcConstraint.ConstraintSource 
		{ 
			get
			{
				if (!ConstraintSource.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ConstraintSource.Value);
			} 
			set
			{
				ConstraintSource = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 5)]
		IIfcActorSelect IIfcConstraint.CreatingActor 
		{ 
			get
			{
				if (CreatingActor == null) return null;
				var ifcorganization = CreatingActor as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = CreatingActor as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = CreatingActor as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					CreatingActor = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					CreatingActor = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					CreatingActor = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					CreatingActor = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 6)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcConstraint.CreationTime 
		{ 
			get
			{
				//## Handle return of CreationTime for which no match was found
			    return CreationTime == null
			        ? null
			        : new Ifc4.DateTimeResource.IfcDateTime(CreationTime.ToISODateTimeString());
			    //##
			} 
			set
			{
				//## Handle setting of CreationTime for which no match was found
			    if (!value.HasValue)
			    {
			        CreationTime = null;
			        return;
			    }
                System.DateTime d = value.Value;
                CreationTime = Model.Instances.New<DateTimeResource.IfcDateAndTime>(dt =>
                {
                    dt.DateComponent = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                    {
                        date.YearComponent = d.Year;
                        date.MonthComponent = d.Month;
                        date.DayComponent = d.Day;
                    });
                    dt.TimeComponent = Model.Instances.New<DateTimeResource.IfcLocalTime>(t =>
                    {
                        t.HourComponent = d.Hour;
                        t.MinuteComponent = d.Minute;
                        t.SecondComponent = d.Second;
                    });
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConstraint), 7)]
		Ifc4.MeasureResource.IfcLabel? IIfcConstraint.UserDefinedGrade 
		{ 
			get
			{
				if (!UserDefinedGrade.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedGrade.Value);
			} 
			set
			{
				UserDefinedGrade = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcExternalReferenceRelationship> IIfcConstraint.HasExternalReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcExternalReferenceRelationship>(e => e.RelatedResourceObjects != null &&  e.RelatedResourceObjects.Contains(this), "RelatedResourceObjects", this);
			} 
		}
		IEnumerable<IIfcResourceConstraintRelationship> IIfcConstraint.PropertiesForConstraint 
		{ 
			get
			{
				return Model.Instances.Where<IIfcResourceConstraintRelationship>(e => (e.RelatingConstraint as IfcConstraint) == this, "RelatingConstraint", this);
			} 
		}
	//## Custom code
	//##
	}
}