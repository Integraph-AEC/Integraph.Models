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
namespace Integraph.Models.Ifc2x3.ElectricalDomain
{
	public partial class @IfcJunctionBoxType : IIfcJunctionBoxType
	{

		[CrossSchemaAttribute(typeof(IIfcJunctionBoxType), 10)]
		Ifc4.Interfaces.IfcJunctionBoxTypeEnum IIfcJunctionBoxType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcJunctionBoxTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcJunctionBoxTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcJunctionBoxTypeEnum.USERDEFINED;
					case IfcJunctionBoxTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcJunctionBoxTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.DATA:
						//## Handle setting of DATA member from IfcJunctionBoxTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcJunctionBoxTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.POWER:
						//## Handle setting of POWER member from IfcJunctionBoxTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcJunctionBoxTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.USERDEFINED:
						PredefinedType = IfcJunctionBoxTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcJunctionBoxTypeEnum.NOTDEFINED:
						PredefinedType = IfcJunctionBoxTypeEnum.NOTDEFINED;
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