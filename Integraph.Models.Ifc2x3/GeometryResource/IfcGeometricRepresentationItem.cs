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
    /// Readonly interface for IfcGeometricRepresentationItem
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcGeometricRepresentationItem : IIfcRepresentationItem
	{
	
	}
}

namespace Integraph.Models.Ifc2x3.GeometryResource
{
	[ExpressType("IfcGeometricRepresentationItem", 30)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcGeometricRepresentationItem : IfcRepresentationItem, IIfcGeometricRepresentationItem, IEquatable<@IfcGeometricRepresentationItem>
	{
		#region IIfcGeometricRepresentationItem explicit implementation
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeometricRepresentationItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}





		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeometricRepresentationItem other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}