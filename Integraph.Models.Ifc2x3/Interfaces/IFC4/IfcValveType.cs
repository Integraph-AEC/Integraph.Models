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
	public partial class @IfcValveType : IIfcValveType
	{

		[CrossSchemaAttribute(typeof(IIfcValveType), 10)]
		Ifc4.Interfaces.IfcValveTypeEnum IIfcValveType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcValveTypeEnum.AIRRELEASE:
						return Ifc4.Interfaces.IfcValveTypeEnum.AIRRELEASE;
					case IfcValveTypeEnum.ANTIVACUUM:
						return Ifc4.Interfaces.IfcValveTypeEnum.ANTIVACUUM;
					case IfcValveTypeEnum.CHANGEOVER:
						return Ifc4.Interfaces.IfcValveTypeEnum.CHANGEOVER;
					case IfcValveTypeEnum.CHECK:
						return Ifc4.Interfaces.IfcValveTypeEnum.CHECK;
					case IfcValveTypeEnum.COMMISSIONING:
						return Ifc4.Interfaces.IfcValveTypeEnum.COMMISSIONING;
					case IfcValveTypeEnum.DIVERTING:
						return Ifc4.Interfaces.IfcValveTypeEnum.DIVERTING;
					case IfcValveTypeEnum.DRAWOFFCOCK:
						return Ifc4.Interfaces.IfcValveTypeEnum.DRAWOFFCOCK;
					case IfcValveTypeEnum.DOUBLECHECK:
						return Ifc4.Interfaces.IfcValveTypeEnum.DOUBLECHECK;
					case IfcValveTypeEnum.DOUBLEREGULATING:
						return Ifc4.Interfaces.IfcValveTypeEnum.DOUBLEREGULATING;
					case IfcValveTypeEnum.FAUCET:
						return Ifc4.Interfaces.IfcValveTypeEnum.FAUCET;
					case IfcValveTypeEnum.FLUSHING:
						return Ifc4.Interfaces.IfcValveTypeEnum.FLUSHING;
					case IfcValveTypeEnum.GASCOCK:
						return Ifc4.Interfaces.IfcValveTypeEnum.GASCOCK;
					case IfcValveTypeEnum.GASTAP:
						return Ifc4.Interfaces.IfcValveTypeEnum.GASTAP;
					case IfcValveTypeEnum.ISOLATING:
						return Ifc4.Interfaces.IfcValveTypeEnum.ISOLATING;
					case IfcValveTypeEnum.MIXING:
						return Ifc4.Interfaces.IfcValveTypeEnum.MIXING;
					case IfcValveTypeEnum.PRESSUREREDUCING:
						return Ifc4.Interfaces.IfcValveTypeEnum.PRESSUREREDUCING;
					case IfcValveTypeEnum.PRESSURERELIEF:
						return Ifc4.Interfaces.IfcValveTypeEnum.PRESSURERELIEF;
					case IfcValveTypeEnum.REGULATING:
						return Ifc4.Interfaces.IfcValveTypeEnum.REGULATING;
					case IfcValveTypeEnum.SAFETYCUTOFF:
						return Ifc4.Interfaces.IfcValveTypeEnum.SAFETYCUTOFF;
					case IfcValveTypeEnum.STEAMTRAP:
						return Ifc4.Interfaces.IfcValveTypeEnum.STEAMTRAP;
					case IfcValveTypeEnum.STOPCOCK:
						return Ifc4.Interfaces.IfcValveTypeEnum.STOPCOCK;
					case IfcValveTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcValveTypeEnum.USERDEFINED;
					case IfcValveTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcValveTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcValveTypeEnum.AIRRELEASE:
						PredefinedType = IfcValveTypeEnum.AIRRELEASE;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.ANTIVACUUM:
						PredefinedType = IfcValveTypeEnum.ANTIVACUUM;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.CHANGEOVER:
						PredefinedType = IfcValveTypeEnum.CHANGEOVER;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.CHECK:
						PredefinedType = IfcValveTypeEnum.CHECK;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.COMMISSIONING:
						PredefinedType = IfcValveTypeEnum.COMMISSIONING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.DIVERTING:
						PredefinedType = IfcValveTypeEnum.DIVERTING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.DRAWOFFCOCK:
						PredefinedType = IfcValveTypeEnum.DRAWOFFCOCK;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.DOUBLECHECK:
						PredefinedType = IfcValveTypeEnum.DOUBLECHECK;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.DOUBLEREGULATING:
						PredefinedType = IfcValveTypeEnum.DOUBLEREGULATING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.FAUCET:
						PredefinedType = IfcValveTypeEnum.FAUCET;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.FLUSHING:
						PredefinedType = IfcValveTypeEnum.FLUSHING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.GASCOCK:
						PredefinedType = IfcValveTypeEnum.GASCOCK;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.GASTAP:
						PredefinedType = IfcValveTypeEnum.GASTAP;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.ISOLATING:
						PredefinedType = IfcValveTypeEnum.ISOLATING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.MIXING:
						PredefinedType = IfcValveTypeEnum.MIXING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.PRESSUREREDUCING:
						PredefinedType = IfcValveTypeEnum.PRESSUREREDUCING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.PRESSURERELIEF:
						PredefinedType = IfcValveTypeEnum.PRESSURERELIEF;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.REGULATING:
						PredefinedType = IfcValveTypeEnum.REGULATING;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.SAFETYCUTOFF:
						PredefinedType = IfcValveTypeEnum.SAFETYCUTOFF;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.STEAMTRAP:
						PredefinedType = IfcValveTypeEnum.STEAMTRAP;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.STOPCOCK:
						PredefinedType = IfcValveTypeEnum.STOPCOCK;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.USERDEFINED:
						PredefinedType = IfcValveTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcValveTypeEnum.NOTDEFINED:
						PredefinedType = IfcValveTypeEnum.NOTDEFINED;
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