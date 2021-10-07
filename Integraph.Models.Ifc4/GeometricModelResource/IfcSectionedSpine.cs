// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.GeometryResource;
using Integraph.Models.Ifc4.ProfileResource;
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
    /// Readonly interface for IfcSectionedSpine
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSectionedSpine : IIfcGeometricRepresentationItem
	{
		IIfcCompositeCurve @SpineCurve { get;  set; }
		IItemSet<IIfcProfileDef> @CrossSections { get; }
		IItemSet<IIfcAxis2Placement3D> @CrossSectionPositions { get; }
		IfcDimensionCount @Dim  { get ; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSectionedSpine", 300)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionedSpine : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcSectionedSpine, IContainsEntityReferences, IEquatable<@IfcSectionedSpine>
	{
		#region IIfcSectionedSpine explicit implementation
		IIfcCompositeCurve IIfcSectionedSpine.SpineCurve { 
 
 
			get { return @SpineCurve; } 
			set { SpineCurve = value as IfcCompositeCurve;}
		}	
		IItemSet<IIfcProfileDef> IIfcSectionedSpine.CrossSections { 
			get { return new Common.Collections.ProxyItemSet<IfcProfileDef, IIfcProfileDef>( @CrossSections); } 
		}	
		IItemSet<IIfcAxis2Placement3D> IIfcSectionedSpine.CrossSectionPositions { 
			get { return new Common.Collections.ProxyItemSet<IfcAxis2Placement3D, IIfcAxis2Placement3D>( @CrossSectionPositions); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionedSpine(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_crossSections = new ItemSet<IfcProfileDef>( this, 0,  2);
			_crossSectionPositions = new ItemSet<IfcAxis2Placement3D>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcCompositeCurve _spineCurve;
		private readonly ItemSet<IfcProfileDef> _crossSections;
		private readonly ItemSet<IfcAxis2Placement3D> _crossSectionPositions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCompositeCurve @SpineCurve 
		{ 
			get 
			{
				if(_activated) return _spineCurve;
				Activate();
				return _spineCurve;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _spineCurve = v, _spineCurve, value,  "SpineCurve", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 4)]
		public IItemSet<IfcProfileDef> @CrossSections 
		{ 
			get 
			{
				if(_activated) return _crossSections;
				Activate();
				return _crossSections;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 5)]
		public IItemSet<IfcAxis2Placement3D> @CrossSectionPositions 
		{ 
			get 
			{
				if(_activated) return _crossSectionPositions;
				Activate();
				return _crossSectionPositions;
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
					_spineCurve = (IfcCompositeCurve)(value.EntityVal);
					return;
				case 1: 
					_crossSections.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 2: 
					_crossSectionPositions.InternalAdd((IfcAxis2Placement3D)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionedSpine other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SpineCurve != null)
					yield return @SpineCurve;
				foreach(var entity in @CrossSections)
					yield return entity;
				foreach(var entity in @CrossSectionPositions)
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