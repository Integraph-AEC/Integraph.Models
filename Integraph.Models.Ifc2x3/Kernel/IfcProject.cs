// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.RepresentationResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProject : IIfcObject
	{
		IfcLabel? @LongName { get;  set; }
		IfcLabel? @Phase { get;  set; }
		IItemSet<IIfcRepresentationContext> @RepresentationContexts { get; }
		IIfcUnitAssignment @UnitsInContext { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.Kernel
{
	[ExpressType("IfcProject", 204)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProject : IfcObject, IInstantiableEntity, IIfcProject, IContainsEntityReferences, IEquatable<@IfcProject>
	{
		#region IIfcProject explicit implementation
		IfcLabel? IIfcProject.LongName { 
 
			get { return @LongName; } 
			set { LongName = value;}
		}	
		IfcLabel? IIfcProject.Phase { 
 
			get { return @Phase; } 
			set { Phase = value;}
		}	
		IItemSet<IIfcRepresentationContext> IIfcProject.RepresentationContexts { 
			get { return new Common.Collections.ProxyItemSet<IfcRepresentationContext, IIfcRepresentationContext>( @RepresentationContexts); } 
		}	
		IIfcUnitAssignment IIfcProject.UnitsInContext { 
 
 
			get { return @UnitsInContext; } 
			set { UnitsInContext = value as IfcUnitAssignment;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProject(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_representationContexts = new ItemSet<IfcRepresentationContext>( this, 0,  8);
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		private IfcLabel? _phase;
		private readonly ItemSet<IfcRepresentationContext> _representationContexts;
		private IfcUnitAssignment _unitsInContext;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcLabel? @LongName 
		{ 
			get 
			{
				if(_activated) return _longName;
				Activate();
				return _longName;
			} 
			set
			{
				SetValue( v =>  _longName = v, _longName, value,  "LongName", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcLabel? @Phase 
		{ 
			get 
			{
				if(_activated) return _phase;
				Activate();
				return _phase;
			} 
			set
			{
				SetValue( v =>  _phase = v, _phase, value,  "Phase", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 13)]
		public IItemSet<IfcRepresentationContext> @RepresentationContexts 
		{ 
			get 
			{
				if(_activated) return _representationContexts;
				Activate();
				return _representationContexts;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 14)]
		public IfcUnitAssignment @UnitsInContext 
		{ 
			get 
			{
				if(_activated) return _unitsInContext;
				Activate();
				return _unitsInContext;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unitsInContext = v, _unitsInContext, value,  "UnitsInContext", 9);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_longName = value.StringVal;
					return;
				case 6: 
					_phase = value.StringVal;
					return;
				case 7: 
					_representationContexts.InternalAdd((IfcRepresentationContext)value.EntityVal);
					return;
				case 8: 
					_unitsInContext = (IfcUnitAssignment)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProject other)
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
				foreach(var entity in @RepresentationContexts)
					yield return entity;
				if (@UnitsInContext != null)
					yield return @UnitsInContext;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}