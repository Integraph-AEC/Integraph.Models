// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.ConstraintResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.CostResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCostValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCostValue : IIfcAppliedValue, IfcMetricValueSelect
	{
		IfcLabel @CostType { get;  set; }
		IfcText? @Condition { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.CostResource
{
	[ExpressType("IfcCostValue", 658)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCostValue : IfcAppliedValue, IInstantiableEntity, IIfcCostValue, IContainsEntityReferences, IEquatable<@IfcCostValue>
	{
		#region IIfcCostValue explicit implementation
		IfcLabel IIfcCostValue.CostType { 
 
			get { return @CostType; } 
			set { CostType = value;}
		}	
		IfcText? IIfcCostValue.Condition { 
 
			get { return @Condition; } 
			set { Condition = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCostValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _costType;
		private IfcText? _condition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcLabel @CostType 
		{ 
			get 
			{
				if(_activated) return _costType;
				Activate();
				return _costType;
			} 
			set
			{
				SetValue( v =>  _costType = v, _costType, value,  "CostType", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcText? @Condition 
		{ 
			get 
			{
				if(_activated) return _condition;
				Activate();
				return _condition;
			} 
			set
			{
				SetValue( v =>  _condition = v, _condition, value,  "Condition", 8);
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
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_costType = value.StringVal;
					return;
				case 7: 
					_condition = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCostValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@UnitBasis != null)
					yield return @UnitBasis;
				if (@ApplicableDate != null)
					yield return @ApplicableDate;
				if (@FixedUntilDate != null)
					yield return @FixedUntilDate;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}