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
	public partial class IfcCompositeProfileDef : IExpressValidatable
	{
		public enum IfcCompositeProfileDefClause
		{
			WR1,
			WR2,
		}

		/// <summary>
		/// Tests the express where-clause specified in param 'clause'
		/// </summary>
		/// <param name="clause">The express clause to test</param>
		/// <returns>true if the clause is satisfied.</returns>
		public bool ValidateClause(IfcCompositeProfileDefClause clause) {
			var retVal = false;
			try
			{
				switch (clause)
				{
					case IfcCompositeProfileDefClause.WR1:
						retVal = Functions.SIZEOF(Profiles.Where(temp => temp.ProfileType != Profiles.ItemAt(0).ProfileType)) == 0;
						break;
					case IfcCompositeProfileDefClause.WR2:
						retVal = Functions.SIZEOF(Profiles.Where(temp => Functions.TYPEOF(temp).Contains("IFC2X3.IFCCOMPOSITEPROFILEDEF"))) == 0;
						break;
				}
			} catch (Exception ex) {
				var log = Validation.ValidationLogging.CreateLogger<Integraph.Models.Ifc2x3.ProfileResource.IfcCompositeProfileDef>();
				log?.LogError(string.Format("Exception thrown evaluating where-clause 'IfcCompositeProfileDef.{0}' for #{1}.", clause,EntityLabel), ex);
			}
			return retVal;
		}

		public virtual IEnumerable<ValidationResult> Validate()
		{
			if (!ValidateClause(IfcCompositeProfileDefClause.WR1))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeProfileDef.WR1", IssueType = ValidationFlags.EntityWhereClauses };
			if (!ValidateClause(IfcCompositeProfileDefClause.WR2))
				yield return new ValidationResult() { Item = this, IssueSource = "IfcCompositeProfileDef.WR2", IssueType = ValidationFlags.EntityWhereClauses };
		}
	}
}
