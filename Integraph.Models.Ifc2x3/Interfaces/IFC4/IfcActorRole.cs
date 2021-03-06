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
namespace Integraph.Models.Ifc2x3.ActorResource
{
	public partial class @IfcActorRole : IIfcActorRole
	{

		[CrossSchemaAttribute(typeof(IIfcActorRole), 1)]
		Ifc4.Interfaces.IfcRoleEnum IIfcActorRole.Role 
		{ 
			get
			{
				//## Custom code to handle enumeration of Role
				//##
				switch (Role)
				{
					case IfcRoleEnum.SUPPLIER:
						return Ifc4.Interfaces.IfcRoleEnum.SUPPLIER;
					case IfcRoleEnum.MANUFACTURER:
						return Ifc4.Interfaces.IfcRoleEnum.MANUFACTURER;
					case IfcRoleEnum.CONTRACTOR:
						return Ifc4.Interfaces.IfcRoleEnum.CONTRACTOR;
					case IfcRoleEnum.SUBCONTRACTOR:
						return Ifc4.Interfaces.IfcRoleEnum.SUBCONTRACTOR;
					case IfcRoleEnum.ARCHITECT:
						return Ifc4.Interfaces.IfcRoleEnum.ARCHITECT;
					case IfcRoleEnum.STRUCTURALENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.STRUCTURALENGINEER;
					case IfcRoleEnum.COSTENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.COSTENGINEER;
					case IfcRoleEnum.CLIENT:
						return Ifc4.Interfaces.IfcRoleEnum.CLIENT;
					case IfcRoleEnum.BUILDINGOWNER:
						return Ifc4.Interfaces.IfcRoleEnum.BUILDINGOWNER;
					case IfcRoleEnum.BUILDINGOPERATOR:
						return Ifc4.Interfaces.IfcRoleEnum.BUILDINGOPERATOR;
					case IfcRoleEnum.MECHANICALENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.MECHANICALENGINEER;
					case IfcRoleEnum.ELECTRICALENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.ELECTRICALENGINEER;
					case IfcRoleEnum.PROJECTMANAGER:
						return Ifc4.Interfaces.IfcRoleEnum.PROJECTMANAGER;
					case IfcRoleEnum.FACILITIESMANAGER:
						return Ifc4.Interfaces.IfcRoleEnum.FACILITIESMANAGER;
					case IfcRoleEnum.CIVILENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.CIVILENGINEER;
					case IfcRoleEnum.COMISSIONINGENGINEER:
						//## Handle translation of COMISSIONINGENGINEER member from IfcRoleEnum in property Role
						return Ifc4.Interfaces.IfcRoleEnum.COMMISSIONINGENGINEER;
						//##
					case IfcRoleEnum.ENGINEER:
						return Ifc4.Interfaces.IfcRoleEnum.ENGINEER;
					case IfcRoleEnum.OWNER:
						return Ifc4.Interfaces.IfcRoleEnum.OWNER;
					case IfcRoleEnum.CONSULTANT:
						return Ifc4.Interfaces.IfcRoleEnum.CONSULTANT;
					case IfcRoleEnum.CONSTRUCTIONMANAGER:
						return Ifc4.Interfaces.IfcRoleEnum.CONSTRUCTIONMANAGER;
					case IfcRoleEnum.FIELDCONSTRUCTIONMANAGER:
						return Ifc4.Interfaces.IfcRoleEnum.FIELDCONSTRUCTIONMANAGER;
					case IfcRoleEnum.RESELLER:
						return Ifc4.Interfaces.IfcRoleEnum.RESELLER;
					case IfcRoleEnum.USERDEFINED:
						//## Optional custom handling of Role == .USERDEFINED. 
				        if (UserDefinedRole == "COMMISSIONINGENGINEER")
				            return Ifc4.Interfaces.IfcRoleEnum.COMMISSIONINGENGINEER;
						//##
						return Ifc4.Interfaces.IfcRoleEnum.USERDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of Role
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcRoleEnum.SUPPLIER:
						Role = IfcRoleEnum.SUPPLIER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.MANUFACTURER:
						Role = IfcRoleEnum.MANUFACTURER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.CONTRACTOR:
						Role = IfcRoleEnum.CONTRACTOR;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.SUBCONTRACTOR:
						Role = IfcRoleEnum.SUBCONTRACTOR;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.ARCHITECT:
						Role = IfcRoleEnum.ARCHITECT;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.STRUCTURALENGINEER:
						Role = IfcRoleEnum.STRUCTURALENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.COSTENGINEER:
						Role = IfcRoleEnum.COSTENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.CLIENT:
						Role = IfcRoleEnum.CLIENT;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.BUILDINGOWNER:
						Role = IfcRoleEnum.BUILDINGOWNER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.BUILDINGOPERATOR:
						Role = IfcRoleEnum.BUILDINGOPERATOR;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.MECHANICALENGINEER:
						Role = IfcRoleEnum.MECHANICALENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.ELECTRICALENGINEER:
						Role = IfcRoleEnum.ELECTRICALENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.PROJECTMANAGER:
						Role = IfcRoleEnum.PROJECTMANAGER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.FACILITIESMANAGER:
						Role = IfcRoleEnum.FACILITIESMANAGER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.CIVILENGINEER:
						Role = IfcRoleEnum.CIVILENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.COMMISSIONINGENGINEER:
						//## Handle setting of COMMISSIONINGENGINEER member from IfcRoleEnum in property Role
                        Role = IfcRoleEnum.COMISSIONINGENGINEER;
				        return;
						//##
										case Ifc4.Interfaces.IfcRoleEnum.ENGINEER:
						Role = IfcRoleEnum.ENGINEER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.OWNER:
						Role = IfcRoleEnum.OWNER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.CONSULTANT:
						Role = IfcRoleEnum.CONSULTANT;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.CONSTRUCTIONMANAGER:
						Role = IfcRoleEnum.CONSTRUCTIONMANAGER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.FIELDCONSTRUCTIONMANAGER:
						Role = IfcRoleEnum.FIELDCONSTRUCTIONMANAGER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.RESELLER:
						Role = IfcRoleEnum.RESELLER;
						return;
					case Ifc4.Interfaces.IfcRoleEnum.USERDEFINED:
						Role = IfcRoleEnum.USERDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcActorRole), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcActorRole.UserDefinedRole 
		{ 
			get
			{
				if (!UserDefinedRole.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedRole.Value);
			} 
			set
			{
				UserDefinedRole = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcActorRole), 3)]
		Ifc4.MeasureResource.IfcText? IIfcActorRole.Description 
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
		IEnumerable<IIfcExternalReferenceRelationship> IIfcActorRole.HasExternalReference 
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