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
namespace Integraph.Models.Ifc4.DateTimeResource
{
	public partial struct IfcDayInWeekNumber : IExpressValidatable
	{
		public enum IfcDayInWeekNumberClause
		{
			ValidRange,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcDayInWeekNumberClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcDayInWeekNumberClause.ValidRange:
						retVal = ((1 <= this) && (this <= 7) );
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.DateTimeResource.IfcDayInWeekNumber>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcDayInWeekNumber.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcDayInWeekNumberClause.ValidRange))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcDayInWeekNumber.ValidRange", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
