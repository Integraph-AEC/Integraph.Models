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
namespace Integraph.Models.Ifc2x3.FacilitiesMgmtDomain
{
	public partial class @IfcPermit : IIfcPermit
	{

		private  Ifc4.Interfaces.IfcPermitTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcPermit), 7)]
		Ifc4.Interfaces.IfcPermitTypeEnum? IIfcPermit.PredefinedType 
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

		private  Ifc4.MeasureResource.IfcLabel? _status;


		[CrossSchemaAttribute(typeof(IIfcPermit), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcPermit.Status 
		{ 
			get
			{
				return _status;
			} 
			set
			{
				SetValue(v => _status = v, _status, value, "Status", -8);
				
			}
		}

		private  Ifc4.MeasureResource.IfcText? _longDescription;


		[CrossSchemaAttribute(typeof(IIfcPermit), 9)]
		Ifc4.MeasureResource.IfcText? IIfcPermit.LongDescription 
		{ 
			get
			{
				return _longDescription;
			} 
			set
			{
				SetValue(v => _longDescription = v, _longDescription, value, "LongDescription", -9);
				
			}
		}
	//## Custom code
	//##
	}
}