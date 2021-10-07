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
namespace Integraph.Models.Ifc2x3.GeometryResource
{
	public partial class IfcSweptSurface : IExpressValidatable
	{
		public enum IfcSweptSurfaceClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcSweptSurfaceClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcSweptSurfaceClause.WR1:
						retVal = !(Functions.TYPEOF(SweptCurve).Contains("IFC2X3.IFCDERIVEDPROFILEDEF"));
						break;
					case IfcSweptSurfaceClause.WR2:
						retVal = SweptCurve.ProfileType == IfcProfileTypeEnum.CURVE;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometryResource.IfcSweptSurface>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcSweptSurface.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcSweptSurfaceClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSweptSurface.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcSweptSurfaceClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcSweptSurface.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
