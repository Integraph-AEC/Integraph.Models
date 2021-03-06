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
	public partial class @IfcDoorStyle : IIfcDoorStyle
	{

		[CrossSchemaAttribute(typeof(IIfcDoorStyle), 9)]
		Ifc4.Interfaces.IfcDoorStyleOperationEnum IIfcDoorStyle.OperationType 
		{ 
			get
			{
				//## Custom code to handle enumeration of OperationType
				//##
				switch (OperationType)
				{
					case IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT;
					case IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT;
					case IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT;
					case IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING;
					case IfcDoorStyleOperationEnum.SLIDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_LEFT;
					case IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING;
					case IfcDoorStyleOperationEnum.FOLDING_TO_LEFT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_LEFT;
					case IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT;
					case IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING;
					case IfcDoorStyleOperationEnum.REVOLVING:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.REVOLVING;
					case IfcDoorStyleOperationEnum.ROLLINGUP:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.ROLLINGUP;
					case IfcDoorStyleOperationEnum.USERDEFINED:
						//## Optional custom handling of OperationType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.USERDEFINED;
					case IfcDoorStyleOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleOperationEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of OperationType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT:
						OperationType = IfcDoorStyleOperationEnum.SINGLE_SWING_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT:
						OperationType = IfcDoorStyleOperationEnum.SINGLE_SWING_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_SINGLE_SWING_OPPOSITE_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_SWING_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_SWING_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_DOUBLE_SWING;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_LEFT:
						OperationType = IfcDoorStyleOperationEnum.SLIDING_TO_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT:
						OperationType = IfcDoorStyleOperationEnum.SLIDING_TO_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_SLIDING;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_LEFT:
						OperationType = IfcDoorStyleOperationEnum.FOLDING_TO_LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT:
						OperationType = IfcDoorStyleOperationEnum.FOLDING_TO_RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING:
						OperationType = IfcDoorStyleOperationEnum.DOUBLE_DOOR_FOLDING;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.REVOLVING:
						OperationType = IfcDoorStyleOperationEnum.REVOLVING;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.ROLLINGUP:
						OperationType = IfcDoorStyleOperationEnum.ROLLINGUP;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.USERDEFINED:
						OperationType = IfcDoorStyleOperationEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDoorStyleOperationEnum.NOTDEFINED:
						OperationType = IfcDoorStyleOperationEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorStyle), 10)]
		Ifc4.Interfaces.IfcDoorStyleConstructionEnum IIfcDoorStyle.ConstructionType 
		{ 
			get
			{
				//## Custom code to handle enumeration of ConstructionType
				//##
				switch (ConstructionType)
				{
					case IfcDoorStyleConstructionEnum.ALUMINIUM:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM;
					case IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL;
					case IfcDoorStyleConstructionEnum.STEEL:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.STEEL;
					case IfcDoorStyleConstructionEnum.WOOD:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.WOOD;
					case IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD;
					case IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC;
					case IfcDoorStyleConstructionEnum.PLASTIC:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.PLASTIC;
					case IfcDoorStyleConstructionEnum.USERDEFINED:
						//## Optional custom handling of ConstructionType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.USERDEFINED;
					case IfcDoorStyleConstructionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorStyleConstructionEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of ConstructionType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM:
						ConstructionType = IfcDoorStyleConstructionEnum.ALUMINIUM;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL:
						ConstructionType = IfcDoorStyleConstructionEnum.HIGH_GRADE_STEEL;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.STEEL:
						ConstructionType = IfcDoorStyleConstructionEnum.STEEL;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.WOOD:
						ConstructionType = IfcDoorStyleConstructionEnum.WOOD;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD:
						ConstructionType = IfcDoorStyleConstructionEnum.ALUMINIUM_WOOD;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC:
						ConstructionType = IfcDoorStyleConstructionEnum.ALUMINIUM_PLASTIC;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.PLASTIC:
						ConstructionType = IfcDoorStyleConstructionEnum.PLASTIC;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.USERDEFINED:
						ConstructionType = IfcDoorStyleConstructionEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDoorStyleConstructionEnum.NOTDEFINED:
						ConstructionType = IfcDoorStyleConstructionEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorStyle), 11)]
		Ifc4.MeasureResource.IfcBoolean IIfcDoorStyle.ParameterTakesPrecedence 
		{ 
			get
			{
				//## Handle return of ParameterTakesPrecedence for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(ParameterTakesPrecedence);
			    //##
			} 
			set
			{
				ParameterTakesPrecedence = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorStyle), 12)]
		Ifc4.MeasureResource.IfcBoolean IIfcDoorStyle.Sizeable 
		{ 
			get
			{
				//## Handle return of Sizeable for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(Sizeable);
				//##
			} 
			set
			{
				Sizeable = value;
				
			}
		}
	//## Custom code
	//##
	}
}