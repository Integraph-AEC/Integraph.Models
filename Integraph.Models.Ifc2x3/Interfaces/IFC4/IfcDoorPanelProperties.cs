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
	public partial class @IfcDoorPanelProperties : IIfcDoorPanelProperties
	{

		[CrossSchemaAttribute(typeof(IIfcDoorPanelProperties), 5)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcDoorPanelProperties.PanelDepth 
		{ 
			get
			{
				if (!PanelDepth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(PanelDepth.Value);
			} 
			set
			{
				PanelDepth = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorPanelProperties), 6)]
		Ifc4.Interfaces.IfcDoorPanelOperationEnum IIfcDoorPanelProperties.PanelOperation 
		{ 
			get
			{
				//## Custom code to handle enumeration of PanelOperation
				//##
				switch (PanelOperation)
				{
					case IfcDoorPanelOperationEnum.SWINGING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.SWINGING;
					case IfcDoorPanelOperationEnum.DOUBLE_ACTING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.DOUBLE_ACTING;
					case IfcDoorPanelOperationEnum.SLIDING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.SLIDING;
					case IfcDoorPanelOperationEnum.FOLDING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.FOLDING;
					case IfcDoorPanelOperationEnum.REVOLVING:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.REVOLVING;
					case IfcDoorPanelOperationEnum.ROLLINGUP:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.ROLLINGUP;
					case IfcDoorPanelOperationEnum.USERDEFINED:
						//## Optional custom handling of PanelOperation == .USERDEFINED. 
				        if (_panelOperation4.HasValue)
				            return _panelOperation4.Value;
						//##
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.USERDEFINED;
					case IfcDoorPanelOperationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorPanelOperationEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PanelOperation
			    if (_panelOperation4.HasValue && value != Ifc4.Interfaces.IfcDoorPanelOperationEnum.FIXEDPANEL)
                    SetValue(v => _panelOperation4 = v, _panelOperation4, null, "PanelOperation", -6);
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.SWINGING:
						PanelOperation = IfcDoorPanelOperationEnum.SWINGING;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.DOUBLE_ACTING:
						PanelOperation = IfcDoorPanelOperationEnum.DOUBLE_ACTING;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.SLIDING:
						PanelOperation = IfcDoorPanelOperationEnum.SLIDING;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.FOLDING:
						PanelOperation = IfcDoorPanelOperationEnum.FOLDING;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.REVOLVING:
						PanelOperation = IfcDoorPanelOperationEnum.REVOLVING;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.ROLLINGUP:
						PanelOperation = IfcDoorPanelOperationEnum.ROLLINGUP;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.FIXEDPANEL:
						//## Handle setting of FIXEDPANEL member from IfcDoorPanelOperationEnum in property PanelOperation
                        PanelOperation = IfcDoorPanelOperationEnum.USERDEFINED;
                        SetValue(v => _panelOperation4 = v, _panelOperation4, value, "PanelOperation", -6);
				        return;
						//##
										case Ifc4.Interfaces.IfcDoorPanelOperationEnum.USERDEFINED:
						PanelOperation = IfcDoorPanelOperationEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDoorPanelOperationEnum.NOTDEFINED:
						PanelOperation = IfcDoorPanelOperationEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorPanelProperties), 7)]
		Ifc4.MeasureResource.IfcNormalisedRatioMeasure? IIfcDoorPanelProperties.PanelWidth 
		{ 
			get
			{
				if (!PanelWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure(PanelWidth.Value);
			} 
			set
			{
				PanelWidth = value.HasValue ? 
					new MeasureResource.IfcNormalisedRatioMeasure(value.Value) :  
					 new MeasureResource.IfcNormalisedRatioMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorPanelProperties), 8)]
		Ifc4.Interfaces.IfcDoorPanelPositionEnum IIfcDoorPanelProperties.PanelPosition 
		{ 
			get
			{
				//## Custom code to handle enumeration of PanelPosition
				//##
				switch (PanelPosition)
				{
					case IfcDoorPanelPositionEnum.LEFT:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.LEFT;
					case IfcDoorPanelPositionEnum.MIDDLE:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.MIDDLE;
					case IfcDoorPanelPositionEnum.RIGHT:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.RIGHT;
					case IfcDoorPanelPositionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDoorPanelPositionEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PanelPosition
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.LEFT:
						PanelPosition = IfcDoorPanelPositionEnum.LEFT;
						return;
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.MIDDLE:
						PanelPosition = IfcDoorPanelPositionEnum.MIDDLE;
						return;
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.RIGHT:
						PanelPosition = IfcDoorPanelPositionEnum.RIGHT;
						return;
					case Ifc4.Interfaces.IfcDoorPanelPositionEnum.NOTDEFINED:
						PanelPosition = IfcDoorPanelPositionEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDoorPanelProperties), 9)]
		IIfcShapeAspect IIfcDoorPanelProperties.ShapeAspectStyle 
		{ 
			get
			{
				return ShapeAspectStyle;
			} 
			set
			{
				ShapeAspectStyle = value as RepresentationResource.IfcShapeAspect;
				
			}
		}
	//## Custom code
	    private Ifc4.Interfaces.IfcDoorPanelOperationEnum? _panelOperation4;
	    //##
	}
}