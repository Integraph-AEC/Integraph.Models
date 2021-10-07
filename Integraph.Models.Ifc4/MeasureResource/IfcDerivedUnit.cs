// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.MeasureResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDerivedUnit
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDerivedUnit : IPersistEntity, IfcUnit
	{
		IItemSet<IIfcDerivedUnitElement> @Elements { get; }
		IfcDerivedUnitEnum @UnitType { get;  set; }
		IfcLabel? @UserDefinedType { get;  set; }
		Common.Geometry.XbimDimensionalExponents @Dimensions  { get ; }
	
	}
}

namespace Integraph.Models.Ifc4.MeasureResource
{
	[ExpressType("IfcDerivedUnit", 630)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDerivedUnit : PersistEntity, IInstantiableEntity, IIfcDerivedUnit, IContainsEntityReferences, IEquatable<@IfcDerivedUnit>
	{
		#region IIfcDerivedUnit explicit implementation
		IItemSet<IIfcDerivedUnitElement> IIfcDerivedUnit.Elements { 
			get { return new Common.Collections.ProxyItemSet<IfcDerivedUnitElement, IIfcDerivedUnitElement>( @Elements); } 
		}	
		IfcDerivedUnitEnum IIfcDerivedUnit.UnitType { 
 
			get { return @UnitType; } 
			set { UnitType = value;}
		}	
		IfcLabel? IIfcDerivedUnit.UserDefinedType { 
 
			get { return @UserDefinedType; } 
			set { UserDefinedType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDerivedUnit(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_elements = new ItemSet<IfcDerivedUnitElement>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcDerivedUnitElement> _elements;
		private IfcDerivedUnitEnum _unitType;
		private IfcLabel? _userDefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 1)]
		public IItemSet<IfcDerivedUnitElement> @Elements 
		{ 
			get 
			{
				if(_activated) return _elements;
				Activate();
				return _elements;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 2)]
		public IfcDerivedUnitEnum @UnitType 
		{ 
			get 
			{
				if(_activated) return _unitType;
				Activate();
				return _unitType;
			} 
			set
			{
				SetValue( v =>  _unitType = v, _unitType, value,  "UnitType", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @UserDefinedType 
		{ 
			get 
			{
				if(_activated) return _userDefinedType;
				Activate();
				return _userDefinedType;
			} 
			set
			{
				SetValue( v =>  _userDefinedType = v, _userDefinedType, value,  "UserDefinedType", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public Common.Geometry.XbimDimensionalExponents @Dimensions 
		{
			get 
			{
				//## Getter for Dimensions
                var derivedUnit = this as IfcDerivedUnit;
                if (derivedUnit == null)
                    throw new NotSupportedException();
                var elements = derivedUnit.Elements as IList<IfcDerivedUnitElement> ?? derivedUnit.Elements.ToList();
                if (!elements.Any())
                    throw new ArgumentNullException();

                #region Strict Implementation
                var result = new Common.Geometry.XbimDimensionalExponents(0, 0, 0, 0, 0, 0, 0);
                foreach (var unitElement in elements)
                {
                    var unitDimensions = unitElement.Unit.Dimensions;
                    if (unitDimensions == null && unitElement.Unit is IfcConversionBasedUnit)
                    {
                        var cbu = unitElement.Unit as IfcConversionBasedUnit;
                        var nu = cbu.ConversionFactor.UnitComponent as IfcNamedUnit;
                        if (nu != null)
                            unitDimensions = nu.Dimensions;
                    }
                    if (unitDimensions == null)
                        continue;

                    result.LengthExponent = result.LengthExponent +
                          (unitElement.Exponent * unitDimensions.LengthExponent);
                    result.MassExponent = +result.MassExponent +
                          (unitElement.Exponent * unitDimensions.MassExponent);
                    result.TimeExponent = result.TimeExponent +
                          (unitElement.Exponent * unitDimensions.TimeExponent);
                    result.ElectricCurrentExponent = result.ElectricCurrentExponent +
                          (unitElement.Exponent * unitDimensions.ElectricCurrentExponent);
                    result.ThermodynamicTemperatureExponent = result.ThermodynamicTemperatureExponent +
                          (unitElement.Exponent * unitDimensions.ThermodynamicTemperatureExponent);
                    result.AmountOfSubstanceExponent = result.AmountOfSubstanceExponent +
                          (unitElement.Exponent * unitDimensions.AmountOfSubstanceExponent);
                    result.LuminousIntensityExponent = result.LuminousIntensityExponent +
                          (unitElement.Exponent * unitDimensions.LuminousIntensityExponent);
                }
                return result;
                #endregion Strict Implementation
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_elements.InternalAdd((IfcDerivedUnitElement)value.EntityVal);
					return;
				case 1: 
                    _unitType = (IfcDerivedUnitEnum) System.Enum.Parse(typeof (IfcDerivedUnitEnum), value.EnumVal, true);
					return;
				case 2: 
					_userDefinedType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDerivedUnit other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Elements)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}