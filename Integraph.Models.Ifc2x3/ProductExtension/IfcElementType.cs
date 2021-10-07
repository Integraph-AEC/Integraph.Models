// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProductExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcElementType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcElementType : IIfcTypeProduct
	{
		IfcLabel? @ElementType { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProductExtension
{
	[ExpressType("IfcElementType", 48)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcElementType : IfcTypeProduct, IIfcElementType, IEquatable<@IfcElementType>
	{
		#region IIfcElementType explicit implementation
		IfcLabel? IIfcElementType.ElementType { 
 
			get { return @ElementType; } 
			set { ElementType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcElementType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _elementType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcLabel? @ElementType 
		{ 
			get 
			{
				if(_activated) return _elementType;
				Activate();
				return _elementType;
			} 
			set
			{
				SetValue( v =>  _elementType = v, _elementType, value,  "ElementType", 9);
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
				case 8: 
					_elementType = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcElementType other)
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