// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.SharedBldgElements;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ArchitectureDomain;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPermeableCoveringProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPermeableCoveringProperties : IIfcPropertySetDefinition
	{
		IfcPermeableCoveringOperationEnum @OperationType { get;  set; }
		IfcWindowPanelPositionEnum @PanelPosition { get;  set; }
		IfcPositiveLengthMeasure? @FrameDepth { get;  set; }
		IfcPositiveLengthMeasure? @FrameThickness { get;  set; }
		IIfcShapeAspect @ShapeAspectStyle { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ArchitectureDomain
{
	[ExpressType("IfcPermeableCoveringProperties", 707)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPermeableCoveringProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcPermeableCoveringProperties, IContainsEntityReferences, IEquatable<@IfcPermeableCoveringProperties>
	{
		#region IIfcPermeableCoveringProperties explicit implementation
		IfcPermeableCoveringOperationEnum IIfcPermeableCoveringProperties.OperationType { 
 
			get { return @OperationType; } 
			set { OperationType = value;}
		}	
		IfcWindowPanelPositionEnum IIfcPermeableCoveringProperties.PanelPosition { 
 
			get { return @PanelPosition; } 
			set { PanelPosition = value;}
		}	
		IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameDepth { 
 
			get { return @FrameDepth; } 
			set { FrameDepth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcPermeableCoveringProperties.FrameThickness { 
 
			get { return @FrameThickness; } 
			set { FrameThickness = value;}
		}	
		IIfcShapeAspect IIfcPermeableCoveringProperties.ShapeAspectStyle { 
 
 
			get { return @ShapeAspectStyle; } 
			set { ShapeAspectStyle = value as IfcShapeAspect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPermeableCoveringProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPermeableCoveringOperationEnum _operationType;
		private IfcWindowPanelPositionEnum _panelPosition;
		private IfcPositiveLengthMeasure? _frameDepth;
		private IfcPositiveLengthMeasure? _frameThickness;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 8)]
		public IfcPermeableCoveringOperationEnum @OperationType 
		{ 
			get 
			{
				if(_activated) return _operationType;
				Activate();
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 9)]
		public IfcWindowPanelPositionEnum @PanelPosition 
		{ 
			get 
			{
				if(_activated) return _panelPosition;
				Activate();
				return _panelPosition;
			} 
			set
			{
				SetValue( v =>  _panelPosition = v, _panelPosition, value,  "PanelPosition", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveLengthMeasure? @FrameDepth 
		{ 
			get 
			{
				if(_activated) return _frameDepth;
				Activate();
				return _frameDepth;
			} 
			set
			{
				SetValue( v =>  _frameDepth = v, _frameDepth, value,  "FrameDepth", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcPositiveLengthMeasure? @FrameThickness 
		{ 
			get 
			{
				if(_activated) return _frameThickness;
				Activate();
				return _frameThickness;
			} 
			set
			{
				SetValue( v =>  _frameThickness = v, _frameThickness, value,  "FrameThickness", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcShapeAspect @ShapeAspectStyle 
		{ 
			get 
			{
				if(_activated) return _shapeAspectStyle;
				Activate();
				return _shapeAspectStyle;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 9);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
                    _operationType = (IfcPermeableCoveringOperationEnum) System.Enum.Parse(typeof (IfcPermeableCoveringOperationEnum), value.EnumVal, true);
					return;
				case 5: 
                    _panelPosition = (IfcWindowPanelPositionEnum) System.Enum.Parse(typeof (IfcWindowPanelPositionEnum), value.EnumVal, true);
					return;
				case 6: 
					_frameDepth = value.RealVal;
					return;
				case 7: 
					_frameThickness = value.RealVal;
					return;
				case 8: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPermeableCoveringProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ShapeAspectStyle != null)
					yield return @ShapeAspectStyle;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}