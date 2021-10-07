using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.ProfileResource;
using Integraph.Models.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc2x3.PresentationDefinitionResource
{
	public partial class IfcAnnotationSurfaceOccurrence : IExpressValidatable
	{
		public enum IfcAnnotationSurfaceOccurrenceClause
		{
			WR31,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcAnnotationSurfaceOccurrenceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcAnnotationSurfaceOccurrenceClause.WR31:
						retVal = !(Functions.EXISTS(this/* as IfcStyledItem*/.Item)) || (Functions.SIZEOF(Functions.NewArray("IFC2X3.IFCSURFACE", "IFC2X3.IFCFACEBASEDSURFACEMODEL", "IFC2X3.IFCSHELLBASEDSURFACEMODEL", "IFC2X3.IFCSOLIDMODEL") * Functions.TYPEOF(this/* as IfcStyledItem*/.Item)) > 0);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationDefinitionResource.IfcAnnotationSurfaceOccurrence>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcAnnotationSurfaceOccurrence.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcAnnotationSurfaceOccurrenceClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcAnnotationSurfaceOccurrence.WR31", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
