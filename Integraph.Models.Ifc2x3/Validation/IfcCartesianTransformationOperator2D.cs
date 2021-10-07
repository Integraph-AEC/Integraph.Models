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
	public partial class IfcCartesianTransformationOperator2D : IExpressValidatable
	{
		public enum IfcCartesianTransformationOperator2DClause
		{
			WR1,
			WR2,
			WR3,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCartesianTransformationOperator2DClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCartesianTransformationOperator2DClause.WR1:
						retVal = this/* as IfcCartesianTransformationOperator*/.Dim == 2;
						break;
					case IfcCartesianTransformationOperator2DClause.WR2:
						retVal = !(Functions.EXISTS(this/* as IfcCartesianTransformationOperator*/.Axis1)) || (this/* as IfcCartesianTransformationOperator*/.Axis1.Dim == 2);
						break;
					case IfcCartesianTransformationOperator2DClause.WR3:
						retVal = !(Functions.EXISTS(this/* as IfcCartesianTransformationOperator*/.Axis2)) || (this/* as IfcCartesianTransformationOperator*/.Axis2.Dim == 2);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.GeometryResource.IfcCartesianTransformationOperator2D>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCartesianTransformationOperator2D.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcCartesianTransformationOperator2DClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCartesianTransformationOperator2D.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCartesianTransformationOperator2DClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCartesianTransformationOperator2D.WR2", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCartesianTransformationOperator2DClause.WR3))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCartesianTransformationOperator2D.WR3", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
