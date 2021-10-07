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
using Integraph.Models.Ifc4.QuantityResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcQuantityArea
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcQuantityArea : IIfcPhysicalSimpleQuantity
	{
		IfcAreaMeasure @AreaValue { get;  set; }
		IfcLabel? @Formula { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.QuantityResource
{
	[ExpressType("IfcQuantityArea", 495)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcQuantityArea : IfcPhysicalSimpleQuantity, IInstantiableEntity, IIfcQuantityArea, IContainsEntityReferences, IEquatable<@IfcQuantityArea>
	{
		#region IIfcQuantityArea explicit implementation
		IfcAreaMeasure IIfcQuantityArea.AreaValue { 
 
			get { return @AreaValue; } 
			set { AreaValue = value;}
		}	
		IfcLabel? IIfcQuantityArea.Formula { 
 
			get { return @Formula; } 
			set { Formula = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcQuantityArea(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAreaMeasure _areaValue;
		private IfcLabel? _formula;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcAreaMeasure @AreaValue 
		{ 
			get 
			{
				if(_activated) return _areaValue;
				Activate();
				return _areaValue;
			} 
			set
			{
				SetValue( v =>  _areaValue = v, _areaValue, value,  "AreaValue", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @Formula 
		{ 
			get 
			{
				if(_activated) return _formula;
				Activate();
				return _formula;
			} 
			set
			{
				SetValue( v =>  _formula = v, _formula, value,  "Formula", 5);
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
					_areaValue = value.RealVal;
					return;
				case 4: 
					_formula = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcQuantityArea other)
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