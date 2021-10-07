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
namespace Integraph.Models.Ifc4.ConstraintResource
{
	public partial class IfcConstraint : IExpressValidatable
	{
		public enum IfcConstraintClause
		{
			WR11,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcConstraintClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcConstraintClause.WR11:
						retVal = (ConstraintGrade != IfcConstraintEnum.USERDEFINED) || ((ConstraintGrade == IfcConstraintEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcConstraint*/.UserDefinedGrade));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ConstraintResource.IfcConstraint>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcConstraint.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcConstraintClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcConstraint.WR11", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
