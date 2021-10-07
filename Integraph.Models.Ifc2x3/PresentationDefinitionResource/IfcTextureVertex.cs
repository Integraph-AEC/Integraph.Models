// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.PresentationDefinitionResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextureVertex
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextureVertex : IPersistEntity
	{
		IItemSet<IfcParameterValue> @Coordinates { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationDefinitionResource
{
	[ExpressType("IfcTextureVertex", 735)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureVertex : PersistEntity, IInstantiableEntity, IIfcTextureVertex, IEquatable<@IfcTextureVertex>
	{
		#region IIfcTextureVertex explicit implementation
		IItemSet<IfcParameterValue> IIfcTextureVertex.Coordinates { 
			get { return @Coordinates; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureVertex(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_coordinates = new ItemSet<IfcParameterValue>( this, 2,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcParameterValue> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 2 }, new int [] { 2 }, 1)]
		public IItemSet<IfcParameterValue> @Coordinates 
		{ 
			get 
			{
				if(_activated) return _coordinates;
				Activate();
				return _coordinates;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_coordinates.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureVertex other)
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