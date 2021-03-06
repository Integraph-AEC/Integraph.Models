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
	public partial class @IfcColumnType : IIfcColumnType
	{

		[CrossSchemaAttribute(typeof(IIfcColumnType), 10)]
		Ifc4.Interfaces.IfcColumnTypeEnum IIfcColumnType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcColumnTypeEnum.COLUMN:
						return Ifc4.Interfaces.IfcColumnTypeEnum.COLUMN;
					case IfcColumnTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
                        if (ElementType.HasValue)
                        {
                            Ifc4.Interfaces.IfcColumnTypeEnum result;
                            if (System.Enum.TryParse(ElementType.Value, false, out result))
                                return result;
                        }
						//##
						return Ifc4.Interfaces.IfcColumnTypeEnum.USERDEFINED;
					case IfcColumnTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcColumnTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcColumnTypeEnum.COLUMN:
						PredefinedType = IfcColumnTypeEnum.COLUMN;
						return;
					case Ifc4.Interfaces.IfcColumnTypeEnum.PILASTER:
						//## Handle setting of PILASTER member from IfcColumnTypeEnum in property PredefinedType
						ElementType = value.ToString();
                        PredefinedType = IfcColumnTypeEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcColumnTypeEnum.USERDEFINED:
						PredefinedType = IfcColumnTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcColumnTypeEnum.NOTDEFINED:
						PredefinedType = IfcColumnTypeEnum.NOTDEFINED;
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