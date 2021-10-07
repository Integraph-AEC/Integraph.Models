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
using Integraph.Models.Ifc2x3.ApprovalResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcApprovalRelationship
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcApprovalRelationship : IPersistEntity
	{
		IIfcApproval @RelatedApproval { get;  set; }
		IIfcApproval @RelatingApproval { get;  set; }
		IfcText? @Description { get;  set; }
		IfcLabel @Name { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ApprovalResource
{
	[ExpressType("IfcApprovalRelationship", 552)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcApprovalRelationship : PersistEntity, IInstantiableEntity, IIfcApprovalRelationship, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcApprovalRelationship>
	{
		#region IIfcApprovalRelationship explicit implementation
		IIfcApproval IIfcApprovalRelationship.RelatedApproval { 
 
 
			get { return @RelatedApproval; } 
			set { RelatedApproval = value as IfcApproval;}
		}	
		IIfcApproval IIfcApprovalRelationship.RelatingApproval { 
 
 
			get { return @RelatingApproval; } 
			set { RelatingApproval = value as IfcApproval;}
		}	
		IfcText? IIfcApprovalRelationship.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		IfcLabel IIfcApprovalRelationship.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcApprovalRelationship(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcApproval _relatedApproval;
		private IfcApproval _relatingApproval;
		private IfcText? _description;
		private IfcLabel _name;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcApproval @RelatedApproval 
		{ 
			get 
			{
				if(_activated) return _relatedApproval;
				Activate();
				return _relatedApproval;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatedApproval = v, _relatedApproval, value,  "RelatedApproval", 1);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 2)]
		public IfcApproval @RelatingApproval 
		{ 
			get 
			{
				if(_activated) return _relatingApproval;
				Activate();
				return _relatingApproval;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingApproval = v, _relatingApproval, value,  "RelatingApproval", 2);
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
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
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
				SetValue( v =>  _name = v, _name, value,  "Name", 4);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_relatedApproval = (IfcApproval)(value.EntityVal);
					return;
				case 1: 
					_relatingApproval = (IfcApproval)(value.EntityVal);
					return;
				case 2: 
					_description = value.StringVal;
					return;
				case 3: 
					_name = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcApprovalRelationship other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@RelatedApproval != null)
					yield return @RelatedApproval;
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatedApproval != null)
					yield return @RelatedApproval;
				if (@RelatingApproval != null)
					yield return @RelatingApproval;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}