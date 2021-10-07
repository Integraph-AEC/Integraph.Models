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
	public partial class @IfcOrganizationRelationship : IIfcOrganizationRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcOrganizationRelationship), 3)]
		IIfcOrganization IIfcOrganizationRelationship.RelatingOrganization 
		{ 
			get
			{
				return RelatingOrganization;
			} 
			set
			{
				RelatingOrganization = value as IfcOrganization;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOrganizationRelationship), 4)]
		IItemSet<IIfcOrganization> IIfcOrganizationRelationship.RelatedOrganizations 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcOrganization, IIfcOrganization>(RelatedOrganizations);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcOrganizationRelationship), 1)]
		Ifc4.MeasureResource.IfcLabel? IIfcResourceLevelRelationship.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 default(MeasureResource.IfcLabel) ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcOrganizationRelationship), 2)]
		Ifc4.MeasureResource.IfcText? IIfcResourceLevelRelationship.Description 
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
	//## Custom code
	//##
	}
}