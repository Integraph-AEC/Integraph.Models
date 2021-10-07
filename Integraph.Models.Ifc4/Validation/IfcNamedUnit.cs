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
namespace Integraph.Models.Ifc4.MeasureResource
{
	public partial class IfcNamedUnit : IExpressValidatable
	{
		public enum IfcNamedUnitClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcNamedUnitClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcNamedUnitClause.WR1:
						retVal = Functions.IfcCorrectDimensions(this.UnitType, this.Dimensions);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.MeasureResource.IfcNamedUnit>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcNamedUnit.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcNamedUnitClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcNamedUnit.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
