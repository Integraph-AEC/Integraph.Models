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
namespace Integraph.Models.Ifc4.GeometricModelResource
{
	public partial class IfcExtrudedAreaSolid : IExpressValidatable
	{
		public enum IfcExtrudedAreaSolidClause
		{
			ValidExtrusionDirection,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcExtrudedAreaSolidClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcExtrudedAreaSolidClause.ValidExtrusionDirection:
						retVal = Functions.IfcDotProduct(Functions.IfcDirection(0, 0, 1), this.ExtrudedDirection) != 0;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.GeometricModelResource.IfcExtrudedAreaSolid>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcExtrudedAreaSolid.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcExtrudedAreaSolidClause.ValidExtrusionDirection))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcExtrudedAreaSolid.ValidExtrusionDirection", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
