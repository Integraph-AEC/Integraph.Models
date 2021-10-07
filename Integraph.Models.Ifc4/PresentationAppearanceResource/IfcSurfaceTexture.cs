// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.PresentationDefinitionResource;
using Integraph.Models.Ifc4.MeasureResource;
using Integraph.Models.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSurfaceTexture
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSurfaceTexture : IIfcPresentationItem
	{
		IfcBoolean @RepeatS { get;  set; }
		IfcBoolean @RepeatT { get;  set; }
		IfcIdentifier? @Mode { get;  set; }
		IIfcCartesianTransformationOperator2D @TextureTransform { get;  set; }
		IItemSet<IfcIdentifier> @Parameter { get; }
		IEnumerable<IIfcTextureCoordinate> @IsMappedBy {  get; }
		IEnumerable<IIfcSurfaceStyleWithTextures> @UsedInStyles {  get; }
	
	}
}

namespace Integraph.Models.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcSurfaceTexture", 722)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSurfaceTexture : IfcPresentationItem, IIfcSurfaceTexture, IEquatable<@IfcSurfaceTexture>
	{
		#region IIfcSurfaceTexture explicit implementation
		IfcBoolean IIfcSurfaceTexture.RepeatS { 
 
			get { return @RepeatS; } 
			set { RepeatS = value;}
		}	
		IfcBoolean IIfcSurfaceTexture.RepeatT { 
 
			get { return @RepeatT; } 
			set { RepeatT = value;}
		}	
		IfcIdentifier? IIfcSurfaceTexture.Mode { 
 
			get { return @Mode; } 
			set { Mode = value;}
		}	
		IIfcCartesianTransformationOperator2D IIfcSurfaceTexture.TextureTransform { 
 
 
			get { return @TextureTransform; } 
			set { TextureTransform = value as IfcCartesianTransformationOperator2D;}
		}	
		IItemSet<IfcIdentifier> IIfcSurfaceTexture.Parameter { 
			get { return @Parameter; } 
		}	
		 
		IEnumerable<IIfcTextureCoordinate> IIfcSurfaceTexture.IsMappedBy {  get { return @IsMappedBy; } }
		IEnumerable<IIfcSurfaceStyleWithTextures> IIfcSurfaceTexture.UsedInStyles {  get { return @UsedInStyles; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSurfaceTexture(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_parameter = new OptionalItemSet<IfcIdentifier>( this, 0,  5);
		}

		#region Explicit attribute fields
		private IfcBoolean _repeatS;
		private IfcBoolean _repeatT;
		private IfcIdentifier? _mode;
		private IfcCartesianTransformationOperator2D _textureTransform;
		private readonly OptionalItemSet<IfcIdentifier> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcBoolean @RepeatS 
		{ 
			get 
			{
				if(_activated) return _repeatS;
				Activate();
				return _repeatS;
			} 
			set
			{
				SetValue( v =>  _repeatS = v, _repeatS, value,  "RepeatS", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcBoolean @RepeatT 
		{ 
			get 
			{
				if(_activated) return _repeatT;
				Activate();
				return _repeatT;
			} 
			set
			{
				SetValue( v =>  _repeatT = v, _repeatT, value,  "RepeatT", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcIdentifier? @Mode 
		{ 
			get 
			{
				if(_activated) return _mode;
				Activate();
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCartesianTransformationOperator2D @TextureTransform 
		{ 
			get 
			{
				if(_activated) return _textureTransform;
				Activate();
				return _textureTransform;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _textureTransform = v, _textureTransform, value,  "TextureTransform", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 5)]
		public IOptionalItemSet<IfcIdentifier> @Parameter 
		{ 
			get 
			{
				if(_activated) return _parameter;
				Activate();
				return _parameter;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Maps")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 6)]
		public IEnumerable<IfcTextureCoordinate> @IsMappedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureCoordinate>(e => e.Maps != null &&  e.Maps.Contains(this), "Maps", this);
			} 
		}
		[InverseProperty("Textures")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 7)]
		public IEnumerable<IfcSurfaceStyleWithTextures> @UsedInStyles 
		{ 
			get 
			{
				return Model.Instances.Where<IfcSurfaceStyleWithTextures>(e => e.Textures != null &&  e.Textures.Contains(this), "Textures", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_repeatS = value.BooleanVal;
					return;
				case 1: 
					_repeatT = value.BooleanVal;
					return;
				case 2: 
					_mode = value.StringVal;
					return;
				case 3: 
					_textureTransform = (IfcCartesianTransformationOperator2D)(value.EntityVal);
					return;
				case 4: 
					_parameter.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSurfaceTexture other)
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