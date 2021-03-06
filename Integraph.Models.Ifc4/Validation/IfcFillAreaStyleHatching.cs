using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc4.Interfaces;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc4.PresentationAppearanceResource
{
	public partial class IfcFillAreaStyleHatching : IExpressValidatable
	{
		public enum IfcFillAreaStyleHatchingClause
		{
			PatternStart2D,
			RefHatchLine2D,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcFillAreaStyleHatchingClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcFillAreaStyleHatchingClause.PatternStart2D:
						retVal = !(Functions.EXISTS(PatternStart)) || (PatternStart.Dim == 2);
						break;
					case IfcFillAreaStyleHatchingClause.RefHatchLine2D:
						retVal = !(Functions.EXISTS(PointOfReferenceHatchLine)) || (PointOfReferenceHatchLine.Dim == 2);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.PresentationAppearanceResource.IfcFillAreaStyleHatching>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcFillAreaStyleHatching.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcFillAreaStyleHatchingClause.PatternStart2D))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFillAreaStyleHatching.PatternStart2D", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcFillAreaStyleHatchingClause.RefHatchLine2D))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFillAreaStyleHatching.RefHatchLine2D", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
