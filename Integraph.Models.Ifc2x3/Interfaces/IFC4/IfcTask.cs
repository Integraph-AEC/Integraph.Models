// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Integraph.Models.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Integraph.Models.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Integraph.Models.Common;

// ReSharper disable once CheckNamespace
namespace Integraph.Models.Ifc2x3.ProcessExtension
{
	public partial class @IfcTask : IIfcTask
	{

		[CrossSchemaAttribute(typeof(IIfcTask), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcTask.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
			set
			{
				Status = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTask), 9)]
		Ifc4.MeasureResource.IfcLabel? IIfcTask.WorkMethod 
		{ 
			get
			{
				if (!WorkMethod.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(WorkMethod.Value);
			} 
			set
			{
				WorkMethod = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTask), 10)]
		Ifc4.MeasureResource.IfcBoolean IIfcTask.IsMilestone 
		{ 
			get
			{
				//## Handle return of IsMilestone for which no match was found
                return new Ifc4.MeasureResource.IfcBoolean(IsMilestone);
				//##
			} 
			set
			{
				IsMilestone = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTask), 11)]
		Ifc4.MeasureResource.IfcInteger? IIfcTask.Priority 
		{ 
			get
			{
				//## Handle return of Priority for which no match was found
                return Priority.HasValue ? new Ifc4.MeasureResource.IfcInteger(Priority.Value) : (Ifc4.MeasureResource.IfcInteger?)null;
				//##
			} 
			set
			{
				Priority = value;
				
			}
		}

		private  IIfcTaskTime _taskTime;


		[CrossSchemaAttribute(typeof(IIfcTask), 12)]
		IIfcTaskTime IIfcTask.TaskTime 
		{ 
			get
			{
				return _taskTime;
			} 
			set
			{
				SetValue(v => _taskTime = v, _taskTime, value, "TaskTime", -12);
				
			}
		}

		private  Ifc4.Interfaces.IfcTaskTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcTask), 13)]
		Ifc4.Interfaces.IfcTaskTypeEnum? IIfcTask.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -13);
				
			}
		}
	//## Custom code
	//##
	}
}