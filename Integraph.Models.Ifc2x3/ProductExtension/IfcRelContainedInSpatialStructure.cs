// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelContainedInSpatialStructure
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelContainedInSpatialStructure : IIfcRelConnects
	{
		IItemSet<IIfcProduct> @RelatedElements { get; }
		IIfcSpatialStructureElement @RelatingStructure { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProductExtension
{
	[ExpressType("IfcRelContainedInSpatialStructure", 559)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelContainedInSpatialStructure : IfcRelConnects, IInstantiableEntity, IIfcRelContainedInSpatialStructure, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelContainedInSpatialStructure>
	{
		#region IIfcRelContainedInSpatialStructure explicit implementation
		IItemSet<IIfcProduct> IIfcRelContainedInSpatialStructure.RelatedElements { 
			get { return new Common.Collections.ProxyItemSet<IfcProduct, IIfcProduct>( @RelatedElements); } 
		}	
		IIfcSpatialStructureElement IIfcRelContainedInSpatialStructure.RelatingStructure { 
 
 
			get { return @RelatingStructure; } 
			set { RelatingStructure = value as IfcSpatialStructureElement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelContainedInSpatialStructure(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedElements = new ItemSet<IfcProduct>( this, 0,  5);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcProduct> _relatedElements;
		private IfcSpatialStructureElement _relatingStructure;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<IfcProduct> @RelatedElements 
		{ 
			get 
			{
				if(_activated) return _relatedElements;
				Activate();
				return _relatedElements;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcSpatialStructureElement @RelatingStructure 
		{ 
			get 
			{
				if(_activated) return _relatingStructure;
				Activate();
				return _relatingStructure;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingStructure = v, _relatingStructure, value,  "RelatingStructure", 6);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatedElements.InternalAdd((IfcProduct)value.EntityVal);
					return;
				case 5: 
					_relatingStructure = (IfcSpatialStructureElement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelContainedInSpatialStructure other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedElements)
					yield return entity;
				if (@RelatingStructure != null)
					yield return @RelatingStructure;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code

		//##
		#endregion
	}
}