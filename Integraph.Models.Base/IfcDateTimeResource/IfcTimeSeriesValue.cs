// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcDateTimeResource
{
	public partial class IfcTimeSeriesValue
	{
		[DataMember(Order = 0)] 
		[Description("A list of time-series values. At least one value is required.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcValue> ListValues { get; protected set; }
	
	
		public IfcTimeSeriesValue(IfcValue[] __ListValues)
		{
			this.ListValues = new List<IfcValue>(__ListValues);
		}
	
	
	}
	
}
