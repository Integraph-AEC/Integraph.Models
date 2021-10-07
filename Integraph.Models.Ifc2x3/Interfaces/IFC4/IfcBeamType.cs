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
namespace Integraph.Models.Ifc2x3.SharedBldgElements
{
	public partial class @IfcBeamType : IIfcBeamType
	{

		[CrossSchemaAttribute(typeof(IIfcBeamType), 10)]
		Ifc4.Interfaces.IfcBeamTypeEnum IIfcBeamType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcBeamTypeEnum.BEAM:
						return Ifc4.Interfaces.IfcBeamTypeEnum.BEAM;
					case IfcBeamTypeEnum.JOIST:
						return Ifc4.Interfaces.IfcBeamTypeEnum.JOIST;
					case IfcBeamTypeEnum.LINTEL:
						return Ifc4.Interfaces.IfcBeamTypeEnum.LINTEL;
					case IfcBeamTypeEnum.T_BEAM:
						return Ifc4.Interfaces.IfcBeamTypeEnum.T_BEAM;
					case IfcBeamTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcBeamTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcBeamTypeEnum.USERDEFINED;
					case IfcBeamTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBeamTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcBeamTypeEnum.BEAM:
						PredefinedType = IfcBeamTypeEnum.BEAM;
						return;
					case Ifc4.Interfaces.IfcBeamTypeEnum.JOIST:
						PredefinedType = IfcBeamTypeEnum.JOIST;
						return;
					case Ifc4.Interfaces.IfcBeamTypeEnum.HOLLOWCORE:
						//## Handle setting of HOLLOWCORE member from IfcBeamTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBeamTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBeamTypeEnum.LINTEL:
						PredefinedType = IfcBeamTypeEnum.LINTEL;
						return;
					case Ifc4.Interfaces.IfcBeamTypeEnum.SPANDREL:
						//## Handle setting of SPANDREL member from IfcBeamTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBeamTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBeamTypeEnum.T_BEAM:
						PredefinedType = IfcBeamTypeEnum.T_BEAM;
						return;
					case Ifc4.Interfaces.IfcBeamTypeEnum.USERDEFINED:
						PredefinedType = IfcBeamTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcBeamTypeEnum.NOTDEFINED:
						PredefinedType = IfcBeamTypeEnum.NOTDEFINED;
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