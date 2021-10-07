// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcHalfSpaceSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcHalfSpaceSolid : IIfcGeometricRepresentationItem, IfcBooleanOperand
	{
		IIfcSurface @BaseSurface { get;  set; }
		bool @AgreementFlag { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcHalfSpaceSolid", 338)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcHalfSpaceSolid : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcHalfSpaceSolid, IContainsEntityReferences, IEquatable<@IfcHalfSpaceSolid>
	{
		#region IIfcHalfSpaceSolid explicit implementation
		IIfcSurface IIfcHalfSpaceSolid.BaseSurface { 
 
 
			get { return @BaseSurface; } 
			set { BaseSurface = value as IfcSurface;}
		}	
		bool IIfcHalfSpaceSolid.AgreementFlag { 
 
			get { return @AgreementFlag; } 
			set { AgreementFlag = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcHalfSpaceSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSurface _baseSurface;
		private bool _agreementFlag;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcSurface @BaseSurface 
		{ 
			get 
			{
				if(_activated) return _baseSurface;
				Activate();
				return _baseSurface;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _baseSurface = v, _baseSurface, value,  "BaseSurface", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public bool @AgreementFlag 
		{ 
			get 
			{
				if(_activated) return _agreementFlag;
				Activate();
				return _agreementFlag;
			} 
			set
			{
				SetValue( v =>  _agreementFlag = v, _agreementFlag, value,  "AgreementFlag", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_baseSurface = (IfcSurface)(value.EntityVal);
					return;
				case 1: 
					_agreementFlag = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcHalfSpaceSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@BaseSurface != null)
					yield return @BaseSurface;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}