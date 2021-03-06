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
namespace Integraph.Models.Ifc2x3.HVACDomain
{
	public partial class @IfcVibrationIsolatorType : IIfcVibrationIsolatorType
	{

		[CrossSchemaAttribute(typeof(IIfcVibrationIsolatorType), 10)]
		Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum IIfcVibrationIsolatorType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcVibrationIsolatorTypeEnum.COMPRESSION:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.COMPRESSION;
					case IfcVibrationIsolatorTypeEnum.SPRING:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.SPRING;
					case IfcVibrationIsolatorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.USERDEFINED;
					case IfcVibrationIsolatorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.COMPRESSION:
						PredefinedType = IfcVibrationIsolatorTypeEnum.COMPRESSION;
						return;
					case Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.SPRING:
						PredefinedType = IfcVibrationIsolatorTypeEnum.SPRING;
						return;
					case Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.USERDEFINED:
						PredefinedType = IfcVibrationIsolatorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcVibrationIsolatorTypeEnum.NOTDEFINED:
						PredefinedType = IfcVibrationIsolatorTypeEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}