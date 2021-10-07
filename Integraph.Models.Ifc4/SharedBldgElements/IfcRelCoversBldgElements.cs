// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Kernel;
using Integraph.Models.Ifc4.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.SharedBldgElements;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelCoversBldgElements
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelCoversBldgElements : IIfcRelConnects
	{
		IIfcElement @RelatingBuildingElement { get;  set; }
		IItemSet<IIfcCovering> @RelatedCoverings { get; }
	
	}
}

namespace Integraph.Models.Ifc4.SharedBldgElements
{
	[ExpressType("IfcRelCoversBldgElements", 24)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelCoversBldgElements : IfcRelConnects, IInstantiableEntity, IIfcRelCoversBldgElements, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelCoversBldgElements>
	{
		#region IIfcRelCoversBldgElements explicit implementation
		IIfcElement IIfcRelCoversBldgElements.RelatingBuildingElement { 
 
 
			get { return @RelatingBuildingElement; } 
			set { RelatingBuildingElement = value as IfcElement;}
		}	
		IItemSet<IIfcCovering> IIfcRelCoversBldgElements.RelatedCoverings { 
			get { return new Common.Collections.ProxyItemSet<IfcCovering, IIfcCovering>( @RelatedCoverings); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelCoversBldgElements(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedCoverings = new ItemSet<IfcCovering>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcElement _relatingBuildingElement;
		private readonly ItemSet<IfcCovering> _relatedCoverings;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcElement @RelatingBuildingElement 
		{ 
			get 
			{
				if(_activated) return _relatingBuildingElement;
				Activate();
				return _relatingBuildingElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingBuildingElement = v, _relatingBuildingElement, value,  "RelatingBuildingElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcCovering> @RelatedCoverings 
		{ 
			get 
			{
				if(_activated) return _relatedCoverings;
				Activate();
				return _relatedCoverings;
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
					_relatingBuildingElement = (IfcElement)(value.EntityVal);
					return;
				case 5: 
					_relatedCoverings.InternalAdd((IfcCovering)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelCoversBldgElements other)
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
				if (@RelatingBuildingElement != null)
					yield return @RelatingBuildingElement;
				foreach(var entity in @RelatedCoverings)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingBuildingElement != null)
					yield return @RelatingBuildingElement;
				foreach(var entity in @RelatedCoverings)
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