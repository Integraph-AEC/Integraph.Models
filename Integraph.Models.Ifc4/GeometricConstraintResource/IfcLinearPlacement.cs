// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLinearPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLinearPlacement : IIfcObjectPlacement
	{
		IIfcCurve @PlacementRelTo { get;  set; }
		IIfcDistanceExpression @Distance { get;  set; }
		IIfcOrientationExpression @Orientation { get;  set; }
		IIfcAxis2Placement3D @CartesianPosition { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcLinearPlacement", 1349)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLinearPlacement : IfcObjectPlacement, IInstantiableEntity, IIfcLinearPlacement, IContainsEntityReferences, IEquatable<@IfcLinearPlacement>
	{
		#region IIfcLinearPlacement explicit implementation
		IIfcCurve IIfcLinearPlacement.PlacementRelTo { 
 
 
			get { return @PlacementRelTo; } 
			set { PlacementRelTo = value as IfcCurve;}
		}	
		IIfcDistanceExpression IIfcLinearPlacement.Distance { 
 
 
			get { return @Distance; } 
			set { Distance = value as IfcDistanceExpression;}
		}	
		IIfcOrientationExpression IIfcLinearPlacement.Orientation { 
 
 
			get { return @Orientation; } 
			set { Orientation = value as IfcOrientationExpression;}
		}	
		IIfcAxis2Placement3D IIfcLinearPlacement.CartesianPosition { 
 
 
			get { return @CartesianPosition; } 
			set { CartesianPosition = value as IfcAxis2Placement3D;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLinearPlacement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurve _placementRelTo;
		private IfcDistanceExpression _distance;
		private IfcOrientationExpression _orientation;
		private IfcAxis2Placement3D _cartesianPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCurve @PlacementRelTo 
		{ 
			get 
			{
				if(_activated) return _placementRelTo;
				Activate();
				return _placementRelTo;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _placementRelTo = v, _placementRelTo, value,  "PlacementRelTo", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDistanceExpression @Distance 
		{ 
			get 
			{
				if(_activated) return _distance;
				Activate();
				return _distance;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _distance = v, _distance, value,  "Distance", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcOrientationExpression @Orientation 
		{ 
			get 
			{
				if(_activated) return _orientation;
				Activate();
				return _orientation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcAxis2Placement3D @CartesianPosition 
		{ 
			get 
			{
				if(_activated) return _cartesianPosition;
				Activate();
				return _cartesianPosition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _cartesianPosition = v, _cartesianPosition, value,  "CartesianPosition", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_placementRelTo = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_distance = (IfcDistanceExpression)(value.EntityVal);
					return;
				case 2: 
					_orientation = (IfcOrientationExpression)(value.EntityVal);
					return;
				case 3: 
					_cartesianPosition = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLinearPlacement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@PlacementRelTo != null)
					yield return @PlacementRelTo;
				if (@Distance != null)
					yield return @Distance;
				if (@Orientation != null)
					yield return @Orientation;
				if (@CartesianPosition != null)
					yield return @CartesianPosition;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}