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
using Integraph.Models.Ifc2x3.QuantityResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcPhysicalQuantity
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcPhysicalQuantity : IPersistEntity
	{
		IfcLabel @Name { get;  set; }
		IfcText? @Description { get;  set; }
		IEnumerable<IIfcPhysicalComplexQuantity> @PartOfComplex {  get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.QuantityResource
{
	[ExpressType("IfcPhysicalQuantity", 102)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPhysicalQuantity : PersistEntity, IIfcPhysicalQuantity, IEquatable<@IfcPhysicalQuantity>
	{
		#region IIfcPhysicalQuantity explicit implementation
		IfcLabel IIfcPhysicalQuantity.Name { 
 
			get { return @Name; } 
			set { Name = value;}
		}	
		IfcText? IIfcPhysicalQuantity.Description { 
 
			get { return @Description; } 
			set { Description = value;}
		}	
		 
		IEnumerable<IIfcPhysicalComplexQuantity> IIfcPhysicalQuantity.PartOfComplex {  get { return @PartOfComplex; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPhysicalQuantity(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private IfcText? _description;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
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
		#endregion



		#region Inverse attributes
		[InverseProperty("HasQuantities")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 3)]
		public IEnumerable<IfcPhysicalComplexQuantity> @PartOfComplex 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPhysicalComplexQuantity>(e => e.HasQuantities != null &&  e.HasQuantities.Contains(this), "HasQuantities", this);
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
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPhysicalQuantity other)
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