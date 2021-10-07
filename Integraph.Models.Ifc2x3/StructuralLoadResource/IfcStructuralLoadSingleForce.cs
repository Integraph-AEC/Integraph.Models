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
using Integraph.Models.Ifc2x3.StructuralLoadResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcStructuralLoadSingleForce
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcStructuralLoadSingleForce : IIfcStructuralLoadStatic
	{
		IfcForceMeasure? @ForceX { get;  set; }
		IfcForceMeasure? @ForceY { get;  set; }
		IfcForceMeasure? @ForceZ { get;  set; }
		IfcTorqueMeasure? @MomentX { get;  set; }
		IfcTorqueMeasure? @MomentY { get;  set; }
		IfcTorqueMeasure? @MomentZ { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.StructuralLoadResource
{
	[ExpressType("IfcStructuralLoadSingleForce", 119)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralLoadSingleForce : IfcStructuralLoadStatic, IInstantiableEntity, IIfcStructuralLoadSingleForce, IEquatable<@IfcStructuralLoadSingleForce>
	{
		#region IIfcStructuralLoadSingleForce explicit implementation
		IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceX { 
 
			get { return @ForceX; } 
			set { ForceX = value;}
		}	
		IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceY { 
 
			get { return @ForceY; } 
			set { ForceY = value;}
		}	
		IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceZ { 
 
			get { return @ForceZ; } 
			set { ForceZ = value;}
		}	
		IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentX { 
 
			get { return @MomentX; } 
			set { MomentX = value;}
		}	
		IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentY { 
 
			get { return @MomentY; } 
			set { MomentY = value;}
		}	
		IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentZ { 
 
			get { return @MomentZ; } 
			set { MomentZ = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralLoadSingleForce(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcForceMeasure? _forceX;
		private IfcForceMeasure? _forceY;
		private IfcForceMeasure? _forceZ;
		private IfcTorqueMeasure? _momentX;
		private IfcTorqueMeasure? _momentY;
		private IfcTorqueMeasure? _momentZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcForceMeasure? @ForceX 
		{ 
			get 
			{
				if(_activated) return _forceX;
				Activate();
				return _forceX;
			} 
			set
			{
				SetValue( v =>  _forceX = v, _forceX, value,  "ForceX", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcForceMeasure? @ForceY 
		{ 
			get 
			{
				if(_activated) return _forceY;
				Activate();
				return _forceY;
			} 
			set
			{
				SetValue( v =>  _forceY = v, _forceY, value,  "ForceY", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcForceMeasure? @ForceZ 
		{ 
			get 
			{
				if(_activated) return _forceZ;
				Activate();
				return _forceZ;
			} 
			set
			{
				SetValue( v =>  _forceZ = v, _forceZ, value,  "ForceZ", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcTorqueMeasure? @MomentX 
		{ 
			get 
			{
				if(_activated) return _momentX;
				Activate();
				return _momentX;
			} 
			set
			{
				SetValue( v =>  _momentX = v, _momentX, value,  "MomentX", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcTorqueMeasure? @MomentY 
		{ 
			get 
			{
				if(_activated) return _momentY;
				Activate();
				return _momentY;
			} 
			set
			{
				SetValue( v =>  _momentY = v, _momentY, value,  "MomentY", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcTorqueMeasure? @MomentZ 
		{ 
			get 
			{
				if(_activated) return _momentZ;
				Activate();
				return _momentZ;
			} 
			set
			{
				SetValue( v =>  _momentZ = v, _momentZ, value,  "MomentZ", 7);
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
					_forceX = value.RealVal;
					return;
				case 2: 
					_forceY = value.RealVal;
					return;
				case 3: 
					_forceZ = value.RealVal;
					return;
				case 4: 
					_momentX = value.RealVal;
					return;
				case 5: 
					_momentY = value.RealVal;
					return;
				case 6: 
					_momentZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralLoadSingleForce other)
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