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
	public partial class @IfcEvaporatorType : IIfcEvaporatorType
	{

		[CrossSchemaAttribute(typeof(IIfcEvaporatorType), 10)]
		Ifc4.Interfaces.IfcEvaporatorTypeEnum IIfcEvaporatorType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcEvaporatorTypeEnum.DIRECTEXPANSIONSHELLANDTUBE:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONSHELLANDTUBE;
					case IfcEvaporatorTypeEnum.DIRECTEXPANSIONTUBEINTUBE:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONTUBEINTUBE;
					case IfcEvaporatorTypeEnum.DIRECTEXPANSIONBRAZEDPLATE:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONBRAZEDPLATE;
					case IfcEvaporatorTypeEnum.FLOODEDSHELLANDTUBE:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.FLOODEDSHELLANDTUBE;
					case IfcEvaporatorTypeEnum.SHELLANDCOIL:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.SHELLANDCOIL;
					case IfcEvaporatorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcEvaporatorTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.USERDEFINED;
					case IfcEvaporatorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcEvaporatorTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSION:
						//## Handle setting of DIRECTEXPANSION member from IfcEvaporatorTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcEvaporatorTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONSHELLANDTUBE:
						PredefinedType = IfcEvaporatorTypeEnum.DIRECTEXPANSIONSHELLANDTUBE;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONTUBEINTUBE:
						PredefinedType = IfcEvaporatorTypeEnum.DIRECTEXPANSIONTUBEINTUBE;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.DIRECTEXPANSIONBRAZEDPLATE:
						PredefinedType = IfcEvaporatorTypeEnum.DIRECTEXPANSIONBRAZEDPLATE;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.FLOODEDSHELLANDTUBE:
						PredefinedType = IfcEvaporatorTypeEnum.FLOODEDSHELLANDTUBE;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.SHELLANDCOIL:
						PredefinedType = IfcEvaporatorTypeEnum.SHELLANDCOIL;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.USERDEFINED:
						PredefinedType = IfcEvaporatorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcEvaporatorTypeEnum.NOTDEFINED:
						PredefinedType = IfcEvaporatorTypeEnum.NOTDEFINED;
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