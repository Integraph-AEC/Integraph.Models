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
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometricConstraintResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcVirtualGridIntersection
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcVirtualGridIntersection : IPersistEntity, IfcGridPlacementDirectionSelect
	{
		IItemSet<IIfcGridAxis> @IntersectingAxes { get; }
		IItemSet<IfcLengthMeasure> @OffsetDistances { get; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcVirtualGridIntersection", 589)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcVirtualGridIntersection : PersistEntity, IInstantiableEntity, IIfcVirtualGridIntersection, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcVirtualGridIntersection>
	{
		#region IIfcVirtualGridIntersection explicit implementation
		IItemSet<IIfcGridAxis> IIfcVirtualGridIntersection.IntersectingAxes { 
			get { return new Common.Collections.ProxyItemSet<IfcGridAxis, IIfcGridAxis>( @IntersectingAxes); } 
		}	
		IItemSet<IfcLengthMeasure> IIfcVirtualGridIntersection.OffsetDistances { 
			get { return @OffsetDistances; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcVirtualGridIntersection(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_intersectingAxes = new ItemSet<IfcGridAxis>( this, 2,  1);
			_offsetDistances = new ItemSet<IfcLengthMeasure>( this, 3,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcGridAxis> _intersectingAxes;
		private readonly ItemSet<IfcLengthMeasure> _offsetDistances;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 2 }, new int [] { 2 }, 1)]
		public IItemSet<IfcGridAxis> @IntersectingAxes 
		{ 
			get 
			{
				if(_activated) return _intersectingAxes;
				Activate();
				return _intersectingAxes;
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { 3 }, 2)]
		public IItemSet<IfcLengthMeasure> @OffsetDistances 
		{ 
			get 
			{
				if(_activated) return _offsetDistances;
				Activate();
				return _offsetDistances;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_intersectingAxes.InternalAdd((IfcGridAxis)value.EntityVal);
					return;
				case 1: 
					_offsetDistances.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcVirtualGridIntersection other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @IntersectingAxes)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @IntersectingAxes)
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