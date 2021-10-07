// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelOverridesProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelOverridesProperties : IIfcRelDefinesByProperties
	{
		IItemSet<IIfcProperty> @OverridingProperties { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.Kernel
{
	[ExpressType("IfcRelOverridesProperties", 248)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelOverridesProperties : IfcRelDefinesByProperties, IInstantiableEntity, IIfcRelOverridesProperties, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelOverridesProperties>
	{
		#region IIfcRelOverridesProperties explicit implementation
		IItemSet<IIfcProperty> IIfcRelOverridesProperties.OverridingProperties { 
			get { return new Common.Collections.ProxyItemSet<IfcProperty, IIfcProperty>( @OverridingProperties); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelOverridesProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_overridingProperties = new ItemSet<IfcProperty>( this, 0,  7);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcProperty> _overridingProperties;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 7)]
		public IItemSet<IfcProperty> @OverridingProperties 
		{ 
			get 
			{
				if(_activated) return _overridingProperties;
				Activate();
				return _overridingProperties;
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
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_overridingProperties.InternalAdd((IfcProperty)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelOverridesProperties other)
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
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingPropertyDefinition != null)
					yield return @RelatingPropertyDefinition;
				foreach(var entity in @OverridingProperties)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingPropertyDefinition != null)
					yield return @RelatingPropertyDefinition;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}