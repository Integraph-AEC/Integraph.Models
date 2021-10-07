// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.SharedBldgElements;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowLiningProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowLiningProperties : IIfcPropertySetDefinition
	{
		IfcPositiveLengthMeasure? @LiningDepth { get;  set; }
		IfcPositiveLengthMeasure? @LiningThickness { get;  set; }
		IfcPositiveLengthMeasure? @TransomThickness { get;  set; }
		IfcPositiveLengthMeasure? @MullionThickness { get;  set; }
		IfcNormalisedRatioMeasure? @FirstTransomOffset { get;  set; }
		IfcNormalisedRatioMeasure? @SecondTransomOffset { get;  set; }
		IfcNormalisedRatioMeasure? @FirstMullionOffset { get;  set; }
		IfcNormalisedRatioMeasure? @SecondMullionOffset { get;  set; }
		IIfcShapeAspect @ShapeAspectStyle { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.SharedBldgElements
{
	[ExpressType("IfcWindowLiningProperties", 252)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowLiningProperties : IfcPropertySetDefinition, IInstantiableEntity, IIfcWindowLiningProperties, IContainsEntityReferences, IEquatable<@IfcWindowLiningProperties>
	{
		#region IIfcWindowLiningProperties explicit implementation
		IfcPositiveLengthMeasure? IIfcWindowLiningProperties.LiningDepth { 
 
			get { return @LiningDepth; } 
			set { LiningDepth = value;}
		}	
		IfcPositiveLengthMeasure? IIfcWindowLiningProperties.LiningThickness { 
 
			get { return @LiningThickness; } 
			set { LiningThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcWindowLiningProperties.TransomThickness { 
 
			get { return @TransomThickness; } 
			set { TransomThickness = value;}
		}	
		IfcPositiveLengthMeasure? IIfcWindowLiningProperties.MullionThickness { 
 
			get { return @MullionThickness; } 
			set { MullionThickness = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstTransomOffset { 
 
			get { return @FirstTransomOffset; } 
			set { FirstTransomOffset = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondTransomOffset { 
 
			get { return @SecondTransomOffset; } 
			set { SecondTransomOffset = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.FirstMullionOffset { 
 
			get { return @FirstMullionOffset; } 
			set { FirstMullionOffset = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcWindowLiningProperties.SecondMullionOffset { 
 
			get { return @SecondMullionOffset; } 
			set { SecondMullionOffset = value;}
		}	
		IIfcShapeAspect IIfcWindowLiningProperties.ShapeAspectStyle { 
 
 
			get { return @ShapeAspectStyle; } 
			set { ShapeAspectStyle = value as IfcShapeAspect;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowLiningProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure? _liningDepth;
		private IfcPositiveLengthMeasure? _liningThickness;
		private IfcPositiveLengthMeasure? _transomThickness;
		private IfcPositiveLengthMeasure? _mullionThickness;
		private IfcNormalisedRatioMeasure? _firstTransomOffset;
		private IfcNormalisedRatioMeasure? _secondTransomOffset;
		private IfcNormalisedRatioMeasure? _firstMullionOffset;
		private IfcNormalisedRatioMeasure? _secondMullionOffset;
		private IfcShapeAspect _shapeAspectStyle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure? @LiningDepth 
		{ 
			get 
			{
				if(_activated) return _liningDepth;
				Activate();
				return _liningDepth;
			} 
			set
			{
				SetValue( v =>  _liningDepth = v, _liningDepth, value,  "LiningDepth", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcPositiveLengthMeasure? @LiningThickness 
		{ 
			get 
			{
				if(_activated) return _liningThickness;
				Activate();
				return _liningThickness;
			} 
			set
			{
				SetValue( v =>  _liningThickness = v, _liningThickness, value,  "LiningThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcPositiveLengthMeasure? @TransomThickness 
		{ 
			get 
			{
				if(_activated) return _transomThickness;
				Activate();
				return _transomThickness;
			} 
			set
			{
				SetValue( v =>  _transomThickness = v, _transomThickness, value,  "TransomThickness", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcPositiveLengthMeasure? @MullionThickness 
		{ 
			get 
			{
				if(_activated) return _mullionThickness;
				Activate();
				return _mullionThickness;
			} 
			set
			{
				SetValue( v =>  _mullionThickness = v, _mullionThickness, value,  "MullionThickness", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcNormalisedRatioMeasure? @FirstTransomOffset 
		{ 
			get 
			{
				if(_activated) return _firstTransomOffset;
				Activate();
				return _firstTransomOffset;
			} 
			set
			{
				SetValue( v =>  _firstTransomOffset = v, _firstTransomOffset, value,  "FirstTransomOffset", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcNormalisedRatioMeasure? @SecondTransomOffset 
		{ 
			get 
			{
				if(_activated) return _secondTransomOffset;
				Activate();
				return _secondTransomOffset;
			} 
			set
			{
				SetValue( v =>  _secondTransomOffset = v, _secondTransomOffset, value,  "SecondTransomOffset", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcNormalisedRatioMeasure? @FirstMullionOffset 
		{ 
			get 
			{
				if(_activated) return _firstMullionOffset;
				Activate();
				return _firstMullionOffset;
			} 
			set
			{
				SetValue( v =>  _firstMullionOffset = v, _firstMullionOffset, value,  "FirstMullionOffset", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcNormalisedRatioMeasure? @SecondMullionOffset 
		{ 
			get 
			{
				if(_activated) return _secondMullionOffset;
				Activate();
				return _secondMullionOffset;
			} 
			set
			{
				SetValue( v =>  _secondMullionOffset = v, _secondMullionOffset, value,  "SecondMullionOffset", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 16)]
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
				SetValue( v =>  _shapeAspectStyle = v, _shapeAspectStyle, value,  "ShapeAspectStyle", 13);
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
					_liningDepth = value.RealVal;
					return;
				case 5: 
					_liningThickness = value.RealVal;
					return;
				case 6: 
					_transomThickness = value.RealVal;
					return;
				case 7: 
					_mullionThickness = value.RealVal;
					return;
				case 8: 
					_firstTransomOffset = value.RealVal;
					return;
				case 9: 
					_secondTransomOffset = value.RealVal;
					return;
				case 10: 
					_firstMullionOffset = value.RealVal;
					return;
				case 11: 
					_secondMullionOffset = value.RealVal;
					return;
				case 12: 
					_shapeAspectStyle = (IfcShapeAspect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowLiningProperties other)
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