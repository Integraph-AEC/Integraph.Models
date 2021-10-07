// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.PropertyResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ActorResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcOrganization
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcOrganization : IPersistEntity, IfcActorSelect, IfcObjectReferenceSelect
	{
		IfcIdentifier? @Id { get;  set; }
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IItemSet<IIfcActorRole> @Roles { get; }
		IItemSet<IIfcAddress> @Addresses { get; }
		IEnumerable<IIfcOrganizationRelationship> @IsRelatedBy {  get; }
		IEnumerable<IIfcOrganizationRelationship> @Relates {  get; }
		IEnumerable<IIfcPersonAndOrganization> @Engages {  get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ActorResource
{
	[ExpressType("IfcOrganization", 276)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrganization : PersistEntity, IInstantiableEntity, IIfcOrganization, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcOrganization>
	{
		#region IIfcOrganization explicit implementation
		IfcIdentifier? IIfcOrganization.Id { 
 
			get { return @Id; } 
			set { Id = value;}
		}	
		IfcLabel IIfcOrganization.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcOrganization.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IItemSet<IIfcActorRole> IIfcOrganization.Roles { 
			get { return new Common.Collections.ProxyItemSet<IfcActorRole, IIfcActorRole>( @Roles); } 
		}	
		IItemSet<IIfcAddress> IIfcOrganization.Addresses { 
			get { return new Common.Collections.ProxyItemSet<IfcAddress, IIfcAddress>( @Addresses); } 
		}	
		 
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.IsRelatedBy {  get { return @IsRelatedBy; } }
		IEnumerable<IIfcOrganizationRelationship> IIfcOrganization.Relates {  get { return @Relates; } }
		IEnumerable<IIfcPersonAndOrganization> IIfcOrganization.Engages {  get { return @Engages; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrganization(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_roles = new OptionalItemSet<IfcActorRole>( this, 0,  4);
			_addresses = new OptionalItemSet<IfcAddress>( this, 0,  5);
		}

		#region Explicit attribute fields
		private IfcIdentifier? _id;
		private IfcLabel _name;
		private IfcText? _description;
		private readonly OptionalItemSet<IfcActorRole> _roles;
		private readonly OptionalItemSet<IfcAddress> _addresses;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcIdentifier? @Id 
		{ 
			get 
			{
				if(_activated) return _id;
				Activate();
				return _id;
			} 
			set
			{
				SetValue( v =>  _id = v, _id, value,  "Id", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
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
				SetValue( v =>  _description = v, _description, value,  "Description", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IOptionalItemSet<IfcActorRole> @Roles 
		{ 
			get 
			{
				if(_activated) return _roles;
				Activate();
				return _roles;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 5)]
		public IOptionalItemSet<IfcAddress> @Addresses 
		{ 
			get 
			{
				if(_activated) return _addresses;
				Activate();
				return _addresses;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatedOrganizations")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 6)]
		public IEnumerable<IfcOrganizationRelationship> @IsRelatedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => e.RelatedOrganizations != null &&  e.RelatedOrganizations.Contains(this), "RelatedOrganizations", this);
			} 
		}
		[InverseProperty("RelatingOrganization")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 7)]
		public IEnumerable<IfcOrganizationRelationship> @Relates 
		{ 
			get 
			{
				return Model.Instances.Where<IfcOrganizationRelationship>(e => Equals(e.RelatingOrganization), "RelatingOrganization", this);
			} 
		}
		[InverseProperty("TheOrganization")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IEnumerable<IfcPersonAndOrganization> @Engages 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPersonAndOrganization>(e => Equals(e.TheOrganization), "TheOrganization", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_id = value.StringVal;
					return;
				case 1: 
					_name = value.StringVal;
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_roles.InternalAdd((IfcActorRole)value.EntityVal);
					return;
				case 4: 
					_addresses.InternalAdd((IfcAddress)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrganization other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Roles)
					yield return entity;
				foreach(var entity in @Addresses)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Addresses)
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