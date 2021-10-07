// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveBoundedPlane
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveBoundedPlane : IIfcBoundedSurface
	{
		IIfcPlane @BasisSurface { get;  set; }
		IIfcCurve @OuterBoundary { get;  set; }
		IItemSet<IIfcCurve> @InnerBoundaries { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.GeometryResource
{
	[ExpressType("IfcCurveBoundedPlane", 334)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveBoundedPlane : IfcBoundedSurface, IInstantiableEntity, IIfcCurveBoundedPlane, IContainsEntityReferences, IEquatable<@IfcCurveBoundedPlane>
	{
		#region IIfcCurveBoundedPlane explicit implementation
		IIfcPlane IIfcCurveBoundedPlane.BasisSurface { 
 
 
			get { return @BasisSurface; } 
			set { BasisSurface = value as IfcPlane;}
		}	
		IIfcCurve IIfcCurveBoundedPlane.OuterBoundary { 
 
 
			get { return @OuterBoundary; } 
			set { OuterBoundary = value as IfcCurve;}
		}	
		IItemSet<IIfcCurve> IIfcCurveBoundedPlane.InnerBoundaries { 
			get { return new Common.Collections.ProxyItemSet<IfcCurve, IIfcCurve>( @InnerBoundaries); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveBoundedPlane(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_innerBoundaries = new ItemSet<IfcCurve>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcPlane _basisSurface;
		private IfcCurve _outerBoundary;
		private readonly ItemSet<IfcCurve> _innerBoundaries;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcPlane @BasisSurface 
		{ 
			get 
			{
				if(_activated) return _basisSurface;
				Activate();
				return _basisSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _basisSurface = v, _basisSurface, value,  "BasisSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCurve @OuterBoundary 
		{ 
			get 
			{
				if(_activated) return _outerBoundary;
				Activate();
				return _outerBoundary;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _outerBoundary = v, _outerBoundary, value,  "OuterBoundary", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 5)]
		public IItemSet<IfcCurve> @InnerBoundaries 
		{ 
			get 
			{
				if(_activated) return _innerBoundaries;
				Activate();
				return _innerBoundaries;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return BasisSurface.Dim;
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
					_basisSurface = (IfcPlane)(value.EntityVal);
					return;
				case 1: 
					_outerBoundary = (IfcCurve)(value.EntityVal);
					return;
				case 2: 
					_innerBoundaries.InternalAdd((IfcCurve)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveBoundedPlane other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BasisSurface != null)
					yield return @BasisSurface;
				if (@OuterBoundary != null)
					yield return @OuterBoundary;
				foreach(var entity in @InnerBoundaries)
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