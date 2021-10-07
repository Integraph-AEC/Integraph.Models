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
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPixelTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPixelTexture : IIfcSurfaceTexture
	{
		IfcInteger @Width { get;  set; }
		IfcInteger @Height { get;  set; }
		IfcInteger @ColourComponents { get;  set; }
		IItemSet<byte[]> @Pixel { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	[ExpressType("IfcPixelTexture", 728)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPixelTexture : IfcSurfaceTexture, IInstantiableEntity, IIfcPixelTexture, IContainsEntityReferences, IEquatable<@IfcPixelTexture>
	{
		#region IIfcPixelTexture explicit implementation
		IfcInteger IIfcPixelTexture.Width { 
 
			get { return @Width; } 
			set { Width = value;}
		}	
		IfcInteger IIfcPixelTexture.Height { 
 
			get { return @Height; } 
			set { Height = value;}
		}	
		IfcInteger IIfcPixelTexture.ColourComponents { 
 
			get { return @ColourComponents; } 
			set { ColourComponents = value;}
		}	
		IItemSet<byte[]> IIfcPixelTexture.Pixel { 
			get { return @Pixel; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPixelTexture(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_pixel = new ItemSet<byte[]>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcInteger _width;
		private IfcInteger _height;
		private IfcInteger _colourComponents;
		private readonly ItemSet<byte[]> _pixel;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcInteger @Width 
		{ 
			get 
			{
				if(_activated) return _width;
				Activate();
				return _width;
			} 
			set
			{
				SetValue( v =>  _width = v, _width, value,  "Width", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcInteger @Height 
		{ 
			get 
			{
				if(_activated) return _height;
				Activate();
				return _height;
			} 
			set
			{
				SetValue( v =>  _height = v, _height, value,  "Height", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcInteger @ColourComponents 
		{ 
			get 
			{
				if(_activated) return _colourComponents;
				Activate();
				return _colourComponents;
			} 
			set
			{
				SetValue( v =>  _colourComponents = v, _colourComponents, value,  "ColourComponents", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 8)]
		public IItemSet<byte[]> @Pixel 
		{ 
			get 
			{
				if(_activated) return _pixel;
				Activate();
				return _pixel;
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_width = value.IntegerVal;
					return;
				case 5: 
					_height = value.IntegerVal;
					return;
				case 6: 
					_colourComponents = value.IntegerVal;
					return;
				case 7: 
					_pixel.InternalAdd(value.HexadecimalVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPixelTexture other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TextureTransform != null)
					yield return @TextureTransform;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}