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
	public partial class IfcDraughtingPreDefinedCurveFont : IExpressValidatable
	{
		public enum IfcDraughtingPreDefinedCurveFontClause
		{
			PreDefinedCurveFontNames,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDraughtingPreDefinedCurveFontClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDraughtingPreDefinedCurveFontClause.PreDefinedCurveFontNames:
						retVal = Functions.NewTypesArray("continuous", "chain", "chain double dash", "dashed", "dotted", "by layer").Contains(this/* as IfcPredefinedItem*/.Name);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.PresentationAppearanceResource.IfcDraughtingPreDefinedCurveFont>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDraughtingPreDefinedCurveFont.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcDraughtingPreDefinedCurveFontClause.PreDefinedCurveFontNames))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDraughtingPreDefinedCurveFont.PreDefinedCurveFontNames", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
