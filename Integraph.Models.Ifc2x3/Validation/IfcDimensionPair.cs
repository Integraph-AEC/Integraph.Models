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
namespace Integraph.Models.Ifc2x3.PresentationDimensioningResource
{
	public partial class IfcDimensionPair : IExpressValidatable
	{
		public enum IfcDimensionPairClause
		{
			WR11,
			WR12,
			WR13,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDimensionPairClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDimensionPairClause.WR11:
						retVal = Functions.NewArray("chained", "parallel").Contains(this.Name);
						break;
					case IfcDimensionPairClause.WR12:
						retVal = Functions.SIZEOF(Functions.TYPEOF(this.RelatingDraughtingCallout) * Functions.NewArray("IFC2X3.IFCANGULARDIMENSION", "IFC2X3.IFCDIAMETERDIMENSION", "IFC2X3.IFCLINEARDIMENSION", "IFC2X3.IFCRADIUSDIMENSION")) == 1;
						break;
					case IfcDimensionPairClause.WR13:
						retVal = Functions.SIZEOF(Functions.TYPEOF(this.RelatedDraughtingCallout) * Functions.NewArray("IFC2X3.IFCANGULARDIMENSION", "IFC2X3.IFCDIAMETERDIMENSION", "IFC2X3.IFCLINEARDIMENSION", "IFC2X3.IFCRADIUSDIMENSION")) == 1;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationDimensioningResource.IfcDimensionPair>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDimensionPair.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcDimensionPairClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDimensionPair.WR11", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcDimensionPairClause.WR12))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDimensionPair.WR12", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcDimensionPairClause.WR13))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDimensionPair.WR13", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
