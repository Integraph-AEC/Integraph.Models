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
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.SharedBldgServiceElements;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcDistributionControlElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcDistributionControlElement : IIfcDistributionElement
	{
		IEnumerable<IIfcRelFlowControlElements> @AssignedToFlowElement {  get; }
	
	}
}

namespace Integraph.Models.Ifc4.SharedBldgServiceElements
{
	[ExpressType("IfcDistributionControlElement", 468)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDistributionControlElement : IfcDistributionElement, IInstantiableEntity, IIfcDistributionControlElement, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDistributionControlElement>
	{
		#region IIfcDistributionControlElement explicit implementation
		 
		IEnumerable<IIfcRelFlowControlElements> IIfcDistributionControlElement.AssignedToFlowElement {  get { return @AssignedToFlowElement; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDistributionControlElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("RelatedControlElements")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 34)]
		public IEnumerable<IfcRelFlowControlElements> @AssignedToFlowElement 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelFlowControlElements>(e => e.RelatedControlElements != null &&  e.RelatedControlElements.Contains(this), "RelatedControlElements", this);
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
				case 5: 
				case 6: 
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDistributionControlElement other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}