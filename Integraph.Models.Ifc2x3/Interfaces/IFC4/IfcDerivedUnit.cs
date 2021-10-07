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
namespace Integraph.Models.Ifc2x3.MeasureResource
{
	public partial class @IfcDerivedUnit : IIfcDerivedUnit
	{

		[CrossSchemaAttribute(typeof(IIfcDerivedUnit), 1)]
		IItemSet<IIfcDerivedUnitElement> IIfcDerivedUnit.Elements 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcDerivedUnitElement, IIfcDerivedUnitElement>(Elements);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcDerivedUnit), 2)]
		Ifc4.Interfaces.IfcDerivedUnitEnum IIfcDerivedUnit.UnitType 
		{ 
			get
			{
				//## Custom code to handle enumeration of UnitType
				//##
				switch (UnitType)
				{
					case IfcDerivedUnitEnum.ANGULARVELOCITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ANGULARVELOCITYUNIT;
					case IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT;
					case IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT;
					case IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT;
					case IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT;
					case IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT;
					case IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT;
					case IfcDerivedUnitEnum.LINEARVELOCITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARVELOCITYUNIT;
					case IfcDerivedUnitEnum.MASSDENSITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSDENSITYUNIT;
					case IfcDerivedUnitEnum.MASSFLOWRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSFLOWRATEUNIT;
					case IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT;
					case IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT;
					case IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT;
					case IfcDerivedUnitEnum.THERMALADMITTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALADMITTANCEUNIT;
					case IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT;
					case IfcDerivedUnitEnum.THERMALRESISTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALRESISTANCEUNIT;
					case IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT;
					case IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT;
					case IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT;
					case IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT;
					case IfcDerivedUnitEnum.TORQUEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.TORQUEUNIT;
					case IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT;
					case IfcDerivedUnitEnum.LINEARMOMENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARMOMENTUNIT;
					case IfcDerivedUnitEnum.LINEARFORCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARFORCEUNIT;
					case IfcDerivedUnitEnum.PLANARFORCEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.PLANARFORCEUNIT;
					case IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT;
					case IfcDerivedUnitEnum.SHEARMODULUSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SHEARMODULUSUNIT;
					case IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT;
					case IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT;
					case IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT;
					case IfcDerivedUnitEnum.ACCELERATIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ACCELERATIONUNIT;
					case IfcDerivedUnitEnum.CURVATUREUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.CURVATUREUNIT;
					case IfcDerivedUnitEnum.HEATINGVALUEUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.HEATINGVALUEUNIT;
					case IfcDerivedUnitEnum.IONCONCENTRATIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.IONCONCENTRATIONUNIT;
					case IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT;
					case IfcDerivedUnitEnum.MASSPERLENGTHUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MASSPERLENGTHUNIT;
					case IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT;
					case IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT;
					case IfcDerivedUnitEnum.PHUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.PHUNIT;
					case IfcDerivedUnitEnum.ROTATIONALMASSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALMASSUNIT;
					case IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT;
					case IfcDerivedUnitEnum.SECTIONMODULUSUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONMODULUSUNIT;
					case IfcDerivedUnitEnum.SOUNDPOWERUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPOWERUNIT;
					case IfcDerivedUnitEnum.SOUNDPRESSUREUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPRESSUREUNIT;
					case IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT;
					case IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT;
					case IfcDerivedUnitEnum.WARPINGCONSTANTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGCONSTANTUNIT;
					case IfcDerivedUnitEnum.WARPINGMOMENTUNIT:
						return Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGMOMENTUNIT;
					case IfcDerivedUnitEnum.USERDEFINED:
						//## Optional custom handling of UnitType == .USERDEFINED. 
                        if (UserDefinedType.HasValue)
                            switch (UserDefinedType.Value)
                            {
                                case "AREADENSITYUNIT":
                                case "SOUNDPOWERLEVELUNIT":
                                case "SOUNDPRESSURELEVELUNIT":
                                case "TEMPERATURERATEOFCHANGEUNIT":
                                    return (Ifc4.Interfaces.IfcDerivedUnitEnum)
                                        System.Enum.Parse(typeof(Ifc4.Interfaces.IfcDerivedUnitEnum), UserDefinedType.Value);
                            }
						//##
						return Ifc4.Interfaces.IfcDerivedUnitEnum.USERDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of UnitType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ANGULARVELOCITYUNIT:
						UnitType = IfcDerivedUnitEnum.ANGULARVELOCITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.AREADENSITYUNIT:
						//## Handle setting of AREADENSITYUNIT member from IfcDerivedUnitEnum in property UnitType
				        UserDefinedType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcDerivedUnitEnum), value);
	                    UnitType = IfcDerivedUnitEnum.USERDEFINED;
				        return;
						//##
										case Ifc4.Interfaces.IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT:
						UnitType = IfcDerivedUnitEnum.COMPOUNDPLANEANGLEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT:
						UnitType = IfcDerivedUnitEnum.DYNAMICVISCOSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT:
						UnitType = IfcDerivedUnitEnum.HEATFLUXDENSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT:
						UnitType = IfcDerivedUnitEnum.INTEGERCOUNTRATEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT:
						UnitType = IfcDerivedUnitEnum.ISOTHERMALMOISTURECAPACITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT:
						UnitType = IfcDerivedUnitEnum.KINEMATICVISCOSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARVELOCITYUNIT:
						UnitType = IfcDerivedUnitEnum.LINEARVELOCITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MASSDENSITYUNIT:
						UnitType = IfcDerivedUnitEnum.MASSDENSITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MASSFLOWRATEUNIT:
						UnitType = IfcDerivedUnitEnum.MASSFLOWRATEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT:
						UnitType = IfcDerivedUnitEnum.MOISTUREDIFFUSIVITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT:
						UnitType = IfcDerivedUnitEnum.MOLECULARWEIGHTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT:
						UnitType = IfcDerivedUnitEnum.SPECIFICHEATCAPACITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALADMITTANCEUNIT:
						UnitType = IfcDerivedUnitEnum.THERMALADMITTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT:
						UnitType = IfcDerivedUnitEnum.THERMALCONDUCTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALRESISTANCEUNIT:
						UnitType = IfcDerivedUnitEnum.THERMALRESISTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT:
						UnitType = IfcDerivedUnitEnum.THERMALTRANSMITTANCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT:
						UnitType = IfcDerivedUnitEnum.VAPORPERMEABILITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT:
						UnitType = IfcDerivedUnitEnum.VOLUMETRICFLOWRATEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT:
						UnitType = IfcDerivedUnitEnum.ROTATIONALFREQUENCYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.TORQUEUNIT:
						UnitType = IfcDerivedUnitEnum.TORQUEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT:
						UnitType = IfcDerivedUnitEnum.MOMENTOFINERTIAUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARMOMENTUNIT:
						UnitType = IfcDerivedUnitEnum.LINEARMOMENTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARFORCEUNIT:
						UnitType = IfcDerivedUnitEnum.LINEARFORCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.PLANARFORCEUNIT:
						UnitType = IfcDerivedUnitEnum.PLANARFORCEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT:
						UnitType = IfcDerivedUnitEnum.MODULUSOFELASTICITYUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SHEARMODULUSUNIT:
						UnitType = IfcDerivedUnitEnum.SHEARMODULUSUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT:
						UnitType = IfcDerivedUnitEnum.LINEARSTIFFNESSUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT:
						UnitType = IfcDerivedUnitEnum.ROTATIONALSTIFFNESSUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT:
						UnitType = IfcDerivedUnitEnum.MODULUSOFSUBGRADEREACTIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ACCELERATIONUNIT:
						UnitType = IfcDerivedUnitEnum.ACCELERATIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.CURVATUREUNIT:
						UnitType = IfcDerivedUnitEnum.CURVATUREUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.HEATINGVALUEUNIT:
						UnitType = IfcDerivedUnitEnum.HEATINGVALUEUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.IONCONCENTRATIONUNIT:
						UnitType = IfcDerivedUnitEnum.IONCONCENTRATIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT:
						UnitType = IfcDerivedUnitEnum.LUMINOUSINTENSITYDISTRIBUTIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MASSPERLENGTHUNIT:
						UnitType = IfcDerivedUnitEnum.MASSPERLENGTHUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT:
						UnitType = IfcDerivedUnitEnum.MODULUSOFLINEARSUBGRADEREACTIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT:
						UnitType = IfcDerivedUnitEnum.MODULUSOFROTATIONALSUBGRADEREACTIONUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.PHUNIT:
						UnitType = IfcDerivedUnitEnum.PHUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.ROTATIONALMASSUNIT:
						UnitType = IfcDerivedUnitEnum.ROTATIONALMASSUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT:
						UnitType = IfcDerivedUnitEnum.SECTIONAREAINTEGRALUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SECTIONMODULUSUNIT:
						UnitType = IfcDerivedUnitEnum.SECTIONMODULUSUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPOWERLEVELUNIT:
						//## Handle setting of SOUNDPOWERLEVELUNIT member from IfcDerivedUnitEnum in property UnitType
						UserDefinedType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcDerivedUnitEnum), value);
	                    UnitType = IfcDerivedUnitEnum.USERDEFINED;
                        return;
						//##
										case Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPOWERUNIT:
						UnitType = IfcDerivedUnitEnum.SOUNDPOWERUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPRESSURELEVELUNIT:
						//## Handle setting of SOUNDPRESSURELEVELUNIT member from IfcDerivedUnitEnum in property UnitType
						UserDefinedType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcDerivedUnitEnum), value);
	                    UnitType = IfcDerivedUnitEnum.USERDEFINED;
                        return;
						//##
										case Ifc4.Interfaces.IfcDerivedUnitEnum.SOUNDPRESSUREUNIT:
						UnitType = IfcDerivedUnitEnum.SOUNDPRESSUREUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT:
						UnitType = IfcDerivedUnitEnum.TEMPERATUREGRADIENTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.TEMPERATURERATEOFCHANGEUNIT:
						//## Handle setting of TEMPERATURERATEOFCHANGEUNIT member from IfcDerivedUnitEnum in property UnitType
						UserDefinedType = System.Enum.GetName(typeof (Ifc4.Interfaces.IfcDerivedUnitEnum), value);
	                    UnitType = IfcDerivedUnitEnum.USERDEFINED;
                        return;
						//##
										case Ifc4.Interfaces.IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT:
						UnitType = IfcDerivedUnitEnum.THERMALEXPANSIONCOEFFICIENTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGCONSTANTUNIT:
						UnitType = IfcDerivedUnitEnum.WARPINGCONSTANTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.WARPINGMOMENTUNIT:
						UnitType = IfcDerivedUnitEnum.WARPINGMOMENTUNIT;
						return;
					case Ifc4.Interfaces.IfcDerivedUnitEnum.USERDEFINED:
						UnitType = IfcDerivedUnitEnum.USERDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDerivedUnit), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcDerivedUnit.UserDefinedType 
		{ 
			get
			{
				if (!UserDefinedType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedType.Value);
			} 
			set
			{
				UserDefinedType = value.HasValue ? 
					new IfcLabel(value.Value) :  
					 new IfcLabel?() ;
				
			}
		}
		Common.Geometry.XbimDimensionalExponents IIfcDerivedUnit.Dimensions 
		{
			get 
			{
				return Dimensions;
			}
		}

	//## Custom code
	//##
	}
}