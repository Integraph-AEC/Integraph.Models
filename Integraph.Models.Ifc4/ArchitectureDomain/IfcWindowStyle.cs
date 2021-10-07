// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Kernel;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.ArchitectureDomain;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcWindowStyle
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWindowStyle : IIfcTypeProduct
	{
		IfcWindowStyleConstructionEnum @ConstructionType { get;  set; }
		IfcWindowStyleOperationEnum @OperationType { get;  set; }
		IfcBoolean @ParameterTakesPrecedence { get;  set; }
		IfcBoolean @Sizeable { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.ArchitectureDomain
{
	[ExpressType("IfcWindowStyle", 345)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWindowStyle : IfcTypeProduct, IInstantiableEntity, IIfcWindowStyle, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcWindowStyle>
	{
		#region IIfcWindowStyle explicit implementation
		IfcWindowStyleConstructionEnum IIfcWindowStyle.ConstructionType { 
 
			get { return @ConstructionType; } 
			set { ConstructionType = value;}
		}	
		IfcWindowStyleOperationEnum IIfcWindowStyle.OperationType { 
 
			get { return @OperationType; } 
			set { OperationType = value;}
		}	
		IfcBoolean IIfcWindowStyle.ParameterTakesPrecedence { 
 
			get { return @ParameterTakesPrecedence; } 
			set { ParameterTakesPrecedence = value;}
		}	
		IfcBoolean IIfcWindowStyle.Sizeable { 
 
			get { return @Sizeable; } 
			set { Sizeable = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWindowStyle(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcWindowStyleConstructionEnum _constructionType;
		private IfcWindowStyleOperationEnum _operationType;
		private IfcBoolean _parameterTakesPrecedence;
		private IfcBoolean _sizeable;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 18)]
		public IfcWindowStyleConstructionEnum @ConstructionType 
		{ 
			get 
			{
				if(_activated) return _constructionType;
				Activate();
				return _constructionType;
			} 
			set
			{
				SetValue( v =>  _constructionType = v, _constructionType, value,  "ConstructionType", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcWindowStyleOperationEnum @OperationType 
		{ 
			get 
			{
				if(_activated) return _operationType;
				Activate();
				return _operationType;
			} 
			set
			{
				SetValue( v =>  _operationType = v, _operationType, value,  "OperationType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcBoolean @ParameterTakesPrecedence 
		{ 
			get 
			{
				if(_activated) return _parameterTakesPrecedence;
				Activate();
				return _parameterTakesPrecedence;
			} 
			set
			{
				SetValue( v =>  _parameterTakesPrecedence = v, _parameterTakesPrecedence, value,  "ParameterTakesPrecedence", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcBoolean @Sizeable 
		{ 
			get 
			{
				if(_activated) return _sizeable;
				Activate();
				return _sizeable;
			} 
			set
			{
				SetValue( v =>  _sizeable = v, _sizeable, value,  "Sizeable", 12);
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
				case 7: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 8: 
                    _constructionType = (IfcWindowStyleConstructionEnum) System.Enum.Parse(typeof (IfcWindowStyleConstructionEnum), value.EnumVal, true);
					return;
				case 9: 
                    _operationType = (IfcWindowStyleOperationEnum) System.Enum.Parse(typeof (IfcWindowStyleOperationEnum), value.EnumVal, true);
					return;
				case 10: 
					_parameterTakesPrecedence = value.BooleanVal;
					return;
				case 11: 
					_sizeable = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWindowStyle other)
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
				foreach(var entity in @HasPropertySets)
					yield return entity;
				foreach(var entity in @RepresentationMaps)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @HasPropertySets)
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