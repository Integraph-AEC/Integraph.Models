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
using Integraph.Models.Ifc2x3.RepresentationResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcProductRepresentation
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcProductRepresentation : IPersistEntity
	{
		IfcLabel? @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IItemSet<IIfcRepresentation> @Representations { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcProductRepresentation", 1)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcProductRepresentation : PersistEntity, IInstantiableEntity, IIfcProductRepresentation, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcProductRepresentation>
	{
		#region IIfcProductRepresentation explicit implementation
		IfcLabel? IIfcProductRepresentation.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcProductRepresentation.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IItemSet<IIfcRepresentation> IIfcProductRepresentation.Representations { 
			get { return new Common.Collections.ProxyItemSet<IfcRepresentation, IIfcRepresentation>( @Representations); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcProductRepresentation(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_representations = new ItemSet<IfcRepresentation>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private readonly ItemSet<IfcRepresentation> _representations;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcRepresentation> @Representations 
		{ 
			get 
			{
				if(_activated) return _representations;
				Activate();
				return _representations;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_description = value.StringVal;
					return;
				case 2: 
					_representations.InternalAdd((IfcRepresentation)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcProductRepresentation other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Representations)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Representations)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}