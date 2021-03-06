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
namespace Integraph.Models.Ifc2x3.Kernel
{
	public partial class @IfcRelSequence : IIfcRelSequence
	{

		[CrossSchemaAttribute(typeof(IIfcRelSequence), 5)]
		IIfcProcess IIfcRelSequence.RelatingProcess 
		{ 
			get
			{
				return RelatingProcess;
			} 
			set
			{
				RelatingProcess = value as IfcProcess;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelSequence), 6)]
		IIfcProcess IIfcRelSequence.RelatedProcess 
		{ 
			get
			{
				return RelatedProcess;
			} 
			set
			{
				RelatedProcess = value as IfcProcess;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelSequence), 7)]
		IIfcLagTime IIfcRelSequence.TimeLag 
		{ 
			get
			{
				//## Handle return of TimeLag for which no match was found
			    return new Interfaces.Conversions.IfcLagTimeTransient(TimeLag.ToISODateTimeString());
				//##
			} 
			set
			{
				//## Handle setting of TimeLag for which no match was found
				throw new System.PlatformNotSupportedException();
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelSequence), 8)]
		Ifc4.Interfaces.IfcSequenceEnum? IIfcRelSequence.SequenceType 
		{ 
			get
			{
				//## Custom code to handle enumeration of SequenceType
			    if (_sequenceType4.HasValue)
			        return _sequenceType4;
				//##
				switch (SequenceType)
				{
					case IfcSequenceEnum.START_START:
						return Ifc4.Interfaces.IfcSequenceEnum.START_START;
					case IfcSequenceEnum.START_FINISH:
						return Ifc4.Interfaces.IfcSequenceEnum.START_FINISH;
					case IfcSequenceEnum.FINISH_START:
						return Ifc4.Interfaces.IfcSequenceEnum.FINISH_START;
					case IfcSequenceEnum.FINISH_FINISH:
						return Ifc4.Interfaces.IfcSequenceEnum.FINISH_FINISH;
					case IfcSequenceEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSequenceEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of SequenceType
			    if (_sequenceType4.HasValue && value != Ifc4.Interfaces.IfcSequenceEnum.USERDEFINED)
			    {
                    SetValue(v => _sequenceType4 = v, _sequenceType4, null, "SequenceType", -8);
			    }
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcSequenceEnum.START_START:
						SequenceType = IfcSequenceEnum.START_START;
						return;
					case Ifc4.Interfaces.IfcSequenceEnum.START_FINISH:
						SequenceType = IfcSequenceEnum.START_FINISH;
						return;
					case Ifc4.Interfaces.IfcSequenceEnum.FINISH_START:
						SequenceType = IfcSequenceEnum.FINISH_START;
						return;
					case Ifc4.Interfaces.IfcSequenceEnum.FINISH_FINISH:
						SequenceType = IfcSequenceEnum.FINISH_FINISH;
						return;
					case Ifc4.Interfaces.IfcSequenceEnum.USERDEFINED:
						//## Handle setting of USERDEFINED member from IfcSequenceEnum in property SequenceType
                        SequenceType = IfcSequenceEnum.NOTDEFINED;
						SetValue(v => _sequenceType4 = v, _sequenceType4, value, "SequenceType", -8);
				        return;
						//##
										case Ifc4.Interfaces.IfcSequenceEnum.NOTDEFINED:
						SequenceType = IfcSequenceEnum.NOTDEFINED;
						return;
					case null:
						SequenceType = IfcSequenceEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		private  Ifc4.MeasureResource.IfcLabel? _userDefinedSequenceType;


		[CrossSchemaAttribute(typeof(IIfcRelSequence), 9)]
		Ifc4.MeasureResource.IfcLabel? IIfcRelSequence.UserDefinedSequenceType 
		{ 
			get
			{
				return _userDefinedSequenceType;
			} 
			set
			{
				SetValue(v => _userDefinedSequenceType = v, _userDefinedSequenceType, value, "UserDefinedSequenceType", -9);
				
			}
		}
	//## Custom code
	    private Ifc4.Interfaces.IfcSequenceEnum? _sequenceType4;
	    //##
	}
}