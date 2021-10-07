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
using Integraph.Models.Ifc4.ProfileResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRoundedRectangleProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRoundedRectangleProfileDef : IIfcRectangleProfileDef
	{
		IfcPositiveLengthMeasure @RoundingRadius { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.ProfileResource
{
	[ExpressType("IfcRoundedRectangleProfileDef", 106)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRoundedRectangleProfileDef : IfcRectangleProfileDef, IInstantiableEntity, IIfcRoundedRectangleProfileDef, IContainsEntityReferences, IEquatable<@IfcRoundedRectangleProfileDef>
	{
		#region IIfcRoundedRectangleProfileDef explicit implementation
		IfcPositiveLengthMeasure IIfcRoundedRectangleProfileDef.RoundingRadius { 
 
			get { return @RoundingRadius; } 
			set { RoundingRadius = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRoundedRectangleProfileDef(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPositiveLengthMeasure _roundingRadius;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure @RoundingRadius 
		{ 
			get 
			{
				if(_activated) return _roundingRadius;
				Activate();
				return _roundingRadius;
			} 
			set
			{
				SetValue( v =>  _roundingRadius = v, _roundingRadius, value,  "RoundingRadius", 6);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_roundingRadius = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRoundedRectangleProfileDef other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}