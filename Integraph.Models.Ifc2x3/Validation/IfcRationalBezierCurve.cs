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
	public partial class IfcRationalBezierCurve : IExpressValidatable
	{
		public enum IfcRationalBezierCurveClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRationalBezierCurveClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRationalBezierCurveClause.WR1:
						retVal = Functions.SIZEOF(WeightsData) == Functions.SIZEOF(this/* as IfcBSplineCurve*/.ControlPointsList);
						break;
					case IfcRationalBezierCurveClause.WR2:
						retVal = Functions.IfcCurveWeightsPositive(this);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometryResource.IfcRationalBezierCurve>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRationalBezierCurve.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRationalBezierCurveClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBezierCurve.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRationalBezierCurveClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBezierCurve.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
