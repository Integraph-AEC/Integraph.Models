using System;
using System.Collections.Generic;
using Integraph.Models.IfcBase.STEP;
using Newtonsoft.Json;

namespace Integraph.Models.IfcBase.Models
{
	/// <summary>
	///     <see href="http://www.buildingsmart-tech.org/ifc/IFC4/final/html/link/ifcgeometricrepresentationsubcontext.htm" />
	/// </summary>
	public class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext
    {
	    /// <summary>
	    ///     Construct a IfcGeometricRepresentationSubContext with all required attributes.
	    /// </summary>
	    public IfcGeometricRepresentationSubContext(IfcDimensionCount coordinateSpaceDimension,
            IfcAxis2Placement worldCoordinateSystem, IfcGeometricRepresentationContext parentContext,
            IfcGeometricProjectionEnum targetView) : base(coordinateSpaceDimension, worldCoordinateSystem)
        {
            ParentContext = parentContext;
            TargetView = targetView;
        }

	    /// <summary>
	    ///     Construct a IfcGeometricRepresentationSubContext with required and optional attributes.
	    /// </summary>
	    [JsonConstructor]
        public IfcGeometricRepresentationSubContext(IfcLabel contextIdentifier, IfcLabel contextType,
            IfcDimensionCount coordinateSpaceDimension, IfcReal precision, IfcAxis2Placement worldCoordinateSystem,
            IfcDirection trueNorth, IfcGeometricRepresentationContext parentContext,
            IfcPositiveRatioMeasure targetScale, IfcGeometricProjectionEnum targetView, IfcLabel userDefinedTargetView)
            : base(contextIdentifier, contextType, coordinateSpaceDimension, precision, worldCoordinateSystem,
                trueNorth)
        {
            ParentContext = parentContext;
            TargetScale = targetScale;
            TargetView = targetView;
            UserDefinedTargetView = userDefinedTargetView;
        }

        public IfcGeometricRepresentationContext ParentContext { get; set; }
        public IfcPositiveRatioMeasure TargetScale { get; set; } // optional
        public IfcGeometricProjectionEnum? TargetView { get; set; }
        public IfcLabel UserDefinedTargetView { get; set; } // optional

        [JsonIgnore]
        public new IfcAxis2Placement WorldCoordinateSystem =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for WorldCoordinateSystem."); // derived

        [JsonIgnore]
        public new IfcDimensionCount CoordinateSpaceDimension =>
            throw new NotImplementedException(
                "Derived property logic has been implemented for CoordinateSpaceDimension."); // derived

        [JsonIgnore]
        public new IfcDirection TrueNorth =>
            throw new NotImplementedException("Derived property logic has been implemented for TrueNorth."); // derived

        [JsonIgnore]
        public new IfcReal Precision =>
            throw new NotImplementedException("Derived property logic has been implemented for Precision."); // derived

        public new static IfcGeometricRepresentationSubContext FromJson(string json)
        {
            return JsonConvert.DeserializeObject<IfcGeometricRepresentationSubContext>(json);
        }

        public override string GetStepParameters()
        {
            var parameters = new List<string>
            {
                ContextIdentifier != null ? ContextIdentifier.ToStepValue() : "$",
                ContextType != null ? ContextType.ToStepValue() : "$",
                "*",
                "*",
                "*",
                "*",
                ParentContext != null ? ParentContext.ToStepValue() : "$",
                TargetScale != null ? TargetScale.ToStepValue() : "$",
                TargetView.ToStepValue(),
                UserDefinedTargetView != null ? UserDefinedTargetView.ToStepValue() : "$"
            };

            return string.Join(", ", parameters.ToArray());
        }
    }
}