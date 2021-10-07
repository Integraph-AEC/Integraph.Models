// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyBoundedValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyBoundedValue : IIfcSimpleProperty
	{
		IIfcValue @UpperBoundValue { get;  set; }
		IIfcValue @LowerBoundValue { get;  set; }
		IIfcUnit @Unit { get;  set; }
		IIfcValue @SetPointValue { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.PropertyResource
{
	[ExpressType("IfcPropertyBoundedValue", 3)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyBoundedValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyBoundedValue, IContainsEntityReferences, IEquatable<@IfcPropertyBoundedValue>
	{
		#region IIfcPropertyBoundedValue explicit implementation
		IIfcValue IIfcPropertyBoundedValue.UpperBoundValue { 
 
 
			get { return @UpperBoundValue; } 
			set { UpperBoundValue = value as IfcValue;}
		}	
		IIfcValue IIfcPropertyBoundedValue.LowerBoundValue { 
 
 
			get { return @LowerBoundValue; } 
			set { LowerBoundValue = value as IfcValue;}
		}	
		IIfcUnit IIfcPropertyBoundedValue.Unit { 
 
 
			get { return @Unit; } 
			set { Unit = value as IfcUnit;}
		}	
		IIfcValue IIfcPropertyBoundedValue.SetPointValue { 
 
 
			get { return @SetPointValue; } 
			set { SetPointValue = value as IfcValue;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyBoundedValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcValue _upperBoundValue;
		private IfcValue _lowerBoundValue;
		private IfcUnit _unit;
		private IfcValue _setPointValue;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 10)]
		public IfcValue @UpperBoundValue 
		{ 
			get 
			{
				if(_activated) return _upperBoundValue;
				Activate();
				return _upperBoundValue;
			} 
			set
			{
				SetValue( v =>  _upperBoundValue = v, _upperBoundValue, value,  "UpperBoundValue", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public IfcValue @LowerBoundValue 
		{ 
			get 
			{
				if(_activated) return _lowerBoundValue;
				Activate();
				return _lowerBoundValue;
			} 
			set
			{
				SetValue( v =>  _lowerBoundValue = v, _lowerBoundValue, value,  "LowerBoundValue", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 13)]
		public IfcValue @SetPointValue 
		{ 
			get 
			{
				if(_activated) return _setPointValue;
				Activate();
				return _setPointValue;
			} 
			set
			{
				SetValue( v =>  _setPointValue = v, _setPointValue, value,  "SetPointValue", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_upperBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 3: 
					_lowerBoundValue = (IfcValue)(value.EntityVal);
					return;
				case 4: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				case 5: 
					_setPointValue = (IfcValue)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyBoundedValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}