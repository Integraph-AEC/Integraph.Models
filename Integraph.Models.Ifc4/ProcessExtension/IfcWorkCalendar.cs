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
using Integraph.Models.Ifc4.DateTimeResource;
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
    /// Readonly interface for IfcWorkCalendar
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcWorkCalendar : IIfcControl
	{
		IItemSet<IIfcWorkTime> @WorkingTimes { get; }
		IItemSet<IIfcWorkTime> @ExceptionTimes { get; }
		IfcWorkCalendarTypeEnum? @PredefinedType { get;  set; }
	
	}
}

namespace Integraph.Models.Ifc4.ProcessExtension
{
	[ExpressType("IfcWorkCalendar", 1318)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcWorkCalendar : IfcControl, IInstantiableEntity, IIfcWorkCalendar, IContainsEntityReferences, IEquatable<@IfcWorkCalendar>
	{
		#region IIfcWorkCalendar explicit implementation
		IItemSet<IIfcWorkTime> IIfcWorkCalendar.WorkingTimes { 
			get { return new Common.Collections.ProxyItemSet<IfcWorkTime, IIfcWorkTime>( @WorkingTimes); } 
		}	
		IItemSet<IIfcWorkTime> IIfcWorkCalendar.ExceptionTimes { 
			get { return new Common.Collections.ProxyItemSet<IfcWorkTime, IIfcWorkTime>( @ExceptionTimes); } 
		}	
		IfcWorkCalendarTypeEnum? IIfcWorkCalendar.PredefinedType { 
 
			get { return @PredefinedType; } 
			set { PredefinedType = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcWorkCalendar(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_workingTimes = new OptionalItemSet<IfcWorkTime>( this, 0,  7);
			_exceptionTimes = new OptionalItemSet<IfcWorkTime>( this, 0,  8);
		}

		#region Explicit attribute fields
		private readonly OptionalItemSet<IfcWorkTime> _workingTimes;
		private readonly OptionalItemSet<IfcWorkTime> _exceptionTimes;
		private IfcWorkCalendarTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 19)]
		public IOptionalItemSet<IfcWorkTime> @WorkingTimes 
		{ 
			get 
			{
				if(_activated) return _workingTimes;
				Activate();
				return _workingTimes;
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 20)]
		public IOptionalItemSet<IfcWorkTime> @ExceptionTimes 
		{ 
			get 
			{
				if(_activated) return _exceptionTimes;
				Activate();
				return _exceptionTimes;
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 21)]
		public IfcWorkCalendarTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 9);
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
					_workingTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 7: 
					_exceptionTimes.InternalAdd((IfcWorkTime)value.EntityVal);
					return;
				case 8: 
                    _predefinedType = (IfcWorkCalendarTypeEnum) System.Enum.Parse(typeof (IfcWorkCalendarTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcWorkCalendar other)
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
				foreach(var entity in @WorkingTimes)
					yield return entity;
				foreach(var entity in @ExceptionTimes)
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