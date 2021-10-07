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
namespace Integraph.Models.Ifc2x3.SharedBldgElements
{
	public partial class IfcWindowLiningProperties : IExpressValidatable
	{
		public enum IfcWindowLiningPropertiesClause
		{
			WR31,
			WR32,
			WR33,
			WR34,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcWindowLiningPropertiesClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcWindowLiningPropertiesClause.WR31:
						retVal = !(!(Functions.EXISTS(LiningDepth)) && Functions.EXISTS(LiningThickness));
						break;
					case IfcWindowLiningPropertiesClause.WR32:
						retVal = !(!(Functions.EXISTS(FirstTransomOffset)) && Functions.EXISTS(SecondTransomOffset));
						break;
					case IfcWindowLiningPropertiesClause.WR33:
						retVal = !(!(Functions.EXISTS(FirstMullionOffset)) && Functions.EXISTS(SecondMullionOffset));
						break;
					case IfcWindowLiningPropertiesClause.WR34:
						retVal = Functions.EXISTS(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)) && (Functions.TYPEOF(this/* as IfcPropertySetDefinition*/.DefinesType.ItemAt(0)).Contains("IFC2X3.IFCWINDOWSTYLE"));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.SharedBldgElements.IfcWindowLiningProperties>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcWindowLiningProperties.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcWindowLiningPropertiesClause.WR31))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWindowLiningProperties.WR31", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcWindowLiningPropertiesClause.WR32))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWindowLiningProperties.WR32", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcWindowLiningPropertiesClause.WR33))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWindowLiningProperties.WR33", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcWindowLiningPropertiesClause.WR34))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcWindowLiningProperties.WR34", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
