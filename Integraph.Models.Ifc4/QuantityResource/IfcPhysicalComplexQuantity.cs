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
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.QuantityResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPhysicalComplexQuantity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPhysicalComplexQuantity : IIfcPhysicalQuantity
	{
		IItemSet<IIfcPhysicalQuantity> @HasQuantities { get; }
		IfcLabel @Discrimination { get;  set; }
		IfcLabel? @Quality { get;  set; }
		IfcLabel? @Usage { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.QuantityResource
{
	[ExpressType("IfcPhysicalComplexQuantity", 604)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPhysicalComplexQuantity : IfcPhysicalQuantity, IInstantiableEntity, IIfcPhysicalComplexQuantity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcPhysicalComplexQuantity>
	{
		#region IIfcPhysicalComplexQuantity explicit implementation
		IItemSet<IIfcPhysicalQuantity> IIfcPhysicalComplexQuantity.HasQuantities { 
			get { return new Common.Collections.ProxyItemSet<IfcPhysicalQuantity, IIfcPhysicalQuantity>( @HasQuantities); } 
		}	
		IfcLabel IIfcPhysicalComplexQuantity.Discrimination { 
 
			get { return @Discrimination; } 
			set { Discrimination = value;}
		}	
		IfcLabel? IIfcPhysicalComplexQuantity.Quality { 
 
			get { return @Quality; } 
			set { Quality = value;}
		}	
		IfcLabel? IIfcPhysicalComplexQuantity.Usage { 
 
			get { return @Usage; } 
			set { Usage = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalComplexQuantity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_hasQuantities = new ItemSet<IfcPhysicalQuantity>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcPhysicalQuantity> _hasQuantities;
		private IfcLabel _discrimination;
		private IfcLabel? _quality;
		private IfcLabel? _usage;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IItemSet<IfcPhysicalQuantity> @HasQuantities 
		{ 
			get 
			{
				if(_activated) return _hasQuantities;
				Activate();
				return _hasQuantities;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcLabel @Discrimination 
		{ 
			get 
			{
				if(_activated) return _discrimination;
				Activate();
				return _discrimination;
			} 
			set
			{
				SetValue( v =>  _discrimination = v, _discrimination, value,  "Discrimination", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcLabel? @Quality 
		{ 
			get 
			{
				if(_activated) return _quality;
				Activate();
				return _quality;
			} 
			set
			{
				SetValue( v =>  _quality = v, _quality, value,  "Quality", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcLabel? @Usage 
		{ 
			get 
			{
				if(_activated) return _usage;
				Activate();
				return _usage;
			} 
			set
			{
				SetValue( v =>  _usage = v, _usage, value,  "Usage", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_hasQuantities.InternalAdd((IfcPhysicalQuantity)value.EntityVal);
					return;
				case 3: 
					_discrimination = value.StringVal;
					return;
				case 4: 
					_quality = value.StringVal;
					return;
				case 5: 
					_usage = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPhysicalComplexQuantity other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @HasQuantities)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasQuantities)
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