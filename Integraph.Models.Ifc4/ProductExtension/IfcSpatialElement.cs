// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Kernel;
using Integraph.Models.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.ProductExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcSpatialElement
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcSpatialElement : IIfcProduct
	{
		IfcLabel? @LongName { get;  set; }
		IEnumerable<IIfcRelContainedInSpatialStructure> @ContainsElements {  get; }
		IEnumerable<IIfcRelServicesBuildings> @ServicedBySystems {  get; }
		IEnumerable<IIfcRelReferencedInSpatialStructure> @ReferencesElements {  get; }
	
	}
}

namespace Integraph.Models.Ifc4.ProductExtension
{
	[ExpressType("IfcSpatialElement", 1273)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcSpatialElement : IfcProduct, IIfcSpatialElement, IEquatable<@IfcSpatialElement>
	{
		#region IIfcSpatialElement explicit implementation
		IfcLabel? IIfcSpatialElement.LongName { 
 
			get { return @LongName; } 
			set { LongName = value;}
		}	
		 
		IEnumerable<IIfcRelContainedInSpatialStructure> IIfcSpatialElement.ContainsElements {  get { return @ContainsElements; } }
		IEnumerable<IIfcRelServicesBuildings> IIfcSpatialElement.ServicedBySystems {  get { return @ServicedBySystems; } }
		IEnumerable<IIfcRelReferencedInSpatialStructure> IIfcSpatialElement.ReferencesElements {  get { return @ReferencesElements; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpatialElement(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _longName;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
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
				SetValue( v =>  _longName = v, _longName, value,  "LongName", 8);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingStructure")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 21)]
		public IEnumerable<IfcRelContainedInSpatialStructure> @ContainsElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelContainedInSpatialStructure>(e => Equals(e.RelatingStructure), "RelatingStructure", this);
			} 
		}
		[InverseProperty("RelatedBuildings")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 22)]
		public IEnumerable<IfcRelServicesBuildings> @ServicedBySystems 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelServicesBuildings>(e => e.RelatedBuildings != null &&  e.RelatedBuildings.Contains(this), "RelatedBuildings", this);
			} 
		}
		[InverseProperty("RelatingStructure")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 23)]
		public IEnumerable<IfcRelReferencedInSpatialStructure> @ReferencesElements 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelReferencedInSpatialStructure>(e => Equals(e.RelatingStructure), "RelatingStructure", this);
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
				case 5: 
				case 6: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 7: 
					_longName = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpatialElement other)
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