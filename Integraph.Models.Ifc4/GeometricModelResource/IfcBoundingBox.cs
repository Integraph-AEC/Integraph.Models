// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.GeometryResource;
using Integraph.Models.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcBoundingBox
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcBoundingBox : IIfcGeometricRepresentationItem
	{
		IIfcCartesianPoint @Corner { get;  set; }
		IfcPositiveLengthMeasure @XDim { get;  set; }
		IfcPositiveLengthMeasure @YDim { get;  set; }
		IfcPositiveLengthMeasure @ZDim { get;  set; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricModelResource
{
	[ExpressType("IfcBoundingBox", 151)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcBoundingBox : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcBoundingBox, IContainsEntityReferences, IEquatable<@IfcBoundingBox>
	{
		#region IIfcBoundingBox explicit implementation
		IIfcCartesianPoint IIfcBoundingBox.Corner { 
 
 
			get { return @Corner; } 
			set { Corner = value as IfcCartesianPoint;}
		}	
		IfcPositiveLengthMeasure IIfcBoundingBox.XDim { 
 
			get { return @XDim; } 
			set { XDim = value;}
		}	
		IfcPositiveLengthMeasure IIfcBoundingBox.YDim { 
 
			get { return @YDim; } 
			set { YDim = value;}
		}	
		IfcPositiveLengthMeasure IIfcBoundingBox.ZDim { 
 
			get { return @ZDim; } 
			set { ZDim = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcBoundingBox(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _corner;
		private IfcPositiveLengthMeasure _xDim;
		private IfcPositiveLengthMeasure _yDim;
		private IfcPositiveLengthMeasure _zDim;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCartesianPoint @Corner 
		{ 
			get 
			{
				if(_activated) return _corner;
				Activate();
				return _corner;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _corner = v, _corner, value,  "Corner", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @XDim 
		{ 
			get 
			{
				if(_activated) return _xDim;
				Activate();
				return _xDim;
			} 
			set
			{
				SetValue( v =>  _xDim = v, _xDim, value,  "XDim", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
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
				SetValue( v =>  _yDim = v, _yDim, value,  "YDim", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure @ZDim 
		{ 
			get 
			{
				if(_activated) return _zDim;
				Activate();
				return _zDim;
			} 
			set
			{
				SetValue( v =>  _zDim = v, _zDim, value,  "ZDim", 4);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
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
					_corner = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 1: 
					_xDim = value.RealVal;
					return;
				case 2: 
					_yDim = value.RealVal;
					return;
				case 3: 
					_zDim = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcBoundingBox other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Corner != null)
					yield return @Corner;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}