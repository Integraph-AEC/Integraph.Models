// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.ProductExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.MaterialResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialUsageDefinition
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialUsageDefinition : IPersistEntity, IfcMaterialSelect
	{
		IEnumerable<IIfcRelAssociatesMaterial> @AssociatedTo {  get; }
	
	}
}

namespace Integraph.Models.Ifc4.MaterialResource
{
	[ExpressType("IfcMaterialUsageDefinition", 1211)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcMaterialUsageDefinition : PersistEntity, IIfcMaterialUsageDefinition, IEquatable<@IfcMaterialUsageDefinition>
	{
		#region IIfcMaterialUsageDefinition explicit implementation
		 
		IEnumerable<IIfcRelAssociatesMaterial> IIfcMaterialUsageDefinition.AssociatedTo {  get { return @AssociatedTo; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialUsageDefinition(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("RelatingMaterial")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 1)]
		public IEnumerable<IfcRelAssociatesMaterial> @AssociatedTo 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelAssociatesMaterial>(e => Equals(e.RelatingMaterial), "RelatingMaterial", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialUsageDefinition other)
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