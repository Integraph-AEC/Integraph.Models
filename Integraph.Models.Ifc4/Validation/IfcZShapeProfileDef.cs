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
namespace Integraph.Models.Ifc4.ProfileResource
{
	public partial class IfcZShapeProfileDef : IExpressValidatable
	{
		public enum IfcZShapeProfileDefClause
		{
			ValidFlangeThickness,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcZShapeProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcZShapeProfileDefClause.ValidFlangeThickness:
						retVal = FlangeThickness < (Depth / 2);
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProfileResource.IfcZShapeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcZShapeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcZShapeProfileDefClause.ValidFlangeThickness))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcZShapeProfileDef.ValidFlangeThickness", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
