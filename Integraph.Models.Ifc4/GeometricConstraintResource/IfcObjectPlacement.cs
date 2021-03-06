// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Kernel;
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
    /// Readonly interface for IfcObjectPlacement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcObjectPlacement : IPersistEntity
	{
		IEnumerable<IIfcProduct> @PlacesObject {  get; }
		IEnumerable<IIfcLocalPlacement> @ReferencedByPlacements {  get; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricConstraintResource
{
	[ExpressType("IfcObjectPlacement", 440)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcObjectPlacement : PersistEntity, IIfcObjectPlacement, IEquatable<@IfcObjectPlacement>
	{
		#region IIfcObjectPlacement explicit implementation
		 
		IEnumerable<IIfcProduct> IIfcObjectPlacement.PlacesObject {  get { return @PlacesObject; } }
		IEnumerable<IIfcLocalPlacement> IIfcObjectPlacement.ReferencedByPlacements {  get { return @ReferencedByPlacements; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcObjectPlacement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("ObjectPlacement")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 1)]
		public IEnumerable<IfcProduct> @PlacesObject 
		{ 
			get 
			{
				return Model.Instances.Where<IfcProduct>(e => Equals(e.ObjectPlacement), "ObjectPlacement", this);
			} 
		}
		[InverseProperty("PlacementRelTo")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 2)]
		public IEnumerable<IfcLocalPlacement> @ReferencedByPlacements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcLocalPlacement>(e => Equals(e.PlacementRelTo), "PlacementRelTo", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcObjectPlacement other)
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