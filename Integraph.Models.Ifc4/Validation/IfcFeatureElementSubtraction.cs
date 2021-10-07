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
namespace Integraph.Models.Ifc4.ProductExtension
{
	public partial class IfcFeatureElementSubtraction : IExpressValidatable
	{
		public enum IfcFeatureElementSubtractionClause
		{
			HasNoSubtraction,
			IsNotFilling,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcFeatureElementSubtractionClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcFeatureElementSubtractionClause.HasNoSubtraction:
						retVal = Functions.SIZEOF(this/* as IfcElement*/.HasOpenings) == 0;
						break;
					case IfcFeatureElementSubtractionClause.IsNotFilling:
						retVal = Functions.SIZEOF(this/* as IfcElement*/.FillsVoids) == 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProductExtension.IfcFeatureElementSubtraction>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcFeatureElementSubtraction.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcFeatureElementSubtractionClause.HasNoSubtraction))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFeatureElementSubtraction.HasNoSubtraction", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcFeatureElementSubtractionClause.IsNotFilling))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcFeatureElementSubtraction.IsNotFilling", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
