// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProfileResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTrapeziumProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTrapeziumProfileDef : IIfcParameterizedProfileDef
	{
		IfcPositiveLengthMeasure @BottomXDim { get;  set; }
		IfcPositiveLengthMeasure @TopXDim { get;  set; }
		IfcPositiveLengthMeasure @YDim { get;  set; }
		IfcLengthMeasure @TopXOffset { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProfileResource
{
	[ExpressType("IfcTrapeziumProfileDef", 561)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTrapeziumProfileDef : IfcParameterizedProfileDef, IInstantiableEntity, IIfcTrapeziumProfileDef, IContainsEntityReferences, IEquatable<@IfcTrapeziumProfileDef>
	{
		#region IIfcTrapeziumProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.BottomXDim { 
 
			get { return @BottomXDim; } 
			set { BottomXDim = value;}
		}	
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.TopXDim { 
 
			get { return @TopXDim; } 
			set { TopXDim = value;}
		}	
		IfcPositiveLengthMeasure IIfcTrapeziumProfileDef.YDim { 
 
			get { return @YDim; } 
			set { YDim = value;}
		}	
		IfcLengthMeasure IIfcTrapeziumProfileDef.TopXOffset { 
 
			get { return @TopXOffset; } 
			set { TopXOffset = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTrapeziumProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _bottomXDim;
		private IfcPositiveLengthMeasure _topXDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcLengthMeasure _topXOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @BottomXDim 
		{ 
			get 
			{
				if(_activated) return _bottomXDim;
				Activate();
				return _bottomXDim;
			} 
			set
			{
				SetValue( v =>  _bottomXDim = v, _bottomXDim, value,  "BottomXDim", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure @TopXDim 
		{ 
			get 
			{
				if(_activated) return _topXDim;
				Activate();
				return _topXDim;
			} 
			set
			{
				SetValue( v =>  _topXDim = v, _topXDim, value,  "TopXDim", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @YDim 
		{ 
			get 
			{
				if(_activated) return _yDim;
				Activate();
				return _yDim;
			} 
			set
			{
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLengthMeasure @TopXOffset 
		{ 
			get 
			{
				if(_activated) return _topXOffset;
				Activate();
				return _topXOffset;
			} 
			set
			{
				SetValue( v =>  _topXOffset = v, _topXOffset, value,  "TopXOffset", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_bottomXDim = value.RealVal;
					return;
				case 4: 
					_topXDim = value.RealVal;
					return;
				case 5: 
					_yDim = value.RealVal;
					return;
				case 6: 
					_topXOffset = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTrapeziumProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}