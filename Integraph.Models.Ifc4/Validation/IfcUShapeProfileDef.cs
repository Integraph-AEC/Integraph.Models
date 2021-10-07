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
	public partial class IfcUShapeProfileDef : IExpressValidatable
	{
		public enum IfcUShapeProfileDefClause
		{
			ValidFlangeThickness,
			ValidWebThickness,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcUShapeProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcUShapeProfileDefClause.ValidFlangeThickness:
						retVal = FlangeThickness < (Depth / 2);
						break;
					case IfcUShapeProfileDefClause.ValidWebThickness:
						retVal = WebThickness < FlangeWidth;
						break;
				}
			} catch (Exception  ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc4.ProfileResource.IfcUShapeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcUShapeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcUShapeProfileDefClause.ValidFlangeThickness))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUShapeProfileDef.ValidFlangeThickness", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcUShapeProfileDefClause.ValidWebThickness))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUShapeProfileDef.ValidWebThickness", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
