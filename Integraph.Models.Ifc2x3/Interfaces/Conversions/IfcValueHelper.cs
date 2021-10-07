using System;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc4.MeasureResource;
using IfcAbsorbedDoseMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcAbsorbedDoseMeasure;
using IfcAccelerationMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcAccelerationMeasure;
using IfcAmountOfSubstanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcAmountOfSubstanceMeasure;
using IfcAngularVelocityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcAngularVelocityMeasure;
using IfcAreaMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcAreaMeasure;
using IfcBoolean = Integraph.Models.Ifc2x3.MeasureResource.IfcBoolean;
using IfcComplexNumber = Integraph.Models.Ifc2x3.MeasureResource.IfcComplexNumber;
using IfcCompoundPlaneAngleMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcCompoundPlaneAngleMeasure;
using IfcContextDependentMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcContextDependentMeasure;
using IfcCountMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcCountMeasure;
using IfcCurvatureMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcCurvatureMeasure;
using IfcDescriptiveMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcDescriptiveMeasure;
using IfcDoseEquivalentMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcDoseEquivalentMeasure;
using IfcDynamicViscosityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcDynamicViscosityMeasure;
using IfcElectricCapacitanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricCapacitanceMeasure;
using IfcElectricChargeMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricChargeMeasure;
using IfcElectricConductanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricConductanceMeasure;
using IfcElectricCurrentMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricCurrentMeasure;
using IfcElectricResistanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricResistanceMeasure;
using IfcElectricVoltageMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcElectricVoltageMeasure;
using IfcEnergyMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcEnergyMeasure;
using IfcForceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcForceMeasure;
using IfcFrequencyMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcFrequencyMeasure;
using IfcHeatFluxDensityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcHeatFluxDensityMeasure;
using IfcHeatingValueMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcHeatingValueMeasure;
using IfcIdentifier = Integraph.Models.Ifc2x3.MeasureResource.IfcIdentifier;
using IfcIlluminanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcIlluminanceMeasure;
using IfcInductanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcInductanceMeasure;
using IfcInteger = Integraph.Models.Ifc2x3.MeasureResource.IfcInteger;
using IfcIntegerCountRateMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcIntegerCountRateMeasure;
using IfcIonConcentrationMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcIonConcentrationMeasure;
using IfcIsothermalMoistureCapacityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcIsothermalMoistureCapacityMeasure;
using IfcKinematicViscosityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcKinematicViscosityMeasure;
using IfcLabel = Integraph.Models.Ifc2x3.MeasureResource.IfcLabel;
using IfcLengthMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLengthMeasure;
using IfcLinearForceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLinearForceMeasure;
using IfcLinearMomentMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLinearMomentMeasure;
using IfcLinearStiffnessMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLinearStiffnessMeasure;
using IfcLinearVelocityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLinearVelocityMeasure;
using IfcLogical = Integraph.Models.Ifc2x3.MeasureResource.IfcLogical;
using IfcLuminousFluxMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLuminousFluxMeasure;
using IfcLuminousIntensityDistributionMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLuminousIntensityDistributionMeasure;
using IfcLuminousIntensityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcLuminousIntensityMeasure;
using IfcMagneticFluxDensityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMagneticFluxDensityMeasure;
using IfcMagneticFluxMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMagneticFluxMeasure;
using IfcMassDensityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMassDensityMeasure;
using IfcMassFlowRateMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMassFlowRateMeasure;
using IfcMassMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMassMeasure;
using IfcMassPerLengthMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMassPerLengthMeasure;
using IfcModulusOfElasticityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcModulusOfElasticityMeasure;
using IfcModulusOfLinearSubgradeReactionMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure;
using IfcModulusOfRotationalSubgradeReactionMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure;
using IfcModulusOfSubgradeReactionMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcModulusOfSubgradeReactionMeasure;
using IfcMoistureDiffusivityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMoistureDiffusivityMeasure;
using IfcMolecularWeightMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMolecularWeightMeasure;
using IfcMomentOfInertiaMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMomentOfInertiaMeasure;
using IfcMonetaryMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcMonetaryMeasure;
using IfcNormalisedRatioMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcNormalisedRatioMeasure;
using IfcNumericMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcNumericMeasure;
using IfcParameterValue = Integraph.Models.Ifc2x3.MeasureResource.IfcParameterValue;
using IfcPHMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPHMeasure;
using IfcPlanarForceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPlanarForceMeasure;
using IfcPlaneAngleMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPlaneAngleMeasure;
using IfcPositiveLengthMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPositiveLengthMeasure;
using IfcPositivePlaneAngleMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPositivePlaneAngleMeasure;
using IfcPositiveRatioMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPositiveRatioMeasure;
using IfcPowerMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPowerMeasure;
using IfcPressureMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcPressureMeasure;
using IfcRadioActivityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcRadioActivityMeasure;
using IfcRatioMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcRatioMeasure;
using IfcReal = Integraph.Models.Ifc2x3.MeasureResource.IfcReal;
using IfcRotationalFrequencyMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcRotationalFrequencyMeasure;
using IfcRotationalMassMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcRotationalMassMeasure;
using IfcRotationalStiffnessMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcRotationalStiffnessMeasure;
using IfcSectionalAreaIntegralMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSectionalAreaIntegralMeasure;
using IfcSectionModulusMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSectionModulusMeasure;
using IfcShearModulusMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcShearModulusMeasure;
using IfcSolidAngleMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSolidAngleMeasure;
using IfcSoundPowerMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSoundPowerMeasure;
using IfcSoundPressureMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSoundPressureMeasure;
using IfcSpecificHeatCapacityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcSpecificHeatCapacityMeasure;
using IfcTemperatureGradientMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcTemperatureGradientMeasure;
using IfcText = Integraph.Models.Ifc2x3.MeasureResource.IfcText;
using IfcThermalAdmittanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermalAdmittanceMeasure;
using IfcThermalConductivityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermalConductivityMeasure;
using IfcThermalExpansionCoefficientMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermalExpansionCoefficientMeasure;
using IfcThermalResistanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermalResistanceMeasure;
using IfcThermalTransmittanceMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermalTransmittanceMeasure;
using IfcThermodynamicTemperatureMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcThermodynamicTemperatureMeasure;
using IfcTimeMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcTimeMeasure;
using IfcTorqueMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcTorqueMeasure;
using IfcValue = Integraph.Models.Ifc2x3.MeasureResource.IfcValue;
using IfcVaporPermeabilityMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcVaporPermeabilityMeasure;
using IfcVolumeMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcVolumeMeasure;
using IfcVolumetricFlowRateMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcVolumetricFlowRateMeasure;
using IfcWarpingConstantMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcWarpingConstantMeasure;
using IfcWarpingMomentMeasure = Integraph.Models.Ifc2x3.MeasureResource.IfcWarpingMomentMeasure;

// ReSharper disable once CheckNamespace
namespace Integraph.Models.Ifc4.Interfaces
{
    public static class IfcValueHelper
    {
        public static IIfcValue ToIfc4(this IfcValue member)
        {
            if (member == null)
                return null;
            switch (member.GetType().Name)
            {
                case "IfcVolumeMeasure":
                    return new MeasureResource.IfcVolumeMeasure((IfcVolumeMeasure)member);
                case "IfcTimeMeasure":
                    return new MeasureResource.IfcTimeMeasure((IfcTimeMeasure)member);
                case "IfcThermodynamicTemperatureMeasure":
                    return new MeasureResource.IfcThermodynamicTemperatureMeasure((IfcThermodynamicTemperatureMeasure)member);
                case "IfcSolidAngleMeasure":
                    return new MeasureResource.IfcSolidAngleMeasure((IfcSolidAngleMeasure)member);
                case "IfcPositiveRatioMeasure":
                    return new MeasureResource.IfcPositiveRatioMeasure((IfcPositiveRatioMeasure)member);
                case "IfcRatioMeasure":
                    return new MeasureResource.IfcRatioMeasure((IfcRatioMeasure)member);
                case "IfcPositivePlaneAngleMeasure":
                    return new MeasureResource.IfcPositivePlaneAngleMeasure((IfcPositivePlaneAngleMeasure)member);
                case "IfcPlaneAngleMeasure":
                    return new MeasureResource.IfcPlaneAngleMeasure((IfcPlaneAngleMeasure)member);
                case "IfcParameterValue":
                    return new MeasureResource.IfcParameterValue((IfcParameterValue)member);
                case "IfcNumericMeasure":
                    return new MeasureResource.IfcNumericMeasure((IfcNumericMeasure)member);
                case "IfcMassMeasure":
                    return new MeasureResource.IfcMassMeasure((IfcMassMeasure)member);
                case "IfcPositiveLengthMeasure":
                    return new MeasureResource.IfcPositiveLengthMeasure((IfcPositiveLengthMeasure)member);
                case "IfcLengthMeasure":
                    return new MeasureResource.IfcLengthMeasure((IfcLengthMeasure)member);
                case "IfcElectricCurrentMeasure":
                    return new MeasureResource.IfcElectricCurrentMeasure((IfcElectricCurrentMeasure)member);
                case "IfcDescriptiveMeasure":
                    return new MeasureResource.IfcDescriptiveMeasure((IfcDescriptiveMeasure)member);
                case "IfcCountMeasure":
                    return new MeasureResource.IfcCountMeasure((IfcCountMeasure)member);
                case "IfcContextDependentMeasure":
                    return new MeasureResource.IfcContextDependentMeasure((IfcContextDependentMeasure)member);
                case "IfcAreaMeasure":
                    return new MeasureResource.IfcAreaMeasure((IfcAreaMeasure)member);
                case "IfcAmountOfSubstanceMeasure":
                    return new MeasureResource.IfcAmountOfSubstanceMeasure((IfcAmountOfSubstanceMeasure)member);
                case "IfcLuminousIntensityMeasure":
                    return new MeasureResource.IfcLuminousIntensityMeasure((IfcLuminousIntensityMeasure)member);
                case "IfcNormalisedRatioMeasure":
                    return new MeasureResource.IfcNormalisedRatioMeasure((IfcNormalisedRatioMeasure)member);
                case "IfcComplexNumber":
                    return new MeasureResource.IfcComplexNumber((IfcComplexNumber)member);
                case "IfcInteger":
                    return new MeasureResource.IfcInteger((IfcInteger)member);
                case "IfcReal":
                    return new MeasureResource.IfcReal((IfcReal)member);
                case "IfcBoolean":
                    return new MeasureResource.IfcBoolean((IfcBoolean)member);
                case "IfcIdentifier":
                    return new MeasureResource.IfcIdentifier((IfcIdentifier)member);
                case "IfcText":
                    return new MeasureResource.IfcText((IfcText)member);
                case "IfcLabel":
                    return new MeasureResource.IfcLabel((IfcLabel)member);
                case "IfcLogical":
                    return new MeasureResource.IfcLogical((IfcLogical)member);
                case "IfcVolumetricFlowRateMeasure":
                    return new MeasureResource.IfcVolumetricFlowRateMeasure((IfcVolumetricFlowRateMeasure)member);
                case "IfcTimeStamp":
                    return new DateTimeResource.IfcTimeStamp((IfcTimeStamp)member);
                case "IfcThermalTransmittanceMeasure":
                    return new MeasureResource.IfcThermalTransmittanceMeasure((IfcThermalTransmittanceMeasure)member);
                case "IfcThermalResistanceMeasure":
                    return new MeasureResource.IfcThermalResistanceMeasure((IfcThermalResistanceMeasure)member);
                case "IfcThermalAdmittanceMeasure":
                    return new MeasureResource.IfcThermalAdmittanceMeasure((IfcThermalAdmittanceMeasure)member);
                case "IfcPressureMeasure":
                    return new MeasureResource.IfcPressureMeasure((IfcPressureMeasure)member);
                case "IfcPowerMeasure":
                    return new MeasureResource.IfcPowerMeasure((IfcPowerMeasure)member);
                case "IfcMassFlowRateMeasure":
                    return new MeasureResource.IfcMassFlowRateMeasure((IfcMassFlowRateMeasure)member);
                case "IfcMassDensityMeasure":
                    return new MeasureResource.IfcMassDensityMeasure((IfcMassDensityMeasure)member);
                case "IfcLinearVelocityMeasure":
                    return new MeasureResource.IfcLinearVelocityMeasure((IfcLinearVelocityMeasure)member);
                case "IfcKinematicViscosityMeasure":
                    return new MeasureResource.IfcKinematicViscosityMeasure((IfcKinematicViscosityMeasure)member);
                case "IfcIntegerCountRateMeasure":
                    return new MeasureResource.IfcIntegerCountRateMeasure((IfcIntegerCountRateMeasure)member);
                case "IfcHeatFluxDensityMeasure":
                    return new MeasureResource.IfcHeatFluxDensityMeasure((IfcHeatFluxDensityMeasure)member);
                case "IfcFrequencyMeasure":
                    return new MeasureResource.IfcFrequencyMeasure((IfcFrequencyMeasure)member);
                case "IfcEnergyMeasure":
                    return new MeasureResource.IfcEnergyMeasure((IfcEnergyMeasure)member);
                case "IfcElectricVoltageMeasure":
                    return new MeasureResource.IfcElectricVoltageMeasure((IfcElectricVoltageMeasure)member);
                case "IfcDynamicViscosityMeasure":
                    return new MeasureResource.IfcDynamicViscosityMeasure((IfcDynamicViscosityMeasure)member);
                case "IfcCompoundPlaneAngleMeasure":
                    return new MeasureResource.IfcCompoundPlaneAngleMeasure((IfcCompoundPlaneAngleMeasure)member);
                case "IfcAngularVelocityMeasure":
                    return new MeasureResource.IfcAngularVelocityMeasure((IfcAngularVelocityMeasure)member);
                case "IfcThermalConductivityMeasure":
                    return new MeasureResource.IfcThermalConductivityMeasure((IfcThermalConductivityMeasure)member);
                case "IfcMolecularWeightMeasure":
                    return new MeasureResource.IfcMolecularWeightMeasure((IfcMolecularWeightMeasure)member);
                case "IfcVaporPermeabilityMeasure":
                    return new MeasureResource.IfcVaporPermeabilityMeasure((IfcVaporPermeabilityMeasure)member);
                case "IfcMoistureDiffusivityMeasure":
                    return new MeasureResource.IfcMoistureDiffusivityMeasure((IfcMoistureDiffusivityMeasure)member);
                case "IfcIsothermalMoistureCapacityMeasure":
                    return new MeasureResource.IfcIsothermalMoistureCapacityMeasure((IfcIsothermalMoistureCapacityMeasure)member);
                case "IfcSpecificHeatCapacityMeasure":
                    return new MeasureResource.IfcSpecificHeatCapacityMeasure((IfcSpecificHeatCapacityMeasure)member);
                case "IfcMonetaryMeasure":
                    return new MeasureResource.IfcMonetaryMeasure((IfcMonetaryMeasure)member);
                case "IfcMagneticFluxDensityMeasure":
                    return new MeasureResource.IfcMagneticFluxDensityMeasure((IfcMagneticFluxDensityMeasure)member);
                case "IfcMagneticFluxMeasure":
                    return new MeasureResource.IfcMagneticFluxMeasure((IfcMagneticFluxMeasure)member);
                case "IfcLuminousFluxMeasure":
                    return new MeasureResource.IfcLuminousFluxMeasure((IfcLuminousFluxMeasure)member);
                case "IfcForceMeasure":
                    return new MeasureResource.IfcForceMeasure((IfcForceMeasure)member);
                case "IfcInductanceMeasure":
                    return new MeasureResource.IfcInductanceMeasure((IfcInductanceMeasure)member);
                case "IfcIlluminanceMeasure":
                    return new MeasureResource.IfcIlluminanceMeasure((IfcIlluminanceMeasure)member);
                case "IfcElectricResistanceMeasure":
                    return new MeasureResource.IfcElectricResistanceMeasure((IfcElectricResistanceMeasure)member);
                case "IfcElectricConductanceMeasure":
                    return new MeasureResource.IfcElectricConductanceMeasure((IfcElectricConductanceMeasure)member);
                case "IfcElectricChargeMeasure":
                    return new MeasureResource.IfcElectricChargeMeasure((IfcElectricChargeMeasure)member);
                case "IfcDoseEquivalentMeasure":
                    return new MeasureResource.IfcDoseEquivalentMeasure((IfcDoseEquivalentMeasure)member);
                case "IfcElectricCapacitanceMeasure":
                    return new MeasureResource.IfcElectricCapacitanceMeasure((IfcElectricCapacitanceMeasure)member);
                case "IfcAbsorbedDoseMeasure":
                    return new MeasureResource.IfcAbsorbedDoseMeasure((IfcAbsorbedDoseMeasure)member);
                case "IfcRadioActivityMeasure":
                    return new MeasureResource.IfcRadioActivityMeasure((IfcRadioActivityMeasure)member);
                case "IfcRotationalFrequencyMeasure":
                    return new MeasureResource.IfcRotationalFrequencyMeasure((IfcRotationalFrequencyMeasure)member);
                case "IfcTorqueMeasure":
                    return new MeasureResource.IfcTorqueMeasure((IfcTorqueMeasure)member);
                case "IfcAccelerationMeasure":
                    return new MeasureResource.IfcAccelerationMeasure((IfcAccelerationMeasure)member);
                case "IfcLinearForceMeasure":
                    return new MeasureResource.IfcLinearForceMeasure((IfcLinearForceMeasure)member);
                case "IfcLinearStiffnessMeasure":
                    return new MeasureResource.IfcLinearStiffnessMeasure((IfcLinearStiffnessMeasure)member);
                case "IfcModulusOfSubgradeReactionMeasure":
                    return new MeasureResource.IfcModulusOfSubgradeReactionMeasure((IfcModulusOfSubgradeReactionMeasure)member);
                case "IfcModulusOfElasticityMeasure":
                    return new MeasureResource.IfcModulusOfElasticityMeasure((IfcModulusOfElasticityMeasure)member);
                case "IfcMomentOfInertiaMeasure":
                    return new MeasureResource.IfcMomentOfInertiaMeasure((IfcMomentOfInertiaMeasure)member);
                case "IfcPlanarForceMeasure":
                    return new MeasureResource.IfcPlanarForceMeasure((IfcPlanarForceMeasure)member);
                case "IfcRotationalStiffnessMeasure":
                    return new MeasureResource.IfcRotationalStiffnessMeasure((IfcRotationalStiffnessMeasure)member);
                case "IfcShearModulusMeasure":
                    return new MeasureResource.IfcShearModulusMeasure((IfcShearModulusMeasure)member);
                case "IfcLinearMomentMeasure":
                    return new MeasureResource.IfcLinearMomentMeasure((IfcLinearMomentMeasure)member);
                case "IfcLuminousIntensityDistributionMeasure":
                    return new MeasureResource.IfcLuminousIntensityDistributionMeasure((IfcLuminousIntensityDistributionMeasure)member);
                case "IfcCurvatureMeasure":
                    return new MeasureResource.IfcCurvatureMeasure((IfcCurvatureMeasure)member);
                case "IfcMassPerLengthMeasure":
                    return new MeasureResource.IfcMassPerLengthMeasure((IfcMassPerLengthMeasure)member);
                case "IfcModulusOfLinearSubgradeReactionMeasure":
                    return new MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure((IfcModulusOfLinearSubgradeReactionMeasure)member);
                case "IfcModulusOfRotationalSubgradeReactionMeasure":
                    return new MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure((IfcModulusOfRotationalSubgradeReactionMeasure)member);
                case "IfcRotationalMassMeasure":
                    return new MeasureResource.IfcRotationalMassMeasure((IfcRotationalMassMeasure)member);
                case "IfcSectionalAreaIntegralMeasure":
                    return new MeasureResource.IfcSectionalAreaIntegralMeasure((IfcSectionalAreaIntegralMeasure)member);
                case "IfcSectionModulusMeasure":
                    return new MeasureResource.IfcSectionModulusMeasure((IfcSectionModulusMeasure)member);
                case "IfcTemperatureGradientMeasure":
                    return new MeasureResource.IfcTemperatureGradientMeasure((IfcTemperatureGradientMeasure)member);
                case "IfcThermalExpansionCoefficientMeasure":
                    return new MeasureResource.IfcThermalExpansionCoefficientMeasure((IfcThermalExpansionCoefficientMeasure)member);
                case "IfcWarpingConstantMeasure":
                    return new MeasureResource.IfcWarpingConstantMeasure((IfcWarpingConstantMeasure)member);
                case "IfcWarpingMomentMeasure":
                    return new MeasureResource.IfcWarpingMomentMeasure((IfcWarpingMomentMeasure)member);
                case "IfcSoundPowerMeasure":
                    return new MeasureResource.IfcSoundPowerMeasure((IfcSoundPowerMeasure)member);
                case "IfcSoundPressureMeasure":
                    return new MeasureResource.IfcSoundPressureMeasure((IfcSoundPressureMeasure)member);
                case "IfcHeatingValueMeasure":
                    return new MeasureResource.IfcHeatingValueMeasure((IfcHeatingValueMeasure)member);
                case "IfcPHMeasure":
                    return new MeasureResource.IfcPHMeasure((IfcPHMeasure)member);
                case "IfcIonConcentrationMeasure":
                    return new MeasureResource.IfcIonConcentrationMeasure((IfcIonConcentrationMeasure)member);
                default:
                    throw new NotSupportedException();
            }
        }

        public static IfcValue ToIfc3(this IIfcValue member)
        {
            if (member == null)
                return null;
            var name = member.GetType().Name;
            switch (name)
            {
                case "IfcAbsorbedDoseMeasure":
                    return new IfcAbsorbedDoseMeasure((MeasureResource.IfcAbsorbedDoseMeasure)member);
                case "IfcAccelerationMeasure":
                    return new IfcAccelerationMeasure((MeasureResource.IfcAccelerationMeasure)member);
                case "IfcAngularVelocityMeasure":
                    return new IfcAngularVelocityMeasure((MeasureResource.IfcAngularVelocityMeasure)member);
                case "IfcAreaDensityMeasure":
                    return null;
                case "IfcCompoundPlaneAngleMeasure":
                    return new IfcCompoundPlaneAngleMeasure((MeasureResource.IfcCompoundPlaneAngleMeasure)member);
                case "IfcCurvatureMeasure":
                    return new IfcCurvatureMeasure((MeasureResource.IfcCurvatureMeasure)member);
                case "IfcDoseEquivalentMeasure":
                    return new IfcDoseEquivalentMeasure((MeasureResource.IfcDoseEquivalentMeasure)member);
                case "IfcDynamicViscosityMeasure":
                    return new IfcDynamicViscosityMeasure((MeasureResource.IfcDynamicViscosityMeasure)member);
                case "IfcElectricCapacitanceMeasure":
                    return new IfcElectricCapacitanceMeasure((MeasureResource.IfcElectricCapacitanceMeasure)member);
                case "IfcElectricChargeMeasure":
                    return new IfcElectricChargeMeasure((MeasureResource.IfcElectricChargeMeasure)member);
                case "IfcElectricConductanceMeasure":
                    return new IfcElectricConductanceMeasure((MeasureResource.IfcElectricConductanceMeasure)member);
                case "IfcElectricResistanceMeasure":
                    return new IfcElectricResistanceMeasure((MeasureResource.IfcElectricResistanceMeasure)member);
                case "IfcElectricVoltageMeasure":
                    return new IfcElectricVoltageMeasure((MeasureResource.IfcElectricVoltageMeasure)member);
                case "IfcEnergyMeasure":
                    return new IfcEnergyMeasure((MeasureResource.IfcEnergyMeasure)member);
                case "IfcForceMeasure":
                    return new IfcForceMeasure((MeasureResource.IfcForceMeasure)member);
                case "IfcFrequencyMeasure":
                    return new IfcFrequencyMeasure((MeasureResource.IfcFrequencyMeasure)member);
                case "IfcHeatFluxDensityMeasure":
                    return new IfcHeatFluxDensityMeasure((MeasureResource.IfcHeatFluxDensityMeasure)member);
                case "IfcHeatingValueMeasure":
                    return new IfcHeatingValueMeasure((MeasureResource.IfcHeatingValueMeasure)member);
                case "IfcIlluminanceMeasure":
                    return new IfcIlluminanceMeasure((MeasureResource.IfcIlluminanceMeasure)member);
                case "IfcInductanceMeasure":
                    return new IfcInductanceMeasure((MeasureResource.IfcInductanceMeasure)member);
                case "IfcIntegerCountRateMeasure":
                    return new IfcIntegerCountRateMeasure((MeasureResource.IfcIntegerCountRateMeasure)member);
                case "IfcIonConcentrationMeasure":
                    return new IfcIonConcentrationMeasure((MeasureResource.IfcIonConcentrationMeasure)member);
                case "IfcIsothermalMoistureCapacityMeasure":
                    return new IfcIsothermalMoistureCapacityMeasure((MeasureResource.IfcIsothermalMoistureCapacityMeasure)member);
                case "IfcKinematicViscosityMeasure":
                    return new IfcKinematicViscosityMeasure((MeasureResource.IfcKinematicViscosityMeasure)member);
                case "IfcLinearForceMeasure":
                    return new IfcLinearForceMeasure((MeasureResource.IfcLinearForceMeasure)member);
                case "IfcLinearMomentMeasure":
                    return new IfcLinearMomentMeasure((MeasureResource.IfcLinearMomentMeasure)member);
                case "IfcLinearStiffnessMeasure":
                    return new IfcLinearStiffnessMeasure((MeasureResource.IfcLinearStiffnessMeasure)member);
                case "IfcLinearVelocityMeasure":
                    return new IfcLinearVelocityMeasure((MeasureResource.IfcLinearVelocityMeasure)member);
                case "IfcLuminousFluxMeasure":
                    return new IfcLuminousFluxMeasure((MeasureResource.IfcLuminousFluxMeasure)member);
                case "IfcLuminousIntensityDistributionMeasure":
                    return new IfcLuminousIntensityDistributionMeasure((MeasureResource.IfcLuminousIntensityDistributionMeasure)member);
                case "IfcMagneticFluxDensityMeasure":
                    return new IfcMagneticFluxDensityMeasure((MeasureResource.IfcMagneticFluxDensityMeasure)member);
                case "IfcMagneticFluxMeasure":
                    return new IfcMagneticFluxMeasure((MeasureResource.IfcMagneticFluxMeasure)member);
                case "IfcMassDensityMeasure":
                    return new IfcMassDensityMeasure((MeasureResource.IfcMassDensityMeasure)member);
                case "IfcMassFlowRateMeasure":
                    return new IfcMassFlowRateMeasure((MeasureResource.IfcMassFlowRateMeasure)member);
                case "IfcMassPerLengthMeasure":
                    return new IfcMassPerLengthMeasure((MeasureResource.IfcMassPerLengthMeasure)member);
                case "IfcModulusOfElasticityMeasure":
                    return new IfcModulusOfElasticityMeasure((MeasureResource.IfcModulusOfElasticityMeasure)member);
                case "IfcModulusOfLinearSubgradeReactionMeasure":
                    return new IfcModulusOfLinearSubgradeReactionMeasure((MeasureResource.IfcModulusOfLinearSubgradeReactionMeasure)member);
                case "IfcModulusOfRotationalSubgradeReactionMeasure":
                    return new IfcModulusOfRotationalSubgradeReactionMeasure((MeasureResource.IfcModulusOfRotationalSubgradeReactionMeasure)member);
                case "IfcModulusOfSubgradeReactionMeasure":
                    return new IfcModulusOfSubgradeReactionMeasure((MeasureResource.IfcModulusOfSubgradeReactionMeasure)member);
                case "IfcMoistureDiffusivityMeasure":
                    return new IfcMoistureDiffusivityMeasure((MeasureResource.IfcMoistureDiffusivityMeasure)member);
                case "IfcMolecularWeightMeasure":
                    return new IfcMolecularWeightMeasure((MeasureResource.IfcMolecularWeightMeasure)member);
                case "IfcMomentOfInertiaMeasure":
                    return new IfcMomentOfInertiaMeasure((MeasureResource.IfcMomentOfInertiaMeasure)member);
                case "IfcMonetaryMeasure":
                    return new IfcMonetaryMeasure((MeasureResource.IfcMonetaryMeasure)member);
                case "IfcPHMeasure":
                    return new IfcPHMeasure((MeasureResource.IfcPHMeasure)member);
                case "IfcPlanarForceMeasure":
                    return new IfcPlanarForceMeasure((MeasureResource.IfcPlanarForceMeasure)member);
                case "IfcPowerMeasure":
                    return new IfcPowerMeasure((MeasureResource.IfcPowerMeasure)member);
                case "IfcPressureMeasure":
                    return new IfcPressureMeasure((MeasureResource.IfcPressureMeasure)member);
                case "IfcRadioActivityMeasure":
                    return new IfcRadioActivityMeasure((MeasureResource.IfcRadioActivityMeasure)member);
                case "IfcRotationalFrequencyMeasure":
                    return new IfcRotationalFrequencyMeasure((MeasureResource.IfcRotationalFrequencyMeasure)member);
                case "IfcRotationalMassMeasure":
                    return new IfcRotationalMassMeasure((MeasureResource.IfcRotationalMassMeasure)member);
                case "IfcRotationalStiffnessMeasure":
                    return new IfcRotationalStiffnessMeasure((MeasureResource.IfcRotationalStiffnessMeasure)member);
                case "IfcSectionModulusMeasure":
                    return new IfcSectionModulusMeasure((MeasureResource.IfcSectionModulusMeasure)member);
                case "IfcSectionalAreaIntegralMeasure":
                    return new IfcSectionalAreaIntegralMeasure((MeasureResource.IfcSectionalAreaIntegralMeasure)member);
                case "IfcShearModulusMeasure":
                    return new IfcShearModulusMeasure((MeasureResource.IfcShearModulusMeasure)member);
                case "IfcSoundPowerLevelMeasure":
                    return new IfcSoundPowerMeasure((IfcSoundPowerLevelMeasure)member);
                case "IfcSoundPowerMeasure":
                    return new IfcSoundPowerMeasure((MeasureResource.IfcSoundPowerMeasure)member);
                case "IfcSoundPressureLevelMeasure":
                    return new IfcSoundPressureMeasure((IfcSoundPressureLevelMeasure)member);
                case "IfcSoundPressureMeasure":
                    return new IfcSoundPressureMeasure((MeasureResource.IfcSoundPressureMeasure)member);
                case "IfcSpecificHeatCapacityMeasure":
                    return new IfcSpecificHeatCapacityMeasure((MeasureResource.IfcSpecificHeatCapacityMeasure)member);
                case "IfcTemperatureGradientMeasure":
                    return new IfcTemperatureGradientMeasure((MeasureResource.IfcTemperatureGradientMeasure)member);
                case "IfcTemperatureRateOfChangeMeasure":
                    return null;
                case "IfcThermalAdmittanceMeasure":
                    return new IfcThermalAdmittanceMeasure((MeasureResource.IfcThermalAdmittanceMeasure)member);
                case "IfcThermalConductivityMeasure":
                    return new IfcThermalConductivityMeasure((MeasureResource.IfcThermalConductivityMeasure)member);
                case "IfcThermalExpansionCoefficientMeasure":
                    return new IfcThermalExpansionCoefficientMeasure((MeasureResource.IfcThermalExpansionCoefficientMeasure)member);
                case "IfcThermalResistanceMeasure":
                    return new IfcThermalResistanceMeasure((MeasureResource.IfcThermalResistanceMeasure)member);
                case "IfcThermalTransmittanceMeasure":
                    return new IfcThermalTransmittanceMeasure((MeasureResource.IfcThermalTransmittanceMeasure)member);
                case "IfcTorqueMeasure":
                    return new IfcTorqueMeasure((MeasureResource.IfcTorqueMeasure)member);
                case "IfcVaporPermeabilityMeasure":
                    return new IfcVaporPermeabilityMeasure((MeasureResource.IfcVaporPermeabilityMeasure)member);
                case "IfcVolumetricFlowRateMeasure":
                    return new IfcVolumetricFlowRateMeasure((MeasureResource.IfcVolumetricFlowRateMeasure)member);
                case "IfcWarpingConstantMeasure":
                    return new IfcWarpingConstantMeasure((MeasureResource.IfcWarpingConstantMeasure)member);
                case "IfcWarpingMomentMeasure":
                    return new IfcWarpingMomentMeasure((MeasureResource.IfcWarpingMomentMeasure)member);
                case "IfcAmountOfSubstanceMeasure":
                    return new IfcAmountOfSubstanceMeasure((MeasureResource.IfcAmountOfSubstanceMeasure)member);
                case "IfcAreaMeasure":
                    return new IfcAreaMeasure((MeasureResource.IfcAreaMeasure)member);
                case "IfcComplexNumber":
                    return new IfcComplexNumber((MeasureResource.IfcComplexNumber)member);
                case "IfcContextDependentMeasure":
                    return new IfcContextDependentMeasure((MeasureResource.IfcContextDependentMeasure)member);
                case "IfcCountMeasure":
                    return new IfcCountMeasure((MeasureResource.IfcCountMeasure)member);
                case "IfcDescriptiveMeasure":
                    return new IfcDescriptiveMeasure((MeasureResource.IfcDescriptiveMeasure)member);
                case "IfcElectricCurrentMeasure":
                    return new IfcElectricCurrentMeasure((MeasureResource.IfcElectricCurrentMeasure)member);
                case "IfcLengthMeasure":
                    return new IfcLengthMeasure((MeasureResource.IfcLengthMeasure)member);
                case "IfcLuminousIntensityMeasure":
                    return new IfcLuminousIntensityMeasure((MeasureResource.IfcLuminousIntensityMeasure)member);
                case "IfcMassMeasure":
                    return new IfcMassMeasure((MeasureResource.IfcMassMeasure)member);
                case "IfcNonNegativeLengthMeasure":
                    return null;
                case "IfcNormalisedRatioMeasure":
                    return new IfcNormalisedRatioMeasure((MeasureResource.IfcNormalisedRatioMeasure)member);
                case "IfcNumericMeasure":
                    return new IfcNumericMeasure((MeasureResource.IfcNumericMeasure)member);
                case "IfcParameterValue":
                    return new IfcParameterValue((MeasureResource.IfcParameterValue)member);
                case "IfcPlaneAngleMeasure":
                    return new IfcPlaneAngleMeasure((MeasureResource.IfcPlaneAngleMeasure)member);
                case "IfcPositiveLengthMeasure":
                    return new IfcPositiveLengthMeasure((MeasureResource.IfcPositiveLengthMeasure)member);
                case "IfcPositivePlaneAngleMeasure":
                    return new IfcPositivePlaneAngleMeasure((MeasureResource.IfcPositivePlaneAngleMeasure)member);
                case "IfcPositiveRatioMeasure":
                    return new IfcPositiveRatioMeasure((MeasureResource.IfcPositiveRatioMeasure)member);
                case "IfcRatioMeasure":
                    return new IfcRatioMeasure((MeasureResource.IfcRatioMeasure)member);
                case "IfcSolidAngleMeasure":
                    return new IfcSolidAngleMeasure((MeasureResource.IfcSolidAngleMeasure)member);
                case "IfcThermodynamicTemperatureMeasure":
                    return new IfcThermodynamicTemperatureMeasure((MeasureResource.IfcThermodynamicTemperatureMeasure)member);
                case "IfcTimeMeasure":
                    return new IfcTimeMeasure((MeasureResource.IfcTimeMeasure)member);
                case "IfcVolumeMeasure":
                    return new IfcVolumeMeasure((MeasureResource.IfcVolumeMeasure)member);
                case "IfcBoolean":
                    return new IfcBoolean((MeasureResource.IfcBoolean)member);
                case "IfcDate":
                    return null;
                case "IfcDateTime":
                    return null;
                case "IfcDuration":
                    return null;
                case "IfcIdentifier":
                    return new IfcIdentifier((MeasureResource.IfcIdentifier)member);
                case "IfcInteger":
                    return new IfcInteger((MeasureResource.IfcInteger)member);
                case "IfcLabel":
                    return new IfcLabel((MeasureResource.IfcLabel)member);
                case "IfcLogical":
                    return new IfcLogical((MeasureResource.IfcLogical)member);
                case "IfcPositiveInteger":
                    return null;
                case "IfcReal":
                    return new IfcReal((MeasureResource.IfcReal)member);
                case "IfcText":
                    return new IfcText((MeasureResource.IfcText)member);
                case "IfcTime":
                    return null;
                case "IfcTimeStamp":
                    return new IfcTimeStamp((DateTimeResource.IfcTimeStamp)member);
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
