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
using Integraph.Models.Ifc4.TopologyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPolyLoop
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPolyLoop : IIfcLoop
	{
		IItemSet<IIfcCartesianPoint> @Polygon { get; }
	
	}
}

namespace Integraph.Models.Ifc4.TopologyResource
{
	[ExpressType("IfcPolyLoop", 200)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPolyLoop : IfcLoop, IInstantiableEntity, IIfcPolyLoop, IContainsEntityReferences, IEquatable<@IfcPolyLoop>
	{
		#region IIfcPolyLoop explicit implementation
		IItemSet<IIfcCartesianPoint> IIfcPolyLoop.Polygon { 
			get { return new Common.Collections.ProxyItemSet<IfcCartesianPoint, IIfcCartesianPoint>( @Polygon); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPolyLoop(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_polygon = new ItemSet<IfcCartesianPoint>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcCartesianPoint> _polygon;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 3 }, new int [] { -1 }, 3)]
		public IItemSet<IfcCartesianPoint> @Polygon 
		{ 
			get 
			{
				if(_activated) return _polygon;
				Activate();
				return _polygon;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_polygon.InternalAdd((IfcCartesianPoint)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPolyLoop other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Polygon)
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