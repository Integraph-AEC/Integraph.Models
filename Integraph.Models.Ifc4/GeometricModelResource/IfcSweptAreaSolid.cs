// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.ProfileResource;
using Integraph.Models.Ifc4.GeometryResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.GeometricModelResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSweptAreaSolid
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSweptAreaSolid : IIfcSolidModel
	{
		IIfcProfileDef @SweptArea { get;  set; }
		IIfcAxis2Placement3D @Position { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.GeometricModelResource
{
	[ExpressType("IfcSweptAreaSolid", 239)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSweptAreaSolid : IfcSolidModel, IIfcSweptAreaSolid, IEquatable<@IfcSweptAreaSolid>
	{
		#region IIfcSweptAreaSolid explicit implementation
		IIfcProfileDef IIfcSweptAreaSolid.SweptArea { 
 
 
			get { return @SweptArea; } 
			set { SweptArea = value as IfcProfileDef;}
		}	
		IIfcAxis2Placement3D IIfcSweptAreaSolid.Position { 
 
 
			get { return @Position; } 
			set { Position = value as IfcAxis2Placement3D;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptAreaSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcProfileDef _sweptArea;
		private IfcAxis2Placement3D _position;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcProfileDef @SweptArea 
		{ 
			get 
			{
				if(_activated) return _sweptArea;
				Activate();
				return _sweptArea;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _sweptArea = v, _sweptArea, value,  "SweptArea", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcAxis2Placement3D @Position 
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
				SetValue( v =>  _position = v, _position, value,  "Position", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sweptArea = (IfcProfileDef)(value.EntityVal);
					return;
				case 1: 
					_position = (IfcAxis2Placement3D)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptAreaSolid other)
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