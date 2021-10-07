// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.GeometryResource;
using Integraph.Models.Ifc2x3.PresentationDefinitionResource;
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
    /// Readonly interface for IfcFillAreaStyleTileSymbolWithStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcFillAreaStyleTileSymbolWithStyle : IIfcGeometricRepresentationItem, IfcFillAreaStyleTileShapeSelect
	{
		IIfcAnnotationSymbolOccurrence @Symbol { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcFillAreaStyleTileSymbolWithStyle", 726)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcFillAreaStyleTileSymbolWithStyle : IfcGeometricRepresentationItem, IInstantiableEntity, IIfcFillAreaStyleTileSymbolWithStyle, IContainsEntityReferences, IEquatable<@IfcFillAreaStyleTileSymbolWithStyle>
	{
		#region IIfcFillAreaStyleTileSymbolWithStyle explicit implementation
		IIfcAnnotationSymbolOccurrence IIfcFillAreaStyleTileSymbolWithStyle.Symbol { 
 
 
			get { return @Symbol; } 
			set { Symbol = value as IfcAnnotationSymbolOccurrence;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcFillAreaStyleTileSymbolWithStyle(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAnnotationSymbolOccurrence _symbol;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcAnnotationSymbolOccurrence @Symbol 
		{ 
			get 
			{
				if(_activated) return _symbol;
				Activate();
				return _symbol;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _symbol = v, _symbol, value,  "Symbol", 1);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_symbol = (IfcAnnotationSymbolOccurrence)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcFillAreaStyleTileSymbolWithStyle other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Symbol != null)
					yield return @Symbol;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}