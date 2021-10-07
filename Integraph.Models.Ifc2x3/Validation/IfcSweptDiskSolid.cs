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
namespace Integraph.Models.Ifc2x3.GeometricModelResource
{
	public partial class IfcSweptDiskSolid : IExpressValidatable
	{
		public enum IfcSweptDiskSolidClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSweptDiskSolidClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSweptDiskSolidClause.WR1:
						retVal = Directrix.Dim == 3;
						break;
					case IfcSweptDiskSolidClause.WR2:
						retVal = (!Functions.EXISTS(InnerRadius)) || (Radius > InnerRadius);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometricModelResource.IfcSweptDiskSolid>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSweptDiskSolid.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcSweptDiskSolidClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSweptDiskSolid.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSweptDiskSolidClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSweptDiskSolid.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
