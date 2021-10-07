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
namespace Integraph.Models.Ifc2x3.GeometryResource
{
	public partial class @IfcTrimmedCurve : IIfcTrimmedCurve
	{

		[CrossSchemaAttribute(typeof(IIfcTrimmedCurve), 1)]
		IIfcCurve IIfcTrimmedCurve.BasisCurve 
		{ 
			get
			{
				return BasisCurve;
			} 
			set
			{
				BasisCurve = value as IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrimmedCurve), 2)]
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim1 
		{ 
			get
			{
			
				return _trim1Ifc4 ?? (_trim1Ifc4 = new Common.Collections.ExtendedItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>(
                    Trim1, 
                    new ItemSet<IIfcTrimmingSelect>(this, 0, -2), 
					Trim1ToIfc4, 
                    Trim1ToIfc2X3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcTrimmingSelect> _trim1Ifc4;
		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private static IIfcTrimmingSelect Trim1ToIfc4 (IfcTrimmingSelect member)
		{
			if (member == null) 
				return null;
			switch (member.GetType().Name)
			{
				case "IfcCartesianPoint":
					return member as IfcCartesianPoint;
				case "IfcParameterValue":
					return new Ifc4.MeasureResource.IfcParameterValue((MeasureResource.IfcParameterValue)member);
				default:
					throw new System.NotSupportedException();
			}
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private static IfcTrimmingSelect Trim1ToIfc2X3 (IIfcTrimmingSelect member){
			if (member == null) 
				return null;
			var name = member.GetType().Name;
			switch (name)
			{
				case "IfcCartesianPoint":
					return member as IfcCartesianPoint;
				case "IfcParameterValue":
					return new MeasureResource.IfcParameterValue((Ifc4.MeasureResource.IfcParameterValue)member);
				default:
					throw new System.NotSupportedException();
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrimmedCurve), 3)]
		IItemSet<IIfcTrimmingSelect> IIfcTrimmedCurve.Trim2 
		{ 
			get
			{
			
				return _trim2Ifc4 ?? (_trim2Ifc4 = new Common.Collections.ExtendedItemSet<IfcTrimmingSelect, IIfcTrimmingSelect>(
                    Trim2, 
                    new ItemSet<IIfcTrimmingSelect>(this, 0, -3), 
					Trim2ToIfc4, 
                    Trim2ToIfc2X3));
			} 
		}

		//private field to hold any extended data
		private IItemSet<IIfcTrimmingSelect> _trim2Ifc4;
		//transformation function to convert/cast IFC2x3 data to appear as IFC4
		private static IIfcTrimmingSelect Trim2ToIfc4 (IfcTrimmingSelect member)
		{
			if (member == null) 
				return null;
			switch (member.GetType().Name)
			{
				case "IfcCartesianPoint":
					return member as IfcCartesianPoint;
				case "IfcParameterValue":
					return new Ifc4.MeasureResource.IfcParameterValue((MeasureResource.IfcParameterValue)member);
				default:
					throw new System.NotSupportedException();
			}
		}

		//transformation function to convert/cast IFC4 data to appear as IFC2x3 if possible
		private static IfcTrimmingSelect Trim2ToIfc2X3 (IIfcTrimmingSelect member){
			if (member == null) 
				return null;
			var name = member.GetType().Name;
			switch (name)
			{
				case "IfcCartesianPoint":
					return member as IfcCartesianPoint;
				case "IfcParameterValue":
					return new MeasureResource.IfcParameterValue((Ifc4.MeasureResource.IfcParameterValue)member);
				default:
					throw new System.NotSupportedException();
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrimmedCurve), 4)]
		Ifc4.MeasureResource.IfcBoolean IIfcTrimmedCurve.SenseAgreement 
		{ 
			get
			{
				//## Handle return of SenseAgreement for which no match was found
			    return new Ifc4.MeasureResource.IfcBoolean(SenseAgreement);
			    //##
			} 
			set
			{
				SenseAgreement = value;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcTrimmedCurve), 5)]
		Ifc4.Interfaces.IfcTrimmingPreference IIfcTrimmedCurve.MasterRepresentation 
		{ 
			get
			{
				//## Custom code to handle enumeration of MasterRepresentation
				//##
				switch (MasterRepresentation)
				{
					case IfcTrimmingPreference.CARTESIAN:
						return Ifc4.Interfaces.IfcTrimmingPreference.CARTESIAN;
					case IfcTrimmingPreference.PARAMETER:
						return Ifc4.Interfaces.IfcTrimmingPreference.PARAMETER;
					case IfcTrimmingPreference.UNSPECIFIED:
						return Ifc4.Interfaces.IfcTrimmingPreference.UNSPECIFIED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of MasterRepresentation
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTrimmingPreference.CARTESIAN:
						MasterRepresentation = IfcTrimmingPreference.CARTESIAN;
						return;
					case Ifc4.Interfaces.IfcTrimmingPreference.PARAMETER:
						MasterRepresentation = IfcTrimmingPreference.PARAMETER;
						return;
					case Ifc4.Interfaces.IfcTrimmingPreference.UNSPECIFIED:
						MasterRepresentation = IfcTrimmingPreference.UNSPECIFIED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}