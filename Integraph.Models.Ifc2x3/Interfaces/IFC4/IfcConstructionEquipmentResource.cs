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
namespace Integraph.Models.Ifc2x3.ConstructionMgmtDomain
{
	public partial class @IfcConstructionEquipmentResource : IIfcConstructionEquipmentResource
	{

		private  Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcConstructionEquipmentResource), 11)]
		Ifc4.Interfaces.IfcConstructionEquipmentResourceTypeEnum? IIfcConstructionEquipmentResource.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -11);
				
			}
		}
	//## Custom code
	//##
	}
}