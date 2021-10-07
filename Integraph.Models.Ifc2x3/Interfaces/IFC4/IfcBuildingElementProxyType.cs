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
namespace Integraph.Models.Ifc2x3.ProductExtension
{
	public partial class @IfcBuildingElementProxyType : IIfcBuildingElementProxyType
	{

		[CrossSchemaAttribute(typeof(IIfcBuildingElementProxyType), 10)]
		Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum IIfcBuildingElementProxyType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcBuildingElementProxyTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.USERDEFINED;
					case IfcBuildingElementProxyTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.COMPLEX:
						//## Handle setting of COMPLEX member from IfcBuildingElementProxyTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.ELEMENT:
						//## Handle setting of ELEMENT member from IfcBuildingElementProxyTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.PARTIAL:
						//## Handle setting of PARTIAL member from IfcBuildingElementProxyTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.PROVISIONFORVOID:
						//## Handle setting of PROVISIONFORVOID member from IfcBuildingElementProxyTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.PROVISIONFORSPACE:
						//## Handle setting of PROVISIONFORSPACE member from IfcBuildingElementProxyTypeEnum in property PredefinedType
                        ElementType = value.ToString();
                        PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
                        return;
                        //##
										case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.USERDEFINED:
						PredefinedType = IfcBuildingElementProxyTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcBuildingElementProxyTypeEnum.NOTDEFINED:
						PredefinedType = IfcBuildingElementProxyTypeEnum.NOTDEFINED;
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