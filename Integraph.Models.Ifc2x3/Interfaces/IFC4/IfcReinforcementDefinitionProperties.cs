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
namespace Integraph.Models.Ifc2x3.StructuralElementsDomain
{
	public partial class @IfcReinforcementDefinitionProperties : IIfcReinforcementDefinitionProperties
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcementDefinitionProperties), 5)]
		Ifc4.MeasureResource.IfcLabel? IIfcReinforcementDefinitionProperties.DefinitionType 
		{ 
			get
			{
				if (!DefinitionType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(DefinitionType.Value);
			} 
			set
			{
				DefinitionType = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcementDefinitionProperties), 6)]
		IItemSet<IIfcSectionReinforcementProperties> IIfcReinforcementDefinitionProperties.ReinforcementSectionDefinitions 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ProfilePropertyResource.IfcSectionReinforcementProperties, IIfcSectionReinforcementProperties>(ReinforcementSectionDefinitions);
			} 
		}
	//## Custom code
	//##
	}
}