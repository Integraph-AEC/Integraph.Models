using System;
using Microsoft.Extensions.Logging;
using Integraph.Models.Common;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Integraph.Models.Common.Enumerations;
using Integraph.Models.Common.ExpressValidation;
using Integraph.Models.Ifc2x3.MeasureResource;
using Integraph.Models.Ifc2x3.Interfaces;
using Integraph.Models.Ifc2x3.Kernel;
using Integraph.Models.Ifc2x3.ProfileResource;
using Integraph.Models.Ifc2x3.ProfilePropertyResource;
// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming
namespace Integraph.Models.Ifc2x3.MeasureResource
{
	public partial struct IfcCompoundPlaneAngleMeasure : IExpressValidatable
	{
		public enum IfcCompoundPlaneAngleMeasureClause
		{
			WR1,
			WR2,
			WR3,
			WR4,
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
					case IfcCompoundPlaneAngleMeasureClause.WR1:
						retVal = ((-360 <= this.ItemAt(0)) && (this.ItemAt(0) < 360) );
						break;
					case IfcCompoundPlaneAngleMeasureClause.WR2:
						retVal = ((-60 <= this.ItemAt(1)) && (this.ItemAt(1) < 60) );
						break;
					case IfcCompoundPlaneAngleMeasureClause.WR3:
						retVal = ((-60 <= this.ItemAt(2)) && (this.ItemAt(2) < 60) );
						break;
					case IfcCompoundPlaneAngleMeasureClause.WR4:
						retVal = ((this.ItemAt(0) >= 0) && (this.ItemAt(1) >= 0) && (this.ItemAt(2) >= 0)) || ((this.ItemAt(0) <= 0) && (this.ItemAt(1) <= 0) && (this.ItemAt(2) <= 0));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.MeasureResource.IfcCompoundPlaneAngleMeasure>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCompoundPlaneAngleMeasure.{0}'.", clause), ex);
			}
			return retVal;
		}

		public IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.WR2", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.WR3))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.WR3", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompoundPlaneAngleMeasureClause.WR4))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompoundPlaneAngleMeasure.WR4", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
