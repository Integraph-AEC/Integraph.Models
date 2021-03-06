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
namespace Integraph.Models.Ifc4.QuantityResource
{
	public partial class IfcQuantityCount : IExpressValidatable
	{
		public enum IfcQuantityCountClause
		{
			WR21,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcQuantityCountClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcQuantityCountClause.WR21:
						retVal = CountValue >= 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.QuantityResource.IfcQuantityCount>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcQuantityCount.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcQuantityCountClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcQuantityCount.WR21", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
