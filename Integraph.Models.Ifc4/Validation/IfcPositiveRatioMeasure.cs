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
	public partial struct IfcPositiveRatioMeasure : IExpressValidatable
	{
		public enum IfcPositiveRatioMeasureClause
		{
			WR1,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPositiveRatioMeasureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPositiveRatioMeasureClause.WR1:
						retVal = this > 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.MeasureResource.IfcPositiveRatioMeasure>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPositiveRatioMeasure.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPositiveRatioMeasureClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPositiveRatioMeasure.WR1", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
