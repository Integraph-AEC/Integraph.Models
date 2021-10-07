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
	public partial class IfcTShapeProfileDef : IExpressValidatable
	{
		public enum IfcTShapeProfileDefClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcTShapeProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcTShapeProfileDefClause.WR1:
						retVal = FlangeThickness < Depth;
						break;
					case IfcTShapeProfileDefClause.WR2:
						retVal = WebThickness < FlangeWidth;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ProfileResource.IfcTShapeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcTShapeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcTShapeProfileDefClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTShapeProfileDef.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcTShapeProfileDefClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcTShapeProfileDef.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
