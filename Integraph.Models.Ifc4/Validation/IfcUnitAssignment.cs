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
	public partial class IfcUnitAssignment : IExpressValidatable
	{
		public enum IfcUnitAssignmentClause
		{
			WR01,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcUnitAssignmentClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcUnitAssignmentClause.WR01:
						retVal = Functions.IfcCorrectUnitAssignment(Units);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.MeasureResource.IfcUnitAssignment>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcUnitAssignment.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcUnitAssignmentClause.WR01))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUnitAssignment.WR01", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
