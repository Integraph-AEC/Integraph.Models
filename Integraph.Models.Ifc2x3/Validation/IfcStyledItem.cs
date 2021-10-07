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
namespace Integraph.Models.Ifc2x3.PresentationAppearanceResource
{
	public partial class IfcStyledItem : IExpressValidatable
	{
		public enum IfcStyledItemClause
		{
			WR11,
			WR12,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcStyledItemClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcStyledItemClause.WR11:
						retVal = Functions.SIZEOF(Styles) == 1;
						break;
					case IfcStyledItemClause.WR12:
						retVal = !(Functions.TYPEOF(Item).Contains("IFC2X3.IFCSTYLEDITEM"));
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.PresentationAppearanceResource.IfcStyledItem>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcStyledItem.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcStyledItemClause.WR11))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStyledItem.WR11", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcStyledItemClause.WR12))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcStyledItem.WR12", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
