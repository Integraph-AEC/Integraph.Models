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
using Integraph.Models.Ifc4.ProcessExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTaskType
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTaskType : IIfcTypeProcess
	{
		IfcTaskTypeEnum @PredefinedType { get;  set; }
		IfcLabel? @WorkMethod { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.ProcessExtension
{
	[ExpressType("IfcTaskType", 1296)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTaskType : IfcTypeProcess, IInstantiableEntity, IIfcTaskType, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTaskType>
	{
		#region IIfcTaskType explicit implementation
		IfcTaskTypeEnum IIfcTaskType.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		IfcLabel? IIfcTaskType.WorkMethod { 
 
			get { return @WorkMethod; } 
			set { WorkMethod = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTaskType(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTaskTypeEnum _predefinedType;
		private IfcLabel? _workMethod;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcTaskTypeEnum @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcLabel? @WorkMethod 
		{ 
			get 
			{
				if(_activated) return _workMethod;
				Activate();
				return _workMethod;
			} 
			set
			{
				SetValue( v =>  _workMethod = v, _workMethod, value,  "WorkMethod", 11);
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
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
                    _predefinedType = (IfcTaskTypeEnum) System.Enum.Parse(typeof (IfcTaskTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_workMethod = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTaskType other)
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