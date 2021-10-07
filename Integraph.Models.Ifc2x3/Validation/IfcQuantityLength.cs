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
namespace Integraph.Models.Ifc2x3.QuantityResource
{
	public partial class IfcQuantityLength : IExpressValidatable
	{
		public enum IfcQuantityLengthClause
		{
			WR21,
			WR22,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcQuantityLengthClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcQuantityLengthClause.WR21:
						retVal = !(Functions.EXISTS(this/* as IfcPhysicalSimpleQuantity*/.Unit)) || (this/* as IfcPhysicalSimpleQuantity*/.Unit.UnitType == IfcUnitEnum.LENGTHUNIT);
						break;
					case IfcQuantityLengthClause.WR22:
						retVal = LengthValue >= 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.QuantityResource.IfcQuantityLength>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcQuantityLength.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcQuantityLengthClause.WR21))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcQuantityLength.WR21", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcQuantityLengthClause.WR22))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcQuantityLength.WR22", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
