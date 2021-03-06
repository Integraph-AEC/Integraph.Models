// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.DateTimeResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.TimeSeriesResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcIrregularTimeSeriesValue
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcIrregularTimeSeriesValue : IPersistEntity
	{
		IIfcDateTimeSelect @TimeStamp { get;  set; }
		IItemSet<IIfcValue> @ListValues { get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.TimeSeriesResource
{
	[ExpressType("IfcIrregularTimeSeriesValue", 609)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIrregularTimeSeriesValue : PersistEntity, IInstantiableEntity, IIfcIrregularTimeSeriesValue, IContainsEntityReferences, IEquatable<@IfcIrregularTimeSeriesValue>
	{
		#region IIfcIrregularTimeSeriesValue explicit implementation
		IIfcDateTimeSelect IIfcIrregularTimeSeriesValue.TimeStamp { 
 
 
			get { return @TimeStamp; } 
			set { TimeStamp = value as IfcDateTimeSelect;}
		}	
		IItemSet<IIfcValue> IIfcIrregularTimeSeriesValue.ListValues { 
			get { return new Common.Collections.ProxyItemSet<IfcValue, IIfcValue>( @ListValues); } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIrregularTimeSeriesValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_listValues = new ItemSet<IfcValue>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcDateTimeSelect _timeStamp;
		private readonly ItemSet<IfcValue> _listValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 1)]
		public IfcDateTimeSelect @TimeStamp 
		{ 
			get 
			{
				if(_activated) return _timeStamp;
				Activate();
				return _timeStamp;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _timeStamp = v, _timeStamp, value,  "TimeStamp", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcValue> @ListValues 
		{ 
			get 
			{
				if(_activated) return _listValues;
				Activate();
				return _listValues;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_timeStamp = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 1: 
					_listValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIrregularTimeSeriesValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@TimeStamp != null)
					yield return @TimeStamp;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}