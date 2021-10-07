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
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometryResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceOfRevolution
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceOfRevolution : IIfcSweptSurface
	{
		IIfcAxis1Placement @AxisPosition { get;  set; }
		Common.Geometry.XbimLine @AxisLine  { get ; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometryResource
{
	[ExpressType("IfcSurfaceOfRevolution", 109)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSurfaceOfRevolution : IfcSweptSurface, IInstantiableEntity, IIfcSurfaceOfRevolution, IContainsEntityReferences, IEquatable<@IfcSurfaceOfRevolution>
	{
		#region IIfcSurfaceOfRevolution explicit implementation
		IIfcAxis1Placement IIfcSurfaceOfRevolution.AxisPosition { 
 
 
			get { return @AxisPosition; } 
			set { AxisPosition = value as IfcAxis1Placement;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceOfRevolution(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAxis1Placement _axisPosition;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcAxis1Placement @AxisPosition 
		{ 
			get 
			{
				if(_activated) return _axisPosition;
				Activate();
				return _axisPosition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _axisPosition = v, _axisPosition, value,  "AxisPosition", 3);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public Common.Geometry.XbimLine @AxisLine 
		{
			get 
			{
				//## Getter for AxisLine
                if (AxisPosition != null)
                {
                    return new Common.Geometry.XbimLine
                    {
                        Pnt = new Common.Geometry.XbimPoint3D(AxisPosition.Location.X, AxisPosition.Location.Y, AxisPosition.Location.Z),
                        Orientation = AxisPosition.Z,
                    };
                }
                return null;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_axisPosition = (IfcAxis1Placement)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceOfRevolution other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SweptCurve != null)
					yield return @SweptCurve;
				if (@Position != null)
					yield return @Position;
				if (@AxisPosition != null)
					yield return @AxisPosition;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}