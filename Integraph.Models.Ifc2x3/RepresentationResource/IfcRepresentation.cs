// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.PresentationOrganizationResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.RepresentationResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRepresentation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRepresentation : IPersistEntity, IfcLayeredItem
	{
		IIfcRepresentationContext @ContextOfItems { get;  set; }
		IfcLabel? @RepresentationIdentifier { get;  set; }
		IfcLabel? @RepresentationType { get;  set; }
		IItemSet<IIfcRepresentationItem> @Items { get; }
		IEnumerable<IIfcRepresentationMap> @RepresentationMap {  get; }
		IEnumerable<IIfcPresentationLayerAssignment> @LayerAssignments {  get; }
		IEnumerable<IIfcProductRepresentation> @OfProductRepresentation {  get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcRepresentation", 87)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRepresentation : PersistEntity, IInstantiableEntity, IIfcRepresentation, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRepresentation>
	{
		#region IIfcRepresentation explicit implementation
		IIfcRepresentationContext IIfcRepresentation.ContextOfItems { 
 
 
			get { return @ContextOfItems; } 
			set { ContextOfItems = value as IfcRepresentationContext;}
		}	
		IfcLabel? IIfcRepresentation.RepresentationIdentifier { 
 
			get { return @RepresentationIdentifier; } 
			set { RepresentationIdentifier = value;}
		}	
		IfcLabel? IIfcRepresentation.RepresentationType { 
 
			get { return @RepresentationType; } 
			set { RepresentationType = value;}
		}	
		IItemSet<IIfcRepresentationItem> IIfcRepresentation.Items { 
			get { return new Common.Collections.ProxyItemSet<IfcRepresentationItem, IIfcRepresentationItem>( @Items); } 
		}	
		 
		IEnumerable<IIfcRepresentationMap> IIfcRepresentation.RepresentationMap {  get { return @RepresentationMap; } }
		IEnumerable<IIfcPresentationLayerAssignment> IIfcRepresentation.LayerAssignments {  get { return @LayerAssignments; } }
		IEnumerable<IIfcProductRepresentation> IIfcRepresentation.OfProductRepresentation {  get { return @OfProductRepresentation; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRepresentation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_items = new ItemSet<IfcRepresentationItem>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcRepresentationContext _contextOfItems;
		private IfcLabel? _representationIdentifier;
		private IfcLabel? _representationType;
		private readonly ItemSet<IfcRepresentationItem> _items;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcRepresentationContext @ContextOfItems 
		{ 
			get 
			{
				if(_activated) return _contextOfItems;
				Activate();
				return _contextOfItems;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _contextOfItems = v, _contextOfItems, value,  "ContextOfItems", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel? @RepresentationIdentifier 
		{ 
			get 
			{
				if(_activated) return _representationIdentifier;
				Activate();
				return _representationIdentifier;
			} 
			set
			{
				SetValue( v =>  _representationIdentifier = v, _representationIdentifier, value,  "RepresentationIdentifier", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLabel? @RepresentationType 
		{ 
			get 
			{
				if(_activated) return _representationType;
				Activate();
				return _representationType;
			} 
			set
			{
				SetValue( v =>  _representationType = v, _representationType, value,  "RepresentationType", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IItemSet<IfcRepresentationItem> @Items 
		{ 
			get 
			{
				if(_activated) return _items;
				Activate();
				return _items;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("MappedRepresentation")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 5)]
		public IEnumerable<IfcRepresentationMap> @RepresentationMap 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRepresentationMap>(e => Equals(e.MappedRepresentation), "MappedRepresentation", this);
			} 
		}
		[InverseProperty("AssignedItems")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 6)]
		public IEnumerable<IfcPresentationLayerAssignment> @LayerAssignments 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPresentationLayerAssignment>(e => e.AssignedItems != null &&  e.AssignedItems.Contains(this), "AssignedItems", this);
			} 
		}
		[InverseProperty("Representations")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 7)]
		public IEnumerable<IfcProductRepresentation> @OfProductRepresentation 
		{ 
			get 
			{
				return Model.Instances.Where<IfcProductRepresentation>(e => e.Representations != null &&  e.Representations.Contains(this), "Representations", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_contextOfItems = (IfcRepresentationContext)(value.EntityVal);
					return;
				case 1: 
					_representationIdentifier = value.StringVal;
					return;
				case 2: 
					_representationType = value.StringVal;
					return;
				case 3: 
					_items.InternalAdd((IfcRepresentationItem)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRepresentation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ContextOfItems != null)
					yield return @ContextOfItems;
				foreach(var entity in @Items)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ContextOfItems != null)
					yield return @ContextOfItems;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}