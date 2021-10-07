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
namespace Integraph.Models.Ifc4.GeometryResource
{
	public partial class IfcRationalBSplineCurveWithKnots : IExpressValidatable
	{
		public enum IfcRationalBSplineCurveWithKnotsClause
		{
			SameNumOfWeightsAndPoints,
			WeightsGreaterZero,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcRationalBSplineCurveWithKnotsClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcRationalBSplineCurveWithKnotsClause.SameNumOfWeightsAndPoints:
						retVal = Functions.SIZEOF(WeightsData) == Functions.SIZEOF(this/* as IfcBSplineCurve*/.ControlPointsList);
						break;
					case IfcRationalBSplineCurveWithKnotsClause.WeightsGreaterZero:
						retVal = Functions.IfcCurveWeightsPositive(this);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometryResource.IfcRationalBSplineCurveWithKnots>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcRationalBSplineCurveWithKnots.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcRationalBSplineCurveWithKnotsClause.SameNumOfWeightsAndPoints))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBSplineCurveWithKnots.SameNumOfWeightsAndPoints", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcRationalBSplineCurveWithKnotsClause.WeightsGreaterZero))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcRationalBSplineCurveWithKnots.WeightsGreaterZero", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
