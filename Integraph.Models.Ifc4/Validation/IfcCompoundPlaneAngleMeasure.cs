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
	public partial struct IfcCompoundPlaneAngleMeasure : IExpressValidatable
	{
		public enum IfcCompoundPlaneAngleMeasureClause
		{
			MinutesInRange,
			SecondsInRange,
			MicrosecondsInRange,
			ConsistentSign,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCompoundPlaneAngleMeasureClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCompoundPlaneAngleMeasureClause.MinutesInRange:
						retVal = Functions.ABS(this.ItemAt(1)) < 60;
						break;
					case IfcCompoundPlaneAngleMeasureClause.SecondsInRange:
						retVal = Functions.ABS(this.ItemAt(2)) < 60;
						break;
					case IfcCompoundPlaneAngleMeasureClause.MicrosecondsInRange:
						retVal = (Functions.SIZEOF(this) == 3) || (Functions.ABS(this.ItemAt(3)) < 1000000);
						break;
					case IfcCompoundPlaneAngleMeasureClause.ConsistentSign:
						retVal = ((this.ItemAt(0) >= 0) && (this.ItemAt(1) >= 0) && (this.ItemAt(2) >= 0) && ((Functions.SIZEOF(this) == 3) || (this.ItemAt(3) >= 0))) || ((this.ItemAt(0) <= 0) && (this.ItemAt(1) <= 0) && (this.ItemAt(2) <= 0) && ((Functions.SIZEOF(this) == 3) || (this.ItemAt(3) <= 0)));
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.MeasureResource.IfcCompoundPlaneAngleMeasure>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCompoundPlaneAngleMeasure.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.MinutesInRange))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.MinutesInRange", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.SecondsInRange))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.SecondsInRange", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.MicrosecondsInRange))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.MicrosecondsInRange", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.ConsistentSign))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.ConsistentSign", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
