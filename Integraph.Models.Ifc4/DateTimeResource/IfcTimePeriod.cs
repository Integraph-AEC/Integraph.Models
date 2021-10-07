// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Integraph.Models.Common.Metadata;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc4.Interfaces;
using Integraph.Models.Ifc4.DateTimeResource;
//## Custom using statements
//##

namespace Integraph.Models.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTimePeriod
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTimePeriod : IPersistEntity
	{
		IfcTime @StartTime { get;  set; }
		IfcTime @EndTime { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.DateTimeResource
{
	[ExpressType("IfcTimePeriod", 1302)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTimePeriod : PersistEntity, IInstantiableEntity, IIfcTimePeriod, IEquatable<@IfcTimePeriod>
	{
		#region IIfcTimePeriod explicit implementation
		IfcTime IIfcTimePeriod.StartTime { 
 
			get { return @StartTime; } 
			set { StartTime = value;}
		}	
		IfcTime IIfcTimePeriod.EndTime { 
 
			get { return @EndTime; } 
			set { EndTime = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTimePeriod(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcTime _startTime;
		private IfcTime _endTime;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcTime @StartTime 
		{ 
			get 
			{
				if(_activated) return _startTime;
				Activate();
				return _startTime;
			} 
			set
			{
				SetValue( v =>  _startTime = v, _startTime, value,  "StartTime", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcTime @EndTime 
		{ 
			get 
			{
				if(_activated) return _endTime;
				Activate();
				return _endTime;
			} 
			set
			{
				SetValue( v =>  _endTime = v, _endTime, value,  "EndTime", 2);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_startTime = value.StringVal;
					return;
				case 1: 
					_endTime = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTimePeriod other)
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