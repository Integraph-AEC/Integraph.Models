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
namespace Integraph.Models.Ifc2x3.ControlExtension
{
	public partial class @IfcPerformanceHistory : IIfcPerformanceHistory
	{

		[CrossSchemaAttribute(typeof(IIfcPerformanceHistory), 7)]
		Ifc4.MeasureResource.IfcLabel IIfcPerformanceHistory.LifeCyclePhase 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(LifeCyclePhase);
			} 
			set
			{
				LifeCyclePhase = new MeasureResource.IfcLabel(value);
				
			}
		}

		private  Ifc4.Interfaces.IfcPerformanceHistoryTypeEnum? _predefinedType;


		[CrossSchemaAttribute(typeof(IIfcPerformanceHistory), 8)]
		Ifc4.Interfaces.IfcPerformanceHistoryTypeEnum? IIfcPerformanceHistory.PredefinedType 
		{ 
			get
			{
				return _predefinedType;
			} 
			set
			{
				SetValue(v => _predefinedType = v, _predefinedType, value, "PredefinedType", -8);
				
			}
		}
	//## Custom code
	//##
	}
}