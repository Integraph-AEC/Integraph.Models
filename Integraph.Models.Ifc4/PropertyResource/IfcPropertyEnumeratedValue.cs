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
using Integraph.Models.Ifc4.PropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPropertyEnumeratedValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPropertyEnumeratedValue : IIfcSimpleProperty
	{
		IItemSet<IIfcValue> @EnumerationValues { get; }
		IIfcPropertyEnumeration @EnumerationReference { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.PropertyResource
{
	[ExpressType("IfcPropertyEnumeratedValue", 629)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyEnumeratedValue : IfcSimpleProperty, IInstantiableEntity, IIfcPropertyEnumeratedValue, IContainsEntityReferences, IEquatable<@IfcPropertyEnumeratedValue>
	{
		#region IIfcPropertyEnumeratedValue explicit implementation
		IItemSet<IIfcValue> IIfcPropertyEnumeratedValue.EnumerationValues { 
			get { return new Common.Collections.ProxyItemSet<IfcValue, IIfcValue>( @EnumerationValues); } 
		}	
		IIfcPropertyEnumeration IIfcPropertyEnumeratedValue.EnumerationReference { 
 
 
			get { return @EnumerationReference; } 
			set { EnumerationReference = value as IfcPropertyEnumeration;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyEnumeratedValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_enumerationValues = new OptionalItemSet<IfcValue>( this, 0,  3);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcValue> _enumerationValues;
		private IfcPropertyEnumeration _enumerationReference;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 10)]
		public IOptionalItemSet<IfcValue> @EnumerationValues 
		{ 
			get 
			{
				if(_activated) return _enumerationValues;
				Activate();
				return _enumerationValues;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 11)]
		public IfcPropertyEnumeration @EnumerationReference 
		{ 
			get 
			{
				if(_activated) return _enumerationReference;
				Activate();
				return _enumerationReference;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _enumerationReference = v, _enumerationReference, value,  "EnumerationReference", 4);
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
					_enumerationValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 3: 
					_enumerationReference = (IfcPropertyEnumeration)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyEnumeratedValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@EnumerationReference != null)
					yield return @EnumerationReference;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}