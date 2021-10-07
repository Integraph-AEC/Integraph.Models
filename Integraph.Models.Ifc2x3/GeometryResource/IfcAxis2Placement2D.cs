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
    /// Readonly interface for IfcAxis2Placement2D
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcAxis2Placement2D : IIfcPlacement, IfcAxis2Placement
	{
		IIfcDirection @RefDirection { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.GeometryResource
{
	[ExpressType("IfcAxis2Placement2D", 411)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcAxis2Placement2D : IfcPlacement, IInstantiableEntity, IIfcAxis2Placement2D, IContainsEntityReferences, IEquatable<@IfcAxis2Placement2D>
	{
		#region IIfcAxis2Placement2D explicit implementation
		IIfcDirection IIfcAxis2Placement2D.RefDirection { 
 
 
			get { return @RefDirection; } 
			set { RefDirection = value as IfcDirection;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAxis2Placement2D(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _refDirection;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcDirection @RefDirection 
		{ 
			get 
			{
				if(_activated) return _refDirection;
				Activate();
				return _refDirection;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _refDirection = v, _refDirection, value,  "RefDirection", 2);
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 2 }, new int [] { 2 }, 0)]
		public List<Common.Geometry.XbimVector3D> @P 
		{
			get 
			{
				//## Getter for P
                var p = new List<Common.Geometry.XbimVector3D>(2);
                if (RefDirection == null)
                {
                    p.Add(new Common.Geometry.XbimVector3D(1, 0, 0));
                    p.Add(new Common.Geometry.XbimVector3D(0, 1, 0));
                }
                else
                {
                    p.Add(new Common.Geometry.XbimVector3D(RefDirection.DirectionRatios[0], RefDirection.DirectionRatios[1], 0));
                    p.Add(new Common.Geometry.XbimVector3D(-RefDirection.DirectionRatios[1], RefDirection.DirectionRatios[0], 0));
                }
                return p;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_refDirection = (IfcDirection)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAxis2Placement2D other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Location != null)
					yield return @Location;
				if (@RefDirection != null)
					yield return @RefDirection;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}