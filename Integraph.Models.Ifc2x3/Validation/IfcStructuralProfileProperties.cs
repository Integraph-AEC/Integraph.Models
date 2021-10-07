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
namespace Integraph.Models.Ifc2x3.ProfilePropertyResource
{
	public partial class IfcStructuralProfileProperties : IExpressValidatable
	{
		public enum IfcStructuralProfilePropertiesClause
		{
			WR21,
			WR22,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStructuralProfilePropertiesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStructuralProfilePropertiesClause.WR21:
						retVal = !(Functions.EXISTS(ShearDeformationAreaY)) || (ShearDeformationAreaY >= 0);
						break;
					case IfcStructuralProfilePropertiesClause.WR22:
						retVal = !(Functions.EXISTS(ShearDeformationAreaZ)) || (ShearDeformationAreaZ >= 0);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ProfilePropertyResource.IfcStructuralProfileProperties>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStructuralProfileProperties.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public override IEnumerable<ValidationResult> Validate()
		{
			foreach (var value in base.Validate())
			{
				yield return value;
			}
			if (!ValidateClause(IfcStructuralProfilePropertiesClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralProfileProperties.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcStructuralProfilePropertiesClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStructuralProfileProperties.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
