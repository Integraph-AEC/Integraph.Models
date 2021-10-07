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
namespace Integraph.Models.Ifc2x3.ProfileResource
{
	public partial class IfcUShapeProfileDef : IExpressValidatable
	{
		public enum IfcUShapeProfileDefClause
		{
			WR21,
			WR22,
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
					case IfcUShapeProfileDefClause.WR21:
						retVal = FlangeThickness < (Depth / 2);
						break;
					case IfcUShapeProfileDefClause.WR22:
						retVal = WebThickness < FlangeWidth;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ProfileResource.IfcUShapeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcUShapeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcUShapeProfileDefClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUShapeProfileDef.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcUShapeProfileDefClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcUShapeProfileDef.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
