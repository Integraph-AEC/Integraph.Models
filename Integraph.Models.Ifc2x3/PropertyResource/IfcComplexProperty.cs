// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.PropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcComplexProperty
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcComplexProperty : IIfcProperty
	{
		IfcIdentifier @UsageName { get;  set; }
		IItemSet<IIfcProperty> @HasProperties { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PropertyResource
{
	[ExpressType("IfcComplexProperty", 379)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcComplexProperty : IfcProperty, IInstantiableEntity, IIfcComplexProperty, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcComplexProperty>
	{
		#region IIfcComplexProperty explicit implementation
		IfcIdentifier IIfcComplexProperty.UsageName { 
 
			get { return @UsageName; } 
			set { UsageName = value;}
		}	
		IItemSet<IIfcProperty> IIfcComplexProperty.HasProperties { 
			get { return new Common.Collections.ProxyItemSet<IfcProperty, IIfcProperty>( @HasProperties); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcComplexProperty(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_hasProperties = new ItemSet<IfcProperty>( this, 0,  4);
		}

		#region Explicit attribute fields
		private IfcIdentifier _usageName;
		private readonly ItemSet<IfcProperty> _hasProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcIdentifier @UsageName 
		{ 
			get 
			{
				if(_activated) return _usageName;
				Activate();
				return _usageName;
			} 
			set
			{
				SetValue( v =>  _usageName = v, _usageName, value,  "UsageName", 3);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<IfcProperty> @HasProperties 
		{ 
			get 
			{
				if(_activated) return _hasProperties;
				Activate();
				return _hasProperties;
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
					_usageName = value.StringVal;
					return;
				case 3: 
					_hasProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcComplexProperty other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @HasProperties)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasProperties)
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