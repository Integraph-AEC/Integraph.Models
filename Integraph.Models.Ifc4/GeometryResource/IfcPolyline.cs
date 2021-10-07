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
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPolyline
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPolyline : IIfcBoundedCurve
	{
		IItemSet<IIfcCartesianPoint> @Points { get; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometryResource
{
	[ExpressType("IfcPolyline", 500)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyline : IfcBoundedCurve, IInstantiableEntity, IIfcPolyline, IContainsEntityReferences, IEquatable<@IfcPolyline>
	{
		#region IIfcPolyline explicit implementation
		IItemSet<IIfcCartesianPoint> IIfcPolyline.Points { 
			get { return new Common.Collections.ProxyItemSet<IfcCartesianPoint, IIfcCartesianPoint>( @Points); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyline(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_points = new ItemSet<IfcCartesianPoint>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcCartesianPoint> _points;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { -1 }, 3)]
		public IItemSet<IfcCartesianPoint> @Points 
		{ 
			get 
			{
				if(_activated) return _points;
				Activate();
				return _points;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_points.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolyline other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Points)
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