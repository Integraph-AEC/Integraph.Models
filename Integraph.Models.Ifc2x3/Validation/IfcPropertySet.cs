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
namespace Integraph.Models.Ifc2x3.Kernel
{
	public partial class IfcPropertySet : IExpressValidatable
	{
		public enum IfcPropertySetClause
		{
			WR31,
			WR32,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcPropertySetClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcPropertySetClause.WR31:
						retVal = Functions.EXISTS(this/* as IfcRoot*/.Name);
						break;
					case IfcPropertySetClause.WR32:
						retVal = Functions.IfcUniquePropertyName(HasProperties);
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.Kernel.IfcPropertySet>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcPropertySet.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcPropertySetClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPropertySet.WR31", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcPropertySetClause.WR32))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcPropertySet.WR32", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
