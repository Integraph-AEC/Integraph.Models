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
namespace Integraph.Models.Ifc2x3.MaterialPropertyResource
{
	public partial class IfcMechanicalMaterialProperties : IExpressValidatable
	{
		public enum IfcMechanicalMaterialPropertiesClause
		{
			WR21,
			WR22,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcMechanicalMaterialPropertiesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcMechanicalMaterialPropertiesClause.WR21:
						retVal = !(Functions.EXISTS(YoungModulus)) || (YoungModulus >= 0);
						break;
					case IfcMechanicalMaterialPropertiesClause.WR22:
						retVal = !(Functions.EXISTS(ShearModulus)) || (ShearModulus >= 0);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.MaterialPropertyResource.IfcMechanicalMaterialProperties>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcMechanicalMaterialProperties.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcMechanicalMaterialPropertiesClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcMechanicalMaterialProperties.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcMechanicalMaterialPropertiesClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcMechanicalMaterialProperties.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
