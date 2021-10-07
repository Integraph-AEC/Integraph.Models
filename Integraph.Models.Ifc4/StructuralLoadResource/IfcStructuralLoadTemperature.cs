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
using Integraph.Models.Ifc4.StructuralLoadResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadTemperature
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadTemperature : IIfcStructuralLoadStatic
	{
		IfcThermodynamicTemperatureMeasure? @DeltaTConstant { get;  set; }
		IfcThermodynamicTemperatureMeasure? @DeltaTY { get;  set; }
		IfcThermodynamicTemperatureMeasure? @DeltaTZ { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.StructuralLoadResource
{
	[ExpressType("IfcStructuralLoadTemperature", 36)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadTemperature : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadTemperature, IEquatable<@IfcStructuralLoadTemperature>
	{
		#region IIfcStructuralLoadTemperature explicit implementation
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTConstant { 
 
			get { return @DeltaTConstant; } 
			set { DeltaTConstant = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTY { 
 
			get { return @DeltaTY; } 
			set { DeltaTY = value;}
		}	
		IfcThermodynamicTemperatureMeasure? IIfcStructuralLoadTemperature.DeltaTZ { 
 
			get { return @DeltaTZ; } 
			set { DeltaTZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadTemperature(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcThermodynamicTemperatureMeasure? _deltaTConstant;
		private IfcThermodynamicTemperatureMeasure? _deltaTY;
		private IfcThermodynamicTemperatureMeasure? _deltaTZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTConstant 
		{ 
			get 
			{
				if(_activated) return _deltaTConstant;
				Activate();
				return _deltaTConstant;
			} 
			set
			{
				SetValue( v =>  _deltaTConstant = v, _deltaTConstant, value,  "DeltaTConstant", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTY 
		{ 
			get 
			{
				if(_activated) return _deltaTY;
				Activate();
				return _deltaTY;
			} 
			set
			{
				SetValue( v =>  _deltaTY = v, _deltaTY, value,  "DeltaTY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcThermodynamicTemperatureMeasure? @DeltaTZ 
		{ 
			get 
			{
				if(_activated) return _deltaTZ;
				Activate();
				return _deltaTZ;
			} 
			set
			{
				SetValue( v =>  _deltaTZ = v, _deltaTZ, value,  "DeltaTZ", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_deltaTConstant = value.RealVal;
					return;
				case 2: 
					_deltaTY = value.RealVal;
					return;
				case 3: 
					_deltaTZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadTemperature other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}