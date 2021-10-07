// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.GeometryResource;
using Integraph.Models.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcAnnotationFillAreaOccurrence
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAnnotationFillAreaOccurrence : IIfcAnnotationOccurrence
	{
		IIfcPoint @FillStyleTarget { get;  set; }
		IfcGlobalOrLocalEnum? @GlobalOrLocal { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcAnnotationFillAreaOccurrence", 544)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAnnotationFillAreaOccurrence : IfcAnnotationOccurrence, IInstantiableEntity, IIfcAnnotationFillAreaOccurrence, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcAnnotationFillAreaOccurrence>
	{
		#region IIfcAnnotationFillAreaOccurrence explicit implementation
		IIfcPoint IIfcAnnotationFillAreaOccurrence.FillStyleTarget { 
 
 
			get { return @FillStyleTarget; } 
			set { FillStyleTarget = value as IfcPoint;}
		}	
		IfcGlobalOrLocalEnum? IIfcAnnotationFillAreaOccurrence.GlobalOrLocal { 
 
			get { return @GlobalOrLocal; } 
			set { GlobalOrLocal = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAnnotationFillAreaOccurrence(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPoint _fillStyleTarget;
		private IfcGlobalOrLocalEnum? _globalOrLocal;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcPoint @FillStyleTarget 
		{ 
			get 
			{
				if(_activated) return _fillStyleTarget;
				Activate();
				return _fillStyleTarget;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _fillStyleTarget = v, _fillStyleTarget, value,  "FillStyleTarget", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 7)]
		public IfcGlobalOrLocalEnum? @GlobalOrLocal 
		{ 
			get 
			{
				if(_activated) return _globalOrLocal;
				Activate();
				return _globalOrLocal;
			} 
			set
			{
				SetValue( v =>  _globalOrLocal = v, _globalOrLocal, value,  "GlobalOrLocal", 5);
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
					_fillStyleTarget = (IfcPoint)(value.EntityVal);
					return;
				case 4: 
                    _globalOrLocal = (IfcGlobalOrLocalEnum) System.Enum.Parse(typeof (IfcGlobalOrLocalEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAnnotationFillAreaOccurrence other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				foreach(var entity in @Styles)
					yield return entity;
				if (@FillStyleTarget != null)
					yield return @FillStyleTarget;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Item != null)
					yield return @Item;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}