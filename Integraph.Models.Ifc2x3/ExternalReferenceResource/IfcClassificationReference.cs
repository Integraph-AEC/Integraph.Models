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
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ExternalReferenceResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcClassificationReference
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcClassificationReference : IIfcExternalReference, IfcClassificationNotationSelect
	{
		IIfcClassification @ReferencedSource { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ExternalReferenceResource
{
	[ExpressType("IfcClassificationReference", 209)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcClassificationReference : IfcExternalReference, IInstantiableEntity, IIfcClassificationReference, IContainsEntityReferences, IEquatable<@IfcClassificationReference>
	{
		#region IIfcClassificationReference explicit implementation
		IIfcClassification IIfcClassificationReference.ReferencedSource { 
 
 
			get { return @ReferencedSource; } 
			set { ReferencedSource = value as IfcClassification;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcClassificationReference(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcClassification _referencedSource;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcClassification @ReferencedSource 
		{ 
			get 
			{
				if(_activated) return _referencedSource;
				Activate();
				return _referencedSource;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _referencedSource = v, _referencedSource, value,  "ReferencedSource", 4);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_referencedSource = (IfcClassification)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcClassificationReference other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ReferencedSource != null)
					yield return @ReferencedSource;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}