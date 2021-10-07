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
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.MaterialPropertyResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMechanicalConcreteMaterialProperties
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMechanicalConcreteMaterialProperties : IIfcMechanicalMaterialProperties
	{
		IfcPressureMeasure? @CompressiveStrength { get;  set; }
		IfcPositiveLengthMeasure? @MaxAggregateSize { get;  set; }
		IfcText? @AdmixturesDescription { get;  set; }
		IfcText? @Workability { get;  set; }
		IfcNormalisedRatioMeasure? @ProtectivePoreRatio { get;  set; }
		IfcText? @WaterImpermeability { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc2x3.MaterialPropertyResource
{
	[ExpressType("IfcMechanicalConcreteMaterialProperties", 693)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMechanicalConcreteMaterialProperties : IfcMechanicalMaterialProperties, IInstantiableEntity, IIfcMechanicalConcreteMaterialProperties, IContainsEntityReferences, IEquatable<@IfcMechanicalConcreteMaterialProperties>
	{
		#region IIfcMechanicalConcreteMaterialProperties explicit implementation
		IfcPressureMeasure? IIfcMechanicalConcreteMaterialProperties.CompressiveStrength { 
 
			get { return @CompressiveStrength; } 
			set { CompressiveStrength = value;}
		}	
		IfcPositiveLengthMeasure? IIfcMechanicalConcreteMaterialProperties.MaxAggregateSize { 
 
			get { return @MaxAggregateSize; } 
			set { MaxAggregateSize = value;}
		}	
		IfcText? IIfcMechanicalConcreteMaterialProperties.AdmixturesDescription { 
 
			get { return @AdmixturesDescription; } 
			set { AdmixturesDescription = value;}
		}	
		IfcText? IIfcMechanicalConcreteMaterialProperties.Workability { 
 
			get { return @Workability; } 
			set { Workability = value;}
		}	
		IfcNormalisedRatioMeasure? IIfcMechanicalConcreteMaterialProperties.ProtectivePoreRatio { 
 
			get { return @ProtectivePoreRatio; } 
			set { ProtectivePoreRatio = value;}
		}	
		IfcText? IIfcMechanicalConcreteMaterialProperties.WaterImpermeability { 
 
			get { return @WaterImpermeability; } 
			set { WaterImpermeability = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMechanicalConcreteMaterialProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcPressureMeasure? _compressiveStrength;
		private IfcPositiveLengthMeasure? _maxAggregateSize;
		private IfcText? _admixturesDescription;
		private IfcText? _workability;
		private IfcNormalisedRatioMeasure? _protectivePoreRatio;
		private IfcText? _waterImpermeability;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcPressureMeasure? @CompressiveStrength 
		{ 
			get 
			{
				if(_activated) return _compressiveStrength;
				Activate();
				return _compressiveStrength;
			} 
			set
			{
				SetValue( v =>  _compressiveStrength = v, _compressiveStrength, value,  "CompressiveStrength", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 8)]
		public IfcPositiveLengthMeasure? @MaxAggregateSize 
		{ 
			get 
			{
				if(_activated) return _maxAggregateSize;
				Activate();
				return _maxAggregateSize;
			} 
			set
			{
				SetValue( v =>  _maxAggregateSize = v, _maxAggregateSize, value,  "MaxAggregateSize", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 9)]
		public IfcText? @AdmixturesDescription 
		{ 
			get 
			{
				if(_activated) return _admixturesDescription;
				Activate();
				return _admixturesDescription;
			} 
			set
			{
				SetValue( v =>  _admixturesDescription = v, _admixturesDescription, value,  "AdmixturesDescription", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 10)]
		public IfcText? @Workability 
		{ 
			get 
			{
				if(_activated) return _workability;
				Activate();
				return _workability;
			} 
			set
			{
				SetValue( v =>  _workability = v, _workability, value,  "Workability", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 11)]
		public IfcNormalisedRatioMeasure? @ProtectivePoreRatio 
		{ 
			get 
			{
				if(_activated) return _protectivePoreRatio;
				Activate();
				return _protectivePoreRatio;
			} 
			set
			{
				SetValue( v =>  _protectivePoreRatio = v, _protectivePoreRatio, value,  "ProtectivePoreRatio", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 12)]
		public IfcText? @WaterImpermeability 
		{ 
			get 
			{
				if(_activated) return _waterImpermeability;
				Activate();
				return _waterImpermeability;
			} 
			set
			{
				SetValue( v =>  _waterImpermeability = v, _waterImpermeability, value,  "WaterImpermeability", 12);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_compressiveStrength = value.RealVal;
					return;
				case 7: 
					_maxAggregateSize = value.RealVal;
					return;
				case 8: 
					_admixturesDescription = value.StringVal;
					return;
				case 9: 
					_workability = value.StringVal;
					return;
				case 10: 
					_protectivePoreRatio = value.RealVal;
					return;
				case 11: 
					_waterImpermeability = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMechanicalConcreteMaterialProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Material != null)
					yield return @Material;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}