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
	public partial class IfcObjective : IExpressValidatable
	{
		public enum IfcObjectiveClause
		{
			WR21,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcObjectiveClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcObjectiveClause.WR21:
						retVal = (ObjectiveQualifier != IfcObjectiveEnum.USERDEFINED) || ((ObjectiveQualifier == IfcObjectiveEnum.USERDEFINED) && Functions.EXISTS(this/* as IfcObjective*/.UserDefinedQualifier));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ConstraintResource.IfcObjective>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcObjective.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcObjectiveClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcObjective.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
