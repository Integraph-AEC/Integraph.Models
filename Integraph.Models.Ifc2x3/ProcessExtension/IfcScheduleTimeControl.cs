// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.DateTimeResource;
using Integraph.Models.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;
using Integraph.Models.Common.Exceptions;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.ProcessExtension;
//## Custom using statements
//##

namespace Integraph.Models.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcScheduleTimeControl
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcScheduleTimeControl : IIfcControl
	{
		IIfcDateTimeSelect @ActualStart { get;  set; }
		IIfcDateTimeSelect @EarlyStart { get;  set; }
		IIfcDateTimeSelect @LateStart { get;  set; }
		IIfcDateTimeSelect @ScheduleStart { get;  set; }
		IIfcDateTimeSelect @ActualFinish { get;  set; }
		IIfcDateTimeSelect @EarlyFinish { get;  set; }
		IIfcDateTimeSelect @LateFinish { get;  set; }
		IIfcDateTimeSelect @ScheduleFinish { get;  set; }
		IfcTimeMeasure? @ScheduleDuration { get;  set; }
		IfcTimeMeasure? @ActualDuration { get;  set; }
		IfcTimeMeasure? @RemainingTime { get;  set; }
		IfcTimeMeasure? @FreeFloat { get;  set; }
		IfcTimeMeasure? @TotalFloat { get;  set; }
		bool? @IsCritical { get;  set; }
		IIfcDateTimeSelect @StatusTime { get;  set; }
		IfcTimeMeasure? @StartFloat { get;  set; }
		IfcTimeMeasure? @FinishFloat { get;  set; }
		IfcPositiveRatioMeasure? @Completion { get;  set; }
		IIfcRelAssignsTasks @ScheduleTimeControlAssigned {  get; }
	
	}
}

namespace Integraph.Models.Ifc2x3.ProcessExtension
{
	[ExpressType("IfcScheduleTimeControl", 402)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcScheduleTimeControl : IfcControl, IInstantiableEntity, IIfcScheduleTimeControl, IContainsEntityReferences, IEquatable<@IfcScheduleTimeControl>
	{
		#region IIfcScheduleTimeControl explicit implementation
		IIfcDateTimeSelect IIfcScheduleTimeControl.ActualStart { 
 
 
			get { return @ActualStart; } 
			set { ActualStart = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.EarlyStart { 
 
 
			get { return @EarlyStart; } 
			set { EarlyStart = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.LateStart { 
 
 
			get { return @LateStart; } 
			set { LateStart = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ScheduleStart { 
 
 
			get { return @ScheduleStart; } 
			set { ScheduleStart = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ActualFinish { 
 
 
			get { return @ActualFinish; } 
			set { ActualFinish = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.EarlyFinish { 
 
 
			get { return @EarlyFinish; } 
			set { EarlyFinish = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.LateFinish { 
 
 
			get { return @LateFinish; } 
			set { LateFinish = value as IfcDateTimeSelect;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.ScheduleFinish { 
 
 
			get { return @ScheduleFinish; } 
			set { ScheduleFinish = value as IfcDateTimeSelect;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.ScheduleDuration { 
 
			get { return @ScheduleDuration; } 
			set { ScheduleDuration = value;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.ActualDuration { 
 
			get { return @ActualDuration; } 
			set { ActualDuration = value;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.RemainingTime { 
 
			get { return @RemainingTime; } 
			set { RemainingTime = value;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.FreeFloat { 
 
			get { return @FreeFloat; } 
			set { FreeFloat = value;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.TotalFloat { 
 
			get { return @TotalFloat; } 
			set { TotalFloat = value;}
		}	
		bool? IIfcScheduleTimeControl.IsCritical { 
 
			get { return @IsCritical; } 
			set { IsCritical = value;}
		}	
		IIfcDateTimeSelect IIfcScheduleTimeControl.StatusTime { 
 
 
			get { return @StatusTime; } 
			set { StatusTime = value as IfcDateTimeSelect;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.StartFloat { 
 
			get { return @StartFloat; } 
			set { StartFloat = value;}
		}	
		IfcTimeMeasure? IIfcScheduleTimeControl.FinishFloat { 
 
			get { return @FinishFloat; } 
			set { FinishFloat = value;}
		}	
		IfcPositiveRatioMeasure? IIfcScheduleTimeControl.Completion { 
 
			get { return @Completion; } 
			set { Completion = value;}
		}	
		 
		IIfcRelAssignsTasks IIfcScheduleTimeControl.ScheduleTimeControlAssigned {  get { return @ScheduleTimeControlAssigned; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcScheduleTimeControl(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDateTimeSelect _actualStart;
		private IfcDateTimeSelect _earlyStart;
		private IfcDateTimeSelect _lateStart;
		private IfcDateTimeSelect _scheduleStart;
		private IfcDateTimeSelect _actualFinish;
		private IfcDateTimeSelect _earlyFinish;
		private IfcDateTimeSelect _lateFinish;
		private IfcDateTimeSelect _scheduleFinish;
		private IfcTimeMeasure? _scheduleDuration;
		private IfcTimeMeasure? _actualDuration;
		private IfcTimeMeasure? _remainingTime;
		private IfcTimeMeasure? _freeFloat;
		private IfcTimeMeasure? _totalFloat;
		private bool? _isCritical;
		private IfcDateTimeSelect _statusTime;
		private IfcTimeMeasure? _startFloat;
		private IfcTimeMeasure? _finishFloat;
		private IfcPositiveRatioMeasure? _completion;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcDateTimeSelect @ActualStart 
		{ 
			get 
			{
				if(_activated) return _actualStart;
				Activate();
				return _actualStart;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _actualStart = v, _actualStart, value,  "ActualStart", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 13)]
		public IfcDateTimeSelect @EarlyStart 
		{ 
			get 
			{
				if(_activated) return _earlyStart;
				Activate();
				return _earlyStart;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _earlyStart = v, _earlyStart, value,  "EarlyStart", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 14)]
		public IfcDateTimeSelect @LateStart 
		{ 
			get 
			{
				if(_activated) return _lateStart;
				Activate();
				return _lateStart;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lateStart = v, _lateStart, value,  "LateStart", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 15)]
		public IfcDateTimeSelect @ScheduleStart 
		{ 
			get 
			{
				if(_activated) return _scheduleStart;
				Activate();
				return _scheduleStart;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _scheduleStart = v, _scheduleStart, value,  "ScheduleStart", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 16)]
		public IfcDateTimeSelect @ActualFinish 
		{ 
			get 
			{
				if(_activated) return _actualFinish;
				Activate();
				return _actualFinish;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _actualFinish = v, _actualFinish, value,  "ActualFinish", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 17)]
		public IfcDateTimeSelect @EarlyFinish 
		{ 
			get 
			{
				if(_activated) return _earlyFinish;
				Activate();
				return _earlyFinish;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _earlyFinish = v, _earlyFinish, value,  "EarlyFinish", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 18)]
		public IfcDateTimeSelect @LateFinish 
		{ 
			get 
			{
				if(_activated) return _lateFinish;
				Activate();
				return _lateFinish;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _lateFinish = v, _lateFinish, value,  "LateFinish", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 19)]
		public IfcDateTimeSelect @ScheduleFinish 
		{ 
			get 
			{
				if(_activated) return _scheduleFinish;
				Activate();
				return _scheduleFinish;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _scheduleFinish = v, _scheduleFinish, value,  "ScheduleFinish", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 20)]
		public IfcTimeMeasure? @ScheduleDuration 
		{ 
			get 
			{
				if(_activated) return _scheduleDuration;
				Activate();
				return _scheduleDuration;
			} 
			set
			{
				SetValue( v =>  _scheduleDuration = v, _scheduleDuration, value,  "ScheduleDuration", 14);
			} 
		}	
		[EntityAttribute(15, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 21)]
		public IfcTimeMeasure? @ActualDuration 
		{ 
			get 
			{
				if(_activated) return _actualDuration;
				Activate();
				return _actualDuration;
			} 
			set
			{
				SetValue( v =>  _actualDuration = v, _actualDuration, value,  "ActualDuration", 15);
			} 
		}	
		[EntityAttribute(16, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 22)]
		public IfcTimeMeasure? @RemainingTime 
		{ 
			get 
			{
				if(_activated) return _remainingTime;
				Activate();
				return _remainingTime;
			} 
			set
			{
				SetValue( v =>  _remainingTime = v, _remainingTime, value,  "RemainingTime", 16);
			} 
		}	
		[EntityAttribute(17, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 23)]
		public IfcTimeMeasure? @FreeFloat 
		{ 
			get 
			{
				if(_activated) return _freeFloat;
				Activate();
				return _freeFloat;
			} 
			set
			{
				SetValue( v =>  _freeFloat = v, _freeFloat, value,  "FreeFloat", 17);
			} 
		}	
		[EntityAttribute(18, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 24)]
		public IfcTimeMeasure? @TotalFloat 
		{ 
			get 
			{
				if(_activated) return _totalFloat;
				Activate();
				return _totalFloat;
			} 
			set
			{
				SetValue( v =>  _totalFloat = v, _totalFloat, value,  "TotalFloat", 18);
			} 
		}	
		[EntityAttribute(19, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 25)]
		public bool? @IsCritical 
		{ 
			get 
			{
				if(_activated) return _isCritical;
				Activate();
				return _isCritical;
			} 
			set
			{
				SetValue( v =>  _isCritical = v, _isCritical, value,  "IsCritical", 19);
			} 
		}	
		[EntityAttribute(20, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 26)]
		public IfcDateTimeSelect @StatusTime 
		{ 
			get 
			{
				if(_activated) return _statusTime;
				Activate();
				return _statusTime;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _statusTime = v, _statusTime, value,  "StatusTime", 20);
			} 
		}	
		[EntityAttribute(21, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcTimeMeasure? @StartFloat 
		{ 
			get 
			{
				if(_activated) return _startFloat;
				Activate();
				return _startFloat;
			} 
			set
			{
				SetValue( v =>  _startFloat = v, _startFloat, value,  "StartFloat", 21);
			} 
		}	
		[EntityAttribute(22, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 28)]
		public IfcTimeMeasure? @FinishFloat 
		{ 
			get 
			{
				if(_activated) return _finishFloat;
				Activate();
				return _finishFloat;
			} 
			set
			{
				SetValue( v =>  _finishFloat = v, _finishFloat, value,  "FinishFloat", 22);
			} 
		}	
		[EntityAttribute(23, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 29)]
		public IfcPositiveRatioMeasure? @Completion 
		{ 
			get 
			{
				if(_activated) return _completion;
				Activate();
				return _completion;
			} 
			set
			{
				SetValue( v =>  _completion = v, _completion, value,  "Completion", 23);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("TimeForTask")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, null, null, 30)]
		public IfcRelAssignsTasks @ScheduleTimeControlAssigned 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcRelAssignsTasks>(e => Equals(e.TimeForTask), "TimeForTask", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_actualStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 6: 
					_earlyStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 7: 
					_lateStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 8: 
					_scheduleStart = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 9: 
					_actualFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 10: 
					_earlyFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 11: 
					_lateFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 12: 
					_scheduleFinish = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 13: 
					_scheduleDuration = value.RealVal;
					return;
				case 14: 
					_actualDuration = value.RealVal;
					return;
				case 15: 
					_remainingTime = value.RealVal;
					return;
				case 16: 
					_freeFloat = value.RealVal;
					return;
				case 17: 
					_totalFloat = value.RealVal;
					return;
				case 18: 
					_isCritical = value.BooleanVal;
					return;
				case 19: 
					_statusTime = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 20: 
					_startFloat = value.RealVal;
					return;
				case 21: 
					_finishFloat = value.RealVal;
					return;
				case 22: 
					_completion = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcScheduleTimeControl other)
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
				if (@ActualStart != null)
					yield return @ActualStart;
				if (@EarlyStart != null)
					yield return @EarlyStart;
				if (@LateStart != null)
					yield return @LateStart;
				if (@ScheduleStart != null)
					yield return @ScheduleStart;
				if (@ActualFinish != null)
					yield return @ActualFinish;
				if (@EarlyFinish != null)
					yield return @EarlyFinish;
				if (@LateFinish != null)
					yield return @LateFinish;
				if (@ScheduleFinish != null)
					yield return @ScheduleFinish;
				if (@StatusTime != null)
					yield return @StatusTime;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}