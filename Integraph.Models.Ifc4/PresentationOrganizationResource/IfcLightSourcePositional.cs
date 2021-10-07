// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.GeometryResource;
using Integraph.Models.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.PresentationOrganizationResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcLightSourcePositional
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcLightSourcePositional : IIfcLightSource
	{
		IIfcCartesianPoint @Position { get;  set; }
		IfcPositiveLengthMeasure @Radius { get;  set; }
		IfcReal @ConstantAttenuation { get;  set; }
		IfcReal @DistanceAttenuation { get;  set; }
		IfcReal @QuadricAttenuation { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.PresentationOrganizationResource
{
	[ExpressType("IfcLightSourcePositional", 759)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourcePositional : IfcLightSource, IInstantiableEntity, IIfcLightSourcePositional, IContainsEntityReferences, IEquatable<@IfcLightSourcePositional>
	{
		#region IIfcLightSourcePositional explicit implementation
		IIfcCartesianPoint IIfcLightSourcePositional.Position { 
 
 
			get { return @Position; } 
			set { Position = value as IfcCartesianPoint;}
		}	
		IfcPositiveLengthMeasure IIfcLightSourcePositional.Radius { 
 
			get { return @Radius; } 
			set { Radius = value;}
		}	
		IfcReal IIfcLightSourcePositional.ConstantAttenuation { 
 
			get { return @ConstantAttenuation; } 
			set { ConstantAttenuation = value;}
		}	
		IfcReal IIfcLightSourcePositional.DistanceAttenuation { 
 
			get { return @DistanceAttenuation; } 
			set { DistanceAttenuation = value;}
		}	
		IfcReal IIfcLightSourcePositional.QuadricAttenuation { 
 
			get { return @QuadricAttenuation; } 
			set { QuadricAttenuation = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourcePositional(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCartesianPoint _position;
		private IfcPositiveLengthMeasure _radius;
		private IfcReal _constantAttenuation;
		private IfcReal _distanceAttenuation;
		private IfcReal _quadricAttenuation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 7)]
		public IfcCartesianPoint @Position 
		{ 
			get 
			{
				if(_activated) return _position;
				Activate();
				return _position;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _position = v, _position, value,  "Position", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcReal @ConstantAttenuation 
		{ 
			get 
			{
				if(_activated) return _constantAttenuation;
				Activate();
				return _constantAttenuation;
			} 
			set
			{
				SetValue( v =>  _constantAttenuation = v, _constantAttenuation, value,  "ConstantAttenuation", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcReal @DistanceAttenuation 
		{ 
			get 
			{
				if(_activated) return _distanceAttenuation;
				Activate();
				return _distanceAttenuation;
			} 
			set
			{
				SetValue( v =>  _distanceAttenuation = v, _distanceAttenuation, value,  "DistanceAttenuation", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcReal @QuadricAttenuation 
		{ 
			get 
			{
				if(_activated) return _quadricAttenuation;
				Activate();
				return _quadricAttenuation;
			} 
			set
			{
				SetValue( v =>  _quadricAttenuation = v, _quadricAttenuation, value,  "QuadricAttenuation", 9);
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
					_position = (IfcCartesianPoint)(value.EntityVal);
					return;
				case 5: 
					_radius = value.RealVal;
					return;
				case 6: 
					_constantAttenuation = value.RealVal;
					return;
				case 7: 
					_distanceAttenuation = value.RealVal;
					return;
				case 8: 
					_quadricAttenuation = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightSourcePositional other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@LightColour != null)
					yield return @LightColour;
				if (@Position != null)
					yield return @Position;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}