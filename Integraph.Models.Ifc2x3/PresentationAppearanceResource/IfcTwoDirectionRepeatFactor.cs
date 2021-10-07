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
using Integraph.Models.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTwoDirectionRepeatFactor
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTwoDirectionRepeatFactor : IIfcOneDirectionRepeatFactor
	{
		IIfcVector @SecondRepeatFactor { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcTwoDirectionRepeatFactor", 315)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTwoDirectionRepeatFactor : IfcOneDirectionRepeatFactor, IInstantiableEntity, IIfcTwoDirectionRepeatFactor, IContainsEntityReferences, IEquatable<@IfcTwoDirectionRepeatFactor>
	{
		#region IIfcTwoDirectionRepeatFactor explicit implementation
		IIfcVector IIfcTwoDirectionRepeatFactor.SecondRepeatFactor { 
 
 
			get { return @SecondRepeatFactor; } 
			set { SecondRepeatFactor = value as IfcVector;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTwoDirectionRepeatFactor(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcVector _secondRepeatFactor;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcVector @SecondRepeatFactor 
		{ 
			get 
			{
				if(_activated) return _secondRepeatFactor;
				Activate();
				return _secondRepeatFactor;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _secondRepeatFactor = v, _secondRepeatFactor, value,  "SecondRepeatFactor", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_secondRepeatFactor = (IfcVector)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTwoDirectionRepeatFactor other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RepeatFactor != null)
					yield return @RepeatFactor;
				if (@SecondRepeatFactor != null)
					yield return @SecondRepeatFactor;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}