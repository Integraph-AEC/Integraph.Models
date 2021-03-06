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
	public partial class IfcCartesianTransformationOperator3DnonUniform : IExpressValidatable
	{
		public enum IfcCartesianTransformationOperator3DnonUniformClause
		{
			Scale2GreaterZero,
			Scale3GreaterZero,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCartesianTransformationOperator3DnonUniformClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCartesianTransformationOperator3DnonUniformClause.Scale2GreaterZero:
						retVal = Scl2 > 0;
						break;
					case IfcCartesianTransformationOperator3DnonUniformClause.Scale3GreaterZero:
						retVal = Scl3 > 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometryResource.IfcCartesianTransformationOperator3DnonUniform>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCartesianTransformationOperator3DnonUniform.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcCartesianTransformationOperator3DnonUniformClause.Scale2GreaterZero))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCartesianTransformationOperator3DnonUniform.Scale2GreaterZero", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCartesianTransformationOperator3DnonUniformClause.Scale3GreaterZero))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCartesianTransformationOperator3DnonUniform.Scale3GreaterZero", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
