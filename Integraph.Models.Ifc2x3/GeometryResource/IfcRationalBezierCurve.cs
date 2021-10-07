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
using Integraph.Models.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRationalBezierCurve
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRationalBezierCurve : IIfcBezierCurve
	{
		IItemSet<double> @WeightsData { get; }
		List<double> @Weights  { get ; }
	
	}
}

namespace Integraph.Models.Ifc2x3.GeometryResource
{
	[ExpressType("IfcRationalBezierCurve", 546)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRationalBezierCurve : IfcBezierCurve, IInstantiableEntity, IIfcRationalBezierCurve, IContainsEntityReferences, IEquatable<@IfcRationalBezierCurve>
	{
		#region IIfcRationalBezierCurve explicit implementation
		IItemSet<double> IIfcRationalBezierCurve.WeightsData { 
			get { return @WeightsData; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRationalBezierCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_weightsData = new ItemSet<double>( this, 0,  6);
		}

		#region Explicit attribute fields
		private readonly ItemSet<double> _weightsData;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { -1 }, 8)]
		public IItemSet<double> @WeightsData 
		{ 
			get 
			{
				if(_activated) return _weightsData;
				Activate();
				return _weightsData;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Array, EntityAttributeType.None, new int [] { 0 }, new int [] { 255 }, 0)]
		public List<double> @Weights 
		{
			get 
			{
				//## Getter for Weights
			    return WeightsData.ToList();
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
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_weightsData.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRationalBezierCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @ControlPointsList)
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